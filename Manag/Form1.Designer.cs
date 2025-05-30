namespace Manag
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
            this.AddBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListBox();
            this.textTasks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBTN.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBTN.Location = new System.Drawing.Point(216, 541);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(92, 35);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Добавить";
            this.AddBTN.UseVisualStyleBackColor = false;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBTN.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBTN.Location = new System.Drawing.Point(343, 541);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(92, 35);
            this.DeleteBTN.TabIndex = 1;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            // 
            // EditBTN
            // 
            this.EditBTN.BackColor = System.Drawing.Color.RosyBrown;
            this.EditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBTN.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBTN.Location = new System.Drawing.Point(473, 541);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(92, 35);
            this.EditBTN.TabIndex = 2;
            this.EditBTN.Text = "Изменить";
            this.EditBTN.UseVisualStyleBackColor = false;
            // 
            // listTasks
            // 
            this.listTasks.BackColor = System.Drawing.Color.LightGray;
            this.listTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTasks.FormattingEnabled = true;
            this.listTasks.ItemHeight = 16;
            this.listTasks.Location = new System.Drawing.Point(174, 153);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(455, 338);
            this.listTasks.TabIndex = 3;
            // 
            // textTasks
            // 
            this.textTasks.BackColor = System.Drawing.Color.RosyBrown;
            this.textTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTasks.Location = new System.Drawing.Point(303, 95);
            this.textTasks.Name = "textTasks";
            this.textTasks.Size = new System.Drawing.Size(174, 22);
            this.textTasks.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.textTasks);
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.AddBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.ListBox listTasks;
        private System.Windows.Forms.TextBox textTasks;
    }
}

