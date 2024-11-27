    using System;
using System.Collections.Generic;
namespace CalculatorLogic
{
    public class CalculatorLogic
    {
        public double ComputeSampleStandardDeviation(List<double> inputList)
        //preq-LOGIC-3
        {
            if (inputList.Count == 0)
            {
                throw new ArgumentException("Input list is empty");
            }

            if (inputList.Count == 1)
            {
                throw new ArgumentException("Input list cannot be exactly one value");
            }
            double mean = ComputeMean(inputList);
            double SD = 0;
            foreach (double value in inputList)
            {
                SD += (value - mean) * (value - mean);
            }
            SD /= (inputList.Count-1);
            return Math.Sqrt(SD);
        }
        public double ComputePopulationStandardDeviation(List<double> inputList)
            //preq-LOGIC-4
        {
            if (inputList.Count == 0)
            {
                throw new ArgumentException("Input list is empty");
            }
            double mean = ComputeMean(inputList);
            double SD = 0;
            foreach (double value in inputList)
            {
                SD += (value - mean) * (value - mean);
            }
            SD /= inputList.Count;
            return Math.Sqrt(SD);
        }
        public double ComputeMean(List<double> inputList)
            //preq-LOGIC-5
        {
            foreach (double value in inputList)
            {
                
            }
            double mean = 0;
            foreach (double value in inputList)
            {
                mean += value;
            }
            mean /= inputList.Count;
            return mean;
        }
        public double ComputeZScore(double[] inputList)
            //preq-LOGIC-6
        {
            if (inputList.Length != 3)
            {
                throw new ArgumentException("Must have exactly 3 inputs");
            }

            if (inputList[2] == 0)
            {
                throw new DivideByZeroException("Standard Deviation Cannot Be Zero");
            }
            double zScore = 0;
            zScore = (inputList[0] - inputList[1]) / inputList[2];
            return zScore;
        }
        public double[] ComputeSingleLinearRegressionFormula(List<double[]> inputList)
            //preq-LOGIC-7
        {
            if (inputList.Count == 0)
            {
                throw new ArgumentException("Must have at least one input");
            }
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i].Length != 2)
                {
                    throw new ArgumentException("Must have exactly 2 data points per input");
                }
            }
            double sumX = 0;
            double sumY = 0;
            double sumXSquared = 0;
            double sumXY = 0;
            foreach (double[] i in inputList)
            {
                sumX += i[0];
                sumY += i[1];
                sumXSquared += i[0] * i[0];
                sumXY += i[0] * i[1];
            }

            double slope = (((inputList.Count * sumXY) - (sumX * sumY)) /
                           ((inputList.Count * sumXSquared) - (sumX * sumX)));
            double intercept = ((sumY - (slope * sumX)) / (inputList.Count));
            double[] results = {slope, intercept};
            
            return results;
        }
        public double PredictYFromLinearRegressionFormula(double[] inputList)
            //preq-LOGIC-8
        {
            if (inputList.Length == 0)
            {
                throw new ArgumentException("Must have at least one input");
            }

            if (inputList.Length != 3)
            {
                throw new ArgumentException("Must have exactly 3 inputs");
            }

            return (inputList[0] * inputList[1]) + (inputList[2]);
        }

        public CalculatorLogic()
        {
            
        }
    }
}