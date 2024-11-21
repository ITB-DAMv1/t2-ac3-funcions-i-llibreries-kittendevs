namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow('/')]
        [DataRow('?')]
        [DataRow('@')]
        public void IsSpecialCharacterTrue(char c)
        {
            // Arrange & Act
            bool flag = TestingCodeTeam3.Program.IsSpecialCharacter(c);
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
            bool flag = TestingCodeTeam3.Program.IsSpecialCharacter(c);
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
            bool flag = TestingCodeTeam3.Program.CharacterSpecial(s);
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
            bool flag = TestingCodeTeam3.Program.CharacterSpecial(s);
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
            TestingCodeTeam3.Program.CheckVowels(ref flag, ref s, ref vowels);
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
            TestingCodeTeam3.Program.CheckVowels(ref flag, ref s, ref vowels);
            // Asser
            Assert.IsFalse(flag);
        }

    }
}