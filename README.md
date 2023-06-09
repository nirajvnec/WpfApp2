
import { AfterViewInit, Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-my-chart',
  template: '<canvas #myChartCanvas></canvas>',
})
export class MyChartComponent implements AfterViewInit {
  @ViewChild('myChartCanvas', { static: true })
  private myChartCanvas!: ElementRef<HTMLCanvasElement>;

  private myChart: Chart | null = null;

  ngAfterViewInit() {
    const ctx = this.myChartCanvas.nativeElement.getContext('2d');

    this.myChart = new Chart(ctx, {
      type: 'bar',
      data: this.chartData,
      options: {
        onClick: (event, elements) => {
          // Your custom logic here
          console.log('Bar chart clicked!');
        },
      },
    });
  }
}




const chartData = {
  labels: [],
  datasets: [] as ChartDataSet[]
};

const sourceData = this.data[1]; // Assuming this.data[1] is an array of objects

for (const dataObj of sourceData) {
  const chartDataSet = new ChartDataSet();
  Object.assign(chartDataSet, dataObj);
  chartData.datasets.push(chartDataSet);
}

console.log(chartData);


const chartData = {
  labels: [],
  datasets: [] as ChartDataSet[]
};

const sourceData = this.data[1]; // Assuming this.data[1] has the desired data

// Assuming you want to create 140 ChartDataSet objects
const numOfDatasets = 140;

for (let i = 0; i < numOfDatasets; i++) {
  const chartDataSet = new ChartDataSet();
  Object.assign(chartDataSet, sourceData);
  chartData.datasets.push(chartDataSet);
}

console.log(chartData);


const chartData = {
  labels: [],
  datasets: [] as ChartDataSet[]
};

// Assuming this.data is an array and has at least two elements
if (this.data.length > 1) {
  const sourceData = this.data[1]; // Assuming this.data[1] has the desired data

  const chartDataSet = new ChartDataSet();
  Object.assign(chartDataSet, sourceData);

  chartData.datasets.push(chartDataSet);
}

console.log(chartData);



const chartData = {
  labels: data1.labels,
  datasets: [] as ChartDataSet[]
};

// Assuming data1.datasets is an array
for (const datasetData of data1.datasets) {
  const chartDataSet = new ChartDataSet();
  Object.assign(chartDataSet, datasetData);
  chartData.datasets.push(chartDataSet);
}

console.log(chartData);



const chartData = {
  datasets: [] as ChartDataSet[]
};

const sourceData = this.data[1]; // Assuming this.data is an array

// Create a new instance of ChartDataSet
const chartDataSet = new ChartDataSet();

// Copy the properties from sourceData to chartDataSet
Object.assign(chartDataSet, sourceData);

// Add chartDataSet to the datasets array
chartData.datasets.push(chartDataSet);

console.log(chartData);



const sourceData = this.data[1]; // Assuming this.data is an array
const chartDataSet = new ChartDataSet();

// Using object spread syntax
const copiedData = { ...sourceData };
Object.assign(chartDataSet, copiedData);

// Using Object.assign()
Object.assign(chartDataSet, sourceData);

console.log(chartDataSet);



function hasNullOrUndefinedOrEmptyProperties(obj: any): boolean {
  for (const key in obj) {
    if (obj.hasOwnProperty(key)) {
      const value = obj[key];
      
      if (value === null || value === undefined || value === '') {
        return true;
      }
    }
  }
  
  return false;
}




public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, IEnumerable<T> data) where T : class
{
    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

    int row = 2;
    worksheet.WriteColumnNames<T>();

    foreach (var item in data)
    {
        PropertyInfo[] properties = typeof(T).GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            var value = property.GetValue(item);
            worksheet.Cells[row, column].Value = value;
            column++;
        }

        row++;
    }
}



interface MyObject {
  id: number;
  name: string;
}

const array: MyObject[] = [
  { id: 1, name: 'Object 1' },
  { id: 2, name: 'Object 2' },
  { id: 3, name: 'Object 3' },
];

function checkPropertiesMatch(array: MyObject[], prop1: number, prop2: string): boolean {
  for (const item of array) {
    if (item.id === prop1 && item.name === prop2) {
      return true;
    }
  }
  return false;
}

console.log(checkPropertiesMatch(array, 2, 'Object 2'));  // true
console.log(checkPropertiesMatch(array, 4, 'Object 4'));  // false


interface Employee {
  id: number;
  name: string;
}

const lstEmp1: Employee[] = [
  { id: 1, name: 'Employee 1A' },
  { id: 2, name: 'Employee 1B' },
  { id: 3, name: 'Employee 1C' },
];

const lstEmp2: Employee[] = [
  { id: 4, name: 'Employee 2A' },
  { id: 5, name: 'Employee 2B' },
  { id: 6, name: 'Employee 2C' },
];

const listOfLists: Employee[][] = [
  [...lstEmp1],
  [...lstEmp2],
];

console.log(listOfLists);






interface Employee {
  id: number;
  name: string;
}

const lstEmp1: Employee[] = [
  { id: 1, name: 'Employee 1A' },
  { id: 2, name: 'Employee 1B' },
  { id: 3, name: 'Employee 1C' },
];

const lstEmp2: Employee[] = [
  { id: 4, name: 'Employee 2A' },
  { id: 5, name: 'Employee 2B' },
  { id: 6, name: 'Employee 2C' },
];

const listOfLists: Employee[][] = [];

listOfLists.push(lstEmp1);
listOfLists.push(lstEmp2);

console.log(listOfLists);


interface MyObject {
  id: number;
  name: string;
}

const array1: MyObject[] = [
  { id: 1, name: 'Object 1A' },
  { id: 2, name: 'Object 1B' },
  { id: 3, name: 'Object 1C' },
];

const array2: MyObject[] = [
  { id: 1, name: 'Object 2A' },
  { id: 2, name: 'Object 2B' },
  { id: 3, name: 'Object 2C' },
];

const combinedArray: MyObject[] = array1.map((item1, index) => ({
  ...item1,
  ...array2[index],
}));

console.log(combinedArray);




const projectionPoints = resultSets.flatMap((x) => x)
  .map((x) => x.ProjectionPoint)
  .filter((value, index, self) => self.indexOf(value) === index)
  .sort();

const legalEntities = resultSets.flatMap((x) => x)
  .map((x) => x.UnitIdentifier)
  .filter((value, index, self) => self.indexOf(value) === index)
  .sort();

const capitalComponents = resultSets.flatMap((x) => x)
  .map((x) => x.CapitalComponent1)
  .filter((value, index, self) => self.indexOf(value) === index)
  .sort();



interface MyObject {
  id: number;
  name: string;
}

const array1: MyObject[] = [
  { id: 1, name: 'Object 1A' },
  { id: 2, name: 'Object 1B' },
  { id: 3, name: 'Object 1C' },
];

const array2: MyObject[] = [
  { id: 1, name: 'Object 2A' },
  { id: 2, name: 'Object 2B' },
  { id: 3, name: 'Object 2C' },
];

const combinedArray: MyObject[][] = array1.map((item1, index) => [item1, array2[index]]);

console.log(combinedArray);



interface Object1 {
  id: number;
  name: string;
}

interface Object2 {
  id: number;
  value: string;
}

const array1: Object1[] = [
  { id: 1, name: 'Object 1A' },
  { id: 2, name: 'Object 1B' },
  { id: 3, name: 'Object 1C' },
];

const array2: Object2[] = [
  { id: 1, value: 'Value 1A' },
  { id: 2, value: 'Value 1B' },
  { id: 3, value: 'Value 1C' },
];

const combinedArray: (Object1 & Object2)[][] = array1.map((item1) =>
  array2
    .filter((item2) => item2.id === item1.id)
    .map((item2) => ({ ...item1, ...item2 }))
);

console.log(combinedArray);



const data = [
  { name: 'John Doe', age: 25, city: 'New York' },
  { name: 'Jane Smith', age: 30, city: 'London' },
  // Add more objects as needed
];

const csvData = convertToCSV(data);
const blob = new Blob([csvData], { type: 'text/csv;charset=utf-8' });
saveAs(blob, 'data.csv');




function convertToCSV(obj) {
  const csv = [];
  const keys = Object.keys(obj[0]);

  // Add the column headers
  csv.push(keys.join(','));

  // Add the data rows
  for (const row of obj) {
    const values = keys.map(key => row[key]);
    csv.push(values.join(','));
  }

  return csv.join('\n');
}


npm install exceljs
npm install exceljs --save-dev



import * as ExcelJS from 'exceljs';

class ExcelUtility {
  public static writeColumnNames<T>(worksheet: ExcelJS.Worksheet): void {
    const propertyNames = Object.keys(new T());

    let column = 1;
    for (const propertyName of propertyNames) {
      worksheet.getCell(1, column).value = propertyName;
      column++;
    }
  }

  public static exportToExcel<T>(
    data: T[][],
    sheetName: string,
    filePath: string
  ): Promise<void> {
    const workbook = new ExcelJS.Workbook();
    const worksheet = workbook.addWorksheet(sheetName);

    let row = 2;
    for (const rowList of data) {
      ExcelUtility.writeColumnNames<T>(worksheet);

      let column = 1;
      for (const item of rowList) {
        const propertyNames = Object.keys(item);

        for (const propertyName of propertyNames) {
          worksheet.getCell(row, column).value = item[propertyName];
          column++;
        }
      }

      row++;
    }

    return workbook.xlsx.writeFile(filePath);
  }
}



using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

public static class ExcelUtility
{
    public static void WriteColumnNames<T>(this ExcelWorksheet worksheet) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            worksheet.Cells[1, column].Value = columnName;
            column++;
        }
    }

    public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, IEnumerable<IEnumerable<T>> data) where T : class
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

        int row = 2;
        foreach (var rowList in data)
        {
            worksheet.WriteColumnNames<T>();

            foreach (var item in rowList)
            {
                PropertyInfo[] properties = typeof(T).GetProperties();

                int column = 1;
                foreach (PropertyInfo property in properties)
                {
                    var value = property.GetValue(item);
                    worksheet.Cells[row, column].Value = value;
                    column++;
                }

                row++;
            }
        }
    }
}





