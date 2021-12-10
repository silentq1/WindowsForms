using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private BindingSource postBindingSource;
        private void Form3_Load(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            postBindingSource = new BindingSource(rbProductDataSet1, "Поставщики");
            NametextBox.DataBindings.Add("Text", postBindingSource, "Поставщик");
            SectiontextBox.DataBindings.Add("Text", postBindingSource, "Адрес поставщика");
            
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            postBindingSource.MoveNext();
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            postBindingSource.MovePrevious();
        }
    }
}
