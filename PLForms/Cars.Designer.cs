namespace PLForms
{
    partial class CarsForm
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
            this.License_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Manufactor_comboBox = new System.Windows.Forms.ComboBox();
            this.Engine_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AoutOrManual_comboBox = new System.Windows.Forms.ComboBox();
            this.AoutOrManual_label = new System.Windows.Forms.Label();
            this.Engine_label = new System.Windows.Forms.Label();
            this.Modek_label = new System.Windows.Forms.Label();
            this.Manufactor_label = new System.Windows.Forms.Label();
            this.License_label = new System.Windows.Forms.Label();
            this.Prodact_label = new System.Windows.Forms.Label();
            this.Branch_label = new System.Windows.Forms.Label();
            this.ProdactDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.KM_label = new System.Windows.Forms.Label();
            this.Doors_label = new System.Windows.Forms.Label();
            this.Passengars_label = new System.Windows.Forms.Label();
            this.KM_textBox = new System.Windows.Forms.TextBox();
            this.Doors_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Passengers_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Branch_comboBox = new System.Windows.Forms.ComboBox();
            this.Model_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Engine_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doors_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passengers_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // License_comboBox
            // 
            this.License_comboBox.FormattingEnabled = true;
            this.License_comboBox.Location = new System.Drawing.Point(125, 27);
            this.License_comboBox.Name = "License_comboBox";
            this.License_comboBox.Size = new System.Drawing.Size(159, 21);
            this.License_comboBox.TabIndex = 0;
            this.License_comboBox.SelectedIndexChanged += new System.EventHandler(this.License_comboBox_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Model_comboBox);
            this.groupBox.Controls.Add(this.Manufactor_comboBox);
            this.groupBox.Controls.Add(this.Engine_numericUpDown);
            this.groupBox.Controls.Add(this.AoutOrManual_comboBox);
            this.groupBox.Controls.Add(this.AoutOrManual_label);
            this.groupBox.Controls.Add(this.Engine_label);
            this.groupBox.Controls.Add(this.Modek_label);
            this.groupBox.Controls.Add(this.Manufactor_label);
            this.groupBox.Location = new System.Drawing.Point(25, 150);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(278, 210);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "type";
            // 
            // Manufactor_comboBox
            // 
            this.Manufactor_comboBox.FormattingEnabled = true;
            this.Manufactor_comboBox.Location = new System.Drawing.Point(121, 43);
            this.Manufactor_comboBox.Name = "Manufactor_comboBox";
            this.Manufactor_comboBox.Size = new System.Drawing.Size(100, 21);
            this.Manufactor_comboBox.TabIndex = 12;
            this.Manufactor_comboBox.SelectedIndexChanged += new System.EventHandler(this.Manufactor_comboBox_SelectedIndexChanged);
            // 
            // Engine_numericUpDown
            // 
            this.Engine_numericUpDown.Location = new System.Drawing.Point(121, 137);
            this.Engine_numericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Engine_numericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Engine_numericUpDown.Name = "Engine_numericUpDown";
            this.Engine_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Engine_numericUpDown.TabIndex = 11;
            this.Engine_numericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // AoutOrManual_comboBox
            // 
            this.AoutOrManual_comboBox.FormattingEnabled = true;
            this.AoutOrManual_comboBox.Location = new System.Drawing.Point(121, 177);
            this.AoutOrManual_comboBox.Name = "AoutOrManual_comboBox";
            this.AoutOrManual_comboBox.Size = new System.Drawing.Size(121, 21);
            this.AoutOrManual_comboBox.TabIndex = 10;
            // 
            // AoutOrManual_label
            // 
            this.AoutOrManual_label.AutoSize = true;
            this.AoutOrManual_label.Location = new System.Drawing.Point(29, 180);
            this.AoutOrManual_label.Name = "AoutOrManual_label";
            this.AoutOrManual_label.Size = new System.Drawing.Size(69, 13);
            this.AoutOrManual_label.TabIndex = 7;
            this.AoutOrManual_label.Text = "Aout/Manual";
            // 
            // Engine_label
            // 
            this.Engine_label.AutoSize = true;
            this.Engine_label.Location = new System.Drawing.Point(29, 137);
            this.Engine_label.Name = "Engine_label";
            this.Engine_label.Size = new System.Drawing.Size(40, 13);
            this.Engine_label.TabIndex = 6;
            this.Engine_label.Text = "Ebgine";
            // 
            // Modek_label
            // 
            this.Modek_label.AutoSize = true;
            this.Modek_label.Location = new System.Drawing.Point(29, 97);
            this.Modek_label.Name = "Modek_label";
            this.Modek_label.Size = new System.Drawing.Size(39, 13);
            this.Modek_label.TabIndex = 5;
            this.Modek_label.Text = "Model:";
            // 
            // Manufactor_label
            // 
            this.Manufactor_label.AutoSize = true;
            this.Manufactor_label.Location = new System.Drawing.Point(29, 52);
            this.Manufactor_label.Name = "Manufactor_label";
            this.Manufactor_label.Size = new System.Drawing.Size(64, 13);
            this.Manufactor_label.TabIndex = 4;
            this.Manufactor_label.Text = "Manufactor:";
            // 
            // License_label
            // 
            this.License_label.AutoSize = true;
            this.License_label.Location = new System.Drawing.Point(22, 30);
            this.License_label.Name = "License_label";
            this.License_label.Size = new System.Drawing.Size(86, 13);
            this.License_label.TabIndex = 0;
            this.License_label.Text = "LIcense number:";
            // 
            // Prodact_label
            // 
            this.Prodact_label.AutoSize = true;
            this.Prodact_label.Location = new System.Drawing.Point(22, 67);
            this.Prodact_label.Name = "Prodact_label";
            this.Prodact_label.Size = new System.Drawing.Size(67, 13);
            this.Prodact_label.TabIndex = 1;
            this.Prodact_label.Text = "prodact date";
            // 
            // Branch_label
            // 
            this.Branch_label.AutoSize = true;
            this.Branch_label.Location = new System.Drawing.Point(22, 99);
            this.Branch_label.Name = "Branch_label";
            this.Branch_label.Size = new System.Drawing.Size(44, 13);
            this.Branch_label.TabIndex = 2;
            this.Branch_label.Text = "Branch:";
            // 
            // ProdactDate_dateTimePicker
            // 
            this.ProdactDate_dateTimePicker.Location = new System.Drawing.Point(125, 67);
            this.ProdactDate_dateTimePicker.Name = "ProdactDate_dateTimePicker";
            this.ProdactDate_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ProdactDate_dateTimePicker.TabIndex = 5;
            // 
            // KM_label
            // 
            this.KM_label.AutoSize = true;
            this.KM_label.Location = new System.Drawing.Point(31, 394);
            this.KM_label.Name = "KM_label";
            this.KM_label.Size = new System.Drawing.Size(26, 13);
            this.KM_label.TabIndex = 6;
            this.KM_label.Text = "KM:";
            // 
            // Doors_label
            // 
            this.Doors_label.AutoSize = true;
            this.Doors_label.Location = new System.Drawing.Point(31, 427);
            this.Doors_label.Name = "Doors_label";
            this.Doors_label.Size = new System.Drawing.Size(38, 13);
            this.Doors_label.TabIndex = 7;
            this.Doors_label.Text = "Doors:";
            // 
            // Passengars_label
            // 
            this.Passengars_label.AutoSize = true;
            this.Passengars_label.Location = new System.Drawing.Point(31, 463);
            this.Passengars_label.Name = "Passengars_label";
            this.Passengars_label.Size = new System.Drawing.Size(65, 13);
            this.Passengars_label.TabIndex = 8;
            this.Passengars_label.Text = "Passengers:";
            // 
            // KM_textBox
            // 
            this.KM_textBox.Location = new System.Drawing.Point(125, 387);
            this.KM_textBox.Name = "KM_textBox";
            this.KM_textBox.Size = new System.Drawing.Size(159, 20);
            this.KM_textBox.TabIndex = 9;
            // 
            // Doors_numericUpDown
            // 
            this.Doors_numericUpDown.Location = new System.Drawing.Point(125, 425);
            this.Doors_numericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Doors_numericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Doors_numericUpDown.Name = "Doors_numericUpDown";
            this.Doors_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Doors_numericUpDown.TabIndex = 10;
            this.Doors_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Passengers_numericUpDown
            // 
            this.Passengers_numericUpDown.Location = new System.Drawing.Point(125, 461);
            this.Passengers_numericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Passengers_numericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Passengers_numericUpDown.Name = "Passengers_numericUpDown";
            this.Passengers_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Passengers_numericUpDown.TabIndex = 11;
            this.Passengers_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Branch_comboBox
            // 
            this.Branch_comboBox.FormattingEnabled = true;
            this.Branch_comboBox.Location = new System.Drawing.Point(125, 99);
            this.Branch_comboBox.Name = "Branch_comboBox";
            this.Branch_comboBox.Size = new System.Drawing.Size(159, 21);
            this.Branch_comboBox.TabIndex = 13;
            // 
            // Model_comboBox
            // 
            this.Model_comboBox.FormattingEnabled = true;
            this.Model_comboBox.Location = new System.Drawing.Point(121, 94);
            this.Model_comboBox.Name = "Model_comboBox";
            this.Model_comboBox.Size = new System.Drawing.Size(100, 21);
            this.Model_comboBox.TabIndex = 13;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 585);
            this.Controls.Add(this.Branch_comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passengers_numericUpDown);
            this.Controls.Add(this.Doors_numericUpDown);
            this.Controls.Add(this.KM_textBox);
            this.Controls.Add(this.Passengars_label);
            this.Controls.Add(this.Doors_label);
            this.Controls.Add(this.KM_label);
            this.Controls.Add(this.License_label);
            this.Controls.Add(this.Prodact_label);
            this.Controls.Add(this.Branch_label);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.License_comboBox);
            this.Controls.Add(this.ProdactDate_dateTimePicker);
            this.Name = "CarsForm";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Engine_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doors_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passengers_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox License_comboBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown Engine_numericUpDown;
        private System.Windows.Forms.ComboBox AoutOrManual_comboBox;
        private System.Windows.Forms.Label AoutOrManual_label;
        private System.Windows.Forms.Label Engine_label;
        private System.Windows.Forms.Label Modek_label;
        private System.Windows.Forms.Label Manufactor_label;
        private System.Windows.Forms.Label License_label;
        private System.Windows.Forms.Label Prodact_label;
        private System.Windows.Forms.Label Branch_label;
        private System.Windows.Forms.DateTimePicker ProdactDate_dateTimePicker;
        private System.Windows.Forms.Label KM_label;
        private System.Windows.Forms.Label Doors_label;
        private System.Windows.Forms.Label Passengars_label;
        private System.Windows.Forms.TextBox KM_textBox;
        private System.Windows.Forms.NumericUpDown Doors_numericUpDown;
        private System.Windows.Forms.NumericUpDown Passengers_numericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Branch_comboBox;
        private System.Windows.Forms.ComboBox Manufactor_comboBox;
        private System.Windows.Forms.ComboBox Model_comboBox;

    }
}