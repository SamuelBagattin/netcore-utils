using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncUtils
{
    public static class CollectionExtensions
    {
        public static async Task<ICollection<T>> BatchWaitAll<T>(this ICollection<Task<T>> enumerable, int batchSize)
        {
            var splittedTasks = new List<ICollection<Task<T>>>();
            for (var i = 0; i < (float) enumerable.Count / batchSize; i++)
            {
                splittedTasks.Add(enumerable.Skip(i * batchSize).Take(batchSize).ToList());
            }

            var tasksChunks = splittedTasks.Select(async e => await Task.WhenAll(e));

            var completedWebhookReports = new List<T>();
            foreach (var chunk in tasksChunks)
            {
                completedWebhookReports.AddRange(await chunk);
            }

            return completedWebhookReports;
        }
    }
}