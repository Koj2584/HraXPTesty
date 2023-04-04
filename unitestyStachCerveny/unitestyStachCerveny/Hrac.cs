using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public enum oblicej
{
    velky_nos, usoplesk, make_up
}


public enum vlasy
{
    drdol, culik, pleska
}

public enum barva_vlasu
{
    kastanova, blond, cervena
}

namespace unitestyStachCerveny
{
    public class Hrac : HerniPostava
    {
        oblicej oblicej;
        vlasy vlasy;
        barva_vlasu barva_vlasu;
        public int xp = 0;

        public Hrac(oblicej oblicej, vlasy vlasy, barva_vlasu barva_vlasu, string specializace, string jmeno) : base(jmeno)
        {
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barva_vlasu = barva_vlasu;
            this.Specializace = specializace;
        }
        public string Specializace
        {
            get=>specializace;
            set
            {
                if (value == "Kouzelník" || value == "Berserker" || value == "Inženýr" || value == "Cizák")
                    specializace = value;
            }
        }
        string specializace;


        public void PridejXP(int x)
        {
            xp += x;
            if(xp>level*100)
            {
                level++;
                xp = xp - (level * 100);
            }
        }

        public override string ToString()
        {
            return oblicej + " jj";
        }
        
    }
}
