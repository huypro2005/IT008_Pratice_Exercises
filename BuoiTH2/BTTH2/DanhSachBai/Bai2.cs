using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BTTH2.DanhSachBai
{
    internal class Bai2
    {

        public void Cau2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập đường dẫn thư mục: ");
            string dir = Console.ReadLine();
            ListDir(dir);
        }
        public void ListDir(string dir)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);
            try
            {
                if (directory.Exists)
                {
                    DirectoryInfo[] dir_folders = directory.GetDirectories();
                    FileInfo[] dir_files = directory.GetFiles();
                    for (int i =0; i< dir_folders.Length; i++)
                    {
                        Console.Write($"{dir_folders[i].LastWriteTime}     {dir_folders[i].Attributes}    {dir_folders[i].Name}\n");
                    }
                    for (int i =0; i< dir_files.Length; i++)
                    {
                        Console.Write($"{dir_files[i].LastWriteTime}     {dir_files[i].Attributes}    {dir_files[i].Name}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"{dir} không tồn tại");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}
