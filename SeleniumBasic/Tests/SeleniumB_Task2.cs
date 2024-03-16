/*Задание 2:
Написать тест на проверку расчетов “Калькулятор ламината” (https://home-ex.ru/calculation/ ).
В рамках теста проверить рассчитанные результаты
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

internal class SeleniumB_Task2 : BaseTest
{    
    [Test]
    public void LaminateCalculate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement lnRoomInput = Driver.FindElement(By.Id("ln_room_id"));
        lnRoomInput.Clear();
        lnRoomInput.SendKeys("900");

        IWebElement wdRoomInput = Driver.FindElement(By.Id("wd_room_id")); 
        wdRoomInput.Clear();
        wdRoomInput.SendKeys("500");

        IWebElement lnLaminateInput = Driver.FindElement(By.Id("ln_lam_id"));
        lnLaminateInput.Clear();
        lnLaminateInput.SendKeys("1020");

        IWebElement wdLaminateInput = Driver.FindElement(By.Id("wd_lam_id"));
        wdLaminateInput.Clear();
        wdLaminateInput.SendKeys("310");

        IWebElement amountInput = Driver.FindElement(By.Id("n_packing"));
        amountInput.Clear();
        amountInput.SendKeys("18");

        IWebElement areaInput = Driver.FindElement(By.Id("area"));
        areaInput.SendKeys("5");

        IWebElement directionButton = Driver.FindElement(By.Id("direction-laminate-id1")); 
        directionButton.Click(); 
        
        new SelectElement(Driver.FindElement(By.Id("laying_method_laminate"))).SelectByValue("0"); 

        IWebElement minPieceInput = Driver.FindElement(By.Id("min_length_segment_id"));  
        // оставить дефолтным 250

        IWebElement wallsGapInput = Driver.FindElement(By.Id("indent_walls_id"));
        wallsGapInput.SendKeys(Keys.Backspace);
        wallsGapInput.SendKeys("15");        
       
        IWebElement calcButton = Driver.FindElement(By.Id("btn_calculate"));           
        calcButton.Click();
        Thread.Sleep(4000);

        var result = Driver.FindElement(By.ClassName("calc-result")).Text;
        Assert.That(result.Contains("Требуемое количество плашек ламината: 146") && result.Contains("Количество упаковок ламината: 9"));
    }
}