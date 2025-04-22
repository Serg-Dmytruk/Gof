using Proxy.Proxy;

var image1 = new ProxyImage("file 1");
var image2 = new ProxyImage("file 2");

image1.Display();
image2.Display();

Console.WriteLine("-----------DISPLAYING AGAIN--------------");

image1.Display();
image1.Display();