namespace LinQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            listBox2 = new ListBox();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(279, 65);
            button1.TabIndex = 0;
            button1.Text = "Загрузить  информацию с файла";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(279, 319);
            listBox1.TabIndex = 1;
            listBox1.Visible = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(316, 12);
            button2.Name = "button2";
            button2.Size = new Size(279, 65);
            button2.TabIndex = 2;
            button2.Text = "Вывести информацию, о людях  младше 40";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 431);
            button3.Name = "button3";
            button3.Size = new Size(160, 31);
            button3.TabIndex = 3;
            button3.Text = "Очистить";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(344, 129);
            button4.Name = "button4";
            button4.Size = new Size(183, 41);
            button4.TabIndex = 4;
            button4.Text = "Задание 1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(714, 431);
            button5.Name = "button5";
            button5.Size = new Size(160, 31);
            button5.TabIndex = 5;
            button5.Text = "Назад";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(344, 188);
            button6.Name = "button6";
            button6.Size = new Size(183, 41);
            button6.TabIndex = 6;
            button6.Text = "Задание 2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 8);
            button7.Name = "button7";
            button7.Size = new Size(279, 92);
            button7.TabIndex = 7;
            button7.Text = "Соединить последовательность и выполнить группировку";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(12, 106);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(279, 319);
            listBox2.TabIndex = 8;
            listBox2.Visible = false;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(316, 12);
            button8.Name = "button8";
            button8.Size = new Size(349, 88);
            button8.TabIndex = 9;
            button8.Text = "Соединить последовательности и вывести на экран сотрудников, регион которых начинается на «И».";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(344, 431);
            button9.Name = "button9";
            button9.Size = new Size(183, 31);
            button9.TabIndex = 10;
            button9.Text = "Выйти";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(886, 486);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(listBox2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "LinQ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ListBox listBox2;
        private Button button8;
        private Button button9;
    }
}