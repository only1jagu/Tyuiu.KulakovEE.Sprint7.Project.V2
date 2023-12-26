namespace Tyuiu.KulakovEE.Sprint7.Project.V2
{
    partial class FormMain
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
            this.menuStrip_KEE = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemInfo_KEE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInstruction_KEE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_KEE = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpBaton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_KEE = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMain_KEE = new System.Windows.Forms.Label();
            this.buttonEnterWorker_KEE = new System.Windows.Forms.Button();
            this.textBox1_KEElog = new System.Windows.Forms.TextBox();
            this.textBox2_KEEpass = new System.Windows.Forms.TextBox();
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1Auth = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip_KEE.SuspendLayout();
            this.groupBoxAuth.SuspendLayout();
            this.groupBox1Auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_KEE
            // 
            this.menuStrip_KEE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInfo_KEE,
            this.toolStripMenuItemExit_KEE});
            this.menuStrip_KEE.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_KEE.Name = "menuStrip_KEE";
            this.menuStrip_KEE.Size = new System.Drawing.Size(520, 27);
            this.menuStrip_KEE.TabIndex = 5;
            this.menuStrip_KEE.Text = "menuStrip1";
            // 
            // toolStripMenuItemInfo_KEE
            // 
            this.toolStripMenuItemInfo_KEE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInstruction_KEE,
            this.toolStripMenuItemAbout_KEE,
            this.ToolStripMenuItemHelpBaton});
            this.toolStripMenuItemInfo_KEE.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItemInfo_KEE.Name = "toolStripMenuItemInfo_KEE";
            this.toolStripMenuItemInfo_KEE.Size = new System.Drawing.Size(66, 23);
            this.toolStripMenuItemInfo_KEE.Text = "Помощь";
            this.toolStripMenuItemInfo_KEE.Click += new System.EventHandler(this.toolStripMenuItemInfo_KEE_Click);
            // 
            // toolStripMenuItemInstruction_KEE
            // 
            this.toolStripMenuItemInstruction_KEE.Name = "toolStripMenuItemInstruction_KEE";
            this.toolStripMenuItemInstruction_KEE.Size = new System.Drawing.Size(270, 24);
            this.toolStripMenuItemInstruction_KEE.Text = "Краткое руководство пользователя";
            this.toolStripMenuItemInstruction_KEE.Click += new System.EventHandler(this.toolStripMenuItemInstruction_KEE_Click);
            // 
            // toolStripMenuItemAbout_KEE
            // 
            this.toolStripMenuItemAbout_KEE.Name = "toolStripMenuItemAbout_KEE";
            this.toolStripMenuItemAbout_KEE.Size = new System.Drawing.Size(270, 24);
            this.toolStripMenuItemAbout_KEE.Text = "О программе ";
            this.toolStripMenuItemAbout_KEE.Click += new System.EventHandler(this.toolStripMenuItemAbout_KEE_Click);
            // 
            // ToolStripMenuItemHelpBaton
            // 
            this.ToolStripMenuItemHelpBaton.Name = "ToolStripMenuItemHelpBaton";
            this.ToolStripMenuItemHelpBaton.Size = new System.Drawing.Size(270, 24);
            this.ToolStripMenuItemHelpBaton.Text = "Тех. поддержка";
            this.ToolStripMenuItemHelpBaton.Click += new System.EventHandler(this.техПоддержкаToolStripMenuItem_Click);
            // 
            // toolStripMenuItemExit_KEE
            // 
            this.toolStripMenuItemExit_KEE.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItemExit_KEE.Name = "toolStripMenuItemExit_KEE";
            this.toolStripMenuItemExit_KEE.Size = new System.Drawing.Size(54, 23);
            this.toolStripMenuItemExit_KEE.Text = "Выход";
            this.toolStripMenuItemExit_KEE.Click += new System.EventHandler(this.toolStripMenuItemExit_KEE_Click);
            // 
            // labelMain_KEE
            // 
            this.labelMain_KEE.AutoSize = true;
            this.labelMain_KEE.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain_KEE.Location = new System.Drawing.Point(45, 6);
            this.labelMain_KEE.Name = "labelMain_KEE";
            this.labelMain_KEE.Size = new System.Drawing.Size(171, 39);
            this.labelMain_KEE.TabIndex = 6;
            this.labelMain_KEE.Text = "Авторизация:";
            this.labelMain_KEE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMain_KEE.Click += new System.EventHandler(this.labelMain_KEE_Click);
            // 
            // buttonEnterWorker_KEE
            // 
            this.buttonEnterWorker_KEE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEnterWorker_KEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterWorker_KEE.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterWorker_KEE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEnterWorker_KEE.Location = new System.Drawing.Point(46, 153);
            this.buttonEnterWorker_KEE.MaximumSize = new System.Drawing.Size(180, 40);
            this.buttonEnterWorker_KEE.MinimumSize = new System.Drawing.Size(180, 40);
            this.buttonEnterWorker_KEE.Name = "buttonEnterWorker_KEE";
            this.buttonEnterWorker_KEE.Size = new System.Drawing.Size(180, 40);
            this.buttonEnterWorker_KEE.TabIndex = 7;
            this.buttonEnterWorker_KEE.Text = "ВОЙТИ";
            this.buttonEnterWorker_KEE.UseVisualStyleBackColor = false;
            this.buttonEnterWorker_KEE.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_KEElog
            // 
            this.textBox1_KEElog.Location = new System.Drawing.Point(46, 82);
            this.textBox1_KEElog.Name = "textBox1_KEElog";
            this.textBox1_KEElog.Size = new System.Drawing.Size(180, 20);
            this.textBox1_KEElog.TabIndex = 8;
            // 
            // textBox2_KEEpass
            // 
            this.textBox2_KEEpass.Location = new System.Drawing.Point(46, 127);
            this.textBox2_KEEpass.Name = "textBox2_KEEpass";
            this.textBox2_KEEpass.Size = new System.Drawing.Size(180, 20);
            this.textBox2_KEEpass.TabIndex = 9;
            this.textBox2_KEEpass.UseSystemPasswordChar = true;
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxAuth.Controls.Add(this.button1);
            this.groupBoxAuth.Controls.Add(this.label2);
            this.groupBoxAuth.Controls.Add(this.label1);
            this.groupBoxAuth.Controls.Add(this.groupBox1Auth);
            this.groupBoxAuth.Controls.Add(this.buttonEnterWorker_KEE);
            this.groupBoxAuth.Controls.Add(this.textBox2_KEEpass);
            this.groupBoxAuth.Controls.Add(this.textBox1_KEElog);
            this.groupBoxAuth.Location = new System.Drawing.Point(123, 27);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(272, 240);
            this.groupBoxAuth.TabIndex = 10;
            this.groupBoxAuth.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин:";
            // 
            // groupBox1Auth
            // 
            this.groupBox1Auth.Controls.Add(this.labelMain_KEE);
            this.groupBox1Auth.Location = new System.Drawing.Point(6, 10);
            this.groupBox1Auth.Name = "groupBox1Auth";
            this.groupBox1Auth.Size = new System.Drawing.Size(260, 47);
            this.groupBox1Auth.TabIndex = 7;
            this.groupBox1Auth.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(79, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Забыли пароль?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(520, 267);
            this.Controls.Add(this.groupBoxAuth);
            this.Controls.Add(this.menuStrip_KEE);
            this.MaximumSize = new System.Drawing.Size(536, 306);
            this.MinimumSize = new System.Drawing.Size(536, 306);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip_KEE.ResumeLayout(false);
            this.menuStrip_KEE.PerformLayout();
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.groupBox1Auth.ResumeLayout(false);
            this.groupBox1Auth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_KEE;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_KEE;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_KEE;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_KEE;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_KEE;
        private System.Windows.Forms.Label labelMain_KEE;
        private System.Windows.Forms.Button buttonEnterWorker_KEE;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpBaton;
        private System.Windows.Forms.TextBox textBox1_KEElog;
        private System.Windows.Forms.TextBox textBox2_KEEpass;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1Auth;
        private System.Windows.Forms.Button button1;
    }
}