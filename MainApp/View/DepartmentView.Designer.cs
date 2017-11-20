namespace MainApp.View
{
    partial class DepartmentView
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
            this.p_left = new System.Windows.Forms.Panel();
            this.p_right = new System.Windows.Forms.Panel();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.p_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // p_left
            // 
            this.p_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_left.Controls.Add(this.dgvDepartment);
            this.p_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_left.Location = new System.Drawing.Point(0, 0);
            this.p_left.Name = "p_left";
            this.p_left.Size = new System.Drawing.Size(537, 457);
            this.p_left.TabIndex = 4;
            // 
            // p_right
            // 
            this.p_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_right.Location = new System.Drawing.Point(537, 0);
            this.p_right.Name = "p_right";
            this.p_right.Size = new System.Drawing.Size(200, 457);
            this.p_right.TabIndex = 3;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartment.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.Size = new System.Drawing.Size(535, 455);
            this.dgvDepartment.TabIndex = 0;
            // 
            // DepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.p_left);
            this.Controls.Add(this.p_right);
            this.Name = "DepartmentView";
            this.Size = new System.Drawing.Size(737, 457);
            this.p_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_left;
        private System.Windows.Forms.Panel p_right;
        private System.Windows.Forms.DataGridView dgvDepartment;
    }
}
