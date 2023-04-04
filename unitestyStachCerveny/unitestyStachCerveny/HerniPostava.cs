using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unitestyStachCerveny
{
    public class HerniPostava
    {
        string Jmeno
        {
            get=>jmeno;
            set
            {
                if (value.Length <= 10)
                {
                    jmeno = value;
                }
                else
                    MessageBox.Show("Příliš dlouhé jméno");
            }
        }

        public string jmeno = string.Empty;
        public int level = 1;

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public int X
        {
            get=>x;
        }
        int x = 0;
        public int Y
        {
            get=>y;
        }
        int y = 0;

        public virtual void  ZmenaPozice(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
