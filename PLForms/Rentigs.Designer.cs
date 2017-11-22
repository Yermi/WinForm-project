namespace PLForms
{
    partial class RentigsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.License_label = new System.Windows.Forms.Label();
            this.StartDate_label = new System.Windows.Forms.Label();
            this.EndDate_label = new System.Windows.Forms.Label();
            this.DriverID_label = new System.Windows.Forms.Label();
            this.carLicense_comboBox = new System.Windows.Forms.ComboBox();
            this.startRent_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endRent_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MdriverID_comboBox = new System.Windows.Forms.ComboBox();
            this.AnotherDriver_checkBox = new System.Windows.Forms.CheckBox();
            this.anotherDriverID_comboBox = new System.Windows.Forms.ComboBox();
            this.anotherDriverID_label = new System.Windows.Forms.Label();
            this.anotherDriver_groupBox = new System.Windows.Forms.GroupBox();
            this.KMstart_label = new System.Windows.Forms.Label();
            this.totalKM_label = new System.Windows.Forms.Label();
            this.totalKM_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderNum_label = new System.Windows.Forms.Label();
            this.ordernum_label1 = new System.Windows.Forms.Label();
            this.KM_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.Price_label2 = new System.Windows.Forms.Label();
            this.anotherDriver_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // License_label
            // 
            this.License_label.AutoSize = true;
            this.License_label.Location = new System.Drawing.Point(63, 88);
            this.License_label.Name = "License_label";
            this.License_label.Size = new System.Drawing.Size(0, 13);
            this.License_label.TabIndex = 2;
            this.License_label.Click += new System.EventHandler(this.License_label_Click);
            // 
            // StartDate_label
            // 
            this.StartDate_label.AutoSize = true;
            this.StartDate_label.Location = new System.Drawing.Point(60, 136);
            this.StartDate_label.Name = "StartDate_label";
            this.StartDate_label.Size = new System.Drawing.Size(65, 13);
            this.StartDate_label.TabIndex = 3;
            this.StartDate_label.Text = "start renting:";
            // 
            // EndDate_label
            // 
            this.EndDate_label.AutoSize = true;
            this.EndDate_label.Location = new System.Drawing.Point(57, 176);
            this.EndDate_label.Name = "EndDate_label";
            this.EndDate_label.Size = new System.Drawing.Size(64, 13);
            this.EndDate_label.TabIndex = 4;
            this.EndDate_label.Text = "End renting:";
            // 
            // DriverID_label
            // 
            this.DriverID_label.AutoSize = true;
            this.DriverID_label.Location = new System.Drawing.Point(54, 216);
            this.DriverID_label.Name = "DriverID_label";
            this.DriverID_label.Size = new System.Drawing.Size(75, 13);
            this.DriverID_label.TabIndex = 5;
            this.DriverID_label.Text = "main driver ID:";
            // 
            // carLicense_comboBox
            // 
            this.carLicense_comboBox.FormattingEnabled = true;
            this.carLicense_comboBox.Location = new System.Drawing.Point(159, 88);
            this.carLicense_comboBox.Name = "carLicense_comboBox";
            this.carLicense_comboBox.Size = new System.Drawing.Size(160, 21);
            this.carLicense_comboBox.TabIndex = 7;
            this.carLicense_comboBox.SelectedIndexChanged += new System.EventHandler(this.carLicense_comboBox_SelectedIndexChanged);
            // 
            // startRent_dateTimePicker
            // 
            this.startRent_dateTimePicker.Location = new System.Drawing.Point(159, 129);
            this.startRent_dateTimePicker.Name = "startRent_dateTimePicker";
            this.startRent_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startRent_dateTimePicker.TabIndex = 8;
            // 
            // endRent_dateTimePicker
            // 
            this.endRent_dateTimePicker.Location = new System.Drawing.Point(159, 170);
            this.endRent_dateTimePicker.Name = "endRent_dateTimePicker";
            this.endRent_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endRent_dateTimePicker.TabIndex = 9;
            // 
            // MdriverID_comboBox
            // 
            this.MdriverID_comboBox.FormattingEnabled = true;
            this.MdriverID_comboBox.Location = new System.Drawing.Point(159, 213);
            this.MdriverID_comboBox.Name = "MdriverID_comboBox";
            this.MdriverID_comboBox.Size = new System.Drawing.Size(160, 21);
            this.MdriverID_comboBox.TabIndex = 10;
            // 
            // AnotherDriver_checkBox
            // 
            this.AnotherDriver_checkBox.AutoSize = true;
            this.AnotherDriver_checkBox.Location = new System.Drawing.Point(63, 254);
            this.AnotherDriver_checkBox.Name = "AnotherDriver_checkBox";
            this.AnotherDriver_checkBox.Size = new System.Drawing.Size(91, 17);
            this.AnotherDriver_checkBox.TabIndex = 12;
            this.AnotherDriver_checkBox.Text = "another driver";
            this.AnotherDriver_checkBox.UseVisualStyleBackColor = true;
            this.AnotherDriver_checkBox.CheckedChanged += new System.EventHandler(this.AnotherDriver_checkBox_CheckedChanged);
            // 
            // anotherDriverID_comboBox
            // 
            this.anotherDriverID_comboBox.FormattingEnabled = true;
            this.anotherDriverID_comboBox.Location = new System.Drawing.Point(171, 24);
            this.anotherDriverID_comboBox.Name = "anotherDriverID_comboBox";
            this.anotherDriverID_comboBox.Size = new System.Drawing.Size(123, 21);
            this.anotherDriverID_comboBox.TabIndex = 13;
            // 
            // anotherDriverID_label
            // 
            this.anotherDriverID_label.AutoSize = true;
            this.anotherDriverID_label.Location = new System.Drawing.Point(37, 27);
            this.anotherDriverID_label.Name = "anotherDriverID_label";
            this.anotherDriverID_label.Size = new System.Drawing.Size(89, 13);
            this.anotherDriverID_label.TabIndex = 14;
            this.anotherDriverID_label.Text = "another driver ID:";
            // 
            // anotherDriver_groupBox
            // 
            this.anotherDriver_groupBox.Controls.Add(this.anotherDriverID_comboBox);
            this.anotherDriver_groupBox.Controls.Add(this.anotherDriverID_label);
            this.anotherDriver_groupBox.Location = new System.Drawing.Point(44, 277);
            this.anotherDriver_groupBox.Name = "anotherDriver_groupBox";
            this.anotherDriver_groupBox.Size = new System.Drawing.Size(329, 58);
            this.anotherDriver_groupBox.TabIndex = 15;
            this.anotherDriver_groupBox.TabStop = false;
            // 
            // KMstart_label
            // 
            this.KMstart_label.AutoSize = true;
            this.KMstart_label.Location = new System.Drawing.Point(69, 470);
            this.KMstart_label.Name = "KMstart_label";
            this.KMstart_label.Size = new System.Drawing.Size(56, 13);
            this.KMstart_label.TabIndex = 16;
            this.KMstart_label.Text = "KM count:";
            // 
            // totalKM_label
            // 
            this.totalKM_label.AutoSize = true;
            this.totalKM_label.Location = new System.Drawing.Point(55, 435);
            this.totalKM_label.Name = "totalKM_label";
            this.totalKM_label.Size = new System.Drawing.Size(74, 13);
            this.totalKM_label.TabIndex = 18;
            this.totalKM_label.Text = "totalKM_label:";
            // 
            // totalKM_textBox
            // 
            this.totalKM_textBox.Location = new System.Drawing.Point(159, 432);
            this.totalKM_textBox.Name = "totalKM_textBox";
            this.totalKM_textBox.Size = new System.Drawing.Size(160, 20);
            this.totalKM_textBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // orderNum_label
            // 
            this.orderNum_label.AutoSize = true;
            this.orderNum_label.Location = new System.Drawing.Point(12, 9);
            this.orderNum_label.Name = "orderNum_label";
            this.orderNum_label.Size = new System.Drawing.Size(0, 13);
            this.orderNum_label.TabIndex = 22;
            // 
            // ordernum_label1
            // 
            this.ordernum_label1.AutoSize = true;
            this.ordernum_label1.Location = new System.Drawing.Point(90, 9);
            this.ordernum_label1.Name = "ordernum_label1";
            this.ordernum_label1.Size = new System.Drawing.Size(0, 13);
            this.ordernum_label1.TabIndex = 23;
            // 
            // KM_label
            // 
            this.KM_label.AutoSize = true;
            this.KM_label.Location = new System.Drawing.Point(156, 470);
            this.KM_label.Name = "KM_label";
            this.KM_label.Size = new System.Drawing.Size(0, 13);
            this.KM_label.TabIndex = 24;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(81, 499);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(33, 13);
            this.price_label.TabIndex = 25;
            this.price_label.Text = "price:";
            // 
            // Price_label2
            // 
            this.Price_label2.AutoSize = true;
            this.Price_label2.Location = new System.Drawing.Point(156, 499);
            this.Price_label2.Name = "Price_label2";
            this.Price_label2.Size = new System.Drawing.Size(0, 13);
            this.Price_label2.TabIndex = 26;
            // 
            // RentigsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(409, 634);
            this.Controls.Add(this.Price_label2);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.KM_label);
            this.Controls.Add(this.ordernum_label1);
            this.Controls.Add(this.orderNum_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalKM_textBox);
            this.Controls.Add(this.totalKM_label);
            this.Controls.Add(this.KMstart_label);
            this.Controls.Add(this.anotherDriver_groupBox);
            this.Controls.Add(this.AnotherDriver_checkBox);
            this.Controls.Add(this.MdriverID_comboBox);
            this.Controls.Add(this.endRent_dateTimePicker);
            this.Controls.Add(this.startRent_dateTimePicker);
            this.Controls.Add(this.carLicense_comboBox);
            this.Controls.Add(this.DriverID_label);
            this.Controls.Add(this.EndDate_label);
            this.Controls.Add(this.StartDate_label);
            this.Controls.Add(this.License_label);
            this.Controls.Add(this.button1);
            this.Name = "RentigsForm";
            this.Text = "Rentigs";
            this.Load += new System.EventHandler(this.RentigsForm_Load);
            this.anotherDriver_groupBox.ResumeLayout(false);
            this.anotherDriver_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label License_label;
        private System.Windows.Forms.Label StartDate_label;
        private System.Windows.Forms.Label EndDate_label;
        private System.Windows.Forms.Label DriverID_label;
        private System.Windows.Forms.ComboBox carLicense_comboBox;
        private System.Windows.Forms.DateTimePicker startRent_dateTimePicker;
        private System.Windows.Forms.DateTimePicker endRent_dateTimePicker;
        private System.Windows.Forms.ComboBox MdriverID_comboBox;
        private System.Windows.Forms.CheckBox AnotherDriver_checkBox;
        private System.Windows.Forms.ComboBox anotherDriverID_comboBox;
        private System.Windows.Forms.Label anotherDriverID_label;
        private System.Windows.Forms.GroupBox anotherDriver_groupBox;
        private System.Windows.Forms.Label KMstart_label;
        private System.Windows.Forms.Label totalKM_label;
        private System.Windows.Forms.TextBox totalKM_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderNum_label;
        private System.Windows.Forms.Label ordernum_label1;
        private System.Windows.Forms.Label KM_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label Price_label2;

    }
}