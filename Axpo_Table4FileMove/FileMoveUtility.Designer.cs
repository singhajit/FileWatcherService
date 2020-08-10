using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace Axpo_Table4FileMove
{
    partial class FileMoveUtility
    {

        private System.IO.FileSystemWatcher FSWatcher;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FSWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.FSWatcher)).BeginInit();
            // 
            // FSWatcher
            // 
            this.FSWatcher.EnableRaisingEvents = true;
            //this.FSWatcher.Filter = ".xml";
            this.FSWatcher.IncludeSubdirectories = true;
            this.FSWatcher.NotifyFilter = ((System.IO.NotifyFilters)((((((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName)
            | System.IO.NotifyFilters.Attributes)
            | System.IO.NotifyFilters.Size)
            | System.IO.NotifyFilters.LastWrite)
            | System.IO.NotifyFilters.LastAccess)
            | System.IO.NotifyFilters.CreationTime)
            | System.IO.NotifyFilters.Security)));
            this.FSWatcher.Changed += new System.IO.FileSystemEventHandler(this.FSWatcher_Changed);
            this.CanHandlePowerEvent = true;
            this.CanPauseAndContinue = true;
            this.CanShutdown = true;
            this.ServiceName = "FileandSystemWatcher";
            ((System.ComponentModel.ISupportInitialize)(this.FSWatcher)).EndInit();

        }

        #endregion

        private void FSWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                if (File.Exists(e.FullPath) && e.FullPath.Contains(ConfigurationManager.AppSettings["IgnoreFolder"]))
                {
                    return;
                }
                AxpoFileWatcher(e);
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
                appLog.Source = "AXPoFileUtility";
                appLog.WriteEntry(ex.Message.ToString());
            }
        }

        private static void AxpoFileWatcher(FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(e.FullPath);
                XmlNodeList nodeList = xmlDoc.GetElementsByTagName("dataType");
                foreach (XmlNode test in nodeList)
                {
                    if (test.InnerXml == "GasCapacity")
                    {
                        FileInfo file = new FileInfo(e.FullPath);
                        if (File.Exists(ConfigurationManager.AppSettings["DestinationFolder"] + file.Name))
                        {
                            File.Delete(ConfigurationManager.AppSettings["DestinationFolder"] + file.Name);
                        }
                        File.Move(e.FullPath, ConfigurationManager.AppSettings["DestinationFolder"] + file.Name);
                    }
                }
            }
        }
    }
}
