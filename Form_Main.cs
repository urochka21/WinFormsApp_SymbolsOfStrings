﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

using SearchTextSymbols = WinFormsApp_SymbolsOfStrings.SearchTextSymbols;

namespace WinFormsApp_SymbolsOfStrings
{
    public partial class form_Main : Form
    {
        SearchTextSymbols _searchTextSymbols = new SearchTextSymbols();
        public form_Main()
        {
            InitializeComponent();
            ArrayList arr_list = new ArrayList();
            arr_list.AddRange(listBox_Input.Items);
            string[] strs = arr_list.ToArray(typeof(string)) as string[];
            _searchTextSymbols.LoadStrings(ref strs);
        }

        private void listBox_Input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _searchTextSymbols.Clear_Strings();
            listBox_Input.Items.Clear();
            toolStripStatusLabel.Text = "Выполнена очистка строк!"; 
        }

        private void button_FindLetter_Click(object sender, EventArgs e)
        {
            char ch_letter = textBox_Letter.Text[0];
            int count_letter = _searchTextSymbols.Search_Num_Of_Letter(ch_letter);
            string str = "Символ " + ch_letter.ToString() + " встречается в тексте " +
               count_letter.ToString() + " раз!";
            toolStripStatusLabel.Text = str;
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_name = openFileDialog.FileName;
                listBox_Input.Items.Clear();
                using (StreamReader r = new StreamReader(file_name, Encoding.Default))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox_Input.Items.Add(line);
                    }
                }
                ArrayList arr_list = new ArrayList();
                arr_list.AddRange(listBox_Input.Items);
                string[] strs = arr_list.ToArray(typeof(string)) as string[];
                _searchTextSymbols.LoadStrings(ref strs);
            }
        }
    }
}
