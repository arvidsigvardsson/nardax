﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    [TestClass]
    {
        Queue<string> _queue;

        public QueueExtensionsTests()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("aa");
            _queue.Enqueue("bb");
            
            Assert.AreEqual("ee", _queue.Dequeue());
        }
    }
}
