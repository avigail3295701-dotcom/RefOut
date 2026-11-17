using System.ComponentModel.Design;
using System.Diagnostics.Tracing;

namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            string error = "";


            //ניתוב התיקיה
            string folderPath = "C:\\Users\\user1\\Desktop\\לימודים- שנה ב\\מתקדם C#\\שיעור 5\\RefOut\\Products";
            folderPath.Trim().Trim('"');
            Console.WriteLine(folderPath);

            //ניתוב הקובץ
            string filePath = "C:\\Users\\user1\\Desktop\\לימודים- שנה ב\\מתקדם C#\\שיעור 5\\products names.txt";
            filePath.Trim().Trim('"');


            bool success = FilePro.SplitNamesToSeparatedFiles(filePath, folderPath, out error, ref count);
            if (success == true)
                Console.WriteLine("created" + count + "files");
            else
                Console.WriteLine("error");


        }
    }
}
