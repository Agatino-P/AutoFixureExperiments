using AutoFixture;
using AutoFixture.AutoMoq;
using Core;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CoreTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Constructor()
        {
            Fixture fixture = new Fixture();
            fixture.Customize(new AutoMoqCustomization());

            string first = fixture.Create<string>("first_");
            string last = fixture.Create<string>("last_");
            IAddress address = fixture.Create<IAddress>();
            
            Person person = new Person(first, last, address);

            person.FirstName.Should().Be(first);
            person.LastName.Should().Be(last);
        }

        [TestMethod]
        public void FullName()
        {
            Fixture fixture = new Fixture();
            var personFrom = fixture.Create<Person>();

            personFrom.FullName().Should().Be(personFrom.FirstName + " " + personFrom.LastName);
        }
        [TestMethod]
        public void UpperName()
        {
            Fixture fixture = new Fixture();
            Mock<Person> mockPerson = new Mock<Person>(fixture.Create("First"), fixture.Create("Last"));
            mockPerson.CallBase = true;

            var upper = mockPerson.Object.UpperFullName();
            mockPerson.Verify(x => x.FullName(), Times.Once());
        }
    }
}
