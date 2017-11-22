namespace PLForms
{
    partial class clientForm
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
            this.cardText = new System.Windows.Forms.TextBox();
            this.AdressText = new System.Windows.Forms.TextBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.labelID = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.labelCard = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.comboBoxid = new System.Windows.Forms.ComboBox();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cardText
            // 
            this.cardText.Location = new System.Drawing.Point(124, 193);
            this.cardText.Name = "cardText";
            this.cardText.Size = new System.Drawing.Size(198, 20);
            this.cardText.TabIndex = 1;
            // 
            // AdressText
            // 
            this.AdressText.Location = new System.Drawing.Point(122, 148);
            this.AdressText.Name = "AdressText";
            this.AdressText.Size = new System.Drawing.Size(198, 20);
            this.AdressText.TabIndex = 2;
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(124, 99);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(196, 20);
            this.dateTimeBirth.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(5, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(7, 13);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "\r\n";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(36, 148);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(41, 13);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "adress:";
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Location = new System.Drawing.Point(12, 193);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(99, 13);
            this.labelCard.TabIndex = 6;
            this.labelCard.Text = "Credit card number:";
            this.labelCard.Click += new System.EventHandler(this.labelCard_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Miriam", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(110, 261);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(133, 50);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxid
            // 
            this.comboBoxid.FormattingEnabled = true;
            this.comboBoxid.Location = new System.Drawing.Point(122, 12);
            this.comboBoxid.Name = "comboBoxid";
            this.comboBoxid.Size = new System.Drawing.Size(144, 21);
            this.comboBoxid.TabIndex = 8;
            this.comboBoxid.SelectedIndexChanged += new System.EventHandler(this.comboBoxid_SelectedIndexChanged);
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(24, 99);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(53, 13);
            this.labelBirthDay.TabIndex = 9;
            this.labelBirthDay.Text = "Birth Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "name:";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(124, 60);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(196, 20);
            this.textBoxname.TabIndex = 12;
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(332, 327);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.comboBoxid);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.AdressText);
            this.Controls.Add(this.cardText);
            this.Name = "clientForm";
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardText;
        private System.Windows.Forms.TextBox AdressText;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ComboBox comboBoxid;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxname;
    }
}