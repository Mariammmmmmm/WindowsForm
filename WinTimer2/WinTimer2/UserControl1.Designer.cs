namespace WinTimer2
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
			this.userControlTimer21 = new WinTimer2.UserControlTimer2();
			this.SuspendLayout();
			// 
			// userControlTimer21
			// 
			this.userControlTimer21.Location = new System.Drawing.Point(63, 63);
			this.userControlTimer21.Name = "userControlTimer21";
			this.userControlTimer21.Size = new System.Drawing.Size(192, 103);
			this.userControlTimer21.TabIndex = 0;
			this.userControlTimer21.Text = "userControlTimer21";
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.userControlTimer21);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(800, 450);
			this.ResumeLayout(false);

        }

		#endregion

		private UserControlTimer2 userControlTimer21;
	}
}
