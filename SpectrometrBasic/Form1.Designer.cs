namespace SpectrometrBasic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusIndicator = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.WyslijPorty = new System.Windows.Forms.Button();
            this.Outputs = new System.Windows.Forms.CheckedListBox();
            this.IOStatus = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.WyslijVMax = new System.Windows.Forms.Button();
            this.VMax2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.VMax1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Przepisz1 = new System.Windows.Forms.Button();
            this.Wyslij1 = new System.Windows.Forms.Button();
            this.UstawioneImpulsy1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AktualneImpulsy1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Przepisz2 = new System.Windows.Forms.Button();
            this.Wyslij2 = new System.Windows.Forms.Button();
            this.UstawioneImpulsy2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.AktualneImpulsy2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LusterkoWyslij = new System.Windows.Forms.Button();
            this.LusterkoKat = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.RefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ConnectionErrors = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Dissconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.BitRate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PortChoose = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VMax1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UstawioneImpulsy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AktualneImpulsy1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UstawioneImpulsy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AktualneImpulsy2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LusterkoKat)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 530);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusIndicator);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // StatusIndicator
            // 
            this.StatusIndicator.FormattingEnabled = true;
            this.StatusIndicator.Items.AddRange(new object[] {
            "Pozycjonowanie 1",
            "Pozycjonowanie 2",
            "Jazda Lewo 1",
            "Jazda Prawo 1",
            "Jazda Lewo 2",
            "Jazda Prawo 2"});
            this.StatusIndicator.Location = new System.Drawing.Point(6, 19);
            this.StatusIndicator.Name = "StatusIndicator";
            this.StatusIndicator.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.StatusIndicator.Size = new System.Drawing.Size(120, 94);
            this.StatusIndicator.TabIndex = 0;
            this.StatusIndicator.SelectedIndexChanged += new System.EventHandler(this.StatusIndicator_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.WyslijPorty);
            this.groupBox5.Controls.Add(this.Outputs);
            this.groupBox5.Controls.Add(this.IOStatus);
            this.groupBox5.Location = new System.Drawing.Point(140, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 148);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wejścia/Wyjścia";
            // 
            // WyslijPorty
            // 
            this.WyslijPorty.Enabled = false;
            this.WyslijPorty.Location = new System.Drawing.Point(79, 91);
            this.WyslijPorty.Name = "WyslijPorty";
            this.WyslijPorty.Size = new System.Drawing.Size(75, 23);
            this.WyslijPorty.TabIndex = 2;
            this.WyslijPorty.Text = "Wyślij";
            this.WyslijPorty.UseVisualStyleBackColor = false;
            this.WyslijPorty.Click += new System.EventHandler(this.WyslijPorty_Click);
            // 
            // Outputs
            // 
            this.Outputs.CheckOnClick = true;
            this.Outputs.FormattingEnabled = true;
            this.Outputs.Items.AddRange(new object[] {
            "OUT 1",
            "OUT 2",
            "OUT 3",
            "OUT 4"});
            this.Outputs.Location = new System.Drawing.Point(79, 20);
            this.Outputs.Name = "Outputs";
            this.Outputs.Size = new System.Drawing.Size(75, 64);
            this.Outputs.TabIndex = 1;
            // 
            // IOStatus
            // 
            this.IOStatus.FormattingEnabled = true;
            this.IOStatus.Items.AddRange(new object[] {
            "IN 1",
            "IN 2",
            "IN 3",
            "IN 4",
            "OUT 1",
            "OUT 2",
            "OUT 3",
            "OUT 4"});
            this.IOStatus.Location = new System.Drawing.Point(7, 20);
            this.IOStatus.Name = "IOStatus";
            this.IOStatus.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.IOStatus.Size = new System.Drawing.Size(65, 124);
            this.IOStatus.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.WyslijVMax);
            this.groupBox6.Controls.Add(this.VMax2);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.VMax1);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(308, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(97, 148);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ustawienia";
            // 
            // WyslijVMax
            // 
            this.WyslijVMax.Enabled = false;
            this.WyslijVMax.Location = new System.Drawing.Point(9, 103);
            this.WyslijVMax.Name = "WyslijVMax";
            this.WyslijVMax.Size = new System.Drawing.Size(80, 23);
            this.WyslijVMax.TabIndex = 4;
            this.WyslijVMax.Text = "Wyślij";
            this.WyslijVMax.UseVisualStyleBackColor = true;
            this.WyslijVMax.Click += new System.EventHandler(this.WyslijVMax_Click);
            // 
            // VMax2
            // 
            this.VMax2.Location = new System.Drawing.Point(9, 76);
            this.VMax2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.VMax2.Name = "VMax2";
            this.VMax2.Size = new System.Drawing.Size(80, 20);
            this.VMax2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prędkość max 2";
            // 
            // VMax1
            // 
            this.VMax1.Location = new System.Drawing.Point(10, 37);
            this.VMax1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.VMax1.Name = "VMax1";
            this.VMax1.Size = new System.Drawing.Size(79, 20);
            this.VMax1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prędkość max 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Przepisz1);
            this.groupBox2.Controls.Add(this.Wyslij1);
            this.groupBox2.Controls.Add(this.UstawioneImpulsy1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AktualneImpulsy1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regulacja Ostrosci";
            // 
            // Przepisz1
            // 
            this.Przepisz1.Enabled = false;
            this.Przepisz1.Location = new System.Drawing.Point(92, 107);
            this.Przepisz1.Name = "Przepisz1";
            this.Przepisz1.Size = new System.Drawing.Size(75, 23);
            this.Przepisz1.TabIndex = 5;
            this.Przepisz1.Text = "Przepisz";
            this.Przepisz1.UseVisualStyleBackColor = true;
            this.Przepisz1.Click += new System.EventHandler(this.Przepisz1_Click);
            // 
            // Wyslij1
            // 
            this.Wyslij1.Enabled = false;
            this.Wyslij1.Location = new System.Drawing.Point(10, 107);
            this.Wyslij1.Name = "Wyslij1";
            this.Wyslij1.Size = new System.Drawing.Size(75, 23);
            this.Wyslij1.TabIndex = 4;
            this.Wyslij1.Text = "Wyślij";
            this.Wyslij1.UseVisualStyleBackColor = true;
            this.Wyslij1.Click += new System.EventHandler(this.Wyslij1_Click);
            // 
            // UstawioneImpulsy1
            // 
            this.UstawioneImpulsy1.Location = new System.Drawing.Point(10, 80);
            this.UstawioneImpulsy1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UstawioneImpulsy1.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.UstawioneImpulsy1.Name = "UstawioneImpulsy1";
            this.UstawioneImpulsy1.Size = new System.Drawing.Size(157, 20);
            this.UstawioneImpulsy1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ustaw";
            // 
            // AktualneImpulsy1
            // 
            this.AktualneImpulsy1.Location = new System.Drawing.Point(10, 36);
            this.AktualneImpulsy1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.AktualneImpulsy1.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.AktualneImpulsy1.Name = "AktualneImpulsy1";
            this.AktualneImpulsy1.ReadOnly = true;
            this.AktualneImpulsy1.Size = new System.Drawing.Size(157, 20);
            this.AktualneImpulsy1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktualna pozycja enkodera";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Przepisz2);
            this.groupBox3.Controls.Add(this.Wyslij2);
            this.groupBox3.Controls.Add(this.UstawioneImpulsy2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.AktualneImpulsy2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(187, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 148);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regulacja Mikrometrem";
            // 
            // Przepisz2
            // 
            this.Przepisz2.Enabled = false;
            this.Przepisz2.Location = new System.Drawing.Point(92, 107);
            this.Przepisz2.Name = "Przepisz2";
            this.Przepisz2.Size = new System.Drawing.Size(75, 23);
            this.Przepisz2.TabIndex = 5;
            this.Przepisz2.Text = "Przepisz";
            this.Przepisz2.UseVisualStyleBackColor = true;
            this.Przepisz2.Click += new System.EventHandler(this.Przepisz2_Click);
            // 
            // Wyslij2
            // 
            this.Wyslij2.Enabled = false;
            this.Wyslij2.Location = new System.Drawing.Point(10, 107);
            this.Wyslij2.Name = "Wyslij2";
            this.Wyslij2.Size = new System.Drawing.Size(75, 23);
            this.Wyslij2.TabIndex = 4;
            this.Wyslij2.Text = "Wyślij";
            this.Wyslij2.UseVisualStyleBackColor = true;
            this.Wyslij2.Click += new System.EventHandler(this.Wyslij2_Click);
            // 
            // UstawioneImpulsy2
            // 
            this.UstawioneImpulsy2.Location = new System.Drawing.Point(10, 80);
            this.UstawioneImpulsy2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UstawioneImpulsy2.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.UstawioneImpulsy2.Name = "UstawioneImpulsy2";
            this.UstawioneImpulsy2.Size = new System.Drawing.Size(157, 20);
            this.UstawioneImpulsy2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ustaw";
            // 
            // AktualneImpulsy2
            // 
            this.AktualneImpulsy2.Location = new System.Drawing.Point(10, 36);
            this.AktualneImpulsy2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.AktualneImpulsy2.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.AktualneImpulsy2.Name = "AktualneImpulsy2";
            this.AktualneImpulsy2.ReadOnly = true;
            this.AktualneImpulsy2.Size = new System.Drawing.Size(157, 20);
            this.AktualneImpulsy2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Aktualna pozycja enkodera";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.LusterkoWyslij);
            this.groupBox4.Controls.Add(this.LusterkoKat);
            this.groupBox4.Location = new System.Drawing.Point(3, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 177);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lusterko - polozenie";
            // 
            // LusterkoWyslij
            // 
            this.LusterkoWyslij.Enabled = false;
            this.LusterkoWyslij.Location = new System.Drawing.Point(7, 75);
            this.LusterkoWyslij.Name = "LusterkoWyslij";
            this.LusterkoWyslij.Size = new System.Drawing.Size(75, 23);
            this.LusterkoWyslij.TabIndex = 1;
            this.LusterkoWyslij.Text = "Wyślij";
            this.LusterkoWyslij.UseVisualStyleBackColor = true;
            this.LusterkoWyslij.Click += new System.EventHandler(this.LusterkoWyslij_Click);
            // 
            // LusterkoKat
            // 
            this.LusterkoKat.Location = new System.Drawing.Point(7, 49);
            this.LusterkoKat.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.LusterkoKat.Name = "LusterkoKat";
            this.LusterkoKat.Size = new System.Drawing.Size(75, 20);
            this.LusterkoKat.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.RefreshRate);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.ConnectionErrors);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.Dissconnect);
            this.groupBox7.Controls.Add(this.Connect);
            this.groupBox7.Controls.Add(this.BitRate);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.PortChoose);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(140, 311);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(183, 177);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Komunikacja";
            // 
            // RefreshRate
            // 
            this.RefreshRate.Location = new System.Drawing.Point(87, 75);
            this.RefreshRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RefreshRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RefreshRate.Name = "RefreshRate";
            this.RefreshRate.Size = new System.Drawing.Size(80, 20);
            this.RefreshRate.TabIndex = 9;
            this.RefreshRate.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Refresh Rate";
            // 
            // ConnectionErrors
            // 
            this.ConnectionErrors.Location = new System.Drawing.Point(11, 144);
            this.ConnectionErrors.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ConnectionErrors.Name = "ConnectionErrors";
            this.ConnectionErrors.ReadOnly = true;
            this.ConnectionErrors.Size = new System.Drawing.Size(155, 20);
            this.ConnectionErrors.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Błędy połączenia";
            // 
            // Dissconnect
            // 
            this.Dissconnect.Enabled = false;
            this.Dissconnect.Location = new System.Drawing.Point(92, 101);
            this.Dissconnect.Name = "Dissconnect";
            this.Dissconnect.Size = new System.Drawing.Size(75, 23);
            this.Dissconnect.TabIndex = 5;
            this.Dissconnect.Text = "Rozłącz";
            this.Dissconnect.UseVisualStyleBackColor = true;
            this.Dissconnect.Click += new System.EventHandler(this.Dissconnect_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(11, 101);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Połącz";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // BitRate
            // 
            this.BitRate.FormattingEnabled = true;
            this.BitRate.Items.AddRange(new object[] {
            "110",
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.BitRate.Location = new System.Drawing.Point(62, 48);
            this.BitRate.Name = "BitRate";
            this.BitRate.Size = new System.Drawing.Size(105, 21);
            this.BitRate.TabIndex = 3;
            this.BitRate.Text = "115200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bit Rate";
            // 
            // PortChoose
            // 
            this.PortChoose.FormattingEnabled = true;
            this.PortChoose.Location = new System.Drawing.Point(43, 20);
            this.PortChoose.Name = "PortChoose";
            this.PortChoose.Size = new System.Drawing.Size(124, 21);
            this.PortChoose.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Port";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "0 - 90 stopni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 530);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Spektrometr Basic Control App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VMax1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UstawioneImpulsy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AktualneImpulsy1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UstawioneImpulsy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AktualneImpulsy2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LusterkoKat)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox StatusIndicator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Przepisz1;
        private System.Windows.Forms.Button Wyslij1;
        private System.Windows.Forms.NumericUpDown UstawioneImpulsy1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AktualneImpulsy1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Przepisz2;
        private System.Windows.Forms.Button Wyslij2;
        private System.Windows.Forms.NumericUpDown UstawioneImpulsy2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AktualneImpulsy2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button LusterkoWyslij;
        private System.Windows.Forms.NumericUpDown LusterkoKat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button WyslijPorty;
        private System.Windows.Forms.CheckedListBox Outputs;
        private System.Windows.Forms.CheckedListBox IOStatus;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown VMax1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button WyslijVMax;
        private System.Windows.Forms.NumericUpDown VMax2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox BitRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox PortChoose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown RefreshRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ConnectionErrors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Dissconnect;
        private System.Windows.Forms.Label label11;
    }
}

