using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Project.COMMON.Tools
{
  public static class ImageUploader
    {
        public static string UploadImage(string serverPath, HttpPostedFileBase file)
        {
            if (file!=null)
            {
                Guid uniqueName = Guid.NewGuid();
                //~/ProjectImages/asdsadasdasdsad
                serverPath = serverPath.Replace("~", string.Empty); //eger gelen serverPath parametresinde ~(tilda) diye bir işaret varsa onu boslukla degiştir.

                string[] fileArray = file.FileName.Split('.'); //burada uzaygemisi.jpg  diye bir veri gelirse Split('.') metodu sayesinde ben bunu ["uzaygemisi"]["jpg"] olarak noktalardan kesip iki elemanlı bir string arraye dönüstürdüm. 

                string extension = fileArray[fileArray.Length - 1].ToLower(); //burada dosya uzantısını yakalayarak onu kücük harflere cevirdik.(ToLower metodu ile)

                string fileName = $"{uniqueName}.{extension}";//Olusturdugumuz Guid tipinkindeki degişkenimizle yakaladıgımız extension'

                //alt tarafta uzantı kontrolü ile dosyanın bir resim olup olmadıgını anlamaya calısıyoruz
                if (extension=="jpg"||extension=="gif"||extension=="png"||extension=="jpeg")
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath+fileName)))
                    {
                        return "Dosya zaten var";
                    }
                    else
                    {
                        string filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);

                        file.SaveAs(filePath);

                        return serverPath + fileName;

                    }
                }
                else
                {
                    return "Resim seçilmedi.Uygulamanın/sitenin kararlılığı açısından seçilmesi önerilir.";
                }

            }
            else
            {
                return "Dosya boş";
            }

           
        }
    }
}