using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kockanap
{
   
    public class AI
    {
        
        int player;
        public AI(int player)
        {
            this.player = player;//1 vagy 2
            
        }
        const int kapuKozep = 350;
        const double kapuSzel = 175 / 2;
        const double felsoKapufa = kapuKozep - kapuSzel;
        const double alsoKapufa = kapuKozep + kapuSzel;
        const int palyaKozep = 500;


        public string Mozgat(double[] ertekek)// 4 elemű játékos koord majd labda koord
                                                //01unit X-Y 23labda X-Y
        {
            string visz = "";
            double[] vissza = new double[2];
            if (player==1)//jobbra
            {
                if (ertekek[2]>ertekek[0]) 
                {
                    vissza = TamadjGeco(ertekek);
                }
                else
                {
                    vissza = VedekezzGeco(ertekek);
                }
            }
            else if (player == 2)//balra támad
            {
                if (ertekek[2] < ertekek[0])
                {
                    vissza = TamadjGeco(ertekek);
                }
                else
                {

                    vissza = VedekezzGeco(ertekek);
                }
            }
            for (int i = 0; i < vissza.Length; i++)
            {
                visz += vissza[i]+"\n";
            }
            return visz;
        }

        private double[] TamadjGeco(double[] ertekek)
        {
            if(!(Math.Abs(ertekek[3]-ertekek[1])>300 || Math.Abs(ertekek[2] - ertekek[0]) > 300))
            {
                int valamennyi = 16;
                //Norbi felelősséget vállal
                if (ertekek[3]>kapuKozep)
                {
                    ertekek[3] += valamennyi;
                }
                else
                {
                    ertekek[3] -= valamennyi;
                }
            }
            return VektorSzamit(ertekek);
        }

        private double[] VedekezzGeco(double[] ertekek)
        {
            double[] vissza = new double[2];
            int valamennyi = 46;
            if (ertekek[3]>kapuKozep)//lentről kerülöm
            {
                ertekek[3] -= valamennyi;
                
            }
            else
            {
                ertekek[3] += valamennyi;

            }
            vissza = VektorSzamit(ertekek);
            return vissza;
        }

        private double[] VektorSzamit(double[] ertekek) // neki megy a labda helyzetének
        {
            double[] vissza = new double[2];

            double xHova = ertekek[2] - ertekek[0];
            int szorzo = 1;
            double yHova = ertekek[3] - ertekek[1];
            if (Math.Abs(xHova) > Math.Abs(yHova))
            {
                if (xHova < 0)
                    szorzo = -1;
                if (yHova != 0)
                    yHova = (yHova / xHova) * 4 * szorzo;
                xHova = 4 * szorzo;
            }
            else
            {
                if (yHova < 0)
                    szorzo = -1;
                if (xHova != 0)
                    xHova = (xHova / yHova) * 4 * szorzo;
                yHova = 4 * szorzo;
            }
            vissza[0] = xHova;
            vissza[1] = yHova;
            return vissza;
        }


    }
}
