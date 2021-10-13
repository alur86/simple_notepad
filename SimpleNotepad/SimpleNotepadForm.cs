using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;


namespace SimpleNotepad
{
    public partial class SimpleNotepadForm : Form
    {
        public SimpleNotepadForm()
        {
            InitializeComponent();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {

            if (m_DocumentChanged)
                MenuFileSaveAs();
            richTextBox1.Clear();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            MenuFileOpen();

        }

        public void MenuFileOpen() {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0) {

                {
                    try
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    catch (System.ArgumentException ex)
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                    }

                }
                this.Text = "File [" + openFileDialog1.FileName + "]";
            }

        }





        private void MenuFileSaveAs()
        {


            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                m_DocumentChanged = false;
             
            }

        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            MenuFileSaveAs();
        }

        private void menuFileSavesAs_Click(object sender, EventArgs e)
        {
            MenuFileSaveAs();
        }

        private void menuFilePageSetup_Click(object sender, EventArgs e)
        {
            MenuFileSetupDialog();
        }

        private void MenuFileSetupDialog()
        {

            pageSetupDialog1.ShowDialog();
        }


        private void MenuFilePrintPreview() 
        {
            m_PrintPageNumber = 1;
            string strText = this.richTextBox1.Text;
            myreader = new StringReader(strText);
            Margins margin = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margin;
            printPreviewDialog1.ShowDialog();
            myreader.Close();
       }


        private void MenuFilePrint()
        {
            m_PrintPageNumber = 1;
            string strText = this.richTextBox1.Text;
            myreader = new StringReader(strText);
            Margins margin = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margin;
            if (printDialog1.ShowDialog() ==DialogResult.OK)
            {
                this.printDocument1.Print();
            }
            myreader.Close();
        }


        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFilePrintPreview();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            if (m_DocumentChanged)
                MenuFileSaveAs();
                 this.Close();
        }

        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            MenuFilePrint();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            m_DocumentChanged = true;
        }

        private void menuEditUndo_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void menuEditRedo_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void menuEditCut_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();

        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void menuEditDelete_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void menuEditSelectAll_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();

        }

        private void menuFormatFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }

        }

        private void menuFormatColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void menuFormatBold_Click(object sender, EventArgs e)
        {
            SetBold();
        }

        private void menuFormatItalic_Click(object sender, EventArgs e)
        {
            SetItalic();
        }

        private void menuFormatUnderline_Click(object sender, EventArgs e)
        {
            SetUnderline();
        }

        private void menuFormatStrikeout_Click(object sender, EventArgs e)
        {
            SetStrikeout();
        }

        private void SetBold()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }

        private void CheckMenuFontCharacterStyle()
        {
            if (richTextBox1.SelectionFont.Bold == true)
            {
                menuFormatBold.Checked = true;
            }
            else
            {
                menuFormatBold.Checked = false;
            }

            if (richTextBox1.SelectionFont.Italic == true)
            {
                menuFormatItalic.Checked = true;
            }
            else
            {
                menuFormatItalic.Checked = false;
            }

            if (richTextBox1.SelectionFont.Underline == true)
            {
                menuFormatUnderline.Checked = true;
            }
            else
            {
                menuFormatUnderline.Checked = false;
            }

            if (richTextBox1.SelectionFont.Strikeout == true)
            {
                menuFormatStrikeout.Checked = true;
            }
            else
            {
                menuFormatStrikeout.Checked = false;
            }
           }

        private void SetItalic()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                CheckMenuFontCharacterStyle();

                if (richTextBox1.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }

     
        private void SetUnderline()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                CheckMenuFontCharacterStyle();

                if (richTextBox1.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }

        private void SetStrikeout()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Strikeout == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Strikeout;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }

        private void menuFormatAligmentLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void menuFormatAligmentRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void menuFormatAligmentCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            
            using (HelpAboutForm helpAboutForm = new HelpAboutForm())
                    helpAboutForm.ShowDialog(this);
            
        }

     
    }

}


    

