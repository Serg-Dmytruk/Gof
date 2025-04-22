namespace Proxy.RealSubject;

public class Image : IImage
{
    private readonly string _fileName;
    private string _asciiArt;

    private void LoadImageFromDisk()
    {
        Thread.Sleep(3000);
        _asciiArt = """"""
                   /7/Y/^\
                     vuVV|C)|                        __ _
                       \|^ /                       .'  Y '>,
                       )| \)                      / _   _   \
                      //)|\\                      )(_) (_)(|}
                     / ^| \ \                     {  4A   } /
                    //^| || \\                     \uLuJJ/\l
                   >//||| |\\\|                    |3    p)/
                   | """""  7/>l__ _____ ____      /nnm_n//
                   L>_   _-< 7/|_-__,__-)\,__)(".  \_>-<_/D
                   )D" Y "c)  9)       //V     \_"-._.__G G_c__.-__<"/ ( \
                    | | |  |(|               < "-._"> _.G_.___)\   \7\
                     \"=" // |              (,"-.__.|\ \<.__.-" )   \ \
                      '---'  |              |,"-.__"| \!"-.__.-".\   \ \
                        |_;._/              (_"-.__"'\ \"-.__.-".|    \_\
                        )(" V                \"-.__"'|\ \-.__.-".)     \ \
                           (                  "-.__'"\_\ \.__.-"./      \ l
                            )                  ".__"">>G\ \__.-">        V )
                                                   ""  G<\ \_.-"        ./7
                                                        G<\ \          ///
                                                   ___  GD'
                                              /  /             )E_>"
                                            _/  (             |  \()
                                           / \ /              |  |
                                           /\\|               |  |
                                          / '((               |  |
                                         /  / )\              \  |
                                        /  y  \y              |Y |
                                       /  /    (              |  |
                                      L ."     |              |  /
                                     | \(                     |  |
                                      \_|                     |  |
                                      |  \                    { "|
                                      | ||                    |  |
                                      |x||                    \_,/
                                      } ||                    / \'
                                      | ||                    |_/
                                      | (|                    | }\
                                      | ||                    } ||
                                      | ||                    | ||
                                      | ||                    |\||
                                      / ||                    | ||
                                      | ||                    ( |!
                                      | |/                    ) ||
                                    _/   \                    | }|
                                _.-"_ ( )|   jjs              ! ||
                             c_"-_-"_    )                    | ||
                              c,-_-'_--""                     { ||
                              "C(_/"                          \ /|
                                                              (! )
                                                              /| \
                                                             /  |(
                                                            /7||\\
                                                           ()U cUu" 
                   """""";
    }

    public Image(string fileName)
    {
        Console.WriteLine("Initializing Image (Subject)");
        _fileName = fileName;
        LoadImageFromDisk();
    }

    public void Display()
    {
        Console.WriteLine($"$Display image high-quality image \n{_asciiArt}");
    }
}