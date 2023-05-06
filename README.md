import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-success-page',
  templateUrl: './success-page.component.html',
  styleUrls: ['./success-page.component.css']
})
export class SuccessPageComponent implements OnInit {
  reportNames: string[];
  cob: string;

  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.reportNames = params['reportNames'].split(',');
      this.cob = params['cob'];
    });
  }

  goBack(): void {
    this.router.navigate(['/report-control/run-status/list']);
  }
}



import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

@Component({
  selector: 'app-success-page',
  templateUrl: './success-page.component.html',
  styleUrls: ['./success-page.component.css']
})
export class SuccessPageComponent implements OnInit {
  reportNames: string[];
  cob: string;

  constructor(private route: ActivatedRoute, private location: Location) { }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.reportNames = params['reportNames'].split(',');
      this.cob = params['cob'];
    });
  }

  goBack(): void {
    this.location.back();
  }
}


<div>
  <h1>Successfully Triggered Reports for {{ cob }}</h1>
  <ul>
    <li *ngFor="let reportName of reportNames">{{ reportName }}</li>
  </ul>
  <button (click)="goBack()">Back</button>
</div>


import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-success-page',
  templateUrl: './success-page.component.html',
  styleUrls: ['./success-page.component.css']
})
export class SuccessPageComponent implements OnInit {
  reportNames: string[];
  cob: string;

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.reportNames = params['reportNames'].split(',');
      this.cob = params['cob'];
    });
  }
}



import { SuccessPageComponent } from './success-page/success-page.component';
const routes: Routes = [
  // ...existing routes...
  { path: 'success', component: SuccessPageComponent },
];


ng generate component success-page --module=report-control


ng generate component success-page --module=app --route=success



<div>
  <h1>Successfully Triggered Reports for COB: {{cob}}</h1>
  <ul>
    <li *ngFor="let reportName of reportNames">{{ reportName }}</li>
  </ul>
</div>


import { ActivatedRoute } from '@angular/router';

export class SuccessPageComponent implements OnInit {
  reportNames: string[];
  cob: string;

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.reportNames = params['reportNames'].split(',');
      this.cob = params['cob'];
    });
  }
}

import { Router } from '@angular/router';

constructor(private router: Router, /* other dependencies */) { }

runStoredReport(): void {
  // ...existing code...
  this.reportRunService.runStoredReports(runStoredReportsData).subscribe(
    () => {
      console.log('Stored reports have been run successfully.');
      this.router.navigate(['/success'], { queryParams: { 
        reportNames: runStoredReportsData.reportNames.join(','), 
        cob: runStoredReportsData.cob 
      } });
    },
    (error) => {
      console.error('An error occurred while running the stored reports:', error);
    }
  );
}



using System.Globalization;

public IActionResult RunReports(RunStoredReports runStoredReports)
{
    var dateFormat = "yyyyMMdd";
    var dateTime = DateTime.ParseExact(runStoredReports.Cob, dateFormat, CultureInfo.InvariantCulture);

    var result = InitializeReportRunRepo().RunStoredReport(runStoredReports.ReportNames, dateTime, runStoredReports.QueueName, runStoredReports.Priority, false);

    return Ok();
}


import { ActivatedRoute } from '@angular/router';

export class SuccessPageComponent implements OnInit {
  reportNames: string[];

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.reportNames = params['reportNames'].split(',');
    });
  }
}

import { Router } from '@angular/router';

constructor(private router: Router, /* other dependencies */) { }

runStoredReport(): void {
  // ...existing code...
  this.reportRunService.runStoredReports(runStoredReportsData).subscribe(
    () => {
      console.log('Stored reports have been run successfully.');
      this.router.navigate(['/success'], { queryParams: { reportNames: runStoredReportsData.reportNames.join(',') } });
    },
    (error) => {
      console.error('An error occurred while running the stored reports:', error);
    }
  );
}

import { SuccessPageComponent } from './success-page/success-page.component';

