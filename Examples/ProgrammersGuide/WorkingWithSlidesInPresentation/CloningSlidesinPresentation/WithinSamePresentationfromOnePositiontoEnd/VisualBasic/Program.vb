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
Imports Aspose.Slides.Export

Namespace WithinSamePresentationfromOnePositiontoEnd
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate Presentation class that represents a presentation file
			Using pres As New Presentation(dataDir & "Aspose.pptx")

				'Clone the desired slide to the end of the collection of slides in the same presentation
				Dim slds As ISlideCollection = pres.Slides

				slds.AddClone(pres.Slides(0))


				'Write the modified presentation to disk
				pres.Save(dataDir & "Aspose_cloned.pptx", SaveFormat.Pptx)

			End Using
		End Sub
	End Class
End Namespace