using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpVoxReader
{
    public interface IVoxLoader
    {
        void LoadModel(Int32 sizeX, Int32 sizeY, Int32 sizeZ, byte[,,] data);
        void LoadPalette(UInt32[] palette);
        void SetModelCount(Int32 count);
        void SetMaterialOld(Int32 paletteId, Chunks.MaterialOld.MaterialTypes type, float weight, Chunks.MaterialOld.PropertyBits property, float normalized);
    }
}
