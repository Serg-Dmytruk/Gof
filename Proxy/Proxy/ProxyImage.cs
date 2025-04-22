using Proxy.RealSubject;

namespace Proxy.Proxy;

public class ProxyImage : IImage
{
    private Image _image;
    private readonly string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        if (_image is null)
        {
            Console.WriteLine($"Show low res placeholder {_fileName}");
            Console.WriteLine("""
                                    .-.
                                   (o.o)
                                    |=|
                                   __|__
                                 //.=|=.\\
                                // .=|=. \\
                                \\ .=|=. //
                                 \\(_=_)//
                                  (:| |:)
                                   || ||
                                   () ()
                                   || ||
                                   || ||
                              l42 ==' '==
                              """);

            _image = new Image(_fileName);
            return;
        }

        _image.Display();
    }
}