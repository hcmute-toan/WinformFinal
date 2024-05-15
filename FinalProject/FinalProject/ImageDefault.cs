using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public static class ImageDefault
    {
        public static string filePath = @"D:\logo1.png"; 
        public static System.Drawing.Image image = System.Drawing.Image.FromFile(filePath);
        public static byte[] ImageToByteArray(System.Drawing.Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        //public static void UpfateIfNull()
        //{
        //    SqlConnection conn = new
        //     SqlConnection(Properties.Settings.Default.ConnStr);
        //    conn.Open();
        //    SqlCommand CMD1 = new SqlCommand("UPDATE Candidates SET Picture = @PictureParam WHERE Id = 1", conn);
        //    // Cung cấp giá trị cho các thamSqlParameter
        //    CMD1.Parameters.Add("@PictureParam", ImageToByteArray(image));
        //    if ( CMD1.ExecuteNonQuery() > 0)
        //    { MessageBox.Show("Succcess!!!"); }
        //    else
        //    {
        //        MessageBox.Show("Fail!!!");
        //    }
        //    conn.Close();
        //}
    }
}
