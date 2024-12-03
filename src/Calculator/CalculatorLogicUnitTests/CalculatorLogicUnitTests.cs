using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CalculatorLogicUnitTests

{
    [TestFixture]
    public class CalculatorLogicUnitTests
    {
        
        [Test]
        public void CalculatorLogic_ComputeMean_ValidList_NoException()
        //preq-UNIT-TEST-4-A
        {
            //tests to make sure that a valid list actually counts as a valid list
            CalculatorLogic.CalculatorLogic meanTestValidListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> meanTestValidList = new List<double>();
            meanTestValidList.Add(9.0);
            meanTestValidList.Add(6.0); 
            meanTestValidList.Add(8.0);
            meanTestValidList.Add(5.0);
            meanTestValidList.Add(7.0);
            try
            {   
                meanTestValidListCalc.ComputeMean(meanTestValidList);
                
                Assert.That(true);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
            
            
        }
        [Test]
        public void CalculatorLogic_ComputeMean_InvalidList_ArguementException()
            //preq-UNIT-TEST-4-B
        {
            //tests to make sure an invalid list throws an exception
            CalculatorLogic.CalculatorLogic meanTestInvalidListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> meanTestInvalidList = new List<double>();
            try
            {
                meanTestInvalidListCalc.ComputeMean(meanTestInvalidList);
                
            }
            catch (Exception)
            {
                Assert.That(true);
            }
            
        }

        [Test]
        public void CalculatorLogic_ComputeMean_Calculation_ResultOfSeven()
            //preq-UNIT-TEST-4-C
        {
            //tests to make sure that the mean is properly calculated using the example values
            CalculatorLogic.CalculatorLogic meanTestListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> meanTestList = new List<double>();
            meanTestList.Add(9.0);
            meanTestList.Add(6.0);
            meanTestList.Add(8.0);
            meanTestList.Add(5.0);
            meanTestList.Add(7.0);
            Assert.That(meanTestListCalc.ComputeMean(meanTestList) == 7.0);
        }

        [Test]
        public void CalculatorLogic_ComputeSampleStandardDeviation_ValidList_NoException()
        //preq-UNIT-TEST-2-A
        {
            CalculatorLogic.CalculatorLogic sampleSDTestValidListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> sampleSDTestValidList = new List<double>();
            sampleSDTestValidList.Add(9.0);
            sampleSDTestValidList.Add(6.0);
            sampleSDTestValidList.Add(8.0);
            sampleSDTestValidList.Add(5.0);
            sampleSDTestValidList.Add(7.0);
            try
            {
                sampleSDTestValidListCalc.ComputeSampleStandardDeviation(sampleSDTestValidList);
                
                Assert.That(true);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
        [Test]
        public void CalculatorLogic_ComputeSampleStandardDeviation_InvalidList_ArgumentException()
            //preq-UNIT-TEST-2-B
        {
            CalculatorLogic.CalculatorLogic sampleSDTestInvalidListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> sampleSDTestInvalidList = new List<double>();
            try
            {
                sampleSDTestInvalidListCalc.ComputeSampleStandardDeviation(sampleSDTestInvalidList);
                
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_ComputeSampleStandardDeviation_InvalidListOfOne_ArgumentException()
            //preq-UNIT-TEST-2-C
        {
            CalculatorLogic.CalculatorLogic sampleSDTestInvalidListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> sampleSDTestInvalidList = new List<double>();
            sampleSDTestInvalidList.Add(9.0);
            try
            {
                sampleSDTestInvalidListCalc.ComputeSampleStandardDeviation(sampleSDTestInvalidList);
                
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_ComputeSampleStandardDeviation_CalculationWorks_ResultFromRequirements()
            //preq-UNIT-TEST-2-D
        {
            CalculatorLogic.CalculatorLogic sampleSDTestListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> sampleSDTestList = new List<double>();
            sampleSDTestList.Add(9.0);
            sampleSDTestList.Add(6.0);
            sampleSDTestList.Add(8.0);
            sampleSDTestList.Add(5.0);
            sampleSDTestList.Add(7.0);
            try
            {
                
                Assert.That(sampleSDTestListCalc.ComputeSampleStandardDeviation(sampleSDTestList) == 1.5811388300841898);
                
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
        [Test]
        public void CalculatorLogic_ComputeSampleStandardDeviation_CalculationWorksAllZeros_ResultOfZero()
            //preq-UNIT-TEST-2-E
        {
            CalculatorLogic.CalculatorLogic sampleSDTestListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> sampleSDTestList = new List<double>();
            sampleSDTestList.Add(0.0);
            sampleSDTestList.Add(0.0);
            sampleSDTestList.Add(0.0);
            sampleSDTestList.Add(0.0);
            sampleSDTestList.Add(0.0);
            try
            {
                
                Assert.That(sampleSDTestListCalc.ComputeSampleStandardDeviation(sampleSDTestList) == 0.0);
                
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
        [Test]
        public void CalculatorLogic_ComputePopulationStandardDeviation_ValidList_NoException()
            //preq-UNIT-TEST-3-A
        {
            CalculatorLogic.CalculatorLogic populationSDTestValidListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> populationSDTestValidList = new List<double>();
            populationSDTestValidList.Add(9.0);
            populationSDTestValidList.Add(6.0);
            populationSDTestValidList.Add(8.0);
            populationSDTestValidList.Add(5.0);
            populationSDTestValidList.Add(7.0);
            try
            {
                populationSDTestValidListCalc.ComputePopulationStandardDeviation(populationSDTestValidList);
                
                Assert.That(true);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
        [Test]
        public void CalculatorLogic_ComputePopulationStandardDeviation_InvalidList_ArgumentException()
            //preq-UNIT-TEST-3-B
        {
            CalculatorLogic.CalculatorLogic populationSDTestInvalidListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> populationSDTestInvalidList = new List<double>();
            try
            {
                populationSDTestInvalidListCalc.ComputePopulationStandardDeviation(populationSDTestInvalidList);
                
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_ComputePopulationStandardDeviation_CalculationWorks_ResultFromRequirements_RoundedToThirteenPlaces()
            //preq-UNIT-TEST-3-C
        {
            CalculatorLogic.CalculatorLogic populationSDTestListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> populationSDTestList = new List<double>();
            populationSDTestList.Add(9.0);
            populationSDTestList.Add(6.0);
            populationSDTestList.Add(8.0);
            populationSDTestList.Add(5.0);
            populationSDTestList.Add(7.0);
            try
            {
                
                
                Assert.That(Math.Round(populationSDTestListCalc.ComputePopulationStandardDeviation(populationSDTestList), 13) == 1.4142135623731);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
        [Test]
        public void CalculatorLogic_ComputePopulationStandardDeviation_CalculationWorksAllZeros_ResultOfZero()
            //preq-UNIT-TEST-3-D
        {
            CalculatorLogic.CalculatorLogic populationSDTestListCalc = new CalculatorLogic.CalculatorLogic();
            List<double> populationSDTestList = new List<double>();
            populationSDTestList.Add(0.0);
            populationSDTestList.Add(0.0);
            populationSDTestList.Add(0.0);
            populationSDTestList.Add(0.0);
            populationSDTestList.Add(0.0);
            try
            {
                
                Assert.That(populationSDTestListCalc.ComputePopulationStandardDeviation(populationSDTestList) == 0.0);
                
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }

        [Test]
        public void CalculatorLogic_ComputeZScore_ValidList_NoException()
        //preq-UNIT-TEST-5-A
        {
            CalculatorLogic.CalculatorLogic ZScoreCalc = new CalculatorLogic.CalculatorLogic();
            double[] inputList = new double[3];
            inputList[0] = 1;
            inputList[1] = 3;
            inputList[2] = 1;
            try
            {
                ZScoreCalc.ComputeZScore(inputList);
                Assert.That(true);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }

        [Test]
        public void CalculatorLogic_ComputeZScore_InvalidList_ArgumentException()
            //preq-UNIT-TEST-5-B
        {
            CalculatorLogic.CalculatorLogic ZScoreCalc = new CalculatorLogic.CalculatorLogic();
            double[] inputList = new double[2];
            inputList[0] = 3;
            inputList[1] = 5;

            try
            {
                ZScoreCalc.ComputeZScore(inputList);
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        
        [Test]
        public void CalculatorLogic_ComputeZScore_StdDevZero_DivideByZeroException()
            //preq-UNIT-TEST-5-C
        {
            CalculatorLogic.CalculatorLogic ZScoreCalc = new CalculatorLogic.CalculatorLogic();
            double[] inputList = new double[3];
            inputList[0] = 1;
            inputList[1] = 3;
            inputList[2] = 0;
            try
            {
                ZScoreCalc.ComputeZScore(inputList);
                
            }
            catch (DivideByZeroException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_ComputeZScore_CalculationWorks_ResultofNegativeTwo()
            //preq-UNIT-TEST-5-D
        {
            CalculatorLogic.CalculatorLogic ZScoreCalc = new CalculatorLogic.CalculatorLogic();
            double[] inputList = new double[3];
            inputList[0] = 1;
            inputList[1] = 3;
            inputList[2] = 1;
            try
            {
                Assert.That(ZScoreCalc.ComputeZScore(inputList)== -2.0);
                
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }

        [Test]
        public void CalculatorLogic_ComputeSingleLinearRegressionFormula_EmptyList_ArgumentException()
        {
            CalculatorLogic.CalculatorLogic linRegCalc = new CalculatorLogic.CalculatorLogic();
            List<double[]> inputList = new List<double[]>();
            
            try
            {
                linRegCalc.ComputeSingleLinearRegressionFormula(inputList);
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        
        public void CalculatorLogic_ComputeSingleLinearRegressionFormula_ListOfOne_ArgumentException()
        {
            CalculatorLogic.CalculatorLogic linRegCalc = new CalculatorLogic.CalculatorLogic();
            List<double[]> inputList = new List<double[]>();
            inputList.Add(new double[] { 1, 5 });
            try
            {
                linRegCalc.ComputeSingleLinearRegressionFormula(inputList);
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_ComputeSingleLinearRegressionFormula_InvalidArrayTooFewParameters_ArgumentException()
        {
            CalculatorLogic.CalculatorLogic linRegCalc = new CalculatorLogic.CalculatorLogic();
            List<double[]> inputList = new List<double[]>();
            inputList.Add(new double[] { 1 });
            inputList.Add(new double[] { 2, 2 });
            try
            {
                linRegCalc.ComputeSingleLinearRegressionFormula(inputList);
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_ComputeSingleLinearRegressionFormula_InvalidArrayTooManyParameters_ArgumentException()
        {
            CalculatorLogic.CalculatorLogic linRegCalc = new CalculatorLogic.CalculatorLogic();
            List<double[]> inputList = new List<double[]>();
            inputList.Add(new double[] { 1, 3, 5 });
            inputList.Add(new double[] { 2, 2 });
            try
            {
                linRegCalc.ComputeSingleLinearRegressionFormula(inputList);
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_ComputeSingleLinearRegressionFormula_ValidArray_NoException()
        {
            CalculatorLogic.CalculatorLogic linRegCalc = new CalculatorLogic.CalculatorLogic();
            List<double[]> inputList = new List<double[]>();
            inputList.Add(new double[] { 1, 5 });
            inputList.Add(new double[] { 5, 4 });
            inputList.Add(new double[] { 3, 8 });
            inputList.Add(new double[] { 6, 2 });
            try
            {
                linRegCalc.ComputeSingleLinearRegressionFormula(inputList);
                Assert.That(true);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
        [Test]
        public void CalculatorLogic_ComputeSingleLinearRegressionFormula_CalculationTest_ResultOfSlopeOneInterceptZero()
        {
            CalculatorLogic.CalculatorLogic linRegCalc = new CalculatorLogic.CalculatorLogic();
            List<double[]> inputList = new List<double[]>();
            inputList.Add(new double[] { 0, 0 });
            inputList.Add(new double[] { 1, 1 });
            inputList.Add(new double[] { 2, 2 });
            inputList.Add(new double[] { 3, 3 });
            inputList.Add(new double[] { 4, 4 });
            double[] expectedResult = new double[2];
            expectedResult[0] = 1;
            expectedResult[1] = 0;
            try
            {
                
                Assert.That(linRegCalc.ComputeSingleLinearRegressionFormula(inputList)[0] == expectedResult[0] && linRegCalc.ComputeSingleLinearRegressionFormula(inputList)[1] == expectedResult[1]);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }

        [Test]
        public void CalculatorLogic_PredictYFromLinearRegressionFormula_MissingParameters_ArgumentException()
        {
            CalculatorLogic.CalculatorLogic linRegPredictCalc = new CalculatorLogic.CalculatorLogic();
            try
            {
                linRegPredictCalc.PredictYFromLinearRegressionFormula(new double[0]);
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }
        [Test]
        public void CalculatorLogic_PredictYFromLinearRegressionFormula_TooManyParameters_ArgumentException()
        {
            CalculatorLogic.CalculatorLogic linRegPredictCalc = new CalculatorLogic.CalculatorLogic();
            try
            {
                linRegPredictCalc.PredictYFromLinearRegressionFormula(new double[4]);
                
            }
            catch (ArgumentException)
            {
                Assert.That(true);
            }
            
        }

        [Test]
        public void CalculatorLogic_PredictYFromLinearRegressionFormula_TooFewParameters_ArgumentException()
        {
            {
                CalculatorLogic.CalculatorLogic linRegPredictCalc = new CalculatorLogic.CalculatorLogic();
                try
                {
                    linRegPredictCalc.PredictYFromLinearRegressionFormula(new double[2]);
                    
                }
                catch (ArgumentException)
                {
                    Assert.That(true);
                }
                
            }
        }

        [Test]
        public void CalculatorLogic_PredictYFromLinearRegressionFormula_ProperInput_NoException()
        {
            CalculatorLogic.CalculatorLogic linRegPredictCalc = new CalculatorLogic.CalculatorLogic();
            double[] inputList = new double[] { 1, 2, 3 };
            try
            {
                linRegPredictCalc.PredictYFromLinearRegressionFormula(inputList);
                Assert.That(true);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
        [Test]
        public void PredictYFromLinearRegressionFormula_Calculation_ResultOfFive()
        {
            CalculatorLogic.CalculatorLogic linRegPredictCalc = new CalculatorLogic.CalculatorLogic();
            double[] inputList = new double[] { 1, 2, 3 };
            try
            {
                
                Assert.That(linRegPredictCalc.PredictYFromLinearRegressionFormula(inputList) == 5.0);
            }
            catch (ArgumentException)
            {
                Assert.That(false);
            }
        }
    }
}