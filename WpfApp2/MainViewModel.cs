
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using OfficeOpenXml;
using System.Diagnostics;
using System.Windows.Threading;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace WpfApp2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<ExcelDataModel> _excelData;

        public ObservableCollection<ExcelDataModel> ExcelData
        {
            get { return _excelData; }
            set { SetProperty(ref _excelData, value, nameof(ExcelData)); }
        }
        private double _uploadProgress;

        public double UploadProgress
        {
            get { return _uploadProgress; }
            set
            {
                _uploadProgress = value;
                OnPropertyChanged();
            }
        }


        private bool _isUploadEnabled = true;

        public bool IsUploadEnabled
        {
            get { return _isUploadEnabled; }
            set
            {
                _isUploadEnabled = value;
                OnPropertyChanged();
            }
        }
        

        public RelayCommand UploadFileCommand { get; private set; }

        public MainViewModel()
        {
            UploadFileCommand = new RelayCommand(UploadFileAsync);
        }



        private async void UploadFileAsync()
        {
            IsUploadEnabled = false;
            var openFileDialog = new OpenFileDialog { Filter = "Excel Files (*.xlsx)|*.xlsx" };
            if (openFileDialog.ShowDialog() == true)
            {
                var filePath = openFileDialog.FileName;

                ExcelData = await ReadExcelFileAsync(filePath);
                //Application.Current.Dispatcher.Invoke(() => ExcelData = ExcelData);
            }
        }
        private async Task<ObservableCollection<ExcelDataModel>> ReadExcelFileAsync(string filePath)
        {
            var progress = new Progress<double>(percent => UploadProgress = percent);
            var result = new ObservableCollection<ExcelDataModel>();

            // Synchronize the access to the collection with the UI
            BindingOperations.EnableCollectionSynchronization(result, new object());

            // Call the method responsible for reading the Excel data and pass the progress instance
            await Application.Current.Dispatcher.Invoke(async () => await ReadExcelFileWithProgress(filePath, progress, result));

            return result;
        }






        private async Task ReadExcelFileWithProgress(string filePath, IProgress<double> progress, ObservableCollection<ExcelDataModel> result)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int totalRows = worksheet.Dimension.Rows;

                for (int row = 2; row <= totalRows; row++)
                {
                    var rowData = new ExcelDataModel
                    {
                        Name = worksheet.Cells[row, 1].GetValue<string>(),
                        Age = worksheet.Cells[row, 2].GetValue<int>(),
                        DateOfBirth = worksheet.Cells[row, 3].GetValue<DateTime>(),
                        Email = worksheet.Cells[row, 4].GetValue<string>(),
                    };
                    double percent = (double)(row - 1) / (totalRows - 1) * 100;

                    result.Add(rowData);
                    progress.Report(percent);

                    // This line will ensure that the UI has time to update
                    await Task.Delay(1);
                }
            }
        }




    }
}


