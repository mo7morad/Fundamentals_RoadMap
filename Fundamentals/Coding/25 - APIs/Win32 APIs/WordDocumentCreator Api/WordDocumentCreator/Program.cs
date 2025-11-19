using System;
using Word = Microsoft.Office.Interop.Word;

namespace WordDocumentCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Word.Application wordApp = new Word.Application();
            try
            {
                wordApp.Visible = false;  // Set to true if you want to see Word while the document is being created

                Word.Document doc = wordApp.Documents.Add();  // Create a new document
                Word.Paragraph para = doc.Paragraphs.Add();   // Add a paragraph
                para.Range.Text = "Hi, My Name is Mohammed Abu-Hadhoud";  // Your name goes here

                // Save the document
                string filepath = @"C:\Temp\MyDocument.docx";  // Change the path as needed
                doc.SaveAs2(filepath);
                doc.Close();

                Console.WriteLine("Document created successfully at: " + filepath);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                wordApp.Quit();  // Close Word application
            }

            Console.ReadKey();  // Keeps the console window open
        }
    }
}
