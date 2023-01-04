using System;
using System.IO;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private string _currentFolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearAllFields()
        {
            listBoxFiles.Items.Clear();
            listBoxFolders.Items.Clear();
            textBoxFolder.Text = "";
            textBoxName.Text = "";
            textBoxCreationTime.Text = "";
            textBoxLastAccessTime.Text = "";
            textBoxLastWriteTime.Text = "";
            textBoxFileSize.Text = "";
            checkBoxReadOnly.Checked = false;
            checkBoxHidden.Checked = false;
        }

        private void DisplayFileInfo(string fileName)
        {
            var fileInfo = new FileInfo(fileName);
            if (!fileInfo.Exists)
                throw new FileNotFoundException("Файл не найден: " + fileName);
            
            textBoxName.Text = fileInfo.Name;
            textBoxCreationTime.Text = fileInfo.CreationTime.ToLongTimeString();
            textBoxLastAccessTime.Text = fileInfo.LastAccessTime.ToLongTimeString();
            textBoxLastWriteTime.Text = fileInfo.LastWriteTime.ToLongTimeString();
            textBoxFileSize.Text = fileInfo.Length + " байт";
            checkBoxReadOnly.Checked = fileInfo.IsReadOnly;
            checkBoxHidden.Checked = fileInfo.Attributes.HasFlag(FileAttributes.Hidden);

            textBoxNewPath.Text = fileInfo.FullName;
            
            textBoxNewPath.Enabled = true;
            buttonCopyTo.Enabled = true;
            buttonMoveTo.Enabled = true;
            buttonDelete.Enabled = true;
        }
        
        private void DisplayFolderInfo(string folderName)
        {
            var directoryInfo = new DirectoryInfo(folderName);
            if (!directoryInfo.Exists)
                throw new DirectoryNotFoundException("Папка не найдена: " + folderName);
            
            textBoxName.Text = directoryInfo.Name;
            textBoxCreationTime.Text = directoryInfo.CreationTime.ToLongTimeString();
            textBoxLastAccessTime.Text = directoryInfo.LastAccessTime.ToLongTimeString();
            textBoxLastWriteTime.Text = directoryInfo.LastWriteTime.ToLongTimeString();
            textBoxFileSize.Text = "";
            checkBoxReadOnly.Checked = directoryInfo.Attributes.HasFlag(FileAttributes.ReadOnly);
            checkBoxHidden.Checked = directoryInfo.Attributes.HasFlag(FileAttributes.Hidden);

            textBoxNewPath.Text = directoryInfo.FullName;
            
            textBoxNewPath.Enabled = true;
            buttonCopyTo.Enabled = true;
            buttonMoveTo.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void DisplayFolderList(string folderFullName)
        {
            var folderInfo = new DirectoryInfo(folderFullName);
            if (!folderInfo.Exists)
                throw new DirectoryNotFoundException("Папка не найдена: " + folderFullName);
            
            ClearAllFields();
            DisableMoveFeatures();
            
            textBoxFolder.Text = folderInfo.FullName;
            _currentFolderPath = folderInfo.FullName;
            textBoxNewPath.Enabled = true;
            buttonCopyTo.Enabled = true;
            buttonMoveTo.Enabled = true;
            buttonDelete.Enabled = true;
            
            foreach (var file in folderInfo.GetFiles())
                listBoxFiles.Items.Add(file.Name);
            
            foreach (var folder in folderInfo.GetDirectories())
                listBoxFolders.Items.Add(folder.Name);
        }
        
        private void DisableMoveFeatures()
        {
            textBoxNewPath.Text = "";
            textBoxNewPath.Enabled = false;
            buttonCopyTo.Enabled = false;
            buttonMoveTo.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void OnDisplayButton(object sender, EventArgs e)
        {
            try
            {
                var folderPath = textBoxInput.Text;
                var folderInfo = new DirectoryInfo(folderPath);

                if (folderInfo.Exists)
                {
                    DisplayFolderList(folderPath);
                    return;
                }

                var fileInfo = new FileInfo(folderPath);
                if (!fileInfo.Exists) 
                    throw new FileNotFoundException("Файл или папка не найдены: " + folderPath);
                
                if (fileInfo.Directory != null)
                    DisplayFolderList(fileInfo.Directory.FullName);
                    
                var index = listBoxFiles.FindString(fileInfo.Name);
                listBoxFiles.SelectedIndex = index;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void OnListBoxFilesSelected(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFiles.SelectedIndex == -1)
                    return;
                
                var fileName = listBoxFiles.SelectedItem.ToString();
                var filePath = Path.Combine(_currentFolderPath, fileName);
                listBoxFolders.ClearSelected();
                
                DisplayFileInfo(filePath);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void OnListBoxFoldersSelected(object sender, MouseEventArgs e)
        {
            try
            {
                var folderName = listBoxFolders.SelectedItem.ToString();
                var folderPath = Path.Combine(_currentFolderPath, folderName);
                
                listBoxFiles.ClearSelected();
                
                DisplayFolderList(folderPath);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void OnListBoxFoldersClicked(object sender, EventArgs e)
        {
            try
            {
                var folderName = listBoxFolders.SelectedItem.ToString();
                var folderPath = Path.Combine(_currentFolderPath, folderName);
                
                listBoxFiles.ClearSelected();
                
                DisplayFolderInfo(folderPath);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void OnUpButtonClick(object sender, EventArgs e)
        {
            try
            {
                var folderInfo = new DirectoryInfo(_currentFolderPath);
                if (folderInfo.Parent != null)
                    DisplayFolderList(folderInfo.Parent.FullName);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void OnDeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFolders.SelectedIndex != -1)
                {
                    DeleteFolder();
                    return;
                }

                if (listBoxFiles.SelectedIndex != -1) 
                    DeleteFile();
                
            } catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении файла или папки: " + ex.Message, "Ошибка");
            }
        }

        private void DeleteFolder()
        {
            var folderName = listBoxFolders.SelectedItem.ToString();
            var folderPath = Path.Combine(_currentFolderPath, folderName);
            var query = $"Вы действительно хотите удалить папку\n{folderPath}?";

            if (MessageBox.Show(query, "Удалить папку?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            Directory.Delete(folderPath, true);
            DisplayFolderList(_currentFolderPath);
        }
        
        private void DeleteFile()
        {
            var fileName = listBoxFiles.SelectedItem.ToString();
            var filePath = Path.Combine(_currentFolderPath, fileName);
            var query = $"Вы действительно хотите удалить файл\n{filePath}?";

            if (MessageBox.Show(query, "Удалить файл?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            File.Delete(filePath);
            DisplayFolderList(_currentFolderPath);
        }

        private void OnCopyToButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFolders.SelectedIndex != -1)
                {
                    CopyFolder();
                    return;
                }
                
                if (listBoxFiles.SelectedIndex != -1)
                    CopyFile();
            } catch (Exception ex)
            {
                MessageBox.Show("Ошибка при копировании файла: " + ex.Message, "Ошибка");
            }
        }

        private void CopyFile()
        {
            var fileName = listBoxFiles.SelectedItem.ToString();
            var filePath = Path.Combine(_currentFolderPath, fileName);
            var newFilePath = textBoxNewPath.Text;
            var query = $"Вы действительно хотите скопировать файл\n{filePath}\nв\n{newFilePath}?";

            if (MessageBox.Show(query, "Копировать файл?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            File.Copy(filePath, newFilePath);
            DisplayFolderList(_currentFolderPath);
        }

        private void CopyFolder()
        {
            var folderName = listBoxFolders.SelectedItem.ToString();
            var folderPath = Path.Combine(_currentFolderPath, folderName);
            var newFolderPath = textBoxNewPath.Text;
            var query = $"Вы действительно хотите скопировать папку\n{folderPath}\nв\n{newFolderPath}?";

            if (MessageBox.Show(query, "Копировать папку?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            DirectoryCopy(folderPath, newFolderPath);
            DisplayFolderList(_currentFolderPath);
        }

        private void DirectoryCopy(string folderPath, string newFolderPath)
        {
            var dir = new DirectoryInfo(folderPath);
            var dirs = dir.GetDirectories();
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Исходная папка не существует или не может быть найдена: "
                    + folderPath);
            }

            if (!Directory.Exists(newFolderPath)) 
                Directory.CreateDirectory(newFolderPath);

            var files = dir.GetFiles();
            foreach (var file in files)
            {
                var temppath = Path.Combine(newFolderPath, file.Name);
                file.CopyTo(temppath, false);
            }

            foreach (var subdir in dirs)
            {
                var temppath = Path.Combine(newFolderPath, subdir.Name);
                DirectoryCopy(subdir.FullName, temppath);
            }
        }

        private void OnMoveToButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFolders.SelectedIndex != -1)
                {
                    MoveFolder();
                    return;
                }
                
                if (listBoxFiles.SelectedIndex != -1)
                    MoveFile();
                
            } catch (Exception ex)
            {
                MessageBox.Show("Ошибка при перемещении файла: " + ex.Message, "Ошибка");
            }
        }

        private void MoveFile()
        {
            var fileName = listBoxFiles.SelectedItem.ToString();
            var filePath = Path.Combine(_currentFolderPath, fileName);
            var newFilePath = textBoxNewPath.Text;
            var query = $"Вы действительно хотите переместить файл\n{filePath}\nв\n{newFilePath}?";

            if (MessageBox.Show(query, "Переместить файл?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            File.Move(filePath, newFilePath);
            DisplayFolderList(_currentFolderPath);
        }

        private void MoveFolder()
        {
            var folderName = listBoxFolders.SelectedItem.ToString();
            var folderPath = Path.Combine(_currentFolderPath, folderName);
            var newFolderPath = textBoxNewPath.Text;
            var query = $"Вы действительно хотите переместить папку\n{folderPath}\nв\n{newFolderPath}?";

            if (MessageBox.Show(query, "Переместить папку?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            Directory.Move(folderPath, newFolderPath);
            DisplayFolderList(_currentFolderPath);
        }
        
        private void OnCreateButtonClick(object sender, EventArgs e)
        {
            try
            {
                if(listBoxFolders.SelectedIndex != -1)
                    CreateFolder();
                else if (listBoxFiles.SelectedIndex != -1)
                    CreateFile();
                
            } catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании файла или папки: " + ex.Message, "Ошибка");
            }
        }

        private void CreateFile()
        {
            var fileName = textBoxNewPath.Text;
            var filePath = Path.Combine(_currentFolderPath, fileName);
            var query = $"Вы действительно хотите создать файл\n{filePath}?";

            if (MessageBox.Show(query, "Создать файл?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            File.Create(filePath);
            DisplayFolderList(_currentFolderPath);
        }

        private void CreateFolder()
        {
            var folderName = textBoxNewPath.Text;
            var query = $"Вы действительно хотите создать папку\n{folderName}?";

            if (MessageBox.Show(query, "Создать папку?", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                return;
            
            Directory.CreateDirectory(Path.Combine(_currentFolderPath, folderName));
            DisplayFolderList(_currentFolderPath);
        }
    }
}