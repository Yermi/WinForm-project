namespace PLForms
{
    partial class ChiceForCars
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
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.buttonUpdateCar = new System.Windows.Forms.Button();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteCar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdateCar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddCar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCar.Location = new System.Drawing.Point(196, 192);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(80, 50);
            this.buttonDeleteCar.TabIndex = 0;
            this.buttonDeleteCar.Text = "Delete car";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // buttonUpdateCar
            // 
            this.buttonUpdateCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCar.Location = new System.Drawing.Point(101, 105);
            this.buttonUpdateCar.Name = "buttonUpdateCar";
            this.buttonUpdateCar.Size = new System.Drawing.Size(80, 50);
            this.buttonUpdateCar.TabIndex = 1;
            this.buttonUpdateCar.Text = "Update car";
            this.buttonUpdateCar.UseVisualStyleBackColor = true;
            this.buttonUpdateCar.Click += new System.EventHandler(this.buttonUpdateCar_Click);
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCar.Location = new System.Drawing.Point(7, 18);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(80, 50);
            this.buttonAddCar.TabIndex = 2;
            this.buttonAddCar.Text = "Add car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // ChiceForCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChiceForCars";
            this.Text = "ChiceForCars";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.Button buttonUpdateCar;
        private System.Windows.Forms.Button buttonAddCar;
    }
}