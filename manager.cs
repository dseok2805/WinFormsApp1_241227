using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_241227
{
    public class manager
    {
        int can; // 관리자의 음료 수량
        int money; // 관리자가 가진 돈
        public int Can
        {
            get
            {
                return can;
            }
            set
            {
                this.can = value;
            }
        }
        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                this.money = value;
            }
        }
    }
}
