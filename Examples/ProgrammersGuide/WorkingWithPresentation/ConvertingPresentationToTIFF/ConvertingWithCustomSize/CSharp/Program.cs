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
using System.Drawing;

namespace ConvertingWithCustomSize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate a Presentation object that represents a Presentation file
            using (Presentation pres = new Presentation(dataDir + "Aspose.pptx"))
            {

                //Instantiate the TiffOptions class
                Aspose.Slides.Export.TiffOptions opts = new Aspose.Slides.Export.TiffOptions();

                //Setting compression type
                opts.CompressionType = TiffCompressionTypes.Default;

                //Compression Types

                //Default - Specifies the default compression scheme (LZW).
                //None - Specifies no compression.
                //CCITT3
                //CCITT4
                //LZW
                //RLE

                //Depth � depends on the compression type and cannot be set manually.
                //Resolution unit � is always equal to �2� (dots per inch)

                //Setting image DPI
                opts.DpiX = 200;
                opts.DpiY = 100;

                //Set Image Size
                opts.ImageSize = new Size(1728, 1078);

                //Save the presentation to TIFF with specified image size
                pres.Save(dataDir + "demo.tiff", Aspose.Slides.Export.SaveFormat.Tiff, opts);

            }
        }
    }
}