'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides

Namespace ConvertingWiithXpsOptions
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a Presentation object that represents a presentation file
			Using pres As New Presentation(dataDir & "Aspose.pptx")
				'Instantiate the TiffOptions class
				Dim opts As New Aspose.Slides.Export.XpsOptions()

				'Save MetaFiles as PNG
				opts.SaveMetafilesAsPng = True

				'Save the presentation to XPS document
				pres.Save(dataDir & "demo.xps", Aspose.Slides.Export.SaveFormat.Xps, opts)
			End Using
		End Sub
	End Class
End Namespace