using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace proyecto_integrador
{
    public partial class FormInventario : Form
    {
        private readonly string connectionString =
            "Server=localhost\\SQLEXPRESS01;Database=INVENTARIO;Trusted_Connection=True;TrustServerCertificate=True;";

        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarInventario();
        }

        private void CargarCombos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter daSemillas = new SqlDataAdapter(
                        "SELECT ID_SEMILLA, NOMBRE_VARIEDAD + ' (' + CODIGO_VARIEDAD + ')' AS DESCRIPCION FROM SEMILLAS",
                        conn);
                    DataTable dtSemillas = new DataTable();
                    daSemillas.Fill(dtSemillas);
                    cmbSemillas.DataSource = dtSemillas;
                    cmbSemillas.DisplayMember = "DESCRIPCION";
                    cmbSemillas.ValueMember = "ID_SEMILLA";

                    SqlDataAdapter daEncargados = new SqlDataAdapter(
                        "SELECT ID_ENCARGADO, NOMBRE FROM ENCARGADO_INVENTARIO",
                        conn);
                    DataTable dtEncargados = new DataTable();
                    daEncargados.Fill(dtEncargados);
                    cmbEncargados.DataSource = dtEncargados;
                    cmbEncargados.DisplayMember = "NOMBRE";
                    cmbEncargados.ValueMember = "ID_ENCARGADO";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarInventario()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            L.ID_LOTE,
                            L.CODIGO_LOTE,
                            S.NOMBRE_VARIEDAD,
                            T.NOMBRE_TIPO,
                            L.EMPRESA_ORIGEN,
                            L.FECHA_INGRESO,
                            L.CANTIDAD_INGRESADA,
                            L.CANTIDAD_DISPONIBLE,
                            L.UNIDAD_MEDIDA,
                            E.NOMBRE AS ENCARGADO
                        FROM LOTE_INVENTARIO L
                        INNER JOIN SEMILLAS S ON L.ID_SEMILLA = S.ID_SEMILLA
                        INNER JOIN TIPO_SEMILLA T ON S.ID_TIPO_SEMILLA = T.ID_TIPO_SEMILLA
                        INNER JOIN ENCARGADO_INVENTARIO E ON L.ID_ENCARGADO = E.ID_ENCARGADO
                        ORDER BY L.ID_LOTE DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLotes.DataSource = dt;

                    cmbLotes.DataSource = dt.Copy();
                    cmbLotes.DisplayMember = "CODIGO_LOTE";
                    cmbLotes.ValueMember = "ID_LOTE";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSumarStock_Click(object sender, EventArgs e)
        {
            if (cmbLotes.SelectedValue == null) return;

            int idLote = Convert.ToInt32(cmbLotes.SelectedValue);
            decimal cantidad = numCantidad.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                        UPDATE LOTE_INVENTARIO
                        SET CANTIDAD_DISPONIBLE = CANTIDAD_DISPONIBLE + @Cantidad,
                            CANTIDAD_INGRESADA = CANTIDAD_INGRESADA + @Cantidad
                        WHERE ID_LOTE = @IdLote";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@IdLote", idLote);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Stock añadido en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarStock_Click(object sender, EventArgs e)
        {
            if (cmbLotes.SelectedValue == null) return;

            int idLote = Convert.ToInt32(cmbLotes.SelectedValue);
            decimal cantidadAQuitar = numCantidad.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    decimal disponibleActual = 0;
                    string consultaStock = "SELECT CANTIDAD_DISPONIBLE FROM LOTE_INVENTARIO WHERE ID_LOTE = @IdLote";
                    using (SqlCommand cmdCheck = new SqlCommand(consultaStock, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@IdLote", idLote);
                        object result = cmdCheck.ExecuteScalar();
                        if (result != null)
                            disponibleActual = Convert.ToDecimal(result);
                    }

                    if (cantidadAQuitar > disponibleActual)
                    {
                        MessageBox.Show($"Solo hay {disponibleActual} disponible en este lote.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sqlUpdate = @"
                        UPDATE LOTE_INVENTARIO
                        SET CANTIDAD_DISPONIBLE = CANTIDAD_DISPONIBLE - @Cantidad
                        WHERE ID_LOTE = @IdLote";

                    using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Cantidad", cantidadAQuitar);
                        cmdUpdate.Parameters.AddWithValue("@IdLote", idLote);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Stock descontado en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearLote_Click(object sender, EventArgs e)
        {
            if (cmbSemillas.SelectedValue == null || cmbEncargados.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtCodigoLote.Text) ||
                string.IsNullOrWhiteSpace(txtEmpresaOrigen.Text) ||
                string.IsNullOrWhiteSpace(txtUnidad.Text))
            {
                MessageBox.Show("Completa todos los campos del nuevo lote.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlInsert = @"
                        INSERT INTO LOTE_INVENTARIO
                        (ID_SEMILLA, ID_ENCARGADO, CODIGO_LOTE, EMPRESA_ORIGEN, FECHA_INGRESO, CANTIDAD_INGRESADA, CANTIDAD_DISPONIBLE, UNIDAD_MEDIDA)
                        VALUES
                        (@IdSemilla, @IdEncargado, @CodigoLote, @EmpresaOrigen, GETDATE(), @Cantidad, @Cantidad, @Unidad)";

                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSemilla", Convert.ToInt32(cmbSemillas.SelectedValue));
                        cmd.Parameters.AddWithValue("@IdEncargado", Convert.ToInt32(cmbEncargados.SelectedValue));
                        cmd.Parameters.AddWithValue("@CodigoLote", txtCodigoLote.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmpresaOrigen", txtEmpresaOrigen.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cantidad", numCantidad.Value);
                        cmd.Parameters.AddWithValue("@Unidad", txtUnidad.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Nuevo lote guardado en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoLote.Clear();
                txtEmpresaOrigen.Clear();
                txtUnidad.Clear();
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el lote: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCombos();
            CargarInventario();
        }

        private void grpStock_Enter(object sender, EventArgs e)
        {

        }
    }
}