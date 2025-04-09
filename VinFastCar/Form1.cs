using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace VinFastCar;

public partial class Form1 : Form
{
    private int page = 0;
    private double sumKWh = 0;
    private double sumTotal = 0;
    private double sumDiscount = 0;
    private double sumPaid = 0;
    private int countList = 0;
    private long firstDate = 0;
    private long lastDate = 0;
    private string _token = "";

    public Form1()
    {
        InitializeComponent();
        // set dtStart is 2000
        dtStart.Value = new DateTime(2000, 1, 1);
        Run();
    }

    public Form1(string tolken)
    {
        InitializeComponent();
        _token = tolken;
        // set dtStart is 2000
        dtStart.Value = new DateTime(2000, 1, 1);
        Run();
    }

    private async void btnTraCuu_Click(object sender, EventArgs e)
    {
        ResetUI();
        await GetHistoryAsync(0);
    }

    async void Run()
    {
        ResetUI();
        await GetHistoryAsync(0);
    }

    private void ResetUI()
    {
        page = 0;
        sumKWh = sumTotal = sumDiscount = sumPaid = 0;
        countList = 0;
        dataGrid.Rows.Clear();
        lblResult.Text = "Bắt đầu tải dữ liệu...";
    }

    private async Task GetHistoryAsync(int targetPage)
    {
        lblResult.Text = $"Đang tải dữ liệu trang {targetPage + 1}";

        using var client = new HttpClient();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri($"https://mobile.connected-car.vinfast.vn/ccarcharging/api/v1/charging-sessions/search?page={targetPage}&size=20"),
            Content = new StringContent("{\"orderStatus\":[3,5,7]}", Encoding.UTF8, "application/json")
        };

        request.Headers.Host = "mobile.connected-car.vinfast.vn";
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        request.Headers.TryAddWithoutValidation("x-device-platform", "iPhone 14 Pro Max");
        request.Headers.TryAddWithoutValidation("x-device-os-version", "18.4");
        request.Headers.TryAddWithoutValidation("authorization", "Bearer "+ _token + "");
        request.Headers.TryAddWithoutValidation("x-timezone", "Asia/Ho_Chi_Minh");
        request.Headers.TryAddWithoutValidation("x-device-locale", "vi_VN");
        request.Headers.TryAddWithoutValidation("x-vin-code", "RLLVAG8C4RH714650");
        request.Headers.TryAddWithoutValidation("x-player-identifier", "trandoducnghia@gmail.com");
        request.Headers.TryAddWithoutValidation("accept-language", "vi-VN;q=1.0, en-VN;q=0.9");
        request.Headers.TryAddWithoutValidation("x-device-family", "iPhone 14 Pro Max");
        request.Headers.TryAddWithoutValidation("x-service-name", "CAPP");
        request.Headers.TryAddWithoutValidation("x-device-identifier", "F00C4D95-3A3E-48E0-AD02-B52319C3C53A");
        request.Headers.TryAddWithoutValidation("user-agent", "iOS - F00C4D95-3A3E-48E0-AD02-B52319C3C53A - 2.4.4");
        request.Headers.TryAddWithoutValidation("x-app-version", "2.4.4");
        request.Headers.TryAddWithoutValidation("connection", "keep-alive");

        var response = await client.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<ApiResponse>(content);

        if (result?.code != 200000 || result.data == null)
        {
            MessageBox.Show("Lỗi khi lấy dữ liệu. Vui lòng thử lại.");
            return;
        }

        var vinFilter = txtVin.Text.Trim().ToUpper();
        long? startTimestamp = dtStart.Checked ? new DateTimeOffset(dtStart.Value).ToUnixTimeMilliseconds() : null;
        long? endTimestamp = dtEnd.Checked ? new DateTimeOffset(dtEnd.Value).ToUnixTimeMilliseconds() : null;

        foreach (var e in result.data)
        {
            if (!string.IsNullOrEmpty(vinFilter) && vinFilter != e.vehicleId.ToUpper())
                continue;

            if (startTimestamp.HasValue && e.startChargeTime < startTimestamp.Value)
                continue;
            if (endTimestamp.HasValue && e.endChargeTime > endTimestamp.Value)
                continue;

            string timeRange = $"{ConvertTimestamp(e.startChargeTime)} - {ConvertTimestamp(e.endChargeTime)}";
            string location = $"{e.chargingStationName} - {e.chargingStationAddress}, {e.district}, {e.province}";

            double price = e.items?.FirstOrDefault(x => x.price.HasValue)?.price ?? 0;
            double engy = 0;
            if (e.items.Count >= 1)
            {
                foreach (var t in e.items)
                {
                    if (t.energy is not null)
                    {
                        engy += t.energy.Value;
                    }
                }
            }

            sumKWh += engy;
            sumTotal += e.amount;
            sumDiscount += e.discount;
            sumPaid += e.finalAmount;
            countList++;

            dataGrid.Rows.Add(timeRange, e.vehicleId, e.totalKWCharged, FormatNumber(price), FormatNumber(e.amount), FormatNumber(e.discount), FormatNumber(e.finalAmount), location);

            firstDate = firstDate == 0 ? e.startChargeTime : Math.Min(firstDate, e.startChargeTime);
            lastDate = Math.Max(lastDate, e.endChargeTime);
        }

        // Update UI summary
        lblSumKWh.Text = $"{sumKWh:F2}" + " kWh";
        lblTotal.Text = FormatNumber(sumTotal) + " VNĐ";
        lblDiscount.Text = FormatNumber(sumDiscount) + " VNĐ KM";
        lblPaid.Text = FormatNumber(sumPaid) + " VNĐ cần trả";
        lblCount.Text = countList.ToString() + " lần sạc";

        lblResult.Text = $"Đã tải xong dữ liệu trang {targetPage + 1}";

        if (result.data.Count > 0)
        {
            page++;
            await GetHistoryAsync(page); // Đệ quy
        }
        else
        {
            lblResult.Text = "Đã tải toàn bộ dữ liệu.";
        }
    }

    private string ConvertTimestamp(long timestamp)
    {
        var date = DateTimeOffset.FromUnixTimeMilliseconds(timestamp).ToLocalTime().DateTime;
        return date.ToString("HH:mm dd/MM/yyyy");
    }

    private string FormatNumber(double num) =>
        string.Format("{0:n0}", num);

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnTraCuu_Click_1(object sender, EventArgs e)
    {
        btnTraCuu_Click(sender, e);
    }
}

public class ApiResponse
{
    public int code { get; set; }
    public List<ChargingSession> data { get; set; }
}

public class ChargingSession
{
    public string vehicleId { get; set; }
    public long startChargeTime { get; set; }
    public long endChargeTime { get; set; }
    public List<ChargeItem> items { get; set; }
    public string totalKWCharged { get; set; }
    public double amount { get; set; }
    public double discount { get; set; }
    public double finalAmount { get; set; }
    public string chargingStationName { get; set; }
    public string chargingStationAddress { get; set; }
    public string district { get; set; }
    public string province { get; set; }
}

public class ChargeItem
{
    public double? price { get; set; }
    public double? energy { get; set; }
    public double? cost { get; set; }
}