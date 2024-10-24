using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using SRSuite.Properties;

namespace SRSuite.Classes
{
    public class DirectoryController
    {

        private MainFrm mainFrm;
        private ImageList imageList;

        public DirectoryController(MainFrm Sender)
        {
            this.mainFrm = Sender;

            this.imageList = new ImageList();
            imageList.Images.Add("folder", Resources.yellow_folder_enabled);
            imageList.Images.Add("file", Resources.blue_file_enabled);
        }


        public void updateDirectoryLists(DirectoryInfo newDir)
        {
            //this.getDirectoryAccess(newDir);

            DirectoryInfo[] d = this.getDirectories(newDir.FullName);
            if(d == null)
                return;
            FileInfo[] f = this.getFiles(newDir.FullName);
            if(f == null)
                return;

            this.mainFrm.core.currentDir = newDir;
            this.mainFrm.directoryListViewLeft.SuspendLayout();
            this.mainFrm.directoryListViewRight.SuspendLayout();
            this.mainFrm.directoryListViewLeft.Items.Clear();
            this.mainFrm.directoryListViewRight.Items.Clear();

            this.addTraversalItems();
            if(this.mainFrm.core.VisibleFolder)
            {
                this.addDirectoryItems(d);
            }
            if(this.mainFrm.core.VisibleFiles)
            {
                this.addFileItems(f);
            }

            this.mainFrm.core.refreshPathInfo();
            this.mainFrm.directoryListViewLeft.ResumeLayout(true);
            this.mainFrm.directoryListViewRight.ResumeLayout(true);
            this.mainFrm.directoryListViewLeft.Refresh();
            this.mainFrm.directoryListViewRight.Refresh();
            this.mainFrm.Refresh();
        }

        public void getDirectoryAccess(DirectoryInfo newDir)
        {
            DirectorySecurity myDirectorySecurity = newDir.GetAccessControl();
            string User = Environment.UserDomainName + "\\" + Environment.UserName;
            myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.Read, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            //myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, FileSystemRights.Read, AccessControlType.Allow));

            newDir.SetAccessControl(myDirectorySecurity);
        }


        private void addTraversalItems()
        {
            ListViewItem goRoot = new ListViewItem("");
            goRoot.ImageKey = "Folder";
            goRoot.SubItems.Add(".");
            goRoot.SubItems.Add("");
            goRoot.SubItems.Add("");
            goRoot.SubItems.Add("");

            ListViewItem goParent = new ListViewItem("");
            goParent.SubItems.Add("..");
            goParent.SubItems.Add("");
            goParent.SubItems.Add("");
            goParent.SubItems.Add("");

            ListViewItem goRootLeft = goRoot;
            ListViewItem goRootRight = (ListViewItem)goRoot.Clone();

            ListViewItem goParentLeft = goParent;
            ListViewItem goParentRight = (ListViewItem)goParent.Clone();

            this.mainFrm.directoryListViewLeft.Items.Add(goRootLeft);
            this.mainFrm.directoryListViewRight.Items.Add(goRootRight);
            this.mainFrm.directoryListViewLeft.Items.Add(goParentLeft);
            this.mainFrm.directoryListViewRight.Items.Add(goParentRight);

            this.mainFrm.directoryListViewLeft.RedrawItems(0, 1, false);
            this.mainFrm.directoryListViewLeft.Refresh();
            this.mainFrm.Refresh();
        }

        private void addDirectoryItems(DirectoryInfo[] d)
        {
            foreach(DirectoryInfo dir in d)
            {
                ListViewItem dirItem = new ListViewItem("");
                dirItem.Checked = true;
                dirItem.SubItems.Add(dir.Name);     // Name
                dirItem.SubItems.Add("Ordner");     // Type
                dirItem.SubItems.Add("");           // Size
                dirItem.SubItems.Add(dir.LastWriteTime.ToString("dd.MM.yyyy HH:mm"));  // Date

                ListViewItem dirItemLeft = dirItem;
                ListViewItem dirItemRight = (ListViewItem) dirItem.Clone();
                // Apply rules for preview list
                dirItemRight.SubItems[1].Text = this.mainFrm.core.applyRulesOnStr(dir.Name, dirItem.Index, this.mainFrm.core.renameFileExt);     // @todo verify dirItem.Index is the correct value
                // Highlight items renamed in preview
                if (dirItemLeft.SubItems[1].Text != dirItemRight.SubItems[1].Text)
                {
                    dirItemLeft.ForeColor = this.mainFrm.highlightColor1;
                    dirItemRight.ForeColor = this.mainFrm.highlightColor1;
                }

                this.mainFrm.directoryListViewLeft.Items.Add(dirItemLeft);
                this.mainFrm.directoryListViewRight.Items.Add(dirItemRight);
            }
        }

        private void addFileItems(FileInfo[] f)
        {
            foreach (FileInfo file in f)
            {
                ListViewItem fileItem = new ListViewItem("");
                fileItem.Checked = true;
                fileItem.SubItems.Add(file.Name);     // Name
                fileItem.SubItems.Add(file.Extension);     // Type
                fileItem.SubItems.Add(this.calcFileSize(file.Length));           // Size
                fileItem.SubItems.Add(file.LastWriteTime.ToString("dd.MM.yyyy HH:mm"));  // Date

                ListViewItem fileItemLeft = fileItem;
                ListViewItem fileItemRight = (ListViewItem)fileItem.Clone();
                // Apply rules for preview list
                fileItemRight.SubItems[1].Text = this.mainFrm.core.applyRulesOnStr(file.Name, fileItem.Index, this.mainFrm.core.renameFileExt);     // @todo verify fileItem.Index is the correct value
                // Highlight items renamed in preview
                if (fileItemLeft.SubItems[1].Text != fileItemRight.SubItems[1].Text)
                {
                    fileItemLeft.ForeColor = this.mainFrm.highlightColor1;
                    fileItemRight.ForeColor = this.mainFrm.highlightColor1;
                }

                this.mainFrm.directoryListViewLeft.Items.Add(fileItemLeft);
                this.mainFrm.directoryListViewRight.Items.Add(fileItemRight);
            }
        }

        private string calcFileSize(long bytes)
        {
            long kbytes = bytes / 1024;
            long mbytes = kbytes / 1024;
            string size = "";

            if (mbytes < 1)
            {
                size = kbytes.ToString() + " KB";
            } else
            {
                size = mbytes.ToString() + " MB";
            }

            return size;
        }

        private DirectoryInfo[] getDirectories(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);

            try
            {
                return dInfo.GetDirectories();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "Fehler", MessageBoxButtons.OK);
            }

            return null;
        }

        private FileInfo[] getFiles(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);

            try
            {
                return dInfo.GetFiles();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "Fehler", MessageBoxButtons.OK);
            }
            return null;
        }

    }
}
