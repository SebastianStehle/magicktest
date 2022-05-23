// See https://aka.ms/new-console-template for more information
using ImageMagick;

Console.WriteLine("Hello, World!");

using (var imageCollection = new MagickImageCollection())
{
    await imageCollection.ReadAsync("logo.avif");
    await imageCollection.WriteAsync("logo.bmp", MagickFormat.Bmp);
}

using (var image = new MagickImage())
{
    image.Ping("logo.bmp", new MagickReadSettings());
}