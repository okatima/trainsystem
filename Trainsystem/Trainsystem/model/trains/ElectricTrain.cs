using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainsystem.model.trains
{
    public class ElectricTrain:Train
    {
        public enum CurrentTypes
        {
            Alternating = 1,
            Direct = 2
        };

        public CurrentTypes CurrentType { get; set; }

        public ElectricTrain(int ID, String Name, int ProductionYear, ElectricTrain.CurrentTypes CurrentType)
        {
            base.ID = ID;
            base.Name = Name;
            base.ProductionYear = ProductionYear;
            this.CurrentType = CurrentType;
        }
    }
}
