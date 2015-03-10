using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityCalculator
{
    public static class Operations
    {
        private static bool IsValidProba(float proba)
        {
            return proba >= 0f && proba <= 1f;
        }

        public static float IndependentJointProbability(float probaA, float probaB)
        {
            if (!IsValidProba(probaA) || !IsValidProba(probaB))
            {
                throw new ArgumentException("Probability must be in range [0;1]");
            }
            return probaA * probaB;
        }

        public static float NotMutuallyExclusiveJointProbability(float probaA, float probaB)
        {
            if (!IsValidProba(probaA) || !IsValidProba(probaB))
            {
                throw new ArgumentException("Probability must be in range [0;1]");
            }
            return probaA + probaB - probaA * probaB;
        }
    }
}
