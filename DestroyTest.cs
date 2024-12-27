using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_241227
{
    class DestroyTest
    {
        private int number;
        public int Number
        {
            get
            {
                if (this.number == 0)
                {
                    return 1;
                }
                return number;
            }
            set
            {
                if (value < 0)
                {
                    this.number = 0;
                }
                this.number = value;
            }
        }
        ~DestroyTest()
        {
            MessageBox.Show("소멸");
        }
    }
}
