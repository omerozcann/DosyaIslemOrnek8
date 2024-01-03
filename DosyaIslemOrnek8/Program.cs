using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dosyaların silinmesi
            File.Delete("abc.txt"); //belirtilen dosyayı siler

           //Dosyaların kopyalanması
            File.Copy("d:\\abc.txt", "e:\\abc.txt");//d sürücüsündeki abc.txt yi,
           //e sürücüsüne kopyalar

           //Klasörlerin oluşturulması
            Directory.CreateDirectory("d:\\bozkır myo");

            //Klasörlerin silinmesi
            Directory.Delete("d:\\bozkır myo");
        }
    }
}
