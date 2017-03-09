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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tsMain.SuspendLayout();
            this.gbSysSummery.SuspendLayout();
            this.tblSysSummery.SuspendLayout();
            this.gbSysScore.SuspendLayout();
            this.tblSysScore.SuspendLayout();
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
            this.tsddEvaluation.Size = new System.Drawing.Size(80, 22);
            this.tsddEvaluation.Text = "システム評価";
            this.tsddEvaluation.ToolTipText = "システム評価";
            // 
            // tsRunEvaluation
            // 
            this.tsRunEvaluation.Name = "tsRunEvaluation";
            this.tsRunEvaluation.Size = new System.Drawing.Size(122, 22);
            this.tsRunEvaluation.Text = "評価実行";
            this.tsRunEvaluation.Click += new System.EventHandler(this.tsRunEvaluation_Click);
            // 
            // tsLoadEvaluation
            // 
            this.tsLoadEvaluation.Name = "tsLoadEvaluation";
            this.tsLoadEvaluation.Size = new System.Drawing.Size(122, 22);
            this.tsLoadEvaluation.Text = "評価読込";
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
            this.tsVersion.Size = new System.Drawing.Size(142, 22);
            this.tsVersion.Text = "バージョン情報";
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
            this.lblOSInfo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
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
            this.lblMachineInfo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
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
            this.tblSysScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblSysScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblSysScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblSysScore.Controls.Add(this.lblCpuInfo, 0, 0);
            this.tblSysScore.Controls.Add(this.lblMemInfo, 0, 1);
            this.tblSysScore.Controls.Add(this.lblGfxInfo, 0, 2);
            this.tblSysScore.Controls.Add(this.lblGameInfo, 0, 3);
            this.tblSysScore.Controls.Add(this.lblDiskInfo, 0, 4);
            this.tblSysScore.Controls.Add(this.lblTotal, 0, 5);
            this.tblSysScore.Controls.Add(this.btnCpuDetail, 1, 0);
            this.tblSysScore.Controls.Add(this.button2, 1, 1);
            this.tblSysScore.Controls.Add(this.button3, 1, 2);
            this.tblSysScore.Controls.Add(this.button4, 1, 4);
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
            this.lblCpuInfo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCpuInfo.Image = global::winsat_reader.resImg.cpu60;
            this.lblCpuInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpuInfo.Location = new System.Drawing.Point(0, 2);
            this.lblCpuInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblCpuInfo.Name = "lblCpuInfo";
            this.lblCpuInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblCpuInfo.Size = new System.Drawing.Size(350, 61);
            this.lblCpuInfo.TabIndex = 0;
            this.lblCpuInfo.Text = "CPU";
            this.lblCpuInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMemInfo
            // 
            this.lblMemInfo.AutoSize = true;
            this.lblMemInfo.BackColor = System.Drawing.Color.White;
            this.lblMemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMemInfo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMemInfo.Image = global::winsat_reader.resImg.mem60;
            this.lblMemInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMemInfo.Location = new System.Drawing.Point(0, 67);
            this.lblMemInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblMemInfo.Name = "lblMemInfo";
            this.lblMemInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMemInfo.Size = new System.Drawing.Size(350, 61);
            this.lblMemInfo.TabIndex = 1;
            this.lblMemInfo.Text = "メモリ (RAM)";
            this.lblMemInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGfxInfo
            // 
            this.lblGfxInfo.AutoSize = true;
            this.lblGfxInfo.BackColor = System.Drawing.Color.White;
            this.lblGfxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGfxInfo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblGfxInfo.Image = global::winsat_reader.resImg.display60;
            this.lblGfxInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGfxInfo.Location = new System.Drawing.Point(0, 132);
            this.lblGfxInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblGfxInfo.Name = "lblGfxInfo";
            this.lblGfxInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblGfxInfo.Size = new System.Drawing.Size(350, 61);
            this.lblGfxInfo.TabIndex = 2;
            this.lblGfxInfo.Text = "グラフィックス";
            this.lblGfxInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.BackColor = System.Drawing.Color.White;
            this.lblGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameInfo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblGameInfo.Location = new System.Drawing.Point(0, 197);
            this.lblGameInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblGameInfo.Size = new System.Drawing.Size(350, 61);
            this.lblGameInfo.TabIndex = 3;
            this.lblGameInfo.Text = "ゲーム用 グラフィックス";
            this.lblGameInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDiskInfo
            // 
            this.lblDiskInfo.AutoSize = true;
            this.lblDiskInfo.BackColor = System.Drawing.Color.White;
            this.lblDiskInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiskInfo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDiskInfo.Image = global::winsat_reader.resImg.hdd60;
            this.lblDiskInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiskInfo.Location = new System.Drawing.Point(0, 262);
            this.lblDiskInfo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblDiskInfo.Name = "lblDiskInfo";
            this.lblDiskInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDiskInfo.Size = new System.Drawing.Size(350, 61);
            this.lblDiskInfo.TabIndex = 4;
            this.lblDiskInfo.Text = "プライマリ ディスク";
            this.lblDiskInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotal.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTotal.Location = new System.Drawing.Point(0, 327);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(350, 83);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "総合";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCpuDetail
            // 
            this.btnCpuDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCpuDetail.Location = new System.Drawing.Point(353, 3);
            this.btnCpuDetail.Name = "btnCpuDetail";
            this.btnCpuDetail.Size = new System.Drawing.Size(71, 59);
            this.btnCpuDetail.TabIndex = 6;
            this.btnCpuDetail.Text = "詳細情報";
            this.btnCpuDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCpuDetail.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(353, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "詳細情報";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(353, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 59);
            this.button3.TabIndex = 8;
            this.button3.Text = "詳細情報";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(353, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 59);
            this.button4.TabIndex = 9;
            this.button4.Text = "詳細情報";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

