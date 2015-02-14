using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_System
{
    public class Image : Element
    {
        public ImageType Type { get; set; }
        public byte[] Data { get; set; }

        public Image(ImageType type, byte[] data)
        {
            this.Type = type;
            this.Data = data;
        }

        public static Image CreateFromFile(string fileName)
        {
            ImageType type = ImageType.CreateFromFileName(fileName);
            byte[] data = File.ReadAllBytes(fileName);
            Image image = new Image(type, data);

            return image;
        }

        public override void RenderHtml(TextWriter writer)
        {
            writer.Write("<img src='data:{0};base64, {1}'/>",
                this.Type.ContentType, Convert.ToBase64String(this.Data));
        }
    }
}
