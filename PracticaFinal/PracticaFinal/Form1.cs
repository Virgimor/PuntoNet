using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PracticaFinal
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter;
        DataSet ds = new DataSet();
        OleDbCommandBuilder builder;
        DataTable sTable = new DataTable();


        public Form1()
        {
            InitializeComponent();
            ocultarPanel();
            // Cadena de conexión a la base de datos
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.practicaDataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Evaluaciones' Puede moverla o quitarla según sea necesario.
            this.evaluacionesTableAdapter.Fill(this.practicaDataSet.Evaluaciones);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.practicaDataSet.Alumnos);
        }

        public void ocultarPanel()
        {
            panelAltaAlumno.Visible = false;
            panelMod_ElimAlumno.Visible = false;
            paEvaAlta.Visible = false;
            panelEvaList.Visible = false;
            panelEvaModif.Visible = false;
            panelNotas.Visible = false;
            
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            panelAltaAlumno.Visible = true;
            panelPrincipal.Visible = false;

        }

        private void buttonGuardarAltaAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                // Comprobar que el NIF es correcto
                if (!EsNifValido(txtNif.Text))
                {
                    MessageBox.Show("El NIF no es válido.");
                    return;
                }

                // Comprobar que el NIF no está ya dado de alta
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Alumnos WHERE NIF = '"+ txtNif.Text + "'";
                command.Parameters.Clear();
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                if (count > 0)
                {
                    MessageBox.Show("El NIF ya está registrado.");
                    return;
                }

                // abre la conexion con la base de datos
                connection.Open();

                command.Connection = connection;
                command.CommandText = "insert into Alumnos (Nombre, Apellidos, NIF, baja) values (@Nombre, @Apellidos, @NIF, @Baja)";

                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellidos", txtApellido.Text);
                command.Parameters.AddWithValue("@NIF", txtNif.Text);
                command.Parameters.AddWithValue("@Baja", checkBaja.Checked);

                command.ExecuteNonQuery();

                MessageBox.Show("Alumno guardado correctamente.");
                connection.Close();
                txtNombre.Clear();
                txtApellido.Clear();
                txtNif.Clear();
                checkBaja.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                connection.Close();
            }
        }

        private bool EsNifValido(string nif)
        {
            if (nif.Length != 9)
            {
                return false;
            }
            
            return true;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            panelMod_ElimAlumno.Visible = true;
            btnGuardarModifiAlum.Visible = false;
            btnEliminarAlumno.Visible = false;
            dgvAlumno.ReadOnly = true;
            panelPrincipal.Visible = false;
            alumnosTableAdapter.Update(practicaDataSet.Alumnos);
            alumnosTableAdapter.Fill(practicaDataSet.Alumnos);  

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            panelMod_ElimAlumno.Visible = true;
            dgvAlumno.Visible = true;
            btnEliminarAlumno.Visible = false;
            btnGuardarModifiAlum.Visible = true;
            dgvAlumno.ReadOnly = false;
            panelPrincipal.Visible = false;

            // Consulta SQL para obtener los datos de la tabla Alumnos
            string sql = "SELECT * FROM Alumnos";

            try
            {
                // Abrir la conexión con la base de datos
                connection.Open();

                // Configurar el comando y el adaptador para la consulta SQL
                command = new OleDbCommand(sql, connection);
                adapter = new OleDbDataAdapter(command);
                // Genera automáticamente comandos INSERT, UPDATE y DELETE
                builder = new OleDbCommandBuilder(adapter);
                // Inicializar el conjunto de datos
                ds = new DataSet();
                // Rellenar el conjunto de datos con los resultados de la consulta
                adapter.Fill(ds, "Alumnos");
                // Extraer la tabla "Alumnos"
                sTable = ds.Tables["Alumnos"]; 

                // Cerrar la conexión después de cargar los datos
                connection.Close();

                // Asignar los datos al DataGridView para mostrar en la interfaz
                dgvAlumno.DataSource = sTable;

                // Configuración del DataGridView 
                // Permitir edición en el DataGridView
                dgvAlumno.ReadOnly = false; 
                // Selección por filas completas
                dgvAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
                
                
            }
            catch (Exception ex)
            {
                // Mostrar mensaje en caso de error
                MessageBox.Show("Error al cargar datos: " + ex.Message);
                connection.Close();
            }
        }

        private void buttonGuardarModifiAlum_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar la base de datos con los cambios realizados en el DataTable
                adapter.Update(sTable);
                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            panelMod_ElimAlumno.Visible = true;
            dgvAlumno.Visible = true;
            btnGuardarModifiAlum.Visible = false;
            btnEliminarAlumno.Visible = true;
            dgvAlumno.ReadOnly = true;
            panelPrincipal.Visible = false;
        }

        private void buttonEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta fila?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                adapter = new OleDbDataAdapter();
                command = new OleDbCommand("DELETE FROM Alumnos WHERE Id = ?", connection);
                command.Parameters.Add("Id", OleDbType.Integer, 4, "Id");
                adapter.DeleteCommand = command;
                
                dgvAlumno.Rows.RemoveAt(dgvAlumno.SelectedRows[0].Index);
                adapter.Update(sTable);
            }
        }

        // Empieza el apartado de Evaluaciones
        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            paEvaAlta.Visible = true;
            panelPrincipal.Visible = false;

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            panelEvaList.Visible = true;
            dgvEvaluacion.ReadOnly = true;
            panelPrincipal.Visible = false;
            evaluacionesTableAdapter.Update(practicaDataSet.Evaluaciones);
            evaluacionesTableAdapter.Fill(practicaDataSet.Evaluaciones);
        }

        private void btnGuarAltaEva_Click(object sender, EventArgs e)
        {
            try
            {
                // abre la conexion con la base de datos
                connection.Open();

                command.Connection = connection;
                command.CommandText = "INSERT INTO Evaluaciones (Evaluacion) VALUES ('" + txtEvaluaciones.Text + "')";

                command.ExecuteNonQuery();

                MessageBox.Show("Evaluacion guardado correctamente.");
                connection.Close();
                txtEvaluaciones.Clear();
                evaluacionesTableAdapter.Update(practicaDataSet.Evaluaciones);
                evaluacionesTableAdapter.Fill(practicaDataSet.Evaluaciones);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            panelEvaModif.Visible = true;
            txtEvaModifi.Visible = true;
            btnEvaGuarModifi.Visible = true;
            labelModificarEva.Visible = true;
            pictureBoxModificar.Visible = true;
            btnEvaBorrar.Visible = false;
            panelPrincipal.Visible = false;
            labelBorrarEva.Visible = false;
            pictureBoxBorrar.Visible = false;

        }
        private void cbxModificacines_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                string query = "SELECT * FROM Evaluaciones WHERE Evaluacion = '" + cbxModificacines.Text +"'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtEvaModifi.Text = reader["Evaluacion"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnEvaGuarModifi_Click(object sender, EventArgs e)
        {
            try
            {
                int evaSeleccionada = Convert.ToInt32(cbxModificacines.SelectedValue);

                // Actualizar la descripción en la base de datos
                connection.Open();
                command.Connection = connection;
                string updateQuery = "UPDATE Evaluaciones SET Evaluacion = '" + txtEvaModifi.Text + "' WHERE Id = " + evaSeleccionada;
                command.CommandText = updateQuery;


                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Evaluación modificada correctamente.");
                txtEvaModifi.Clear();
                evaluacionesTableAdapter.Update(practicaDataSet.Evaluaciones);
                evaluacionesTableAdapter.Fill(practicaDataSet.Evaluaciones);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la evaluación: " + ex.Message);
            }
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            panelEvaModif.Visible = true;
            btnEvaBorrar.Visible = true;
            labelBorrarEva.Visible = true;
            pictureBoxBorrar.Visible = true;
            txtEvaModifi.Visible = false;
            btnEvaGuarModifi.Visible = false;
            panelPrincipal.Visible = false;
            labelModificarEva.Visible = false;
            pictureBoxModificar.Visible = false;
        }

        private void btnEvaBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta la evaluacion?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                string evaSeleccionada = cbxModificacines.SelectedValue.ToString();

                string query = "DELETE FROM Evaluaciones WHERE Id = " + evaSeleccionada;
                command.CommandText = query;
  
                command.ExecuteNonQuery();
                connection.Close();
                evaluacionesTableAdapter.Update(practicaDataSet.Evaluaciones);
                evaluacionesTableAdapter.Fill(practicaDataSet.Evaluaciones);
            }
        }

        // Empieza el apartado de Notas
        private void FiltrarNota(int idEva, int? idAlu = null)
        {
            if (dgvNotas.DataSource is BindingSource bindingSource)
            {
                if (idAlu.HasValue)
                {
                    bindingSource.Filter = $"Id_Alumno = {idAlu.Value} AND Id_Evaluacion = {idEva}";
                }
                else
                {
                    bindingSource.Filter = $"Id_Evaluacion = {idEva}";
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }

        private void checkNotas_CheckedChanged(object sender, EventArgs e)
        {
            listBoxNotas.Enabled = !checkNotas.Checked;
        }


        private void consularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            cargarListBoxAlumnosNombreApellidos();
            panelNotas.Visible = true;
            btnGuardarNotas.Enabled = false;
            panelPrincipal.Visible = false;
        }

        private void cargarListBoxAlumnosNombreApellidos()
        {
            adapter = new OleDbDataAdapter();
            ds = new DataSet();
            string consulta = null;
            consulta = "SELECT Id, Nombre & ' ' & Apellidos AS Nombre_Apellidos FROM Alumnos";

            try
            {
                //ds.Clear();

                connection.Open();
                command = new OleDbCommand(consulta, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                listBoxNotas.DataSource = ds.Tables[0];
                listBoxNotas.DisplayMember = "Nombre_Apellidos";
                listBoxNotas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.ToString());
            }

        }

        private void btnListarNotas_Click(object sender, EventArgs e)
        {
            int idEva = Convert.ToInt32(cbxNotas.SelectedValue);
            if (checkNotas.Checked)
            {
                FiltrarNota(idEva);
            }
            else
            {
                int idAlu = Convert.ToInt32(listBoxNotas.SelectedValue);
                FiltrarNota(idEva, idAlu);
            }

        }
        private void btnModificarNotas_Click(object sender, EventArgs e)
        {
            dgvNotas.ReadOnly = false;
            btnModificarNotas.Enabled = false;
            btnEliminarNotas.Enabled = true;
            btnGuardarNotas.Enabled = true;
            btnListarNotas.Enabled = false;
            btnCrearNotas.Enabled = false;
        }

        private void btnEliminarNotas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta fila?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvNotas != null)
                {
                    int indiceSeleccionado = dgvNotas.CurrentCell.RowIndex;
                    DataGridViewRow filaSeleccionada = dgvNotas.Rows[indiceSeleccionado];
                    int idAlu = Convert.ToInt32(filaSeleccionada.Cells["idAlumnoDataGridViewTextBoxColumn"].Value);
                    int idEva = Convert.ToInt32(filaSeleccionada.Cells["idEvaluacionDataGridViewTextBoxColumn"].Value);
                    var fila = practicaDataSet.Notas.FindById_AlumnoId_Evaluacion(idAlu, idEva);

                    if (fila != null)
                    {
                        fila.Delete();
                        notasTableAdapter.Update(practicaDataSet.Notas);
                        MessageBox.Show("Fila eliminada correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una fila");
                }
            }
        }

        private void btnGuardarNotas_Click(object sender, EventArgs e)
        {
            dgvNotas.ReadOnly = true;
            btnModificarNotas.Enabled = true;
            btnEliminarNotas.Enabled = true;
            btnGuardarNotas.Enabled = false;
            btnCrearNotas.Enabled = true;
            btnListarNotas.Enabled = true;
            notasTableAdapter.Update(practicaDataSet.Notas);
            notasTableAdapter.Fill(practicaDataSet.Notas);
        }

        private void btnCrearNotas_Click(object sender, EventArgs e)
        {
            dgvNotas.ReadOnly = false;
            btnListarNotas.Enabled = false;
            btnModificarNotas.Enabled = false;
            btnEliminarNotas.Enabled = false;
            btnGuardarNotas.Enabled = true;
        }
    }
}
