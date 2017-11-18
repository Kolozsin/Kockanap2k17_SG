using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kockanap
{
    public class Blokk
    {
       public List<Merkozes> merkozesek = new List<Merkozes>();
        List<Eredmenyek> eredmeny = new List<Eredmenyek>();

        public void CsomagDarabolas(string input)
        {
           
            string[] elsoSplit = input.Split('?'); 
            List<string> merkozesekList = new List<string>();
            for (int i = 0; i < elsoSplit.Length; i++)
            {
                if (elsoSplit[i] != "")
                    merkozesekList.Add(elsoSplit[i]);
            }
            foreach (var item in merkozesekList)
            {
                string[] temp = item.Split('|');
                if (temp.Length == 16)
                {
                    if (merkozesek.Where(x => x.merkozesazonosito == temp[0]).Count() == 0)
                    {
                        merkozesek.Add(new Merkozes(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6], temp[7],
                            temp[8], temp[9], temp[10], temp[11], temp[12], temp[13], temp[14])
                            );
                    }
                    else
                    {
                        string currentId = merkozesek.Find(x => x.merkozesazonosito == temp[0]).merkozesazonosito;
                        merkozesek.Find(x => x.merkozesazonosito == currentId).Update(temp[1], temp[2], temp[3], temp[4], temp[5], temp[6], temp[7],
                          temp[8], temp[9], temp[10], temp[11], temp[12], temp[13], temp[14]);
                    }
                }
                else
                {
                    
                    if (eredmeny.Where(x => x.merkozesazonosito == temp[0]).Count() == 0)
                    {
                        eredmeny.Add(new Eredmenyek(temp[0], temp[1], temp[2], temp[3], temp[4]));
                    }
                    else
                    {
                        string currentId = eredmeny.Find(x => x.merkozesazonosito == temp[0]).merkozesazonosito;
                        eredmeny.Find(x => x.merkozesazonosito == currentId).Update( temp[1], temp[2], temp[3], temp[4]);
                    }
                }
            }
            
            
        }
    }
    public class Eredmenyek
    {
        public string merkozesazonosito;
        string Player1g;
        string Player1p;
        string Player2g;
        string Player2p;

        public Eredmenyek(string merkozesazonosito, string player1g, string player1p, string player2g, string player2p)
        {
            this.merkozesazonosito = merkozesazonosito;
            Player1g = player1g;
            Player1p = player1p;
            Player2g = player2g;
            Player2p = player2p;
        }



        internal void Update(string v2, string v3, string v4, string v5)
        {
            Player1g = v2;
            Player1p = v3;
            Player2g = v4;
            Player2p = v5;
        }
    }
    public class Merkozes
    {
        public string merkozesazonosito;
        string labdaX;
        string labdaY;
        string player11X;
        string player11Y;
        string player12X;
        string player12Y;
        string player13X;
        string player13Y;
        string player21X;
        string player21Y;
        string player22X;
        string player22Y;
        string player23X;
        string player23Y;

        public Merkozes(string merkozesazonosito, string labdaX, string labdaY, string player11X, string player11Y, string player12X, string player12Y, string player13X, string player13Y, string player21X, string player21Y, string player22X, string player22Y, string player23X, string player23Y)
        {
            this.merkozesazonosito = merkozesazonosito;
            this.LabdaX = labdaX;
            this.LabdaY = labdaY;
            this.Player11X = player11X;
            this.Player11Y = player11Y;
            this.Player12X = player12X;
            this.Player12Y = player12Y;
            this.Player13X = player13X;
            this.Player13Y = player13Y;
            this.Player21X = player21X;
            this.Player21Y = player21Y;
            this.Player22X = player22X;
            this.Player22Y = player22Y;
            this.Player23X = player23X;
            this.Player23Y = player23Y;
        }

        public string LabdaX
        {
            get
            {
                return labdaX;
            }

            set
            {
                labdaX = value;
            }
        }

        public string LabdaY
        {
            get
            {
                return labdaY;
            }

            set
            {
                labdaY = value;
            }
        }

        public string Player11X
        {
            get
            {
                return player11X;
            }

            set
            {
                player11X = value;
            }
        }

        public string Player11Y
        {
            get
            {
                return player11Y;
            }

            set
            {
                player11Y = value;
            }
        }

        public string Player12X
        {
            get
            {
                return player12X;
            }

            set
            {
                player12X = value;
            }
        }

        public string Player12Y
        {
            get
            {
                return player12Y;
            }

            set
            {
                player12Y = value;
            }
        }

        public string Player13X
        {
            get
            {
                return player13X;
            }

            set
            {
                player13X = value;
            }
        }

        public string Player13Y
        {
            get
            {
                return player13Y;
            }

            set
            {
                player13Y = value;
            }
        }

        public string Player21X
        {
            get
            {
                return player21X;
            }

            set
            {
                player21X = value;
            }
        }

        public string Player21Y
        {
            get
            {
                return player21Y;
            }

            set
            {
                player21Y = value;
            }
        }

        public string Player22X
        {
            get
            {
                return player22X;
            }

            set
            {
                player22X = value;
            }
        }

        public string Player22Y
        {
            get
            {
                return player22Y;
            }

            set
            {
                player22Y = value;
            }
        }

        public string Player23X
        {
            get
            {
                return player23X;
            }

            set
            {
                player23X = value;
            }
        }

        public string Player23Y
        {
            get
            {
                return player23Y;
            }

            set
            {
                player23Y = value;
            }
        }

        internal void Update(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, string v11, string v12, string v13, string v14)
        {
            this.LabdaX = v1;
            this.LabdaY = v2;
            this.Player11X = v3;
            this.Player11Y = v4;
            this.Player12X = v5;
            this.Player12Y = v6;
            this.Player13X = v7;
            this.Player13Y = v8;
            this.Player21X = v9;
            this.Player21Y = v10;
            this.Player22X = v11;
            this.Player22Y = v12;
            this.Player23X = v13;
            this.Player23Y = v14;
        }

        public string Move(string player)
        {
            string coords = "";
            switch (player)
            {
                case "1":  coords =  Move1(Player11X,Player11Y,1) + "\n" + Move2(Player12X,Player12Y,1) + "\n" + Move3(Player13X,Player13Y,1) + "\n"; break;
                case "2":  coords = Move1(Player21X, Player21Y,2) + "\n" + Move2(Player22X, Player22Y,2) + "\n" + Move3(Player23X, Player23Y,2) + "\n"; break;
                default:
                    break;
            }


            return coords;
        }

        private string Move3(string playerX, string playerY,int player)
        {
         
               double x = (double.Parse(labdaX) - double.Parse(playerX));
               double y = (double.Parse(labdaY) - double.Parse(playerY));
            if (x > y && player == 1)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = -4;
                    y = 0;
                }
                else
                {
                    x = 4;
                    y = y / x * 4;
                }

            }
            else if (x > y && player == 2)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = 4;
                    y = 0;
                }
                else
                {
                    x = -4;
                    y = y / x * 4;
                }
            }
            else if (x < y && player == 1)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = -4;
                    y = 0;
                }
                else
                {
                    y = 4;
                    x = x / y * 4;
                }
            }
            else if (x < y && player == 2)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = 4;
                    y = 0;
                }
                else
                {
                    y = 4;
                    x = x / y * -4;

                }

            }
            string nx = (x).ToString();
            string ny = (y).ToString();
            return nx + "\n" + ny;
        }

        private string Move2(string playerX, string playerY,int player)
        {
            double x = (double.Parse(labdaX) - double.Parse(playerX));
            double y = (double.Parse(labdaY) - double.Parse(playerY));
            if (x > y && player == 1)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = -4;
                    y = 0;
                }
                else
                {
                    x = 4;
                    y = y / x * 4;
                }

            }
            else if (x > y && player == 2)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = 4;
                    y = 0;
                }
                else
                {
                    x = -4;
                    y = y / x * 4;
                }
            }
            else if (x < y && player == 1)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = -4;
                    y = 0;
                }
                else
                {
                    y = 4;
                    x = x / y * 4;
                }
            }
            else if (x < y && player == 2)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = 4;
                    y = 0;
                }
                else
                {
                    y = 4;
                    x = x / y * -4;

                }

            }
            string nx = (x).ToString();
            string ny = (y).ToString();
            return nx + "\n" + ny;
        }

        private string Move1(string playerX, string playerY,int player)
        {
            double x = (double.Parse(labdaX) - double.Parse(playerX));
            double y = (double.Parse(labdaY) - double.Parse(playerY));
            if (x > y && player == 1)
            {
                if (double.Parse(labdaX)<x)
                {
                    x = -4;
                    y = 0;
                }
                else
                {
                x = 4;
                y = y / x * 4;
                }

            }
            else if (x > y && player == 2)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = 4;
                    y = 0;
                }
                else
                {
                    x = -4;
                    y = y / x * 4;
                }
            }
            else if(x < y && player == 1)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = -4;
                    y = 0;
                }
                else
                {
                    y = 4;
                    x = x / y * 4;
                }
            }
            else if (x < y && player == 2)
            {
                if (double.Parse(labdaX) < x)
                {
                    x = 4;
                    y = 0;
                }
                else
	            {
                    y = 4;
                    x = x / y * -4;

                }
 
            }
            string nx = (x).ToString();
            string ny = (y).ToString();
            return nx + "\n" + ny;
        }
    }
}
