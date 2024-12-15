namespace databaseproject
{
    partial class Form_report
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
            this.components = new System.ComponentModel.Container();
            this.button_eventorg = new System.Windows.Forms.Button();
            this.button_highbudget = new System.Windows.Forms.Button();
            this.button_manybeds = new System.Windows.Forms.Button();
            this.button_guestroom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new databaseproject.hotelDataSet();
            this.employeeseventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeseventsTableAdapter = new databaseproject.hotelDataSetTableAdapters.employeeseventsTableAdapter();
            this.higherbedroomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.higherbedroomsTableAdapter = new databaseproject.hotelDataSetTableAdapters.higherbedroomsTableAdapter();
            this.managedhigherbudgetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managedhigherbudgetsTableAdapter = new databaseproject.hotelDataSetTableAdapters.managedhigherbudgetsTableAdapter();
            this.managerviewguestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerviewguestsTableAdapter = new databaseproject.hotelDataSetTableAdapters.managerviewguestsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeseventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.higherbedroomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managedhigherbudgetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerviewguestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_eventorg
            // 
            this.button_eventorg.Location = new System.Drawing.Point(23, 12);
            this.button_eventorg.Name = "button_eventorg";
            this.button_eventorg.Size = new System.Drawing.Size(173, 66);
            this.button_eventorg.TabIndex = 0;
            this.button_eventorg.Text = "Event organizers";
            this.button_eventorg.UseVisualStyleBackColor = true;
            this.button_eventorg.Click += new System.EventHandler(this.button_eventorg_Click);
            // 
            // button_highbudget
            // 
            this.button_highbudget.Location = new System.Drawing.Point(23, 124);
            this.button_highbudget.Name = "button_highbudget";
            this.button_highbudget.Size = new System.Drawing.Size(173, 66);
            this.button_highbudget.TabIndex = 1;
            this.button_highbudget.Text = "High Budget Hotels";
            this.button_highbudget.UseVisualStyleBackColor = true;
            this.button_highbudget.Click += new System.EventHandler(this.button_highbudget_Click);
            // 
            // button_manybeds
            // 
            this.button_manybeds.Location = new System.Drawing.Point(23, 234);
            this.button_manybeds.Name = "button_manybeds";
            this.button_manybeds.Size = new System.Drawing.Size(173, 66);
            this.button_manybeds.TabIndex = 2;
            this.button_manybeds.Text = "Many beds";
            this.button_manybeds.UseVisualStyleBackColor = true;
            this.button_manybeds.Click += new System.EventHandler(this.button_manybeds_Click);
            // 
            // button_guestroom
            // 
            this.button_guestroom.Location = new System.Drawing.Point(23, 342);
            this.button_guestroom.Name = "button_guestroom";
            this.button_guestroom.Size = new System.Drawing.Size(173, 66);
            this.button_guestroom.TabIndex = 3;
            this.button_guestroom.Text = "Guest and room no.";
            this.button_guestroom.UseVisualStyleBackColor = true;
            this.button_guestroom.Click += new System.EventHandler(this.button_guestroom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 364);
            this.dataGridView1.TabIndex = 4;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeseventsBindingSource
            // 
            this.employeeseventsBindingSource.DataMember = "employeesevents";
            this.employeeseventsBindingSource.DataSource = this.hotelDataSet;
            // 
            // employeeseventsTableAdapter
            // 
            this.employeeseventsTableAdapter.ClearBeforeFill = true;
            // 
            // higherbedroomsBindingSource
            // 
            this.higherbedroomsBindingSource.DataMember = "higherbedrooms";
            this.higherbedroomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // higherbedroomsTableAdapter
            // 
            this.higherbedroomsTableAdapter.ClearBeforeFill = true;
            // 
            // managedhigherbudgetsBindingSource
            // 
            this.managedhigherbudgetsBindingSource.DataMember = "managedhigherbudgets";
            this.managedhigherbudgetsBindingSource.DataSource = this.hotelDataSet;
            // 
            // managedhigherbudgetsTableAdapter
            // 
            this.managedhigherbudgetsTableAdapter.ClearBeforeFill = true;
            // 
            // managerviewguestsBindingSource
            // 
            this.managerviewguestsBindingSource.DataMember = "managerviewguests";
            this.managerviewguestsBindingSource.DataSource = this.hotelDataSet;
            // 
            // managerviewguestsTableAdapter
            // 
            this.managerviewguestsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "View employees who organized or ran events";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "View hotels managed by managers with budgets greater than average";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "View bedrooms with higher than average beds";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 410);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "View just guests and their room number";
            // 
            // Form_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_guestroom);
            this.Controls.Add(this.button_manybeds);
            this.Controls.Add(this.button_highbudget);
            this.Controls.Add(this.button_eventorg);
            this.Name = "Form_report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeseventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.higherbedroomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managedhigherbudgetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerviewguestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_eventorg;
        private System.Windows.Forms.Button button_highbudget;
        private System.Windows.Forms.Button button_manybeds;
        private System.Windows.Forms.Button button_guestroom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource employeeseventsBindingSource;
        private hotelDataSetTableAdapters.employeeseventsTableAdapter employeeseventsTableAdapter;
        private System.Windows.Forms.BindingSource higherbedroomsBindingSource;
        private hotelDataSetTableAdapters.higherbedroomsTableAdapter higherbedroomsTableAdapter;
        private System.Windows.Forms.BindingSource managedhigherbudgetsBindingSource;
        private hotelDataSetTableAdapters.managedhigherbudgetsTableAdapter managedhigherbudgetsTableAdapter;
        private System.Windows.Forms.BindingSource managerviewguestsBindingSource;
        private hotelDataSetTableAdapters.managerviewguestsTableAdapter managerviewguestsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}