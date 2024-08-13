using System;
using SingleReponsibilityPrinciple;

namespace SingleResponsiblityPrinciple
{
    class Program : Report
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            ReportFormatter reportFormatter = new ReportFormatter();
            ReportFileManager reportFileManager = new ReportFileManager();
            report.GenerateReport("This is some content.");
            reportFormatter.FormatReport(report);
            reportFileManager.SaveToFile("report.txt", report);
            reportFileManager.LoadFromFile("report.txt", report);

            Console.Write(report.Content);
        }
    }
}
