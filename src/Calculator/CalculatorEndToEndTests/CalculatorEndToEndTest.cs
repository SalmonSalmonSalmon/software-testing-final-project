using Microsoft.Playwright;

namespace CalculatorEndToEndTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    //preq-E2E-TEST-5
    public async Task CalculatorWebServerAppHome_PageTitle_IsCalculator()
    {
        await Page.GotoAsync("http://localhost:5000/");

        
        await Expect(Page).ToHaveTitleAsync("Calculator");
    }

    [Test]
    public async Task CalculatorUISystem_FormatSampleSD_AccurateResult()
    //preq-E2E-TEST-6
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByText("Clear").ClickAsync();
        await Page.GetByLabel("inputField").FillAsync("9\n 2\n 5\n 4\n 12\n 7\n 8\n 11\n 9\n 3\n 7\n 4\n 12\n 5\n 4\n 10\n 9\n 6\n 9\n 4");
        await Page.GetByText("Compute Sample Standard Deviation | One Value Per Line").ClickAsync();
        await Expect(Page.GetByLabel("outputText")).ToContainTextAsync("3.060787652326");
    }
    [Test]
    public async Task CalculatorUISystem_FormatPopulationSD_EmptyInputErrorMessage()
        //preq-E2E-TEST-7
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByText("Compute Population Standard Deviation | One Value Per Line").ClickAsync();
        await Expect(Page.GetByLabel("outputText")).ToContainTextAsync("Must have at least one input");
    }
    [Test]
    public async Task CalculatorUISystem_FormatSampleSD_OneLineInputErrorMessage()
        //preq-E2E-TEST-8
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByText("Clear").ClickAsync();
        await Page.GetByLabel("inputField").FillAsync("9");
        await Page.GetByText("Compute Sample Standard Deviation | One Value Per Line").ClickAsync();
        await Expect(Page.GetByLabel("outputText")).ToContainTextAsync("Input list cannot be exactly one value");
    }
    [Test]
    public async Task CalculatorUISystem_FormatMean_AccurateResult()
        //preq-E2E-TEST-9
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByText("Clear").ClickAsync();
        await Page.GetByLabel("inputField").FillAsync("9\n 2\n 5\n 4\n 12\n 7\n 8\n 11\n 9\n 3\n 7\n 4\n 12\n 5\n 4\n 10\n 9\n 6\n 9\n 4");
        await Page.GetByText("Compute Mean | One Value Per Line").ClickAsync();
        await Expect(Page.GetByLabel("outputText")).ToContainTextAsync("7");
    }
    [Test]
    public async Task CalculatorUISystem_FormatZScore_AccurateResult()
        //preq-E2E-TEST-10
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByText("Clear").ClickAsync();
        await Page.GetByLabel("inputField").FillAsync("5.5, 7, 3.060787652326");
        await Page.GetByText("Compute Z-Score | value, mean, StdDev on one line").ClickAsync();
        await Expect(Page.GetByLabel("outputText")).ToContainTextAsync("-0.49006993309715474");
    }
    [Test]
    public async Task CalculatorUISystem_FormatRegressionFormula_AccurateResult()
        //preq-E2E-TEST-11
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByText("Clear").ClickAsync();
        await Page.GetByLabel("inputField").FillAsync("5,3\n3,2\n2,15\n1,12.3\n7.5,-3\n4,5\n3,17\n4,3\n6.42,4\n34,5\n12,17\n3,-1");
        await Page.GetByText("Compute Single Linear Regression Formula | One X,Y Pair Per Line").ClickAsync();
        await Expect(Page.GetByLabel("outputText")).ToContainTextAsync("y = -0.045961532930936355x + 6.933587781374592");
    }

    [Test]
    public async Task CalculatorUISystem_FormatRegressionPrediction_AccurateResult()
    //preq-E2E-Test-11
    {
        await Page.GotoAsync("http://localhost:5000/");
        await Page.GetByText("Clear").ClickAsync();
        await Page.GetByLabel("inputField").FillAsync("-0.04596, 6, 6.9336");
        await Page.GetByText("Compute Y From Linear Regression Formula | m,x,b On One Line").ClickAsync();
        await Expect(Page.GetByLabel("outputText")).ToContainTextAsync("6.65784");
    }
}