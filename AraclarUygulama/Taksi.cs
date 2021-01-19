using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraclarUygulama
{
    class araclar
    {
        public string yakitTuru { get; set; }
        public string motorHacmi { get; set; }

        public virtual string Yazdir()
        {
            return "Yakıt Türü: " + yakitTuru + " Motor Hacmi: " + motorHacmi;
        }
    }

    class Taksi:araclar
    {
        public string kapiSayisi { get; set; }

        public override string Yazdir()
        {
            return "Taksi:\n"+ base.Yazdir() + " " + "Kapı sayısı: "+kapiSayisi;
        }
    }
    class Otobüs:araclar
    {
        public string yolcuKapasitesi { get; set; }

        public override string Yazdir()
        {
            return "Otobüs:\n"+ base.Yazdir()+" "+"Yolcu kapasitesi: "+yolcuKapasitesi;
        }
    }
    class Kamyon:araclar
    {
        public string yukKapasitesi { get; set; }
        public string koruk { get; set; }
        public override string Yazdir()
        {
            return "Kamyon:\n"+ base.Yazdir() + " " + "Yük kapasitesi: "+yukKapasitesi+" Körük: "+koruk;
        }
    }
}
