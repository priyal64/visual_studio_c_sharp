// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class PercentTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void percent() {
    driver.Navigate().GoToUrl("https://www.calculator.net/percent-calculator.html");
    driver.Manage().Window.Size = new System.Drawing.Size(652, 672);
    driver.FindElement(By.Id("cpar1")).Click();
    driver.FindElement(By.Id("cpar1")).SendKeys("34");
    {
      var element = driver.FindElement(By.Name("x"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.Id("cpar2")).Click();
    driver.FindElement(By.Id("cpar2")).SendKeys("200");
    driver.FindElement(By.Name("x")).Click();
  }
}
