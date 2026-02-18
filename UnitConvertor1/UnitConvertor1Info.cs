using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace UnitConvertor1
{
    public class UnitConvertor1Info : GH_AssemblyInfo
    {
        public override string Name => "UnitConvertor1";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("e54fdaec-fcfd-48d1-b3bd-7adeabcadc31");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}