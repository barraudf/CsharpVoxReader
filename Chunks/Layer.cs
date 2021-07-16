using System;
using System.IO;
using System.Collections.Generic;

namespace CsharpVoxReader.Chunks
{
    public class Layer : Chunk
    {
        public const string ID = "LAYR";

        internal override string Id
        {
            get { return ID; }
        }

        internal override int Read(BinaryReader br, IVoxLoader loader)
        {
            int readSize = base.Read(br, loader);
            Int32 id = br.ReadInt32();
            Dictionary<string, byte[]> attributes = GenericsReader.ReadDict(br, ref readSize);

			attributes.TryGetName(out var name);

            Int32 reservedId = br.ReadInt32();
            readSize += sizeof(Int32) * 2;

            loader.NewLayer(id, name, attributes);
            return readSize;
        }
    }
}
