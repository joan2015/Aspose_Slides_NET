//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;

namespace ModifyingBuiltinProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate the Presentation class that represents the Presentation
            Presentation pres = new Presentation(dataDir + "Aspose.pptx");

            //Create a reference to IDocumentProperties object associated with Presentation
            IDocumentProperties dp = pres.DocumentProperties;

            //Set the builtin properties
            dp.Author = "Aspose.Slides for .NET";
            dp.Title = "Modifying Presentation Properties";
            dp.Subject = "Aspose Subject";
            dp.Comments = "Aspose Description";
            dp.Manager = "Aspose Manager";

            //Save your presentation to a file
            pres.Write(dataDir + "DocProps.pptx");
            
        }
    }
}