namespace PLForms
{
    partial class choiceForClient
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
            this.AddClient = new System.Windows.Forms.Button();
            this.updateClientButton = new System.Windows.Forms.Button();
            this.deleteCluentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AddClient, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateClientButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteCluentButton, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddClient
            // 
            this.AddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClient.Location = new System.Drawing.Point(7, 18);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(80, 50);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // updateClientButton
            // 
            this.updateClientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClientButton.Location = new System.Drawing.Point(101, 105);
            this.updateClientButton.Name = "updateClientButton";
            this.updateClientButton.Size = new System.Drawing.Size(80, 50);
            this.updateClientButton.TabIndex = 1;
            this.updateClientButton.Text = "update client";
            this.updateClientButton.UseVisualStyleBackColor = true;
            this.updateClientButton.Click += new System.EventHandler(this.updateClientButton_Click);
            // 
            // deleteCluentButton
            // 
            this.deleteCluentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteCluentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCluentButton.Location = new System.Drawing.Point(196, 193);
            this.deleteCluentButton.Name = "deleteCluentButton";
            this.deleteCluentButton.Size = new System.Drawing.Size(80, 50);
            this.deleteCluentButton.TabIndex = 2;
            this.deleteCluentButton.Text = "delete client";
            this.deleteCluentButton.UseVisualStyleBackColor = true;
            this.deleteCluentButton.Click += new System.EventHandler(this.deleteCluentButton_Click);
            // 
            // choiceForClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "choiceForClient";
            this.Text = "choiceForClient";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button updateClientButton;
        private System.Windows.Forms.Button deleteCluentButton;
    }
}