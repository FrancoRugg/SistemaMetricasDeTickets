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
    public partial class frmUsuarios : Form
    {
        AreaService areaService = new AreaService();
        LoginService loginService = new LoginService();
        public string id = string.Empty;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            GetAreas();
            GetUsuarios();
        }
        private void GetAreas()
        {
            cbmAreas.DataSource = areaService.GetAreas();
            cbmAreas.DisplayMember = "Area";
            cbmAreas.ValueMember = "Area";
        }
        private void GetUsuarios()
        {
            grdDatos.DataSource = loginService.TraerUsuarios();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Usuario = txtUsuario.Text;
            login.Clave = txtClave.Text;
            login.Nombre = txtNombre.Text;
            login.Apellido = txtApellido.Text;
            login.Email = txtEmail.Text;
            login.Dni = txtDni.Text;
            login.Area = cbmAreas.Text;

            bool respuesta = loginService.CrearUsuario(login);

            if (respuesta)
            {
                btnAlert.Text = "Usuario creado correctamente.";
                btnAlert.BackColor = Color.ForestGreen;
                GetUsuarios();
            }
            else
            {
                btnAlert.Text = "Ocurrio un problema al crear el usuario.";
                btnAlert.BackColor = Color.Crimson;
            }

            btnAlert.Visible = true;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdDatos.Rows[e.RowIndex];

            id = row.Cells["Id"].Value.ToString();

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //MessageBox.Show("ID seleccionado: " + id.ToString());
                btnEditarUsuario.Visible = true;
                btnCrearUsuario.Visible = false;
                txtUsuario.Text = row.Cells["Usuario"].Value.ToString();
                txtClave.Text = EncriptHandler.Base64Decode(row.Cells["Clave"].Value.ToString());
                txtDni.Text = row.Cells["Dni"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cbmAreas.Text = row.Cells["Area"].Value.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value.ToString();

            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DialogResult dialogo = MessageBox.Show("Continuar con la eliminación", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (dialogo == DialogResult.OK)
                {
                    if (loginService.EliminarUsuario(id))
                    {
                        btnAlert.Text = "Usuario eliminado correctamente.";
                        btnAlert.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        btnAlert.Text = "Ocurrió un problema al eliminar el usuario.";
                        btnAlert.BackColor = Color.Crimson;
                    }
                    GetUsuarios();
                }

            }

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Id = Convert.ToInt32(id);
            login.Usuario = txtUsuario.Text;
            login.Clave = EncriptHandler.Base64Encode(txtClave.Text);
            login.Nombre = txtNombre.Text;
            login.Apellido = txtApellido.Text;
            login.Email = txtEmail.Text;
            login.Dni = txtDni.Text;
            login.Area = cbmAreas.Text;
            login.Estado = cmbEstado.Text;

            if (loginService.EditarUsuario(login))
            {
                btnAlert.Text = "Usuario Editado correctamente.";
                btnAlert.BackColor = Color.ForestGreen;
            }
            else
            {
                btnAlert.Text = "Ocurrió un problema al editar el usuario.";
                btnAlert.BackColor = Color.Crimson;
            }
            btnEditarUsuario.Visible = false;
            btnCrearUsuario.Visible = true;
            GetUsuarios();
        }
    }
}
