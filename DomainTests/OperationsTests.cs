using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void IndependentMethod_Should_ReturnIndependentJointProbability()
        {
            // Given
            float probaA = 1 / 2;
            float probaB = 1 / 2;
            float expectedJointProbability = 1 / 4;

            // When
            float result = ProbabilityCalculator.Operations.IndependentJointProbability(probaA, probaB);

            // Then
            Assert.AreEqual<float>(expectedJointProbability, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndependentMethod_Should_FailWhenInvalidProbability()
        {
            // Given
            float invalidProba = 1.1f;
            float probaB = 1 / 2;

            // When
            ProbabilityCalculator.Operations.IndependentJointProbability(invalidProba, probaB);

            // Then
            // Expected Argument Exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndependentMethod_Should_FailWhenInvalidNegativeProbability()
        {
            // Given
            float negativeProba = -0.1f;
            float probaB = 1 / 2;

            // When
            ProbabilityCalculator.Operations.IndependentJointProbability(negativeProba, probaB);

            // Then
            // Expected Argument Exception
        }

        [TestMethod]
        public void NotMutuallyExclusiveMethod_Should_ReturnNotMutuallyExclusiveJointProbability()
        {
            // Given
            float probaA = 13 / 52;
            float probaB = 12 / 52;
            float expectedJointProbability = 11 / 26;

            // When
            float result = ProbabilityCalculator.Operations.NotMutuallyExclusiveJointProbability(probaA, probaB);

            // Then
            Assert.AreEqual<float>(expectedJointProbability, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotMutuallyExclusiveMethod_Should_FailWhenInvalidProbability()
        {
            // Given
            float invalidProba = 1.1f;
            float probaB = 1 / 2;

            // When
            ProbabilityCalculator.Operations.NotMutuallyExclusiveJointProbability(invalidProba, probaB);

            // Then
            // Expected Argument Exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotMutuallyExclusiveMethod_Should_FailWhenInvalidNegativeProbability()
        {
            // Given
            float negativeProba = -0.1f;
            float probaB = 1 / 2;

            // When
            ProbabilityCalculator.Operations.NotMutuallyExclusiveJointProbability(negativeProba, probaB);

            // Then
            // Expected Argument Exception
        }
    }
}
