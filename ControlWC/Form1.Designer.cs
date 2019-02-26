namespace ControlWC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WCStart = new System.Windows.Forms.Button();
            this.pictureBoxWC = new System.Windows.Forms.PictureBox();
            this.LBCams = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBMP = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxH = new System.Windows.Forms.CheckBox();
            this.checkBoxV = new System.Windows.Forms.CheckBox();
            this.checkBoxS = new System.Windows.Forms.CheckBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.labelV = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            this.pictureBoxV = new System.Windows.Forms.PictureBox();
            this.pictureBoxH = new System.Windows.Forms.PictureBox();
            this.checkBoxWindows = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).BeginInit();
            this.SuspendLayout();
            // 
            // WCStart
            // 
            this.WCStart.Location = new System.Drawing.Point(859, 507);
            this.WCStart.Name = "WCStart";
            this.WCStart.Size = new System.Drawing.Size(75, 23);
            this.WCStart.TabIndex = 0;
            this.WCStart.Text = "Start";
            this.WCStart.UseVisualStyleBackColor = true;
            this.WCStart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBoxWC
            // 
            this.pictureBoxWC.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWC.Name = "pictureBoxWC";
            this.pictureBoxWC.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxWC.TabIndex = 1;
            this.pictureBoxWC.TabStop = false;
            this.pictureBoxWC.Click += new System.EventHandler(this.PictureBoxWC_Click);
            // 
            // LBCams
            // 
            this.LBCams.FormattingEnabled = true;
            this.LBCams.Location = new System.Drawing.Point(922, 504);
            this.LBCams.Name = "LBCams";
            this.LBCams.Size = new System.Drawing.Size(118, 121);
            this.LBCams.TabIndex = 2;
            this.LBCams.SelectedIndexChanged += new System.EventHandler(this.LBCams_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // pictureBoxBMP
            // 
            this.pictureBoxBMP.Location = new System.Drawing.Point(646, 0);
            this.pictureBoxBMP.Name = "pictureBoxBMP";
            this.pictureBoxBMP.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxBMP.TabIndex = 4;
            this.pictureBoxBMP.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(75, 19);
            this.trackBar1.Maximum = 256;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(172, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 86;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxH);
            this.groupBox1.Controls.Add(this.checkBoxV);
            this.groupBox1.Controls.Add(this.checkBoxS);
            this.groupBox1.Controls.Add(this.textBoxV);
            this.groupBox1.Controls.Add(this.textBoxS);
            this.groupBox1.Controls.Add(this.textBoxH);
            this.groupBox1.Controls.Add(this.labelV);
            this.groupBox1.Controls.Add(this.labelS);
            this.groupBox1.Controls.Add(this.labelH);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // checkBoxH
            // 
            this.checkBoxH.AutoCheck = false;
            this.checkBoxH.AutoSize = true;
            this.checkBoxH.Checked = true;
            this.checkBoxH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxH.Location = new System.Drawing.Point(323, 31);
            this.checkBoxH.Name = "checkBoxH";
            this.checkBoxH.Size = new System.Drawing.Size(15, 14);
            this.checkBoxH.TabIndex = 20;
            this.checkBoxH.UseVisualStyleBackColor = true;
            // 
            // checkBoxV
            // 
            this.checkBoxV.AutoSize = true;
            this.checkBoxV.Location = new System.Drawing.Point(323, 96);
            this.checkBoxV.Name = "checkBoxV";
            this.checkBoxV.Size = new System.Drawing.Size(15, 14);
            this.checkBoxV.TabIndex = 19;
            this.checkBoxV.UseVisualStyleBackColor = true;
            // 
            // checkBoxS
            // 
            this.checkBoxS.AutoSize = true;
            this.checkBoxS.Location = new System.Drawing.Point(323, 64);
            this.checkBoxS.Name = "checkBoxS";
            this.checkBoxS.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS.TabIndex = 18;
            this.checkBoxS.UseVisualStyleBackColor = true;
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(253, 90);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(49, 20);
            this.textBoxV.TabIndex = 16;
            this.textBoxV.Text = "40";
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(253, 58);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(49, 20);
            this.textBoxS.TabIndex = 15;
            this.textBoxS.Text = "40";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(253, 25);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(49, 20);
            this.textBoxH.TabIndex = 14;
            this.textBoxH.Text = "10";
            this.textBoxH.TextChanged += new System.EventHandler(this.TextBoxH_TextChanged);
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(6, 84);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(14, 13);
            this.labelV.TabIndex = 10;
            this.labelV.Text = "V";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(6, 51);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(14, 13);
            this.labelS.TabIndex = 9;
            this.labelS.Text = "S";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(6, 19);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(15, 13);
            this.labelH.TabIndex = 8;
            this.labelH.Text = "H";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(75, 84);
            this.trackBar3.Maximum = 256;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(172, 45);
            this.trackBar3.TabIndex = 7;
            this.trackBar3.Value = 73;
            this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(75, 51);
            this.trackBar2.Maximum = 256;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(172, 45);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.Value = 143;
            this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 483);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.Location = new System.Drawing.Point(567, 504);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxS.TabIndex = 8;
            this.pictureBoxS.TabStop = false;
            // 
            // pictureBoxV
            // 
            this.pictureBoxV.Location = new System.Drawing.Point(701, 504);
            this.pictureBoxV.Name = "pictureBoxV";
            this.pictureBoxV.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxV.TabIndex = 9;
            this.pictureBoxV.TabStop = false;
            // 
            // pictureBoxH
            // 
            this.pictureBoxH.Location = new System.Drawing.Point(433, 505);
            this.pictureBoxH.Name = "pictureBoxH";
            this.pictureBoxH.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxH.TabIndex = 10;
            this.pictureBoxH.TabStop = false;
            // 
            // checkBoxWindows
            // 
            this.checkBoxWindows.AutoSize = true;
            this.checkBoxWindows.Location = new System.Drawing.Point(433, 486);
            this.checkBoxWindows.Name = "checkBoxWindows";
            this.checkBoxWindows.Size = new System.Drawing.Size(211, 17);
            this.checkBoxWindows.TabIndex = 11;
            this.checkBoxWindows.Text = "Включить окна для настройки цвета";
            this.checkBoxWindows.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(836, 568);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(147, 486);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(198, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Включить изображение с камеры";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1028, 643);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxWindows);
            this.Controls.Add(this.pictureBoxH);
            this.Controls.Add(this.pictureBoxV);
            this.Controls.Add(this.pictureBoxS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxBMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBCams);
            this.Controls.Add(this.pictureBoxWC);
            this.Controls.Add(this.WCStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "ControlWC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WCStart;
        private System.Windows.Forms.PictureBox pictureBoxWC;
        private System.Windows.Forms.ListBox LBCams;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBMP;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxS;
        private System.Windows.Forms.PictureBox pictureBoxV;
        private System.Windows.Forms.PictureBox pictureBoxH;
        private System.Windows.Forms.CheckBox checkBoxV;
        private System.Windows.Forms.CheckBox checkBoxS;
        private System.Windows.Forms.CheckBox checkBoxH;
        private System.Windows.Forms.CheckBox checkBoxWindows;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

