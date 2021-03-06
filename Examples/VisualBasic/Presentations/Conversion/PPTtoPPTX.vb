Imports System
Imports Aspose.Slides.Export

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Presentations.Conversion
    Public Class PPTtoPPTX
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Conversion()

            ' Instantiate a Presentation object that represents a PPTX file
            Dim pres As New Presentation(dataDir & Convert.ToString("PPTtoPPTX.ppt"))

            ' Saving the PPTX presentation to PPTX format
            pres.Save(dataDir & Convert.ToString("PPTtoPPTX_out.pptx"), SaveFormat.Pptx)
        End Sub
    End Class
End Namespace
