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
            this.label1 = new System.Windows.Forms.Label();
            this.p_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_left
            // 
            this.p_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_left.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // DepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p_left);
            this.Controls.Add(this.p_right);
            this.Name = "DepartmentView";
            this.Size = new System.Drawing.Size(737, 457);
            this.p_left.ResumeLayout(false);
            this.p_left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_left;
        private System.Windows.Forms.Panel p_right;
        private System.Windows.Forms.Label label1;
    }
}
