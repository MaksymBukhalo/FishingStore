namespace FishingStore
{
	partial class MainMenu
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
			this.sortButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// sortButton
			// 
			this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sortButton.BackColor = System.Drawing.Color.Aqua;
			this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sortButton.Location = new System.Drawing.Point(679, 9);
			this.sortButton.Name = "sortButton";
			this.sortButton.Size = new System.Drawing.Size(155, 88);
			this.sortButton.TabIndex = 1;
			this.sortButton.Text = "Сортувати";
			this.sortButton.UseVisualStyleBackColor = false;
			this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
			// 
			// addButton
			// 
			this.addButton.AutoSize = true;
			this.addButton.BackColor = System.Drawing.Color.Aqua;
			this.addButton.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.addButton.Location = new System.Drawing.Point(-5, 9);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(171, 49);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Додати";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// Delete
			// 
			this.Delete.BackColor = System.Drawing.Color.Aqua;
			this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Delete.ForeColor = System.Drawing.Color.Red;
			this.Delete.Location = new System.Drawing.Point(-5, 55);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(171, 45);
			this.Delete.TabIndex = 3;
			this.Delete.Text = "Видалити";
			this.Delete.UseVisualStyleBackColor = false;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.BackColor = System.Drawing.Color.Aqua;
			this.ClientSize = new System.Drawing.Size(832, 453);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.sortButton);
			this.Name = "MainMenu";
			this.Text = "MainMenu";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.Controls.SetChildIndex(this.sortButton, 0);
			this.Controls.SetChildIndex(this.addButton, 0);
			this.Controls.SetChildIndex(this.Delete, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button sortButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button Delete;
	}
}
