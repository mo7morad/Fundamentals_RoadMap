using System;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Core = Microsoft.Office.Core;

namespace PowerPointCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerPoint.Application pptApplication = new PowerPoint.Application();

            try
            {
                pptApplication.Visible = Core.MsoTriState.msoTrue;
                PowerPoint.Presentations presentations = pptApplication.Presentations;
                PowerPoint.Presentation presentation = presentations.Add(Core.MsoTriState.msoTrue);

                // Add a slide
                PowerPoint.Slides slides = presentation.Slides;
                PowerPoint.Slide slide = slides.Add(1, PowerPoint.PpSlideLayout.ppLayoutText);

                // Set title
                PowerPoint.Shape titleShape = slide.Shapes[1];
                titleShape.TextFrame.TextRange.Text = "Hello, PowerPoint!";

                // Set subtitle
                PowerPoint.Shape bodyShape = slide.Shapes[2];
                bodyShape.TextFrame.TextRange.Text = "Created using C#";

                // Save the presentation
                string filePath = @"C:\Temp\MyPresentation.pptx";
                presentation.SaveAs(filePath, PowerPoint.PpSaveAsFileType.ppSaveAsDefault, Core.MsoTriState.msoTrue);
                presentation.Close();
                Console.WriteLine("Presentation created successfully at: " + filePath);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                pptApplication.Quit();
            }

            Console.ReadKey(); // Keeps the console window open
        }
    }
}
