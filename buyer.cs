using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_241227
{
    public class buyer
    {
        int can; // 구매자가 구매한 음료 수량
        int money; // 구매자가 보유한 돈
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
