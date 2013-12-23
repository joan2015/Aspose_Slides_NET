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
Imports System.Drawing

Namespace ManagingFontProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a Presentation object that represents a PPT file
			Dim pres As New Presentation(dataDir & "demo.ppt")


			'Accessing a slide using its slide position
			Dim slide As Slide = pres.GetSlideByPosition(1)


			'Accessing the first placeholder in the slide and typecasting it as a text holder
			Dim th As TextHolder = CType(slide.Placeholders(0), TextHolder)


			'Getting the first paragraph of the text holder
			Dim para As Paragraph = th.Paragraphs(0)


			'Accessing the first portion of the paragraph
			Dim port As Portion = para.Portions(0)


			'Setting the font to bold
			port.FontBold = True


			'Setting the font to be underlined
			port.FontUnderline = True


			'Setting the font to be embossed
			port.FontEmbossed = True


			'Setting the font to be italic
			port.FontItalic = True


			'Enabling the font shadow
			port.FontShadow = True


			'Setting the font color to green
			port.FontColor = Color.Green


			'Setting the font height to 55
			port.FontHeight = 55


			'Writing the presentation as a PPT file
			pres.Write(dataDir & "modified.ppt")

		End Sub
	End Class
End Namespace