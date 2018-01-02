﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BND2Master
{
    public partial class VertexSizePicker : Form
    {
        public int VertexSize
        {
            get
            {
                string val = cboSelect.Text;

                int result;
                if (!int.TryParse(val, out result))
                    return -1;
                return result;
            }
        }

        private List<int> _vertexSizeList;
        public List<int> VertexSizeList
        {
            get { return _vertexSizeList; }
            set
            {
                _vertexSizeList = value;

                cboSelect.Items.Clear();
                foreach (int size in _vertexSizeList)
                {
                    cboSelect.Items.Add(size);
                }
                cboSelect.SelectedIndex = 0;
            }
        }

        public VertexSizePicker()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
