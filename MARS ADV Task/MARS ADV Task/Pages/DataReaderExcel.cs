﻿using System.IO;
using ExcelDataReader;
using System.Data;
using DataTable = System.Data.DataTable;

namespace MARS_ADV_Task.Pages
{
    internal class DataReaderExcel
    {
        string filename = "Mars.xlsx";

        public DataTable readData()
        {
            string filePath = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "Data"
                + Path.DirectorySeparatorChar + filename;

            using (System.IO.FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))

            {
                // handle encoding exception 1252
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using (IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateOpenXmlReader(fs))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    DataTableCollection dtc = result.Tables;
                    DataTable dt = dtc[0];
                    return dt;
                }
            }
        }
    }
}
