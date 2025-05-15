using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Linq;

namespace EPS_Salvar_Vidas
{
    public partial class FormularioDatos : Form
    {
        public FormularioDatos()
        {
            InitializeComponent();

            RaBto_Medicina.CheckedChanged += RaBto_Atencion_CheckedChanged;
            RaBto_Laboratorio.CheckedChanged += RaBto_Laboratorio_CheckedChanged;

            this.ControlBox = false; //desactivar el botón de cerrar
            this.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            CargarDatosDesdeExcel();
        }

        private void CargarPilaDesdeExcel(ExcelPackage package)
        {
            var worksheet = package.Workbook.Worksheets["Pila"];
            if (worksheet != null)
            {
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    // Leer datos y agregar a pilaUsuarios
                    // Ejemplo: pilaUsuarios.Push(new EstructuraDatosUsuario { ... });
                }
            }
        }

        private void CargarColaDesdeExcel(ExcelPackage package)
        {
            var worksheet = package.Workbook.Worksheets["Cola"];
            if (worksheet != null)
            {
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    // Lee cada celda correspondiente a las propiedades de la clase
                    string nombre = worksheet.Cells[row, 1].Text; // Ejemplo para la columna A
                    int edad = int.Parse(worksheet.Cells[row, 2].Text); // Ejemplo para la columna B
                    // Crea un nuevo objeto y lo agréga a cola
                    colaUsuarios.Enqueue(new EstructuraDatosUsuario { Nombre = nombre, Edad = edad });
                }
            }
        }

        private void CargarListaDesdeExcel(ExcelPackage package)
        {
            var worksheet = package.Workbook.Worksheets["Lista"];
            if (worksheet != null)
            {
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    // Lee los datos de las columnas según la estructura de tu clase
                    string nombre = worksheet.Cells[row, 1].Text; // Ejemplo para la columna A
                    int edad = int.Parse(worksheet.Cells[row, 2].Text); // Ejemplo para la columna B

                    // Crea un nuevo objeto y lo agréga a la lista
                    listaUsuarios.Add(new EstructuraDatosUsuario { Nombre = nombre, Edad = edad });
                }
            }
        }


        private void CargarDatosDesdeExcel()
        {
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UsuariosEPS.xlsx");

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    using (FileStream stream = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            package.Load(stream);

                            // Cargar datos de las hojas (Pila, Cola, Lista)
                            CargarPilaDesdeExcel(package);
                            CargarColaDesdeExcel(package);
                            CargarListaDesdeExcel(package);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos desde el archivo Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Inicialización de las estructuras de datos
        private Stack<EstructuraDatosUsuario> pilaUsuarios = new Stack<EstructuraDatosUsuario>();
        private Queue<EstructuraDatosUsuario> colaUsuarios = new Queue<EstructuraDatosUsuario>();
        private List<EstructuraDatosUsuario> listaUsuarios = new List<EstructuraDatosUsuario>();

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTCAPTION = 0x02;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            // Bloquear el movimiento del formulario
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION; // Evita mover el formulario
                return;
            }

            // Bloquear el movimiento por el mouse y teclado
            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MOVE)
            {
                return; // No permitir mover
            }

            base.WndProc(ref m);
        }

        private void GuardarEnExcel(string rutaArchivo)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Crear una hoja para "Pila"
                var hojaPila = excelPackage.Workbook.Worksheets.Add("Pila");
                CargarDatosDataGridViewEnExcel(dataGridViewPila, hojaPila);

                // Crear una hoja para "Cola"
                var hojaCola = excelPackage.Workbook.Worksheets.Add("Cola");
                CargarDatosDataGridViewEnExcel(dataGridViewCola, hojaCola);

                // Verificar si dataGridViewFila existe
                if (dataGridViewLista != null)
                {
                    // Crear una hoja para "Fila"
                    var hojaFila = excelPackage.Workbook.Worksheets.Add("Fila");
                    CargarDatosDataGridViewEnExcel(dataGridViewLista, hojaFila);
                }
                else
                {
                    MessageBox.Show("El DataGridView 'dataGridViewFila' no está disponible.");
                }

                // Guardar el archivo en la ruta especificada
                FileInfo fi = new FileInfo(rutaArchivo);
                excelPackage.SaveAs(fi);
            }
        }


        // Método auxiliar para cargar datos desde un DataGridView a un ExcelRange
        private void CargarDatosDataGridViewEnExcel(DataGridView dgv, ExcelWorksheet worksheet)
        {
            // Agregar encabezados
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                worksheet.Cells[1, col + 1].Value = dgv.Columns[col].HeaderText; // Encabezados en la fila 1
            }

            // Agregar filas
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    worksheet.Cells[row + 2, col + 1].Value = dgv.Rows[row].Cells[col].Value; // Datos a partir de la fila 2
                }
            }
        }

        public int CalcularCopago()
        {
            int estrato = Convert.ToInt32(cb_Estrato.SelectedItem);
            int copago = 0;

            if (RaBto_Medicina.Checked)
            {
                switch (estrato)
                {
                    case 1:
                        copago = 0;
                        break;
                    case 2:
                        copago = 0;
                        break;
                    case 3:
                        copago = 10000;
                        break;
                    case 4:
                        copago = 15000;
                        break;
                    case 5:
                        copago = 20000;
                        break;
                    case 6:
                        copago = 30000;
                        break;
                }
            }
            if (RaBto_Laboratorio.Checked)
            {
                switch (estrato)
                {
                    case 1:
                        copago = 0;
                        break;
                    case 2:
                        copago = 0;
                        break;
                    case 3:
                        copago = 0;
                        break;
                    case 4:
                        copago = 5000;
                        break;
                    case 5:
                        copago = 10000;
                        break;
                    case 6:
                        copago = 20000;
                        break;
                }
            }

            txtValorCopago.Text = copago.ToString("C"); 
            return copago;

        }


        private void FormularioDatos_Load(object sender, EventArgs e)
        {
            // Configurar columnas para DataGridView Pila
            dataGridViewPila.Columns.Add("TipoIdentificacion", "Tipo de Identificación");
            dataGridViewPila.Columns.Add("NumeroIdentificacion", "Número de Identificación");
            dataGridViewPila.Columns.Add("Nombre", "Nombre completo");
            dataGridViewPila.Columns.Add("Edad", "Edad");
            dataGridViewPila.Columns.Add("Estrato", "Estrato");
            dataGridViewPila.Columns.Add("TipoAtencion", "Tipo de Atención");
            dataGridViewPila.Columns.Add("FechaRegistro", "Fecha de Registro");
            dataGridViewPila.Columns.Add("ValorCopago", "Valor del Copago");

            // Configurar columnas para DataGridView Cola
            dataGridViewCola.Columns.Add("TipoIdentificacion", "Tipo Identificación");
            dataGridViewCola.Columns.Add("NumeroIdentificacion", "Número Identificación");
            dataGridViewCola.Columns.Add("Nombre", "Nombre");
            dataGridViewCola.Columns.Add("Edad", "Edad");
            dataGridViewCola.Columns.Add("Estrato", "Estrato");
            dataGridViewCola.Columns.Add("TipoAtencion", "Tipo Atención");
            dataGridViewCola.Columns.Add("FechaRegistro", "Fecha de Registro");
            dataGridViewCola.Columns.Add("ValorCopago", "Valor del Copago");

            // Configurar columnas para DataGridView Lista
            dataGridViewLista.Columns.Add("TipoIdentificacion", "Tipo Identificación");
            dataGridViewLista.Columns.Add("NumeroIdentificacion", "Número Identificación");
            dataGridViewLista.Columns.Add("Nombre", "Nombre");
            dataGridViewLista.Columns.Add("Edad", "Edad");
            dataGridViewLista.Columns.Add("Estrato", "Estrato");
            dataGridViewLista.Columns.Add("TipoAtencion", "Tipo Atención");
            dataGridViewLista.Columns.Add("FechaRegistro", "Fecha de Registro");
            dataGridViewLista.Columns.Add("ValorCopago", "Valor del Copago");

            // Agregar elementos al ComboBox de Tipo de Identificación
            cb_TipoID.Items.Add("CC"); // Cédula de Ciudadanía
            cb_TipoID.Items.Add("CE"); // Cédula de Extranjería
            cb_TipoID.Items.Add("NUIP"); // Número Único de Identificación Personal
            cb_TipoID.Items.Add("PAS"); // Pasaporte

            // Agregar elementos al ComboBox de Estrato Socioeconómico
            cb_Estrato.Items.Add(1);
            cb_Estrato.Items.Add(2);
            cb_Estrato.Items.Add(3);
            cb_Estrato.Items.Add(4);
            cb_Estrato.Items.Add(5);
            cb_Estrato.Items.Add(6);

            // Limpiar selección inicial
            cb_TipoID.SelectedIndex = -1;
            cb_Estrato.SelectedIndex = -1;
        }

        private void ActualizarDataGridView(DataGridView dataGridView, object lista)
        {
            dataGridView.DataSource = null; // Desvincular el DataGridView
            dataGridView.Columns.Clear(); // Limpiar columnas existentes

            if (lista is Stack<EstructuraDatosUsuario> pila)
            {
                dataGridView.DataSource = pila.ToList(); // Convertir a lista para mostrar
            }
            else if (lista is Queue<EstructuraDatosUsuario> cola)
            {
                dataGridView.DataSource = cola.ToList(); // Convertir a cola para mostrar
            }
            else if (lista is List<EstructuraDatosUsuario> listaUsu)
            {
                dataGridView.DataSource = listaUsu; // Vincular la fila directamente
            }
        }

        private void RaBto_Laboratorio_CheckedChanged(object sender, EventArgs e)
        {
            CalcularCopago();
        }

        private void RaBto_Atencion_CheckedChanged(object sender, EventArgs e)
        {
            CalcularCopago();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Estrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularCopago();
        }

        private void ActualizarArchivoExcel()
        {
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UsuariosEPS.xlsx");

            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    if (File.Exists(rutaArchivo))
                    {
                        using (FileStream stream = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                        {
                            package.Load(stream);
                        }
                    }

                    //actualiza las hojas (Pila, Cola, Lista)
                    ExcelWorksheet worksheetPila = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Pila") ?? package.Workbook.Worksheets.Add("Pila");
                    ExcelWorksheet worksheetCola = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Cola") ?? package.Workbook.Worksheets.Add("Cola");
                    ExcelWorksheet worksheetLista = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Lista") ?? package.Workbook.Worksheets.Add("Lista");

                    // Actualiza o agrega datos en la hoja de Pila
                    if (worksheetPila.Dimension == null)
                    {
                        // Agregar encabezados si la hoja de trabajo está vacía
                        worksheetPila.Cells[1, 1].Value = "Tipo Identificación";
                        worksheetPila.Cells[1, 2].Value = "Cedula";
                        worksheetPila.Cells[1, 3].Value = "Nombre";
                        worksheetPila.Cells[1, 4].Value = "Edad";
                        worksheetPila.Cells[1, 5].Value = "Estrato";
                        worksheetPila.Cells[1, 6].Value = "Tipo Atencion";
                        worksheetPila.Cells[1, 7].Value = "Copago";
                        worksheetPila.Cells[1, 8].Value = "Fecha";
                    }

                    // Agregamos datos de la pila al final de la hoja
                    int rowPila = worksheetPila.Dimension?.End.Row + 1 ?? 2;
                    foreach (var usuario in pilaUsuarios)
                    {
                        worksheetPila.Cells[rowPila, 1].Value = usuario.TipoIdentificacion;
                        worksheetPila.Cells[rowPila, 2].Value = usuario.NumeroIdentificacion;
                        worksheetPila.Cells[rowPila, 3].Value = usuario.Nombre;
                        worksheetPila.Cells[rowPila, 3].Value = usuario.Edad;
                        worksheetPila.Cells[rowPila, 3].Value = usuario.Estrato;
                        worksheetPila.Cells[rowPila, 3].Value = usuario.TipoAtencion;
                        worksheetPila.Cells[rowPila, 3].Value = usuario.ValorCopago;
                        worksheetPila.Cells[rowPila, 3].Value = usuario.FechaRegistro;
                    }

                    if (worksheetCola.Dimension == null)
                    {
                        // Agregar encabezados si la hoja de trabajo está vacía
                        worksheetCola.Cells[1, 1].Value = "Tipo Identificación";
                        worksheetCola.Cells[1, 2].Value = "Cedula";
                        worksheetCola.Cells[1, 3].Value = "Nombre";
                        worksheetCola.Cells[1, 4].Value = "Edad";
                        worksheetCola.Cells[1, 5].Value = "Estrato";
                        worksheetCola.Cells[1, 6].Value = "Tipo Atencion";
                        worksheetCola.Cells[1, 7].Value = "Copago";
                        worksheetCola.Cells[1, 8].Value = "Fecha";
                    }

                    // Agregamos datos de la cola al final de la hoja
                    int rowCola = worksheetCola.Dimension?.End.Row + 1 ?? 2;
                    foreach (var usuario in colaUsuarios)
                    {
                        worksheetCola.Cells[rowCola, 1].Value = usuario.TipoIdentificacion;
                        worksheetCola.Cells[rowCola, 2].Value = usuario.NumeroIdentificacion;
                        worksheetCola.Cells[rowCola, 3].Value = usuario.Nombre;
                        worksheetCola.Cells[rowCola, 3].Value = usuario.Edad;
                        worksheetCola.Cells[rowCola, 3].Value = usuario.Estrato;
                        worksheetCola.Cells[rowCola, 3].Value = usuario.TipoAtencion;
                        worksheetCola.Cells[rowCola, 3].Value = usuario.ValorCopago;
                        worksheetCola.Cells[rowCola, 3].Value = usuario.FechaRegistro;
                    }

                    if (worksheetLista.Dimension == null)
                    {
                        // Agregar encabezados si la hoja de trabajo está vacía
                        worksheetLista.Cells[1, 1].Value = "Tipo Identificación";
                        worksheetLista.Cells[1, 2].Value = "Cedula";
                        worksheetLista.Cells[1, 3].Value = "Nombre";
                        worksheetLista.Cells[1, 4].Value = "Edad";
                        worksheetLista.Cells[1, 5].Value = "Estrato";
                        worksheetLista.Cells[1, 6].Value = "Tipo Atencion";
                        worksheetLista.Cells[1, 7].Value = "Copago";
                        worksheetLista.Cells[1, 8].Value = "Fecha";
                    }

                    // Agregamos datos de la lista al final de la hoja
                    int rowFila = worksheetLista.Dimension?.End.Row + 1 ?? 2;
                    foreach (var usuario in colaUsuarios)
                    {
                        worksheetLista.Cells[rowFila, 1].Value = usuario.TipoIdentificacion;
                        worksheetLista.Cells[rowFila, 2].Value = usuario.NumeroIdentificacion;
                        worksheetLista.Cells[rowFila, 3].Value = usuario.Nombre;
                        worksheetLista.Cells[rowFila, 3].Value = usuario.Edad;
                        worksheetLista.Cells[rowFila, 3].Value = usuario.Estrato;
                        worksheetLista.Cells[rowFila, 3].Value = usuario.TipoAtencion;
                        worksheetLista.Cells[rowFila, 3].Value = usuario.ValorCopago;
                        worksheetLista.Cells[rowFila, 3].Value = usuario.FechaRegistro;
                    }

                    using (FileStream stream = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
                    {
                        package.SaveAs(stream);
                    }
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Error de IO al actualizar el archivo Excel: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el archivo Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ExcelPackage CargarExcel(string rutaArchivo)
        {
            ExcelPackage package = new ExcelPackage();
            if (File.Exists(rutaArchivo))
            {
                using (FileStream stream = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                {
                    package.Load(stream);
                }
            }
            return package;
        }

        private ExcelWorksheet ObtenerHojaTrabajo(ExcelPackage package, string nombreHoja)
        {
            return package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == nombreHoja) ?? package.Workbook.Worksheets.Add(nombreHoja);
        }

        private List<EstructuraDatosUsuario> usuariosTemporales = new List<EstructuraDatosUsuario>();


        private void bto_Registrar_Click(object sender, EventArgs e)
        {
            int numeroIdentificacion = int.Parse(txt_Numero_Identificacion.Text);
            DateTime fechaRegistro = DTP_FechaRegistro.Value;

            if (string.IsNullOrWhiteSpace(txt_Numero_Identificacion.Text) ||
                string.IsNullOrWhiteSpace(txt_Nombre_Completo.Text) ||
                string.IsNullOrWhiteSpace(txt_Edad.Text) ||
                cb_TipoID.SelectedIndex == -1 ||
                cb_Estrato.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No registrar al usuario
            }

            // Intentar convertir y validar el número de identificación y edad
            if (!int.TryParse(txt_Numero_Identificacion.Text, out numeroIdentificacion))
            {
                MessageBox.Show("Número de identificación inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_Edad.Text, out int edad))
            {
                MessageBox.Show("Edad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el número de identificación ya existe en la misma fecha
            if (pilaUsuarios.Any(u => u.NumeroIdentificacion == numeroIdentificacion && u.FechaRegistro.Date == fechaRegistro.Date) ||
                colaUsuarios.Any(u => u.NumeroIdentificacion == numeroIdentificacion && u.FechaRegistro.Date == fechaRegistro.Date) ||
                listaUsuarios.Any(u => u.NumeroIdentificacion == numeroIdentificacion && u.FechaRegistro.Date == fechaRegistro.Date))
            {
                MessageBox.Show("Para poder asignar una nueva cita, debes cambiar la fecha.");
                return; // No registrar al usuario
            }

            // Crear objeto del usuario
            var usuario = new EstructuraDatosUsuario
            {
                TipoIdentificacion = cb_TipoID.SelectedItem.ToString(),
                NumeroIdentificacion = int.Parse(txt_Numero_Identificacion.Text),
                Nombre = txt_Nombre_Completo.Text,
                Edad = int.Parse(txt_Edad.Text),
                Estrato = int.Parse(cb_Estrato.SelectedItem.ToString()),
                TipoAtencion = RaBto_Medicina.Checked ? "Medicina General" : "Examen Laboratorio",
                ValorCopago = decimal.Parse(txtValorCopago.Text, NumberStyles.Currency),
                FechaRegistro = DTP_FechaRegistro.Value
            };

            // Agregar el usuario a la lista temporal
            usuariosTemporales.Add(usuario);

            // Determinar la estructura seleccionada
            switch (cb_Estructura.SelectedItem.ToString())
            {
                case "Pila":
                    pilaUsuarios.Push(usuario);
                    ActualizarDataGridView(dataGridViewPila, pilaUsuarios.ToList());
                    GuardarDatosEnExcel("Pila", pilaUsuarios.ToList());
                    break;
                case "Cola":
                    colaUsuarios.Enqueue(usuario);
                    ActualizarDataGridView(dataGridViewCola, colaUsuarios.ToList());
                    GuardarDatosEnExcel("Cola", colaUsuarios.ToList());
                    break;
                case "Lista":
                    listaUsuarios.Add(usuario);
                    ActualizarDataGridView(dataGridViewLista, listaUsuarios);
                    GuardarDatosEnExcel("Lista", listaUsuarios);
                    break;
                default:
                    MessageBox.Show("Seleccione una estructura válida.", "Error");
                    return;
            }

            // Mensaje de confirmación
            MessageBox.Show("Usuario registrado en la estructura seleccionada y guardado en el archivo Excel correspondiente.");
        }

        private void GuardarDatosEnExcel(string nombreHoja, List<EstructuraDatosUsuario> listaUsuarios)
        {
            // Definir la ruta para el archivo Excel
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{nombreHoja}.xlsx");

            using (ExcelPackage package = new ExcelPackage())
            {
                // Crear una hoja de trabajo
                var worksheet = package.Workbook.Worksheets.Add(nombreHoja);

                // Agregar encabezados
                worksheet.Cells[1, 1].Value = "Tipo Identificación";
                worksheet.Cells[1, 2].Value = "Cedula";
                worksheet.Cells[1, 3].Value = "Nombre";
                worksheet.Cells[1, 4].Value = "Edad";
                worksheet.Cells[1, 5].Value = "Estrato";
                worksheet.Cells[1, 6].Value = "Tipo de Atención";
                worksheet.Cells[1, 7].Value = "Copago";
                worksheet.Cells[1, 8].Value = "Fecha";

                // Llenar la hoja con los datos de los usuarios
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    var usuario = listaUsuarios[i];
                    worksheet.Cells[i + 2, 1].Value = usuario.TipoIdentificacion;
                    worksheet.Cells[i + 2, 2].Value = usuario.NumeroIdentificacion;
                    worksheet.Cells[i + 2, 3].Value = usuario.Nombre;
                    worksheet.Cells[i + 2, 4].Value = usuario.Edad;
                    worksheet.Cells[i + 2, 5].Value = usuario.Estrato;
                    worksheet.Cells[i + 2, 6].Value = usuario.TipoAtencion;
                    worksheet.Cells[i + 2, 7].Value = usuario.ValorCopago;
                    worksheet.Cells[i + 2, 8].Value = usuario.FechaRegistro;
                }

                // Guardar el archivo Excel
                package.SaveAs(rutaArchivo);
            }
        }


        private void bto_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bto_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Numero_Identificacion.Clear();
            txt_Nombre_Completo.Clear();
            txt_Edad.Clear();
            txtValorCopago.Clear();
            cb_TipoID.SelectedIndex = -1;
            cb_Estrato.SelectedIndex = -1;
            RaBto_Medicina.Checked = false;
            RaBto_Laboratorio.Checked = false;
            DTP_FechaRegistro.Value = DateTime.Now;
        }

        private void txt_Numero_Identificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_Completo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bto_Reporte_Pila_Click(object sender, EventArgs e)
        {
            int Sumacopago = 0;

            foreach (DataGridViewRow row in dataGridViewPila.Rows)
            {
                if (row.Cells["ValorCopago"].Value != null)
                {
                    Sumacopago += Convert.ToInt32(row.Cells["ValorCopago"].Value);
                }
            }

            txt_Reporte.Text = $"Pila (Suma Copagos): {Sumacopago}";
        }

        private void bto_Reporte_Cola_Click(object sender, EventArgs e)
        {
            // Para la cola: cantidad de registros
            int cantidadCola = dataGridViewCola.Rows.Count;

            txt_Reporte.Text = $"Cola (Cantidad): {cantidadCola}";
        }

        private void bto_Reporte_Lista_Click(object sender, EventArgs e)
        {
            // Para la lista: promedio de edades
            int sumaEdades = 0;
            int count = 0;
            foreach (DataGridViewRow row in dataGridViewLista.Rows)
            {
                sumaEdades += Convert.ToInt32(row.Cells["Edad"].Value);
                count++;
            }
            decimal promedioEdades = count > 0 ? (decimal)sumaEdades / count : 0;

            // Mostrar resultados en el campo de reporte
            txt_Reporte.Text = $"Lista (Promedio Edades): {promedioEdades:F2}";
        }

        private void txt_Numero_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Nombre_Completo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EliminarSeleccionado(DataGridView dataGridView, dynamic listaUsuarios, string nombreHoja)
{
    if (dataGridView.SelectedRows.Count > 0)
    {
        // Obtener el índice de la fila seleccionada
        int index = dataGridView.SelectedRows[0].Index;

        // Eliminar de la lista correspondiente
        if (nombreHoja == "Pila")
        {
            // Pop para eliminar el último elemento en Pila
            // En este caso necesitas ajustar cómo manejas la pila para eliminar el elemento correcto.
            pilaUsuarios.Pop(); // Modifica según el elemento que deseas eliminar
        }
        else if (nombreHoja == "Cola")
        {
            // Para Cola, podemos usar Dequeue para eliminar el primer elemento
            colaUsuarios.Dequeue(); // Modifica según el elemento que deseas eliminar
        }
        else if (nombreHoja == "Lista")
        {
            listaUsuarios.RemoveAt(index);
        }

        // Actualizar el DataGridView
        ActualizarDataGridView(dataGridView, listaUsuarios.ToList());

        // Guardar cambios en el archivo Excel
        GuardarDatosEnExcel(nombreHoja, listaUsuarios.ToList());
    }
    else
    {
        MessageBox.Show("Seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}

        private void bto_Eliminar_Pila_Click(object sender, EventArgs e)
        {
            if (dataGridViewPila.SelectedRows.Count > 0)
            {
                int index = dataGridViewPila.SelectedRows[0].Index; // Índice de la fila seleccionada

                // Convertir la pila a una lista para eliminar el elemento
                List<EstructuraDatosUsuario> tempPila = pilaUsuarios.ToList();
                tempPila.RemoveAt(index); // Eliminar el elemento en el índice
                pilaUsuarios = new Stack<EstructuraDatosUsuario>(tempPila.OrderByDescending(x => x.FechaRegistro)); // Reconstruir la pila en orden descendente por fecha de registro

                ActualizarDataGridView(dataGridViewPila, pilaUsuarios.ToList());
                EliminarSeleccionado(dataGridViewPila, pilaUsuarios, "Pila");
                ActualizarArchivoExcel(); // Actualizar el archivo Excel
            }
        }

        private void bto_Eliminar_Cola_Click(object sender, EventArgs e)
        {
            if (dataGridViewCola.SelectedRows.Count > 0)
            {
                int index = dataGridViewCola.SelectedRows[0].Index; // Índice de la fila seleccionada

                // Convertir la cola a una lista para eliminar el elemento
                List<EstructuraDatosUsuario> tempCola = colaUsuarios.ToList();
                tempCola.RemoveAt(index); // Eliminar el elemento en el índice
                colaUsuarios = new Queue<EstructuraDatosUsuario>(tempCola); // Reconstruir la cola

                ActualizarDataGridView(dataGridViewCola, colaUsuarios.ToList());
                EliminarSeleccionado(dataGridViewCola, colaUsuarios, "Cola");
                ActualizarArchivoExcel(); // Actualizar el archivo Excel
            }
        }

        private void bto_Eliminar_Lista_Click(object sender, EventArgs e)
        {
            if (dataGridViewLista.SelectedRows.Count > 0)
            {
                int index = dataGridViewLista.SelectedRows[0].Index; // Índice de la fila seleccionada
                listaUsuarios.RemoveAt(index); // Eliminar directamente de la lista
                ActualizarDataGridView(dataGridViewLista, listaUsuarios);
                EliminarSeleccionado(dataGridViewLista, listaUsuarios, "Lista");
                ActualizarArchivoExcel(); // Actualizar el archivo Excel
            }
        }
    }
}
