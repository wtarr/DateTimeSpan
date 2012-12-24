using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DateTimeProcessing;

namespace NUnitTests
{
    public class DateSpanTests
    {
        ProcessDate pd;
        
        [TestFixtureSetUp]
        public void Setup()
        {
            pd = new ProcessDate();
        }

        [Test]
        public void Test_That_CalculateSpanBetweenTwoDates_Returns_A_Correct_Span_When_Given_Two_Known_Dates()
        {
            bool isFortnight; // Mock
            DateTime d1 = new DateTime(2012, 8, 13);
            DateTime d2 = new DateTime(2012, 8, 20);
            
            ProcessDate pd = new ProcessDate();
            int daySpan = pd.CalculateSpanBetweenTwoDates(d1, d2, out isFortnight);
            Assert.IsTrue(daySpan == 7); 
        }

        [Test]
        public void Test_That_CalculateSpanBetweenTwoDates_Return_True_As_Fornight_When_Known_Dates_Are_A_Fornight_Apart()
        {
            bool isFortnight;
            DateTime d1 = new DateTime(2012, 8, 13);
            DateTime d2 = new DateTime(2012, 8, 27);
            int daySpan = pd.CalculateSpanBetweenTwoDates(d1, d2, out isFortnight);
            Assert.IsTrue(isFortnight); 
        }

        [Test]
        public void Test_That_CalculateSpanBetweenTwoDates_Return_False_As_Fortnight_When_Known_Dates_Are_Not_A_Fornight_Apart()
        {
            bool isFortnight;
            DateTime d1 = new DateTime(2012, 8, 13);
            DateTime d2 = new DateTime(2012, 8, 28);
            int daySpan = pd.CalculateSpanBetweenTwoDates(d1, d2, out isFortnight);
            Assert.IsFalse(isFortnight);

        }
    }
}
