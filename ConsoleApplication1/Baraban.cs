using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Baraban: Tovar
    {
        public string material { get; set; }
        public string Marka_instrumenta { get; set; }
        public DateTime Release_data { get; set; }

        public Baraban(Nomenklatura ID, double Price, string Marka_instrumenta, string material, DateTime Release_data) : base(ID, Price)
        {
            this.material = material;
            this.Marka_instrumenta = Marka_instrumenta;
            this.Release_data = Release_data;
        }
        public override void Get_info()
        {
            Console.WriteLine(ID.ToString() + ", " + Price.ToString() + ", " + Marka_instrumenta.ToString() + ", " + material.ToString() + ", " + Release_data.ToString("dd MMMM, yyyy"));
        }
    }
}
