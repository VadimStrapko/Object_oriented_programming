using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    static class SVYFileManager
    {
        //Получает список файлов и папок с указанного диска
        static public void GetFileAndDir(string NameDisk)
        {
            if (NameDisk is null)
            {
                throw new ArgumentNullException(nameof(NameDisk));
            }

            DirectoryInfo di = new(NameDisk);
            FileInfo[] fiArr = di.GetFiles();
            Console.WriteLine();
            Console.WriteLine($"Файлы диска {NameDisk} :");
            string sourceFilePath = @"C:\SourceFolder\SourceFile.txt";
            string destinationFilePath = @"C:\DestinationFolder\DestinationFile.txt";

            foreach (FileInfo fi in fiArr)
                Console.WriteLine(fi);

            Console.WriteLine($"\nПапки диска {NameDisk} :");
            DirectoryInfo[] fiArr2 = di.GetDirectories();

            foreach (DirectoryInfo fi in fiArr2)
                Console.WriteLine(fi);

            SVYLog.Write("SVYFileManager", MethodBase.GetCurrentMethod()!.Name);
        }
        //Создает новую директорию с указанным именем
        static public void CreateDirAndFile(string NameDir, string NameFile)
        {
            if (NameDir is null)
            {
                throw new ArgumentNullException(nameof(NameDir));
            }

            if (NameFile is null)
            {
                throw new ArgumentNullException(nameof(NameFile));
            }

            DirectoryInfo dirInfo = new(NameDir);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (StreamWriter writer = new(NameFile, false))
            {
                writer.WriteLine("Сохранённая информация)");
            }

            SVYLog.Write("SVYFileManager", MethodBase.GetCurrentMethod()!.Name);
        }
        //Копирует файл
        static public void CopyFile(string pathFrom, string pathTo)
        {
            if (pathFrom is null)
            {
                throw new ArgumentNullException(nameof(pathFrom));
            }

            if (pathTo is null)
            {
                throw new ArgumentNullException(nameof(pathTo));
            }

            FileInfo fi = new(pathTo);

            if (!fi.Exists)
                File.Copy(pathFrom, pathTo);

            SVYLog.Write("SVYFileManager", MethodBase.GetCurrentMethod()!.Name);
        }
        //Удаляет файл
        static public void DelFile(string path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            FileInfo fi = new(path);

            if (fi.Exists)
            {
                File.Delete(path);
            }

            SVYLog.Write("SVYFileManager", MethodBase.GetCurrentMethod()!.Name);
        }
        //Создает новую директорию с указанным именем
        static public void CreateDirAndCopyFile(string nameDir, string FileExtenshion, string pathFrom)
        {
            if (nameDir is null)
            {
                throw new ArgumentNullException(nameof(nameDir));
            }

            if (FileExtenshion is null)
            {
                throw new ArgumentNullException(nameof(FileExtenshion));
            }

            if (pathFrom is null)
            {
                throw new ArgumentNullException(nameof(pathFrom));
            }

            DirectoryInfo dirFrom = new(pathFrom);
            DirectoryInfo dirTo = new(nameDir);
            dirTo.Create();
            var files = dirFrom.GetFiles();

            foreach (FileInfo f in dirTo.GetFiles())
            {
                f.Delete();
            }
            try
            {
                

                // Перемещение файла
                File.Move(sourceFilePath, destinationFilePath);

                Console.WriteLine("Файл успешно перемещен.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перемещении файла: {ex.Message}");
            }

            foreach (var file in files)
            {

                if (FileExtenshion.Length == 0 ||
                    FileExtenshion.Contains(file.Extension))
                {
                    file.CopyTo(dirTo.FullName + "\\" + file.Name);
                }
            }

            SVYLog.Write("SVYFileManager", MethodBase.GetCurrentMethod()!.Name);

        }
        //Создает архив с содержимым указанной директории pathF
        async static public void ArchiveFile(string pathF, string targetFolder)
        {
            if (pathF is null)
            {
                throw new ArgumentNullException(nameof(pathF));
            }

            if (targetFolder is null)
            {
                throw new ArgumentNullException(nameof(targetFolder));
            }

            DirectoryInfo dir = new(pathF);
            string path = $"{dir.FullName}.zip";

            if (Directory.Exists(path))
            {
                Console.WriteLine("\nАрхив уже создан!");
            }
            else
            {
                ZipFile.CreateFromDirectory(dir.FullName, path);
            }

            try
            {
                ZipFile.ExtractToDirectory(path, targetFolder);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Файлы уже разархивированы!\n");
            }


            SVYLog.Write("SVYFileManager", "Archive File");

        }
    }
}
