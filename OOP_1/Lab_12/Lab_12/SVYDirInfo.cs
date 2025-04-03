﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    //позволяет получить основную информацию о каталоге 
    class SVYDirInfo

    {
        public static void GetDirInfo(string path)
        {
            DirectoryInfo dirInf = new(path);
            if (dirInf.Exists)
            {
                Console.WriteLine("Имя каталога: {0}", dirInf.Name);
                Console.WriteLine("Полный путь: {0}", dirInf.FullName);
                Console.WriteLine("Время создания: {0}", dirInf.CreationTime);
                Console.WriteLine("Корневой каталог: {0}", dirInf.Root);
                Console.WriteLine("Родительский каталог: {0}", dirInf.Parent);
                Console.WriteLine("Количество файлов: {0}", dirInf.GetFiles().Length);
                Console.WriteLine("Количество подкаталогов: {0}", dirInf.GetDirectories().Length);
            }
            SVYLog.Write("SVYDirInfo", MethodBase.GetCurrentMethod()!.Name);
        }
    }
}
