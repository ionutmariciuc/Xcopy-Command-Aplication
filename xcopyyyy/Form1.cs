using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace xcopyyyy
{
    
    public partial class Form1 : Form
    {
        string source, destination, command, command2, options1,auxiliar,folderBrowseSource,folderBrowseDestination;
        string sourcefileName, destinationFileName,backUp,backupMessage,treeCreation,treeCreationMessage, specificDisplayCommand,nume;
        
        List<String> options;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TreeCreation_Click(object sender, EventArgs e)
        {
             nume = "";
            GetSourceDestination();
            foreach (var items in checkedListBox1.CheckedItems)
            {
                A.Text += items.ToString() + " ";
                nume += items.ToString() + " ";
            }

            options1 = nume;
            command += "\"" + source + "\"" + " " + "\"" + destination;
            treeCreationMessage += "\"" + source +"in destination? ";
            A.Text = command+treeCreation;
            ProcessStartInfo ps = new ProcessStartInfo();

            ps.FileName = "Xcopy";
            ps.Arguments = $"\"{source}\" \"{destination}\" {treeCreation}";
            ps.UseShellExecute = false;
            ps.CreateNoWindow = false;
            ps.RedirectStandardOutput = true;
            ps.RedirectStandardError = true;
            string message = "This is the operation: \n\n" + treeCreationMessage;
            string caption = "Do you want to proceed the Tree Creation?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Process process = Process.Start(ps);
            }
        }
    

        //-------------------------------------------------------------------------------------------------------------
        private void btnMove_Click(object sender, EventArgs e)
        {
             nume = "";
            GetSourceDestination();
            foreach (var items in checkedListBox1.CheckedItems)
            {

                A.Text += items.ToString() + " ";
                nume += items.ToString() + " ";
            }
            
            options1 = nume;
            command += "\"" + source + "\"" + " " + "\"" + destination + "\"" + " " + options1;
            command2 = "DELETE"+"\"" + source +" ? " ;
            A.Text = command;

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "Xcopy";
            ps.Arguments = $"\"{source}\" \"{destination}\" {options1}";
            ps.UseShellExecute = false;
            ps.CreateNoWindow = false;
            ps.RedirectStandardOutput = true;
            ps.RedirectStandardError = true;
            string message = "This is the operation: \n\n" + command;
            string caption = "Do you want to proceed?";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Process process = Process.Start(ps);
                string CopySucces = "The  selected files were successfully copied, \n";
                string commandText = CopySucces+"The next step will delete the source to complete the move command: \n\n" + command2;
                string TabText = "DO YOU WANT TO PROCEED?";
                var result1= MessageBox.Show(commandText, TabText, MessageBoxButtons.YesNo);
                
                 if (result1 == System.Windows.Forms.DialogResult.Yes)

                {
                    if (sourceName.Text == folderBrowseSource)
                    {
                        DeleteDirectory(folderBrowseSource);
                    }
                    if(source==sourceName.Text)
                    {
                        File.Delete(source);
                    }
                }
    
           }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
             nume = "";
            GetSourceDestination();
            foreach (var items in checkedListBox1.CheckedItems)
            {
                A.Text += items.ToString() + " ";
                nume += items.ToString() + " ";
            }

            options1 = nume;
            command += "\"" + source + "\"" + " " + "\"" + destination;
            backupMessage += "\"" + source + "\"" + " " + "\"" + destination + backUp;
            A.Text = command+backUp;

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "Xcopy";
            ps.Arguments = $"\"{source}\" \"{destination}\" {backUp}";
            ps.UseShellExecute = false;
            ps.CreateNoWindow = false;
            ps.RedirectStandardOutput = true;
            ps.RedirectStandardError = true;
            string message = "This is the operation: \n\n" + backupMessage;
            string caption = "Do you want to proceed the Back up?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Process process = Process.Start(ps);
            }
        }
    

        //-----------------------------------------------------------------------------------------------------
        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            GetSourceDestination();
          
            OpenFileDialog sourceBrowse = new OpenFileDialog();
            sourceBrowse.ValidateNames = false;
            sourceBrowse.CheckFileExists = false;
            sourceBrowse.CheckPathExists = true;
            sourceBrowse.FileName = "Folder Selection.";
           
               if (sourceBrowse.ShowDialog() == DialogResult.OK)
             {
                 sourceName.Text = sourceBrowse.FileName;
             }
               if (sourceBrowse.FileName != null)
             {
               folderBrowseSource= Path.GetDirectoryName(sourceBrowse.FileName);
                sourcefileName = Path.GetFileName(sourceName.Text);
             }
               if(sourcefileName== auxiliar)
             {
                sourceName.Text = folderBrowseSource;
             }

        }
        //------------------------------------------------------------------------------------------------------------------------------
        private void helpName_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
        
            GetSourceDestination();

            OpenFileDialog destinationBrowse = new OpenFileDialog();
            destinationBrowse.ValidateNames = false;
            destinationBrowse.CheckFileExists = false;
            destinationBrowse.CheckPathExists = true;
            destinationBrowse.FileName = "Folder Selection.";

              if (destinationBrowse.ShowDialog() == DialogResult.OK)
            {
                destinationName.Text = destinationBrowse.FileName;
            }
              if (destinationBrowse.FileName != null)
            {
                folderBrowseDestination = Path.GetDirectoryName(destinationBrowse.FileName);
                destinationFileName = Path.GetFileName(destinationName.Text);
            }
              if (destinationFileName == auxiliar)
            {
                destinationName.Text = folderBrowseDestination;
            }

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnCopy_Click(object sender, EventArgs e)
        {
            nume = "";
            GetSourceDestination();
            foreach (var items in checkedListBox1.CheckedItems)
            {

                A.Text += items.ToString() + " ";
                nume += items.ToString() + " ";
                //options.Add(items.ToString());
            }

            options1 = nume;
            command += "\"" + source + "\"" + " " + "\"" + destination + "\"" + " " + options1;
            A.Text = command;
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "Xcopy";
            ps.Arguments = $"\"{source}\" \"{destination}\" {options1}";
            ps.UseShellExecute = false;
            ps.CreateNoWindow = false;
            ps.RedirectStandardOutput = true;
            ps.RedirectStandardError = true;
            string message = "This is the operation: \n\n" + command;
            string caption = "Do you want to proceed?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Process process = Process.Start(ps);
            }
            //XcopyWithDisplayMessages();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public void GetSourceDestination()
        {
            source = sourceName.Text;
            destination = destinationName.Text;
            command = "Xcopy ";
            auxiliar = "Folder Selection";
            backUp = "/d /y";
            backupMessage = "BACK UP ";
            treeCreation = "/t /e /y";
            treeCreationMessage = "Create tree ";
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
        //------------------------------------------------------------------------------------------------------------------------------------

        void XcopyWithDisplayMessages()

        {
            nume = "";
            GetSourceDestination();
            foreach (var items in checkedListBox1.CheckedItems)
            {

                A.Text += items.ToString() + " ";
                nume += items.ToString() + " ";
                //options.Add(items.ToString());
            }

            specificDisplayCommand = nume;
            switch (specificDisplayCommand)
            {
                case "/w  ":
                    XC_w_command();    
                break;

                default:
                    DefaultXcopyCode();
                break;
                   
            }
        }


        public void DefaultXcopyCode()
        {
            nume = "";
            GetSourceDestination();
            command += "\"" + source + "\"" + " " + "\"" + destination + "\"" + " " + options1;
            A.Text = command;
            ProcessStartInfo ps1 = new ProcessStartInfo();
            ps1.FileName = "Xcopy";
            ps1.Arguments = $"\"{source}\" \"{destination}\" {options1}";
            ps1.UseShellExecute = false;
            ps1.CreateNoWindow = false;
            ps1.RedirectStandardOutput = true;
            ps1.RedirectStandardError = true;
            string message1 = "This is the operation: \n\n" + command;
            string caption1 = "Do you want to proceed?";
            var result1 = MessageBox.Show(message1, caption1, MessageBoxButtons.YesNo);

            if (result1 == System.Windows.Forms.DialogResult.Yes)
            {
                Process process = Process.Start(ps1);
            }
        }
        public void XC_w_command()
        {
             nume = "";
            GetSourceDestination();
            command += "\"" + source + "\"" + " " + "\"" + destination + "\"" + " " + options1;
            A.Text = command;

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "Xcopy";
            ps.Arguments = $"\"{source}\" \"{destination}\" ";
            ps.UseShellExecute = false;
            ps.CreateNoWindow = false;
            ps.RedirectStandardOutput = true;
            ps.RedirectStandardError = true;
            string message = "Press any key to begin copying file(s): \n\n";
            string caption = "Do you want to proceed?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Process process = Process.Start(ps);
            }
        }
   
}
    }
                                                                                                                                                                                   