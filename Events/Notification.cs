using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Notification
    {
        Banking bank;

        public Notification(Banking bank)
        {
            this.bank = bank;
            
            bank.UnderBalance_Event += UnderBalance_Noti_Method;
            bank.UnderBalance_Event += UnderBalance_SMS;
            bank.OverBalance_Event += OverBalance_Noti_Method;
            bank.OverBalance_Event += OverBalance_SMS;
        }
       
        private void UnderBalance_Noti_Method()
        {
            Console.WriteLine("your account balance is underbalance");
        }

        private void OverBalance_Noti_Method()
        {
            Console.WriteLine("your account balance is Overbalance");
        }
        
        private void UnderBalance_SMS()
        {
            Console.WriteLine("underBalance SMS sent");
        }

        private void OverBalance_SMS()
        {
            Console.WriteLine("overBalance SMS sent");
        }
    }

    
}
