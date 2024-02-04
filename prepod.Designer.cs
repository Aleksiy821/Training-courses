namespace Kursovoy_project
{
    partial class prepod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prepod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.job_title = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.family = new System.Windows.Forms.TextBox();
            this.Imya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDacc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.IDacc);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.job_title);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.family);
            this.panel1.Controls.Add(this.Imya);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 313);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(450, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 32);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавть преподователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(490, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 32);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // job_title
            // 
            this.job_title.Location = new System.Drawing.Point(306, 191);
            this.job_title.Name = "job_title";
            this.job_title.Size = new System.Drawing.Size(191, 22);
            this.job_title.TabIndex = 4;
            this.job_title.Enter += new System.EventHandler(this.job_title_Enter);
            this.job_title.Leave += new System.EventHandler(this.job_title_Leave);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(306, 122);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(191, 22);
            this.surname.TabIndex = 3;
            this.surname.Enter += new System.EventHandler(this.surname_Enter);
            this.surname.Leave += new System.EventHandler(this.surname_Leave);
            // 
            // family
            // 
            this.family.Location = new System.Drawing.Point(36, 191);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(191, 22);
            this.family.TabIndex = 2;
            this.family.Enter += new System.EventHandler(this.family_Enter);
            this.family.Leave += new System.EventHandler(this.family_Leave);
            // 
            // Imya
            // 
            this.Imya.Location = new System.Drawing.Point(36, 122);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(191, 22);
            this.Imya.TabIndex = 1;
            this.Imya.Enter += new System.EventHandler(this.Imya_Enter);
            this.Imya.Leave += new System.EventHandler(this.Imya_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление преподователей";
            // 
            // IDacc
            // 
            this.IDacc.Location = new System.Drawing.Point(170, 238);
            this.IDacc.Name = "IDacc";
            this.IDacc.Size = new System.Drawing.Size(191, 22);
            this.IDacc.TabIndex = 24;
            this.IDacc.Enter += new System.EventHandler(this.IDacc_Enter);
            this.IDacc.Leave += new System.EventHandler(this.IDacc_Leave);
            // 
            // prepod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 313);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prepod";
            this.Text = "prepod";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox job_title;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox family;
        private System.Windows.Forms.TextBox Imya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox IDacc;
    }
}