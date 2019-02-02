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
            Ajax.nextVillage = null;
        }

        public void Travel()
        {
            Village currentVillage = Maple;
            while (currentVillage.nextVillage != null)
            {
                Console.WriteLine("I am in : " + currentVillage.villageName);
                if (currentVillage.isAstrilde)
                    Console.WriteLine("Yay! Hugi found Astrilda in "+currentVillage.villageName+" XOXO");
                else
                    currentVillage = currentVillage.nextVillage;
                // Village NextVillage = currentVillage.NextVillage;
            }

        }


    }




}

