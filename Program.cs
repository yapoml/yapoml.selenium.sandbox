﻿using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();

var ya = driver.Ya(options => options.WithBaseUrl("https://github.com"));

ya.SearchPage.Open(query: "yapoml")
    .Repositories[r => r.Name == "yapoml/yapoml"]
    .Name.Click();

ya.RepositoryPage.Star.Click();