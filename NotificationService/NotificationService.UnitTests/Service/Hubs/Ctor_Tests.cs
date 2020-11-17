﻿// <autogenerated />
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace NotificationService.UnitTests.Service.Hubs_Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using WebNotifications.Hubs;
    using NUnit.Framework;

    /// <summary>
    /// Test Base class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Ctor_Tests : NotificationsHubBaseTest
    {
        /// <summary>
        /// Ctors the null logger.
        /// </summary>
        [Test]
        public void Ctor_NullLogger()
        {
            this.SetupBase();
            var ex = Assert.Throws<ArgumentNullException>(() => new NotificationsHub(this.trackerMock.Object, this.configuration, logger: null));
            Assert.IsTrue(ex.ParamName.Equals("logger", StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void Ctor_NullUserTracker()
        {
            this.SetupBase();
            var ex = Assert.Throws<ArgumentNullException>(() => new NotificationsHub(null, this.configuration,this.loggerMock.Object));
            Assert.IsTrue(ex.ParamName.Equals("userConnectionTracker", StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void Ctor_NullConfiguration()
        {
            this.SetupBase();
            var ex = Assert.Throws<ArgumentNullException>(() => new NotificationsHub(this.trackerMock.Object, null, this.loggerMock.Object));
            Assert.IsTrue(ex.ParamName.Equals("configuration", StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Ctors the valid logger.
        /// </summary>
        [Test]
        public void Ctor_ValidLogger()
        {
            this.SetupBase();
            var hub = new NotificationsHub(this.trackerMock.Object, this.configuration, this.loggerMock.Object);
            Assert.Pass();
        }
    }
}
