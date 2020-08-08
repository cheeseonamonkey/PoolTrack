namespace Pol
{
    partial class EmployeesForm
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
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.txtEmployeeAdd = new System.Windows.Forms.TextBox();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(12, 12);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(181, 255);
            this.listViewEmployees.TabIndex = 0;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.List;
            this.listViewEmployees.SelectedIndexChanged += new System.EventHandler(this.listViewEmployees_SelectedIndexChanged);
            // 
            // txtEmployeeAdd
            // 
            this.txtEmployeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeAdd.Location = new System.Drawing.Point(199, 28);
            this.txtEmployeeAdd.Name = "txtEmployeeAdd";
            this.txtEmployeeAdd.Size = new System.Drawing.Size(113, 23);
            this.txtEmployeeAdd.TabIndex = 1;
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeAdd.Location = new System.Drawing.Point(199, 57);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(75, 36);
            this.btnEmployeeAdd.TabIndex = 2;
            this.btnEmployeeAdd.Text = "Add";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee name:";
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDelete.Location = new System.Drawing.Point(199, 231);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(75, 36);
            this.btnEmployeeDelete.TabIndex = 4;
            this.btnEmployeeDelete.Text = "Delete";
            this.btnEmployeeDelete.UseVisualStyleBackColor = true;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 296);
            this.Controls.Add(this.btnEmployeeDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.txtEmployeeAdd);
            this.Controls.Add(this.listViewEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Employee list";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.TextBox txtEmployeeAdd;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmployeeDelete;
    }
}