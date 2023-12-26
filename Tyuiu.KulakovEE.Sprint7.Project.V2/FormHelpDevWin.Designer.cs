
namespace Tyuiu.KulakovEE.Sprint7.Project.V2
{
    partial class FormHelpDevWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelpDevWin));
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.buttonCloseBackUnion = new System.Windows.Forms.Button();
            this.labelHelpDevWinInfo = new System.Windows.Forms.Label();
            this.groupBoxHelpDevWin = new System.Windows.Forms.GroupBox();
            this.groupBoxHelpDevWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenBrowser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenBrowser.Location = new System.Drawing.Point(12, 19);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(432, 48);
            this.btnOpenBrowser.TabIndex = 0;
            this.btnOpenBrowser.Text = "Связаться с нами";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // buttonCloseBackUnion
            // 
            this.buttonCloseBackUnion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseBackUnion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseBackUnion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCloseBackUnion.Location = new System.Drawing.Point(12, 73);
            this.buttonCloseBackUnion.Name = "buttonCloseBackUnion";
            this.buttonCloseBackUnion.Size = new System.Drawing.Size(432, 30);
            this.buttonCloseBackUnion.TabIndex = 1;
            this.buttonCloseBackUnion.Text = "Закрыть";
            this.buttonCloseBackUnion.UseVisualStyleBackColor = true;
            this.buttonCloseBackUnion.Click += new System.EventHandler(this.buttonCloseBackUnion_KEE_Click);
            // 
            // labelHelpDevWinInfo
            // 
            this.labelHelpDevWinInfo.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelpDevWinInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHelpDevWinInfo.Location = new System.Drawing.Point(9, 9);
            this.labelHelpDevWinInfo.Name = "labelHelpDevWinInfo";
            this.labelHelpDevWinInfo.Size = new System.Drawing.Size(435, 161);
            this.labelHelpDevWinInfo.TabIndex = 2;
            this.labelHelpDevWinInfo.Text = resources.GetString("labelHelpDevWinInfo.Text");
            this.labelHelpDevWinInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelpDevWinInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxHelpDevWin
            // 
            this.groupBoxHelpDevWin.Controls.Add(this.btnOpenBrowser);
            this.groupBoxHelpDevWin.Controls.Add(this.buttonCloseBackUnion);
            this.groupBoxHelpDevWin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxHelpDevWin.Location = new System.Drawing.Point(0, 160);
            this.groupBoxHelpDevWin.Name = "groupBoxHelpDevWin";
            this.groupBoxHelpDevWin.Size = new System.Drawing.Size(451, 118);
            this.groupBoxHelpDevWin.TabIndex = 3;
            this.groupBoxHelpDevWin.TabStop = false;
            // 
            // FormHelpDevWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(451, 278);
            this.Controls.Add(this.groupBoxHelpDevWin);
            this.Controls.Add(this.labelHelpDevWinInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(467, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(467, 317);
            this.Name = "FormHelpDevWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обратная связь и поддержка ";
            this.Load += new System.EventHandler(this.FormHelpDevWin_Load);
            this.groupBoxHelpDevWin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenBrowser;
        private System.Windows.Forms.Button buttonCloseBackUnion;
        private System.Windows.Forms.Label labelHelpDevWinInfo;
        private System.Windows.Forms.GroupBox groupBoxHelpDevWin;
    }
}