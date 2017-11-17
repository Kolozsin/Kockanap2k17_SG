using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kockanap
{
    public class Blokk
    {
        List<Merkozes> merkozesek;

        public void CsomagDarabolas(string input)
        {
            merkozesek = new List<Merkozes>();
            string[] elsoSplit = input.Split('?');
            List<string> merkozesekList = new List<string>();
            for (int i = 0; i < elsoSplit.Length; i++)
            {
                if (elsoSplit[i] != "")
                    merkozesekList.Add(elsoSplit[i]);
            }
            string[] merkozesekArray;
            foreach (var item in merkozesekList)
            {
                string[] temp = item.Split('|');
                if (temp.Length == 16)
                {
                    merkozesek.Add(new Merkozes(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5],temp[6], temp[7],
                        temp[8], temp[9], temp[10], temp[11], temp[12], temp[13], temp[14])
                        );
                }
                else
                {

                }
            }
            
            
        }
    }
    public class Merkozes
    {
        string merkozesazonosito;
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
            this.labdaX = labdaX;
            this.labdaY = labdaY;
            this.player11X = player11X;
            this.player11Y = player11Y;
            this.player12X = player12X;
            this.player12Y = player12Y;
            this.player13X = player13X;
            this.player13Y = player13Y;
            this.player21X = player21X;
            this.player21Y = player21Y;
            this.player22X = player22X;
            this.player22Y = player22Y;
            this.player23X = player23X;
            this.player23Y = player23Y;
        }
    }
}
