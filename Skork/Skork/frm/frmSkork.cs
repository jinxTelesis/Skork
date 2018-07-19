﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using Skork.ui;
using Skork.util;
using Skork.frm;
using Skork.keywords;
using System.Collections.Specialized;

namespace Skork {

    public partial class frmSkork : Form {

        private delegate void drawPlane(Panel p);
        Diag d;
        /// <summary>
        /// Default constructor
        /// </summary>

        public frmSkork() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;


            Point frmSize = new Point(750, 500);
            this.Width = frmSize.X;
            this.Height = frmSize.Y;

            UserInterface.drawMain(this, ref frmSize);
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 4, 3);
            d = new Diag();
        }

        /// <summary>
        /// Perform various tasks when the load event is invoked
        /// (When the initialize component or the constructor is finished.).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmSkork_Load(object sender, EventArgs e) {
            addHandlers();
            addToLoad();
        }

        /// <summary>
        /// All dynamic event handlers.
        /// </summary>

        private void addHandlers() {
            lblZoom.MouseDown += lblZoom_MouseDown;
            ctxZoomFactor.ItemClicked += ctxZoomFactor_ItemClicked;
        }

        private void addToLoad() {
            string v = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Skork Application - " + v;
            this.txtCode.Text =
                "/**\n" +
                "Skork v: " + v + '\n' +
                "@author iReapism\n" +
                "*/\n\n";

            this.Icon = Properties.Resources.skork_icon;
        }

        private void frmSkork_Resize(object sender, EventArgs e) {
            Point p = new Point(this.Width, this.Height);
            UserInterface.drawMain(this, ref p);

        }

        private void txtCode_TextChanged(object sender, EventArgs e) {
            updateZoomFactor();
        }

        private void updateZoomFactor() {

            lblZoom.Text = txtCode.ZoomFactor * 100 + "%";
        }

        /// <summary>
        /// As long as each button child in the Parent ContextMenuStrip 
        /// has a psuedo float tag where 1 = 1.0, this will find it and
        /// convert it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ctxZoomFactor_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

            if (e.ClickedItem is ToolStripItem) {
                ToolStripMenuItem zoom = (ToolStripMenuItem)e.ClickedItem;

                try {
                    if (zoom.Tag.ToString() == null) {
                        return;
                    } else {
                        if (zoom.HasDropDownItems) {
                            foreach (ToolStripMenuItem i in zoom.DropDownItems) {
                                if (i.Tag.ToString().Contains('.')) {
                                    float zmFct = float.Parse(i.Tag.ToString());
                                    txtCode.ZoomFactor = zmFct;
                                    updateZoomFactor();
                                }
                            }
                        }

                        if (zoom.Tag.ToString().Contains('.')) {
                            float zmFct = float.Parse(zoom.Tag.ToString());
                            txtCode.ZoomFactor = zmFct;
                            updateZoomFactor();
                        } else if (zoom.Tag.ToString().ToLower() == "custom") {
                            string s = "Enter a custom amount.:";
                            if (d.showInputDialog(s).Equals(DialogResult.OK)) {

                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Show the ctxZoomFactor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lblZoom_MouseDown(object sender, MouseEventArgs e) {
            if (sender is ToolStripStatusLabel) {
                ToolStripStatusLabel lbl = (ToolStripStatusLabel)sender;
                // sender = (Label) sender; // explicit cast 
                ctxZoomFactor.Show(this, stsMain.Location.X, stsMain.Location.Y + stsMain.Height);
                //lbl.ForeColor = Color.Red;
            }
            updateZoomFactor();
        }

        /// <summary>
        /// While Ctrl + Scrolling, this will ensure the update of the
        /// zoom factor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtCode_MouseHover(object sender, EventArgs e) {
            updateZoomFactor();
        }

        private void btnCTXCompile_Click(object sender, EventArgs e) {
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 1, 3);
            Util u = new util.Util();
            
            if (txtCode.Text.Contains(u.readUntil(txtCode.Text, "S",";"))) {
                SkorkKeywords keyword = new SkorkKeywords();
                SkorkSprite s = new SkorkSprite();
                SkorkLeft left = new SkorkLeft();
                    keyword.addKeyword("Sprite", s);
                    keyword.invokeKeyword("True");
                    left.left(s, 4);
                if (keyword.isKeyword("True")) {

                }
            }
        }

        private void btnCTXCompileDebug_Click(object sender, EventArgs e) {
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 2, 3);
        }

        private void btnCTXSave_Click(object sender, EventArgs e) {
            OutlineBox o = new OutlineBox();
            o.outlineControl(ref picSyntax, 3, 3);
        }

        private void btnFile_Click(object sender, EventArgs e) {

        }

        private void getTextToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btnSettings_Click(object sender, EventArgs e) {
            FrmSettings s = new frm.FrmSettings();
            s.Show(this);
        }

        private void btnRedrawGrid_Click(object sender, EventArgs e) {
            SkorkPlane p = new SkorkPlane();
            p.drawPlane(ref pnlPlane, 4);
        }

        private void btnHelp_Click(object sender, EventArgs e) {

        }

        private void getLiensToolStripMenuItem_Click(object sender, EventArgs e) {
            Util u = new Util();
            string code = txtCode.Text;
            StringCollection sc = u.getLines(code);
            SkorkCode scc = new SkorkCode();
            //sc = scc.cleanCode(ref sc);

            
            MessageBox.Show("Hello mr. streamer2!");

            foreach(string item in sc) {
                MessageBox.Show(item);
            }
        }

        private void addKeyToolStripMenuItem_Click(object sender, EventArgs e) {
            SkorkInstructions si = new SkorkInstructions();
            Diag d = new Diag();

            si.createInt(d.showInputDialog("Enter a name:"), int.Parse(d.showInputDialog("Enter a value:")));
        }

        private void listKeyToolStripMenuItem_Click(object sender, EventArgs e) {
            SkorkInstructions si = new SkorkInstructions();
            si.getList();
        }

        private void validIdentiferToolStripMenuItem_Click(object sender, EventArgs e) {
            Diag d = new Diag();
            string identifier = d.showInputDialog("Enter an identifier: ");

            SkorkConventions sc = new SkorkConventions();
            MessageBox.Show(identifier + " is " + sc.isValidIdentifier(identifier));
        }
    }
}
