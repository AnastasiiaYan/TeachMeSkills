using NUnit.Framework;
using SeleniumBasic.Utilites.Configuration;
using OpenQA.Selenium;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;

[Parallelizable(scope: ParallelScope.All)] //параллелизация запусков
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)] //отдельный экземпляр для каждого
public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
       
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}