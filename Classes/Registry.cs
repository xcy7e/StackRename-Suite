using Microsoft.Win32;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SRSuite.Classes
{
    internal class Registry
    {

        /// <summary>
        /// Context Menu Integration Reg-Keys
        /// </summary>
        private const string ContextMenuItemName = "startStackRenameSuite";
        private const string ContextMenuCommand = "\\command";

        Form contextFrm;

        /// <param name="contextFrm">Calling Form reference</param>
        public Registry(Form contextFrm)
        {
            this.contextFrm = contextFrm;
        }

        public bool contextMenuIntegration(bool state)
        {
            string contextMenuItemLabel = "StackRename Suite öffnen";   // @todo i18n

            if (state)
            { 
                //this.addRegKey(ContextMenuItemName, contextMenuItemLabel);
                //this.addRegKey(ContextMenuCommand, contextMenuItemLabel);
                if(!Registry.Register("Folder", ContextMenuItemName, contextMenuItemLabel, ContextMenuCommand, Properties.Resources.srsuite_icon1))
                {
                    return false;
                }
            }
            else
            {
                //this.removeRegKey(ContextMenuItemName);
                //this.removeRegKey(ContextMenuCommand);
                if(!Registry.Unregister(ContextMenuItemName, ContextMenuCommand))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Adds a key to registry
        /// </summary>
        /// <param name="key">Key name</param>
        /// <param name="val">Key value</param>
        /// <returns></returns>
        private bool addRegKey(string key, string val)
        {
            RegistryKey regKey = null;
            try
            {
                regKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(key);
                if (regKey != null)
                    regKey.SetValue("", val);
            } catch(Exception ex)
            {
                MessageBox.Show(this.contextFrm, ex.ToString());
                return false;
            } finally
            {
                if (regKey != null)
                    regKey.Close();
            }
            return true;
        }

        /// <summary>
        /// Removes a key from registry
        /// </summary>
        /// <param name="key">Key name</param>
        /// <returns></returns>
        private bool removeRegKey(string key)
        {
            try
            {
                RegistryKey reg = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key);
                if (reg != null)
                {
                    reg.Close();
                    Microsoft.Win32.Registry.ClassesRoot.DeleteSubKey(key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.contextFrm, ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Add key to registry
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="shellKeyName"></param>
        /// <param name="menuText"></param>
        /// <param name="menuCommand"></param>
        /// <param name="menuIcon"></param>
        /// <returns></returns>
        public static bool Register(string fileType, string shellKeyName, string menuText, string menuCommand, byte[] menuIcon)
        {
            RegistryKey regmenu = null;
            //RegistryKey regicon = null;
            RegistryKey regcmd = null;
            
            // create path to registry location
            string regPath = string.Format(@"{0}\shell\{1}",
                                           fileType, shellKeyName);

            try
            {
                string menuEntry = shellKeyName;
                string menuCmd = regPath + menuCommand;
                string menuCmdExecutable = System.Reflection.Assembly.GetEntryAssembly().Location + " \"%1\"";
                string labelText = menuText;

                // ensure app-icon is stored in bin-path
                string execFullPath = System.Reflection.Assembly.GetEntryAssembly().Location;
                string execPath = execFullPath.Replace(System.Reflection.Assembly.GetEntryAssembly().ManifestModule.Name, "");
                File.WriteAllBytes(execPath + "\\contexticon.ico", menuIcon);

                // entry 
                regmenu = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(menuEntry, writable: true);
                if (regmenu != null)
                {
                    regmenu.SetValue("", labelText);
                    // icon
                    string iconPath = execPath + "\\contexticon.ico";
                    regmenu.SetValue("Icon", iconPath + ",0", RegistryValueKind.String);

                    // command
                    regcmd = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(menuCmd);
                    if (regcmd != null)
                        regcmd.SetValue("", menuCmdExecutable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (regmenu != null)
                    regmenu.Close();
                if (regcmd != null)
                    regcmd.Close();

            }
            return true;
        }

        /// <summary>
        /// Remove Key from registry
        /// </summary>
        /// <param name="shellKeyName"></param>
        /// <param name="menuCommand"></param>
        /// <returns></returns>
        public static bool Unregister(string shellKeyName, string menuCommand)
        {

            // create path to registry location
            string regPath = string.Format(@"{0}\shell\{1}",
                                           "Folder", shellKeyName);
            string menuEntry = regPath;
            string menuCmd = menuEntry + "\\command";

            try
            {
                RegistryKey reg = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(menuCmd, writable: true);
                if (reg != null)
                {
                    reg.Close();
                    Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(menuCmd);
                }
                reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(regPath, writable: true);
                if (reg != null)
                {
                    reg.Close();
                    Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(regPath, false);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                return true;
            }
        }

    }
}
