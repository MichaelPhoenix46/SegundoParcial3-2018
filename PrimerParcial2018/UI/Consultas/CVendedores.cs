using PrimerParcial2018.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial2018.UI.Consultas
{
    public partial class CVendedores : Form
    {
        public CVendedores()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Vendedores, bool>> filtro = x => true;

            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.Vendedorid == id
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 1:// nombre
                    filtro = x => x.Nombres.Contains(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2:// Sueldo
                    filtro = x => x.Sueldo.Equals(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 3:// Retencion Total
                    filtro = x => x.Retencion.Equals(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 4:// porciento de retencion
                    filtro = x => x.PorRetencion.Equals(CriteriotextBox)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 5: //Todo
                    filtro = x => true;
                    if (BLL.VendedoresBLL.GetList(filtro).Count() == 0)
                    {
                        MessageBox.Show("Base de datos Vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
            ConsultadataGridView.DataSource = BLL.VendedoresBLL.GetList(filtro);
        }


    }
}
