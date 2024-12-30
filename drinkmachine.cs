using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_241227
{
    public class drinkmachine
    {
        int money; // 자판기 안에 있는 돈
        int can; // 자판기 내 음료 수량
        public int Can
        {
            get { return can; }
            set { can = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
    }

}
