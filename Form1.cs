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

        private void button_NumCan_Click(object sender, EventArgs e) // 자판기의 음료 재고 확인 버튼
        {
            textBox_McinCan.Text = machine1.Can.ToString() + "개";
        }

        private void button_SetCan_Click(object sender, EventArgs e) // 음료 채워넣기 버튼 수행
        {
            if (manager1.Can <= 0)
            {
                manager1.Can += 1000;
            }
            else
            {
                machine1.Can += 100;
                manager1.Can -= 100;
                textBox_ManagerCan.Text = manager1.Can.ToString() + "개";
                textBox_McinCan.Text = machine1.Can.ToString() + "개";
            }

        }

        private void button_DrinkCan_Click(object sender, EventArgs e) // 음료 마시기
        {
            if (buyer1.Can > 0)
            {
                buyer1.Can -= 1;
                textBox_BuyerCan.Text = buyer1.Can.ToString() + "개";
            }
            else
            {
                MessageBox.Show("마실 음료수 없음");
            }
        }

        private void button_BuyCan_Click(object sender, EventArgs e) // 음료 구매하기
        {
            if (buyer1.Money < 500)
            {
                buyer1.Money += 10000; // 만원 추가
            }
            else
            {
                if (machine1.Can > 0) // 캔이 있을 때만 수행가능함
                {
                    buyer1.Money -= 500;
                    machine1.Money += 500;
                    machine1.Can -= 1;
                    buyer1.Can += 1;
                    textBox_BuyerCan.Text = buyer1.Can.ToString() + "개";
                    textBox_McinCan.Text = machine1.Can.ToString() + "개";
                    textBox_BuyerMoney.Text = buyer1.Money.ToString() + "원";
                    textBox_McinMoney.Text = machine1.Money.ToString() + "원";
                }
                else
                {
                    MessageBox.Show("구매할 음료수 없음");
                }
            }
        }

        private void button_MoneyBack_Click(object sender, EventArgs e) // 돈 회수하기
        {
            if(machine1.Money >= 5000)
            {
                machine1.Money -= 5000;
                manager1.Money += 5000;
                textBox_McinMoney.Text = machine1.Money.ToString() + "원";
                textBox_ManagerMoney.Text = manager1.Money.ToString() + "원";
            }
            else
            {
                MessageBox.Show("회수할 돈 부족함");
            }
        }
    }
}
