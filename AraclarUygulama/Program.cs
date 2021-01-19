using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraclarUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            islemler islem = new islemler();

            Taksi tk = new Taksi();
            tk.motorHacmi = "1,6";
            tk.yakitTuru = "dizel";
            tk.kapiSayisi = "4";

            islem.ekle(tk);

            Otobüs ot = new Otobüs();
            ot.motorHacmi = "1,6";
            ot.yakitTuru = "benzin";
            ot.yolcuKapasitesi = "24";

            islem.ekle(ot);

            Kamyon ka = new Kamyon();
            ka.motorHacmi = "1,4";
            ka.yakitTuru = "motorin";
            ka.yukKapasitesi = "10 ton";
            ka.koruk = "var";

            islem.ekle(ka);

            islem.listele();

            Console.ReadLine();
        }
    }
}
