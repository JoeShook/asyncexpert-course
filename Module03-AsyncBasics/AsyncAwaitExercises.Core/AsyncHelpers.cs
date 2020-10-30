using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExercises.Core
{
    public class AsyncHelpers
    {
        private static async Task<string> GetStringWithRetriesInt(HttpClient client, string url, int maxTries = 3,
            CancellationToken token = default)
        {
            // Create a method that will try to get a response from a given `url`, retrying `maxTries` number of times.
            // It should wait one second before the second try, and double the wait time before every successive retry
            // (so pauses before retries will be 1, 2, 4, 8, ... seconds).
            // * `maxTries` must be at least 2
            // * we retry if:
            //    * we get non-successful status code (outside of 200-299 range), or
            //    * HTTP call thrown an exception (like network connectivity or DNS issue)
            // * token should be able to cancel both HTTP call and the retry delay
            // * if all retries fails, the method should throw the exception of the last try
            // HINTS:
            // * `HttpClient.GetStringAsync` does not accept cancellation token (use `GetAsync` instead)
            // * you may use `EnsureSuccessStatusCode()` method

            int retryTimeInSeconds = 1;



            for (int i = 0; i < maxTries; i++)
            {
                try
                {
                    var response = await client.GetAsync(url, token);
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    await Task.Delay(retryTimeInSeconds * 1000, token);
                    retryTimeInSeconds = retryTimeInSeconds * 2;

                    if (i >= maxTries - 1)
                    {
                        throw;
                    }
                }
            }


            return string.Empty;
        }

        public static Task<string> GetStringWithRetries(HttpClient client, string url, int maxTries = 3,
            CancellationToken token = default)
        {
            if (maxTries < 2)
            {
                throw new ArgumentException("Must be at least 2.", nameof(maxTries));
            }

            return GetStringWithRetriesInt(client, url, maxTries, token);
        }
    }
}