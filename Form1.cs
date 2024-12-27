namespace WinFormsApp1_241227
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();

            this.a = 0; // 쓰레기 값이 가득 들어있음, a=0 으로 초기화 가능

            textBox1.Text = a.ToString(); // 아직 할당이 안된 a를 쓰고있다
            // a에 값을 넣어주면 오류가 해결됨

            DestroyTest destroyTest = new DestroyTest();

            int local_number = destroyTest.Number; // get(가져오기)
            destroyTest.Number = 100; // set(집어넣기)
        }

        ~Form1()
        {
            MessageBox.Show("죽음");
            // 창이 인스턴스가 해제될 때 소멸자가 수행됨
            // 일반적으로 창을 닫을 때 수행됨
        }
    }
}