using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public static class ExcelUtility
{
    public static void WriteColumnNames<T>(this ExcelWorksheet worksheet) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            worksheet.Cells[1, column].Value = columnName;
            column++;
        }
    }

    public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, IEnumerable<IEnumerable<T>> data) where T : class
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

        int row = 2;
        foreach (var rowList in data)
        {
            worksheet.WriteColumnNames<T>();

            int column = 1;
            foreach (var item in rowList)
            {
                PropertyInfo[] properties = typeof(T).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    var value = property.GetValue(item);
                    worksheet.Cells[row, column].Value = value;
                    column++;
                }
            }

            row++;
        }
    }
}




using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public static class ExcelUtility
{
    public static void WriteColumnNames<T>(this ExcelWorksheet worksheet) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            worksheet.Cells[1, column].Value = columnName;
            column++;
        }
    }

    public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, IEnumerable<IEnumerable<T>> data) where T : class
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

        if (data.Any())
        {
            int row = 2;
            foreach (var rowList in data)
            {
                worksheet.WriteColumnNames<T>();

                int column = 1;
                foreach (var item in rowList)
                {
                    PropertyInfo[] properties = typeof(T).GetProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        var value = property.GetValue(item);
                        worksheet.Cells[row, column].Value = value;
                        column++;
                    }
                }

                row++;
            }
        }
    }
}




using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

public static class ExcelUtility
{
    public static void WriteColumnNames<T>(this ExcelWorksheet worksheet) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            worksheet.Cells[1, column].Value = columnName;
            column++;
        }
    }

    public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, IEnumerable<IEnumerable<T>> data) where T : class
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

        if (data.Any())
        {
            int row = 1;
            foreach (var rowList in data)
            {
                worksheet.WriteColumnNames<T>();

                int column = 1;
                foreach (var item in rowList)
                {
                    PropertyInfo[] properties = typeof(T).GetProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        var value = property.GetValue(item);
                        worksheet.Cells[row + 1, column].Value = value;
                        column++;
                    }
                }

                row++;
            }
        }
    }
}



using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public static class ExcelUtility
{
    public static void WriteColumnNames<T>(this ExcelWorksheet worksheet) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            worksheet.Cells[1, column].Value = columnName;
            column++;
        }
    }

    public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, List<List<T>> data) where T : class
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

        if (data.Count > 0)
        {
            int row = 1;
            foreach (var rowList in data)
            {
                worksheet.WriteColumnNames<T>();

                int column = 1;
                foreach (var item in rowList)
                {
                    PropertyInfo[] properties = typeof(T).GetProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        var value = property.GetValue(item);
                        worksheet.Cells[row + 1, column].Value = value;
                        column++;
                    }
                }

                row++;
            }
        }
    }
}



using (ExcelPackage excelPackage = new ExcelPackage())
{
    List<MyData> dataList = new List<MyData>
    {
        new MyData { Name = "John Doe", Age = 25 },
        new MyData { Name = "Jane Smith", Age = 30 },
        // Add more data as needed
    };

    excelPackage.ExportToExcel("Sheet1", dataList);

    FileInfo excelFile = new FileInfo("output.xlsx");
    excelPackage.SaveAs(excelFile);
}



using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public static class ExcelUtility
{
    public static void WriteColumnNames<T>(this ExcelWorksheet worksheet) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            worksheet.Cells[1, column].Value = columnName;
            column++;
        }
    }

    public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, List<T> data) where T : class
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

        worksheet.WriteColumnNames<T>();

        int row = 2;
        foreach (var item in data)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            int column = 1;
            foreach (PropertyInfo property in properties)
            {
                var value = property.GetValue(item);
                worksheet.Cells[row, column].Value = value;
                column++;
            }

            row++;
        }
    }
}




using (ExcelPackage excelPackage = new ExcelPackage())
{
    excelPackage.ExportToExcel<MyData>("Sheet1", dataList);

    FileInfo excelFile = new FileInfo("output.xlsx");
    excelPackage.SaveAs(excelFile);
}



using OfficeOpenXml;
using System;
using System.IO;
using System.Reflection;

public static class ExcelUtility
{
    public static void WriteColumnNames<T>(this ExcelWorksheet worksheet) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        int column = 1;
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            worksheet.Cells[1, column].Value = columnName;
            column++;
        }
    }

    public static void ExportToExcel<T>(this ExcelPackage excelPackage, string sheetName, IEnumerable<T> data)
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

        worksheet.WriteColumnNames<T>();

        int row = 2;
        foreach (var item in data)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            int column = 1;
            foreach (PropertyInfo property in properties)
            {
                var value = property.GetValue(item);
                worksheet.Cells[row, column].Value = value;
                column++;
            }

            row++;
        }
    }
}



using OfficeOpenXml;
using System;
using System.IO;
using System.Reflection;

public class MyData
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public static void WriteColumnNames<T>(ExcelWorksheet worksheet) where T : class
{
    Type type = typeof(T);
    PropertyInfo[] properties = type.GetProperties();

    int column = 1;
    foreach (PropertyInfo property in properties)
    {
        string columnName = property.Name;
        worksheet.Cells[1, column].Value = columnName;
        column++;
    }
}

public static void Main()
{
    using (ExcelPackage excelPackage = new ExcelPackage())
    {
        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

        WriteColumnNames<MyData>(worksheet);

        FileInfo excelFile = new FileInfo("output.xlsx");
        excelPackage.SaveAs(excelFile);
    }
}




if (resultSet.some(x => x.UnitIdentifier === le && x.ProjectionPoint === proj && x.CapitalComponent === cc)) {
  const result = resultSet.filter(x => x.UnitIdentifier === le && x.ProjectionPoint === proj && x.CapitalComponent === cc);
  ds.data.push(result.reduce((sum, x) => sum + parseInt(x.ResultValue), 0));
}




const array: string[] = ['foo', 'bar', '', 'baz', null];

const hasNullOrEmpty = array.some(item => item === null || item === '');

if (hasNullOrEmpty) {
  console.log("The array contains null or empty string values.");
} else {
  console.log("The array does not contain null or empty string values.");
}



if (this.filteredData && this.filteredData.unitIdentifiers) {
  this.legalEntities = this.filteredData.unitIdentifiers
    .filter(this.distinct)
    .sort();
}


var ctx = document.getElementById('myChart').getContext('2d');
var chart = new Chart(ctx, {
    // The type of chart we want to create
    type: 'line',

    // The data for our dataset
    data: {
        labels: ["January", "February", "March", "April", "May", "June", "July"],
        datasets: [{
            label: "My First dataset",
            backgroundColor: 'rgb(255, 99, 132)',
            borderColor: 'rgb(255, 99, 132)',
            data: [0, 10, 5, 2, 20, 30, 45],
            pointStyle: "line",
        },
        {
            label: "My Second dataset",
            backgroundColor: 'rgb(0, 99, 132)',
            borderColor: 'rgb(0, 99, 132)',
            data: [40, 10, 35, 32, 20, 30, 45],
            pointStyle: "rect",
        },
        {
            label: "My Third dataset",
            backgroundColor: 'rgb(0, 0, 132)',
            borderColor: 'rgb(0, 0, 132)',
            data: [29, 10, 25, 22, 20, 30, 45],
        }]
    },

    // Configuration options go here
    options: {
        legendCallback: function(chart) {
            // Return the HTML string here.
            var text = [];
            text.push('<ul class="list-inline">');
            for (var i = 0; i < chart.data.datasets.length; i++) {
                text.push('<li class="text-white list-inline-item btn" style="background: '+ chart.data.datasets[i].backgroundColor +' ">');
                text.push( chart.data.datasets[i].label );
                text.push('</li>');
            }
            text.push('</ul>');
            return text.join("");

        },
        legend: {
            display: false,
            position: "left",
            reverse: false,
            //onClick: changeFontColor,
            labels: {
                boxWidth: 5,
                fontSize: 15,
                fontStyle: "bold",
                fontColor: "#000",
                //fontFamily: "New Times Roman",
                padding: 20,
                usePointStyle: true,
            }
        }
    }
});

function changeFontColor() {
    chart.options.legend.labels.fontColor = 'red';
};

document.getElementById("chartjs-legend").innerHTML = chart.generateLegend();


function GetMultipleResultSetsForChart(
  legalEntity: string,
  capitalComponent: string,
  projectionPoint: string,
  rrpSession: string,
  spot: boolean = false
): RrpResultSetModel[][] {
  const filteredResultSets: RrpResultSetModel[][] = [];
  filteredResultSets.push(GetResultSetsForChart(legalEntity, capitalComponent, projectionPoint, rrpSession, spot));
  filteredResultSets.push(GetResultSetsForChart(legalEntity, capitalComponent, projectionPoint, rrpSession + "-2", spot));
  return filteredResultSets;
}


interface RRPResultSet {
  ValuationType: string;
  UnitIdentifier: string;
  InstanceIdentifier: string;
}

function getInstances(resultSets: RRPResultSet[]): RRPResultSet[] {
  const filteredResultSets = resultSets
    .reduce((groups: { [key: string]: RRPResultSet }, resultSet: RRPResultSet) => {
      const key = `${resultSet.ValuationType}_${resultSet.UnitIdentifier}`;
      if (!groups[key] || resultSet.InstanceIdentifier < groups[key].InstanceIdentifier) {
        groups[key] = resultSet;
      }
      return groups;
    }, {});

  const sortedResultSets = Object.values(filteredResultSets).sort((a, b) => {
    if (a.UnitIdentifier !== b.UnitIdentifier) {
      return a.UnitIdentifier.localeCompare(b.UnitIdentifier);
    }
    return a.ValuationType.localeCompare(b.ValuationType);
  });

  return sortedResultSets;
}

