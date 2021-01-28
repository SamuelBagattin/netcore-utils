using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncUtils;
using Xunit;

namespace UnitTests
{
    public class AsyncUtilsTests
    {
        [Fact]
        public async Task BatchWaitAll_should_returnExecutedTasksWithResults()
        {
            // Arrange
            var init = Enumerable.Range(0, 100).Select(Task.FromResult).ToList();
            var expected = Enumerable.Range(0, 100).ToList();
            
            // Act
            var result = await init.BatchWaitAll(10);

            // Assert
            Assert.True(result.SequenceEqual(expected));

        }
    }
}