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
            this.tvDepartment = new System.Windows.Forms.TreeView();
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.p_left.SuspendLayout();
            this.p_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_left
            // 
            this.p_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_left.Controls.Add(this.tvDepartment);
            this.p_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_left.Location = new System.Drawing.Point(0, 0);
            this.p_left.Name = "p_left";
            this.p_left.Size = new System.Drawing.Size(372, 457);
            this.p_left.TabIndex = 4;
            // 
            // p_right
            // 
            this.p_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_right.Controls.Add(this.lvEmployee);
            this.p_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_right.Location = new System.Drawing.Point(372, 0);
            this.p_right.Name = "p_right";
            this.p_right.Size = new System.Drawing.Size(365, 457);
            this.p_right.TabIndex = 3;
            // 
            // tvDepartment
            // 
            this.tvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepartment.Location = new System.Drawing.Point(0, 0);
            this.tvDepartment.Name = "tvDepartment";
            this.tvDepartment.Size = new System.Drawing.Size(370, 455);
            this.tvDepartment.TabIndex = 0;
            // 
            // lvEmployee
            // 
            this.lvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmployee.Location = new System.Drawing.Point(0, 0);
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(363, 455);
            this.lvEmployee.TabIndex = 0;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
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
            this.p_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_left;
        private System.Windows.Forms.Panel p_right;
        private System.Windows.Forms.TreeView tvDepartment;
        private System.Windows.Forms.ListView lvEmployee;
    }
}
