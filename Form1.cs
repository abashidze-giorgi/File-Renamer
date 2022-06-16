using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Renamer
{
    public partial class Form1 : Form
    {
        string folderPath;

        long nameNum = 1;

        string tempName;

        bool numerateEnabled = false;

        bool extEnabled = false;

        bool addSymbolEnabled = false;

        List<string> selectedExt = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            
            SelectFolder();
            FillForm();
        }

        private void FillForm()
        {
            ClearForm();
            FillList();
        }
        private void FillList()
        {
            try
            {
                string[] GetFiles = Directory.GetFiles(folderPath);
                foreach(var i in GetFiles)
                {
                    listBox1.Items.Add(i);
                    GetExtention(i.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearForm()
        {
            try
            {
                nameNum = 1;

                numerateEnabled = false;
                extEnabled = false;
                addSymbolEnabled = false;

                ClearLblFolder();
                ClearListBox();
                ClearCheckBoxes();
                ClearAddSymbols();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearLblFolder()
        {
            lbl_folder.Text = "...";
        }

        private void ClearAddSymbols()
        {
            txt_beaf_1.Clear();
            txt_beaf_2.Clear();
            txt_beaf_2.Visible = false;
            pnl_symb.Enabled = false;
            check_add_sym.Checked = false;
        }

        private void ClearCheckBoxes()
        {
            chk_numbers.Checked = false;
            chk_ext.Checked = false;
            chk_ext_list.Items.Clear();

        }

        private void ClearListBox()
        {
            listBox1.Items.Clear();
        }

        private void GetExtention(string i)
        {
            string fileName = Path.GetFileName(i);
            string[] splittedExt = fileName.Split('.');
            string ext = splittedExt[splittedExt.Length-1].ToString();
            Check_Extention(ext);
        }

        private void Check_Extention(string ext)
        {
            try
            {
                bool extExist = false;
                foreach(var i in chk_ext_list.Items)
                {
                    if (string.IsNullOrEmpty(i.ToString()))
                    {
                        return;
                    }
                    else
                    {
                        if(i.ToString() == ext)
                        {
                            extExist = true;
                            return;
                        }
                    }
                }
                if (!extExist)
                {
                    chk_ext_list.Items.Add(ext);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectFolder()
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.ShowDialog();
                folderPath = dlg.SelectedPath;
                lbl_folder.Text = folderPath;
            }
        }

        private void chk_ext_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ext.Checked)
            {
                chk_ext_list.Enabled = true;
                extEnabled = true;
            }
            else
            {
                extEnabled = false;
                chk_ext_list.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chk_ext_list.Enabled = false;
            pnl_symb.Enabled = false;
            txt_beaf_2.Visible = false;
            cmb_sym.SelectedIndex = 0;
        }

        private void check_add_sym_CheckedChanged(object sender, EventArgs e)
        {
            if (check_add_sym.Checked)
            {
                addSymbolEnabled = true;
                pnl_symb.Enabled = true;
            }
            else
            {
                addSymbolEnabled &= false;
                cmb_sym.SelectedIndex = 0;
                pnl_symb.Enabled = false;
            }
        }

        private void cmb_sym_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_sym.SelectedIndex)
            {
                case 0:
                    AddBeforeName();
                    break;

                case 1:
                    AddAfterName();
                    break;

                case 2:
                    AddBeforeAndAfter();
                    break;
            }
        }

        private void AddBeforeAndAfter()
        {
            txt_beaf_2.Visible = true;
            txt_beaf_1.Visible = true;
            lbl_bef_aft.Text = "+ name +";
        }

        private void AddAfterName()
        {
            txt_beaf_2.Clear();
            txt_beaf_1.Clear();
            lbl_bef_aft.Text = "name +";
            txt_beaf_1.Visible = false;
            txt_beaf_2.Visible = true;
        }

        private void AddBeforeName()
        {
            txt_beaf_2.Clear();
            txt_beaf_1.Clear();
            lbl_bef_aft.Text = "+ name";
            txt_beaf_2.Visible = false;
            txt_beaf_1.Visible = true;
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            RenameFiles();
        }

        private void RenameFiles()
        {
            FillSelectedExtentions();
            GetFiles();
        }

        private void GetFiles()
        {
            string[] GetFiles = Directory.GetFiles(folderPath);

            foreach (string file in GetFiles)
            {
                string tempFile = Path.GetFileName(file);

                string[] splittedFileName = tempFile.Split('.');

                tempName = splittedFileName[0].ToString();
                string newExt = splittedFileName[1].ToString();
                if(extEnabled == false)
                {
                    FormatName(file, newExt);
                }else
                {
                    foreach(var i in selectedExt)
                    {
                        if (i.ToString() == newExt)
                        {
                            FormatName(file, newExt);
                            break;
                        }
                    }
                }
            }

            FillForm();
        }

        private void FormatName(string file, string ext)
        {
            CheckIfNumbersEnabled();
            CheckIfSymbolAddEnabled();
            tempName = folderPath + "\\" + tempName + "." + ext;
            RenameFile(file);
        }

        private void RenameFile(string file)
        {
            try
            {
                if (!File.Exists(tempName))
                {
                    System.IO.File.Move(file, tempName);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void CheckIfSymbolAddEnabled()
        {
            if (addSymbolEnabled)
            {
                string temp1 = "";
                string temp2 = "";
                if (!string.IsNullOrEmpty(txt_beaf_1.Text.ToString()))
                {
                    temp1 = txt_beaf_1.Text.ToString();
                }
                if (!string.IsNullOrEmpty(txt_beaf_2.Text.ToString()))
                {
                    temp2 = txt_beaf_2.Text.ToString();
                }
                tempName = temp1 + tempName + temp2;
            }
        }

        private void CheckIfNumbersEnabled()
        {
            if (chk_numbers.Checked)
            {
                if(nameNum < 10)
                {
                    tempName = "0" + nameNum.ToString();
                }
                else
                {
                    tempName = nameNum.ToString();
                }
                nameNum++;
            }
        }

        private void chk_numbers_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_numbers.Checked)
            {
                numerateEnabled = true;
            }
            else
            {
                numerateEnabled = false;
            }
        }

        private void FillSelectedExtentions()
        {
            if (extEnabled)
            {
                selectedExt.Clear();
                foreach (object i in chk_ext_list.CheckedItems)
                {
                    selectedExt.Add(i.ToString());
                }
            }
        }
    }
}
