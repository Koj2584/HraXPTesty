using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitestyStachCerveny
{
    public enum prace
    {
        obchodnik,nepritel, obyvatel
    }

    internal class Npc : HerniPostava
    {
        public bool sila;
        public prace prace;

        public Npc(bool sila, prace prace,string jmeno) : base(jmeno)
        {
            this.sila = sila;
            this.prace = prace;
        }

        public Npc(prace prace, string jmeno) : base(jmeno)
        {
            this.prace = prace;
            sila = false;
        }

        public sealed override void ZmenaPozice(int x, int y)
        {
            base.ZmenaPozice(2,3);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
