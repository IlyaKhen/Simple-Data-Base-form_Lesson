//Targil 9 PDF class ilya khenkin and roman aronov
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Lesson_8_SQL_ADO_NET
{
    class MyPDF
    {
        private Document doc;
        //constructor for building new PDF file
        public MyPDF()
        {
            this.doc = new Document();
            PdfWriter.GetInstance(this.doc, new FileStream("new_pdf.pdf", FileMode.Create));
        }
        //constructor for building new PDF file with user name
        public MyPDF(string name)
        {
            this.doc = new Document();
            PdfWriter.GetInstance(this.doc, new FileStream(name + ".pdf", FileMode.Create));
        }
        //writing a title
        public void SetTitle(string title)
        {
            try
            {
                doc.Open();
                Paragraph par = new Paragraph(title + "\n");
                par.Alignment = Element.ALIGN_CENTER;
                par.SpacingAfter = 100f;
                doc.Add(par);
            }
            catch (IOException)
            {
                Console.Error.Write("The file is open. Error.");
            }
        }
        //adding image to PDF
        public void SetImage(string imagePath)
        {
            doc.Open();
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
            image.ScaleAbsolute(400, 400);
            image.SetAbsolutePosition(50, 350);
            Paragraph imageParagragh = new Paragraph();
            imageParagragh.Add(image);
            doc.Add(imageParagragh);
        }
        //adding table to PDF file
        public void SetIntTable(int[,] table)
        {
            doc.Open();
            PdfPTable myTable = new PdfPTable(table.GetLength(0)); //number of columns
            myTable.HorizontalAlignment = Element.ALIGN_CENTER;
            float[] widthCell = new float[table.GetLength(0)];
            for (int i = 0; i < table.GetLength(0); i++)
                widthCell[i] = (float)100 / table.GetLength(0); //getting equal % for any cell
            myTable.SetTotalWidth(widthCell);
            PdfPCell myCell = new PdfPCell();
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.Length / table.GetLength(0); j++)
                {
                    myCell.Phrase = new Phrase(table[i, j].ToString());
                    myTable.AddCell(myCell);
                }
            }
            Paragraph pargraghTable = new Paragraph();
            pargraghTable.Add(myTable);
            pargraghTable.SpacingAfter = 15f;
            doc.Add(pargraghTable);
        }
        //set student table
        public void SetStudentTable(Students[] table)
        {
            doc.Open();
            PdfPTable myTable = new PdfPTable(2); //number of columns
            myTable.HorizontalAlignment = Element.ALIGN_CENTER;
            float[] widthCell = new float[2];
            widthCell[0] = 40;
            widthCell[1] = 60;
            myTable.SetTotalWidth(widthCell);
            PdfPCell myCell = new PdfPCell();

            for (int i = 0; i < table.Length; i++)
            {
                myCell.Phrase = new Phrase(table[i].FirstName.ToString());
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(table[i].CityName.ToString());
                myTable.AddCell(myCell);
                
            }
            Paragraph pargraghTable = new Paragraph();
            pargraghTable.Add(myTable);
            pargraghTable.SpacingAfter = 15f;
            doc.Add(pargraghTable);
        }
        //closing PDF file
        public void CloseReport()
        {
            this.doc.Close();
        }
    }
}
