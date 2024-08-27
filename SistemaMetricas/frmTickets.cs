using SistemaMetricas.Models;
using SistemaMetricas.Services.Handlers;
using SistemaMetricas.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmTickets : Form
    {
        TicketService ticketService = new TicketService();
        AreaService areaService = new AreaService();
        TipoService tipoService = new TipoService();
        string id = string.Empty;
        public frmTickets()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void GetAreas()
        {
            cmbAreas.DataSource = areaService.GetAreas();
            cmbAreas.DisplayMember = "Area";
            cmbAreas.ValueMember = "Area";
        }
        private void GetTipos()
        {
            cmbTipos.DataSource = tipoService.GetTipos();
            cmbTipos.DisplayMember = "Tipo";
            cmbTipos.ValueMember = "Tipo";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetTickets()
        {
            grdDatos.DataSource = ticketService.GetTicketDt();
            btnAlert.Visible=false;
        }
        private void frmTickets_Load(object sender, EventArgs e)
        {
            GetTickets();
            GetAreas();
            GetTipos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTicket();
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdDatos.Rows[e.RowIndex];
            //Terminado
            //Pendiente
            //En Curso
            //Rechazado
            
            id = row.Cells["Id"].Value.ToString();

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //MessageBox.Show("ID seleccionado: " + id.ToString());
                btnEditar.Visible = true;
                txtTitulo.Text = row.Cells["Titulo"].Value.ToString();
                cmbAreas.Text = row.Cells["Area"].Value.ToString();
                cmbTipos.Text = row.Cells["Tipos"].Value.ToString();
                cmbPrioridad.Text = row.Cells["Prioridad"].Value.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value.ToString();
                textBoxDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                btnEditar.Visible = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DialogResult dialogo = MessageBox.Show("Continuar con la eliminación", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (dialogo == DialogResult.OK)
                {
                    
                    if (ticketService.EliminarTicket(id))
                    {
                        btnAlert.Text = "Ticket eliminado correctamente.";
                        btnAlert.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        btnAlert.Text = "Ocurrió un problema al eliminar el Ticket.";
                        btnAlert.BackColor = Color.Crimson;
                    }
                    btnAlert.Visible = true;
                    GetTickets();
                }

            }
        }
        private void EditarTicket()
        {
            Ticket newTicket = new Ticket();
            newTicket.Id = Convert.ToInt32(id);
            newTicket.Titulo = txtTitulo.Text;
            newTicket.Area = cmbAreas.Text;
            newTicket.Prioridad = cmbPrioridad.Text;
            newTicket.Tipos = cmbTipos.Text;
            newTicket.Estado = cmbEstado.Text;
            newTicket.Descripcion = textBoxDescripcion.Text;

            if (txtTitulo.Text == "" || textBoxDescripcion.Text == "")
            {
                btnAlert.Text = "Completar los datos vacios.";
                btnAlert.ForeColor = Color.Crimson;
                btnAlert.Visible = true;
                return;
            }

            bool result = ticketService.EditarTicket(newTicket);

            if (result)
            {
                btnAlert.Text = "Ticket Editado Correctamente!";
                btnAlert.ForeColor = Color.ForestGreen;
                btnAlert.Visible = true;   
                GetTickets();
            }
            else
            {
                btnAlert.Text = "La operación no pudo completarse ＼（〇_ｏ）／";
                btnAlert.ForeColor = Color.Crimson;

            }

        }

        private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Mismos colores que los reportes, así se asocia de uno para el otro
            if (grdDatos.Columns[e.ColumnIndex].Name == "Estado")
            {
                DataGridViewRow row = grdDatos.Rows[e.RowIndex];
                string estado = row.Cells["Estado"].Value?.ToString();

                if (estado == "Pendiente")
                {
                    row.DefaultCellStyle.BackColor = Color.Goldenrod;
                }
                else if (estado == "En Curso")
                {
                    row.DefaultCellStyle.BackColor = Color.RoyalBlue;
                }
                else if (estado == "Rechazado")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LawnGreen;
                }
            }
        }
    }
}
