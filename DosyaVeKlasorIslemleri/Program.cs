using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaVeKlasorIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using System.IO NameSpace'i

            #region FileInfo

            //string txtpath = "C://Alp/nikola.txt";
            //string docxpath = "C://Alp/nikola.docx";

            //FileInfo fileTxt = new FileInfo(txtpath);
            //FileInfo fileDocx = new FileInfo(docxpath);

            //Console.WriteLine("Dosya Var mı");
            //Console.WriteLine("txt = " + fileTxt.Exists);
            //Console.WriteLine("docx = " + fileDocx.Exists);
            //Console.WriteLine();
            //Console.WriteLine("Dosya Uzantısı");
            //Console.WriteLine("txt = " + fileTxt.Extension);
            //Console.WriteLine("docx = " + fileDocx.Extension);
            //Console.WriteLine();
            //Console.WriteLine("Dosya Adı");
            //Console.WriteLine("txt = " + fileTxt.Name);
            //Console.WriteLine("docx = " + fileDocx.Name);
            //Console.WriteLine();
            //Console.WriteLine("Dosya Yolu");
            //Console.WriteLine("txt = " + fileTxt.FullName);
            //Console.WriteLine("docx = " + fileDocx.FullName);
            //Console.WriteLine();
            //Console.WriteLine("Oluşturma Zamanı");
            //Console.WriteLine("txt = " + fileTxt.CreationTime);
            //Console.WriteLine("docx = " + fileDocx.CreationTime);
            //Console.WriteLine();
            //Console.WriteLine("Klasör Adı");
            //Console.WriteLine("txt = " + fileTxt.Directory);
            //Console.WriteLine("docx = " + fileDocx.Directory);
            //Console.WriteLine();
            //Console.WriteLine("Sadece Okunabilir Dosya mı?");
            //Console.WriteLine("txt = " + fileTxt.IsReadOnly);
            //Console.WriteLine("docx = " + fileDocx.IsReadOnly);

            #endregion

            #region DirectoryInfo

            //string path = "C://Alp";

            //DirectoryInfo di = new DirectoryInfo(path);

            //Console.WriteLine("Klasör Var mı = " + di.Exists);
            //Console.WriteLine("Klasör Yolu" + di.FullName);
            //Console.WriteLine("Klasör Adı" + di.Name);
            //Console.WriteLine("Oluşturma Tarihi" + di.CreationTime);
            //Console.WriteLine("Son Erişim zamanı = " + di.LastAccessTime);
            //Console.WriteLine("Son Yazma zamanı = " + di.LastWriteTime);
            //Console.WriteLine("Ebeveyn = " + di.Parent);
            //Console.WriteLine("Kök = " + di.Root);
            //Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
            //foreach (FileInfo item in di.GetFiles())
            //{
            //    Console.WriteLine(item.FullName);
            //}
            //foreach (DirectoryInfo item in di.GetDirectories())
            //{
            //    Console.WriteLine(item.FullName);
            //}

            #endregion

            #region Dosya Klasör Oluşturma Ve Silme

            ////FileInfo fi = new FileInfo("C://Alp/benyaptim.txt");
            ////fi.Delete();
            ////if (!fi.Exists)
            ////{
            ////    fi.Create();
            ////}

            //DirectoryInfo di = new DirectoryInfo("C://Alp2/");
            //////di.Create();
            ////di.Delete();

            ////FileInfo[] dosyalar = di.GetFiles();
            //List<FileInfo> dosyalar = di.GetFiles().ToList();

            //foreach (FileInfo item in dosyalar)
            //{
            //    item.Delete();
            //}
            //di.Delete();

            #endregion

            #region Stream Writer

            ////Eğer Dosya Var ise bunu kullanalım
            ////Dosyanın üzerine Yazar
            ////StreamWriter sw = new StreamWriter("C://Alp/benyaptim.txt");
            ////sw.WriteLine("Nabünüz?");
            ////sw.WriteLine("2. satır");
            ////sw.Close();

            //StreamWriter sw = new StreamWriter("C://Alp/benyaptim.txt", true);
            //sw.WriteLine("1. satır");
            //sw.WriteLine("2. satır");
            //sw.WriteLine("3. satır");
            //sw.WriteLine("4. satır");
            //sw.Flush();//Buraya kadar olanları stream üzerine yansıt
            //Console.ReadLine();
            //sw.WriteLine("5. satır");
            //sw.WriteLine("6. satır");
            //sw.WriteLine("7. satır");
            //sw.WriteLine("8. satır");
            //sw.Close();



            #endregion

            #region Stream Reader

            //StreamReader sr = new StreamReader("C://Alp/nikola.txt");
            ////Console.WriteLine(sr.Read());//1 karakter

            ////Console.WriteLine(sr.ReadLine());
            ////Console.WriteLine(sr.ReadLine());
            ////Console.WriteLine(sr.ReadLine());

            //Console.WriteLine(sr.ReadToEnd());

            ////StreamReader sr2 = new StreamReader("C://Alp/nikola.docx");
            ////Console.WriteLine(sr2.ReadToEnd());
            //sr.Close();

            #endregion

            #region FileStream

            //FileStream fs = new FileStream("C://Alp/personeller.txt", FileMode.OpenOrCreate);
            //fs.Close();
            //StreamWriter sw = new StreamWriter("C://Alp/personeller.txt",true);
            //sw.WriteLine("Alp Sarıkışla");
            //sw.Close();


            #endregion

        }
    }
}