const routes: Routes = [
  // ...your other routes...
  { path: 'success', component: SuccessPageComponent },
];


this.selectedData.selected.map(item => item.reportName);

runStoredReport(): void {
  const runStoredReportsData: RunStoredReports = {
    reportNames: ['Report1', 'Report2'],
    queueName: 'Queue1',
    priority: 1,
    cob: '2023-05-05',
  };

  this.reportRunService.runStoredReports(runStoredReportsData).subscribe(
    () => {
      console.log('Stored reports have been run successfully.');
    },
    (error) => {
      console.error('An error occurred while running the stored reports:', error);
    }
  );
}


import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { RunStoredReports } from './run-stored-reports.model';

@Injectable({
  providedIn: 'root',
})
export class ReportRunService {
  private MARS_URL = 'https://your-backend-api-url.com/api/';

  constructor(private http: HttpClient) {}

  runStoredReports(runStoredReports: RunStoredReports): Observable<void> {
    const url = this.MARS_URL + 'ReportRun/RunStoredReports';
    return this.http
      .post<void>(url, runStoredReports)
      .pipe(catchError((error: HttpErrorResponse) => throwError(error)));
  }

  // Add other methods if needed
}


public async Task<XPathDocument> PostRequestLiteAsync()
{
    return await Task.Run(() => PostRequestLite());
}



// Add global using directives at the top of your file
global using System;
global using System.Net.Http;
global using System.Text;
global using System.Threading.Tasks;
global using System.Xml;
global using System.Xml.XPath;

namespace YourNamespace
{
    public record XmlRequestItem(string Command, string ClientSystemName)
    {
        public Dictionary<string, string> AttributeValueCollection { get; } = new();
    }

    public record XmlRequest
    {
        public List<XmlRequestItem> RequestItems { get; } = new();

        public void AddRequestNode(XmlRequestItem requestItem)
        {
            RequestItems.Add(requestItem);
        }
    }

    public class ReportRunner
    {
        private readonly string _connectionString;
        private readonly string _userName;
        private readonly string _clientSystemName;

        public ReportRunner(string connectionString, string userName, string clientSystemName)
        {
            _connectionString = connectionString;
            _userName = userName;
            _clientSystemName = clientSystemName;
        }

        public async Task<XPathDocument> RunStoredReportAsync(string[] reportNames, DateTime cobDate, string queue, int priority, bool synchronous)
        {
            var request = new XmlRequest();
            string cobDateValue = HtmlUtility.StandardCobDate(cobDate);

            foreach (string name in reportNames)
            {
                var requestItem = new XmlRequestItem("RunStoredReport", _clientSystemName)
                {
                    AttributeValueCollection =
                    {
                        ["name"] = name,
                        ["date"] = cobDateValue,
                        ["mode"] = synchronous ? "synchronous" : "asynchronous",
                        ["queue_name"] = queue,
                        ["priority"] = priority.ToString()
                    }
                };

                request.AddRequestNode(requestItem);
            }

            return await PostRequestAsync(request);
        }

