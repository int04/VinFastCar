namespace VinFastCar;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        panel1 = new Panel();
        lblResult = new Label();
        btnTraCuu = new Button();
        dtEnd = new DateTimePicker();
        dtStart = new DateTimePicker();
        txtVin = new TextBox();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        panel2 = new Panel();
        lblCount = new Label();
        lblPaid = new Label();
        lblDiscount = new Label();
        lblTotal = new Label();
        lblSumKWh = new Label();
        dataGrid = new DataGridView();
        thoigian = new DataGridViewTextBoxColumn();
        vin = new DataGridViewTextBoxColumn();
        nạp = new DataGridViewTextBoxColumn();
        gia = new DataGridViewTextBoxColumn();
        tổng = new DataGridViewTextBoxColumn();
        khuyenmai = new DataGridViewTextBoxColumn();
        thanhtoan = new DataGridViewTextBoxColumn();
        address = new DataGridViewTextBoxColumn();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.348F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.651996732F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(dataGrid, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4187584F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.5812454F));
        tableLayoutPanel1.Size = new Size(1251, 781);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.6171646F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.38284F));
        tableLayoutPanel2.Controls.Add(panel1, 0, 0);
        tableLayoutPanel2.Controls.Add(panel2, 1, 0);
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 94.28571F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.714286F));
        tableLayoutPanel2.Size = new Size(1212, 140);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(lblResult);
        panel1.Controls.Add(btnTraCuu);
        panel1.Controls.Add(dtEnd);
        panel1.Controls.Add(dtStart);
        panel1.Controls.Add(txtVin);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(862, 125);
        panel1.TabIndex = 0;
        // 
        // lblResult
        // 
        lblResult.AutoSize = true;
        lblResult.Location = new Point(414, 79);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(40, 20);
        lblResult.TabIndex = 7;
        lblResult.Text = "đợi...";
        // 
        // btnTraCuu
        // 
        btnTraCuu.Location = new Point(409, 12);
        btnTraCuu.Name = "btnTraCuu";
        btnTraCuu.Size = new Size(203, 45);
        btnTraCuu.TabIndex = 6;
        btnTraCuu.Text = "Lọc";
        btnTraCuu.UseVisualStyleBackColor = true;
        btnTraCuu.Click += btnTraCuu_Click_1;
        // 
        // dtEnd
        // 
        dtEnd.Location = new Point(77, 76);
        dtEnd.Name = "dtEnd";
        dtEnd.Size = new Size(284, 27);
        dtEnd.TabIndex = 5;
        // 
        // dtStart
        // 
        dtStart.Location = new Point(79, 38);
        dtStart.Name = "dtStart";
        dtStart.Size = new Size(282, 27);
        dtStart.TabIndex = 4;
        // 
        // txtVin
        // 
        txtVin.Location = new Point(77, 5);
        txtVin.Name = "txtVin";
        txtVin.Size = new Size(284, 27);
        txtVin.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 76);
        label3.Name = "label3";
        label3.Size = new Size(63, 20);
        label3.TabIndex = 2;
        label3.Text = "Kết thúc";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 37);
        label2.Name = "label2";
        label2.Size = new Size(63, 20);
        label2.TabIndex = 1;
        label2.Text = "Bắt đầu;";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 3);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 0;
        label1.Text = "Số vin:";
        // 
        // panel2
        // 
        panel2.Controls.Add(lblCount);
        panel2.Controls.Add(lblPaid);
        panel2.Controls.Add(lblDiscount);
        panel2.Controls.Add(lblTotal);
        panel2.Controls.Add(lblSumKWh);
        panel2.Location = new Point(871, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(338, 125);
        panel2.TabIndex = 1;
        // 
        // lblCount
        // 
        lblCount.AutoSize = true;
        lblCount.Location = new Point(260, 45);
        lblCount.Name = "lblCount";
        lblCount.Size = new Size(40, 20);
        lblCount.TabIndex = 12;
        lblCount.Text = "đợi...";
        // 
        // lblPaid
        // 
        lblPaid.AutoSize = true;
        lblPaid.Location = new Point(3, 95);
        lblPaid.Name = "lblPaid";
        lblPaid.Size = new Size(40, 20);
        lblPaid.TabIndex = 11;
        lblPaid.Text = "đợi...";
        // 
        // lblDiscount
        // 
        lblDiscount.AutoSize = true;
        lblDiscount.Location = new Point(3, 66);
        lblDiscount.Name = "lblDiscount";
        lblDiscount.Size = new Size(40, 20);
        lblDiscount.TabIndex = 10;
        lblDiscount.Text = "đợi...";
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Location = new Point(3, 37);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(40, 20);
        lblTotal.TabIndex = 9;
        lblTotal.Text = "đợi...";
        // 
        // lblSumKWh
        // 
        lblSumKWh.AutoSize = true;
        lblSumKWh.Location = new Point(3, 8);
        lblSumKWh.Name = "lblSumKWh";
        lblSumKWh.Size = new Size(40, 20);
        lblSumKWh.TabIndex = 8;
        lblSumKWh.Text = "đợi...";
        // 
        // dataGrid
        // 
        dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGrid.Columns.AddRange(new DataGridViewColumn[] { thoigian, vin, nạp, gia, tổng, khuyenmai, thanhtoan, address });
        dataGrid.Dock = DockStyle.Fill;
        dataGrid.Location = new Point(3, 154);
        dataGrid.Name = "dataGrid";
        dataGrid.RowHeadersWidth = 51;
        dataGrid.Size = new Size(1236, 624);
        dataGrid.TabIndex = 1;
        dataGrid.CellContentClick += dataGridView1_CellContentClick;
        // 
        // thoigian
        // 
        thoigian.HeaderText = "Thời gian";
        thoigian.MinimumWidth = 6;
        thoigian.Name = "thoigian";
        thoigian.Width = 125;
        // 
        // vin
        // 
        vin.HeaderText = "Số vin";
        vin.MinimumWidth = 6;
        vin.Name = "vin";
        vin.Width = 125;
        // 
        // nạp
        // 
        nạp.HeaderText = "nap";
        nạp.MinimumWidth = 6;
        nạp.Name = "nạp";
        nạp.Width = 125;
        // 
        // gia
        // 
        gia.HeaderText = "Giá 1kwh";
        gia.MinimumWidth = 6;
        gia.Name = "gia";
        gia.Width = 125;
        // 
        // tổng
        // 
        tổng.HeaderText = "tong";
        tổng.MinimumWidth = 6;
        tổng.Name = "tổng";
        tổng.Width = 125;
        // 
        // khuyenmai
        // 
        khuyenmai.HeaderText = "Khuyễn Mãi";
        khuyenmai.MinimumWidth = 6;
        khuyenmai.Name = "khuyenmai";
        khuyenmai.Width = 125;
        // 
        // thanhtoan
        // 
        thanhtoan.HeaderText = "T.Toán";
        thanhtoan.MinimumWidth = 6;
        thanhtoan.Name = "thanhtoan";
        thanhtoan.Width = 125;
        // 
        // address
        // 
        address.HeaderText = "Địa chỉ";
        address.MinimumWidth = 6;
        address.Name = "address";
        address.Width = 125;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1251, 781);
        Controls.Add(tableLayoutPanel1);
        Name = "Form1";
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private DataGridView dataGrid;
    private DataGridViewTextBoxColumn thoigian;
    private DataGridViewTextBoxColumn vin;
    private DataGridViewTextBoxColumn nạp;
    private DataGridViewTextBoxColumn gia;
    private DataGridViewTextBoxColumn tổng;
    private DataGridViewTextBoxColumn khuyenmai;
    private DataGridViewTextBoxColumn thanhtoan;
    private DataGridViewTextBoxColumn address;
    private Panel panel1;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label lblResult;
    private Button btnTraCuu;
    private DateTimePicker dtEnd;
    private DateTimePicker dtStart;
    private TextBox txtVin;
    private Panel panel2;
    private Label lblCount;
    private Label lblPaid;
    private Label lblDiscount;
    private Label lblTotal;
    private Label lblSumKWh;
}