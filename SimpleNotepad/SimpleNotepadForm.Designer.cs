
namespace SimpleNotepad
{
    partial class SimpleNotepadForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (m_DocumentChanged)
                MenuFileSaveAs();

            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleNotepadForm));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSavesAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFormatColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatCharacterStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatBold = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatStrikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatParagraphAligment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatAligmentLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatAligmentRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatAligmentCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripbtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrint = new System.Windows.Forms.ToolStripButton();
            this.menuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuFormat,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFilePageSetup,
            this.printPreviewToolStripMenuItem,
            this.menuFilePrint,
            this.toolStripMenuItem1,
            this.menuFileSave,
            this.menuFileSavesAs,
            this.menuFileExit,
            this.toolStripMenuItem2});
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(180, 22);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(184, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFilePageSetup
            // 
            this.menuFilePageSetup.Name = "menuFilePageSetup";
            this.menuFilePageSetup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuFilePageSetup.Size = new System.Drawing.Size(184, 22);
            this.menuFilePageSetup.Text = "&Page Setup...";
            this.menuFilePageSetup.Click += new System.EventHandler(this.menuFilePageSetup_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.printPreviewToolStripMenuItem.Text = "P&rint Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuFilePrint.Size = new System.Drawing.Size(184, 22);
            this.menuFilePrint.Text = "P&rint";
            this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(184, 22);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSavesAs
            // 
            this.menuFileSavesAs.Name = "menuFileSavesAs";
            this.menuFileSavesAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuFileSavesAs.Size = new System.Drawing.Size(184, 22);
            this.menuFileSavesAs.Text = "Sa&ves As...";
            this.menuFileSavesAs.Click += new System.EventHandler(this.menuFileSavesAs_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuFileExit.Size = new System.Drawing.Size(184, 22);
            this.menuFileExit.Text = "&Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditRedo,
            this.menuEditUndo,
            this.toolStripMenuItem3,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditDelete,
            this.toolStripMenuItem4,
            this.menuEditSelectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "E&dit";
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.Size = new System.Drawing.Size(180, 22);
            this.menuEditRedo.Text = "Re&do";
            this.menuEditRedo.Click += new System.EventHandler(this.menuEditRedo_Click);
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuEditUndo.Size = new System.Drawing.Size(180, 22);
            this.menuEditUndo.Text = "U&ndo";
            this.menuEditUndo.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCut.Size = new System.Drawing.Size(180, 22);
            this.menuEditCut.Text = "C&ut";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuEditCopy.Size = new System.Drawing.Size(180, 22);
            this.menuEditCopy.Text = "C&opy";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuEditPaste.Size = new System.Drawing.Size(180, 22);
            this.menuEditPaste.Text = "P&aste";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuEditDelete
            // 
            this.menuEditDelete.Name = "menuEditDelete";
            this.menuEditDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuEditDelete.Size = new System.Drawing.Size(180, 22);
            this.menuEditDelete.Text = "D&elete";
            this.menuEditDelete.Click += new System.EventHandler(this.menuEditDelete_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(119, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuEditSelectAll.Size = new System.Drawing.Size(180, 22);
            this.menuEditSelectAll.Text = "S&elect All";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatFont,
            this.toolStripMenuItem5,
            this.menuFormatColor,
            this.menuFormatCharacterStyle,
            this.menuFormatParagraphAligment});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(57, 20);
            this.menuFormat.Text = "F&ormat";
            // 
            // menuFormatFont
            // 
            this.menuFormatFont.Name = "menuFormatFont";
            this.menuFormatFont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuFormatFont.Size = new System.Drawing.Size(221, 22);
            this.menuFormatFont.Text = "F&ont...";
            this.menuFormatFont.Click += new System.EventHandler(this.menuFormatFont_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFormatColor
            // 
            this.menuFormatColor.Name = "menuFormatColor";
            this.menuFormatColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuFormatColor.Size = new System.Drawing.Size(221, 22);
            this.menuFormatColor.Text = "Co&lor...";
            this.menuFormatColor.Click += new System.EventHandler(this.menuFormatColor_Click);
            // 
            // menuFormatCharacterStyle
            // 
            this.menuFormatCharacterStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatBold,
            this.menuFormatItalic,
            this.menuFormatUnderline,
            this.menuFormatStrikeout});
            this.menuFormatCharacterStyle.Name = "menuFormatCharacterStyle";
            this.menuFormatCharacterStyle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuFormatCharacterStyle.Size = new System.Drawing.Size(221, 22);
            this.menuFormatCharacterStyle.Text = "Cha&racter Style...";
            // 
            // menuFormatBold
            // 
            this.menuFormatBold.Name = "menuFormatBold";
            this.menuFormatBold.Size = new System.Drawing.Size(125, 22);
            this.menuFormatBold.Text = "Bold";
            this.menuFormatBold.Click += new System.EventHandler(this.menuFormatBold_Click);
            // 
            // menuFormatItalic
            // 
            this.menuFormatItalic.Name = "menuFormatItalic";
            this.menuFormatItalic.Size = new System.Drawing.Size(125, 22);
            this.menuFormatItalic.Text = "Italic";
            this.menuFormatItalic.Click += new System.EventHandler(this.menuFormatItalic_Click);
            // 
            // menuFormatUnderline
            // 
            this.menuFormatUnderline.Name = "menuFormatUnderline";
            this.menuFormatUnderline.Size = new System.Drawing.Size(125, 22);
            this.menuFormatUnderline.Text = "Underline";
            this.menuFormatUnderline.Click += new System.EventHandler(this.menuFormatUnderline_Click);
            // 
            // menuFormatStrikeout
            // 
            this.menuFormatStrikeout.Name = "menuFormatStrikeout";
            this.menuFormatStrikeout.Size = new System.Drawing.Size(125, 22);
            this.menuFormatStrikeout.Text = "Strikeout";
            this.menuFormatStrikeout.Click += new System.EventHandler(this.menuFormatStrikeout_Click);
            // 
            // menuFormatParagraphAligment
            // 
            this.menuFormatParagraphAligment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatAligmentLeft,
            this.menuFormatAligmentRight,
            this.menuFormatAligmentCenter});
            this.menuFormatParagraphAligment.Name = "menuFormatParagraphAligment";
            this.menuFormatParagraphAligment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuFormatParagraphAligment.Size = new System.Drawing.Size(221, 22);
            this.menuFormatParagraphAligment.Text = "Par&agraph Aligment";
            // 
            // menuFormatAligmentLeft
            // 
            this.menuFormatAligmentLeft.Name = "menuFormatAligmentLeft";
            this.menuFormatAligmentLeft.Size = new System.Drawing.Size(109, 22);
            this.menuFormatAligmentLeft.Text = "Left";
            this.menuFormatAligmentLeft.Click += new System.EventHandler(this.menuFormatAligmentLeft_Click);
            // 
            // menuFormatAligmentRight
            // 
            this.menuFormatAligmentRight.Name = "menuFormatAligmentRight";
            this.menuFormatAligmentRight.Size = new System.Drawing.Size(109, 22);
            this.menuFormatAligmentRight.Text = "Right";
            this.menuFormatAligmentRight.Click += new System.EventHandler(this.menuFormatAligmentRight_Click);
            // 
            // menuFormatAligmentCenter
            // 
            this.menuFormatAligmentCenter.Name = "menuFormatAligmentCenter";
            this.menuFormatAligmentCenter.Size = new System.Drawing.Size(109, 22);
            this.menuFormatAligmentCenter.Text = "Center";
            this.menuFormatAligmentCenter.Click += new System.EventHandler(this.menuFormatAligmentCenter_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "H&elp";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.menuHelpAbout.Text = "A&bout";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "RTF files | *.rtf |Text files| *.text| All Files| *.*";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtnNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripbtnCut,
            this.toolStripBtnCopy,
            this.toolStripbtnPaste,
            this.toolStripbtnPreview,
            this.toolStripPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripbtnNew
            // 
            this.toolStripbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnNew.Image")));
            this.toolStripbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnNew.Name = "toolStripbtnNew";
            this.toolStripbtnNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnNew.Text = "toolStripButton1";
            this.toolStripbtnNew.ToolTipText = "New";
            this.toolStripbtnNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpen.Text = "toolStripButton2";
            this.toolStripOpen.ToolTipText = "Open";
            this.toolStripOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripSave.Text = "toolStripButton3";
            this.toolStripSave.ToolTipText = "Save";
            this.toolStripSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // toolStripbtnCut
            // 
            this.toolStripbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnCut.Image")));
            this.toolStripbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnCut.Name = "toolStripbtnCut";
            this.toolStripbtnCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnCut.Text = "toolStripButton4";
            this.toolStripbtnCut.ToolTipText = "Cut";
            this.toolStripbtnCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // toolStripBtnCopy
            // 
            this.toolStripBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCopy.Image")));
            this.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCopy.Name = "toolStripBtnCopy";
            this.toolStripBtnCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCopy.Text = "toolStripButton5";
            this.toolStripBtnCopy.ToolTipText = "Copy";
            this.toolStripBtnCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // toolStripbtnPaste
            // 
            this.toolStripbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnPaste.Image")));
            this.toolStripbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnPaste.Name = "toolStripbtnPaste";
            this.toolStripbtnPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnPaste.Text = "toolStripButton6";
            this.toolStripbtnPaste.ToolTipText = "Paste";
            this.toolStripbtnPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // toolStripbtnPreview
            // 
            this.toolStripbtnPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnPreview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnPreview.Image")));
            this.toolStripbtnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnPreview.Name = "toolStripbtnPreview";
            this.toolStripbtnPreview.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnPreview.Text = "toolStripButton7";
            this.toolStripbtnPreview.ToolTipText = "Preview";
            this.toolStripbtnPreview.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrint.Image")));
            this.toolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripPrint.Text = "New";
            this.toolStripPrint.ToolTipText = "Print";
            this.toolStripPrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // SimpleNotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "SimpleNotepadForm";
            this.Text = "Simple Notepad";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuFilePageSetup;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSavesAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStripMenuItem menuFormatFont;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.IO.StringReader myreader;
        private uint m_PrintPageNumber;
        private bool m_DocumentChanged = false;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFormatColor;
        private System.Windows.Forms.ToolStripMenuItem menuEditRedo;
        private System.Windows.Forms.ToolStripMenuItem menuFormatCharacterStyle;
        private System.Windows.Forms.ToolStripMenuItem menuFormatBold;
        private System.Windows.Forms.ToolStripMenuItem menuFormatItalic;
        private System.Windows.Forms.ToolStripMenuItem menuFormatUnderline;
        private System.Windows.Forms.ToolStripMenuItem menuFormatStrikeout;
        private System.Windows.Forms.ToolStripMenuItem menuFormatParagraphAligment;
        private System.Windows.Forms.ToolStripMenuItem menuFormatAligmentLeft;
        private System.Windows.Forms.ToolStripMenuItem menuFormatAligmentRight;
        private System.Windows.Forms.ToolStripMenuItem menuFormatAligmentCenter;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripbtnNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripbtnCut;
        private System.Windows.Forms.ToolStripButton toolStripBtnCopy;
        private System.Windows.Forms.ToolStripButton toolStripbtnPaste;
        private System.Windows.Forms.ToolStripButton toolStripbtnPreview;
        private System.Windows.Forms.ToolStripButton toolStripPrint;
    }
}

