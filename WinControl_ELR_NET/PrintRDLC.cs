using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;

namespace WinControl_ELR_NET
{

    public class DimensionesPapel
    {
       public double PageWidth = 8.5;
       public double PageHeight = 11;
       public double MarginTop = 0.25;
       public double MarginLeft = 0.25;
       public double MarginRight = 0.25;
       public double MarginBottom = 0.25;

       public DimensionesPapel()
       {

       }

       public DimensionesPapel(double pageWidth, double pageHeight, double marginTop, double marginLeft, double marginRight, double marginBottom)
       {
           PageWidth = pageWidth;
           PageHeight = pageHeight;
           MarginTop = marginTop;
           MarginLeft = marginLeft;
           MarginRight = marginRight;
           MarginBottom = marginBottom;
       }

    }

    public class PrintRDLC : IDisposable
    {

        //Variables Publicas
        public double PageWidth = 8.5;
        public double PageHeight = 11;
        public double MarginTop = 0.25;
        public double MarginLeft = 0.25;
        public double MarginRight = 0.25;
        public double MarginBottom = 0.25;

        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();

                m_streams = null;
            }
        }

        //Routine to provide to the report renderer, in order to
        //save an image for each page of the report.
        public Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);

            return stream;
        }

        //Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth><PAGE_WIDTH>in</PageWidth>
                <PageHeight><PAGE_HEIGHT>in</PageHeight>
                <MarginTop><MARGIN_TOP>in</MarginTop>
                <MarginLeft><MARGIN_LEFT>in</MarginLeft>
                <MarginRight><MARGIN_RIGHT>in</MarginRight>
                <MarginBottom><MARGIN_BOTTOM>in</MarginBottom>
            </DeviceInfo>";

            deviceInfo = deviceInfo.Replace("<PAGE_WIDTH>", PageWidth.ToString());
            deviceInfo = deviceInfo.Replace("<PAGE_HEIGHT>", PageHeight.ToString());
            deviceInfo = deviceInfo.Replace("<MARGIN_TOP>", MarginTop.ToString());
            deviceInfo = deviceInfo.Replace("<MARGIN_LEFT>", MarginLeft.ToString());
            deviceInfo = deviceInfo.Replace("<MARGIN_RIGHT>", MarginRight.ToString());
            deviceInfo = deviceInfo.Replace("<MARGIN_BOTTOM>", MarginBottom.ToString());


            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }

        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = "CutePDF Writer";
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }


        //Metodo Publicos
        public void Print(LocalReport localReport)
        {
            
            Export(localReport);
            Print();
        }

        public void Print(LocalReport localReport, double pageWidth, double pageHeight, double marginTop, double marginLeft, double marginRight, double marginBottom)
        {
            PageWidth = pageWidth;
            PageHeight = pageHeight;
            MarginTop = marginTop;
            MarginLeft = marginLeft;
            MarginRight = marginRight;
            MarginBottom = marginBottom;

            Export(localReport);
            Print();
        }

        public void Print(LocalReport localReport, DimensionesPapel dmPapel)
        {
            PageWidth = dmPapel.PageWidth;
            PageHeight = dmPapel.PageHeight;
            MarginTop =dmPapel.MarginTop;
            MarginLeft = dmPapel.MarginLeft;
            MarginRight = dmPapel.MarginRight;
            MarginBottom = dmPapel.MarginBottom;

            Export(localReport);
            Print();
        }
        



    }
}
