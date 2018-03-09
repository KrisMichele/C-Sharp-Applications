using System;
using OfficeOpenXml;
using System.IO;

namespace EmailDatabase
{
    class Database
    {
        public void AddTo(string firstName, string lastName, string department, string email, string password,
            string mailboxCapacity)
        {

            FileInfo excelFilePath =
                new FileInfo(
                    "C:\\Users\\Kristen\\Dropbox\\C# Applications\\EmailDatabase\\EmailDatabase\\EmailDatabase.xlsx");

            try
            {
                DateTime now = DateTime.Now;
                string dtcurrent = now.ToString("mm/dd/yyyy hh: mm:ss");

                ExcelPackage package = new ExcelPackage(excelFilePath);
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int endRow = worksheet.Dimension.Rows;
                int newRow = ++endRow;

                worksheet.Cells[newRow, 1].Value = dtcurrent;
                worksheet.Cells[newRow, 2].Value = firstName;
                worksheet.Cells[newRow, 3].Value = lastName;
                worksheet.Cells[newRow, 4].Value = department;
                worksheet.Cells[newRow, 5].Value = email;
                worksheet.Cells[newRow, 6].Value = password;
                worksheet.Cells[newRow, 7].Value = mailboxCapacity;
                package.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }


        public void ChangeTo(string firstName, string lastName, string department, string password, string email,
            string mailboxCapacity)
        {
            FileInfo excelFilePath =
                new FileInfo(
                    "C:\\Users\\Kristen\\Dropbox\\C# Applications\\EmailDatabase\\EmailDatabase\\EmailDatabase.xlsx");

            try
            {

                DateTime now = DateTime.Now;
                string dtcurrent = now.ToString("mm/dd/yyyy hh: mm:ss");

                ExcelPackage package = new ExcelPackage(excelFilePath);
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                for (var rowNum = 1; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    if (worksheet.Cells[rowNum, 2].Value.ToString() == firstName &&
                        worksheet.Cells[rowNum, 3].Value.ToString() == lastName)
                    {
                        worksheet.Cells[rowNum, 1].Value = dtcurrent;
                        worksheet.Cells[rowNum, 2].Value = firstName;
                        worksheet.Cells[rowNum, 3].Value = lastName;
                        worksheet.Cells[rowNum, 5].Value = password;

                        if (department != null)
                        {
                            worksheet.Cells[rowNum, 4].Value = department;
                            worksheet.Cells[rowNum, 5].Value = email;
                        }
                        if (mailboxCapacity != null)
                        {
                            worksheet.Cells[rowNum, 7].Value = mailboxCapacity;
                        }
                    }
                }
                package.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Delete(string firstName, string lastName)
        {
            FileInfo excelFilePath =
                new FileInfo(
                    "C:\\Users\\Kristen\\Dropbox\\C# Applications\\EmailDatabase\\EmailDatabase\\EmailDatabase.xlsx");

            try
            {
                ExcelPackage package = new ExcelPackage(excelFilePath);
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                for (var rowNum = 1; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    if (worksheet.Cells[rowNum, 2].Value.ToString() == firstName &&
                        worksheet.Cells[rowNum, 3].Value.ToString() == lastName)
                    {
                      worksheet.DeleteRow(rowNum, 1);
                    }
                }
                package.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Open()
        {

            FileInfo excelFilePath = new FileInfo("C:\\Users\\Kristen\\Dropbox\\C# Applications\\EmailDatabase\\EmailDatabase\\EmailDatabase.xlsx");
            if (excelFilePath.Exists)
            {
                System.Diagnostics.Process.Start(@"C:\\Users\\Kristen\\Dropbox\\C# Applications\\EmailDatabase\\EmailDatabase\\EmailDatabase.xlsx");
            }
            else
            {
                Console.WriteLine("An error was encountered during open or the database does not exist.");
            }
        }

    }
}