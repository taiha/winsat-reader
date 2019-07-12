namespace winsat_reader
{
    partial class frmBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5.6D);
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2.2D);
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5.9D);
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3.2D);
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 8.3D);
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2.1D);
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 9.9D);
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.tsExit = new System.Windows.Forms.ToolStripButton();
			this.tsddEvaluation = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsRunEvaluation = new System.Windows.Forms.ToolStripMenuItem();
			this.tsLoadEvaluation = new System.Windows.Forms.ToolStripMenuItem();
			this.tsHelp = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsVersion = new System.Windows.Forms.ToolStripMenuItem();
			this.gbSysSummery = new System.Windows.Forms.GroupBox();
			this.tblSysSummery = new System.Windows.Forms.TableLayoutPanel();
			this.lblOS = new System.Windows.Forms.Label();
			this.lblMachine = new System.Windows.Forms.Label();
			this.lblOSInfo = new System.Windows.Forms.Label();
			this.lblMachineInfo = new System.Windows.Forms.Label();
			this.gbSysScore = new System.Windows.Forms.GroupBox();
			this.tblSysScore = new System.Windows.Forms.TableLayoutPanel();
			this.lblCpuInfo = new System.Windows.Forms.Label();
			this.lblMemInfo = new System.Windows.Forms.Label();
			this.lblGfxInfo = new System.Windows.Forms.Label();
			this.lblGameInfo = new System.Windows.Forms.Label();
			this.lblDiskInfo = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnCpuDetail = new System.Windows.Forms.Button();
			this.btnMemDetail = new System.Windows.Forms.Button();
			this.btnGfxDetail = new System.Windows.Forms.Button();
			this.btnHddDetail = new System.Windows.Forms.Button();
			this.totalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.elementChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tsMain.SuspendLayout();
			this.gbSysSummery.SuspendLayout();
			this.tblSysSummery.SuspendLayout();
			this.gbSysScore.SuspendLayout();
			this.tblSysScore.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.totalChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elementChart)).BeginInit();
			this.SuspendLayout();
			// 
			// tsMain
			// 
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExit,
            this.tsddEvaluation,
            this.tsHelp});
			this.tsMain.Location = new System.Drawing.Point(0, 0);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(784, 25);
			this.tsMain.TabIndex = 0;
			this.tsMain.Text = "toolStrip1";
			// 
			// tsExit
			// 
			this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
			this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsExit.Name = "tsExit";
			this.tsExit.Size = new System.Drawing.Size(50, 22);
			this.tsExit.Text = "終了(&C)";
			this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
			// 
			// tsddEvaluation
			// 
			this.tsddEvaluation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsddEvaluation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRunEvaluation,
            this.tsLoadEvaluation});
			this.tsddEvaluation.Image = ((System.Drawing.Image)(resources.GetObject("tsddEvaluation.Image")));
			this.tsddEvaluation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsddEvaluation.Name = "tsddEvaluation";
			this.tsddEvaluation.Size = new System.Drawing.Size(81, 22);
			this.tsddEvaluation.Text = "システム評価";
			this.tsddEvaluation.ToolTipText = "システム評価";
			// 
			// tsRunEvaluation
			// 
			this.tsRunEvaluation.Name = "tsRunEvaluation";
			this.tsRunEvaluation.Size = new System.Drawing.Size(140, 22);
			this.tsRunEvaluation.Text = "評価実行 (&R)";
			this.tsRunEvaluation.Click += new System.EventHandler(this.tsRunEvaluation_Click);
			// 
			// tsLoadEvaluation
			// 
			this.tsLoadEvaluation.Name = "tsLoadEvaluation";
			this.tsLoadEvaluation.Size = new System.Drawing.Size(140, 22);
			this.tsLoadEvaluation.Text = "評価読込 (&L)";
			this.tsLoadEvaluation.Click += new System.EventHandler(this.tsLoadEvaluation_Click);
			// 
			// tsHelp
			// 
			this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVersion});
			this.tsHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsHelp.Image")));
			this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsHelp.Name = "tsHelp";
			this.tsHelp.Size = new System.Drawing.Size(49, 22);
			this.tsHelp.Text = "ヘルプ";
			// 
			// tsVersion
			// 
			this.tsVersion.Name = "tsVersion";
			this.tsVersion.Size = new System.Drawing.Size(160, 22);
			this.tsVersion.Text = "バージョン情報 (&V)";
			this.tsVersion.Click += new System.EventHandler(this.tsVersion_Click);
			// 
			// gbSysSummery
			// 
			this.gbSysSummery.BackColor = System.Drawing.Color.PowderBlue;
			this.gbSysSummery.Controls.Add(this.tblSysSummery);
			this.gbSysSummery.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbSysSummery.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbSysSummery.Location = new System.Drawing.Point(0, 25);
			this.gbSysSummery.Name = "gbSysSummery";
			this.gbSysSummery.Size = new System.Drawing.Size(784, 100);
			this.gbSysSummery.TabIndex = 1;
			this.gbSysSummery.TabStop = false;
			this.gbSysSummery.Text = "システム概要";
			// 
			// tblSysSummery
			// 
			this.tblSysSummery.ColumnCount = 2;
			this.tblSysSummery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tblSysSummery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.tblSysSummery.Controls.Add(this.lblOS, 0, 0);
			this.tblSysSummery.Controls.Add(this.lblMachine, 0, 1);
			this.tblSysSummery.Controls.Add(this.lblOSInfo, 1, 0);
			this.tblSysSummery.Controls.Add(this.lblMachineInfo, 1, 1);
			this.tblSysSummery.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblSysSummery.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tblSysSummery.Location = new System.Drawing.Point(3, 21);
			this.tblSysSummery.Name = "tblSysSummery";
			this.tblSysSummery.RowCount = 2;
			this.tblSysSummery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblSysSummery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblSysSummery.Size = new System.Drawing.Size(778, 76);
			this.tblSysSummery.TabIndex = 0;
			// 
			// lblOS
			// 
			this.lblOS.AutoSize = true;
			this.lblOS.BackColor = System.Drawing.Color.White;
			this.lblOS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblOS.Location = new System.Drawing.Point(1, 1);
			this.lblOS.Margin = new System.Windows.Forms.Padding(1);
			this.lblOS.Name = "lblOS";
			this.lblOS.Size = new System.Drawing.Size(270, 36);
			this.lblOS.TabIndex = 0;
			this.lblOS.Text = "OS";
			this.lblOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMachine
			// 
			this.lblMachine.AutoSize = true;
			this.lblMachine.BackColor = System.Drawing.Color.White;
			this.lblMachine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMachine.Location = new System.Drawing.Point(1, 39);
			this.lblMachine.Margin = new System.Windows.Forms.Padding(1);
			this.lblMachine.Name = "lblMachine";
			this.lblMachine.Size = new System.Drawing.Size(270, 36);
			this.lblMachine.TabIndex = 1;
			this.lblMachine.Text = "Machine (MotherBoard)";
			this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOSInfo
			// 
			this.lblOSInfo.AutoSize = true;
			this.lblOSInfo.BackColor = System.Drawing.Color.White;
			this.lblOSInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblOSInfo.Location = new System.Drawing.Point(273, 1);
			this.lblOSInfo.Margin = new System.Windows.Forms.Padding(1);
			this.lblOSInfo.Name = "lblOSInfo";
			this.lblOSInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lblOSInfo.Size = new System.Drawing.Size(504, 36);
			this.lblOSInfo.TabIndex = 2;
			this.lblOSInfo.Text = "OS_Info";
			this.lblOSInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMachineInfo
			// 
			this.lblMachineInfo.AutoSize = true;
			this.lblMachineInfo.BackColor = System.Drawing.Color.White;
			this.lblMachineInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMachineInfo.Location = new System.Drawing.Point(273, 39);
			this.lblMachineInfo.Margin = new System.Windows.Forms.Padding(1);
			this.lblMachineInfo.Name = "lblMachineInfo";
			this.lblMachineInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lblMachineInfo.Size = new System.Drawing.Size(504, 36);
			this.lblMachineInfo.TabIndex = 3;
			this.lblMachineInfo.Text = "Machine_Info";
			this.lblMachineInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbSysScore
			// 
			this.gbSysScore.BackColor = System.Drawing.Color.Linen;
			this.gbSysScore.Controls.Add(this.tblSysScore);
			this.gbSysScore.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbSysScore.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbSysScore.Location = new System.Drawing.Point(0, 125);
			this.gbSysScore.Name = "gbSysScore";
			this.gbSysScore.Size = new System.Drawing.Size(784, 436);
			this.gbSysScore.TabIndex = 2;
			this.gbSysScore.TabStop = false;
			this.gbSysScore.Text = "システム詳細 / スコア";
			// 
			// tblSysScore
			// 
			this.tblSysScore.ColumnCount = 3;
			this.tblSysScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tblSysScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tblSysScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tblSysScore.Controls.Add(this.lblCpuInfo, 1, 0);
			this.tblSysScore.Controls.Add(this.lblMemInfo, 1, 1);
			this.tblSysScore.Controls.Add(this.lblGfxInfo, 1, 2);
			this.tblSysScore.Controls.Add(this.lblGameInfo, 1, 3);
			this.tblSysScore.Controls.Add(this.lblDiskInfo, 1, 4);
			this.tblSysScore.Controls.Add(this.lblTotal, 1, 5);
			this.tblSysScore.Controls.Add(this.btnCpuDetail, 0, 0);
			this.tblSysScore.Controls.Add(this.btnMemDetail, 0, 1);
			this.tblSysScore.Controls.Add(this.btnGfxDetail, 0, 2);
			this.tblSysScore.Controls.Add(this.btnHddDetail, 0, 4);
			this.tblSysScore.Controls.Add(this.totalChart, 2, 5);
			this.tblSysScore.Controls.Add(this.elementChart, 2, 0);
			this.tblSysScore.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblSysScore.Location = new System.Drawing.Point(3, 21);
			this.tblSysScore.Name = "tblSysScore";
			this.tblSysScore.RowCount = 6;
			this.tblSysScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tblSysScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tblSysScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tblSysScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tblSysScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tblSysScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblSysScore.Size = new System.Drawing.Size(778, 412);
			this.tblSysScore.TabIndex = 0;
			// 
			// lblCpuInfo
			// 
			this.lblCpuInfo.AutoSize = true;
			this.lblCpuInfo.BackColor = System.Drawing.Color.White;
			this.lblCpuInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCpuInfo.Font = new System.Drawing.Font("メイリオ", 10F);
			this.lblCpuInfo.Image = global::winsat_reader.resImg.label54;
			this.lblCpuInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCpuInfo.Location = new System.Drawing.Point(77, 2);
			this.lblCpuInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblCpuInfo.Name = "lblCpuInfo";
			this.lblCpuInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblCpuInfo.Size = new System.Drawing.Size(350, 61);
			this.lblCpuInfo.TabIndex = 0;
			this.lblCpuInfo.Text = "CPU";
			this.lblCpuInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMemInfo
			// 
			this.lblMemInfo.AutoSize = true;
			this.lblMemInfo.BackColor = System.Drawing.Color.White;
			this.lblMemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMemInfo.Font = new System.Drawing.Font("メイリオ", 10F);
			this.lblMemInfo.Image = global::winsat_reader.resImg.label54;
			this.lblMemInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMemInfo.Location = new System.Drawing.Point(77, 67);
			this.lblMemInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblMemInfo.Name = "lblMemInfo";
			this.lblMemInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblMemInfo.Size = new System.Drawing.Size(350, 61);
			this.lblMemInfo.TabIndex = 1;
			this.lblMemInfo.Text = "メモリ (RAM)";
			this.lblMemInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGfxInfo
			// 
			this.lblGfxInfo.AutoSize = true;
			this.lblGfxInfo.BackColor = System.Drawing.Color.White;
			this.lblGfxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblGfxInfo.Font = new System.Drawing.Font("メイリオ", 10F);
			this.lblGfxInfo.Image = global::winsat_reader.resImg.label54;
			this.lblGfxInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGfxInfo.Location = new System.Drawing.Point(77, 132);
			this.lblGfxInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblGfxInfo.Name = "lblGfxInfo";
			this.lblGfxInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblGfxInfo.Size = new System.Drawing.Size(350, 61);
			this.lblGfxInfo.TabIndex = 2;
			this.lblGfxInfo.Text = "グラフィックス";
			this.lblGfxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGameInfo
			// 
			this.lblGameInfo.AutoSize = true;
			this.lblGameInfo.BackColor = System.Drawing.Color.White;
			this.lblGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblGameInfo.Font = new System.Drawing.Font("メイリオ", 10F);
			this.lblGameInfo.Image = global::winsat_reader.resImg.label5;
			this.lblGameInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGameInfo.Location = new System.Drawing.Point(77, 197);
			this.lblGameInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblGameInfo.Name = "lblGameInfo";
			this.lblGameInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblGameInfo.Size = new System.Drawing.Size(350, 61);
			this.lblGameInfo.TabIndex = 3;
			this.lblGameInfo.Text = "ゲーム用 グラフィックス";
			this.lblGameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDiskInfo
			// 
			this.lblDiskInfo.AutoSize = true;
			this.lblDiskInfo.BackColor = System.Drawing.Color.White;
			this.lblDiskInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDiskInfo.Font = new System.Drawing.Font("メイリオ", 10F);
			this.lblDiskInfo.Image = global::winsat_reader.resImg.label54;
			this.lblDiskInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDiskInfo.Location = new System.Drawing.Point(77, 262);
			this.lblDiskInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblDiskInfo.Name = "lblDiskInfo";
			this.lblDiskInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblDiskInfo.Size = new System.Drawing.Size(350, 61);
			this.lblDiskInfo.TabIndex = 4;
			this.lblDiskInfo.Text = "プライマリ ディスク";
			this.lblDiskInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.BackColor = System.Drawing.Color.White;
			this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblTotal.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblTotal.Location = new System.Drawing.Point(77, 327);
			this.lblTotal.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(350, 83);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "合計\r\n（4項目合計）";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCpuDetail
			// 
			this.btnCpuDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCpuDetail.Enabled = false;
			this.btnCpuDetail.Image = global::winsat_reader.resImg.cpu60;
			this.btnCpuDetail.Location = new System.Drawing.Point(3, 3);
			this.btnCpuDetail.Name = "btnCpuDetail";
			this.btnCpuDetail.Size = new System.Drawing.Size(71, 59);
			this.btnCpuDetail.TabIndex = 6;
			this.btnCpuDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCpuDetail.UseVisualStyleBackColor = true;
			// 
			// btnMemDetail
			// 
			this.btnMemDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMemDetail.Enabled = false;
			this.btnMemDetail.Image = global::winsat_reader.resImg.mem60;
			this.btnMemDetail.Location = new System.Drawing.Point(3, 68);
			this.btnMemDetail.Name = "btnMemDetail";
			this.btnMemDetail.Size = new System.Drawing.Size(71, 59);
			this.btnMemDetail.TabIndex = 7;
			this.btnMemDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMemDetail.UseVisualStyleBackColor = true;
			// 
			// btnGfxDetail
			// 
			this.btnGfxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGfxDetail.Enabled = false;
			this.btnGfxDetail.Image = global::winsat_reader.resImg.display60;
			this.btnGfxDetail.Location = new System.Drawing.Point(3, 133);
			this.btnGfxDetail.Name = "btnGfxDetail";
			this.btnGfxDetail.Size = new System.Drawing.Size(71, 59);
			this.btnGfxDetail.TabIndex = 8;
			this.btnGfxDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGfxDetail.UseVisualStyleBackColor = true;
			// 
			// btnHddDetail
			// 
			this.btnHddDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnHddDetail.Enabled = false;
			this.btnHddDetail.Image = global::winsat_reader.resImg.hdd40;
			this.btnHddDetail.Location = new System.Drawing.Point(3, 263);
			this.btnHddDetail.Name = "btnHddDetail";
			this.btnHddDetail.Size = new System.Drawing.Size(71, 59);
			this.btnHddDetail.TabIndex = 9;
			this.btnHddDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHddDetail.UseVisualStyleBackColor = true;
			// 
			// totalChart
			// 
			chartArea7.AxisX.LabelStyle.Enabled = false;
			chartArea7.AxisX.MajorGrid.Enabled = false;
			chartArea7.AxisX.MajorTickMark.Enabled = false;
			chartArea7.AxisX.Maximum = 1.7D;
			chartArea7.AxisX.Minimum = 0.3D;
			chartArea7.AxisY.LabelStyle.Enabled = false;
			chartArea7.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea7.AxisY.MajorGrid.Interval = 10D;
			chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea7.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea7.AxisY.MajorTickMark.Enabled = false;
			chartArea7.AxisY.Maximum = 49.5D;
			chartArea7.AxisY.Minimum = 0D;
			chartArea7.AxisY.MinorGrid.Enabled = true;
			chartArea7.AxisY.MinorGrid.Interval = 10D;
			chartArea7.AxisY.MinorGrid.IntervalOffset = 5D;
			chartArea7.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
			chartArea7.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea7.Name = "ChartArea1";
			chartArea7.Position.Auto = false;
			chartArea7.Position.Height = 100F;
			chartArea7.Position.Width = 100F;
			this.totalChart.ChartAreas.Add(chartArea7);
			this.totalChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.totalChart.Location = new System.Drawing.Point(430, 328);
			this.totalChart.Name = "totalChart";
			this.totalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.totalChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumAquamarine,
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))))};
			series8.ChartArea = "ChartArea1";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series8.CustomProperties = "BarLabelStyle=Right";
			series8.Font = new System.Drawing.Font("Meiryo UI", 16F, System.Drawing.FontStyle.Bold);
			series8.IsValueShownAsLabel = true;
			series8.LabelForeColor = System.Drawing.Color.White;
			series8.LabelFormat = "0.0";
			series8.Name = "Series1";
			series8.Points.Add(dataPoint8);
			series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series9.ChartArea = "ChartArea1";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series9.CustomProperties = "BarLabelStyle=Right";
			series9.Font = new System.Drawing.Font("Meiryo UI", 16F, System.Drawing.FontStyle.Bold);
			series9.IsValueShownAsLabel = true;
			series9.LabelForeColor = System.Drawing.Color.White;
			series9.LabelFormat = "0.0";
			series9.Name = "Series2";
			series9.Points.Add(dataPoint9);
			this.totalChart.Series.Add(series8);
			this.totalChart.Series.Add(series9);
			this.totalChart.Size = new System.Drawing.Size(345, 81);
			this.totalChart.TabIndex = 16;
			this.totalChart.Text = "chart6";
			// 
			// elementChart
			// 
			chartArea8.AxisX.IsReversed = true;
			chartArea8.AxisX.LabelStyle.Enabled = false;
			chartArea8.AxisX.MajorGrid.Enabled = false;
			chartArea8.AxisX.MajorTickMark.Enabled = false;
			chartArea8.AxisX.Maximum = 1.8D;
			chartArea8.AxisX.Minimum = 0.2D;
			chartArea8.AxisY.IsLabelAutoFit = false;
			chartArea8.AxisY.LabelStyle.Enabled = false;
			chartArea8.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea8.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea8.AxisY.MajorTickMark.Enabled = false;
			chartArea8.AxisY.Maximum = 10D;
			chartArea8.AxisY.Minimum = 0D;
			chartArea8.Name = "caCpu";
			chartArea8.Position.Auto = false;
			chartArea8.Position.Height = 20F;
			chartArea8.Position.Width = 100F;
			chartArea9.AxisX.LabelStyle.Enabled = false;
			chartArea9.AxisX.MajorGrid.Enabled = false;
			chartArea9.AxisX.MajorTickMark.Enabled = false;
			chartArea9.AxisX.Maximum = 1.8D;
			chartArea9.AxisX.Minimum = 0.2D;
			chartArea9.AxisY.LabelStyle.Enabled = false;
			chartArea9.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea9.AxisY.MajorGrid.Interval = 0D;
			chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea9.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea9.AxisY.MajorTickMark.Enabled = false;
			chartArea9.AxisY.Maximum = 10D;
			chartArea9.AxisY.Minimum = 0D;
			chartArea9.Name = "caMem";
			chartArea9.Position.Auto = false;
			chartArea9.Position.Height = 20F;
			chartArea9.Position.Width = 100F;
			chartArea9.Position.Y = 20F;
			chartArea10.AxisX.LabelStyle.Enabled = false;
			chartArea10.AxisX.MajorGrid.Enabled = false;
			chartArea10.AxisX.MajorTickMark.Enabled = false;
			chartArea10.AxisX.Maximum = 1.8D;
			chartArea10.AxisX.Minimum = 0.2D;
			chartArea10.AxisY.LabelStyle.Enabled = false;
			chartArea10.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea10.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea10.AxisY.MajorTickMark.Enabled = false;
			chartArea10.AxisY.Maximum = 10D;
			chartArea10.AxisY.Minimum = 0D;
			chartArea10.Name = "caGfx";
			chartArea10.Position.Auto = false;
			chartArea10.Position.Height = 20F;
			chartArea10.Position.Width = 100F;
			chartArea10.Position.Y = 40F;
			chartArea11.AxisX.LabelStyle.Enabled = false;
			chartArea11.AxisX.MajorGrid.Enabled = false;
			chartArea11.AxisX.MajorTickMark.Enabled = false;
			chartArea11.AxisX.Maximum = 1.8D;
			chartArea11.AxisX.Minimum = 0.2D;
			chartArea11.AxisY.LabelStyle.Enabled = false;
			chartArea11.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea11.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea11.AxisY.MajorTickMark.Enabled = false;
			chartArea11.AxisY.Maximum = 10D;
			chartArea11.AxisY.Minimum = 0D;
			chartArea11.Name = "caGame";
			chartArea11.Position.Auto = false;
			chartArea11.Position.Height = 20F;
			chartArea11.Position.Width = 100F;
			chartArea11.Position.Y = 60F;
			chartArea12.AxisX.LabelStyle.Enabled = false;
			chartArea12.AxisX.MajorGrid.Enabled = false;
			chartArea12.AxisX.MajorTickMark.Enabled = false;
			chartArea12.AxisX.Maximum = 1.8D;
			chartArea12.AxisX.Minimum = 0.2D;
			chartArea12.AxisY.LabelStyle.Enabled = false;
			chartArea12.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
			chartArea12.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea12.AxisY.MajorTickMark.Enabled = false;
			chartArea12.AxisY.Maximum = 10D;
			chartArea12.AxisY.Minimum = 0D;
			chartArea12.Name = "caDisk";
			chartArea12.Position.Auto = false;
			chartArea12.Position.Height = 20F;
			chartArea12.Position.Width = 100F;
			chartArea12.Position.Y = 80F;
			this.elementChart.ChartAreas.Add(chartArea8);
			this.elementChart.ChartAreas.Add(chartArea9);
			this.elementChart.ChartAreas.Add(chartArea10);
			this.elementChart.ChartAreas.Add(chartArea11);
			this.elementChart.ChartAreas.Add(chartArea12);
			this.elementChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elementChart.Location = new System.Drawing.Point(430, 3);
			this.elementChart.Name = "elementChart";
			this.elementChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.elementChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Tomato,
        System.Drawing.Color.Orange,
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.MediumSlateBlue};
			this.tblSysScore.SetRowSpan(this.elementChart, 5);
			series10.ChartArea = "caCpu";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series10.CustomProperties = "BarLabelStyle=Right";
			series10.Font = new System.Drawing.Font("Meiryo UI", 17F, System.Drawing.FontStyle.Bold);
			series10.IsValueShownAsLabel = true;
			series10.LabelForeColor = System.Drawing.Color.White;
			series10.LabelFormat = "0.0";
			series10.Name = "serCpu";
			series10.Points.Add(dataPoint10);
			series11.ChartArea = "caMem";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series11.CustomProperties = "BarLabelStyle=Right";
			series11.Font = new System.Drawing.Font("Meiryo UI", 17F, System.Drawing.FontStyle.Bold);
			series11.IsValueShownAsLabel = true;
			series11.LabelForeColor = System.Drawing.Color.White;
			series11.LabelFormat = "0.0";
			series11.Name = "serMem";
			series11.Points.Add(dataPoint11);
			series12.ChartArea = "caGfx";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series12.CustomProperties = "BarLabelStyle=Right";
			series12.Font = new System.Drawing.Font("Meiryo UI", 17F, System.Drawing.FontStyle.Bold);
			series12.IsValueShownAsLabel = true;
			series12.LabelForeColor = System.Drawing.Color.White;
			series12.LabelFormat = "0.0";
			series12.Name = "serGfx";
			series12.Points.Add(dataPoint12);
			series13.ChartArea = "caGame";
			series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series13.CustomProperties = "BarLabelStyle=Right";
			series13.Font = new System.Drawing.Font("Meiryo UI", 17F, System.Drawing.FontStyle.Bold);
			series13.IsValueShownAsLabel = true;
			series13.LabelForeColor = System.Drawing.Color.White;
			series13.LabelFormat = "0.0";
			series13.Name = "serGame";
			series13.Points.Add(dataPoint13);
			series14.ChartArea = "caDisk";
			series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series14.CustomProperties = "BarLabelStyle=Right";
			series14.Font = new System.Drawing.Font("Meiryo UI", 17F, System.Drawing.FontStyle.Bold);
			series14.IsValueShownAsLabel = true;
			series14.LabelForeColor = System.Drawing.Color.White;
			series14.LabelFormat = "0.0";
			series14.Name = "serDisk";
			series14.Points.Add(dataPoint14);
			this.elementChart.Series.Add(series10);
			this.elementChart.Series.Add(series11);
			this.elementChart.Series.Add(series12);
			this.elementChart.Series.Add(series13);
			this.elementChart.Series.Add(series14);
			this.elementChart.Size = new System.Drawing.Size(345, 319);
			this.elementChart.TabIndex = 17;
			this.elementChart.Text = "chart1";
			// 
			// frmBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.gbSysScore);
			this.Controls.Add(this.gbSysSummery);
			this.Controls.Add(this.tsMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmBase";
			this.Text = "WinSAT Reader";
			this.Load += new System.EventHandler(this.frmBase_Load);
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.gbSysSummery.ResumeLayout(false);
			this.tblSysSummery.ResumeLayout(false);
			this.tblSysSummery.PerformLayout();
			this.gbSysScore.ResumeLayout(false);
			this.tblSysScore.ResumeLayout(false);
			this.tblSysScore.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.totalChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elementChart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.ToolStripDropDownButton tsddEvaluation;
        private System.Windows.Forms.ToolStripMenuItem tsRunEvaluation;
        private System.Windows.Forms.ToolStripMenuItem tsLoadEvaluation;
        private System.Windows.Forms.ToolStripDropDownButton tsHelp;
        private System.Windows.Forms.ToolStripMenuItem tsVersion;
        private System.Windows.Forms.GroupBox gbSysSummery;
        private System.Windows.Forms.TableLayoutPanel tblSysSummery;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblOSInfo;
        private System.Windows.Forms.Label lblMachineInfo;
        private System.Windows.Forms.GroupBox gbSysScore;
		private System.Windows.Forms.TableLayoutPanel tblSysScore;
		private System.Windows.Forms.Label lblCpuInfo;
		private System.Windows.Forms.Label lblMemInfo;
		private System.Windows.Forms.Label lblGfxInfo;
		private System.Windows.Forms.Label lblGameInfo;
		private System.Windows.Forms.Label lblDiskInfo;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnCpuDetail;
		private System.Windows.Forms.Button btnMemDetail;
		private System.Windows.Forms.Button btnGfxDetail;
		private System.Windows.Forms.Button btnHddDetail;
		private System.Windows.Forms.DataVisualization.Charting.Chart totalChart;
		private System.Windows.Forms.DataVisualization.Charting.Chart elementChart;
	}
}

