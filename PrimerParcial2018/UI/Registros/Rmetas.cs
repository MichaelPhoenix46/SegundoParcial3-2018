using PrimerParcial2018.BLL;
using PrimerParcial2018.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial2018.UI.Registros
{
    public partial class Rmetas : Form
    {
        private RepositorioBase<Metas> repositorio;
        public Rmetas()
        {
            InitializeComponent();
        }

        public Metas Llenaclase()
        {
            Metas metas = new Metas();
            metas.MetasId = Convert.ToInt32(MetasnumericUpDown.Value);
            metas.Descripcion = DescripcionmetastextBox.Text;
            metas.Cuotas = CuotanumericUpDown.Value;


            return metas;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Metas>();
            Metas meta = repositorio.Buscar((int)MetasnumericUpDown.Value);
            return (meta != null);
        }

        private void Limpiar()
        {

            MetasnumericUpDown.Value = 0;
            DescripcionmetastextBox.Text = string.Empty;
            CuotanumericUpDown.Value = 0;


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Metas>();
            Metas meta;
            bool paso = false;
            meta = Llenaclase();
            if (MetasnumericUpDown.Value == 0)
                paso = repositorio.Guardar(meta);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    return;
                }
                paso = repositorio.Modificar(meta);
            }
            if (paso)
            {
                MessageBox.Show("Vendedor Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
