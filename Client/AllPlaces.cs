using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AllPlaces : Form
    {
        private List<string> _ten;
        public List<string> ten
        {
            set { _ten = value; }
        }
        private List<string> _ma_so;
        public List<string> ma_so
        {
            set { _ma_so = value; }
        }
        private List<string> _kinh_do;
        public List<string> kinh_do
        {
            set { _kinh_do = value; }
        }
        private List<string> _vi_do;
        public List<string> vi_do
        {
            set { _vi_do = value; }
        }
        private List<string> _mo_ta;
        public List<string> mo_ta
        {
            set { _mo_ta = value; }
        }
        public AllPlaces()
        {
            InitializeComponent();
        }
        private void ManyObj_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _ten.Count - 1; i++)
            {
                for (int j = i + 1; j < _ten.Count; j++)
                {
                    if (Int32.Parse(_ma_so[i]) > Int32.Parse(_ma_so[j]))
                    {
                        string temp1 = _ma_so[i];
                        string temp2 = _ten[i];
                        string temp3 = _kinh_do[i];
                        string temp4 = _vi_do[i];
                        string temp5 = _mo_ta[i];

                        _ma_so[i] = _ma_so[j];
                        _ma_so[j] = temp1;

                        _ten[i] = _ten[j];
                        _ten[j] = temp2;

                        _kinh_do[i] = _kinh_do[j];
                        _kinh_do[j] = temp3;

                        _vi_do[i] = _vi_do[j];
                        _vi_do[j] = temp4;

                        _mo_ta[i] = _mo_ta[j];
                        _mo_ta[j] = temp5;
                    }
                }
            }
            for (int i = 0; i < _ten.Count; i++)
            {
                 string[] row = { _ma_so[i], _ten[i], _kinh_do[i], _vi_do[i], _mo_ta[i]};
                 var listViewItem = new ListViewItem(row);
                 listView1.Items.Add(listViewItem);
            }
        }
    }
}