// Example usage:
const resultSets: RRPResultSet[] = [
  {
    ValuationType: "Val1",
    UnitIdentifier: "Unit1",
    InstanceIdentifier: "Inst1",
  },
  {
    ValuationType: "Val2",
    UnitIdentifier: "Unit1",
    InstanceIdentifier: "Inst2",
  },
  {
    ValuationType: "Val1",
    UnitIdentifier: "Unit2",
    InstanceIdentifier: "Inst3",
  },
];

const instances = getInstances(resultSets);
console.log(instances);









interface RRPResultSet {
  ValuationType: string;
  UnitIdentifier: string;
  InstanceIdentifier: string;
}

function getInstances(resultSets: RRPResultSet[]): RRPResultSet[] {
  const filteredResultSets = resultSets
    .reduce((groups: { [key: string]: RRPResultSet }, resultSet: RRPResultSet) => {
      const key = `${resultSet.ValuationType}_${resultSet.UnitIdentifier}`;
      if (!groups[key] || resultSet.InstanceIdentifier < groups[key].InstanceIdentifier) {
        groups[key] = resultSet;
      }
      return groups;
    }, {})
    .values();

  const sortedResultSets = [...filteredResultSets].sort((a, b) => {
    if (a.UnitIdentifier !== b.UnitIdentifier) {
      return a.UnitIdentifier.localeCompare(b.UnitIdentifier);
    }
    return a.ValuationType.localeCompare(b.ValuationType);
  });

  return sortedResultSets;
}



function getInstances(results: any[]): any[] {
  // Placeholder implementation
  // Assuming each result object has properties: UnitIdentifier, ValuationType, InstanceIdentifier
  const instances: any[] = results.map((result) => ({
    UnitIdentifier: result.UnitIdentifier,
    ValuationType: result.ValuationType,
    InstanceIdentifier: result.InstanceIdentifier,
  }));

  return instances;
}


GetMultipleJopMultipleLEBarChart(
  legalEntity: string[],
  capitalComponent: string[],
  projectionPoint: string[],
  rrpSession: string
): object[] {
  const cdLabel: string[] = [];
  const chartDataSets: ChartDataset[] = [];
  const chartLegend: string[][] = [];
  const spotChartLegend: string[][] = [];
  const chartData: object[] = [];
  let i: number;

  try {
    const resultSets: RrpResultSetModel[] = GetMultipleResultSetsForChart(
      legalEntity,
      capitalComponent,
      projectionPoint,
      rrpSession
    );

    if (resultSets.length === 0) {
      return null;
    }

    const projectionPoints = [
      ...new Set(resultSets.map((x) => x.projectionPoint)),
    ].sort();
    const legalEntities = [
      ...new Set(resultSets.map((x) => x.unitIdentifier)),
    ].sort();
    const capitalComponents = [
      ...new Set(resultSets.map((x) => x.capitalComponent)),
    ].sort();

    chartData.push(cdLabel);
    addLegendDataRow('', '', cdLabel, chartLegend);

    for (const cc of capitalComponents) {
      for (const proj of projectionPoints) {
        i = 1;
        for (const resultSet of resultSets) {
          const jop = `JoP ${i}`;
          const ds = new ChartDataset();
          ds.label = `${jop} — ${proj} — ${cc}`;
          ds.type = 'bar';
          ds.stack = `${jop} — ${proj}`;

          for (const le of legalEntities) {
            if (
              resultSet.unitIdentifier === le &&
              resultSet.projectionPoint === proj &&
              resultSet.capitalComponent === cc
            ) {
              // Process result
            } else {
              ds.data.push(0);
            }
          }

          chartDataSets.push(ds);
          addLegendDataRow(
            ds.stack,
            cc,
            ds.data.map((x) => x.toString()),
            chartLegend
          );
          i++;
        }
      }
    }

    assignColors(chartDataSets);
    chartData.push(chartDataSets);
    chartData.push(chartLegend);

    const spotResultSets: RrpResultSetModel[] = GetMultipleResultSetsForChart(
      legalEntity,
      capitalComponent,
      projectionPoint,
      rrpSession,
      true
    );

    const spotProjectionPoints = [
      ...new Set(spotResultSets.map((x) => x.projectionPoint)),
    ].sort();
    const spotLegalEntities = [
      ...new Set(spotResultSets.map((x) => x.unitIdentifier)),
    ].sort();

    addLegendDataRow('', '', spotLegalEntities, spotChartLegend);
    i = 1;

    for (const resultSet of spotResultSets) {
      const jop = `JoP ${i}`;
      for (const prod of spotProjectionPoints) {
        for (const cc of capitalComponents) {
          const data: number[] = [];
          for (const le of spotLegalEntities) {
            if (
              resultSet.unitIdentifier === le &&
              resultSet.projectionPoint === proj &&
              resultSet.capitalComponent === cc
            ) {
              data.push(parseInt(resultSet.resultValue));
            } else {
              data.push(0);
            }
          }
          addLegendDataRow(
            `${jop} ${proj}`,
            cc,
            data.map((x) => x.toString()),
            spotChartLegend
          );
          i++;
          chartData.push(spotChartLegend);
          for (const results of resultSets) {
            const instances = getInstances(results).map((x) => ({
              UnitIdentifier: x.unitIdentifier,
              ValuationType: x.valuationType,
              InstanceIdentifier: x.instanceIdentifier,
            }));
            chartData.push(instances);
          }
        }
      }
    }
  } catch (error) {
    return chartData;
  }

  return chartData;
}

function addLegendDataRow(column1: string, column2: string, data: string[], chartLegend: string[][]): void {
  const row: string[] = [column1, column2];
  row.push(...data);
  chartLegend.push(row);
}








GetMultipleJopMultipleLEBarChart(
  legalEntity: string[],
  capitalComponent: string[],
  projectionPoint: string[],
  rrpSession: string
): object[] {
  const cdLabel: string[] = [];
  const chartDataSets: ChartDataset[] = [];
  const chartLegend: string[][] = [];
  const spotChartLegend: string[][] = [];
  const chartData: object[] = [];
  let i: number;

  try {
    const resultSets: RrpResultSetModel[][] = GetMultipleResultSetsForChart(
      legalEntity,
      capitalComponent,
      projectionPoint,
      rrpSession
    );

    if (resultSets.length === 0) {
      return null;
    }

    const projectionPoints = [
      ...new Set(resultSets.flatMap((x) => x).map((x) => x.projectionPoint)),
    ].sort();
    const legalEntities = [
      ...new Set(resultSets.flatMap((x) => x).map((x) => x.unitIdentifier)),
    ].sort();
    const capitalComponents = [
      ...new Set(resultSets.flatMap((x) => x).map((x) => x.capitalComponent)),
    ].sort();

    chartData.push(cdLabel);
    AddLegendDataRow('', '', cdLabel, chartLegend);

    for (const cc of capitalComponents) {
      for (const proj of projectionPoints) {
        i = 1;
        for (const resultSet of resultSets) {
          const jop = `JoP ${i}`;
          const ds = new ChartDataset();
          ds.label = `${jop} — ${proj} — ${cc}`;
          ds.type = 'bar';
          ds.stack = `${jop} — ${proj}`;

          for (const le of legalEntities) {
            if (
              resultSet.some(
                (x) =>
                  x.unitIdentifier === le &&
                  x.projectionPoint === proj &&
                  x.capitalComponent === cc
              )
            ) {
              const result = resultSet.filter(
                (x) =>
                  x.unitIdentifier === le &&
                  x.projectionPoint === proj &&
                  x.capitalComponent === cc
              );
              // Process result
            } else {
              ds.data.push(0);
            }
          }

          chartDataSets.push(ds);
          AddLegendDataRow(
            ds.stack,
            cc,
            ds.data.map((x) => x.toString()),
            chartLegend
          );
          i++;
        }
      }
    }

    AssignColors(chartDataSets);
    chartData.push(chartDataSets);
    chartData.push(chartLegend);

    const spotResultSets: RrpResultSetModel[][] = GetMultipleResultSetsForChart(
      legalEntity,
      capitalComponent,
      projectionPoint,
      rrpSession,
      true
    );

    const spotProjectionPoints = [
      ...new Set(spotResultSets.flatMap((x) => x).map((x) => x.projectionPoint)),
    ].sort();
    const spotLegalEntities = [
      ...new Set(spotResultSets.flatMap((x) => x).map((x) => x.unitIdentifier)),
    ].sort();

    AddLegendDataRow('', '', spotLegalEntities, spotChartLegend);
    i = 1;

    for (const resultSet of spotResultSets) {
      const jop = `JoP ${i}`;
      for (const prod of spotProjectionPoints) {
        for (const cc of spotCapitalComponents) {
          const data: number[] = [];
          for (const le of spotLegalEntities) {
            if (
              resultSet.some(
                (x) =>
                  x.unitIdentifier === le &&
                  x.projectionPoint === proj &&
                  x.capitalComponent === cc
              )
            ) {
              const result = resultSet.filter(
                (x) =>
                  x.unitIdentifier === le &&
                  x.projectionPoint === proj &&
                  x.capitalComponent === cc
              );
              data.push(
                result.reduce(
                  (sum, x) => sum + parseInt(x.resultValue),
                  0
                )
              );
            } else {
              data.push(0);
            }
          }
          AddLegendDataRow(
            `${jop} ${proj}`,
            cc,
            data.map((x) => x.toString()),
            spotChartLegend
          );
          i++;
          chartData.push(spotChartLegend);
          for (const results of resultSets) {
            const instances = GetInstances(results).map((x) => ({
              UnitIdentifier: x.unitIdentifier,
              ValuationType: x.valuationType,
              InstanceIdentifier: x.instanceIdentifier,
            }));
            chartData.push(instances);
          }
        }
      }
    }
  } catch (error) {
    return chartData;
  }

  return chartData;
}


