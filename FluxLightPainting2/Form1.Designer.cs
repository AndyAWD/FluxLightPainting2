namespace FluxLightPainting2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPictureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCutSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculation = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxCalculation = new System.Windows.Forms.ListBox();
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.btnPbxClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.BtnPictureMenu,
            this.btnCalculationMenu,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadPicture,
            this.toolStripSeparator1,
            this.btnExit});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(122, 22);
            this.btnLoadPicture.Text = "匯入圖片";
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 22);
            this.btnExit.Text = "結束";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnPictureMenu
            // 
            this.BtnPictureMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCut,
            this.btnCutSave});
            this.BtnPictureMenu.Name = "BtnPictureMenu";
            this.BtnPictureMenu.Size = new System.Drawing.Size(43, 20);
            this.BtnPictureMenu.Text = "圖片";
            this.BtnPictureMenu.Visible = false;
            // 
            // btnCut
            // 
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(134, 22);
            this.btnCut.Text = "預覽切割";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCutSave
            // 
            this.btnCutSave.Name = "btnCutSave";
            this.btnCutSave.Size = new System.Drawing.Size(134, 22);
            this.btnCutSave.Text = "切割並儲存";
            this.btnCutSave.Click += new System.EventHandler(this.btnCutSave_Click);
            // 
            // btnCalculationMenu
            // 
            this.btnCalculationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCalculation});
            this.btnCalculationMenu.Name = "btnCalculationMenu";
            this.btnCalculationMenu.Size = new System.Drawing.Size(43, 20);
            this.btnCalculationMenu.Text = "計算";
            this.btnCalculationMenu.Visible = false;
            // 
            // btnCalculation
            // 
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(122, 22);
            this.btnCalculation.Text = "計算層高";
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInfo});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // btnInfo
            // 
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(163, 22);
            this.btnInfo.Text = "關於FLUX光塗鴉";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lbxCalculation
            // 
            this.lbxCalculation.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxCalculation.FormattingEnabled = true;
            this.lbxCalculation.ItemHeight = 24;
            this.lbxCalculation.Location = new System.Drawing.Point(12, 77);
            this.lbxCalculation.Name = "lbxCalculation";
            this.lbxCalculation.Size = new System.Drawing.Size(325, 556);
            this.lbxCalculation.TabIndex = 1;
            // 
            // pbxPicture
            // 
            this.pbxPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbxPicture.Location = new System.Drawing.Point(343, 33);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(850, 600);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPicture.TabIndex = 2;
            this.pbxPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "切片數量";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxQuantity.Location = new System.Drawing.Point(104, 39);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(58, 29);
            this.tbxQuantity.TabIndex = 4;
            // 
            // btnPbxClear
            // 
            this.btnPbxClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPbxClear.Location = new System.Drawing.Point(207, 33);
            this.btnPbxClear.Name = "btnPbxClear";
            this.btnPbxClear.Size = new System.Drawing.Size(130, 38);
            this.btnPbxClear.TabIndex = 5;
            this.btnPbxClear.Text = "清除切割";
            this.btnPbxClear.UseVisualStyleBackColor = true;
            this.btnPbxClear.Visible = false;
            this.btnPbxClear.Click += new System.EventHandler(this.btnPbxClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1206, 650);
            this.Controls.Add(this.btnPbxClear);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.lbxCalculation);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "FLUX光塗鴉 - 1.21";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLoadPicture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem BtnPictureMenu;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnCutSave;
        private System.Windows.Forms.ToolStripMenuItem btnCalculationMenu;
        private System.Windows.Forms.ToolStripMenuItem btnCalculation;
        private System.Windows.Forms.ListBox lbxCalculation;
        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btnPbxClear;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnInfo;
    }
}

