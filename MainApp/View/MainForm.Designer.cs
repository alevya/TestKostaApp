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
            this.p_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bottom
            // 
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 584);
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
            this.p_top.Size = new System.Drawing.Size(948, 584);
            this.p_top.TabIndex = 3;
            // 
            // tc_organization
            // 
            this.tc_organization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_organization.Location = new System.Drawing.Point(0, 0);
            this.tc_organization.Name = "tc_organization";
            this.tc_organization.SelectedIndex = 0;
            this.tc_organization.Size = new System.Drawing.Size(948, 584);
            this.tc_organization.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 630);
            this.Controls.Add(this.p_top);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое приложение";
            this.p_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.TabControl tc_organization;
    }
}

