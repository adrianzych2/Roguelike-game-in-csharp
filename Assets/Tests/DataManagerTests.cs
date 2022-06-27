using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DungeonCrawl.Core;

namespace DungeonCrawl.Core.Tests
{
    public class DataManagerTests 
    {
        DataManager _dataManager = DataManager.Singleton;

        [Test]
        public void CheckConnection()
        {
            Assert.IsTrue(true);
        }
    }
}
