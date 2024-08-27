using Sistema_de_Ventas;
using SistemaMetricas.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using SistemaMetricas.Services.Services;

namespace SistemaMetricas
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        TicketService ticketService = new TicketService();
        Timer timer;


        private void frmHome_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Usuario Logeado: " + DatosGlobales.UsuarioLogeado;
            lblRol.Text = "Rol: " + DatosGlobales.RolUsuario;
            if (DatosGlobales.VistasPermitidas.Contains("frmAreas"))
            {
                tsbAreas.PerformClick();
            }
            //tsbAreas.PerformClick();
            timer = new Timer(5000); //Cada 5 seg
            timer.Elapsed += OnTimeEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

        }
        private void OnTimeEvent(object source, ElapsedEventArgs e) //Función que se ejecuta según el tiempo estimado en el timer
        {   
            this.Invoke((MethodInvoker)delegate
            {
                string area = DatosGlobales.AreaUsuario;
                tsbTickets.Text = $"Tickets({ticketService.GetTicketPendientesCount(area)})";
                //MessageBox.Show();
                
            });
        }
        private void tsbAreas_Click(object sender, EventArgs e)
        {
            //frmAreas areas =  new frmAreas();
            //LlenarContenedor(areas);
            MostrarVistaSiPermitida("frmAreas", new frmAreas());
        }
        private void LlenarContenedor(Form form)
        {
            pnlContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void tsbTipos_Click(object sender, EventArgs e)
        {
            frmBuilder tipos = new frmBuilder("Tipos", "Administracion de Tipos");
            LlenarContenedor(tipos);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //frmNuevoTickets nuevoTicket = new frmNuevoTickets();
            //LlenarContenedor(nuevoTicket);
            MostrarVistaSiPermitida("frmNuevoTickets", new frmNuevoTickets());
        }
        

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            //frmUsuarios usuarios = new frmUsuarios();
            //LlenarContenedor(usuarios);
            MostrarVistaSiPermitida("frmUsuarios", new frmUsuarios());
        }

        private void tsbDashboard_Click(object sender, EventArgs e)
        {
            //frmReportes reportes = new frmReportes();
            //LlenarContenedor(reportes);
            MostrarVistaSiPermitida("frmReportes", new frmReportes());
        }

        private void tsbTickets_Click(object sender, EventArgs e)
        {
            //frmTickets tickets = new frmTickets();
            //LlenarContenedor(tickets);
            MostrarVistaSiPermitida("frmTickets", new frmTickets());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MostrarVistaSiPermitida(string vistaNombre, Form form)
        {
            if (DatosGlobales.VistasPermitidas.Contains(vistaNombre))
            {
                LlenarContenedor(form);
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a esta vista.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