function GetMultipleJopMultipleLEBarChart(
  legalEntity: string,
  capitalComponent: string,
  projectionPoint: string,
  rrpSession: string
): object[] {
  const cdLabel: string[] = [];
  const chartDataSets: ChartDatasets[] = [];
  const chartLegend: string[][] = [];
  const spotChartLegend: string[][] = [];
  const chartData: object[] = [];
  let i: number;

  try
  {
    const resultSets = GetMultipleResultSetsForChart(
    legalEntity,
    capitalComponent,
    projectionPoint,
    rrpSession
    );

    if (resultSets.length === 0) {
      return null;
    }

    const projectionPoints = [...new Set(resultSets.flatMap((x) => x).map((x) => x.ProjectionPoint))].sort();
    const legalEntities = [...new Set(resultSets.flatMap((x) => x).map((x) => x.UnitIdentifier))].sort();
    const capitalComponents = [...new Set(resultSets.flatMap((x) => x).map((x) => x.CapitalComponent))].sort();

    chartData.push(cdLabel);
    AddLegendDataRow('', '', cdLabel, chartLegend);

    for (const cc of capitalComponents) {
      for (const proj of projectionPoints) {
          i = 1;
          for (const resultSet of resultSets) {
            const jop = `JoP ${i}`;
            const ds: ChartDatasets = {
            label: `${jop} — ${proj} — ${cc}`,
            type: 'bar',
            stack: `${jop} — ${proj}`,
            data: [],
      };

      for (const le of legalEntities) {
        if (resultSet.some((x) => x.UnitIdentifier === le && x.ProjectionPoint === proj && x.CapitalComponent === cc)) {
          const result = resultSet.filter((x) => x.UnitIdentifier === le && x.ProjectionPoint === proj && x.CapitalComponent === cc);
          // Process result
        } else {
          ds.data.push(0);
        }
      }

      chartDataSets.push(ds);
      AddLegendDataRow(ds.stack, cc, ds.data.map((x) => x.toString()), chartLegend);
      i++;
    }
  }
}


   } 
   catch (error) 
   {
     return chartData;
   }


}




import { Component, OnInit } from '@angular/core';
import Chart, { ChartType } from 'chart.js/auto';

export class YourComponent implements OnInit {
  ngOnInit() {
    this.parseDataAndShowBarChart(data, xAxisLabel, legendPosition);
  }

  parseDataAndShowBarChart(data: any[], xAxisLabel: string, legendPosition: string) {
    const chartData = {
      labels: data[0],
      datasets: []
    };

    for (let i = 0; i < data[1].length; i++) {
      const dataset = {
        label: data[1][i],
        data: data[2][i],
        backgroundColor: data[3][i]
      };

      chartData.datasets.push(dataset);
    }

    const config = {
      type: 'bar' as ChartType, // Cast the type as ChartType
      data: chartData,
      options: {
        responsive: true,
        maintainAspectRatio: true,
        plugins: {
          legend: {
            position: legendPosition
          }
        },
        scales: {
          x: {
            title: {
              display: true,
              text: xAxisLabel
            }
          },
          y: {
            title: {
              display: true,
              text: 'RWA in $'
            }
          }
        }
      }
    };

    const rrpBarChart = new Chart('rrpBarChart', config);
    this.generateTable(data);
  }

  generateTable(data: any[]) {
    // Implement your table generation logic here
  }
}




export class YourComponent implements OnInit {
  ngOnInit() {
    // Call this method to generate the bar chart
    this.parseDataAndShowBarChart(data, xAxisLabel, legendPosition);
  }

  parseDataAndShowBarChart(data: any[], xAxisLabel: string, legendPosition: string) {
    const chartData = {
      labels: data[0],
      datasets: []
    };

    for (let i = 0; i < data[1].length; i++) {
      const dataset = {
        label: data[1][i],
        data: data[2][i],
        backgroundColor: data[3][i]
      };

      chartData.datasets.push(dataset);
    }

    const config = {
      type: 'bar',
      data: chartData,
      options: {
        responsive: true,
        maintainAspectRatio: true,
        plugins: {
          legend: {
            position: legendPosition
          }
        },
        scales: {
          x: {
            title: {
              display: true,
              text: xAxisLabel
            }
          },
          y: {
            title: {
              display: true,
              text: 'RWA in $'
            }
          }
        }
      }
    };

    const rrpBarChart = new Chart('rrpBarChart', config);
    this.generateTable(data);
  }

  generateTable(data: any[]) {
    // Implement your table generation logic here
  }
}



const resultSetModels: RrpResultSetModel[] = [];

res.forEach((item: any) => {
  const resultSetModel: RrpResultSetModel = new RrpResultSetModel();
  resultSetModel.id = item.id;
  resultSetModel.resultSetName = item.resultSetName;
  resultSetModel.parentReportName = item.parentReportName;
  resultSetModel.unitIdentifier = item.unitIdentifier;
  resultSetModel.instanceIdentifier = item.instanceIdentifier;
  resultSetModel.valuationType = item.valuationType;
  resultSetModel.projectionPoint = item.projectionPoint;
  resultSetModel.projectionDate = item.projectionDate;
  resultSetModel.capitalComponent = item.capitalComponent;
  resultSetModel.resultValue = item.resultValue;
  resultSetModel.resultVersion = item.resultVersion;

  resultSetModels.push(resultSetModel);
});



import { registerables } from 'chart.js';

Chart.register(...registerables);


import { Component, OnInit } from '@angular/core';
import { Chart, registerables } from 'chart.js';

@Component({
  selector: 'app-bar-chart',
  templateUrl: './bar-chart.component.html',
  styleUrls: ['./bar-chart.component.css']
})
export class BarChartComponent implements OnInit {
  barChartTitle: string;
  rrpBarChart: Chart;

  ngOnInit() {
    this.parseDataAndShowBarChartStacked();
  }

  parseDataAndShowBarChartStacked() {
    this.barChartTitle = 'Bar Chart' + this.getChartTitle();
    const data = /* your data */;
    const xAxisLabel = /* your xAxisLabel */;

    Chart.register(...registerables);

    const getOrCreateLegendList = (chart: Chart, id: string) => {
      const legendContainer = document.getElementById(id);
      let listContainer = legendContainer.querySelector('ul');
      if (!listContainer) {
        listContainer = document.createElement('ul');
        listContainer.style.display = 'flex';
        listContainer.style.flexDirection = 'row';
        listContainer.style.margin = '0';
        listContainer.style.padding = '0';
        legendContainer.appendChild(listContainer);
      }
      return listContainer;
    };

    const htmlLegendPlugin = {
      id: 'htmlLegend',
      afterUpdate: (chart: Chart, options: any) => {
        const ul = getOrCreateLegendList(chart, options.containerID);

        // Remove old legend items
        while (ul.firstChild) {
          ul.firstChild.remove();
        }

        const items = chart.options.plugins.legend.labels.generateLabels(chart);
        items.forEach(item => {
          const li = document.createElement('li');
          li.style.alignItems = 'center';
          li.style.cursor = 'pointer';
          li.style.display = 'flex';
          li.style.flexDirection = 'row';
          li.style.marginLeft = '110px';
          li.onclick = () => {
            const { type } = chart.config;
            if (type === 'pie' || type === 'doughnut') {
              // Pie and doughnut charts only have a single dataset and visibility is per item
              chart.toggleDataVisibility(item.index);
            } else {
              chart.setDatasetVisibility(item.datasetIndex, !chart.isDatasetVisible(item.datasetIndex));
            }
          };

          // Color box
          const boxSpan = document.createElement('span');
          boxSpan.style.background = item.fillStyle;
          boxSpan.style.borderColor = item.strokeStyle;
          boxSpan.style.borderWidth = item.lineWidth + 'px';
          boxSpan.style.display = 'inline-block';
          boxSpan.style.height = '120px';
          boxSpan.style.marginRight = '110px';
          boxSpan.style.width = '20px';

          // Text
          const textContainer = document.createElement('p');
          textContainer.style.color = item.fontColor;
          textContainer.style.margin = '0';
          textContainer.style.padding = '0';
          textContainer.style.textDecoration = item.hidden ? 'line-through' : '';

          const text = document.createTextNode(item.text);
          textContainer.appendChild(text);
          li.appendChild(boxSpan);
          li.appendChild(textContainer);
          ul.appendChild(li);
        });
      }
    };

    const ctx: any = document.getElementById('rrpBarChart');
    const config = {
      type: 'bar',
      data: data,
      options: {
        responsive: true,
        maintainAspectRatio: true,
        plugins: {
          htmlLegend: {
            containerID: 'legend-container'
          },
          legend: {
            display: false
          }
        },
        scales: {
          x: {
            stacked: true,
            title: {
              display: true,
              text: xAxisLabel
            }
          },
          y: {
            stacked: true,
            title: {
              display: true,
              text: 'RWA in $'
            }
          }
        }
      }
    };

    this.rrpBarChart = new Chart(ctx.getContext('2d'), config);
    this.generateTableStacked(data[2], data[3]);
  }

  




@ViewChild('legendContainer', { static: true }) legendContainerRef!: ElementRef;

// ...

getOrCreateLegendList(chart: any, id: string): HTMLElement {
  const legendContainer = this.legendContainerRef.nativeElement;
  let listContainer = legendContainer.querySelector('ul');

  if (!listContainer) {
    listContainer = document.createElement('ul');
    listContainer.style.display = 'flex';
    listContainer.style.flexDirection = 'row';
    listContainer.style.margin = '0';
    listContainer.style.padding = '0';

    legendContainer.appendChild(listContainer);
  }

  return listContainer;
}



const htmlLegendPlugin = {
  id: 'htmlLegend',
  afterUpdate: (chart: any, args: any, options: any) => {
    const legendContainer = this.legendContainerRef.nativeElement;
    const listContainer = getOrCreateLegendList(chart, legendContainer.id);
    // Rest of the code
  }
};



const htmlLegendPlugin = {
  id: 'htmlLegend',
  afterUpdate: (chart: any, args: any, options: any) => {
    const legendContainer = this.legendContainerRef.nativeElement;
    const listContainer = getOrCreateLegendList(chart, legendContainer.id);
    // Rest of the code
  }
};


import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-legend',
  template: `
    <div #legendContainer>
      <ul #listContainer></ul>
    </div>
  `,
  styles: []
})
export class LegendComponent implements OnInit {
  @ViewChild('legendContainer', { static: true }) legendContainerRef!: ElementRef;
  @ViewChild('listContainer', { static: true }) listContainerRef!: ElementRef;

