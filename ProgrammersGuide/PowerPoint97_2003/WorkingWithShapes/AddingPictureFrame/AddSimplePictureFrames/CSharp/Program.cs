//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using System;

namespace AddSimplePictureFrames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate a Presentation object that represents a PPT file
            Presentation pres = new Presentation(dataDir + "demo.ppt");


            //Accessing a slide using its slide position
            Slide slide = pres.GetSlideByPosition(2);


            //Creating a picture object that will be used to fill the ellipse
            Picture pic = new Picture(pres, dataDir + "asp.jpg");


            //Adding the picture object to pictures collection of the presentation
            //After the picture object is added, the picture is given a uniqe picture Id
            int picId = pres.Pictures.Add(pic);


            //Calculating picture width and height
            int pictureWidth = pres.Pictures[picId - 1].Image.Width * 4;
            int pictureHeight = pres.Pictures[picId - 1].Image.Height * 4;


            //Calculating slide width and height
            int slideWidth = slide.Background.Width;
            int slideHeight = slide.Background.Height;


            //Calculating the width and height of picture frame
            int pictureFrameWidth = Convert.ToInt32(slideWidth / 2 - pictureWidth / 2);
            int pictureFrameHeight = Convert.ToInt32(slideHeight / 2 - pictureHeight / 2);


            //Adding picture frame to the slide
            slide.Shapes.AddPictureFrame(picId, pictureFrameWidth, pictureFrameHeight,
                                                    pictureWidth, pictureHeight);


            //Writing the presentation as a PPT file
            pres.Write(dataDir + "modified.ppt");

        }
    }
}