namespace Kursovoy_project
{
    partial class Zapis_na_curs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zapis_na_curs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name_kurs = new System.Windows.Forms.TextBox();
            this.course_date = new System.Windows.Forms.TextBox();
            this.id_accaunt = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.id_accaunt);
            this.panel1.Controls.Add(this.course_date);
            this.panel1.Controls.Add(this.name_kurs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Запись на курс";
            // 
            // name_kurs
            // 
            this.name_kurs.Location = new System.Drawing.Point(98, 138);
            this.name_kurs.Name = "name_kurs";
            this.name_kurs.Size = new System.Drawing.Size(228, 22);
            this.name_kurs.TabIndex = 10;
            this.name_kurs.Enter += new System.EventHandler(this.name_kurs_Enter);
            this.name_kurs.Leave += new System.EventHandler(this.name_kurs_Leave);
            // 
            // course_date
            // 
            this.course_date.Location = new System.Drawing.Point(98, 206);
            this.course_date.Name = "course_date";
            this.course_date.Size = new System.Drawing.Size(228, 22);
            this.course_date.TabIndex = 11;
            this.course_date.Enter += new System.EventHandler(this.course_date_Enter);
            this.course_date.Leave += new System.EventHandler(this.course_date_Leave);
            // 
            // id_accaunt
            // 
            this.id_accaunt.Location = new System.Drawing.Point(449, 138);
            this.id_accaunt.Name = "id_accaunt";
            this.id_accaunt.Size = new System.Drawing.Size(228, 22);
            this.id_accaunt.TabIndex = 12;
            this.id_accaunt.Enter += new System.EventHandler(this.id_accaunt_Enter);
            this.id_accaunt.Leave += new System.EventHandler(this.id_accaunt_Leave);
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(449, 206);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(228, 22);
            this.category.TabIndex = 13;
            this.category.Enter += new System.EventHandler(this.category_Enter);
            this.category.Leave += new System.EventHandler(this.category_Leave);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(277, 289);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(228, 22);
            this.price.TabIndex = 14;
            this.price.Enter += new System.EventHandler(this.price_Enter);
            this.price.Leave += new System.EventHandler(this.price_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Запись на курс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(721, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(762, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zapis_na_curs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zapis_na_curs";
            this.Text = "Zapis_na_curs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox id_accaunt;
        private System.Windows.Forms.TextBox course_date;
        private System.Windows.Forms.TextBox name_kurs;
    }
}