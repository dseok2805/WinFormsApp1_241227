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
            manager1.Can = 1000; // �������� ����� �ʱⰪ ����
            manager1.Money = 0;
            buyer1.Money = 10000; // �����ڰ� ó�� ���� �� : ���� , �ʱⰪ ����
            buyer1.Can = 0;
            machine1.Can = 0;
            machine1.Money = 0;

        }

        private void button_NumCan_Click(object sender, EventArgs e) // ���Ǳ��� ���� ��� Ȯ�� ��ư
        {
            textBox_McinCan.Text = machine1.Can.ToString() + "��";
        }

        private void button_SetCan_Click(object sender, EventArgs e) // ���� ä���ֱ� ��ư ����
        {
            if (manager1.Can <= 0)
            {
                manager1.Can += 1000;
            }
            else
            {
                machine1.Can += 100;
                manager1.Can -= 100;
                textBox_ManagerCan.Text = manager1.Can.ToString() + "��";
                textBox_McinCan.Text = machine1.Can.ToString() + "��";
            }

        }

        private void button_DrinkCan_Click(object sender, EventArgs e) // ���� ���ñ�
        {
            if (buyer1.Can > 0)
            {
                buyer1.Can -= 1;
                textBox_BuyerCan.Text = buyer1.Can.ToString() + "��";
            }
            else
            {
                MessageBox.Show("���� ����� ����");
            }
        }

        private void button_BuyCan_Click(object sender, EventArgs e) // ���� �����ϱ�
        {
            if (buyer1.Money < 500)
            {
                buyer1.Money += 10000; // ���� �߰�
            }
            else
            {
                if (machine1.Can > 0) // ĵ�� ���� ���� ���డ����
                {
                    buyer1.Money -= 500;
                    machine1.Money += 500;
                    machine1.Can -= 1;
                    buyer1.Can += 1;
                    textBox_BuyerCan.Text = buyer1.Can.ToString() + "��";
                    textBox_McinCan.Text = machine1.Can.ToString() + "��";
                    textBox_BuyerMoney.Text = buyer1.Money.ToString() + "��";
                    textBox_McinMoney.Text = machine1.Money.ToString() + "��";
                }
                else
                {
                    MessageBox.Show("������ ����� ����");
                }
            }
        }

        private void button_MoneyBack_Click(object sender, EventArgs e) // �� ȸ���ϱ�
        {
            if(machine1.Money >= 5000)
            {
                machine1.Money -= 5000;
                manager1.Money += 5000;
                textBox_McinMoney.Text = machine1.Money.ToString() + "��";
                textBox_ManagerMoney.Text = manager1.Money.ToString() + "��";
            }
            else
            {
                MessageBox.Show("ȸ���� �� ������");
            }
        }
    }
}
