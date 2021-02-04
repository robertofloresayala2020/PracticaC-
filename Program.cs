using System;
using System.IO;


namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream ("Archivo.txt",FileMode.Create,FileAccess.Write,FileShare.None);

            BinaryWriter writer = new BinaryWriter(fs);
            writer.Write("A");
            writer.Write(200);
            writer.Write("true");

            fs.Close();
            
            FileStream ds = new FileStream ("Archivo.txt",FileMode.Open,FileAccess.Read,FileShare.None);
            BinaryReader reader  = new BinaryReader(ds);

            string letra1 =reader.ReadString();
            int letra2= reader.ReadInt32();
            bool letra3= reader.ReadBoolean();

            reader.Close();
            Console.WriteLine("{0}  - {1} -  {2}",letra1,letra2,letra3);


            Console.WriteLine("Hello World!");
        }
    }
}
