using System.Reflection;
using System.Xml.Serialization;
using System.Xml;

namespace BotanicalGarden
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            TypeAttributes ta = typeof(Console).Attributes;
            MethodAttributes ma = MethodInfo.GetCurrentMethod().Attributes;
            Console.WriteLine(ta + "\n" + ma);

            string Path = "data.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(Path);

            if (!File.Exists(Path))
            {
                Console.WriteLine("��� ������� � �����: {0}", Path);
                return;
            }
            Console.WriteLine("�������� ��������� ������.");

            try
            {
                MemoryStream rawData = new MemoryStream(File.ReadAllBytes(Path));
                XmlSerializer xmls = new XmlSerializer(typeof(BotanicalG));
                var xmlList = (BotanicalG)xmls.Deserialize(rawData);
                Console.WriteLine("XML o��������.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "������ ��������� XML ������");
            }

            Console.ReadKey();
        }
    }
}