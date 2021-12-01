namespace FileCat
{
    partial class mainFrm
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
            this.resultLst = new System.Windows.Forms.ListBox();
            this.scanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLst
            // 
            this.resultLst.FormattingEnabled = true;
            this.resultLst.Location = new System.Drawing.Point(4, 43);
            this.resultLst.Name = "resultLst";
            this.resultLst.Size = new System.Drawing.Size(413, 225);
            this.resultLst.TabIndex = 0;
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(4, 12);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(148, 23);
            this.scanBtn.TabIndex = 1;
            this.scanBtn.Text = "Move Files";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.resultLst);
            this.Name = "mainFrm";
            this.Text = "Desktop Files Categurizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultLst;
        private System.Windows.Forms.Button scanBtn;
    }
}

