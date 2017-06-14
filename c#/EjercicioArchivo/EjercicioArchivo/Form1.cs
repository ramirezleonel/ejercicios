using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDirectorio.Text = "C:\\";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            listDirectorio.Clear();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            ListViewItem itemDeLista=new ListViewItem();
            fbd.SelectedPath = txtDirectorio.Text;
            //ruta seleccionada
            DirectoryInfo directorio = new DirectoryInfo(fbd.SelectedPath);
              List<DirectoryInfo> listaDir =new List<DirectoryInfo>();

            foreach (var dir in directorio.GetDirectories())
            {
                listDirectorio.Items.Add(dir.Name);
            }

            foreach (var item in directorio.GetFiles())
            {
                listDirectorio.Items.Add(item.Name);   
            }
            
        }

        private void listDirectorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDirectorio_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
