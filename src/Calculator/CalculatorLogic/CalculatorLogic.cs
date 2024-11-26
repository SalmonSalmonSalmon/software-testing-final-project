using System.Collections.Generic;
{
    public class CalculatorLogic
    {
        public double ComputeSampleStandardDeviation(List<double> inputList)
        //preq-LOGIC-3
        {
            
        }
        public double ComputePopulationStandardDeviation(List<double> inputList)
            //preq-LOGIC-4
        {
            
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
            
        }
        public double ComputeSingleLinearRegressionFormula(List<double> inputList)
            //preq-LOGIC-7
        {
            
        }
        public double PredictYFromLinearRegressionFormula(double[] inputList)
            //preq-LOGIC-8
        {
            
        }
        
        
    }
}