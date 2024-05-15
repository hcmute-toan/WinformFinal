using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public static class ConvertImage
    {
        public static System.Drawing.Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return System.Drawing.Image.FromStream(m);
        }
    }
}
