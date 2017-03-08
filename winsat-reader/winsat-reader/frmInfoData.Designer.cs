namespace winsat_reader
{
    partial class frmInfoData
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.txtDtInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(0, 33);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 21;
            this.dgvInfo.Size = new System.Drawing.Size(384, 528);
            this.dgvInfo.TabIndex = 0;
            // 
            // txtDtInfo
            // 
            this.txtDtInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDtInfo.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtDtInfo.Name = "txtDtInfo";
            this.txtDtInfo.Size = new System.Drawing.Size(384, 27);
            this.txtDtInfo.TabIndex = 1;
            // 
            // frmInfoData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.txtDtInfo);
            this.Controls.Add(this.dgvInfo);
            this.Name = "frmInfoData";
            this.Text = "frmInfoData";
            this.Load += new System.EventHandler(this.frmInfoData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.TextBox txtDtInfo;
    }
}