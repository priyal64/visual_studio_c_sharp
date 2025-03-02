using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class MultiUserTest
{
    private List<(string username, string password)> users = new List<(string, string)>
    {
        ("standard_user", "secret_sauce"), // Valid user
        ("locked_out_user", "secret_sauce"), // Invalid user (locked out)
        ("problem_user", "secret_sauce") // Another test user
    };

    [Test]
    public void TestMultipleUsers()
    {
        for (int i = 0; i < users.Count; i++)
        {
            RunTestForUser(users[i].username, users[i].password);
        }
    }

    public void RunTestForUser(string username, string password)
    {
        IWebDriver driver = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        // Enter username
        IWebElement usernameField = wait.Until(d => d.FindElement(By.Id("user-name")));
        usernameField.Clear();
        usernameField.SendKeys(username);

        // Enter password
        IWebElement passwordField = driver.FindElement(By.Id("password"));
        passwordField.Clear();
        passwordField.SendKeys(password);

        // Click login button
        IWebElement loginButton = driver.FindElement(By.Id("login-button"));
        loginButton.Click();

        // Check if login was successful
        bool isLoginSuccessful = wait.Until(d => d.Url.Contains("inventory.html"));

        if (isLoginSuccessful)
        {
            Console.WriteLine($"✅ Login successful for {username}");

            // Click logout
            IWebElement menuButton = driver.FindElement(By.Id("react-burger-menu-btn"));
            menuButton.Click();
            wait.Until(d => d.FindElement(By.Id("logout_sidebar_link"))).Click();
            Console.WriteLine($"🚪 Logged out {username}");
        }
        else
        {
            Console.WriteLine($"❌ Login failed for {username}");
        }

        driver.Quit();
    }
}
