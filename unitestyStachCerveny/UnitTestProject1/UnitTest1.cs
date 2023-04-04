using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// delka jmena
        /// </summary>
        [TestMethod]
        public void TestMethod1POS()
        {
            string jmeno = "RadekRadekRadek";
           unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            Assert.IsTrue(jmeno.Length > 10);
        }

        [TestMethod]
        public void TestMethod1NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            Assert.IsTrue(jmeno.Length > 10);
        }

        /// <summary>
        /// level nastaveny na 1
        /// </summary>

        [TestMethod]
        public void TestMethod2POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            int level = cs.level;
            level = 1; // Postrádá smysl testování
            Assert.IsTrue(level == 1);
        }

        [TestMethod]
        public void TestMethod2NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            int level = cs.level;
            level = 2; // Postrádá smysl testování
            Assert.IsTrue(level == 1);

        }

        /// <summary>
        /// pozice X na 0
        /// </summary>

        [TestMethod]
        public void TestMethod3POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            cs.x = 0; // Postrádá smysl testování
            int x = cs.x;
            Assert.IsTrue(x == 0);

        }

        [TestMethod]
        public void TestMethod3NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            cs.x = 1; // Postrádá smysl testování
            int x = cs.x;
            Assert.IsTrue(x == 0);

        }


        /// <summary>
        /// pozice Y na 0
        /// </summary>

        [TestMethod]
        public void TestMethod4POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            cs.y = 0; // Postrádá smysl testování
            int y = cs.y;
            Assert.IsTrue(y == 0);

        }

        [TestMethod]
        public void TestMethod4NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            cs.y = 1; // Postrádá smysl testování
            int y = cs.y;
            Assert.IsTrue(y == 0);

        }


        /// <summary>
        /// test zmeny pozice
        /// </summary>

        [TestMethod]
        public void TestMethod5POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            int x = cs.ZmenaPozice(3,4);
            x = 0; // Postrádá smysl testování
            Assert.IsTrue(x  == 0);


        }

        [TestMethod]
        public void TestMethod5NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.HerniPostava cs = new unitestyStachCerveny.HerniPostava(jmeno);
            int x = cs.ZmenaPozice(3,4); // Nedostatečně otestované
            Assert.IsTrue(x == 0);

        }


        /// <summary>
        /// Specializace
        /// </summary>

        [TestMethod]
        public void TestMethod6POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 0, 0, "Kouzelník", jmeno);
            Assert.AreEqual("Kouzelník", cs.specializace);


        }

        [TestMethod]
        public void TestMethod6NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0,0,0,"Gormit",jmeno);
            Assert.AreEqual("Kouzelník", cs.specializace);


        }


        /// <summary>
        /// oblicej, vlasy, barva vlasu
        /// </summary>

        [TestMethod]
        public void TestMethod7POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 0, 0, "Kouzelník", jmeno);
            Assert.IsTrue(cs.oblicej == 0 && cs.vlasy == 0 && cs.barvavlasu == 0);


        }

        [TestMethod]
        public void TestMethod7NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 1, 0, "Gormit", jmeno);
            Assert.IsTrue(cs.oblicej == 0 && cs.vlasy == 0 && cs.barvavlasu == 0);


        }

        /// <summary>
        /// xp na 0
        /// </summary>

        [TestMethod]
        public void TestMethod8POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 0, 0, "Kouzelník", jmeno);
            int x = cs.xp;
            Assert.IsTrue(x == 0);


        }

        [TestMethod]
        public void TestMethod8NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 1, 0, "Gormit", jmeno);
            int x = cs.xp + 1; // Postrádá smysl testování
            Assert.IsTrue(x == 0);


        }


        /// <summary>
        /// pricteni xp
        /// </summary>

        [TestMethod]
        public void TestMethod9POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 0, 0, "Kouzelník", jmeno);
            cs.PridejXP(5);
            int x = cs.xp;
            Assert.IsTrue(x != 0); // Nedostatečně otestované



        }

        [TestMethod]
        public void TestMethod9NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 1, 0, "Gormit", jmeno);
            cs.PridejXP(0);
            int x = cs.xp;
            Assert.IsTrue(x != 0);


        }


        /// <summary>
        /// ToString
        /// </summary>

        [TestMethod]
        public void TestMethod10POS()
        {
            string jmeno = "RadekRadekRadek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 0, 0, "Kouzelník", jmeno);
            string x = cs.ToString();
            Assert.IsTrue(x != string.Empty);



        }

        [TestMethod]
        public void TestMethod10NEG()
        {
            string jmeno = "Radek";
            unitestyStachCerveny.Hrac cs = new unitestyStachCerveny.Hrac(0, 1, 0, "Gormit", jmeno);
            string x = cs.ToString();
            x = string.Empty; 
            Assert.IsTrue(x != string.Empty);



        }
    }
}
