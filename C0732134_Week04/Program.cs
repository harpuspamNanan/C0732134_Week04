using System;

namespace C0732134_Week04
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside c = new Countryside();
            c.run();
            c.Travel();
            //new Test().forTest();             // Anonymous Object Reference
                Console.ReadLine();
        }
    }

    class Village
    {
        public bool isAstrilde = false;
        public Village nextVillage;
        public Village prevVillage;
        public string villageName;
    }

    class Countryside
    {
        Village Toronto, Ajax, Maple;

        public void run()
        {
            Maple = new Village();
            Maple.villageName = "Maple";
            Toronto = new Village();
            Toronto.villageName = "Toronto";
            Ajax = new Village();
            Ajax.isAstrilde = true;
            Ajax.villageName = "Ajax";

            Maple.nextVillage = Toronto;
            Toronto.nextVillage = Ajax;
            Ajax.nextVillage = Maple;
        }

        public void Travel()
        {
            Village CurrentVillage = Toronto;
            while (CurrentVillage.isAstrilde)
            {
                if (CurrentVillage.isAstrilde)
                    Console.WriteLine("Yay! Hugi found Astrilda. XOXO");
                else
                    CurrentVillage = CurrentVillage.nextVillage;
                // Village NextVillage = CurrentVillage.NextVillage;
            }

        }
    }



    
}