  constructor() { }

  ngOnInit() {
    this.getOrCreateLegendList();
  }

  getOrCreateLegendList() {
    const legendContainer = this.legendContainerRef.nativeElement;
    let listContainer = this.listContainerRef.nativeElement;

    if (!listContainer) {
      listContainer = document.createElement('ul');
      listContainer.style.display = 'flex';
      listContainer.style.flexDirection = 'row';
      listContainer.style.margin = '0';
      listContainer.style.padding = '0';

      legendContainer.appendChild(listContainer);
    }

    return listContainer;
  }
}




@Component({
  selector: 'app-your-component',
  templateUrl: './your-component.component.html',
  styleUrls: ['./your-component.component.css']
})
export class YourComponent implements OnInit {
  filteredData: FilteredData | null = null;

  constructor(private yourService: YourService) { }

  ngOnInit() {
    this.getFilteredData();
  }

  getFilteredData() {
    this.yourService.getFilteredData().subscribe(
      (data: FilteredData) => {
        this.filteredData = data;
        // Perform any additional logic with the filtered data
      },
      (error) => {
        // Handle error if needed
      }
    );
  }
}


export interface FilteredData {
  unitIdentifiers: string[];
  capitalComponents: string[];
  projectionPoints: string[];
}

@Injectable({
  providedIn: 'root'
})
export class YourService {
  private apiUrl = 'https://api.example.com/filtered-data'; // Replace with your API URL

  constructor(private http: HttpClient) { }

  getFilteredData(): Observable<FilteredData> {
    return this.http.get<FilteredData>(this.apiUrl).pipe(
      map(response => this.mapFilteredData(response))
    );
  }

  private mapFilteredData(response: any): FilteredData {
    // Perform any necessary mapping or transformation here
    // Assuming the response matches the structure of FilteredData
    return {
      unitIdentifiers: response.unitIdentifiers,
      capitalComponents: response.capitalComponents,
      projectionPoints: response.projectionPoints
    };
  }
}


public class FilteredData
{
    public IEnumerable<string> UnitIdentifiers { get; set; }
    public IEnumerable<string> CapitalComponents { get; set; }
    public IEnumerable<string> ProjectionPoints { get; set; }
}

public FilteredData PopulateFilters(IEnumerable<RRPResultSet> rrpResultSets)
{
    var unitIdentifiers = rrpResultSets
        .Select(x => x.UnitIdentifier)
        .Where(x => !x.Equals("SCEN", StringComparison.InvariantCultureIgnoreCase))
        .Distinct()
        .OrderBy(x => x);

    var capitalComponents = rrpResultSets
        .Select(x => x.Capita1Component)
        .Where(x => x.StartsWith("RWA"))
        .Distinct()
        .OrderBy(x => x);

    var projectionPoints = rrpResultSets
        .Select(x => x.ProjectionPoint)
        .Distinct()
        .OrderBy(x => x);

    var filteredData = new FilteredData
    {
        UnitIdentifiers = unitIdentifiers,
        CapitalComponents = capitalComponents,
        ProjectionPoints = projectionPoints
    };

    return filteredData;
}


using System;
using System.Xml;
using System.Xml.Linq;

public static class XElementExtensions
{
    public static XElement CreateXElement(this string inputXml)
    {
        XElement element = new XElement("Request",
            new XElement("MaRSNetSession",
                new XElement("LogOnDetails",
                    new XElement("User", new XAttribute("name", "nkumar152"),
                        new XElement("Groups")
                    )
                ),
                new XElement("Signature")
            ),
            XElement.Parse(inputXml) // Converts the given inputXml to XElement and includes it in the resulting structure
        );

        return element;
    }

    public static XmlDocument ToXmlDocument(this XElement element)
    {
        var document = new XmlDocument();
        document.LoadXml(element.ToString());
        return document;
    }
}

public class Program
{
    public static void Main()
    {
        string inputXml = "<GetResultSetNames username=\"nkuma152\" client_ref=\"MarsNet\" hame_pattern=\"RRPScen96\"><FirstDate>2023/3/31</FirstDate><LastDate>2023/3/31</LastDate></GetResultSetNames>";

        XElement result = inputXml.CreateXElement();

        XmlDocument xmlDoc = result.ToXmlDocument();

        Console.WriteLine(xmlDoc.OuterXml); // Output the final XML structure as a string
    }
}




string cacheKey = "rrpSession";
cache.Set(cacheKey, rrpResultSets);

List<RRPResultSet> cachedResultSets = cache.Get<List<RRPResultSet>>(cacheKey);


dotnet add package Serilog
dotnet add package Serilog.Extensions.Logging
dotnet add package Serilog.Sinks.Console
dotnet add package Serilog.Sinks.File

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseSerilog((hostingContext, loggerConfiguration) =>
            {
                loggerConfiguration
                    .ReadFrom.Configuration(hostingContext.Configuration)
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .WriteTo.File("logs.txt", rollingInterval: RollingInterval.Day);
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}




List<RRPResultSet> cachedResultSets = memoryCache.Get<List<RRPResultSet>>(rrpSession);

if (cachedResultSets != null)
{
    // Use the cachedResultSets as needed
    // ...
}


private void CreateResultSetTable(XmlNodeList nodesList, string rrpSession, string rrpCobDate, IMemoryCache memoryCache)
{
    var rrpDelimiter = Configuration.GetSection("RRPDelimiter").Value;
    var rrpResultSets = new List<RRPResultSet>();

    foreach (XmlNode node in nodesList)
    {
        var rrpRowData = GetRRPResultSetFromResultSetName(node.Attributes["Pid"].Value, node.InnerText, rrpDelimiter);

        if (rrpRowData is not null && rrpRowData.UnitIdentifier != "CSGROUP_DIV")
        {
            rrpResultSets.Add(rrpRowData);
        }
    }

    if (rrpResultSets.Any())
    {
        rrpResultSets = rrpResultSets.OrderByDescending(x => x.InstanceIdentifier)
                                     .ThenBy(x => x.ValuationType)
                                     .ThenBy(x => x.ProjectionPoint)
                                     .ToList();

        GetResults(rrpResultSets, rrpCobDate);

        memoryCache.Set(rrpSession, rrpResultSets, TimeSpan.FromMinutes(30)); // Adjust the expiration time as per your requirements
    }
}


using System.Collections.Generic;
using System.Linq;

public static class StringExtensions
{
    public static string RemoveUnderscores(this string input)
    {
        return new string(input.Where(c => c != '_').ToArray());
    }

    public static List<string> RemoveUnderscores(this List<string> strings)
    {
        return strings.Select(s => s.RemoveUnderscores()).ToList();
    }
}

using System.Collections.Generic;
using System.Linq;

public static class StringExtensions
{
    public static List<string> RemoveSpacesBetweenCharacters(this List<string> strings)
    {
        return strings.Select(s => string.Concat(s.Split())).ToList();
    }
}






using System;
using System.Collections.Generic;

public static class MyClassExtensions
{
    public static List<string> GetPropertiesContainingString(this MyClass obj, string input)
    {
        List<string> properties = new List<string>();

        if (obj.Property1.Contains(input))
            properties.Add(nameof(MyClass.Property1));

        if (obj.Property2.Contains(input))
            properties.Add(nameof(MyClass.Property2));

        if (obj.Property3.Contains(input))
            properties.Add(nameof(MyClass.Property3));

        if (obj.Property4.Contains(input))
            properties.Add(nameof(MyClass.Property4));

        if (obj.Property5.Contains(input))
            properties.Add(nameof(MyClass.Property5));

        return properties;
    }
}




using Microsoft.AspNetCore.Hosting;
using System.IO;

public static class WebHostEnvironmentExtensions
{
    public static string GetFilePath(this IWebHostEnvironment hostEnvironment, string relativePath)
    {
        string contentRootPath = hostEnvironment.ContentRootPath;
        string filePath = Path.Combine(contentRootPath, relativePath);

        return filePath;
    }
}




canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean> | Promise<boolean> | boolean {
    return this.authService.checkAuthorization().toPromise()
      .then((response) => {
        const isAuthorized = response.headers.get('AuthorizationStatus');
        if (!isAuthorized) {
          this.router.navigate(['/error']);
          return false;
        }
        return true;
      })
      .catch((error) => {
        // Handle the error
        return false;
      });
  }
import { Injectable } from '@angular/core';
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  Router,
} from '@angular/router';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class AuthorizationGuard implements CanActivate {
  constructor(private http: HttpClient, private router: Router) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean> | Promise<boolean> | boolean {
    return this.http
      .get<any>('api/some-action')
      .toPromise()
      .then((response) => {
        const isAuthorized = response.headers.get('AuthorizationStatus');
        if (!isAuthorized) {
          this.router.navigate(['/error']);
          return false;
        }
        return true;
      })
      .catch((error) => {
        // Handle the error
        return false;
      });
  }
}






import { Observable } from 'rxjs';

interface ResultSet {
  id: string;
  name: string;
}

// Assuming you have an Observable<string[]> named 'source$'
const source$: Observable<string[]> = ...;

// Map the Observable<string[]> to ResultSet[]
source$.pipe(
  map((array: string[]) => {
    return array.map((item: string, index: number) => {
      const result: ResultSet = {
        id: index.toString(),  // Assign the index as 'id' property
        name: item             // Map the item to 'name' property
      };
      return result;
    });
  })
).subscribe((resultSetArray: ResultSet[]) => {
  // Handle the resulting ResultSet[] array
  console.log(resultSetArray);
});



import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Item } from '../item.interface';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css']
})
export class GridComponent {
  @Input() items: Item[] = [];
  @Output() onItemSelectionChange: EventEmitter<void> = new EventEmitter<void>();

