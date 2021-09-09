
namespace Task2StudentsSemechev
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGV = new System.Windows.Forms.DataGridView();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.tBStudents = new System.Windows.Forms.TextBox();
            this.lblStd = new System.Windows.Forms.Label();
            this.lblTests = new System.Windows.Forms.Label();
            this.tBTests = new System.Windows.Forms.TextBox();
            this.StdFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StdFName,
            this.StdLName});
            this.dGV.Location = new System.Drawing.Point(12, 12);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(797, 616);
            this.dGV.TabIndex = 0;
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.btnApply);
            this.gBox.Controls.Add(this.tBTests);
            this.gBox.Controls.Add(this.lblTests);
            this.gBox.Controls.Add(this.lblStd);
            this.gBox.Controls.Add(this.tBStudents);
            this.gBox.Location = new System.Drawing.Point(815, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(307, 184);
            this.gBox.TabIndex = 1;
            this.gBox.TabStop = false;
            this.gBox.Text = "Enter Data";
            // 
            // tBStudents
            // 
            this.tBStudents.Location = new System.Drawing.Point(173, 34);
            this.tBStudents.Name = "tBStudents";
            this.tBStudents.Size = new System.Drawing.Size(106, 22);
            this.tBStudents.TabIndex = 0;
            this.tBStudents.Text = "0";
            // 
            // lblStd
            // 
            this.lblStd.AutoSize = true;
            this.lblStd.Location = new System.Drawing.Point(6, 37);
            this.lblStd.Name = "lblStd";
            this.lblStd.Size = new System.Drawing.Size(134, 17);
            this.lblStd.TabIndex = 1;
            this.lblStd.Text = "Number of Students";
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Location = new System.Drawing.Point(6, 95);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(113, 17);
            this.lblTests.TabIndex = 2;
            this.lblTests.Text = "Number of Tests";
            // 
            // tBTests
            // 
            this.tBTests.Location = new System.Drawing.Point(173, 90);
            this.tBTests.Name = "tBTests";
            this.tBTests.Size = new System.Drawing.Size(106, 22);
            this.tBTests.TabIndex = 3;
            this.tBTests.Text = "0";
            // 
            // StdFName
            // 
            this.StdFName.HeaderText = "First Name";
            this.StdFName.MinimumWidth = 6;
            this.StdFName.Name = "StdFName";
            // 
            // StdLName
            // 
            this.StdLName.HeaderText = "Last Name";
            this.StdLName.MinimumWidth = 6;
            this.StdLName.Name = "StdLName";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(80, 139);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(154, 39);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(824, 530);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(298, 98);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Results";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 640);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.dGV);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.TextBox tBTests;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Label lblStd;
        private System.Windows.Forms.TextBox tBStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdLName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCalculate;
    }
}

