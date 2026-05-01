using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace CS3502P3
{
    public partial class Form1 : Form
    {
        //Holds the current folder user is in
        SystemFolder currentFolder;
        //holds the Current directory address
        String currentDir;
        //Holds the root folder
        SystemFolder mainFolder;
        //Holder that stores the file being edited
        SystemFile holder;

        /*
         * GUI code
         */


        //initializes form
        public Form1()
        {
            InitializeComponent();
            mainFolder = new SystemFolder("Main", "Main");
            currentFolder = mainFolder;
            currentDir = "Main";
            textBox1.Text = currentDir;
            panel2.Visible = false;
            button7.Visible = false;
            listView1.SmallImageList = imageList1;
            listView1.FullRowSelect = true;
            listView1.HideSelection = false;
            button7.Visible = false;
            listView1.ItemActivate += listView1_ItemActivate;
        }

        //allows user to open folder by double clicking it
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selected = listView1.SelectedItems[0];

            int index = listView1.Items.IndexOf(selected);
            Item clickedItem = currentFolder.getContents()[index];

            if (clickedItem is SystemFolder folder)
            {
                currentFolder = folder;
                updateTable();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //shows pannel that prompts user to input name for new file/folder
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Please input file name:";
            panel2.Visible = true;

        }

        //Prompts user to rename file/folder. Checks if it is valid, renames the file/folder, then updates table
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error:\nPlease select a item");
                return;
            }
            else if (listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Error:\nPlease select only one item to rename");
                return;
            }

            int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            Item itemRenaming = currentFolder.getContents()[index];

            ListViewItem selected = listView1.SelectedItems[0];

            String oldName = selected.Text;

            string newName = Microsoft.VisualBasic.Interaction.InputBox(
        "Enter new name:",
        "Rename",
        oldName);

            if (itemRenaming is SystemFolder)
            {
                if (!fileOrFolder(newName))
                {
                    if (isValidFileName(newName))
                    {
                        itemRenaming.setName(newName);
                        MessageBox.Show("Item renamed successfully!");
                        updateTable();
                        return;
                    }
                    return;
                }
                MessageBox.Show("Error:\nPlease enter a valid name for a folder");
                return;
            }
            else if (itemRenaming is SystemFile)
            {
                if (fileOrFolder(newName))
                {
                    if (isValidFileName(newName))
                    {
                        itemRenaming.setName(newName);
                        MessageBox.Show("Item renamed successfully!");
                        updateTable();
                    }
                    return;
                }
                MessageBox.Show("Error:\nPlease enter a valid name for a file");
                return;
            }

        }

        //Stores every item selected in an array and deletes them. 
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error:\nPlease select a item");
                return;
            }

            DialogResult result = MessageBox.Show(
       $"Are you sure you want to delete {listView1.SelectedItems.Count} item(s)?",
       "Confirm Delete",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   );

            if (result != DialogResult.Yes)
            {
                return;
            }

            List<Item> toDelete = new List<Item>();
            foreach (ListViewItem selected in listView1.SelectedItems)
            {
                int index = listView1.Items.IndexOf(selected);
                toDelete.Add(currentFolder.getContents()[index]);
            }

            foreach (Item item in toDelete)
            {
                currentFolder.getContents().Remove(item);
            }

            updateTable();

            MessageBox.Show("Item(s) successfully deleted");

        }

        //Reads file contents and displays to user. User cannot edit this, it is read only. 
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error:\nPlease select a file to view");
                return;
            }
            else if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error:\nPlease select only one file to view");
                return;
            }

            ListViewItem selected = listView1.SelectedItems[0];
            int index = listView1.Items.IndexOf(selected);

            Item item = currentFolder.getContents()[index];

            if (item is SystemFolder)
            {
                MessageBox.Show("Error:\nFolder cannot be read");
                return;
            }

            SystemFile file = (SystemFile)(item);

            textBox2.Text = file.read();
            panel3.Visible = true;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button10.Visible = false;
        }

        //reads file and displays to user. User can edit this and when they make changes and exit, those changes are saved. 
        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error:\nPlease select a file to view");
                return;
            }
            else if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error:\nPlease select only one file to view");
                return;
            }

            ListViewItem selected = listView1.SelectedItems[0];
            int index = listView1.Items.IndexOf(selected);

            Item item = currentFolder.getContents()[index];

            if (item is SystemFolder)
            {
                MessageBox.Show("Error:\nFolder cannot be read");
                return;
            }

            SystemFile file = (SystemFile)(item);
            holder = file;

            textBox4.Text = file.read();
            panel4.Visible = true;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button10.Visible = false;
        }

        //closes panel and goes back to file manager
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Checks if the file name inputted is valid, where it then creates and stores the file/folder and displays it in the table. 
        private void button8_Click(object sender, EventArgs e)
        {
            if (isValidFileName(textBox3.Text))
            {
                if (fileOrFolder(textBox3.Text))
                {
                    currentFolder.addFile(textBox3.Text, currentDir);
                    MessageBox.Show("File created successfully!");

                    ListViewItem temp = new ListViewItem(textBox3.Text);
                    temp.ImageIndex = 1;
                    temp.SubItems.Add(getFileType(textBox3.Text));
                    temp.SubItems.Add(DateTime.Now.ToString("MM/dd/yy hh:mm tt"));
                    temp.SubItems.Add("0 b");

                    listView1.Items.Add(temp);
                }
                else
                {
                    currentFolder.addFolder(textBox3.Text, currentDir);
                    MessageBox.Show("Folder created successfully!");

                    ListViewItem temp = new ListViewItem(textBox3.Text);
                    temp.ImageIndex = 0;
                    temp.SubItems.Add("Folder");
                    temp.SubItems.Add(DateTime.Now.ToString("MM/dd/yy hh:mm tt"));
                    temp.SubItems.Add(" ");

                    listView1.Items.Add(temp);
                }
                textBox3.Text = "";
                panel2.Visible = false;
            }

        }

        //Closes input file name pannel
        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textBox3.Text = "";
        }

        //Back button functionality. Goes to the previous folder
        private void button7_Click_1(object sender, EventArgs e)
        {
            string[] parts = currentDir.Split('/', StringSplitOptions.RemoveEmptyEntries);

            String newDir = string.Join('/', parts.Take(parts.Length - 1));

            SystemFolder folder = (SystemFolder)directorySearch(newDir);

            if (folder == null)
            {
                MessageBox.Show("Error:\nCould not locate parent folder.");
                return;
            }

            currentFolder = folder;
            currentDir = newDir;

            updateTable();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //When using the search bar, when the user leaves the search bar, the bar goes back to what it was before
        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            textBox1.Text = currentDir;
        }

        //when the user presses enter on the search bar, the program searches for the adress
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                SystemFolder folder = (SystemFolder)directorySearch(textBox1.Text);

                if (folder == null)
                {
                    MessageBox.Show("Error:\nDirectory does not exist");
                    return;
                }

                currentFolder = folder;
                currentDir = textBox1.Text;
                updateTable();
            }
        }

        //When the read button is clicked, show the panel that displays the contents of the file
        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button10.Visible = true;
        }

        //when the download button is clicked, download the file with its contents onto computer
        private void button10_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error:\nPlease select an item to download");
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select download location";
                if (folderDialog.ShowDialog() != DialogResult.OK)
                    return;

                string targetFolder = folderDialog.SelectedPath;

                List<SystemFile> filesToDownload = new List<SystemFile>();

                foreach (ListViewItem selected in listView1.SelectedItems)
                {
                    int index = listView1.Items.IndexOf(selected);
                    Item item = currentFolder.getContents()[index];

                    if (item is SystemFile file)
                    {
                        filesToDownload.Add(file);
                    }
                }

                foreach (SystemFile file in filesToDownload)
                {
                    string filePath = Path.Combine(targetFolder, file.getName());

                    try
                    {
                        File.WriteAllText(filePath, file.read());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to download '{file.getName()}':\n{ex.Message}");
                    }
                }

                MessageBox.Show("Download complete");
            }
        }

        //
        private void button12_Click(object sender, EventArgs e)
        {
            holder.update(textBox4.Text);
            panel4.Visible = false;
            updateTable();

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button10.Visible = true;
        }


        /*
         * Helper Methods
         */


        //searches through the tree to find the directory address. Returns the last folder in the address
        public Item directorySearch(String directory)
        {
            string[] parts = directory.Split('/', StringSplitOptions.RemoveEmptyEntries);

            SystemFolder current = mainFolder;

            foreach (String part in parts)
            {
                if (part.Equals("Main"))
                {
                    continue;
                }

                bool found = false;
                foreach (Item item in current.getContents())
                {
                    if (item is SystemFolder folder && folder.getName().Equals(part))
                    {
                        current = folder;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    return null;
                }

            }

            return (SystemFolder)current;
        }

        //Updates the table by removing everything on it and replacing it with ever item in the global variable "currentFolder" 
        public void updateTable()
        {
            listView1.Items.Clear();

            foreach (Item item in currentFolder.getContents())
            {
                ListViewItem row = new ListViewItem(item.getName());

                if (item is SystemFolder subfolder)
                {
                    row.ImageIndex = 0;
                    row.SubItems.Add("Folder");
                    row.SubItems.Add(subfolder.getDateModified());
                    row.SubItems.Add("");
                }
                else if (item is SystemFile file)
                {
                    row.ImageIndex = 1;
                    row.SubItems.Add(file.getFileType());
                    row.SubItems.Add(file.getDateModified());
                    row.SubItems.Add(file.getSize().ToString() + " b");
                }

                listView1.Items.Add(row);
            }

            currentDir = currentFolder.getDirectory();
            textBox1.Text = currentDir;

            if (!currentDir.Equals("Main"))
            {
                button7.Visible = true;
            }
            else
            {
                button7.Visible = false;
            }
        }

        //checks if the file name is valid by checking for duplicates or if it is empty
        public bool isValidFileName(String fileName)
        {
            if (fileName == null)
            {
                MessageBox.Show("Error:\nSomething went wrong. Please try again.");
                return false;
            }
            else if (fileName.Length == 0)
            {
                MessageBox.Show("Error:\nPlease enter a name.");
                return false;
            }

            foreach (Item file in currentFolder.getContents())
            {
                if (file.getName().Equals(fileName))
                {
                    if (file.getIsFile())
                    {
                        MessageBox.Show("Error:\nThere is another file with that name");
                    }
                    else
                    {
                        MessageBox.Show("Error:\nThere is another folder with that name");

                    }
                    return false;
                }
            }
            return true;
        }

        //Returns true if the item is a file or false if it is a folder
        public bool fileOrFolder(String fileName)
        {
            for (int i = fileName.Length - 1; i >= 0; i--)
            {
                if (fileName[i] == '.')
                {
                    return true;
                }
            }

            return false;
        }

        //returns the file type
        public String getFileType(String fileName)
        {
            for (int i = fileName.Length - 1; i >= 0; i--)
            {
                if (fileName[i].Equals('.'))
                {
                    return fileName.Substring(i);
                }
            }
            return null;
        }


        /*
         * Classes
         */


        //data structure for files and folders. Parent class of SystemFile and SystemFolder that stores common variables. 
        public class Item
        {
            private String name;
            private String directory;
            private bool isFile;
            private String dateModified;

            public Item(String newName, String newDirectory, bool newIsFile)
            {
                name = newName;
                directory = newDirectory;
                isFile = newIsFile;
                dateModified = DateTime.Now.ToString("MM/dd/yy hh:mm tt");
            }

            public String getName()
            {
                return name;
            }
            public void setName(String newName)
            {
                name = newName;
            }

            public String getDirectory()
            {
                return directory;
            }

            public bool getIsFile()
            {
                return isFile;
            }

            public String getDateModified()
            {
                return dateModified;
            }

            public void setDateModified(String newDateModified)
            {
                dateModified = newDateModified;
            }
        }

        //Data structure for file. Contains the varaibles contents, fileType, and size in bits. 
        public class SystemFile : Item
        {
            private String contents;
            private String fileType;
            private int size;


            public SystemFile(String name, String fileDirectory) : base(name, fileDirectory, true)
            {
                setFileType();

                contents = "";
                size = 0;
            }

            public void update(String updatedContents)
            {
                contents = updatedContents;
                size = updatedContents.Length * 2;
            }

            public String read()
            {
                return contents;
            }

            public String getFileType()
            {
                return fileType;
            }

            public void setFileType()
            {
                for (int i = getName().Length - 1; i >= 0; i--)
                {
                    if (getName()[i].Equals('.'))
                    {
                        fileType = getName().Substring(i);
                    }
                }
            }

            public int getSize()
            {
                return size;
            }

            public void setSize(int newSize)
            {
                size = newSize;
            }

        }

        //Data structure for folder. Contains the variable contents, which sets up a tree. 
        public class SystemFolder : Item
        {
            private List<Item> contents;

            public SystemFolder(String newName, String folderDirectory) : base(newName, folderDirectory, false)
            {
                contents = new List<Item>();
            }

            public List<Item> getContents()
            {
                return contents;
            }

            public void addFolder(String newName, String newDirectory)
            {
                contents.Add(new SystemFolder(newName, newDirectory + "/" + newName));
            }

            public void addFile(String newName, String newDirectory)
            {
                contents.Add(new SystemFile(newName, newDirectory + "/" + newName));

            }


        }
    }
}