  selectAll(checked: boolean) {
    this.items.forEach(item => item.selected = checked);
    this.onItemSelectionChange.emit();
  }

  toggleSelection(item: Item) {
    item.selected = !item.selected;
    this.onItemSelectionChange.emit();
  }
}



import { Component, Input } from '@angular/core';
import { Item } from '../item.interface';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css']
})
export class GridComponent {
  @Input() items: Item[] = [];

  selectAll(checked: boolean) {
    this.items.forEach(item => item.selected = checked);
  }

  toggleSelection(item: Item) {
    item.selected = !item.selected;
  }
}


import { Component, ViewChild } from '@angular/core';
import { Item } from './item.interface';
import { GridComponent } from './grid.component';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  items: Item[] = [
    { selected: false, name: 'Item 1' },
    { selected: false, name: 'Item 2' },
    { selected: false, name: 'Item 3' }
    // Add more items as needed
  ];

  selectedItems: Item[] = [];

  @ViewChild(GridComponent) gridComponent: GridComponent;

  ngAfterViewInit() {
    this.gridComponent.onItemSelectionChange.subscribe(() => {
      this.selectedItems = this.items.filter(item => item.selected);
    });
  }
}


<table class="table">
  <thead>
    <tr>
      <th>
        <input type="checkbox" (change)="selectAll($event.target.checked)">
      </th>
      <th>Name</th>
    </tr>
  </thead>
  <tbody>
    <tr *ngFor="let item of items">
      <td>
        <input type="checkbox" [(ngModel)]="item.selected" (change)="toggleSelection(item)">
      </td>
      <td>{{ item.name }}</td>
    </tr>
  </tbody>
</table>


import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Item } from '../item.interface';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css']
})
export class GridComponent {
  @Input() items: Item[] = [];
  @Output() onItemSelectionChange: EventEmitter<void> = new EventEmitter<void>();

  selectAll(checked: boolean) {
    this.items.forEach(item => item.selected = checked);
    this.onItemSelectionChange.emit();
  }

  toggleSelection(item: Item) {
    item.selected = !item.selected;
    this.onItemSelectionChange.emit();
  }
}

Parent
<app-grid [items]="items" (onItemSelectionChange)="onItemSelectionChange()"></app-grid>

import { Component } from '@angular/core';
import { Item } from './item.interface';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  items: Item[] = [
    { selected: false, name: 'Item 1' },
    { selected: false, name: 'Item 2' },
    { selected: false, name: 'Item 3' }
    // Add more items as needed
  ];

  selectedItems: Item[] = [];

  onItemSelectionChange() {
    this.selectedItems = this.items.filter(item => item.selected);
  }
}
  





import { Component } from '@angular/core';
import { YourService } from './your.service';
import { Item } from './item.interface';

@Component({
  selector: 'app-your-component',
  templateUrl: './your-component.component.html',
  styleUrls: ['./your-component.component.css']
})
export class YourComponent {
  items: Item[] = [];

  constructor(private yourService: YourService) {}

  ngOnInit() {
    this.yourService.getStringArray().subscribe((response: string[]) => {
      this.items = response.map(name => ({ name, selected: false }));
    });
  }
}


import { Component } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  items = [
    { selected: false, column1: 'Item 1 Column 1', column2: 'Item 1 Column 2' },
    { selected: false, column1: 'Item 2 Column 1', column2: 'Item 2 Column 2' },
    { selected: false, column1: 'Item 3 Column 1', column2: 'Item 3 Column 2' }
    // Add more items as needed
  ];

  selectedItems = [];
}



<div class="container">
  <div class="row">
    <div class="col-md-12">
      <table class="table">
        <thead>
          <tr>
            <th>
              <input type="checkbox" (change)="selectAll($event.target.checked)" />
            </th>
            <th>Column 1</th>
            <th>Column 2</th>
          </tr>
        </thead>
        <tbody>
          <tr *ngFor="let item of items">
            <td>
              <input type="checkbox" [(ngModel)]="item.selected" />
            </td>
            <td>{{ item.column1 }}</td>
            <td>{{ item.column2 }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</div>


<app-grid [items]="items"></app-grid>

<div class="selected-items">
  <h4>Selected Items:</h4>
  <ul>
    <li *ngFor="let selectedItem of selectedItems">{{ selectedItem.column1 }} - {{ selectedItem.column2 }}</li>
  </ul>
</div>

selectAll(checked: boolean) {
  this.items.forEach(item => item.selected = checked);

  if (checked) {
    this.selectedItems = [...this.items];
  } else {
    this.selectedItems = [];
  }
}

child component
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css']
})
export class GridComponent {
  @Input() items: any[] = [];

  selectAll(checked: boolean) {
    this.items.forEach(item => item.selected = checked);
  }
}





import { Component, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-your-component',
  template: `
    <input type="checkbox" id="selectAllCheckbox" [(ngModel)]="selectAllChecked" (change)="toggleSelectAll()"> Select All
    <input type="checkbox" id="mat-checkbox-1-input" [(ngModel)]="checkbox1Checked"> Checkbox 1
    <input type="checkbox" id="mat-checkbox-2-input" [(ngModel)]="checkbox2Checked"> Checkbox 2
    <input type="checkbox" id="mat-checkbox-3-input" [(ngModel)]="checkbox3Checked"> Checkbox 3
  `,
})
export class YourComponent implements AfterViewInit {
  selectAllChecked: boolean = false;
  checkbox1Checked: boolean = false;
  checkbox2Checked: boolean = false;
  checkbox3Checked: boolean = false;

  ngAfterViewInit() {
    const checkboxSelectors = ['#mat-checkbox-\\d+-input']; // Regex pattern to match checkboxes with IDs like '#mat-checkbox-1-input', '#mat-checkbox-2-input', etc.
    const checkboxes = Array.from(document.querySelectorAll('input[type="checkbox"]')).filter((checkbox: HTMLInputElement) => {
      return checkboxSelectors.some((selector) => new RegExp(selector).test(checkbox.id));
    });
    checkboxes.forEach((checkbox: HTMLInputElement) => {
      checkbox.checked = this.selectAllChecked;
    });
  }

  toggleSelectAll() {
    // Implement the logic to handle the select all functionality
  }
}


export class YourComponent implements AfterContentInit {
  // Component properties, methods, and lifecycle hooks

  ngAfterContentInit() {
    // Check all the checkboxes with the specified selector
    if (this.checkboxes && this.checkboxes.length > 0) {
      this.checkboxes.forEach((cb: any) => {
        cb.nativeElement.checked = true;
      });
    }
  }
}

@ViewChildren('checkbox') checkboxes: QueryList<any>;



@ViewChildren('checkbox') checkboxes: QueryList<any>;


toggleSelectAll() {
  this.checkboxes.forEach((checkbox: any) => {
    checkbox.checked = true;
  });
}


<div class="col-and-12">
  <!-- Other code -->
  <app-select-all-row [checked]="selectAllChecked" (toggleChecked)="toggleSelectAll()"></app-select-all-row>
  <!-- Other code -->
</div>



ng generate module select-all-row --module=MarsAdminModule --route select-all-row

ng generate component select-all-row --module=MarsAdminModule

<div class="col-and-12">
  <mnet-notification [showNotification]="listDataSource?.data?.length === 0" [message]="'No data available'"></mnet-notification>
  <div *ngIf="showSelectAllCheckbox" class="mat-elevation-z2 mb-2 rounded-xl">
    <mat-table #tableFilePath [dataSource]="listDataSource" matSort>
      <ng-container matColumnDef="Select">
        <mat-header-cell *matHeaderCellDef>
          <mat-checkbox [(ngModel)]="selectAllChecked" (change)="toggleSelectAll()"></mat-checkbox>
        </mat-header-cell>
        <mat-cell *matCellDef="let searchItem">
          <mat-checkbox (change)="manageSelection(searchItem)" [(ngModel)]="searchItem.isSelected"></mat-checkbox>
        </mat-cell>
      </ng-container>
      <ng-container matColumnDef="Name">
        <mat-header-cell *matHeaderCellDef mat-sort-header> Name </mat-header-cell>
        <mat-cell *matCellDef="let searchItem"> {{ searchItem.name }} </mat-cell>
      </ng-container>
      <!-- Add your other column definitions here -->

      <mat-header-row *matHeaderRowDef="displayedColumns"></mat-header-row>
      <mat-row *matRowDef="let row; columns: displayedColumns;"></mat-row>
    </mat-table>
    <mat-paginator #listPaginator [pageSizeOptions]="[20, 50, 100]" showFirstLastButtons></mat-paginator>
  </div>
</div>



<div class="col-and-12">
  <mnet-notification [showNotification]="listDataSource?.data?.length === 0" [message]="'No data available'"></mnet-notification>
  <div *ngIf="showSelectAllCheckbox" class="mat-elevation-z2 mb-2 rounded-xl">
    <mat-table #tableFilePath [dataSource]="listDataSource" matSort>
      <ng-container matColumnDef="Select">
        <mat-header-cell *matHeaderCellDef>
          <mat-checkbox [(ngModel)]="selectAllChecked" (change)="toggleSelectAll()"></mat-checkbox>
        </mat-header-cell>
        <mat-cell *matCellDef="let searchItem">
          <mat-checkbox (change)="manageSelection(searchItem)" [(ngModel)]="searchItem.isSelected"></mat-checkbox>
        </mat-cell>
      </ng-container>
      <ng-container matColumnDef="Name">
        <mat-header-cell *matHeaderCellDef mat-sort-header> Name </mat-header-cell>
        <mat-cell *matCellDef="let searchItem"> {{ searchItem.name }} </mat-cell>
      </ng-container>
      <!-- Add your other column definitions here -->

      <mat-header-row *matHeaderRowDef="displayedColumns"></mat-header-row>
      <mat-row *matRowDef="let row; columns: displayedColumns;"></mat-row>
    </mat-table>
    <mat-paginator #listPaginator [pageSizeOptions]="[20, 50, 100]" showFirstLastButtons></mat-paginator>
  </div>
