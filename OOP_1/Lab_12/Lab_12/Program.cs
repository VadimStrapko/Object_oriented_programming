

System;

namespace Lab_12
{
    //демонстрирует использование различных функций
    class Program
    {
        static void Main()
        {
            SVYLog.Write("Main", "begin");
            SVYDiskInfo.GetDiskInfo();
            SVYDirInfo.GetDirInfo("D:\\study\\3_sem\\OOP\\Lab_12\\Lab_12\\bin\\Debug\\net6.0");
            SVYFileInfo.GetFileInfo("D:\\study\\3_sem\\OOP\\Lab_12\\Lab_12\\bin\\Debug\\net6.0\\svylogfile.txt");
            SVYFileManager.GetFileAndDir("D:\\");
            SVYFileManager.CreateDirAndFile("D:\\SVYInspect", "D:\\SVYInspect\\svydirinfo.txt");
            SVYFileManager.CopyFile("D:\\SVYInspect\\svydirinfo.txt", "D:\\SVYInspect\\svydirinfoCOPY.txt");
            
            SVYFileManager.CreateDirAndCopyFile("D:\\SVYFlies", ".txt", "D:\\study\\3_sem\\KPO\\SE_Lab17\\Debug\\");
            SVYFileManager.ArchiveFile("D:\\SVYlies", "D:\\SVYInspect");
            SVYLog.Write("Main\n\n", "end");
            Console.WriteLine("Информация из файла:\n");
            SVYLog.ReadAndFind("07.11.2023", "00:00:00", "01:00:00");
            
        }
    }
}
