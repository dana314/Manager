namespace Manage.UI
{
    partial class Manager : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        private void InitializeComponent()
        {
            listTasks = new ListBox();
            textTask = new TextBox();
            AddBTN = new Button();
            DeleteBTN = new Button();
            EditBTN = new Button();
            SuspendLayout();
            // 
            // listTasks
            // 
            listTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listTasks.BackColor = Color.Silver;
            listTasks.FormattingEnabled = true;
            listTasks.Location = new Point(222, 129);
            listTasks.Name = "listTasks";
            listTasks.Size = new Size(349, 124);
            listTasks.TabIndex = 1;
            // 
            // textTask
            // 
            textTask.Anchor = AnchorStyles.Top;
            textTask.Location = new Point(250, 70);
            textTask.Name = "textTask";
            textTask.Size = new Size(300, 27);
            textTask.TabIndex = 0;
            // 
            // AddBTN
            // 
            AddBTN.Anchor = AnchorStyles.Bottom;
            AddBTN.BackColor = Color.RosyBrown;
            AddBTN.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddBTN.Location = new Point(222, 273);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(87, 46);
            AddBTN.TabIndex = 2;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Anchor = AnchorStyles.Bottom;
            DeleteBTN.BackColor = Color.RosyBrown;
            DeleteBTN.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteBTN.Location = new Point(353, 273);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(86, 46);
            DeleteBTN.TabIndex = 3;
            DeleteBTN.Text = "Удалить";
            DeleteBTN.UseVisualStyleBackColor = false;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // EditBTN
            // 
            EditBTN.Anchor = AnchorStyles.Bottom;
            EditBTN.BackColor = Color.RosyBrown;
            EditBTN.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditBTN.Location = new Point(485, 273);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(86, 46);
            EditBTN.TabIndex = 4;
            EditBTN.Text = "Изменить";
            EditBTN.UseVisualStyleBackColor = false;
            EditBTN.Click += EditBTN_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textTask);
            Controls.Add(listTasks);
            Controls.Add(AddBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(EditBTN);
            Name = "Manager";
            Text = "Задачник";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBTN;
        private Button DeleteBTN;
        private Button EditBTN;
        private TextBox textTask;
        private ListBox listTasks;
    }
}
