namespace Axpo_Table4FileMove
{
    partial class ProjectInstaller
    {
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
            this.AxpoProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.AxposerviceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // AxpoProcessInstaller
            // 
            this.AxpoProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.AxpoProcessInstaller.Password = null;
            this.AxpoProcessInstaller.Username = null;
            // 
            // AxposerviceInstaller
            // 
            this.AxposerviceInstaller.ServiceName = "AXPOFileMoveUtility1";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.AxpoProcessInstaller,
            this.AxposerviceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller AxpoProcessInstaller;
        private System.ServiceProcess.ServiceInstaller AxposerviceInstaller;
    }
}