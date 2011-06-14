﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Logging Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Tests.TraceListeners.NotificationTraceListenerScenarios.given_notification_trace_with_trace_tag
{
    [TestClass]
    public class when_data_is_traced : Context
    {
        protected override void Arrange()
        {
            base.Arrange();
        }

        [TestMethod]
        public void then_original_log_entry_can_be_retrieved()
        {
            Listener.TraceData(new Diagnostics.TraceEventCache(), "test", Diagnostics.TraceEventType.Error, 100, ActualLogEntry);

            Assert.AreSame(ActualLogEntry, NotificationTraceLogEntry);
        }

        [TestMethod]
        public void then_original_trace_tag_can_be_retrieved()
        {
            Listener.TraceData(new Diagnostics.TraceEventCache(), "test", Diagnostics.TraceEventType.Error, 100, ActualLogEntry);

            Assert.AreSame(DefaultTraceTag, TraceTag);
        }

        // TODO : Check with Fernando if this test is required or not...
        [TestMethod]
        public void then_listener_is_thread_safe()
        {
            Assert.IsTrue(Listener.IsThreadSafe);
        }
    }
}