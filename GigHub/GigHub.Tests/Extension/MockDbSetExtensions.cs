﻿using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GigHub.Tests.Extension
{
    public static class MockDbSetExtensions
    {
        //public static void SetSource<T>(this Mock<DbSet<T>> mockSet, IList<T> source) where T : class
        //{
        //    var data = source.AsQueryable();


        //    mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

        //}

        public static void SetSource<T>(this Mock<DbSet<T>> mockSet, IList<T> source) where T : class
        {
            var data = source.AsQueryable();

            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
        }
    }
}