</div>


import { MatCheckbox } from '@angular/material/checkbox';

selectAll(event: Event) {
  const checkbox = event.target as MatCheckbox;
  const checkboxes = Array.from(document.querySelectorAll('.mat-checkbox-input'));

  checkboxes.forEach((cb: HTMLInputElement) => {
    const matCheckbox = cb as MatCheckbox;
    matCheckbox.checked = checkbox.checked;
  });
}



<app-child-component [showSelectAllCheckbox]="shouldShowSelectAll"></app-child-component>

shouldShowSelectAll: boolean = false;

<div class="col-and-12">
  <mnet-notification [showNotification]="listDataSource?.data?.length === 0" [message]="'No data available'"></mnet-notification>
  <div *ngIf="showSelectAllCheckbox" class="mat-elevation-z2 mb-2 rounded-xl">
    <mat-table #tableFilePath [dataSource]="listDataSource" matSort>
      <ng-container matColumnDef="Select">
        <mat-header-cell *matHeaderCellDef>
          <mat-checkbox (change)="selectAll($event)"></mat-checkbox>
        </mat-header-cell>
        <mat-cell *matCellDef="let searchItem">
          <mat-checkbox (change)="manageSelection(searchItem)" [checked]="selection?.isSelected(searchItem)"></mat-checkbox>
        </mat-cell>
      </ng-container>
      <ng-container matColumnDef="{{displayedColumns[1]}}">
        <mat-header-cell *matHeaderCellDef mat-sort-header>{{displayedColumns[1]}}</mat-header-cell>
        <mat-cell *matCellDef="let searchItem">{{searchItem.name}}</mat-cell>
      </ng-container>
      <mat-header-row *matHeaderRowDef="displayedColumns"></mat-header-row>
      <mat-row *matRowDef="let row; columns: displayedColumns;"></mat-row>
    </mat-table>
    <mat-paginator #listPaginator [pageSizeOptions]="[20, 50, 100]" showFirstLastButtons></mat-paginator>
  </div>
</div>


import { Component } from '@angular/core';

@Component({
  selector: 'app-parent-component',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  shouldShowSelectAll: boolean = false;

  toggleSelectAllVisibility() {
    this.shouldShowSelectAll = !this.shouldShowSelectAll;
  }
}



import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-child-component',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
  @Input() showSelectAllCheckbox: boolean = false;

  // Rest of the component logic
}


selectAll(event: Event) {
  const checkbox = event.target as HTMLInputElement;
  const checkboxes = document.querySelectorAll('mat-checkbox.mat-checkbox-input');

  checkboxes.forEach((cb: HTMLInputElement) => {
    cb.checked = checkbox.checked;
    // Perform additional logic or update data/model as needed
  });
}



public removeItemsFromGroup(type: string, groupName: string, items: string[]): Observable<any> {
  const url = 'YOUR_API_ENDPOINT_URL'; // Replace with your actual API endpoint URL

  const params = {
    type: type,
    groupName: groupName,
    items: items
  };

  return this.http.delete(url, { params });
}



import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { LabelType } from './label-type';

@Injectable({
  providedIn: 'root'
})
export class LabelService {
  private apiUrl = 'api/maintenance/GetLabelTypes';

  constructor(private http: HttpClient) { }

  getListofLabelTypesAndValues(): Observable<LabelType[]> {
    return this.http.get<string[]>(this.apiUrl).pipe(
      map(strings => strings.map(string => ({ displayText: string, value: string } as LabelType))),
      catchError(this.handleError<LabelType[]>('getListofLabelTypesAndValues', []))
    );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error); // log to console instead
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}



async Task<XmlDocument> GetNewBatchesAsync(DateTime since)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetNewBatchReports", m_ClientSystemName)
    {
        AttributeValueCollection = { ["since"] = since.ToString("yyyyMMdd HH:mm:ss") }
    };
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);

    XmlDocument results = await requestDocument.PostRequestAsync();

    return results;
}


async Task<XDocument> GetHierarchyDocumentAsync(string hierarchyName, int levels, DateTime cobDate)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetHierarchy", m_ClientSystemName)
    {
        AttributeValueCollection = 
        {
            ["hierarchy_name"] = hierarchyName,
            ["levels"] = levels.ToString(),
            ["date"] = HtmlUtility.StandardCobDate(cobDate),
            ["detail"] = "all"
        }
    };
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);

    string resultXml = await requestDocument.PostRequestAsync();
    XDocument results = XDocument.Parse(resultXml);

    return results;
}


async Task<XDocument> GetHierarchyDocumentAsync(string hierarchyName, int levels, DateTime cobDate, string startNodeId)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetHierarchy", m_ClientSystemName)
    {
        AttributeValueCollection = 
        {
            ["hierarchy_name"] = hierarchyName,
            ["levels"] = levels.ToString(),
            ["date"] = HtmlUtility.StandardCobDate(cobDate),
            ["start_node"] = startNodeId,
            ["detail"] = "all"
        }
    };
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);

    string resultXml = await requestDocument.PostRequestAsync();
    XDocument results = XDocument.Parse(resultXml);

    return results;
}


async Task<XPathDocument> GetHierarchyDocumentLiteAsync(string hierarchyName, int levels, DateTime cobDate)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetHierarchy", m_ClientSystemName)
    {
        AttributeValueCollection = 
        {
            ["hierarchy_name"] = hierarchyName,
            ["levels"] = levels.ToString(),
            ["date"] = HtmlUtility.StandardCobDate(cobDate),
            ["detail"] = "all"
        }
    };
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);

    string resultXml = await requestDocument.PostRequestLiteAsync();
    XDocument xDocument = XDocument.Parse(resultXml);
    XPathDocument results = new XPathDocument(xDocument.CreateReader());

    return results;
}

async Task<XPathDocument> GetHierarchyDocumentLiteAsync(string hierarchyName, int levels, DateTime cobDate, string startNodeId)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetHierarchy", m_ClientSystemName)
    {
        AttributeValueCollection = 
        {
            ["hierarchy_name"] = hierarchyName,
            ["levels"] = levels.ToString(),
            ["date"] = HtmlUtility.StandardCobDate(cobDate),
            ["start_node"] = startNodeId,
            ["detail"] = "all"
        }
    };
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);

    string resultXml = await requestDocument.PostRequestLiteAsync();
    XDocument xDocument = XDocument.Parse(resultXml);
    XPathDocument results = new XPathDocument(xDocument.CreateReader());

    return results;
}


async Task<XPathDocument> GetHierarchyDiffAsync(string hierarchyName, DateTime fromDate, DateTime toDate)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetHierarchyDifferencesByCob", m_ClientSystemName)
    {
        AttributeValueCollection = 
        {
            ["hierarchy_name"] = hierarchyName,
            ["from_date"] = fromDate.ToString("yyyyMMdd"),
            ["to_date"] = toDate.ToString("yyyyMMdd")
        }
    };
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);

    string resultXml = await requestDocument.PostRequestLiteAsync();
    XDocument xDocument = XDocument.Parse(resultXml);
    XPathDocument results = new XPathDocument(xDocument.CreateReader());

    return results;
}


async Task<XDocument> AddReportToMarsNetGroupAsync(string reportname, string groupName = "MaRS Net Reports", string type = "")
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("AddDataItemGroupItems");
    XmlRequestItem requestItem2 = new("DataItemGroupMembership")
    {
        AttributeValueCollection = 
        {
            ["group"] = groupName,
            ["item"] = reportname,
            ["type"] = type
        }
    };

    requestItem.AddChildRequestItem(requestItem2);
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);

    string resultXml = await requestDocument.PostRequestAsync();
    XDocument results = XDocument.Parse(resultXml);

    return results;
}

async Task<XDocument> GetMarsReportRunStatusAsync(string[] reportNames, DateTime cobDate)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("ListReportRunsStatus");

    requestItem.AttributeValueCollection.Add("cob_date", cobDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));

    foreach (string reportName in reportNames)
    {
        XmlRequestItem requestItemRequest = new("ListReportRunsStatusRequest")
        {
            AttributeValueCollection = { ["report_name"] = reportName }
        };

        requestItem.AddChildRequestItem(requestItemRequest);
    }

    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, m_DefaultProxy, m_UserName);
    string resultXml = await requestDocument.PostRequestAsync();
    XDocument results = XDocument.Parse(resultXml);

    return results;
}

async Task<XDocument> ListReportTagsAsync()
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("ListLabels", m_ClientSystemName)
    {
        AttributeValueCollection = { ["label_type"] = "" }
    };
    
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, "", m_UserName);
    string resultXml = await requestDocument.PostRequestAsync();
    XDocument results = XDocument.Parse(resultXml);

    return results;
}

async Task<XDocument> GetDataItemGroupsAsync(string type)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetDataItemGroups")
    {
        AttributeValueCollection = { ["type"] = type }
    };
    
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, "", m_UserName);
    string resultXml = await requestDocument.PostRequestAsync();
    XDocument results = XDocument.Parse(resultXml);

    return results;
}


async Task<XDocument> GetNewReportsAsync(DateTime since)
{
    XmlRequest request = new();
    XmlRequestItem requestItem = new("GetNewReports", m_ClientSystemName)
    {
        AttributeValueCollection = { ["since"] = since.ToString("yyyyMMdd HH:mm:ss") }
    };
    
    request.AddRequestNode(requestItem);

    DBServerHttpXmlRequest requestDocument = new(request, m_ConnectionString, "", m_UserName);
    string resultXml = await requestDocument.PostRequestAsync();
    XDocument results = XDocument.Parse(resultXml);

    return results;
}




ng generate module label-maintenance-routing --flat --module=label-maintenance

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AdminComponent } from './admin/admin.component';
import { NonAdminComponent } from './non-admin/non-admin.component';

