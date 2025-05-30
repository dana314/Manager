namespace Manage.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Задачник";

            // Кнопки
            this.AddBTN = new Button();
            this.DeleteBTN = new Button();
            this.EditBTN = new Button();

            // Поля
            this.textTask = new TextBox();
            this.listTasks = new ListBox();

            // Добавляем элементы на форму
            this.Controls.Add(this.textTask);
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.EditBTN);

            // Настройки кнопок
            this.AddBTN.Location = new System.Drawing.Point(250, 400);
            this.AddBTN.Text = "Добавить";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.BackColor = System.Drawing.Color.RosyBrown;

            this.DeleteBTN.Location = new System.Drawing.Point(350, 400);
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.BackColor = System.Drawing.Color.RosyBrown;

            this.EditBTN.Location = new System.Drawing.Point(450, 400);
            this.EditBTN.Text = "Изменить";
            this.EditBTN.UseVisualStyleBackColor = false;
            this.EditBTN.BackColor = System.Drawing.Color.RosyBrown;

            // Поле ввода
            this.textTask.Location = new System.Drawing.Point(250, 50);
            this.textTask.Width = 300;

            // Список задач
            this.listTasks.Location = new System.Drawing.Point(250, 100);
            this.listTasks.Size = new System.Drawing.Size(300, 200);
            this.listTasks.BackColor = System.Drawing.Color.Silver;
            this.listTasks.FormattingEnabled = true;
        }

        #endregion

        public Button AddBTN;
        public Button DeleteBTN;
        public Button EditBTN;
        public TextBox textTask;
        public ListBox listTasks;
    }
}