using Models.Interfaces;

namespace Models
{
    public interface IPicture
    {
        string Url { get; set; }
        int Dimension { get; set; }
    }
    public class Image : BookItem, IPicture, IVisitee
    {
        public string Url { get; set; }
        public int Dimension { get; set; } = 0;
        public ImageContent? ContentImg { get; }

        public Image(string content, string url = "") : base(content) {
            Url = url;
            ContentImg = ImageLoaderFactory.Create(url);
        }
        public override void Print() => Console.WriteLine(Content + " * rendering *");

        public void Accept(IVisitor visitor)
        {
            visitor.VisitImage(this);
        }
    }

    public class ImageProxy
    {
        public string Url { get; set; }
        public int Dimension { get; set; } = 0;

        public Image Image {
            get {
                if(realImage == null)
                {
                   return loadImage();
                }
                return realImage;
            }
        }
        private Image? realImage;
        public ImageProxy(string url) {
            Url = url;
        }

        private Image loadImage()
        {
            realImage = new Image("My new image", Url);
            // calculate dimension here
            Dimension = (new Random()).Next(9999);
            return realImage;
        }
    }

    public interface IImageLoader
    {
        public ImageContent Load(string url);
    }

    public class JPGImageLoader : IImageLoader
    {
        public ImageContent Load(string url)
        {
            throw new NotImplementedException();
        }
    }

    public class BMPImageLoader : IImageLoader
    {
        public ImageContent Load(string url)
        {
            throw new NotImplementedException();
        }
    }

    public class ImageContent
    {

    }

    public class ImageLoaderFactory
    {
       public static ImageContent? Create(string url)
        {
            var urlLower = url.ToLower();
            if(urlLower.EndsWith(".jpg"))
                return (new JPGImageLoader()).Load(url);
            if(urlLower.EndsWith(".bmp"))
                return (new BMPImageLoader()).Load(url);
            return null;
        }
    }
}