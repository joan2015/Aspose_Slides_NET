//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertingPresentationToHTML
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            //Instantiate a Presentation object that represents a presentation file
            using (Presentation pres = new Presentation(dataDir + "Aspose.pptx"))
            {

                HtmlOptions htmlOpt = new HtmlOptions();
                htmlOpt.HtmlFormatter = HtmlFormatter.CreateDocumentFormatter("", false);

                //Saving the presentation to HTML
                pres.Save(dataDir + "demo.html", Aspose.Slides.Export.SaveFormat.Html, htmlOpt);
            }
        }
    }
}