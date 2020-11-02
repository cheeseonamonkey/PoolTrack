namespace Pol
{
    partial class MultiForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setAllTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSetAll = new System.Windows.Forms.Button();
            this.pnlTimes = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(465, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScrollMargin = new System.Drawing.Size(25, 25);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.setAllTimePicker);
            this.panel1.Controls.Add(this.btnSetAll);
            this.panel1.Controls.Add(this.pnlTimes);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbEmployees);
            this.panel1.Controls.Add(this.txtRoomNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGuest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 321);
            this.panel1.TabIndex = 8;
            // 
            // setAllTimePicker
            // 
            this.setAllTimePicker.CustomFormat = "";
            this.setAllTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAllTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.setAllTimePicker.Location = new System.Drawing.Point(117, 288);
            this.setAllTimePicker.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.setAllTimePicker.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.setAllTimePicker.Name = "setAllTimePicker";
            this.setAllTimePicker.ShowUpDown = true;
            this.setAllTimePicker.Size = new System.Drawing.Size(95, 23);
            this.setAllTimePicker.TabIndex = 15;
            this.setAllTimePicker.Value = new System.DateTime(2020, 7, 18, 18, 0, 0, 0);
            // 
            // btnSetAll
            // 
            this.btnSetAll.Location = new System.Drawing.Point(218, 288);
            this.btnSetAll.Name = "btnSetAll";
            this.btnSetAll.Size = new System.Drawing.Size(75, 23);
            this.btnSetAll.TabIndex = 14;
            this.btnSetAll.Text = "Set all";
            this.btnSetAll.UseVisualStyleBackColor = true;
            // 
            // pnlTimes
            // 
            this.pnlTimes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlTimes.AutoScroll = true;
            this.pnlTimes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTimes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.pnlTimes.ColumnCount = 3;
            this.pnlTimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlTimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlTimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTimes.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.pnlTimes.Location = new System.Drawing.Point(27, 159);
            this.pnlTimes.Name = "pnlTimes";
            this.pnlTimes.RowCount = 1;
            this.pnlTimes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlTimes.Size = new System.Drawing.Size(395, 123);
            this.pnlTimes.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.datePicker2);
            this.groupBox1.Controls.Add(this.datePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(169, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 75);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates:";
            // 
            // datePicker2
            // 
            this.datePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker2.Location = new System.Drawing.Point(40, 44);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(102, 23);
            this.datePicker2.TabIndex = 9;
            this.datePicker2.ValueChanged += new System.EventHandler(this.datePicker2_ValueChanged);
            // 
            // datePicker1
            // 
            this.datePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker1.Location = new System.Drawing.Point(40, 16);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(102, 23);
            this.datePicker1.TabIndex = 4;
            this.datePicker1.ValueChanged += new System.EventHandler(this.datePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "End:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(332, 46);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(100, 24);
            this.cmbEmployees.TabIndex = 6;
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNum.Location = new System.Drawing.Point(63, 18);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(44, 23);
            this.txtRoomNum.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guest";
            // 
            // txtGuest
            // 
            this.txtGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuest.Location = new System.Drawing.Point(63, 47);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(100, 23);
            this.txtGuest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room #";
            // 
            // MultiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(917, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.MinimumSize = new System.Drawing.Size(933, 606);
            this.Name = "MultiForm";
            this.Text = "Reserve multiple days";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel pnlTimes;
        private System.Windows.Forms.Button btnSetAll;
        private System.Windows.Forms.DateTimePicker setAllTimePicker;
    }
}