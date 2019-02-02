using System;

namespace C0732134_Week04
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside c = new Countryside();
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
            Ajax.villageName = "Ajax";

            Maple.nextVillage = Toronto;
            Toronto.nextVillage = Ajax;
            Ajax.nextVillage = Maple;
        }
    }
}