        private async Task<XPathDocument> PostRequestAsync(XmlRequest request)
        {
            using var httpClient = new HttpClient();
            // Set up request headers or other configurations here, if needed.

            // Serialize the XmlRequest object into an XML string
            string requestBody = SerializeRequestToXml(request);

            var content = new StringContent(requestBody, Encoding.UTF8, "application/xml");
            var response = await httpClient.PostAsync(_connectionString, content);

            if (!response.IsSuccessStatusCode)
            {
                // Handle the error response here, if needed.
                throw new HttpRequestException($"Request failed with status code: {response.StatusCode}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            return new XPathDocument(new StringReader(responseContent));
        }

        private string SerializeRequestToXml(XmlRequest request)
        {
            // Implement the serialization logic here based on your XmlRequest object structure.
            // You can use XmlDocument, XDocument, or other XML libraries to create an XML string representation of the request object.
            throw new NotImplementedException();
        }
    }
}





<div class="container">
  <div class="row">
    <div class="col">
      <label>{{ labelForQueues }}:</label>
      <app-dropdowns
        [isVisible]="showDropdowns"
        [options]="availableReportQueueOptions"
        [selectedValue]="defaultValueforQueue"
        (change)="onDropdownSelectionChanged($event)"
      ></app-dropdowns>
    </div>
    <div class="col">
      <label>{{ labelForPriorities }}:</label>
      <app-dropdowns
        [isVisible]="showDropdowns"
        [selectedValue]="defaultvalueforPriority"
        [options]="priorityOptions"
        (change)="onDropdownSelectionChanged($event)"
      ></app-dropdowns>
    </div>
    <div class="col d-flex justify-content-end">
      <div class="btn-group">
        <button
          type="button"
          class="btn btn-secondary"
          (click)="form.reset(); inValidReportName = false"
        >
          Clear
        </button>
        <button
          type="button"
          class="btn btn-secondary"
          (click)="deleteSearchCache()"
        >
          Delete Saved Search
        </button>
      </div>
      <button
        type="button"
        class="btn btn-primary ms-3"
        (click)="toggleDropdowns()"
        [disabled]="loadSpinnerService.loading$ | async"
      >
        <span
          *ngIf="loadSpinnerService.loading$ | async"
          class="spinner-border spinner-border-sm me-2"
          role="status"
          aria-hidden="true"
        ></span>
        Search
      </button>
    </div>
  </div>
</div>



<div *ngIf="isVisible">
  <select class="form-select" (change)="onSelectionChange($event)">
    <option value=""></option>
    <option *ngFor="let option of options" [value]="option.value" [selected]="option.value === selectedValue">
      {{ option.displayText }}
    </option>
  </select>
</div>

import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-dropdowns',
  templateUrl: './dropdowns.component.html',
  styleUrls: ['./dropdowns.component.css']
})
export class DropdownsComponent {
  @Input() options: { displayText: string; value: string }[] = [];
  @Input() label: string = 'Queues:';
  @Input() selectedValue: string;
  @Input() isVisible: boolean = false;
  @Output() selectionChanged = new EventEmitter<any>();

  constructor() { }

  onSelectionChange(event: any): void {
    this.selectionChanged.emit(event.target.value);
  }
}

<app-dropdowns
  [options]="availableReportQueueOptions"
  [selectedValue]="defaultvalueforPriority"
  (change)="onDropdownSelectionChanged($event)"
  [isVisible]="showDropdowns"
></app-dropdowns>

<app-dropdowns
  [label]="labelForPriorities"
  [selectedValue]="defaultValueforQueue"
  [options]="priorityOptions"
  (change)="onDropdownSelectionChanged($event)"
  [isVisible]="showDropdowns"
></app-dropdowns>


import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-dropdowns',
  templateUrl: './dropdowns.component.html',
  styleUrls: ['./dropdowns.component.css']
})
export class DropdownsComponent implements OnInit {
  @Input() options: { displayText: string; value: string }[] = [];
  @Input() label: string = 'Queues:';
  @Input() selectedOption: string;
  @Output() selectionChanged = new EventEmitter<any>();

  constructor() { }

  ngOnInit(): void {
    if (this.options.length > 0 && !this.selectedOption) {
      this.selectedOption = this.options[0].value;
    }
  }

  onSelectionChange(event: any): void {
    this.selectionChanged.emit(event.target.value);
  }
}


<select class="form-select" (change)="onSelectionChange($event)">
  <option value=""></option>
  <option *ngFor="let option of options" [value]="option.value" [selected]="option.value === selectedOption">
    {{ option.displayText }}
  </option>
</select>



import { finalize } from 'rxjs/operators';


