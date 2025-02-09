using System;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PdfMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide at least one PDF file path.");
                return;
            }

            string outputFilePath = "mergePdf.pdf";
            using (PdfDocument outputDocument = new PdfDocument())
            {
                foreach (string filePath in args)
                {
                    if (File.Exists(filePath) && Path.GetExtension(filePath).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                    {
                        PdfDocument inputDocument = PdfReader.Open(filePath, PdfDocumentOpenMode.Import);
                        for (int i = 0; i < inputDocument.PageCount; i++)
                        {
                            PdfPage page = inputDocument.Pages[i];
                            outputDocument.AddPage(page);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"File not found or not a PDF: {filePath}");
                    }
                }

                outputDocument.Save(outputFilePath);
                Console.WriteLine($"Merged PDF saved as {outputFilePath}");
            }
        }
    }
}