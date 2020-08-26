using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Amazon.CognitoIdentity;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Refit;

namespace dotnet
{
    [DynamoDBTable("Customers")]
    public class Customer
    {
        [DynamoDBHashKey]
        public string id { get; set; }
        [DynamoDBRangeKey]
        public string email { get; set; }
    }

    [Headers("x-vtex-api-appKey: vtexappkey-ecoke-VWHVPD\nx-vtex-api-appToken: ----------")]
    public interface IVTEXCustomersApi
    {
        [Get("/api/dataentities/CL/search")]
        Task<IList<Customer>> GetCustomers();
    }

    public class Program
    {
        static IVTEXCustomersApi VTEXCustomersApi = RestService.For<IVTEXCustomersApi>("https://ecoke.vtexcommercestable.com.br/");
        static CognitoAWSCredentials cognitoAWSCredentials = new CognitoAWSCredentials("us-east-2:--------------", Amazon.RegionEndpoint.USEast2);
        static AmazonDynamoDBClient amazonDynamoDBClient = new AmazonDynamoDBClient(cognitoAWSCredentials, Amazon.RegionEndpoint.USEast2);
        static DynamoDBContext dynamoDBContext = new DynamoDBContext(amazonDynamoDBClient);

        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            MakeRequestAsync().Wait();
        }

        static async Task MakeRequestAsync()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var customers = await VTEXCustomersApi.GetCustomers();

            await Task.WhenAll(customers.Select(c => dynamoDBContext.SaveAsync(c)));
            stopWatch.Stop();

            Console.WriteLine($"Time spent: {stopWatch.Elapsed}");
        }
    }
}
