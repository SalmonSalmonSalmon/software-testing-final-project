namespace CalculatorWebServerApp;
using CalculatorLogic;
using System.Collections.Generic;

public class CalculatorUISystem
{
    public string FormatMean(string input)
    {
        CalculatorLogic calculator = new CalculatorLogic();
        string[] inputListString = input.Split("\n");
        List<Double> inputListDouble = new List<double>();
        foreach (string inputString in inputListString)
        {
            inputListDouble.Add(double.Parse(inputString));
        }
        return Convert.ToString(calculator.ComputeMean(inputListDouble));
    }
    public string FormatSampleSD(string input)
    {
        CalculatorLogic calculator = new CalculatorLogic();
        string[] inputListString = input.Split("\n");
        List<Double> inputListDouble = new List<double>();
        foreach (string inputString in inputListString)
        {
            inputListDouble.Add(double.Parse(inputString));
        }
        return Convert.ToString(calculator.ComputeSampleStandardDeviation(inputListDouble));
    }
    public string FormatPopulationSD(string input)
    {
        CalculatorLogic calculator = new CalculatorLogic();
        string[] inputListString = input.Split("\n");
        List<Double> inputListDouble = new List<double>();
        foreach (string inputString in inputListString)
        {
            inputListDouble.Add(double.Parse(inputString));
        }
        return Convert.ToString(calculator.ComputePopulationStandardDeviation(inputListDouble));
    }

    public string FormatZScore(string input)
    {
        CalculatorLogic calculator = new CalculatorLogic();
        if (input.Contains("\n"))
        {
            throw new ArgumentException("Must have only one line of data");
        }
        string[] inputListString = input.Split(",");
        double[] inputListDouble = new double[inputListString.Length];
        for (int i = 0; i < inputListString.Length; i++)
        {
            inputListDouble[i] = double.Parse(inputListString[i]);
        }
        return Convert.ToString(calculator.ComputeZScore(inputListDouble));
    }

    public string FormatRegressionFormula(string input)
    {
        CalculatorLogic calculator = new CalculatorLogic();
        string[] inputListString = input.Split("\n");
        List<double[]> inputListDoubleList = new List<double[]>();
        foreach (string inputString in inputListString)
        {
            inputListDoubleList.Add(inputString.Split(",").Select(double.Parse).ToArray());
        }

        double[] finalResult = calculator.ComputeSingleLinearRegressionFormula(inputListDoubleList);
        return "y = "+ finalResult[0].ToString()+"x + "+finalResult[1].ToString();
    }
    public string FormatRegressionPrediction(string input)
    {
        CalculatorLogic calculator = new CalculatorLogic();
        if (input.Contains("\n"))
        {
            throw new ArgumentException("Must have only one line of data");
        }
        string[] inputListString = input.Split(",");
        double[] inputListDouble = new double[inputListString.Length];
        for (int i = 0; i < inputListString.Length; i++)
        {
            inputListDouble[i] = double.Parse(inputListString[i]);
        }
        return Convert.ToString(calculator.PredictYFromLinearRegressionFormula(inputListDouble));
    }
}