﻿namespace EyeSoft.Core.Test.Mapping
{
    using System;
    using System.Linq;
    using Core.Mapping;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpTestsEx;

    [TestClass]
	public class DomainMapperTest
	{
		[TestMethod]
		public void VerifyAllMappedEntityAreReturned()
		{
			new DomainMapper()
				.Register<CustomerAggregate>()
				.Register<HeadOffice>()
				.Register<Order>()
				.MappedTypes()
				.Count().Should().Be.EqualTo(3);
		}

		[TestMethod]
		public void MapTheSameEntityMoreThanOnceExpectedException()
		{
			Executing
				.This(() =>
					new DomainMapper()
						.Register<CustomerAggregate>()
						.Register<CustomerAggregate>())
				.Should().Throw<ArgumentException>();
		}

		private class CustomerAggregate
		{
		}

		private class HeadOffice
		{
		}

		private class Order
		{
		}
	}
}