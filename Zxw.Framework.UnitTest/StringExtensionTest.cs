using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Zxw.Framework.NetCore.Extensions;

namespace Zxw.Framework.UnitTest
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void TestExtract()
        {
            var str = "【接触物理性有害因素】[0，无\r\n            1，噪声\r\n            2，震动\r\n            3，X射线\r\n            4，电磁辐射\r\n            5，高温\r\n            6，极低温度\r\n            7，微波\r\n            8，其他]";
            var result = str.Extract(@"\[(.*)\]");
            Assert.IsTrue(result.Length > 0);
        }
    }
}