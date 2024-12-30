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
            get { return can; }
            set { can = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public void BuyDrink(int price, drinkmachine machine)
        {
            if (Money < price) throw new InvalidOperationException("음료를 구매할 돈이 부족합니다.\r\n10,000원 충전합니다!");
            if (machine.Can <= 0) throw new InvalidOperationException("구매할 음료가 없습니다.");

            Money -= price;
            Can += 1;
            machine.Can -= 1;
            machine.Money += price;
        }

        public void Drink()
        {
            if (Can <= 0) throw new InvalidOperationException("마실 음료가 없습니다.");
            Can -= 1;
        }
    }

}
