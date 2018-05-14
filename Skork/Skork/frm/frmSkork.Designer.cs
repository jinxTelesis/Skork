﻿namespace Skork
{
    partial class frmSkork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkork));
            this.grpCode = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.picSyntax = new System.Windows.Forms.PictureBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.ctxCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCTXCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCTXCompileDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCTXSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxZoomFactor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn100 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn110 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn125 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn150 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn200 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn250 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn300 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn400 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn500 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateMoreZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSyntax)).BeginInit();
            this.stsMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ctxCode.SuspendLayout();
            this.ctxZoomFactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCode
            // 
            this.grpCode.Controls.Add(this.txtCode);
            this.grpCode.Controls.Add(this.picSyntax);
            this.grpCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCode.Location = new System.Drawing.Point(0, 25);
            this.grpCode.Name = "grpCode";
            this.grpCode.Size = new System.Drawing.Size(327, 414);
            this.grpCode.TabIndex = 1;
            this.grpCode.TabStop = false;
            this.grpCode.Text = "groupBox1";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(6, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(315, 389);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "/**\nSkork - v\n@author iReapism\n*/";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // picSyntax
            // 
            this.picSyntax.BackColor = System.Drawing.Color.Red;
            this.picSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSyntax.Location = new System.Drawing.Point(3, 16);
            this.picSyntax.Name = "picSyntax";
            this.picSyntax.Size = new System.Drawing.Size(321, 395);
            this.picSyntax.TabIndex = 0;
            this.picSyntax.TabStop = false;
            // 
            // grpOutput
            // 
            this.grpOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOutput.Location = new System.Drawing.Point(367, 25);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(367, 414);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "groupBox2";
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblZoom});
            this.stsMain.Location = new System.Drawing.Point(0, 439);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(734, 22);
            this.stsMain.TabIndex = 3;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblZoom
            // 
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(35, 17);
            this.lblZoom.Text = "100%";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnEdit,
            this.btnView,
            this.btnHelp,
            this.btnSettings});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(734, 25);
            this.tsMain.TabIndex = 4;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnFile
            // 
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(54, 22);
            this.btnFile.Text = "File";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 22);
            this.btnEdit.Text = "Edit";
            // 
            // btnView
            // 
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(61, 22);
            this.btnView.Text = "View";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(61, 22);
            this.btnHelp.Text = "Help";
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Text = "Settings";
            // 
            // ctxCode
            // 
            this.ctxCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCTXCompile,
            this.btnCTXCompileDebug,
            this.btnCTXSave});
            this.ctxCode.Name = "ctxCode";
            this.ctxCode.Size = new System.Drawing.Size(171, 70);
            // 
            // btnCTXCompile
            // 
            this.btnCTXCompile.Name = "btnCTXCompile";
            this.btnCTXCompile.Size = new System.Drawing.Size(170, 22);
            this.btnCTXCompile.Text = "Compile";
            // 
            // btnCTXCompileDebug
            // 
            this.btnCTXCompileDebug.Name = "btnCTXCompileDebug";
            this.btnCTXCompileDebug.Size = new System.Drawing.Size(170, 22);
            this.btnCTXCompileDebug.Text = "Compile && Debug";
            // 
            // btnCTXSave
            // 
            this.btnCTXSave.Name = "btnCTXSave";
            this.btnCTXSave.Size = new System.Drawing.Size(170, 22);
            this.btnCTXSave.Text = "Save";
            // 
            // ctxZoomFactor
            // 
            this.ctxZoomFactor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn100,
            this.btn110,
            this.btn125,
            this.btn150,
            this.btn200,
            this.btn250,
            this.btn300,
            this.btn400,
            this.btn500,
            this.btnGenerateMoreZoom,
            this.btnCustomZoom});
            this.ctxZoomFactor.Name = "ctxZoomFactor";
            this.ctxZoomFactor.Size = new System.Drawing.Size(162, 246);
            // 
            // btn100
            // 
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(161, 22);
            this.btn100.Tag = "1";
            this.btn100.Text = "100%";
            // 
            // btn110
            // 
            this.btn110.Name = "btn110";
            this.btn110.Size = new System.Drawing.Size(161, 22);
            this.btn110.Tag = "1.1";
            this.btn110.Text = "110%";
            // 
            // btn125
            // 
            this.btn125.Name = "btn125";
            this.btn125.Size = new System.Drawing.Size(161, 22);
            this.btn125.Tag = "1.25";
            this.btn125.Text = "125%";
            // 
            // btn150
            // 
            this.btn150.Name = "btn150";
            this.btn150.Size = new System.Drawing.Size(161, 22);
            this.btn150.Tag = "1.5";
            this.btn150.Text = "150%";
            // 
            // btn200
            // 
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(161, 22);
            this.btn200.Tag = "2.0";
            this.btn200.Text = "200%";
            // 
            // btn250
            // 
            this.btn250.Name = "btn250";
            this.btn250.Size = new System.Drawing.Size(161, 22);
            this.btn250.Tag = "2.5";
            this.btn250.Text = "250%";
            // 
            // btn300
            // 
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(161, 22);
            this.btn300.Tag = "3.0";
            this.btn300.Text = "300%";
            // 
            // btn400
            // 
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(161, 22);
            this.btn400.Tag = "4.0";
            this.btn400.Text = "400%";
            // 
            // btn500
            // 
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(161, 22);
            this.btn500.Tag = "5.0";
            this.btn500.Text = "500%";
            // 
            // btnGenerateMoreZoom
            // 
            this.btnGenerateMoreZoom.Name = "btnGenerateMoreZoom";
            this.btnGenerateMoreZoom.Size = new System.Drawing.Size(161, 22);
            this.btnGenerateMoreZoom.Tag = "Generate more...";
            this.btnGenerateMoreZoom.Text = "Generate more...";
            // 
            // btnCustomZoom
            // 
            this.btnCustomZoom.Name = "btnCustomZoom";
            this.btnCustomZoom.Size = new System.Drawing.Size(161, 22);
            this.btnCustomZoom.Tag = "Custom...";
            this.btnCustomZoom.Text = "Custom...";
            // 
            // frmSkork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpCode);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.stsMain);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmSkork";
            this.Text = "Skork Application";
            this.Load += new System.EventHandler(this.frmSkork_Load);
            this.Resize += new System.EventHandler(this.frmSkork_Resize);
            this.grpCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSyntax)).EndInit();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ctxCode.ResumeLayout(false);
            this.ctxZoomFactor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStrip tsMain;
        internal System.Windows.Forms.GroupBox grpCode;
        internal System.Windows.Forms.GroupBox grpOutput;
        internal System.Windows.Forms.RichTextBox txtCode;
        internal System.Windows.Forms.PictureBox picSyntax;
        private System.Windows.Forms.ContextMenuStrip ctxCode;
        private System.Windows.Forms.ToolStripMenuItem btnCTXCompile;
        private System.Windows.Forms.ToolStripMenuItem btnCTXCompileDebug;
        private System.Windows.Forms.ToolStripDropDownButton btnFile;
        private System.Windows.Forms.ToolStripDropDownButton btnEdit;
        private System.Windows.Forms.ToolStripDropDownButton btnView;
        private System.Windows.Forms.ToolStripDropDownButton btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnCTXSave;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ContextMenuStrip ctxZoomFactor;
        private System.Windows.Forms.ToolStripMenuItem btn100;
        private System.Windows.Forms.ToolStripMenuItem btn110;
        private System.Windows.Forms.ToolStripMenuItem btn125;
        private System.Windows.Forms.ToolStripMenuItem btn150;
        private System.Windows.Forms.ToolStripMenuItem btn200;
        private System.Windows.Forms.ToolStripMenuItem btn250;
        private System.Windows.Forms.ToolStripMenuItem btn300;
        private System.Windows.Forms.ToolStripMenuItem btn400;
        private System.Windows.Forms.ToolStripMenuItem btn500;
        private System.Windows.Forms.ToolStripMenuItem btnGenerateMoreZoom;
        private System.Windows.Forms.ToolStripMenuItem btnCustomZoom;
        private System.Windows.Forms.ToolStripStatusLabel lblZoom;
    }
}