const routes: Routes = [
  { 
    path: 'admin', 
    component: AdminComponent 
  },
  { 
    path: 'nonadmin', 
    component: NonAdminComponent 
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LabelMaintenanceRoutingModule { }









string newPath = $@"C:\Users\{Environment.UserName}\Downloads\certificate.p12";


moving my leave up by two days
// user-warning.component.ts
import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-user-warning',
  templateUrl: './user-warning.component.html',
  styleUrls: ['./user-warning.component.css']
})
export class UserWarningComponent {
  @Output() dataGridReloadEvent = new EventEmitter<boolean>();

  onButtonClick() {
    this.dataGridReloadEvent.emit(true);
  }
}

<!-- parent.component.html -->
<app-user-warning (dataGridReloadEvent)="onDataGridReloadEvent($event)"></app-user-warning>

  

ng g c report-control/run-status/user-warning


import { Observable } from 'rxjs';



// In StateService
getReportNamesObservable(): Observable<string> {
  return this.reportNames.asObservable();
}


import { Component, OnInit, OnDestroy } from '@angular/core';
import { StateService } from 'src/app/services/state.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-success-page',
  templateUrl: './success-page.component.html',
  styleUrls: ['./success-page.component.css']
})
export class SuccessPageComponent implements OnInit, OnDestroy {
  reportNames: string[];
  private reportNamesSubscription: Subscription;

  constructor(private stateService: StateService) {}

  ngOnInit(): void {
    this.reportNamesSubscription = this.stateService.getReportNamesObservable().subscribe((reportNames: string) => {
      if (reportNames) {
        this.reportNames = reportNames.split(',');
      }
    });
  }

  ngOnDestroy(): void {
    // Clean up the subscription to prevent memory leaks
    this.reportNamesSubscription.unsubscribe();
  }
}


import { Component, OnInit } from '@angular/core';
import { MnetReportControlService } from 'src/app/services/mnet-report-control.service';
import { StaticData } from 'src/app/static-data';
import { ReportdefRSPermGroupModel } from 'src/app/models/reportdef-rs-perm-group.model';
import { tap } from 'rxjs/operators';

@Component({
  selector: 'app-example',
  templateUrl: './example.component.html',
  styleUrls: ['./example.component.css']
})
export class ExampleComponent implements OnInit {
  groups: ReportdefRSPermGroupModel[];

  constructor(private mnetReportControlService: MnetReportControlService) { }

  ngOnInit(): void {
    this.initialiseGroups();
  }

  initialiseGroups(): void {
    try {
      let pagePermissionType = StaticData.CONSTANTS.ConstantData.PermissionGroupType[0].ReportDefinition;
      this.mnetReportControlService.getRSPermissionGroup(pagePermissionType).pipe(
        tap((result: ReportdefRSPermGroupModel[]) => {
          this.groups = result;
          console.log(result);
          console.log('groups added');
          // Perform your task here
          this.loadGrid();
        })
      ).subscribe(
        (result: ReportdefRSPermGroupModel[]) => {
          // This will still be executed, but the task has already been performed in the tap operator
        },
        (error) => {
          console.log(error);
        }
      );
    } catch (error) {
      console.log(error);
    }
  }

  loadGrid(): void {
    // Your loadGrid function logic
  }
}



initialiseGroups(): void {
  try {
    let pagePermissionType = StaticData.CONSTANTS.ConstantData.PermissionGroupType[0].ReportDefinition;
    this.mnetReportControlService.getRSPermissionGroup(pagePermissionType).subscribe(
      (result: ReportdefRSPermGroupModel[]) => {
        this.groups = result;
        console.log(result);
        console.log('groups added');
      },
      (error) => {
        console.log(error);
      }
    );
  } catch (error) {
    console.log(error);
  }
}


import { Component } from '@angular/core';

@Component({
  // ... Component metadata ...
})
export class YourComponent {
  constructor(private mnetReportControlService: YourService) {
    (async () => {
      await this.initialiseGroups();
    })();
  }

  async initialiseGroups() {
    // ... Your existing initialiseGroups method ...
  }
}


import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { StateService } from 'src/app/services/state.service';

@Component({
  selector: 'app-success-page',
  templateUrl: './success-page.component.html',
  styleUrls: ['./success-page.component.css']
})
export class SuccessPageComponent implements OnInit {
  reportNames: string[];
  cob: string;

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private stateService: StateService
  ) { }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.reportNames = params['reportNames'].split(',');
      this.cob = params['cob'];
    });
  }

  goBack(): void {
    this.stateService.setBackClicked(true);
    this.location.back();
  }
}



<div class="container">
  <div class="row">
    <div class="col-md-3">
      <label for="statusDropdown">Status:</label>
      <select id="statusDropdown" [(ngModel)]="statusDropdownValue">
        <!-- Add your options here -->
      </select>
    </div>

    <div class="col-md-3">
      <label for="reportNameTextBox">Report Name (use for pattern search):</label>
      <input type="text" id="reportNameTextBox" [(ngModel)]="reportNameTextBoxValue" />
    </div>

    <div class="col-md-3">
      <label for="queueDropdown">Queue:</label>
      <select id="queueDropdown" [(ngModel)]="queueDropdownValue">
        <!-- Add your options here -->
      </select>
    </div>

    <div class="col-md-3">
      <label for="priorityDropdown">Priority:</label>
      <select id="priorityDropdown" [(ngModel)]="priorityDropdownValue">
        <!-- Add your options here -->
      </select>
    </div>
  </div>

  <div class="row">
    <div class="col-md-12">
      <button (click)="onButtonClick()">Load Grid</button>
    </div>
  </div>

  <div class="row" *ngIf="gridVisible">
    <div class="col-md-12">
      <!-- Replace this placeholder with your actual grid component or implementation -->
      <div class="grid-placeholder">Grid goes here</div>
    </div>
  </div>
</div>



import { Component, OnInit } from '@angular/core';
import { StateService } from 'src/app/services/state.service';

@Component({
  selector: 'app-run-status-list',
  templateUrl: './run-status-list.component.html',
  styleUrls: ['./run-status-list.component.css']
})
export class RunStatusListComponent implements OnInit {
  // Variables for selected dropdown values and grid visibility
  statusDropdownValue: any;
  reportNameTextBoxValue: string;
  queueDropdownValue: any;
  priorityDropdownValue: any;
  gridVisible: boolean;

  constructor(private stateService: StateService) { }

  ngOnInit(): void {
    // If the back button was clicked, retrieve the stored state from the StateService
    if (this.stateService.getBackClicked()) {
      this.statusDropdownValue = this.stateService.getStatusDropdownValue();
      this.reportNameTextBoxValue = this.stateService.getReportNameTextBoxValue();
      this.queueDropdownValue = this.stateService.getQueueDropdownValue();
      this.priorityDropdownValue = this.stateService.getPriorityDropdownValue();
      this.gridVisible = this.stateService.getGridVisible();

      // Load the grid
      this.loadGrid();
    }
  }

  // Load the grid with data from the backend API
  loadGrid(): void {
    // Your existing logic for loading the grid with data from the backend API
    // ...

    // Set grid visibility to true
    this.gridVisible = true;
  }

  // Handle the click event for the button that loads the grid
  onButtonClick(): void {
    // Load the grid and store the state
    this.loadGrid();
    this.storeState();
  }

  // Store the state of dropdown selected values and grid visibility
  storeState(): void {
    this.stateService.setStatusDropdownValue(this.statusDropdownValue);
    this.stateService.setReportNameTextBoxValue(this.reportNameTextBoxValue);
    this.stateService.setQueueDropdownValue(this.queueDropdownValue);
    this.stateService.setPriorityDropdownValue(this.priorityDropdownValue);
    this.stateService.setGridVisible(this.gridVisible);
    this.stateService.setBackClicked(false);
  }
}



import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class StateService {
  private statusDropdownValue = new BehaviorSubject<any>(null);
  private reportNameTextBoxValue = new BehaviorSubject<string>(null);
  private queueDropdownValue = new BehaviorSubject<any>(null);
  private priorityDropdownValue = new BehaviorSubject<any>(null);
  private gridVisible = new BehaviorSubject<boolean>(false);
  private backClicked = new BehaviorSubject<boolean>(false);

  constructor() {}

  getStatusDropdownValue(): any {
    return this.statusDropdownValue.value;
  }

  setStatusDropdownValue(value: any): void {
    this.statusDropdownValue.next(value);
  }

  getReportNameTextBoxValue(): string {
    return this.reportNameTextBoxValue.value;
  }

  setReportNameTextBoxValue(value: string): void {
    this.reportNameTextBoxValue.next(value);
  }

  getQueueDropdownValue(): any {
    return this.queueDropdownValue.value;
  }

  setQueueDropdownValue(value: any): void {
    this.queueDropdownValue.next(value);
  }

  getPriorityDropdownValue(): any {
    return this.priorityDropdownValue.value;
  }

  setPriorityDropdownValue(value: any): void {
    this.priorityDropdownValue.next(value);
  }

  getGridVisible(): boolean {
    return this.gridVisible.value;
  }

  setGridVisible(visible: boolean): void {
    this.gridVisible.next(visible);
  }

  getBackClicked(): boolean {
    return this.backClicked.value;
  }

  setBackClicked(clicked: boolean): void {
    this.backClicked.next(clicked);
  }
}



{
  "compilerOptions": {
    "moduleResolution": "node",
    "experimentalDecorators": true,
    // ...other settings
  },
  // ...other settings
}



import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StateService {
  private dropdownValues = new BehaviorSubject<any>(null);
  private gridVisible = new BehaviorSubject<boolean>(false);
  private backClicked = new BehaviorSubject<boolean>(false);

  constructor() { }

  setDropdownValues(values: any): void {
    this.dropdownValues.next(values);
  }

  getDropdownValues(): BehaviorSubject<any> {
    return this.dropdownValues;
  }

  setGridVisible(visible: boolean): void {
    this.gridVisible.next(visible);
  }

  getGridVisible(): BehaviorSubject<boolean> {
    return this.gridVisible;
  }

  setBackClicked(value: boolean): void {
    this.backClicked.next(value);
  }

  getBackClicked(): BehaviorSubject<boolean> {
    return this.backClicked;
  }
}



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
