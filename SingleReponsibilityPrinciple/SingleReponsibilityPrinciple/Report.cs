namespace SingleReponsibilityPrinciple
{
    public class Report
    {
        public string Content { get; set; }

        public void GenerateReport(string content)
        {
            Content = content;
        }
    }

    public class ReportFileManager
    {
        public void SaveToFile(string filename, Report report)
        {
            File.WriteAllText(filename, report.Content);
        }

        public void LoadFromFile(string filename, Report report)
        {
            report.Content = File.ReadAllText(filename);
        }
    }

    public class ReportFormatter
    {
        public void FormatReport(Report report)
        {
            report.Content = report.Content.ToLower();
        }
    }

}
