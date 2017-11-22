namespace PLForms
{
    partial class management
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.getAllCars_button = new System.Windows.Forms.Button();
            this.getAllClients_button = new System.Windows.Forms.Button();
            this.getAllRentings_button = new System.Windows.Forms.Button();
            this.getAllFaults_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Manager_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 302);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.getAllCars_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.getAllClients_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.getAllRentings_button, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.getAllFaults_button, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 154);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 145);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // getAllCars_button
            // 
            this.getAllCars_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getAllCars_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllCars_button.Location = new System.Drawing.Point(26, 11);
            this.getAllCars_button.Name = "getAllCars_button";
            this.getAllCars_button.Size = new System.Drawing.Size(85, 50);
            this.getAllCars_button.TabIndex = 0;
            this.getAllCars_button.Text = "get all cars";
            this.getAllCars_button.UseVisualStyleBackColor = true;
            this.getAllCars_button.Click += new System.EventHandler(this.getAllCars_button_Click);
            // 
            // getAllClients_button
            // 
            this.getAllClients_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getAllClients_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllClients_button.Location = new System.Drawing.Point(163, 11);
            this.getAllClients_button.Name = "getAllClients_button";
            this.getAllClients_button.Size = new System.Drawing.Size(85, 50);
            this.getAllClients_button.TabIndex = 1;
            this.getAllClients_button.Text = "get all clients";
            this.getAllClients_button.UseVisualStyleBackColor = true;
            this.getAllClients_button.Click += new System.EventHandler(this.getAllClients_button_Click);
            // 
            // getAllRentings_button
            // 
            this.getAllRentings_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getAllRentings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllRentings_button.Location = new System.Drawing.Point(26, 83);
            this.getAllRentings_button.Name = "getAllRentings_button";
            this.getAllRentings_button.Size = new System.Drawing.Size(85, 50);
            this.getAllRentings_button.TabIndex = 2;
            this.getAllRentings_button.Text = "get all rentings";
            this.getAllRentings_button.UseVisualStyleBackColor = true;
            this.getAllRentings_button.Click += new System.EventHandler(this.getAllRentings_button_Click);
            // 
            // getAllFaults_button
            // 
            this.getAllFaults_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getAllFaults_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllFaults_button.Location = new System.Drawing.Point(163, 83);
            this.getAllFaults_button.Name = "getAllFaults_button";
            this.getAllFaults_button.Size = new System.Drawing.Size(85, 50);
            this.getAllFaults_button.TabIndex = 3;
            this.getAllFaults_button.Text = "get all faults";
            this.getAllFaults_button.UseVisualStyleBackColor = true;
            this.getAllFaults_button.Click += new System.EventHandler(this.getAllFaults_button_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.maskedTextBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Manager_label, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(274, 145);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(87, 62);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '●';
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(99, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager_label
            // 
            this.Manager_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Manager_label.AutoSize = true;
            this.Manager_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager_label.Location = new System.Drawing.Point(22, 8);
            this.Manager_label.Name = "Manager_label";
            this.Manager_label.Size = new System.Drawing.Size(229, 32);
            this.Manager_label.TabIndex = 2;
            this.Manager_label.Text = "wlecome manager! please enter your\r\n                    password to continue";
            // 
            // management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 302);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "management";
            this.Text = "management";
            this.Load += new System.EventHandler(this.management_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button getAllCars_button;
        private System.Windows.Forms.Button getAllClients_button;
        private System.Windows.Forms.Button getAllRentings_button;
        private System.Windows.Forms.Button getAllFaults_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Manager_label;
    }
}