using ProbabilityCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCMiniProject.Controllers
{
    public class CalculatorController : ApiController
    {
        public class QueryModel
        {
            public string probaA { get; set; }
            public string probaB { get; set; }
        }

        [ActionName("GetIndependentJointProbability")]
        public float GetIndependentJointProbability([FromUri] QueryModel model)
        {
            float probaA;
            float probaB;

            try
            {
                ParseModel(model, out probaA, out probaB);
                return Operations.IndependentJointProbability(probaA, probaB);

            }
            catch (Exception ex)
            {
                HttpResponseMessage response =
                    this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                throw new HttpResponseException(response);
            }
        }

        [ActionName("GetNotMutuallyExclusiveJointProbability")]
        public float GetNotMutuallyExclusiveJointProbability([FromUri] QueryModel model)
        {
            float probaA;
            float probaB;

            try
            {
                ParseModel(model, out probaA, out probaB);
                return Operations.NotMutuallyExclusiveJointProbability(probaA, probaB);

            }
            catch (Exception ex)
            {
                HttpResponseMessage response =
                    this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                throw new HttpResponseException(response);
            }
        }

        private void ParseModel(QueryModel model, out float probaA, out float probaB)
        {
            if (model == null)
            {
                throw new ArgumentNullException("Two probabilities expected: probaA:float, probaB:float.");
            }
            else if (!float.TryParse(model.probaA, out probaA))
            {
                throw new ArgumentException("Probability A is incorrect.");
            }
            else if (!float.TryParse(model.probaB, out probaB))
            {
                throw new ArgumentException("Probability B is incorrect.");
            }
        }
    }
}
