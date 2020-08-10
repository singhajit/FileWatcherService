using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AxpoTable4FileMove
{
    public static class AxpoPontonFileUtility
    {




        //public static void Run()
        //{
        //    string[] args = Environment.GetCommandLineArgs();

        //    using (FileSystemWatcher watcher = new FileSystemWatcher())
        //    {
        //        watcher.Path = ConfigurationManager.AppSettings["ActiveFolder"];
        //        // watcher.IncludeSubdirectories = true;
        //        // Watch for changes in LastAccess and LastWrite times, and
        //        // the renaming of files or directories.
        //        watcher.NotifyFilter = NotifyFilters.LastAccess
        //                             | NotifyFilters.LastWrite
        //                             | NotifyFilters.FileName
        //                             | NotifyFilters.DirectoryName;

        //        // Only watch text files.
        //        watcher.Filter = "*.xml";

        //        // Add event handlers.
        //        watcher.Created += OnChanged;
        //        // Begin watching.
        //        watcher.EnableRaisingEvents = true;

        //        //// Wait for the user to quit the program.
        //        //Console.WriteLine("Press 'q' to quit the sample.");
        //        //while (Console.Read() != 'q') ;
        //    }
        //}
        //private static void OnChanged(object source, FileSystemEventArgs e)
        //{
        //    XmlDocument xmlDoc = new XmlDocument();
        //    xmlDoc.Load(e.FullPath);
        //    XmlNodeList nodeList = xmlDoc.GetElementsByTagName("dataType");
        //    foreach (XmlNode test in nodeList)
        //    {
        //        if (test.InnerXml == "GasCapacity")
        //        {
        //            File.Move(e.FullPath, ConfigurationManager.AppSettings["DestinationFolder"] + e.Name);
        //        }
        //        Console.WriteLine(test.InnerXml);

        //    }
        //}
    }

}