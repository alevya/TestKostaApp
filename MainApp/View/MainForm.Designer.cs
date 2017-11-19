namespace MainApp.View
{
    partial class MainForm
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
            this.p_bottom = new System.Windows.Forms.Panel();
            this.p_top = new System.Windows.Forms.Panel();
            this.tc_organization = new System.Windows.Forms.TabControl();
            this.tp_employee = new System.Windows.Forms.TabPage();
            this.tp_department = new System.Windows.Forms.TabPage();
            this.p_top.SuspendLayout();
            this.tc_organization.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bottom
            // 
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 453);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(948, 46);
            this.p_bottom.TabIndex = 2;
            // 
            // p_top
            // 
            this.p_top.Controls.Add(this.tc_organization);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(948, 453);
            this.p_top.TabIndex = 3;
            // 
            // tc_organization
            // 
            this.tc_organization.Controls.Add(this.tp_employee);
            this.tc_organization.Controls.Add(this.tp_department);
            this.tc_organization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_organization.Location = new System.Drawing.Point(0, 0);
            this.tc_organization.Name = "tc_organization";
            this.tc_organization.SelectedIndex = 0;
            this.tc_organization.Size = new System.Drawing.Size(948, 453);
            this.tc_organization.TabIndex = 0;
            // 
            // tp_employee
            // 
            this.tp_employee.Location = new System.Drawing.Point(4, 22);
            this.tp_employee.Name = "tp_employee";
            this.tp_employee.Padding = new System.Windows.Forms.Padding(3);
            this.tp_employee.Size = new System.Drawing.Size(940, 427);
            this.tp_employee.TabIndex = 0;
            this.tp_employee.Text = "Сотрудники";
            this.tp_employee.UseVisualStyleBackColor = true;
            // 
            // tp_department
            // 
            this.tp_department.Location = new System.Drawing.Point(4, 22);
            this.tp_department.Name = "tp_department";
            this.tp_department.Padding = new System.Windows.Forms.Padding(3);
            this.tp_department.Size = new System.Drawing.Size(847, 349);
            this.tp_department.TabIndex = 1;
            this.tp_department.Text = "Отделы";
            this.tp_department.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 499);
            this.Controls.Add(this.p_top);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое приложение";
            this.p_top.ResumeLayout(false);
            this.tc_organization.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.TabControl tc_organization;
        private System.Windows.Forms.TabPage tp_employee;
        private System.Windows.Forms.TabPage tp_department;
    }
}

