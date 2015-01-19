using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class ColorCorrectionData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxPath TextureLUT { get; set; }
        public FoxFloat StartSlope { get; set; }
        public FoxFloat EndSlope { get; set; }
        public FoxBool ShowBaseLUT { get; set; }
        public FoxBool ShowFilterLUT { get; set; }
        public FoxColor ColorScale { get; set; }
    }
}