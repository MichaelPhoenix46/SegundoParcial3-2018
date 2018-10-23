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
    public partial class Registro : Form
    {
        private RepositorioBase<Vendedores> repositorio;
        public List<MetasDetalle> Detalle { get; set; }
        public Registro()
        {
            InitializeComponent();
            this.Detalle = new List<MetasDetalle>();

        }
        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }



        private bool Validar()
        {
            bool errores = false; 

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                VendedoreserrorProvider.SetError(NombretextBox, "Llenar el nombre");
                errores = true;
                
            }

            if (SueldonumericUpDown.Value == 0 || PorRetencionnumericUpDown.Value == 0)
            {
                VendedoreserrorProvider.SetError(SueldonumericUpDown, "Llenar el Sueldo, si esta en 0");
                VendedoreserrorProvider.SetError(PorRetencionnumericUpDown, "Llenar Porciento, si esta en 0");
                errores = true;
            }
            if (RetencionnumericUpDown.Value == 0)
            {

                VendedoreserrorProvider.SetError(RetencionnumericUpDown, "Si los campos de sueldo y porciento estan llenos, debe dar click en la flecha de retencion para llenarla");
                errores = true;
            }



            return errores;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Vendedores>();
            Vendedores vendedor = repositorio.Buscar((int)VendedornumericUpDown.Value);
            return (vendedor != null);
        }

        private void Limpiar()
        {

            VendedornumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            SueldonumericUpDown.Value = 0;
            PorRetencionnumericUpDown.Value = 0;
            RetencionnumericUpDown.Value = 0;

            VendedoreserrorProvider.Clear();
            this.Detalle = new List<MetasDetalle>();
            CargarGrid();
        }

        public Vendedores Llenaclase()
        {
            Vendedores vendedores = new Vendedores();
            vendedores.Vendedorid = Convert.ToInt32(VendedornumericUpDown.Value);
            vendedores.Nombres = NombretextBox.Text;
            vendedores.Sueldo = SueldonumericUpDown.Value;
            vendedores.Retencion = RetencionnumericUpDown.Value;
            vendedores.PorRetencion = PorRetencionnumericUpDown.Value;

            vendedores.Metas = this.Detalle;
            return vendedores;
        }
        private void LlenaCampo(Vendedores vendedor)
        {
            VendedornumericUpDown.Value = vendedor.Vendedorid;
            NombretextBox.Text = vendedor.Nombres;
            SueldonumericUpDown.Value = Convert.ToDecimal(vendedor.Sueldo);
            RetencionnumericUpDown.Value = Convert.ToDecimal(vendedor.PorRetencion);
            RetencionnumericUpDown.Value = vendedor.PorRetencion;
            FechadateTimePicker.Value = vendedor.Fecha;

            this.Detalle = vendedor.Metas;
            CargarGrid();
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Metas> metas = new RepositorioBase<Metas>();
            MetacomboBox.DataSource = metas.GetList(x => true);
            MetacomboBox.ValueMember = "MetaId";
            MetacomboBox.DisplayMember = "MetaId";
        }



        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>();
            Vendedores vendedor;
            bool paso = false;
            if (!Validar())
                return;

            vendedor = Llenaclase();
            if (VendedornumericUpDown.Value == 0)
                paso = repositorio.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    return;
                }
                paso = repositorio.Modificar(vendedor);
            }
            if (paso)
            {
                MessageBox.Show("Vendedor Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RetencionnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Validar())
            {
                MessageBox.Show("llenar el campo vacio", "trate de guardar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            if (SueldonumericUpDown.Value != 0 && PorRetencionnumericUpDown.Value != 0)
            {
                
                RetencionnumericUpDown.Value = SueldonumericUpDown.Value * (PorRetencionnumericUpDown.Value/100);
                

            }
            else
            {
                MessageBox.Show("algun campo no esta lleno correctamente", "trate de nuevo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>();
            VendedoreserrorProvider.Clear();
            int id;
            int.TryParse(VendedornumericUpDown.Text, out id);

            if (!ExisteEnLaBaseDeDatos())
            {
                VendedoreserrorProvider.SetError(VendedornumericUpDown, "No puedes Borrar Un Vendedor Inexistente");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Vendedor Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<Vendedores>();
            Vendedores vendedor = new Vendedores();
            int.TryParse(VendedornumericUpDown.Text, out id);

            vendedor = repositorio.Buscar(id);

            if (vendedor != null)
            {
                VendedoreserrorProvider.Clear();
                
                MessageBox.Show("Vendedor Encontrado!!!", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vendedor no Encontrado!!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SueldonumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PorRetencionnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendedornumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<MetasDetalle>)DetalledataGridView.DataSource;
            this.Detalle.Add(
                new MetasDetalle(
                    detallesid: 0,
                    metaid: MetacomboBox.SelectedIndex,
                    vendedorid: (int)VendedornumericUpDown.Value,
                    cuota: Convert.ToDecimal(CuotasnumericUpDown.Value)

                    )
                );
            VendedoreserrorProvider.Clear();
            CargarGrid();
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        
        }


    }




}





