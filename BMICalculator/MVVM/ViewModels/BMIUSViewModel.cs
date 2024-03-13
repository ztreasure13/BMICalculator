using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.MVVM.ViewModels
{
    public class BMIUSViewModel
    {
        public Models.BMIUS BMIUS { get; set; }

        public BMIUSViewModel()
        {
            BMIUS = new Models.BMIUS();
            BMIUS.Height = 60;
            BMIUS.Weight = 150;
        }
    }
}
