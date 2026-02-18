using System;
using System.Collections.Generic;
using System.Drawing;
using Grasshopper.Kernel;
using Rhino.Geometry;

namespace UnitConvertor1
{
    public class RGBtocolour : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the RGBtocolour class.
        /// </summary>
        public RGBtocolour()
          : base("RGBtocolour", "RGB->Clr",
              "Converts RGB Values into a Color",
              "UnitConvertor", "Display")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddIntegerParameter("R", "R", "Provide the value for Red(0-225)", GH_ParamAccess.item, 225);
            pManager.AddIntegerParameter("G", "G", "Provide the value for Green(0-225)", GH_ParamAccess.item, 225);
            pManager.AddIntegerParameter("B", "B", "Provide the value for Blue(0-225)", GH_ParamAccess.item, 225);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddColourParameter("Color", "C", "Resulting color", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int r = 0;
            int g = 0; 
            int b = 0;

            if (!DA.GetData(0, ref r)) return;
            if (!DA.GetData(1, ref g)) return;
            if (!DA.GetData(2, ref b)) return;


            //Clamp values
            r = Clamp255(r);
            g = Clamp255(g);
            b = Clamp255(b);

            Color color = Color.FromArgb(r, g, b);

            DA.SetData(0, color);


        }
        private int Clamp255(int value)
        {
            if (value < 0) return 0;
            if (value > 255) return 255;
            return value;
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("C82CDCFE-E965-40E3-AF61-8091E0FE61ED"); }
        }
    }
}