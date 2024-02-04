namespace Kursovoy_project
{
    partial class oplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oplata));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.expiration_date = new System.Windows.Forms.TextBox();
            this.date_of_payment = new System.Windows.Forms.TextBox();
            this.payment_number = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.family = new System.Windows.Forms.TextBox();
            this.Imya = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.bodyLabel);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.expiration_date);
            this.panel1.Controls.Add(this.date_of_payment);
            this.panel1.Controls.Add(this.payment_number);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.family);
            this.panel1.Controls.Add(this.Imya);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 354);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(228, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Вывести";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.bodyLabel.Location = new System.Drawing.Point(60, 305);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(44, 16);
            this.bodyLabel.TabIndex = 10;
            this.bodyLabel.Text = "label2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(365, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(260, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оплата";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // expiration_date
            // 
            this.expiration_date.Location = new System.Drawing.Point(365, 193);
            this.expiration_date.Name = "expiration_date";
            this.expiration_date.Size = new System.Drawing.Size(213, 22);
            this.expiration_date.TabIndex = 6;
            this.expiration_date.MouseEnter += new System.EventHandler(this.expiration_date_MouseEnter);
            this.expiration_date.MouseLeave += new System.EventHandler(this.expiration_date_MouseLeave);
            // 
            // date_of_payment
            // 
            this.date_of_payment.Location = new System.Drawing.Point(365, 134);
            this.date_of_payment.Name = "date_of_payment";
            this.date_of_payment.Size = new System.Drawing.Size(213, 22);
            this.date_of_payment.TabIndex = 5;
            this.date_of_payment.MouseEnter += new System.EventHandler(this.date_of_payment_MouseEnter);
            this.date_of_payment.MouseLeave += new System.EventHandler(this.date_of_payment_MouseLeave);
            // 
            // payment_number
            // 
            this.payment_number.Location = new System.Drawing.Point(365, 74);
            this.payment_number.Name = "payment_number";
            this.payment_number.Size = new System.Drawing.Size(213, 22);
            this.payment_number.TabIndex = 4;
            this.payment_number.MouseEnter += new System.EventHandler(this.payment_number_MouseEnter);
            this.payment_number.MouseLeave += new System.EventHandler(this.payment_number_MouseLeave);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(51, 262);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(213, 22);
            this.surname.TabIndex = 3;
            this.surname.MouseEnter += new System.EventHandler(this.surname_MouseEnter);
            this.surname.MouseLeave += new System.EventHandler(this.surname_MouseLeave);
            // 
            // family
            // 
            this.family.Location = new System.Drawing.Point(51, 193);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(213, 22);
            this.family.TabIndex = 2;
            this.family.MouseEnter += new System.EventHandler(this.family_MouseEnter);
            this.family.MouseLeave += new System.EventHandler(this.family_MouseLeave);
            // 
            // Imya
            // 
            this.Imya.Location = new System.Drawing.Point(51, 134);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(213, 22);
            this.Imya.TabIndex = 1;
            this.Imya.MouseEnter += new System.EventHandler(this.Imya_MouseEnter);
            this.Imya.MouseLeave += new System.EventHandler(this.Imya_MouseLeave);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(51, 74);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(213, 22);
            this.ID.TabIndex = 0;
            this.ID.MouseEnter += new System.EventHandler(this.ID_MouseEnter);
            this.ID.MouseLeave += new System.EventHandler(this.ID_MouseLeave);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(564, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(605, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 34);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // oplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 354);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oplata";
            this.Text = "oplata";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox expiration_date;
        private System.Windows.Forms.TextBox date_of_payment;
        private System.Windows.Forms.TextBox payment_number;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.TextBox Imya;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Button button5;
    }
}