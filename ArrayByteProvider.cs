using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Decoder
{
    internal class ArrayByteProvider : Be.Windows.Forms.IByteProvider
    {
        private readonly byte[] _data;
        public long Length  => _data.Length;

        public event EventHandler LengthChanged;
        public event EventHandler Changed;

        public ArrayByteProvider(byte[] data)
        {
            _data = data;
        }

        public void ApplyChanges()
        {
            throw new NotSupportedException();
        }

        public void DeleteBytes(long index, long length)
        {
            throw new NotSupportedException();
        }

        public bool HasChanges() => false;

        public void InsertBytes(long index, byte[] bs)
        {
            throw new NotSupportedException();
        }

        public byte ReadByte(long index) => _data[index];

        public bool SupportsDeleteBytes() => false;

        public bool SupportsInsertBytes() => false;

        public bool SupportsWriteByte() => true;

        public void WriteByte(long index, byte value) => _data[index] = value;
    }
}
