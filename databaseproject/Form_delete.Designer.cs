namespace databaseproject
{
    partial class Form_delete
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_pk1 = new System.Windows.Forms.TextBox();
            this.textBox_pk2 = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
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
            this.comboBox1.Location = new System.Drawing.Point(12, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(543, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(343, 222);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "PrimaryKey1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(615, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "PrimaryKey2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(371, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(304, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Primary Key(s) of the row you want to delete";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_pk1
            // 
            this.textBox_pk1.Location = new System.Drawing.Point(271, 274);
            this.textBox_pk1.Name = "textBox_pk1";
            this.textBox_pk1.Size = new System.Drawing.Size(210, 20);
            this.textBox_pk1.TabIndex = 6;
            // 
            // textBox_pk2
            // 
            this.textBox_pk2.Location = new System.Drawing.Point(543, 274);
            this.textBox_pk2.Name = "textBox_pk2";
            this.textBox_pk2.Size = new System.Drawing.Size(210, 20);
            this.textBox_pk2.TabIndex = 7;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(419, 322);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(189, 59);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(53, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(672, 20);
            this.textBox6.TabIndex = 30;
            this.textBox6.Text = "Please format input, strings as \'string\', date as \'YYYY-MM-DD\', boolean as either" +
    " TRUE or FALSE";
            // 
            // Form_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_pk2);
            this.Controls.Add(this.textBox_pk1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form_delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox_pk1;
        private System.Windows.Forms.TextBox textBox_pk2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox6;
    }
}