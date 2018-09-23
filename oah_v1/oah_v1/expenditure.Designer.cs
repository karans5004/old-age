namespace oah_v1
{
    partial class expenditure
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
            this.Date = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.servicename1 = new System.Windows.Forms.TextBox();
            this.ServiceName = new System.Windows.Forms.Label();
            this.ServiceId = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Service_types = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(406, 128);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(64, 24);
            this.Date.TabIndex = 25;
            this.Date.Text = "Date :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(508, 129);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.CadetBlue;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(336, 332);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(106, 42);
            this.Submit.TabIndex = 23;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 22;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(107, 251);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(94, 24);
            this.Price.TabIndex = 21;
            this.Price.Text = "Amount :";
            // 
            // servicename1
            // 
            this.servicename1.Location = new System.Drawing.Point(225, 187);
            this.servicename1.Name = "servicename1";
            this.servicename1.Size = new System.Drawing.Size(121, 20);
            this.servicename1.TabIndex = 20;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSize = true;
            this.ServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceName.Location = new System.Drawing.Point(62, 187);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(153, 24);
            this.ServiceName.TabIndex = 19;
            this.ServiceName.Text = "Service Name :";
            // 
            // ServiceId
            // 
            this.ServiceId.AutoSize = true;
            this.ServiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceId.Location = new System.Drawing.Point(76, 128);
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.Size = new System.Drawing.Size(103, 24);
            this.ServiceId.TabIndex = 18;
            this.ServiceId.Text = "Service Id";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Service_types
            // 
            this.Service_types.AutoSize = true;
            this.Service_types.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service_types.Location = new System.Drawing.Point(48, 67);
            this.Service_types.Name = "Service_types";
            this.Service_types.Size = new System.Drawing.Size(131, 24);
            this.Service_types.TabIndex = 16;
            this.Service_types.Text = "Service Types";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "                         Expenditure Details                      ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 387);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.servicename1);
            this.Controls.Add(this.ServiceName);
            this.Controls.Add(this.ServiceId);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Service_types);
            this.Controls.Add(this.label1);
            this.Name = "expenditure";
            this.Text = "expenditure";
            this.Load += new System.EventHandler(this.expenditure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox servicename1;
        private System.Windows.Forms.Label ServiceName;
        private System.Windows.Forms.Label ServiceId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Service_types;
        private System.Windows.Forms.Label label1;
    }
}