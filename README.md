
// Add this to your GlobalUsings.cs
global using System.Xml.Linq;

namespace RiskPortal.Library
{
    public class SecurityServer
    {
        // ... existing code ...

        public async Task<XDocument> GetPermissionedDataAsync(string userName)
        {
            string request = $@"<Requests{(_environmentSwitch is {{Length: > 0}} ? $" environment=""{_environmentSwitch}""" : "")}><GetPermissionedData application_id=""{_applicationId}"" login=""{userName}"" item_id="""" deep.";

            XDocument requestDoc = XDocument.Parse(request);
            return await PostRequestAsync(requestDoc);
        }

        public async Task<XDocument> GetPermissionedDataAsync(string userName, string itemId)
        {
            string request = $@"<Requests{(_environmentSwitch is {{Length: > 0}} ? $" environment=""{_environmentSwitch}""" : "")}><GetPermissionedData application_id=""{_applicationId}"" login=""{userName}"" item_id=""{itemId}"" deep.";

            XDocument requestDoc = XDocument.Parse(request);
            return await PostRequestAsync(requestDoc);
        }

        private async Task<XDocument> PostRequestAsync(XDocument xmlRequest)
        {
            using StringContent content = new StringContent(xmlRequest.ToString(), Encoding.UTF8, "text/xml");
            using HttpResponseMessage response = await _httpClient.PostAsync(_connection, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error {(int)response.StatusCode} with Security Server '{_connection}'.");
            }

            XDocument responseDoc;
            try
            {
                responseDoc = XDocument.Load(await response.Content.ReadAsStreamAsync());
            }
            catch (XmlException e)
            {
                throw new ApplicationException($"Security Server '{_connection}' has returned invalid XML: {e.Message}", e);
            }

            return responseDoc;
        }
    }
}




using YourNamespace.Extensions;

// ...
string connectionString = builder.Configuration.GetConnectionString("SecurityServer");
int applicationId = int.Parse(builder.Configuration["SecurityServer:ApplicationId"]);
string environmentSwitch = builder.Configuration["SecurityServer:EnvironmentSwitch"];

builder.Services
    .AddSecurityServer(connectionString, applicationId, environmentSwitch)
    .AddHttpClient();

// ...




using Microsoft.Extensions.DependencyInjection;
using RiskPortal.Library;
using System;

namespace YourNamespace.Extensions
{
    public static class SecurityServerExtensions
    {
        public static IServiceCollection AddSecurityServer(this IServiceCollection services, string connectionString, int applicationId, string environmentSwitch)
        {
            services.AddSingleton<ISecurityServer>(sp =>
            {
                IHttpClientFactory httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                return new SecurityServer(httpClientFactory, connectionString, applicationId, environmentSwitch);
            });

            return services;
        }
    }
}





namespace RiskPortal.Library
{
    public class SecurityServer : ISecurityServer
    {
        // ... existing code ...

        public async Task<XDocument> GetPermissionedDataAsync(string userName)
        {
            // ... existing code ...
        }

        public async Task<XDocument> GetPermissionedDataAsync(string userName, string itemId)
        {
            // ... existing code ...
        }

        private async Task<XDocument> PostRequestAsync(XDocument xmlRequest)
        {
            // ... existing code ...
        }
    }
}




namespace RiskPortal.Library
{
    public interface ISecurityServer
    {
        Task<XDocument> GetPermissionedDataAsync(string userName);
        Task<XDocument> GetPermissionedDataAsync(string userName, string itemId);
    }
}



using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create the dictionary
        Dictionary<string, Tuple<List<string>, List<string>>> myDictionary = new Dictionary<string, Tuple<List<string>, List<string>>>();
        myDictionary["A"] = Tuple.Create(new List<string> { "TQ", "gh" }, new List<string> { "jh", "jk" });
        myDictionary["B"] = Tuple.Create(new List<string> { "vg", "bk" }, new List<string> { "nm", "vj" });
        myDictionary["C"] = Tuple.Create(new List<string> { "xy" }, new List<string> { "yz" });

        // Filter the dictionary based on a list of keys
        List<string> keys = new List<string> { "A", "B" };
        Dictionary<string, Tuple<List<string>, List<string>>> filteredDictionary = myDictionary
            .Where(entry => keys.Contains(entry.Key))
            .ToDictionary(entry => entry.Key, entry => entry.Value);

        // Print the filtered dictionary contents
        foreach (var entry in filteredDictionary)
        {
            Console.WriteLine($"Key: {entry.Key}");
            Console.WriteLine("List 1:");
            foreach (string item in entry.Value.Item1)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine("List 2:");
            foreach (string item in entry.Value.Item2)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}




public record CsvRow
{
    public string Key { get; init; }
    public string Value1 { get; init; }
    public string Value2 { get; init; }
}



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

class Program
{
    static void Main()
    {
        string csvFilePath = "path/to/your/csvfile.csv";

        Dictionary<string, Tuple<List<string>, List<string>>> myDictionary = new Dictionary<string, Tuple<List<string>, List<string>>>();

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<CsvRow>();

            foreach (var record in records)
            {
                if (myDictionary.ContainsKey(record.Key))
                {
                    myDictionary[record.Key].Item1.Add(record.Value1);
                    myDictionary[record.Key].Item2.Add(record.Value2);
                }
                else
                {
                    myDictionary[record.Key] = Tuple.Create(
                        new List<string> { record.Value1 },
                        new List<string> { record.Value2 }
                    );
                }
            }
        }

        // Print the dictionary contents
        foreach (var entry in myDictionary)
        {
            Console.WriteLine($"Key: {entry.Key}");
            Console.WriteLine("List 1:");
            foreach (string item in entry.Value.Item1)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine("List 2:");
            foreach (string item in entry.Value.Item2)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
