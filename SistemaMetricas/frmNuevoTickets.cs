using SistemaMetricas.Models;
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
    public partial class frmNuevoTickets : Form
    {
        TicketService ticketService = new TicketService();
        AreaService areaService = new AreaService();
        TipoService tipoService = new TipoService();

        public frmNuevoTickets()
        {
            InitializeComponent();
        }

        private void frmNuevoTickets_Load(object sender, EventArgs e)
        {
            GetAreas();
            GetTipos();
            cmbPrioridad.SelectedIndex = 2; //Te preselecciona dicho elemento del desplegable

        }
        private void GetAreas()//Llenar el combo box con los datos de la Bdd
        {
            cmbAreas.DataSource = areaService.GetAreas();
            cmbAreas.DisplayMember = "Area";//Te muestra lo que quieras que se vea en el desplegable
            cmbAreas.ValueMember = "Area";//Te muestra el valor que te llevás al BackEnd, vendría a ser el value de un option de un select en HTML
        }
        private void GetTipos()//Llenar el combo box con los datos de la Bdd
        {
            cmbTipos.DataSource = tipoService.GetTipos();
            cmbTipos.DisplayMember = "Tipo";//Te muestra lo que quieras que se vea en el desplegable
            cmbTipos.ValueMember = "Tipo";//Te muestra el valor que te llevás al BackEnd, vendría a ser el value de un option de un select en HTML
        }
        private void CreateTicket()
        {
            Ticket newTicket = new Ticket();
            newTicket.Titulo = txtTitulo.Text;
            newTicket.Area = cmbAreas.Text;
            newTicket.Prioridad = cmbPrioridad.Text;
            newTicket.Tipos = cmbTipos.Text;
            newTicket.Descripcion = textBoxDescripcion.Text;

            if(txtTitulo.Text == "" || textBoxDescripcion.Text == "")
            {
                lblAlert.Text = "Completar los datos vacios.";
                lblAlert.ForeColor = Color.Crimson;
                return;
            }

            bool result = ticketService.CreateTicket(newTicket);

            if(result)
            {
                lblAlert.Text = "Ticket Creado Correctamente!";
                lblAlert.ForeColor = Color.ForestGreen;
                txtTitulo.Text = string.Empty;
                textBoxDescripcion.Text = string.Empty;
            }
            else
            {
                lblAlert.Text = "La operación no pudo completarse w(ﾟДﾟ)w";
                lblAlert.ForeColor = Color.Crimson;

            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CreateTicket();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            if(txtTitulo.Text != "")
            {
                lblAlert.Text = "";
                lblTitle.Text = txtTitulo.Text;
                lblTitle.BackColor = Color.WhiteSmoke; 
                lblTitle.ForeColor = Color.SkyBlue; 
                lblTitle.Font = new Font(lblTitle.Font.FontFamily, 12, FontStyle.Underline);
            }
            else
            {
                lblTitle.BackColor = Color.Empty; 
                lblTitle.ForeColor = Color.Black; 
                lblTitle.Text = "Titulo";

            }
        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescripcion.Text != "")
            {
                lblAlert.Text = "";
            }
        }

        private void lblLinkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxGuia.Text = "1- Completar el campo del Título.\r\n\r\n2- Seleccionar el Area correspondiente. \r\n\r\n3- Definir la prioridad del Ticket.\r\n\r\n4- Seleccionar su Tipo.\r\n\r\n5- Generar una descripción del mismo.\r\n\r\n6- Presionar el botón \"Crear\".\r\n\r\n7- Celebre su logro []~(￣▽￣)~*.";
        }
    }
}
