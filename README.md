Super simple CLI tool to merge PDFs.

## Prerequisites
.NET 9 SDK for building the project. Get it at [https://dot.net]([https://dot.net](https://dotnet.microsoft.com/en-us/download))

## Usage
Just run the tool and add 2 or more PDF file paths as arguments to merge them. Pages will be read in this order and appended to a new `mergePdf.pdf` file in the same directory.
`dotnet run -- "c:\pdf1.pdf" "c:\pdf2.pdf" "c:\pdf3.pdf"`
