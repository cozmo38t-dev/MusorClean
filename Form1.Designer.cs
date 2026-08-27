namespace MusorClean
{
    partial class MusorClean
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSFC = new Button();
            buttonMRT = new Button();
            buttonREG = new Button();
            buttonTAS = new Button();
            buttonREB = new Button();
            button1 = new Button();
            buttonCHK = new Button();
            buttonCHK2 = new Button();
            buttonDISM = new Button();
            buttonCLS = new Button();
            buttonWS = new Button();
            button = new Button();
            buttonIP = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonCMD = new Button();
            label1 = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            listViewAutostart = new ListView();
            tabPage2 = new TabPage();
            listViewTasks = new ListView();
            button4 = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSFC
            // 
            buttonSFC.Font = new Font("Segoe UI", 12F);
            buttonSFC.Location = new Point(12, 12);
            buttonSFC.Name = "buttonSFC";
            buttonSFC.Size = new Size(140, 39);
            buttonSFC.TabIndex = 0;
            buttonSFC.Text = "sfc /scannow";
            buttonSFC.UseVisualStyleBackColor = true;
            buttonSFC.Click += buttonSFC_Click;
            // 
            // buttonMRT
            // 
            buttonMRT.Font = new Font("Segoe UI", 12F);
            buttonMRT.Location = new Point(175, 12);
            buttonMRT.Name = "buttonMRT";
            buttonMRT.Size = new Size(140, 39);
            buttonMRT.TabIndex = 1;
            buttonMRT.Text = "mrt";
            buttonMRT.UseVisualStyleBackColor = true;
            buttonMRT.Click += buttonMRT_Click;
            // 
            // buttonREG
            // 
            buttonREG.Font = new Font("Segoe UI", 12F);
            buttonREG.Location = new Point(339, 12);
            buttonREG.Name = "buttonREG";
            buttonREG.Size = new Size(140, 39);
            buttonREG.TabIndex = 2;
            buttonREG.Text = "regedit";
            buttonREG.UseVisualStyleBackColor = true;
            buttonREG.Click += buttonREG_Click;
            // 
            // buttonTAS
            // 
            buttonTAS.Font = new Font("Segoe UI", 12F);
            buttonTAS.Location = new Point(512, 12);
            buttonTAS.Name = "buttonTAS";
            buttonTAS.Size = new Size(140, 39);
            buttonTAS.TabIndex = 3;
            buttonTAS.Text = "taskmgr";
            buttonTAS.UseVisualStyleBackColor = true;
            buttonTAS.Click += buttonTAS_Click;
            // 
            // buttonREB
            // 
            buttonREB.Font = new Font("Segoe UI", 12F);
            buttonREB.Location = new Point(12, 57);
            buttonREB.Name = "buttonREB";
            buttonREB.Size = new Size(140, 39);
            buttonREB.TabIndex = 4;
            buttonREB.Text = "Reboot";
            buttonREB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(175, 57);
            button1.Name = "button1";
            button1.Size = new Size(140, 39);
            button1.TabIndex = 5;
            button1.Text = "gpupdate /force";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttongpupdate_Click;
            // 
            // buttonCHK
            // 
            buttonCHK.Font = new Font("Segoe UI", 12F);
            buttonCHK.Location = new Point(339, 57);
            buttonCHK.Name = "buttonCHK";
            buttonCHK.Size = new Size(140, 39);
            buttonCHK.TabIndex = 6;
            buttonCHK.Text = "chkdsk /c";
            buttonCHK.UseVisualStyleBackColor = true;
            buttonCHK.Click += buttonCHKDSKC_Click;
            // 
            // buttonCHK2
            // 
            buttonCHK2.Font = new Font("Segoe UI", 12F);
            buttonCHK2.Location = new Point(512, 57);
            buttonCHK2.Name = "buttonCHK2";
            buttonCHK2.Size = new Size(140, 39);
            buttonCHK2.TabIndex = 7;
            buttonCHK2.Text = "chkdsk /r";
            buttonCHK2.UseVisualStyleBackColor = true;
            buttonCHK2.Click += buttonCHKDSKR_Click;
            // 
            // buttonDISM
            // 
            buttonDISM.Font = new Font("Segoe UI", 12F);
            buttonDISM.Location = new Point(12, 102);
            buttonDISM.Name = "buttonDISM";
            buttonDISM.Size = new Size(140, 39);
            buttonDISM.TabIndex = 8;
            buttonDISM.Text = "DISM";
            buttonDISM.UseVisualStyleBackColor = true;
            buttonDISM.Click += buttonDISM_Click;
            // 
            // buttonCLS
            // 
            buttonCLS.Font = new Font("Segoe UI", 12F);
            buttonCLS.Location = new Point(175, 102);
            buttonCLS.Name = "buttonCLS";
            buttonCLS.Size = new Size(140, 39);
            buttonCLS.TabIndex = 9;
            buttonCLS.Text = "cleanmgr";
            buttonCLS.UseVisualStyleBackColor = true;
            buttonCLS.Click += buttonCLEANMGR_Click;
            // 
            // buttonWS
            // 
            buttonWS.Font = new Font("Segoe UI", 12F);
            buttonWS.Location = new Point(339, 102);
            buttonWS.Name = "buttonWS";
            buttonWS.Size = new Size(140, 39);
            buttonWS.TabIndex = 10;
            buttonWS.Text = "flushDNS";
            buttonWS.UseVisualStyleBackColor = true;
            buttonWS.Click += buttonFlushDNS_Click;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 12F);
            button.Location = new Point(512, 102);
            button.Name = "button";
            button.Size = new Size(140, 39);
            button.TabIndex = 11;
            button.Text = "wsReset";
            button.UseVisualStyleBackColor = true;
            button.Click += buttonWSReset_Click;
            // 
            // buttonIP
            // 
            buttonIP.Font = new Font("Segoe UI", 12F);
            buttonIP.Location = new Point(12, 147);
            buttonIP.Name = "buttonIP";
            buttonIP.Size = new Size(140, 39);
            buttonIP.TabIndex = 12;
            buttonIP.Text = "release ipconfig";
            buttonIP.UseVisualStyleBackColor = true;
            buttonIP.Click += buttonRELEASE_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(512, 147);
            button2.Name = "button2";
            button2.Size = new Size(140, 39);
            button2.TabIndex = 13;
            button2.Text = "delete password";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(175, 147);
            button3.Name = "button3";
            button3.Size = new Size(140, 39);
            button3.TabIndex = 14;
            button3.Text = "Winver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonCMD
            // 
            buttonCMD.Font = new Font("Segoe UI", 12F);
            buttonCMD.Location = new Point(339, 147);
            buttonCMD.Name = "buttonCMD";
            buttonCMD.Size = new Size(140, 39);
            buttonCMD.TabIndex = 15;
            buttonCMD.Text = "Open CMD";
            buttonCMD.UseVisualStyleBackColor = true;
            buttonCMD.Click += buttonCMD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 488);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 16;
            label1.Text = "PC Cleaner";
            // 
            // tabControl
            // 
            tabControl.AccessibleDescription = "";
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(12, 192);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(640, 294);
            tabControl.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewAutostart);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(632, 266);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Реестр";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewAutostart
            // 
            listViewAutostart.FullRowSelect = true;
            listViewAutostart.Location = new Point(0, 0);
            listViewAutostart.Name = "listViewAutostart";
            listViewAutostart.Size = new Size(632, 266);
            listViewAutostart.TabIndex = 0;
            listViewAutostart.UseCompatibleStateImageBehavior = false;
            listViewAutostart.View = View.Details;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listViewTasks);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(632, 266);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Планировщик";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewTasks
            // 
            listViewTasks.Location = new Point(0, 0);
            listViewTasks.Name = "listViewTasks";
            listViewTasks.Size = new Size(632, 266);
            listViewTasks.TabIndex = 0;
            listViewTasks.UseCompatibleStateImageBehavior = false;
            listViewTasks.View = View.Details;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(481, 486);
            button4.Name = "button4";
            button4.Size = new Size(171, 39);
            button4.TabIndex = 18;
            button4.Text = "удалить параметр";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonDelete_Click;
            // 
            // MusorClean
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 527);
            Controls.Add(button4);
            Controls.Add(tabControl);
            Controls.Add(label1);
            Controls.Add(buttonCMD);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonIP);
            Controls.Add(button);
            Controls.Add(buttonWS);
            Controls.Add(buttonCLS);
            Controls.Add(buttonDISM);
            Controls.Add(buttonCHK2);
            Controls.Add(buttonCHK);
            Controls.Add(button1);
            Controls.Add(buttonREB);
            Controls.Add(buttonTAS);
            Controls.Add(buttonREG);
            Controls.Add(buttonMRT);
            Controls.Add(buttonSFC);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MusorClean";
            Text = "Admin Panel";
            TopMost = true;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSFC;
        private Button buttonMRT;
        private Button buttonREG;
        private Button buttonTAS;
        private Button buttonREB;
        private Button button1;
        private Button buttonCHK;
        private Button buttonCHK2;
        private Button buttonDISM;
        private Button buttonCLS;
        private Button buttonWS;
        private Button button;
        private Button buttonIP;
        private Button button2;
        private Button button3;
        private Button buttonCMD;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private ListView listViewAutostart;
        private TabPage tabPage2;
        private ListView listViewTasks;
        private Button button4;
    }
}
