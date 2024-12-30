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
            get { return can; }
            set { can = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public void RefillDrinks(drinkmachine machine, int refillAmount)
        {
            if (Can < refillAmount) throw new InvalidOperationException("자판기에 채워넣을 음료가 부족합니다.");

            Can -= refillAmount;
            machine.Can += refillAmount;
        }

        public void WithdrawMoney(drinkmachine machine, int amount)
        {
            if (machine.Money < amount) throw new InvalidOperationException("회수할 돈이 부족합니다.");

            machine.Money -= amount;
            Money += amount;
        }
    }

}
