namespace WinFormsApp1_241227
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
            textBox_BuyerMoney = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_BuyerCan = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox_McinMoney = new TextBox();
            label6 = new Label();
            textBox_McinCan = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox_ManagerMoney = new TextBox();
            label9 = new Label();
            textBox_ManagerCan = new TextBox();
            button_BuyCan = new Button();
            button_DrinkCan = new Button();
            button_MoneyBack = new Button();
            button_SetCan = new Button();
            button_NumCan = new Button();
            SuspendLayout();
            // 
            // textBox_BuyerMoney
            // 
            textBox_BuyerMoney.Location = new Point(39, 128);
            textBox_BuyerMoney.Name = "textBox_BuyerMoney";
            textBox_BuyerMoney.Size = new Size(145, 23);
            textBox_BuyerMoney.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 66);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "구매자";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 98);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 2;
            label2.Text = "돈";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 163);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "음료수";
            // 
            // textBox_BuyerCan
            // 
            textBox_BuyerCan.Location = new Point(39, 192);
            textBox_BuyerCan.Name = "textBox_BuyerCan";
            textBox_BuyerCan.Size = new Size(145, 23);
            textBox_BuyerCan.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 66);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "자판기";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 98);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 6;
            label5.Text = "돈";
            // 
            // textBox_McinMoney
            // 
            textBox_McinMoney.Location = new Point(248, 128);
            textBox_McinMoney.Name = "textBox_McinMoney";
            textBox_McinMoney.Size = new Size(141, 23);
            textBox_McinMoney.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 163);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 8;
            label6.Text = "음료수";
            // 
            // textBox_McinCan
            // 
            textBox_McinCan.Location = new Point(248, 192);
            textBox_McinCan.Name = "textBox_McinCan";
            textBox_McinCan.Size = new Size(141, 23);
            textBox_McinCan.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(454, 66);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 10;
            label7.Text = "관리자";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(458, 98);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 11;
            label8.Text = "돈";
            // 
            // textBox_ManagerMoney
            // 
            textBox_ManagerMoney.Location = new Point(458, 128);
            textBox_ManagerMoney.Name = "textBox_ManagerMoney";
            textBox_ManagerMoney.Size = new Size(124, 23);
            textBox_ManagerMoney.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(458, 163);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 13;
            label9.Text = "음료수";
            // 
            // textBox_ManagerCan
            // 
            textBox_ManagerCan.Location = new Point(458, 191);
            textBox_ManagerCan.Name = "textBox_ManagerCan";
            textBox_ManagerCan.Size = new Size(122, 23);
            textBox_ManagerCan.TabIndex = 14;
            // 
            // button_BuyCan
            // 
            button_BuyCan.Location = new Point(248, 242);
            button_BuyCan.Name = "button_BuyCan";
            button_BuyCan.Size = new Size(138, 31);
            button_BuyCan.TabIndex = 15;
            button_BuyCan.Text = "음료 구매하기";
            button_BuyCan.UseVisualStyleBackColor = true;
            button_BuyCan.Click += button_BuyCan_Click;
            // 
            // button_DrinkCan
            // 
            button_DrinkCan.Location = new Point(42, 244);
            button_DrinkCan.Name = "button_DrinkCan";
            button_DrinkCan.Size = new Size(142, 28);
            button_DrinkCan.TabIndex = 16;
            button_DrinkCan.Text = "음료마시기";
            button_DrinkCan.UseVisualStyleBackColor = true;
            button_DrinkCan.Click += button_DrinkCan_Click;
            // 
            // button_MoneyBack
            // 
            button_MoneyBack.Location = new Point(462, 244);
            button_MoneyBack.Name = "button_MoneyBack";
            button_MoneyBack.Size = new Size(121, 29);
            button_MoneyBack.TabIndex = 17;
            button_MoneyBack.Text = "자판기에서 돈 회수";
            button_MoneyBack.UseVisualStyleBackColor = true;
            button_MoneyBack.Click += button_MoneyBack_Click;
            // 
            // button_SetCan
            // 
            button_SetCan.Location = new Point(462, 295);
            button_SetCan.Name = "button_SetCan";
            button_SetCan.Size = new Size(120, 30);
            button_SetCan.TabIndex = 18;
            button_SetCan.Text = "음료 채워넣기";
            button_SetCan.UseVisualStyleBackColor = true;
            button_SetCan.Click += button_SetCan_Click;
            // 
            // button_NumCan
            // 
            button_NumCan.Location = new Point(249, 292);
            button_NumCan.Name = "button_NumCan";
            button_NumCan.Size = new Size(137, 32);
            button_NumCan.TabIndex = 19;
            button_NumCan.Text = "음료 재고";
            button_NumCan.UseVisualStyleBackColor = true;
            button_NumCan.Click += button_NumCan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_NumCan);
            Controls.Add(button_SetCan);
            Controls.Add(button_MoneyBack);
            Controls.Add(button_DrinkCan);
            Controls.Add(button_BuyCan);
            Controls.Add(textBox_ManagerCan);
            Controls.Add(label9);
            Controls.Add(textBox_ManagerMoney);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox_McinCan);
            Controls.Add(label6);
            Controls.Add(textBox_McinMoney);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_BuyerCan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_BuyerMoney);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_BuyerMoney;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_BuyerCan;
        private Label label4;
        private Label label5;
        private TextBox textBox_McinMoney;
        private Label label6;
        private TextBox textBox_McinCan;
        private Label label7;
        private Label label8;
        private TextBox textBox_ManagerMoney;
        private Label label9;
        private TextBox textBox_ManagerCan;
        private Button button_BuyCan;
        private Button button_DrinkCan;
        private Button button_MoneyBack;
        private Button button_SetCan;
        private Button button_NumCan;
    }
}
