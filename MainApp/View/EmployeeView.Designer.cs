namespace MainApp.View
{
    partial class EmployeeView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.testDBDataSet = new MainApp.TestDBDataSet();
            this.p_right = new System.Windows.Forms.Panel();
            this.p_left = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            this.p_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "TestDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_right
            // 
            this.p_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_right.Location = new System.Drawing.Point(646, 0);
            this.p_right.Name = "p_right";
            this.p_right.Size = new System.Drawing.Size(207, 551);
            this.p_right.TabIndex = 0;
            // 
            // p_left
            // 
            this.p_left.AutoSize = true;
            this.p_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_left.Controls.Add(this.dgvEmployee);
            this.p_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_left.Location = new System.Drawing.Point(0, 0);
            this.p_left.Name = "p_left";
            this.p_left.Size = new System.Drawing.Size(646, 551);
            this.p_left.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(644, 549);
            this.dgvEmployee.TabIndex = 0;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.p_left);
            this.Controls.Add(this.p_right);
            this.Name = "EmployeeView";
            this.Size = new System.Drawing.Size(853, 551);
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            this.p_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TestDBDataSet testDBDataSet;
        private System.Windows.Forms.Panel p_right;
        private System.Windows.Forms.Panel p_left;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}
