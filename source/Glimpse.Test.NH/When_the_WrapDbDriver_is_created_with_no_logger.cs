﻿using System;
using Glimpse.NH.Plumbing.Injectors;
using Glimpse.Test.NH.Core;
using Glimpse.Test.NH.Core.Extensions;
using Moq;
using NUnit.Framework;

namespace Glimpse.Test.NH
{
    [TestFixture]
    public class When_the_WrapDbDriver_is_created_with_no_logger : StaticContextSpecification
    {
        private Action _action;

        protected override void Arrange()
        {
        }

        protected override void Act()
        {
            _action = () => new WrapDbDriver(null, new Mock<INHibernateInfoProvider>().Object, new Mock<IGlimpseProfileDbDriverFactory>().Object, new Mock<IGlimpseProfileDbDriverActivator>().Object);
        }

        [Test]
        public void It_should_not_throw_an_exception()
        {
            _action
                .ShouldThrow<ArgumentNullException>()
                .ShouldHaveParamName("logger");
        }
    }
}