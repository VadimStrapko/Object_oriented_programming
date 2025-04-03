using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    //позволяет получить основную информацию о дисках компьютера
    public static class SVYDiskInfo
    {
        public static void GetDiskInfo()
        {
            foreach(var inff in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Имя диска: {inff.Name}");
                Console.WriteLine($"Свободное место на диске: {inff.AvailableFreeSpace}");
                Console.WriteLine($"Файловая система: {inff.DriveFormat}");
                if (inff.IsReady)
                {
                    Console.WriteLine($"Объём диска: {inff.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {inff.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {inff.VolumeLabel}");
                }
            }
            SVYLog.Write("SVYDiskInfo", MethodBase.GetCurrentMethod()!.Name);
        }
    }
}
