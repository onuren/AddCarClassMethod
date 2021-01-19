using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraclarUygulama
{
    class islemler
    {
        public araclar[] araclarDizi;

        public islemler()
        {
            araclarDizi = new araclar[0];
        }

        public void ekle(Taksi ta)
        {
            araclar[] gecici = new araclar[araclarDizi.Length+1];
            Array.Copy(araclarDizi, gecici, araclarDizi.Length);
            gecici[gecici.Length - 1] = ta;
            araclarDizi = gecici;
        }
        public void ekle(Otobüs ot)
        {
            araclar[] gecici = new araclar[araclarDizi.Length + 1];
            Array.Copy(araclarDizi, gecici, araclarDizi.Length);
            gecici[gecici.Length - 1] = ot;
            araclarDizi = gecici;
        }
        public void ekle(Kamyon ka)
        {
            araclar[] gecici = new araclar[araclarDizi.Length + 1];
            Array.Copy(araclarDizi, gecici, araclarDizi.Length);
            gecici[gecici.Length - 1] = ka;
            araclarDizi = gecici;
        }

        public void listele()
        {
            araclar[] dizi = new araclar[araclarDizi.Length];
            dizi = araclarDizi;
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine((i+1)+". Araç\n*-*-*-*-*-*-*-*-*-* \n"+araclarDizi[i].Yazdir());
            }
        }
        
    }
}
