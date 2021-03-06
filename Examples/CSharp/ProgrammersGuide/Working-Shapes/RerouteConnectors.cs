﻿using Aspose.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ProgrammersGuide.Working_Shapes
{
    public class RerouteConnectors
    {
        public static void Run()
        {
            //ExStart:RerouteConnectors
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes();

            // call a Diagram class constructor to load the VSDX diagram
            Diagram diagram = new Diagram(dataDir + "Drawing1.vsdx");
            // get page by name
            Page page = diagram.Pages.GetPage("Page-3");

            // get a particular connector shape
            Shape shape = page.Shapes.GetShape(18);
            // set reroute option
            shape.Layout.ConFixedCode.Value = ConFixedCodeValue.NeverReroute;

            // save Visio diagram
            diagram.Save(dataDir + "RerouteConnectors_Out.vsdx", SaveFileFormat.VSDX);
            //ExEnd:RerouteConnectors
        }
    }
}
