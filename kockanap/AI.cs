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
                                                //unit X-Y labda X-Y
        {
            string visz = "";
            double[] vissza = new double[2];
            if (player==1)//jobbra támad
            {
                if (ertekek[2]<ertekek[0]) 
                {
                    vissza = VedekezzGeco(ertekek);
                }
                else
                {
                    vissza = TamadjGeco(ertekek);
                }
            }
            else if (player == 2)//balra támad
            {
                if (ertekek[2] > ertekek[0])
                {
                    vissza = VedekezzGeco(ertekek);
                }
                else
                {
                    vissza = TamadjGeco(ertekek);
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
            if(Math.Abs(ertekek[3]-ertekek[1])>300 || Math.Abs(ertekek[2] - ertekek[0]) > 300)
                return TamadoVektor(ertekek);
            else
            {
                //Norbi felelősséget vállal
                if (ertekek[3]>palyaKozep)
                {
                    ertekek[3] += 25;
                }
                else
                {
                    ertekek[3] -= 25;
                }
            }
            return TamadoVektor(ertekek);
        }

        private double[] VedekezzGeco(double[] ertekek)
        {
            double[] vissza = new double[2];

            if (ertekek[2]>kapuKozep)//lentről kerülöm
            {
                ertekek[2] -= 65;
                
            }
            else
            {
                ertekek[2] += 65;

            }
            vissza = TamadoVektor(ertekek);
            return vissza;
        }

        private double[] TamadoVektor(double[] ertekek) // neki megy a labda helyzetének
        {
            double[] vissza = new double[2];

            double xHova = ertekek[2] - ertekek[0];
            int szorzo = 1;
            double yHova = ertekek[3] - ertekek[1];
            if (xHova>yHova)
            {
                if (xHova < 0)
                    szorzo = -1;
                yHova = (yHova / xHova) * 4;
                xHova = 4*szorzo;
            }
            else
            {
                if (yHova < 0)
                    szorzo = -1;
                xHova = (xHova / yHova) * 4;
                yHova = 4;
            }
            vissza[0] = xHova;
            vissza[1] = yHova;
            return vissza;
        }

        private double[] LabdaraMegy(double unitX, double unitY,  double ballX, double ballY)
        {
            double[] vissza = new double[2];
            double xKoor = ballX - unitX;
            double yKoor = ballY - unitY;
            return vissza;
        }
    }
}
