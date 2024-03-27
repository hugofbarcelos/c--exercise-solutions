using System;
using System.Security.Cryptography.X509Certificates;
namespace Exercises
{
    public class Exercise003
    {
        // Replace the exception statement below with your code!
        public string[] IceCreamFlavours = new string[] { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };


        public string[] IceCreamCode()
        {
            return IceCreamFlavours;
        }

        public int IceCreamCode(string iceCreamFlavour)
        {
            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (IceCreamFlavours[i] == iceCreamFlavour)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
