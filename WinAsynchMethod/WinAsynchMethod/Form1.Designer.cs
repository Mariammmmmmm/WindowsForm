
namespace WinAsynchMethod
{
	partial class Form1
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
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.btnRun = new System.Windows.Forms.Button();
			this.btnWork = new System.Windows.Forms.Button();
			this.txbA = new System.Windows.Forms.TextBox();
			this.txbB = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(2, 9);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(86, 17);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Значение А";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(191, 9);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(86, 17);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "Значение В";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(57, 71);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 2;
			this.btnRun.Text = "Сумма";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnWork
			// 
			this.btnWork.Location = new System.Drawing.Point(163, 71);
			this.btnWork.Name = "btnWork";
			this.btnWork.Size = new System.Drawing.Size(75, 23);
			this.btnWork.TabIndex = 3;
			this.btnWork.Text = "Работа";
			this.btnWork.UseVisualStyleBackColor = true;
			this.btnWork.Click += new System.EventHandler(this.button2_Click);
			// 
			// txbA
			// 
			this.txbA.Location = new System.Drawing.Point(85, 9);
			this.txbA.Name = "txbA";
			this.txbA.Size = new System.Drawing.Size(100, 22);
			this.txbA.TabIndex = 4;
			// 
			// txbB
			// 
			this.txbB.Location = new System.Drawing.Point(279, 6);
			this.txbB.Name = "txbB";
			this.txbB.Size = new System.Drawing.Size(100, 22);
			this.txbB.TabIndex = 5;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(305, 83);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(46, 17);
			this.lblResult.TabIndex = 6;
			this.lblResult.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(57, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Разность";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 153);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txbB);
			this.Controls.Add(this.txbA);
			this.Controls.Add(this.btnWork);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Name = "Form1";
			this.Text = "Асинхронный запуск";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnWork;
		private System.Windows.Forms.TextBox txbA;
		private System.Windows.Forms.TextBox txbB;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Button button1;
	}
}

