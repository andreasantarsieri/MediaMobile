using System;
using System.IO;

namespace Santarsieri.Andrea._4H.MediaMobile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\Users\Lab113\Desktop\Santarsieri.Andrea.4H.MediaMobile\Santarsieri.Andrea.4H.MediaMobile\Dati.txt";
            Console.WriteLine("Programma di Andrea Santarsieri sulla media mobile delle temperature ");

            Campione[] Campione = new Campione[10];
            for(int i=0; i<Campione.Length; i++)
            {
                Campione[i] = new Campione();
            }
            StreamReader sr = new StreamReader(path);

            string riga = sr.ReadLine();
            string[] data = riga.Split(' ');

            riga = sr.ReadLine();
            string[] temperatura = riga.Split(' ');

            riga = sr.ReadLine();
            string[] umidita = riga.Split(' ');

            riga = sr.ReadLine();
            string[] pressione = riga.Split(' ');

            sr.Close();



            for(int i =0; i< data.Length; i++ )
            {
                Campione[i].Date = data[i];
                Campione[i].Temperatura = Convert.ToDouble(temperatura[i]);
                Campione[i].Umidita = Convert.ToDouble(umidita[i]);
                Campione[i].Pressione = Convert.ToInt32(pressione[i]);

                //Console.WriteLine(Array)
            }






                //microgrammi * metro ^ 3
        }
    }
    class Campione
    {
         string _date;
         double _temperatura;
         double _umidita;
         int _pressione;

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public double Temperatura
        {
            get
            {
                return _temperatura;
            }
            set
            {
                _temperatura = value;
            }
        }
        public double Umidita
        {
            get
            {
                return _umidita;
            }
            set
            {
                _umidita = value;
            }
        }
        public int Pressione
        {
            get
            {
                return _pressione;
            }
            set
            {
                _pressione = value;
            }
        }
        public Campione()
        {

        }

        public string MediaMobile12(Campione c1, Campione c2)
        {
            double MediaTmp = 0;
            double MediaUm = 0;
            double MediaPrs = 0;

            MediaTmp += this._temperatura + c1._temperatura + c2._temperatura;
            MediaTmp = MediaTmp / 3;
            MediaUm += this._umidita + c1._umidita + c2._umidita;
            MediaUm = MediaUm / 3;
            MediaPrs += this._pressione + c1._pressione + c2._pressione;
            MediaPrs = MediaPrs / 3;




            return $"La media delle temperature in 3 giorni valgono {MediaTmp:n2} dell'umidita {MediaUm:n2} e della pressione {MediaPrs}";

        }
        public string MediaMobile123(Campione c1, Campione c2, Campione c3)
        {
            double MediaTmp = 0;
            double MediaUm = 0;
            double MediaPrs = 0;

            MediaTmp += this._temperatura + c1._temperatura + c2._temperatura + c3._temperatura;
            MediaTmp = MediaTmp / 4;
            MediaUm += this._temperatura + c1._umidita + c2._umidita + c3._umidita;
            MediaUm = MediaUm / 4;
            MediaPrs += this._temperatura + c1._pressione + c2._pressione + c3._pressione;
            MediaPrs = MediaPrs / 4;

            

            return $"La media delle temperature in 4 giorni valgono {MediaTmp:n2} dell'umidita {MediaUm:n2} e della pressione {MediaPrs}";
        }
        public string MediaMobile1234(Campione c1, Campione c2, Campione c3, Campione c4 )
        {
            double MediaTmp = 0;
            double MediaUm = 0;
            double MediaPrs = 0;

            MediaTmp += this._temperatura + c1._temperatura + c2._temperatura + c3._temperatura + c4._temperatura;
            MediaTmp = MediaTmp / 5;
            MediaUm += this._umidita + c1._umidita + c2._umidita + c3._umidita + c4._umidita;
            MediaUm = MediaUm / 5;
            MediaPrs += this._pressione + c1._pressione + c2._pressione + c3._pressione + c4._pressione;
            MediaPrs = MediaPrs / 5;


            return $"La media delle temperature in 5 giorni valgono {MediaTmp:n2} dell'umidita {MediaUm:n2} e della pressione {MediaPrs}";


        }
    



    }

}
