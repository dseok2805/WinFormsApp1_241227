namespace WinFormsApp1_241227
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();

            this.a = 0; // ������ ���� ���� �������, a=0 ���� �ʱ�ȭ ����

            textBox1.Text = a.ToString(); // ���� �Ҵ��� �ȵ� a�� �����ִ�
            // a�� ���� �־��ָ� ������ �ذ��

            DestroyTest destroyTest = new DestroyTest();

            int local_number = destroyTest.Number; // get(��������)
            destroyTest.Number = 100; // set(����ֱ�)
        }

        ~Form1()
        {
            MessageBox.Show("����");
            // â�� �ν��Ͻ��� ������ �� �Ҹ��ڰ� �����
            // �Ϲ������� â�� ���� �� �����
        }
    }
}
