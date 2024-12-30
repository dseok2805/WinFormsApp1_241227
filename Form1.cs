namespace WinFormsApp1_241227
{
    public partial class Form1 : Form
    {
        buyer buyer1 = new buyer();
        manager manager1 = new manager();
        drinkmachine machine1 = new drinkmachine();

        public Form1()
        {
            InitializeComponent();
            manager1.Can = 1000; // 관리자의 음료수 초기값 선언
            manager1.Money = 0;
            buyer1.Money = 10000; // 구매자가 처음 가진 돈 : 만원 , 초기값 선언
            buyer1.Can = 0;
            machine1.Can = 0;
            machine1.Money = 0;
        }

        private void button_NumCan_Click(object sender, EventArgs e)
        {
            textBox_McinCan.Text = $"{machine1.Can}개";
        }

        private void button_SetCan_Click(object sender, EventArgs e)
        {
            try
            {
                manager1.RefillDrinks(machine1, 100);
                textBox_ManagerCan.Text = $"{manager1.Can}개";
                textBox_McinCan.Text = $"{machine1.Can}개";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_DrinkCan_Click(object sender, EventArgs e)
        {
            try
            {
                buyer1.Drink();
                textBox_BuyerCan.Text = $"{buyer1.Can}개";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_BuyCan_Click(object sender, EventArgs e)
        {
            try
            {
                buyer1.BuyDrink(500, machine1);
                textBox_BuyerCan.Text = $"{buyer1.Can}개";
                textBox_McinCan.Text = $"{machine1.Can}개";
                textBox_BuyerMoney.Text = $"{buyer1.Money}원";
                textBox_McinMoney.Text = $"{machine1.Money}원";
            }
            catch (InvalidOperationException ex)
            {
                buyer1.Money = 10000;
                MessageBox.Show(ex.Message);
            }
        }

        private void button_MoneyBack_Click(object sender, EventArgs e)
        {
            try
            {
                manager1.WithdrawMoney(machine1, 5000);
                textBox_McinMoney.Text = $"{machine1.Money}원";
                textBox_ManagerMoney.Text = $"{manager1.Money}원";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
