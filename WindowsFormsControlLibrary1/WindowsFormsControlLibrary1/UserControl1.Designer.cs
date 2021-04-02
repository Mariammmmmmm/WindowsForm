namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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
			this.userControlTimer1 = new WindowsFormsControlLibrary1.UserControlTimer();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userControlTimer1
			// 
			this.userControlTimer1.Location = new System.Drawing.Point(20, 16);
			this.userControlTimer1.Name = "userControlTimer1";
			this.userControlTimer1.Size = new System.Drawing.Size(156, 107);
			this.userControlTimer1.TabIndex = 0;
			this.userControlTimer1.TimeEnabled = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(281, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Остановить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.userControlTimer1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(800, 450);
			this.ResumeLayout(false);

        }

		#endregion

		private UserControlTimer userControlTimer1;
		private System.Windows.Forms.Button button1;
	}
}