getReportQueues() {
  this.mnetReportControlService.getReportQueues()
    .pipe(
      finalize(() => {
        // This code will run when the observable completes
        if (this.availableReportQueueOptions.length > 0) {
          this.defaultValueforQueue = this.availableReportQueueOptions[0].displayText;
        } else {
          // Handle the case when availableReportQueueOptions is empty, if necessary
        }
      })
    )
    .subscribe(result => {
      this.availableReportQueueOptions = result.map((item: string) => {
        return { displayText: item, value: item };
      });
    });
}



import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-dropdowns',
  templateUrl: './dropdowns.component.html',
  styleUrls: ['./dropdowns.component.css']
})
export class DropdownsComponent implements OnInit {
  @Input() options: any[] = ['Option 1', 'Option 2', 'Option 3'];
  @Output() selectionChanged = new EventEmitter<any>();

  constructor() { }

  ngOnInit(): void { }

  onSelectionChange(event: any): void {
    this.selectionChanged.emit(event.value);
  }
}



<mat-select (selectionChange)="onSelectionChange($event)">
  <mat-option *ngFor="let option of options" [value]="option">
    {{ option }}
  </mat-option>
</mat-select>


<app-dropdowns [options]="myOptions" (selectionChanged)="onDropdownSelectionChanged($event)"></app-dropdowns>


import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search-run-status',
  templateUrl: './search-run-status.component.html',
  styleUrls: ['./search-run-status.component.css']
})
export class SearchRunStatusComponent implements OnInit {
  myOptions: any[] = ['Option A', 'Option B', 'Option C'];

  constructor() { }

  ngOnInit(): void { }

  onDropdownSelectionChanged(selectedOption: any): void {
    console.log('Selected option:', selectedOption);
    // Handle the selection change event here
  }
}




// Add this to your GlobalUsings.cs
global using System.Xml.Linq;

namespace RiskPortal.Library
{
    public class SecurityServer
    {
        // ... existing code ...

        public async Task<XDocument> GetPermissionedDataAsync(string userName)
        {
            string request = $@"<Requests{(!string.IsNullOrEmpty(_environmentSwitch) ? $@" environment=""{_environmentSwitch}""" : "")}><GetPermissionedData application_id=""{_applicationId}"" login=""{userName}"" item_id="""" deep="" />";
            
            XDocument requestDoc = XDocument.Parse(request);
            return await PostRequestAsync(requestDoc);
        }

        public async Task<XDocument> GetPermissionedDataAsync(string userName, string itemId)
        {
            string request = $@"<Requests{(!string.IsNullOrEmpty(_environmentSwitch) ? $@" environment=""{_environmentSwitch}""" : "")}><GetPermissionedData application_id=""{_applicationId}"" login=""{userName}"" item_id=""{itemId}"" deep="" />";
            
            XDocument requestDoc = XDocument.Parse(request);
            return await PostRequestAsync(requestDoc);
        }

        // ... existing code ...
    }
}






// Add this to your GlobalUsings.cs
global using System.Xml.Linq;

namespace RiskPortal.Library
{
    public class SecurityServer
    {
        // ... existing code ...

        public async Task<XDocument> GetPermissionedDataAsync(string userName)
        {
            string request = $@"<Requests{(_environmentSwitch.Length > 0 ? $" environment=""{_environmentSwitch}""" : "")}><GetPermissionedData application_id=""{_applicationId}"" login=""{userName}"" item_id="""" deep.";

            XDocument requestDoc = XDocument.Parse(request);
            return await PostRequestAsync(requestDoc);
        }

        public async Task<XDocument> GetPermissionedDataAsync(string userName, string itemId)
        {
            string request = $@"<Requests{(_environmentSwitch.Length > 0 ? $" environment=""{_environmentSwitch}""" : "")}><GetPermissionedData application_id=""{_applicationId}"" login=""{userName}"" item_id=""{itemId}"" deep.";

            XDocument requestDoc = XDocument.Parse(request);
            return await PostRequestAsync(requestDoc);
        }

        private async Task<XDocument> PostRequestAsync(XDocument xmlRequest)
        {
            using StringContent content = new(xmlRequest.ToString(), Encoding.UTF8, "text/xml");
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
