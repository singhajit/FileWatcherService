using AxpoTable4FileMove;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Axpo_Table4FileMove
{
    public partial class FileMoveUtility : ServiceBase
    {
        public FileMoveUtility()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string path = ConfigurationManager.AppSettings["ActiveFolder"];
            
            if (Directory.Exists(path))
            {
                FSWatcher.Path = path;
            }
            else
            {
                Exception customEx = new Exception(@"Path To Watch Does Not Exists, Setting Default Path To Watch To C:\");
                //FSWatcher.Path = @"C\";
            }
        }

        protected override void OnStop()
        {
            FSWatcher.EnableRaisingEvents = false;
            FSWatcher.Dispose();
        }


       

        //[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        //private static void Run()
        //{
        //    string[] args = Environment.GetCommandLineArgs();

        //    using (FileSystemWatcher watcher = new FileSystemWatcher())
        //    {
        //        //watcher.Path = ConfigurationManager.AppSettings["ActiveFolder"];
        //        //// watcher.IncludeSubdirectories = true;
        //        //// Watch for changes in LastAccess and LastWrite times, and
        //        //// the renaming of files or directories.
        //        //watcher.NotifyFilter = NotifyFilters.LastAccess
        //        //                     | NotifyFilters.LastWrite
        //        //                     | NotifyFilters.FileName
        //        //                     | NotifyFilters.DirectoryName;

        //        //// Only watch text files.
        //        //watcher.Filter = "*.xml";

        //        //// Add event handlers.
        //        //watcher.Created += OnChanged;
        //        //// Begin watching.
        //        //watcher.EnableRaisingEvents = true;

        //        ////// Wait for the user to quit the program.
        //        ////Console.WriteLine("Press 'q' to quit the sample.");
        //        ////while (Console.Read() != 'q') ;
        //    }
       // }

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
        //    // }

        //    // Specify what is done when a file is changed, created, or deleted.
        //    //Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        //}

        //private void AxpofileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        //{
        //    System.Diagnostics.Debugger.Launch();
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
