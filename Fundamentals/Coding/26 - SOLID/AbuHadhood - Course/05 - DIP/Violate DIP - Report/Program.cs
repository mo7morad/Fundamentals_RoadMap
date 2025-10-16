using System;


    public class PdfReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("PDF report generated :-).");
        }
    }

    public class ReportGenerator
    {
        private PdfReportGenerator _pdfReportGenerator;
        

        public ReportGenerator()
        {
            // Direct dependency on PdfReport (low-level module)
            _pdfReportGenerator = new PdfReportGenerator();
          
        }

        public void GenerateReport()
        {
            _pdfReportGenerator.Generate();
        }
    

    class Program
    {
        static void Main(string[] args)
        {
            // Client code
            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.GenerateReport();

            
            Console.ReadKey();

        }
    }
}
