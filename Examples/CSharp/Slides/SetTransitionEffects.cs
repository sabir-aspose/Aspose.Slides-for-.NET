﻿using Aspose.Slides.Export;
using Aspose.Slides.SlideShow;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.Slides
{
    class SetTransitionEffects
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Slides_Presentations();

            // ExStart:SetTransitionEffects
            // Create an instance of Presentation class
            Presentation presentation = new Presentation(dataDir + "AccessSlides.pptx");

            // Set effect
            presentation.Slides[0].SlideShowTransition.Type = TransitionType.Cut;
            ((OptionalBlackTransition)presentation.Slides[0].SlideShowTransition.Value).FromBlack = true;

            // ExEnd:SetTransitionEffects
            // Write the presentation to disk
            presentation.Save(dataDir + "SetTransitionEffects.pptx", SaveFormat.Pptx);
        }
    }
}