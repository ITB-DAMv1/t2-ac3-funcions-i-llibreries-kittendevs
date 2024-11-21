using System.Data;

namespace UnitTestSuper4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, 4, 1)]
        [DataRow(1, 4, 4)]
        [DataRow(1, 4, 2)]
        public void NumIsInRange(int min, int max, int num)
        {
            //Arrange (^-^)
            bool IsInRange;

            //Act
            IsInRange = !Super4MainCode.Program.IntIsInRange(min, max, num);

            //Assert
            Assert.IsTrue(IsInRange);
        }

        [TestMethod]
        [DataRow(1, 4, 0)]
        [DataRow(1, 4, 666)]
        public void NumIsNotRange(int min, int max, int userNum)
        {
            // Arrange (^-^)
            bool IsInRange;

            // Act
            IsInRange = !Super4MainCode.Program.IntIsInRange(min, max, userNum);

            // Assert
            Assert.IsFalse(IsInRange);
        }

        [TestMethod]
        [DataRow(2, 10, "mi")]
        [DataRow(2, 10, "miawwmiaww")]
        [DataRow(2, 10, "miaw")]
        public void StringIsInRange(int min, int max, string userString)
        {
            // Arrange
            bool IsInRange;

            // Act
            IsInRange = !Super4MainCode.Program.StringIsInRange(min, max, userString);

            // Assert
            Assert.IsTrue(IsInRange);
        }

        [TestMethod]
        [DataRow(2, 10, "i")]
        [DataRow(2, 10, "miawmiawmiaw")]
        public void StringIsNotRange(int min, int max, string userString)
        {
            // Arrange
            bool IsInRange;

            // Act
            IsInRange = !Super4MainCode.Program.StringIsInRange(min, max, userString);

            // Assert
            Assert.IsFalse(IsInRange);
        }

        [TestMethod]
        [DataRow('/')]
        [DataRow('?')]
        [DataRow('@')]
        public void IsSpecialCharacterTrue(char c)
        {
            // Arrange & Act
            bool flag = Super4MainCode.Program.IsSpecialCharacter(c);
            // Assert
            Assert.IsTrue(flag);
        }

        [TestMethod]
        [DataRow('a')]
        [DataRow('z')]
        [DataRow('7')]
        public void IsSpecialCharacterFalse(char c)
        {
            // Arrange & Act
            bool flag = Super4MainCode.Program.IsSpecialCharacter(c);
            // Assert
            Assert.IsFalse(flag);
        }

        [TestMethod]
        [DataRow("Ho\\ª")]
        [DataRow("@/*9")]
        [DataRow("¿?")]
        public void CharacterSpecialTrue(string s)
        {
            // Arrange & Act
            bool flag = Super4MainCode.Program.CharacterSpecial(s);
            // Assert
            Assert.IsTrue(flag);
        }

        [TestMethod]
        [DataRow("HOLA")]
        [DataRow("aloh")]
        [DataRow("Hola123")]
        public void CharacterSpecialFalse(string s)
        {
            // Arrange & Act
            bool flag = Super4MainCode.Program.CharacterSpecial(s);
            // Assert
            Assert.IsFalse(flag);
        }

        [TestMethod]
        [DataRow("Hola")]
        [DataRow("ALOH")]
        [DataRow("aaaaaaa")]
        public void CheckVowelsTrue(string s)
        {
            // Arrange
            int vowels = 0;
            bool flag = false;
            // Act
            Super4MainCode.Program.CheckVowels(ref flag, ref s, ref vowels);
            // Asser
            Assert.IsTrue(flag);
        }

        [TestMethod]
        [DataRow("si")]
        [DataRow("PRGRMC")]
        [DataRow("tick")]
        public void CheckVowelsFalse(string s)
        {
            // Arrange
            int vowels = 0;
            bool flag = false;
            // Act
            Super4MainCode.Program.CheckVowels(ref flag, ref s, ref vowels);
            // Asser
            Assert.IsFalse(flag);
        }

        [TestMethod]
        //Voy a provar la clase de equivalencia  con palabras de mas de dos vocales.
        [DataRow(1000, 0)]
        [DataRow(2000, 0)]
        [DataRow(40, 0)]
        public void DividirMaldatIsCorrectTwoVowelsTrue(double miMalicia, double _expected)
        {
            //Arrange 
            bool isTwoVowels = true;
            double actualAvatarMalice = 0;

            Super4MainCode.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

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

            Super4MainCode.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

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

            Super4MainCode.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

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

            Super4MainCode.Program.DividirMaldat(ref actualAvatarMalice, miMalicia, isTwoVowels);

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

            resultat = Super4MainCode.Program.ConvertToMagicDust(maliceNum);

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

            resultat = Super4MainCode.Program.ConvertToMagicDust(maliceNum);

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

            resultat = Super4MainCode.Program.ConvertToMagicDust(maliceNum, percent);

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

            resultat = Super4MainCode.Program.ConvertToMagicDust(maliceNum, percent);

            //Assert
            Assert.AreNotEqual(expected, resultat);
        }
    }
}