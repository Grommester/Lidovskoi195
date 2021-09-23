using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword.Tests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_12Symbols_ReturnsTrue()
        {
            string password = "21121994eeee";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_8Symbols_ReturnsFalse()
        {
            string password = "2112199";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_20Symbols_ReturnsFalse()
        {
            string password = "21121994573164597834f";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_20Symbols_ReturnsTrue()
        {
            string password = "123456789qwertyuiopa";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void Check_numbersSymbols_ReturnsTrue()
        {
            string password = "123456789";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Check_numbersSymbols_ReturnsFalse()
        {
            string password = "Qwertyuiop";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);

        }


        [TestMethod()]
        public void Check_SpecSymbols_ReturnsTrue()
        {
            string password = "qwertyu@";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        public void Check_SpecSymbols_ReturnsFalse()
        {
            string password = "Hhjsadasdasd";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);

        }

        [TestMethod()]
        public void Check_CapsSymbols_ReturnsTrue()
        {
            string password = "AsfhjfsdkjKjhfs1@";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Check_CapsSymbols_ReturnsFalse()
        {
            string password = "1280848149845»8320:";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);

        }

        [TestMethod()]
        public void Check_UPSymbols_ReturnsTrue()
        {
            string password = "ASA@1987DFE:";
            bool expected = true;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Check_UPSymbols_ReturnsFalse()
        {
            string password = "dejh#93875jsapo";
            bool expected = false;

            bool actual = PasswordChecker.validatePassword(password);
            Assert.IsFalse(actual);

        }
        public class PasswordChecker
        {
            public static bool validatePassword(string password)
            {
                if (password.Length < 8 || password.Length > 20)
                    return false;
                if (!password.Any(char.IsLower))
                    return false;
                if (!password.Any(char.IsUpper))
                    return false;
                if (!password.Any(char.IsDigit))
                    return false;
                if (password.Intersect("!@#$%^&*()").Count() == 0)
                    return false;

                return true;


            }



        }
    }
}



