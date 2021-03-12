using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beerlibrary;
using System;
using System.Security.Cryptography;


namespace BeerlibraryTest
{
    [TestClass]
    public class Beertesting
    {
        Beer Beer1 = new Beer();
        [TestMethod]
        public void Name()
        {
         
            Assert.ThrowsException<ArgumentException>(() => Beer1.Name = "ØlB");
            Beer1.Name = "Tuborg";
            Assert.AreEqual("Tuborg", Beer1.Name);
        
        }
        [TestMethod]
        public void Id()
        {
          
            Assert.ThrowsException<ArgumentException>(() => Beer1.Id = 0);
            Beer1.Id = 19;
            Assert.AreEqual(19, Beer1.Id);
        }
        [TestMethod]
        public void Pris()
        {
        
            Assert.ThrowsException<ArgumentException>(() => Beer1.Pris = 0);
            Beer1.Pris = 35;
            Assert.AreEqual(35, Beer1.Pris);
        }
        [TestMethod]
        public void Abv()
        {

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer1.Abv = 0);
            Beer1.Abv = 1;
            Assert.AreEqual(1, Beer1.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer1.Abv = 101);
            Beer1.Abv = 99.99;
            Assert.AreEqual(99.99, Beer1.Abv);
            
        }
    }
}
