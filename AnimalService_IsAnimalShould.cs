using NUnit.Framework;
using AnimalClass;

namespace UnitTests.Services
{
    [TestFixture]
    public class AnimalService_IsAnimalShould
    {
        private Animal _animal;
        private Cat _cat;
        private Dog _dog;

        [SetUp]
        public void SetUp()
        {
            _animal = new Animal();
            _cat = new Cat();
            _dog = new Dog();
        }

        [Test]
        public void MakeSound_ReturnEqual()
        {
            var result = _animal.MakeSound();

            Assert.AreEqual(result, "Animal gives a sound!");
        }

        [Test]
        public void MakeSounds_ReturnNotEqual()
        {
            var result = _animal.MakeSound();

            Assert.AreNotEqual(result, "Animal gives a dance!");
        }

        [Test]
        public void Cat_MakeSounds_ReturnEqual()
        {
            var result = _cat.MakeSound();

            Assert.AreEqual(result, "Cat says: meow meow !");
        }

        [Test]
        public void Cat_MakeSounds_ReturnNotEqual()
        {
            var result = _cat.MakeSound();

            Assert.AreNotEqual(result, "Cat says: moo moo !");
        }

        [Test]
        public void Dog_MakeSounds_ReturnEqual()
        {
            var result = _dog.MakeSound();

            Assert.AreEqual(result, "Dog sounds like: hau hau !");
        }

        [Test]
        public void Dog_MakeSounds_ReturnNotEqual()
        {
            var result = _dog.MakeSound();

            Assert.AreNotEqual(result, "Dog sounds like: moo moo !");
        }
    }
}