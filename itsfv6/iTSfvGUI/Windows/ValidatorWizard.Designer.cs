﻿namespace iTSfvGUI
{
    partial class ValidatorWizard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidatorWizard));
            this.tcValidator = new System.Windows.Forms.TabControl();
            this.tpChecks = new System.Windows.Forms.TabPage();
            this.flpChecks = new System.Windows.Forms.FlowLayoutPanel();
            this.chkChecks_MissingTags = new System.Windows.Forms.CheckBox();
            this.chkChecks_ArtworkLowRes = new System.Windows.Forms.CheckBox();
            this.tpTracks = new System.Windows.Forms.TabPage();
            this.flpTracks = new System.Windows.Forms.FlowLayoutPanel();
            this.chkTracks_ArtworkFill = new System.Windows.Forms.CheckBox();
            this.chkTracks_GenreFill = new System.Windows.Forms.CheckBox();
            this.chkTracks_AlbumArtistFill = new System.Windows.Forms.CheckBox();
            this.chkTracks_TrackCountFill = new System.Windows.Forms.CheckBox();
            this.tpFileSystem = new System.Windows.Forms.TabPage();
            this.flpFileSystem = new System.Windows.Forms.FlowLayoutPanel();
            this.chkFileSystem_ArtworkJpgExport = new System.Windows.Forms.CheckBox();
            this.lbDiscs = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile_TasksAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile_AddFilesWithStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTasksValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFoldersLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpLogViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.ttApp = new System.Windows.Forms.ToolTip(this.components);
            this.tvLibrary = new System.Windows.Forms.TreeView();
            this.tlpApp = new System.Windows.Forms.TableLayoutPanel();
            this.cmsDisc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSearchInGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tcValidator.SuspendLayout();
            this.tpChecks.SuspendLayout();
            this.flpChecks.SuspendLayout();
            this.tpTracks.SuspendLayout();
            this.flpTracks.SuspendLayout();
            this.tpFileSystem.SuspendLayout();
            this.flpFileSystem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tlpApp.SuspendLayout();
            this.cmsDisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcValidator
            // 
            this.tcValidator.Controls.Add(this.tpChecks);
            this.tcValidator.Controls.Add(this.tpTracks);
            this.tcValidator.Controls.Add(this.tpFileSystem);
            this.tcValidator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcValidator.Location = new System.Drawing.Point(4, 4);
            this.tcValidator.Margin = new System.Windows.Forms.Padding(4);
            this.tcValidator.Name = "tcValidator";
            this.tcValidator.SelectedIndex = 0;
            this.tcValidator.Size = new System.Drawing.Size(471, 397);
            this.tcValidator.TabIndex = 1;
            // 
            // tpChecks
            // 
            this.tpChecks.Controls.Add(this.flpChecks);
            this.tpChecks.Location = new System.Drawing.Point(4, 25);
            this.tpChecks.Margin = new System.Windows.Forms.Padding(4);
            this.tpChecks.Name = "tpChecks";
            this.tpChecks.Padding = new System.Windows.Forms.Padding(4);
            this.tpChecks.Size = new System.Drawing.Size(463, 368);
            this.tpChecks.TabIndex = 1;
            this.tpChecks.Text = "Checks";
            this.tpChecks.UseVisualStyleBackColor = true;
            // 
            // flpChecks
            // 
            this.flpChecks.Controls.Add(this.chkChecks_MissingTags);
            this.flpChecks.Controls.Add(this.chkChecks_ArtworkLowRes);
            this.flpChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChecks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChecks.Location = new System.Drawing.Point(4, 4);
            this.flpChecks.Margin = new System.Windows.Forms.Padding(4);
            this.flpChecks.Name = "flpChecks";
            this.flpChecks.Size = new System.Drawing.Size(455, 360);
            this.flpChecks.TabIndex = 1;
            // 
            // chkChecks_MissingTags
            // 
            this.chkChecks_MissingTags.AutoSize = true;
            this.chkChecks_MissingTags.Location = new System.Drawing.Point(4, 4);
            this.chkChecks_MissingTags.Margin = new System.Windows.Forms.Padding(4);
            this.chkChecks_MissingTags.Name = "chkChecks_MissingTags";
            this.chkChecks_MissingTags.Size = new System.Drawing.Size(172, 21);
            this.chkChecks_MissingTags.TabIndex = 0;
            this.chkChecks_MissingTags.Text = "Check for missing tags";
            this.chkChecks_MissingTags.UseVisualStyleBackColor = true;
            // 
            // chkChecks_ArtworkLowRes
            // 
            this.chkChecks_ArtworkLowRes.AutoSize = true;
            this.chkChecks_ArtworkLowRes.Location = new System.Drawing.Point(4, 33);
            this.chkChecks_ArtworkLowRes.Margin = new System.Windows.Forms.Padding(4);
            this.chkChecks_ArtworkLowRes.Name = "chkChecks_ArtworkLowRes";
            this.chkChecks_ArtworkLowRes.Size = new System.Drawing.Size(230, 21);
            this.chkChecks_ArtworkLowRes.TabIndex = 1;
            this.chkChecks_ArtworkLowRes.Text = "Check for low resolution artwork";
            this.chkChecks_ArtworkLowRes.UseVisualStyleBackColor = true;
            // 
            // tpTracks
            // 
            this.tpTracks.Controls.Add(this.flpTracks);
            this.tpTracks.Location = new System.Drawing.Point(4, 25);
            this.tpTracks.Margin = new System.Windows.Forms.Padding(4);
            this.tpTracks.Name = "tpTracks";
            this.tpTracks.Padding = new System.Windows.Forms.Padding(4);
            this.tpTracks.Size = new System.Drawing.Size(463, 368);
            this.tpTracks.TabIndex = 2;
            this.tpTracks.Text = "Tracks";
            this.tpTracks.UseVisualStyleBackColor = true;
            // 
            // flpTracks
            // 
            this.flpTracks.Controls.Add(this.chkTracks_ArtworkFill);
            this.flpTracks.Controls.Add(this.chkTracks_GenreFill);
            this.flpTracks.Controls.Add(this.chkTracks_AlbumArtistFill);
            this.flpTracks.Controls.Add(this.chkTracks_TrackCountFill);
            this.flpTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTracks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTracks.Location = new System.Drawing.Point(4, 4);
            this.flpTracks.Margin = new System.Windows.Forms.Padding(4);
            this.flpTracks.Name = "flpTracks";
            this.flpTracks.Size = new System.Drawing.Size(455, 360);
            this.flpTracks.TabIndex = 2;
            // 
            // chkTracks_ArtworkFill
            // 
            this.chkTracks_ArtworkFill.AutoSize = true;
            this.chkTracks_ArtworkFill.Location = new System.Drawing.Point(4, 4);
            this.chkTracks_ArtworkFill.Margin = new System.Windows.Forms.Padding(4);
            this.chkTracks_ArtworkFill.Name = "chkTracks_ArtworkFill";
            this.chkTracks_ArtworkFill.Size = new System.Drawing.Size(196, 21);
            this.chkTracks_ArtworkFill.TabIndex = 3;
            this.chkTracks_ArtworkFill.Text = "Embed artwork from folder";
            this.chkTracks_ArtworkFill.UseVisualStyleBackColor = true;
            // 
            // chkTracks_GenreFill
            // 
            this.chkTracks_GenreFill.AutoSize = true;
            this.chkTracks_GenreFill.Location = new System.Drawing.Point(4, 33);
            this.chkTracks_GenreFill.Margin = new System.Windows.Forms.Padding(4);
            this.chkTracks_GenreFill.Name = "chkTracks_GenreFill";
            this.chkTracks_GenreFill.Size = new System.Drawing.Size(253, 21);
            this.chkTracks_GenreFill.TabIndex = 0;
            this.chkTracks_GenreFill.Text = "Fill missing Genre using best guess";
            this.chkTracks_GenreFill.UseVisualStyleBackColor = true;
            // 
            // chkTracks_AlbumArtistFill
            // 
            this.chkTracks_AlbumArtistFill.AutoSize = true;
            this.chkTracks_AlbumArtistFill.Location = new System.Drawing.Point(4, 62);
            this.chkTracks_AlbumArtistFill.Margin = new System.Windows.Forms.Padding(4);
            this.chkTracks_AlbumArtistFill.Name = "chkTracks_AlbumArtistFill";
            this.chkTracks_AlbumArtistFill.Size = new System.Drawing.Size(288, 21);
            this.chkTracks_AlbumArtistFill.TabIndex = 1;
            this.chkTracks_AlbumArtistFill.Text = "Fill missing Album Artist using best guess";
            this.chkTracks_AlbumArtistFill.UseVisualStyleBackColor = true;
            // 
            // chkTracks_TrackCountFill
            // 
            this.chkTracks_TrackCountFill.AutoSize = true;
            this.chkTracks_TrackCountFill.Location = new System.Drawing.Point(4, 91);
            this.chkTracks_TrackCountFill.Margin = new System.Windows.Forms.Padding(4);
            this.chkTracks_TrackCountFill.Name = "chkTracks_TrackCountFill";
            this.chkTracks_TrackCountFill.Size = new System.Drawing.Size(368, 21);
            this.chkTracks_TrackCountFill.TabIndex = 2;
            this.chkTracks_TrackCountFill.Text = "Fill missing Track Count, Disc Number and Disc Count";
            this.chkTracks_TrackCountFill.UseVisualStyleBackColor = true;
            // 
            // tpFileSystem
            // 
            this.tpFileSystem.Controls.Add(this.flpFileSystem);
            this.tpFileSystem.Location = new System.Drawing.Point(4, 25);
            this.tpFileSystem.Margin = new System.Windows.Forms.Padding(4);
            this.tpFileSystem.Name = "tpFileSystem";
            this.tpFileSystem.Size = new System.Drawing.Size(463, 368);
            this.tpFileSystem.TabIndex = 3;
            this.tpFileSystem.Text = "FileSystem";
            this.tpFileSystem.UseVisualStyleBackColor = true;
            // 
            // flpFileSystem
            // 
            this.flpFileSystem.Controls.Add(this.chkFileSystem_ArtworkJpgExport);
            this.flpFileSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFileSystem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFileSystem.Location = new System.Drawing.Point(0, 0);
            this.flpFileSystem.Margin = new System.Windows.Forms.Padding(4);
            this.flpFileSystem.Name = "flpFileSystem";
            this.flpFileSystem.Size = new System.Drawing.Size(463, 368);
            this.flpFileSystem.TabIndex = 1;
            // 
            // chkFileSystem_ArtworkJpgExport
            // 
            this.chkFileSystem_ArtworkJpgExport.AutoSize = true;
            this.chkFileSystem_ArtworkJpgExport.Location = new System.Drawing.Point(4, 4);
            this.chkFileSystem_ArtworkJpgExport.Margin = new System.Windows.Forms.Padding(4);
            this.chkFileSystem_ArtworkJpgExport.Name = "chkFileSystem_ArtworkJpgExport";
            this.chkFileSystem_ArtworkJpgExport.Size = new System.Drawing.Size(306, 21);
            this.chkFileSystem_ArtworkJpgExport.TabIndex = 0;
            this.chkFileSystem_ArtworkJpgExport.Text = "Export Artwork to Album folder as Folder.jpg";
            this.chkFileSystem_ArtworkJpgExport.UseVisualStyleBackColor = true;
            // 
            // lbDiscs
            // 
            this.lbDiscs.AllowDrop = true;
            this.lbDiscs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDiscs.FormattingEnabled = true;
            this.lbDiscs.ItemHeight = 16;
            this.lbDiscs.Location = new System.Drawing.Point(842, 4);
            this.lbDiscs.Margin = new System.Windows.Forms.Padding(4);
            this.lbDiscs.Name = "lbDiscs";
            this.lbDiscs.Size = new System.Drawing.Size(352, 397);
            this.lbDiscs.Sorted = true;
            this.lbDiscs.TabIndex = 0;
            this.lbDiscs.SelectedIndexChanged += new System.EventHandler(this.lbDiscs_SelectedIndexChanged);
            this.lbDiscs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragDrop);
            this.lbDiscs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragEnter);
            this.lbDiscs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDiscs_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.foldersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1198, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile_TasksAddFiles,
            this.tsmiFile_AddFilesWithStructure});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tsmiFile_TasksAddFiles
            // 
            this.tsmiFile_TasksAddFiles.Name = "tsmiFile_TasksAddFiles";
            this.tsmiFile_TasksAddFiles.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiFile_TasksAddFiles.Size = new System.Drawing.Size(278, 24);
            this.tsmiFile_TasksAddFiles.Text = "&Add files...";
            this.tsmiFile_TasksAddFiles.Click += new System.EventHandler(this.miTasksAddFiles_Click);
            // 
            // tsmiFile_AddFilesWithStructure
            // 
            this.tsmiFile_AddFilesWithStructure.Name = "tsmiFile_AddFilesWithStructure";
            this.tsmiFile_AddFilesWithStructure.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiFile_AddFilesWithStructure.Size = new System.Drawing.Size(278, 24);
            this.tsmiFile_AddFilesWithStructure.Text = "Add files with wizard...";
            this.tsmiFile_AddFilesWithStructure.Click += new System.EventHandler(this.tsmiFile_AddFilesWithStructure_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTasksValidate});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.windowsToolStripMenuItem.Text = "&Tasks";
            // 
            // tsmiTasksValidate
            // 
            this.tsmiTasksValidate.Name = "tsmiTasksValidate";
            this.tsmiTasksValidate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiTasksValidate.Size = new System.Drawing.Size(157, 24);
            this.tsmiTasksValidate.Text = "&Validate";
            this.tsmiTasksValidate.Click += new System.EventHandler(this.tsmiTasksValidate_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(139, 24);
            this.tsmiOptions.Text = "&Options...";
            this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
            // 
            // foldersToolStripMenuItem
            // 
            this.foldersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFoldersLogs});
            this.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem";
            this.foldersToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.foldersToolStripMenuItem.Text = "&Folders";
            // 
            // tsmiFoldersLogs
            // 
            this.tsmiFoldersLogs.Name = "tsmiFoldersLogs";
            this.tsmiFoldersLogs.Size = new System.Drawing.Size(118, 24);
            this.tsmiFoldersLogs.Text = "&Logs...";
            this.tsmiFoldersLogs.Click += new System.EventHandler(this.tsmiFoldersLogs_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiHelpLogViewer});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(159, 24);
            this.tsmiAbout.Text = "&About...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiHelpLogViewer
            // 
            this.tsmiHelpLogViewer.Name = "tsmiHelpLogViewer";
            this.tsmiHelpLogViewer.Size = new System.Drawing.Size(159, 24);
            this.tsmiHelpLogViewer.Text = "&Log viewer...";
            this.tsmiHelpLogViewer.Click += new System.EventHandler(this.tsmiHelpLogViewer_Click);
            // 
            // tvLibrary
            // 
            this.tvLibrary.AllowDrop = true;
            this.tvLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLibrary.Location = new System.Drawing.Point(483, 4);
            this.tvLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.tvLibrary.Name = "tvLibrary";
            this.tvLibrary.Size = new System.Drawing.Size(351, 397);
            this.tvLibrary.TabIndex = 2;
            this.tvLibrary.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLibrary_NodeMouseClick);
            this.tvLibrary.Click += new System.EventHandler(this.tvLibrary_Click);
            this.tvLibrary.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvLibrary_DragDrop);
            this.tvLibrary.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvLibrary_DragEnter);
            // 
            // tlpApp
            // 
            this.tlpApp.ColumnCount = 3;
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpApp.Controls.Add(this.tvLibrary, 1, 0);
            this.tlpApp.Controls.Add(this.tcValidator, 0, 0);
            this.tlpApp.Controls.Add(this.lbDiscs, 2, 0);
            this.tlpApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpApp.Location = new System.Drawing.Point(0, 28);
            this.tlpApp.Margin = new System.Windows.Forms.Padding(4);
            this.tlpApp.Name = "tlpApp";
            this.tlpApp.RowCount = 1;
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpApp.Size = new System.Drawing.Size(1198, 405);
            this.tlpApp.TabIndex = 3;
            // 
            // cmsDisc
            // 
            this.cmsDisc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearchInGoogle,
            this.tsmiShowInExplorer});
            this.cmsDisc.Name = "cmsDisc";
            this.cmsDisc.Size = new System.Drawing.Size(242, 52);
            // 
            // tsmiSearchInGoogle
            // 
            this.tsmiSearchInGoogle.Name = "tsmiSearchInGoogle";
            this.tsmiSearchInGoogle.Size = new System.Drawing.Size(241, 24);
            this.tsmiSearchInGoogle.Text = "Search in Google...";
            this.tsmiSearchInGoogle.Click += new System.EventHandler(this.tsmiSearchInGoogle_Click);
            // 
            // tsmiShowInExplorer
            // 
            this.tsmiShowInExplorer.Name = "tsmiShowInExplorer";
            this.tsmiShowInExplorer.Size = new System.Drawing.Size(241, 24);
            this.tsmiShowInExplorer.Text = "Open containing folder...";
            this.tsmiShowInExplorer.Click += new System.EventHandler(this.tsmiShowInExplorer_Click);
            // 
            // ValidatorWizard
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 433);
            this.Controls.Add(this.tlpApp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1216, 480);
            this.Name = "ValidatorWizard";
            this.Text = "iTSfv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ValidatorWizard_FormClosing);
            this.Load += new System.EventHandler(this.ValidatorWizard_Load);
            this.Shown += new System.EventHandler(this.ValidatorWizard_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ValidatorWizard_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ValidatorWizard_DragEnter);
            this.Move += new System.EventHandler(this.ValidatorWizard_Move);
            this.Resize += new System.EventHandler(this.ValidatorWizard_Resize);
            this.tcValidator.ResumeLayout(false);
            this.tpChecks.ResumeLayout(false);
            this.flpChecks.ResumeLayout(false);
            this.flpChecks.PerformLayout();
            this.tpTracks.ResumeLayout(false);
            this.flpTracks.ResumeLayout(false);
            this.flpTracks.PerformLayout();
            this.tpFileSystem.ResumeLayout(false);
            this.flpFileSystem.ResumeLayout(false);
            this.flpFileSystem.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpApp.ResumeLayout(false);
            this.cmsDisc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcValidator;
        private System.Windows.Forms.TabPage tpChecks;
        private System.Windows.Forms.TabPage tpTracks;
        private System.Windows.Forms.TabPage tpFileSystem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile_TasksAddFiles;
        private System.Windows.Forms.CheckBox chkTracks_GenreFill;
        private System.Windows.Forms.ListBox lbDiscs;
        private System.Windows.Forms.ToolTip ttApp;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.CheckBox chkChecks_MissingTags;
        private System.Windows.Forms.CheckBox chkTracks_AlbumArtistFill;
        private System.Windows.Forms.CheckBox chkFileSystem_ArtworkJpgExport;
        private System.Windows.Forms.TreeView tvLibrary;
        private System.Windows.Forms.ToolStripMenuItem tsmiTasksValidate;
        private System.Windows.Forms.TableLayoutPanel tlpApp;
        private System.Windows.Forms.FlowLayoutPanel flpChecks;
        private System.Windows.Forms.FlowLayoutPanel flpTracks;
        private System.Windows.Forms.FlowLayoutPanel flpFileSystem;
        private System.Windows.Forms.CheckBox chkTracks_TrackCountFill;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile_AddFilesWithStructure;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFoldersLogs;
        private System.Windows.Forms.CheckBox chkTracks_ArtworkFill;
        private System.Windows.Forms.CheckBox chkChecks_ArtworkLowRes;
        private System.Windows.Forms.ContextMenuStrip cmsDisc;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchInGoogle;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInExplorer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpLogViewer;
    }
}

