namespace databaseproject
{
    partial class Form_update
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_pk2 = new System.Windows.Forms.TextBox();
            this.textBox_pk1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_val1 = new System.Windows.Forms.TextBox();
            this.textBox_val3 = new System.Windows.Forms.TextBox();
            this.textBox_val2 = new System.Windows.Forms.TextBox();
            this.textBox_val4 = new System.Windows.Forms.TextBox();
            this.textBox_val5 = new System.Windows.Forms.TextBox();
            this.textBox_val6 = new System.Windows.Forms.TextBox();
            this.textBox_col6 = new System.Windows.Forms.TextBox();
            this.textBox_col5 = new System.Windows.Forms.TextBox();
            this.textBox_col4 = new System.Windows.Forms.TextBox();
            this.textBox_col2 = new System.Windows.Forms.TextBox();
            this.textBox_col3 = new System.Windows.Forms.TextBox();
            this.textBox_col1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "employee",
            "admin",
            "hotel",
            "room",
            "guest",
            "bill",
            "cleaning",
            "cooking",
            "meal",
            "inventory",
            "amenity",
            "event",
            "runs",
            "cleans",
            "readies",
            "registers",
            "cooks",
            "charges"});
            this.comboBox1.Location = new System.Drawing.Point(20, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(282, 379);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(189, 59);
            this.button_update.TabIndex = 16;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_pk2
            // 
            this.textBox_pk2.Location = new System.Drawing.Point(554, 118);
            this.textBox_pk2.Name = "textBox_pk2";
            this.textBox_pk2.Size = new System.Drawing.Size(210, 20);
            this.textBox_pk2.TabIndex = 15;
            // 
            // textBox_pk1
            // 
            this.textBox_pk1.Location = new System.Drawing.Point(282, 118);
            this.textBox_pk1.Name = "textBox_pk1";
            this.textBox_pk1.Size = new System.Drawing.Size(210, 20);
            this.textBox_pk1.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(382, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(304, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Primary Key(s) of the row you want to update";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(626, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "PrimaryKey2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(354, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "PrimaryKey1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(554, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox_val1
            // 
            this.textBox_val1.Location = new System.Drawing.Point(20, 300);
            this.textBox_val1.Name = "textBox_val1";
            this.textBox_val1.Size = new System.Drawing.Size(88, 20);
            this.textBox_val1.TabIndex = 17;
            // 
            // textBox_val3
            // 
            this.textBox_val3.Location = new System.Drawing.Point(282, 300);
            this.textBox_val3.Name = "textBox_val3";
            this.textBox_val3.Size = new System.Drawing.Size(93, 20);
            this.textBox_val3.TabIndex = 18;
            // 
            // textBox_val2
            // 
            this.textBox_val2.Location = new System.Drawing.Point(147, 300);
            this.textBox_val2.Name = "textBox_val2";
            this.textBox_val2.Size = new System.Drawing.Size(88, 20);
            this.textBox_val2.TabIndex = 19;
            // 
            // textBox_val4
            // 
            this.textBox_val4.Location = new System.Drawing.Point(424, 300);
            this.textBox_val4.Name = "textBox_val4";
            this.textBox_val4.Size = new System.Drawing.Size(88, 20);
            this.textBox_val4.TabIndex = 20;
            // 
            // textBox_val5
            // 
            this.textBox_val5.Location = new System.Drawing.Point(565, 300);
            this.textBox_val5.Name = "textBox_val5";
            this.textBox_val5.Size = new System.Drawing.Size(88, 20);
            this.textBox_val5.TabIndex = 21;
            // 
            // textBox_val6
            // 
            this.textBox_val6.Location = new System.Drawing.Point(700, 300);
            this.textBox_val6.Name = "textBox_val6";
            this.textBox_val6.Size = new System.Drawing.Size(88, 20);
            this.textBox_val6.TabIndex = 22;
            // 
            // textBox_col6
            // 
            this.textBox_col6.Location = new System.Drawing.Point(700, 267);
            this.textBox_col6.Name = "textBox_col6";
            this.textBox_col6.ReadOnly = true;
            this.textBox_col6.Size = new System.Drawing.Size(88, 20);
            this.textBox_col6.TabIndex = 28;
            // 
            // textBox_col5
            // 
            this.textBox_col5.Location = new System.Drawing.Point(565, 267);
            this.textBox_col5.Name = "textBox_col5";
            this.textBox_col5.ReadOnly = true;
            this.textBox_col5.Size = new System.Drawing.Size(88, 20);
            this.textBox_col5.TabIndex = 27;
            // 
            // textBox_col4
            // 
            this.textBox_col4.Location = new System.Drawing.Point(424, 267);
            this.textBox_col4.Name = "textBox_col4";
            this.textBox_col4.ReadOnly = true;
            this.textBox_col4.Size = new System.Drawing.Size(88, 20);
            this.textBox_col4.TabIndex = 26;
            // 
            // textBox_col2
            // 
            this.textBox_col2.Location = new System.Drawing.Point(147, 267);
            this.textBox_col2.Name = "textBox_col2";
            this.textBox_col2.ReadOnly = true;
            this.textBox_col2.Size = new System.Drawing.Size(88, 20);
            this.textBox_col2.TabIndex = 25;
            // 
            // textBox_col3
            // 
            this.textBox_col3.Location = new System.Drawing.Point(282, 267);
            this.textBox_col3.Name = "textBox_col3";
            this.textBox_col3.ReadOnly = true;
            this.textBox_col3.Size = new System.Drawing.Size(93, 20);
            this.textBox_col3.TabIndex = 24;
            // 
            // textBox_col1
            // 
            this.textBox_col1.Location = new System.Drawing.Point(20, 267);
            this.textBox_col1.Name = "textBox_col1";
            this.textBox_col1.ReadOnly = true;
            this.textBox_col1.Size = new System.Drawing.Size(88, 20);
            this.textBox_col1.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(52, 196);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(672, 20);
            this.textBox6.TabIndex = 29;
            this.textBox6.Text = "Please format input, strings as \'string\', date as \'YYYY-MM-DD\', boolean as either" +
    " TRUE or FALSE";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(53, 170);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(670, 20);
            this.textBox7.TabIndex = 30;
            this.textBox7.Text = "Enter attribute new values for the data";
            // 
            // Form_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox_col6);
            this.Controls.Add(this.textBox_col5);
            this.Controls.Add(this.textBox_col4);
            this.Controls.Add(this.textBox_col2);
            this.Controls.Add(this.textBox_col3);
            this.Controls.Add(this.textBox_col1);
            this.Controls.Add(this.textBox_val6);
            this.Controls.Add(this.textBox_val5);
            this.Controls.Add(this.textBox_val4);
            this.Controls.Add(this.textBox_val2);
            this.Controls.Add(this.textBox_val3);
            this.Controls.Add(this.textBox_val1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_pk2);
            this.Controls.Add(this.textBox_pk1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form_update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_pk2;
        private System.Windows.Forms.TextBox textBox_pk1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_val1;
        private System.Windows.Forms.TextBox textBox_val3;
        private System.Windows.Forms.TextBox textBox_val2;
        private System.Windows.Forms.TextBox textBox_val4;
        private System.Windows.Forms.TextBox textBox_val5;
        private System.Windows.Forms.TextBox textBox_val6;
        private System.Windows.Forms.TextBox textBox_col6;
        private System.Windows.Forms.TextBox textBox_col5;
        private System.Windows.Forms.TextBox textBox_col4;
        private System.Windows.Forms.TextBox textBox_col2;
        private System.Windows.Forms.TextBox textBox_col3;
        private System.Windows.Forms.TextBox textBox_col1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}