using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calidad20222.web.Models;
using Calidad20222.web.Controllers;

namespace Calidad20222.web.Services.Tests
{
    [TestClass()]
    public class PokerServiceTests
    {
        [TestMethod()]
        public void GetJugadaTest()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 5, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 2, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 2, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 5, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 1, Palo = "TREBOL"
                },
            };

            Assert.AreNotEqual("DOBLE PAREJA", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest2()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 13, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 12, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 11, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 10, Palo = "ESPADA"
                },
            };

            Assert.AreNotEqual("ESCALERA", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest3()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 8, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 2, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 8, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 8, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 8, Palo = "COCOS"
                },
            };

            Assert.AreNotEqual("POKER", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest4()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 4, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 4, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 4, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 3, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 3, Palo = "TREBOL"
                },
            };

            Assert.AreNotEqual("FULL", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest5()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 6, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 3, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 1, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 7, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 7, Palo = "COCOS"
                },
            };

            Assert.AreNotEqual("PAREJA", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest6()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 10, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 5, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 4, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 10, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 4, Palo = "COCOS"
                },
            };

            Assert.AreNotEqual("DOBLE PAREJA", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest7()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 5, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 5, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 5, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 4, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 4, Palo = "COCOS"
                },
            };

            Assert.AreNotEqual("FULL", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest8()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 2, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 3, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 4, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 5, Palo = "CORAZON"
                },
            };

            Assert.AreNotEqual("COLOR", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest9()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 3, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 10, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 12, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 3, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 3, Palo = "COCOS"
                },
            };

            Assert.AreNotEqual("TRIO", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest10()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 13, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 12, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 8, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 9, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 10, Palo = "COCS"
                },
            };

            Assert.AreNotEqual("CARTA MAYOR", "13");
        }

        [TestMethod()]
        public void GetJugadaTest11()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 8, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 6, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 11, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 12, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 2, Palo = "TREBOL"
                },
            };

            Assert.AreNotEqual("COLOR", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest12()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 11, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 11, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 11, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 1, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 11, Palo = "TREBOL"
                },
            };

            Assert.AreNotEqual("POKER", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest13()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 9, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 11, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 13, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 12, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 10, Palo = "COCOS"
                },
            };

            Assert.AreNotEqual("ESCALERA", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest14()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 9, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 1, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 5, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 9, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 9, Palo = "TREBOL"
                },
            };

            Assert.AreNotEqual("TRIO", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest15()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 12, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 12, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 10, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 12, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 10, Palo = "CORAZON"
                },
            };

            Assert.AreNotEqual("FULL", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest16()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 7, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 2, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 7, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 2, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 7, Palo = "CORAZON"
                },
            };

            Assert.AreNotEqual("FULL", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest17()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 9, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 4, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 9, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 3, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 4, Palo = "COCOS"
                },
            };

            Assert.AreNotEqual("DOBLE PAREJA", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest18()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 11, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 11, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 5, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 7, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 5, Palo = "CORAZON"
                },
            };

            Assert.AreNotEqual("DOBLE PAREJA", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest19()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 7, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 6, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 5, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 4, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 3, Palo = "CORAZON"
                },
            };

            Assert.AreNotEqual("ESCALERA", cartaList);
        }

        [TestMethod()]
        public void GetJugadaTest20()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1, Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 8, Palo = "COCOS"
                },
                new Carta()
                {
                    Numero = 9, Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 12, Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 8, Palo = "CORAZON"
                },
            };

            Assert.AreNotEqual("DOBLE", cartaList);
        }
    }
}