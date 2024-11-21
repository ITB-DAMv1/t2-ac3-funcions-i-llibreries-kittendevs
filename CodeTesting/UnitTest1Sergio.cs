using System.Security.Cryptography.X509Certificates;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Voy a provar la clase de equivalencia  con palabras de mas de dos vocales.
        [DataRow(1000, 0)]
        [DataRow(2000, 0)]
        [DataRow(40,0)]
        public void DividirMaldatIsCorrectTwoVowelsTrue(double miMalicia, double _expected)
        {
            //Arrange 
            bool isTwoVowels = true;
            double actualAvatarMalice = 0;

            TestingCodeTeam3.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

            //Assert
            Assert.AreEqual(_expected, actualAvatarMalice);
        }
        [TestMethod]
        //Voy a provar la clase de equivalencia  con palabras de mas de dos vocales, dando error.

        [DataRow(1000, 5)]
        [DataRow(100, 10)]
        [DataRow(40, 0.1)]
        public void DividirMaldatIsNotCorrectTwoVowelsTrue(double miMalicia, double _expected)
        {
            //Arrange 
            bool isTwoVowels = true;
            double actualAvatarMalice = 0;

            TestingCodeTeam3.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

            //Assert
            Assert.AreNotEqual(_expected, actualAvatarMalice);
        }
        
      
        [TestMethod]

        //Voy a provar la clase de equivalencia  con palabras con menos de dos vocales

        [DataRow(1000, 950)]
        [DataRow(2000, 1900)]
        [DataRow(4000, 3800)]

        public void DividirMaldatIsCorrectTwoVowelsFalse(double miMalicia, double _expected)
        {
            //Arrange 
            bool isTwoVowels = false;
            double actualAvatarMalice = 0;

            TestingCodeTeam3.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

            //Assert
            Assert.AreEqual(_expected, actualAvatarMalice);
        }
       

        [TestMethod]

        //Voy a provar la clase de equivalencia  con palabras con menos de dos vocales,dando error.

        [DataRow(1000, 951)]
        [DataRow(2000, 1000)]
        [DataRow(4000, 3010)]

        public void DividirMaldatIsNotCorrectTwoVowelsFalse(double miMalicia, double _expected)
        {
            //Arrange 
            bool isTwoVowels = false;
            double actualAvatarMalice = 0;

            TestingCodeTeam3.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

            //Assert
            Assert.AreNotEqual(_expected, actualAvatarMalice);
        }
        [TestMethod]

        //Voy a provar la clase de equivalencia  con palabras con mas de dos vocales

        [DataRow(1000, 250)]
        [DataRow(2000, 500)]
        [DataRow(4000, 1000)]

        public void ConvertToMagicDustTwoVowelsTrue(double maliceNum, double expected)
        {
            double resultat;

            resultat = TestingCodeTeam3.Program.ConvertToMagicDust(maliceNum);

            //Assert
            Assert.AreEqual(expected, resultat);
        }

        [TestMethod]

        //Voy a provar la clase de equivalencia  con palabras con mas de dos vocales, dando error.

        [DataRow(1000, 2.2)]
        [DataRow(2000, 300)]
        [DataRow(4000, 950)]

        public void ConvertToMagicDustNotCorrectTwoVowelsTrue(double maliceNum, double expected)
        {
            double resultat;

            resultat = TestingCodeTeam3.Program.ConvertToMagicDust(maliceNum);

            //Assert
            Assert.AreNotEqual(expected, resultat);
        }

        [TestMethod]

        //Voy a provar la clase de equivalencia  con palabras con menos de dos vocales

        [DataRow(1000, 12.5)]
        [DataRow(2000, 25)]
        [DataRow(4000, 50)]

        public void ConvertToMagicDustTwoVowelsFalse(double maliceNum, double expected)
        {
            double resultat;
            int percent = 5;

            resultat = TestingCodeTeam3.Program.ConvertToMagicDust(maliceNum, percent);

            //Assert
            Assert.AreEqual(expected, resultat);
        }
        [TestMethod]

        //Voy a provar la clase de equivalencia  con palabras con menos de dos vocales, dando error.

        [DataRow(1000, 12.8)]
        [DataRow(2000, 25.8)]
        [DataRow(4000, 501)]

        public void ConvertToMagicDustNotCorrectTwoVowelsFalse(double maliceNum, double expected)
        {
            double resultat;
            int percent = 5;

            resultat = TestingCodeTeam3.Program.ConvertToMagicDust(maliceNum, percent);

            //Assert
            Assert.AreNotEqual(expected, resultat);
        }
    }
}