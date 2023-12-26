namespace Tyuiu.KulakovEE.Sprint7.Project.V2
{
    partial class FormAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_KEE = new System.Windows.Forms.Button();
            this.labelInfo_KEE = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBoxAvatar_KEE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KEE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_KEE
            // 
            this.buttonOK_KEE.BackColor = System.Drawing.Color.DimGray;
            this.buttonOK_KEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK_KEE.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_KEE.ForeColor = System.Drawing.Color.LightGray;
            this.buttonOK_KEE.Location = new System.Drawing.Point(7, 129);
            this.buttonOK_KEE.Name = "buttonOK_KEE";
            this.buttonOK_KEE.Size = new System.Drawing.Size(418, 33);
            this.buttonOK_KEE.TabIndex = 1;
            this.buttonOK_KEE.Text = "ОКЕЙ";
            this.buttonOK_KEE.UseVisualStyleBackColor = false;
            this.buttonOK_KEE.Click += new System.EventHandler(this.buttonOK_KEE_Click);
            // 
            // labelInfo_KEE
            // 
            this.labelInfo_KEE.AutoSize = true;
            this.labelInfo_KEE.Location = new System.Drawing.Point(136, 9);
            this.labelInfo_KEE.Name = "labelInfo_KEE";
            this.labelInfo_KEE.Size = new System.Drawing.Size(0, 13);
            this.labelInfo_KEE.TabIndex = 3;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Location = new System.Drawing.Point(113, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(284, 117);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBoxAvatar_KEE
            // 
            this.pictureBoxAvatar_KEE.BackgroundImage = global::Tyuiu.KulakovEE.Sprint7.Project.V2.Properties.Resources._Fl9TqTA5_Y;
            this.pictureBoxAvatar_KEE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAvatar_KEE.Location = new System.Drawing.Point(7, 9);
            this.pictureBoxAvatar_KEE.Name = "pictureBoxAvatar_KEE";
            this.pictureBoxAvatar_KEE.Size = new System.Drawing.Size(100, 117);
            this.pictureBoxAvatar_KEE.TabIndex = 5;
            this.pictureBoxAvatar_KEE.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.pictureBoxAvatar_KEE);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelInfo_KEE);
            this.Controls.Add(this.buttonOK_KEE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 204);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 204);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prod. by Gocha HoodRich ®";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KEE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK_KEE;
        private System.Windows.Forms.Label labelInfo_KEE;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_KEE;
    }
}