using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace KitapTakip
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public string RafNo { get; set; }

        public override string ToString()
        {
            return $"{KitapAdi} (RafNo:{RafNo}) Fiyatı:{Fiyat}";
        }

    }
}
