using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainsystem.model
{
    public class Train
    {
        public Train()
        { }

        public Train(int ID, String Name, int ProductionYear)
        {
            this.ID = ID;
            this.Name = Name;
            this.ProductionYear = ProductionYear;
        }

        public int ID { get; set; }
        public String Name { get; set; }
        public int ProductionYear { get; set; }

    }
}
