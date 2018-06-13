using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
            // myMachine.Location = "Kitchen";
            // myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);

            myMachine.MakeCappuccino();
        }
    }

    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }

        private string _location;
        private string _make;
        private string _model;

        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino made");
        }
    }
}
