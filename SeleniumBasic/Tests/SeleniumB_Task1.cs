﻿/*
Задание 1:
Закончить тест на проверку СКФ (https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148 ). 
В рамках теста проверить рассчитанные результаты
*/

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace SeleniumBasic.Tests
{
    internal class SeleniumB_Task1 : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
            Thread.Sleep(1000);
            Driver.SwitchTo().Frame(0);
        }

        [Test]
        public void ValidateSKF()
        {
                        
            IWebElement ageInput = Driver.FindElement(By.Id("age"));
            ageInput.SendKeys("40");

            SelectElement selectSexElement = new SelectElement(Driver.FindElement(By.Id("sex")));
            selectSexElement.SelectByText("Мужской");

            IWebElement creatinineInput = Driver.FindElement(By.Id("cr"));
            creatinineInput.SendKeys("15");

            SelectElement dropDownElement = new SelectElement(Driver.FindElement(By.Id("cr-size")));
            dropDownElement.SelectByText("мг/дл");

            SelectElement selectRaceElement = new SelectElement(Driver.FindElement(By.Id("race")));
            selectRaceElement.SelectByText("Негроидная");

            IWebElement massaInput = Driver.FindElement(By.Id("mass"));
            massaInput.SendKeys("80");

            IWebElement growInput = Driver.FindElement(By.Id("grow"));
            growInput.SendKeys("199");

            IWebElement calcButton = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
            calcButton.Click();
            Thread.Sleep(4000);

            Assert.Multiple(() =>
            {         
            Assert.That(Driver.FindElement(By.Id("mdrd_res")).Text, Is.EqualTo("4.41"));
            Assert.That(Driver.FindElement(By.TagName("i")).Text, Is.EqualTo("мл/мин/1.73м2"));
            Assert.That(Driver.FindElement(By.ClassName("diagnosis")).Text, Is.EqualTo("Терминальная почечная недостаточность (C5)"));                           
            Assert.That(Driver.FindElement(By.Id("ckd_epi_res")).Text, Is.EqualTo("4.11"));   
            Assert.That(Driver.FindElement(By.Id("cge_res")).Text, Is.EqualTo("7.41"));             
            });
        }
    }
}