using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MusorClean
{
    public partial class MusorClean : Form
    {
        public MusorClean()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();
            LoadAutostartPrograms();
            LoadTaskSchedulerTasks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = Environment.UserName;

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    // /k оставляет окно открытым, чтобы ты увидел результат (успешно или ошибка)
                    Arguments = $"/k net user {userName} \"\"",
                    UseShellExecute = true,
                    Verb = "runas" // Обязательно запуск от Администратора
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RunCommandInConsole(string command)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k {command}",
                    UseShellExecute = true,
                    Verb = "runas"
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось запустить команду: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDISM_Click(object sender, EventArgs e)
        {
            RunCommandInConsole("DISM.exe /Online /Cleanup-Image /RestoreHealth");
        }

        private void buttonFlushDNS_Click(object sender, EventArgs e)
        {
            RunCommandInConsole("ipconfig /flushdns");
        }
        private void buttonRELEASE_Click(object sender, EventArgs e)
        {
            RunCommandInConsole("ipconfig /release");
        }

        private void buttonREBOOT_Click(object sender, EventArgs e)
        {
            RunCommandInConsole("shutdown /r /t 3");
        }

        private void buttonCHKDSKR_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/k chkdsk C: /f /r",
                    UseShellExecute = true,
                    Verb = "runas"
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWSReset_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "wsreset.exe",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сбросе Microsoft Store: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCHKDSKC_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/k chkdsk C: /f /c",
                    UseShellExecute = true,
                    Verb = "runas"
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCMD_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System),
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTAS_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "taskmgr.exe",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSFC_Click(object sender, EventArgs e)
        {
            RunCommandInConsole("sfc /scannow");
        }
        private void buttongpupdate_Click(object sender, EventArgs e)
        {
            RunCommandInConsole("gpupdate /force");
        }

        private void buttonMRT_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "mrt.exe",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonREG_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "regedit.exe",
                    Verb = "runas",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "winver.exe",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCLEANMGR_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cleanmgr.exe",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAutostartPrograms()
        {
            listViewAutostart.Items.Clear();

            if (listViewAutostart.Columns.Count == 0)
            {
                listViewAutostart.View = View.Details;
                listViewAutostart.FullRowSelect = true;
                listViewAutostart.Columns.Add("Имя программы", 150);
                listViewAutostart.Columns.Add("Путь", 300);
                listViewAutostart.Columns.Add("Расположение", 100);
            }

            string regKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            ReadRegistryHive(RegistryHive.CurrentUser, regKeyPath, "User");
            ReadRegistryHive(RegistryHive.LocalMachine, regKeyPath, "Machine");
            ReadRegistryHive(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Winlogon");
        }

        private void ReadRegistryHive(RegistryHive hive, string regKeyPath, string hiveTag)
        {
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64))
                {
                    using (RegistryKey? key = baseKey.OpenSubKey(regKeyPath))
                    {
                        if (key != null)
                        {
                            foreach (string valName in key.GetValueNames())
                            {
                                string valData = key.GetValue(valName)?.ToString() ?? "";

                                ListViewItem item = new ListViewItem(valName);
                                item.SubItems.Add(valData);
                                item.SubItems.Add(hiveTag); // Помечаем, где именно лежит запись

                                listViewAutostart.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Игнорируем ошибки доступа, если нет админских прав на чтение HKLM
            }
        }

        private void DeleteSelectedAutostart()
        {
            if (listViewAutostart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала выбери программу из списка для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewAutostart.SelectedItems[0];
            string valName = selectedItem.Text;
            string hiveTag = selectedItem.SubItems[2].Text; // Узнаем, откуда удалять (User или Machine)

            DialogResult result = MessageBox.Show($"Точно удалить из автозагрузки ({hiveTag}): {valName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            string regKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            RegistryHive targetHive = (hiveTag == "Machine") ? RegistryHive.LocalMachine : RegistryHive.CurrentUser;

            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(targetHive, RegistryView.Registry64))
                {
                    using (RegistryKey? key = baseKey.OpenSubKey(regKeyPath, true))
                    {
                        if (key != null)
                        {
                            key.DeleteValue(valName);
                            MessageBox.Show("Успешно удалено из реестра!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAutostartPrograms();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось открыть ветку реестра для записи. Возможно, нужны права администратора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении (возможно, требуются права администратора): " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteSelectedTask()
        {
            if (listViewTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала выбери задачу из списка для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string taskName = listViewTasks.SelectedItems[0].Text;

            DialogResult result = MessageBox.Show($"Точно удалить задачу планировщика: {taskName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "schtasks.exe",
                    Arguments = $"/delete /tn \"{taskName}\" /f",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process? p = Process.Start(psi))
                {
                    if (p != null)
                    {
                        p.WaitForExit();
                        int exitCode = p.ExitCode;

                        if (exitCode == 0)
                        {
                            MessageBox.Show("Задача успешно удалена из планировщика!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTaskSchedulerTasks(); // Перезагружаем список задач
                        }
                        else
                        {
                            string error = p.StandardError.ReadToEnd();
                            MessageBox.Show("Не удалось удалить задачу. Возможно, нужны права администратора.\n" + error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении задачи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Замени tabControl1 на то имя, которое у твоего TabControl в дизайнере!
            if (tabControl.SelectedTab == tabPage1)
            {
                DeleteSelectedAutostart();
            }
            else if (tabControl.SelectedTab == tabPage2)
            {
                DeleteSelectedTask();
            }
        }
        private void LoadTaskSchedulerTasks()
        {
            // Проверяем, существует ли этот элемент на форме
            if (listViewTasks == null) return;

            listViewTasks.Items.Clear();

            if (listViewTasks.Columns.Count == 0)
            {
                listViewTasks.View = View.Details;
                listViewTasks.FullRowSelect = true;
                listViewTasks.Columns.Add("Имя задачи", 200);
                listViewTasks.Columns.Add("Следующий запуск", 150);
                listViewTasks.Columns.Add("Состояние", 120);
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "schtasks.exe",
                    Arguments = "/query /fo LIST /v",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = System.Text.Encoding.GetEncoding(866)
                };

                using (Process? p = Process.Start(psi))
                {
                    if (p != null)
                    {
                        string output = p.StandardOutput.ReadToEnd();
                        p.WaitForExit();

                        string taskName = "";
                        string nextRun = "";
                        string status = "";

                        foreach (string line in output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
                        {
                            string trimmed = line.Trim();

                            if (trimmed.StartsWith("Имя задачи:") || trimmed.StartsWith("TaskName:"))
                            {
                                if (!string.IsNullOrEmpty(taskName))
                                {
                                    AddOrUpdateTaskItem(taskName, nextRun, status);
                                }
                                taskName = trimmed.Substring(trimmed.IndexOf(':') + 1).Trim();
                                nextRun = "";
                                status = "";
                            }
                            else if (trimmed.StartsWith("Следующий запуск:") || trimmed.StartsWith("Next Run Time:"))
                            {
                                nextRun = trimmed.Substring(trimmed.IndexOf(':') + 1).Trim();
                            }
                            else if (trimmed.StartsWith("Состояние:") || trimmed.StartsWith("Status:"))
                            {
                                status = trimmed.Substring(trimmed.IndexOf(':') + 1).Trim();
                            }
                        }

                        if (!string.IsNullOrEmpty(taskName))
                        {
                            AddOrUpdateTaskItem(taskName, nextRun, status);
                        }
                    }
                }
            }
            catch (Exception ex) // <-- Здесь была та самая опечатка со скобкой
            {
                MessageBox.Show("Не удалось загрузить задачи планировщика: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOrUpdateTaskItem(string name, string run, string stat)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(string.IsNullOrEmpty(run) ? "Не запланировано" : run);
            item.SubItems.Add(string.IsNullOrEmpty(stat) ? "Неизвестно" : stat);
            listViewTasks.Items.Add(item);
        }
    }
}