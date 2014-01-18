﻿using System;
using ApprovalTests.Wpf;
using DeveloperTimer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperTimer.Tests.Forms
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void TestMainWindow()
        {
            var window = new MainWindow(3, 14); 
            WpfApprovals.Verify(window);
        }
    }
}
