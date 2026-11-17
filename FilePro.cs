using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    internal class FilePro
    {
        public static bool SplitNamesToSeparatedFiles(string filePath, string directoryPat, out string errStr, ref int numberStudents)
        {
            errStr = "";

            //בדיקה האם הקובץ קיים 
            if (!File.Exists(filePath))
            {
                errStr = "File not found";
                return false;
            }


            //בדיקה אם התיקיה קיימת, אם לא יוצרים אותה
            if (Directory.Exists(directoryPat))
                Directory.CreateDirectory(directoryPat);


            //מכניס למשתנה את מה שכתוב באותו נתיב
            string Pro = File.ReadAllText(filePath);

            string[] SplitNames = Pro.Split(',');
            for (int i = 0; i < SplitNames.Length; i++)
            {
                string name = SplitNames[i].Trim();

                //מחברת את הנתיבים לנתיב אחד
                string pathtxt = Path.Combine(directoryPat, name + ".txt");

                //מקבלת נתיב וכותבת לתוכו
                File.WriteAllText(pathtxt, "");
                numberStudents++;

            }
            return true;    
        }
    }
}