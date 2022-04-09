using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report report= new Report(); //parametre yok
                                         //  report.CreatedDate= DateTime.Now;
            Console.WriteLine($"Tarih: {report.CreatedDate}, Format: {report.Format}, ve Türü: {report.Type}");
            
            Report performanceReport= new Report("Devrim Mehmet");
            Console.WriteLine($"Tarih: {performanceReport.CreatedDate}, Format: {performanceReport.Format}, ve Türü: {performanceReport.Type}, Bu Raporun Sahibi: {performanceReport.Owner}");

            Report customReport =new Report(Formats.Excel);


        }
    }
}
