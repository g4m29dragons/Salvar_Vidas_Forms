namespace EPS_Salvar_Vidas
{
    partial class FormularioDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDatos));
            this.txt_Numero_Identificacion = new System.Windows.Forms.TextBox();
            this.cb_TipoID = new System.Windows.Forms.ComboBox();
            this.RaBto_Medicina = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nombre_Completo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.cb_Estrato = new System.Windows.Forms.ComboBox();
            this.txtValorCopago = new System.Windows.Forms.TextBox();
            this.txt_Reporte = new System.Windows.Forms.TextBox();
            this.bto_Registrar = new System.Windows.Forms.Button();
            this.bto_Limpiar = new System.Windows.Forms.Button();
            this.bto_Salir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DTP_FechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.RaBto_Laboratorio = new System.Windows.Forms.RadioButton();
            this.cb_Estructura = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPageDatos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bto_Eliminar_Pila = new System.Windows.Forms.Button();
            this.bto_Reporte_Pila = new System.Windows.Forms.Button();
            this.dataGridViewPila = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bto_Eliminar_Cola = new System.Windows.Forms.Button();
            this.bto_Reporte_Cola = new System.Windows.Forms.Button();
            this.dataGridViewCola = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bto_Eliminar_Lista = new System.Windows.Forms.Button();
            this.bto_Reporte_Lista = new System.Windows.Forms.Button();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabPageDatos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPila)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCola)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Numero_Identificacion
            // 
            this.txt_Numero_Identificacion.Location = new System.Drawing.Point(722, 127);
            this.txt_Numero_Identificacion.Name = "txt_Numero_Identificacion";
            this.txt_Numero_Identificacion.Size = new System.Drawing.Size(121, 20);
            this.txt_Numero_Identificacion.TabIndex = 0;
            this.txt_Numero_Identificacion.TextChanged += new System.EventHandler(this.txt_Numero_Identificacion_TextChanged);
            this.txt_Numero_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_Identificacion_KeyPress);
            // 
            // cb_TipoID
            // 
            this.cb_TipoID.FormattingEnabled = true;
            this.cb_TipoID.Location = new System.Drawing.Point(240, 129);
            this.cb_TipoID.Name = "cb_TipoID";
            this.cb_TipoID.Size = new System.Drawing.Size(151, 21);
            this.cb_TipoID.TabIndex = 1;
            // 
            // RaBto_Medicina
            // 
            this.RaBto_Medicina.AutoSize = true;
            this.RaBto_Medicina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaBto_Medicina.Location = new System.Drawing.Point(506, 263);
            this.RaBto_Medicina.Name = "RaBto_Medicina";
            this.RaBto_Medicina.Size = new System.Drawing.Size(148, 23);
            this.RaBto_Medicina.TabIndex = 2;
            this.RaBto_Medicina.TabStop = true;
            this.RaBto_Medicina.Text = "Medicina General";
            this.RaBto_Medicina.UseVisualStyleBackColor = true;
            this.RaBto_Medicina.CheckedChanged += new System.EventHandler(this.RaBto_Atencion_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Numero de Identificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "SISTEMA DE REGISTRO DE USUARIOS EN CENTRO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "EPS Salvando Vidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Tipo de Identificación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Nombre Completo:";
            // 
            // txt_Nombre_Completo
            // 
            this.txt_Nombre_Completo.Location = new System.Drawing.Point(240, 185);
            this.txt_Nombre_Completo.Name = "txt_Nombre_Completo";
            this.txt_Nombre_Completo.Size = new System.Drawing.Size(151, 20);
            this.txt_Nombre_Completo.TabIndex = 8;
            this.txt_Nombre_Completo.TextChanged += new System.EventHandler(this.txt_Nombre_Completo_TextChanged);
            this.txt_Nombre_Completo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Completo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "*Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "*Estrato Socioeconomico:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor del Copago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "*Fecha de Acceso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "*Tipo de Estructura:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(101, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Reporte de Datos:";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(722, 180);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(121, 20);
            this.txt_Edad.TabIndex = 16;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // cb_Estrato
            // 
            this.cb_Estrato.FormattingEnabled = true;
            this.cb_Estrato.Location = new System.Drawing.Point(240, 245);
            this.cb_Estrato.Name = "cb_Estrato";
            this.cb_Estrato.Size = new System.Drawing.Size(151, 21);
            this.cb_Estrato.TabIndex = 17;
            this.cb_Estrato.SelectedIndexChanged += new System.EventHandler(this.comboBox_Estrato_SelectedIndexChanged);
            // 
            // txtValorCopago
            // 
            this.txtValorCopago.Enabled = false;
            this.txtValorCopago.Location = new System.Drawing.Point(240, 308);
            this.txtValorCopago.Name = "txtValorCopago";
            this.txtValorCopago.Size = new System.Drawing.Size(151, 20);
            this.txtValorCopago.TabIndex = 18;
            // 
            // txt_Reporte
            // 
            this.txt_Reporte.Enabled = false;
            this.txt_Reporte.Location = new System.Drawing.Point(241, 398);
            this.txt_Reporte.Name = "txt_Reporte";
            this.txt_Reporte.Size = new System.Drawing.Size(150, 20);
            this.txt_Reporte.TabIndex = 20;
            // 
            // bto_Registrar
            // 
            this.bto_Registrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bto_Registrar.Location = new System.Drawing.Point(514, 383);
            this.bto_Registrar.Name = "bto_Registrar";
            this.bto_Registrar.Size = new System.Drawing.Size(75, 23);
            this.bto_Registrar.TabIndex = 21;
            this.bto_Registrar.Text = "Registrar";
            this.bto_Registrar.UseVisualStyleBackColor = true;
            this.bto_Registrar.Click += new System.EventHandler(this.bto_Registrar_Click);
            // 
            // bto_Limpiar
            // 
            this.bto_Limpiar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bto_Limpiar.Location = new System.Drawing.Point(643, 383);
            this.bto_Limpiar.Name = "bto_Limpiar";
            this.bto_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.bto_Limpiar.TabIndex = 22;
            this.bto_Limpiar.Text = "Limpiar";
            this.bto_Limpiar.UseVisualStyleBackColor = true;
            this.bto_Limpiar.Click += new System.EventHandler(this.bto_Limpiar_Click);
            // 
            // bto_Salir
            // 
            this.bto_Salir.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bto_Salir.Location = new System.Drawing.Point(768, 383);
            this.bto_Salir.Name = "bto_Salir";
            this.bto_Salir.Size = new System.Drawing.Size(75, 23);
            this.bto_Salir.TabIndex = 23;
            this.bto_Salir.Text = "Salir";
            this.bto_Salir.UseVisualStyleBackColor = true;
            this.bto_Salir.Click += new System.EventHandler(this.bto_Salir_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(531, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(296, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Los campos marcados con (*) son de tipo obligatorios.";
            // 
            // DTP_FechaRegistro
            // 
            this.DTP_FechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FechaRegistro.Location = new System.Drawing.Point(722, 332);
            this.DTP_FechaRegistro.Name = "DTP_FechaRegistro";
            this.DTP_FechaRegistro.Size = new System.Drawing.Size(121, 20);
            this.DTP_FechaRegistro.TabIndex = 26;
            // 
            // RaBto_Laboratorio
            // 
            this.RaBto_Laboratorio.AutoSize = true;
            this.RaBto_Laboratorio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaBto_Laboratorio.Location = new System.Drawing.Point(664, 263);
            this.RaBto_Laboratorio.Name = "RaBto_Laboratorio";
            this.RaBto_Laboratorio.Size = new System.Drawing.Size(184, 23);
            this.RaBto_Laboratorio.TabIndex = 28;
            this.RaBto_Laboratorio.TabStop = true;
            this.RaBto_Laboratorio.Text = "Examen de Laboratorio";
            this.RaBto_Laboratorio.UseVisualStyleBackColor = true;
            this.RaBto_Laboratorio.CheckedChanged += new System.EventHandler(this.RaBto_Laboratorio_CheckedChanged);
            // 
            // cb_Estructura
            // 
            this.cb_Estructura.FormattingEnabled = true;
            this.cb_Estructura.Items.AddRange(new object[] {
            "Pila",
            "Cola",
            "Lista"});
            this.cb_Estructura.Location = new System.Drawing.Point(241, 351);
            this.cb_Estructura.Name = "cb_Estructura";
            this.cb_Estructura.Size = new System.Drawing.Size(150, 21);
            this.cb_Estructura.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 379);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(449, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 70);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "*Tipo de Atención:";
            // 
            // tabPageDatos
            // 
            this.tabPageDatos.Controls.Add(this.tabPage1);
            this.tabPageDatos.Controls.Add(this.tabPage2);
            this.tabPageDatos.Controls.Add(this.tabPage3);
            this.tabPageDatos.Location = new System.Drawing.Point(41, 487);
            this.tabPageDatos.Name = "tabPageDatos";
            this.tabPageDatos.SelectedIndex = 0;
            this.tabPageDatos.Size = new System.Drawing.Size(818, 229);
            this.tabPageDatos.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bto_Eliminar_Pila);
            this.tabPage1.Controls.Add(this.bto_Reporte_Pila);
            this.tabPage1.Controls.Add(this.dataGridViewPila);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pila";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bto_Eliminar_Pila
            // 
            this.bto_Eliminar_Pila.Location = new System.Drawing.Point(729, 59);
            this.bto_Eliminar_Pila.Name = "bto_Eliminar_Pila";
            this.bto_Eliminar_Pila.Size = new System.Drawing.Size(75, 23);
            this.bto_Eliminar_Pila.TabIndex = 2;
            this.bto_Eliminar_Pila.Text = "Eliminar";
            this.bto_Eliminar_Pila.UseVisualStyleBackColor = true;
            this.bto_Eliminar_Pila.Click += new System.EventHandler(this.bto_Eliminar_Pila_Click);
            // 
            // bto_Reporte_Pila
            // 
            this.bto_Reporte_Pila.Location = new System.Drawing.Point(729, 17);
            this.bto_Reporte_Pila.Name = "bto_Reporte_Pila";
            this.bto_Reporte_Pila.Size = new System.Drawing.Size(75, 23);
            this.bto_Reporte_Pila.TabIndex = 1;
            this.bto_Reporte_Pila.Text = "Reporte";
            this.bto_Reporte_Pila.UseVisualStyleBackColor = true;
            this.bto_Reporte_Pila.Click += new System.EventHandler(this.bto_Reporte_Pila_Click);
            // 
            // dataGridViewPila
            // 
            this.dataGridViewPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPila.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewPila.Name = "dataGridViewPila";
            this.dataGridViewPila.Size = new System.Drawing.Size(699, 197);
            this.dataGridViewPila.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bto_Eliminar_Cola);
            this.tabPage2.Controls.Add(this.bto_Reporte_Cola);
            this.tabPage2.Controls.Add(this.dataGridViewCola);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cola";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bto_Eliminar_Cola
            // 
            this.bto_Eliminar_Cola.Location = new System.Drawing.Point(729, 59);
            this.bto_Eliminar_Cola.Name = "bto_Eliminar_Cola";
            this.bto_Eliminar_Cola.Size = new System.Drawing.Size(75, 23);
            this.bto_Eliminar_Cola.TabIndex = 5;
            this.bto_Eliminar_Cola.Text = "Eliminar";
            this.bto_Eliminar_Cola.UseVisualStyleBackColor = true;
            this.bto_Eliminar_Cola.Click += new System.EventHandler(this.bto_Eliminar_Cola_Click);
            // 
            // bto_Reporte_Cola
            // 
            this.bto_Reporte_Cola.Location = new System.Drawing.Point(729, 17);
            this.bto_Reporte_Cola.Name = "bto_Reporte_Cola";
            this.bto_Reporte_Cola.Size = new System.Drawing.Size(75, 23);
            this.bto_Reporte_Cola.TabIndex = 4;
            this.bto_Reporte_Cola.Text = "Reporte";
            this.bto_Reporte_Cola.UseVisualStyleBackColor = true;
            this.bto_Reporte_Cola.Click += new System.EventHandler(this.bto_Reporte_Cola_Click);
            // 
            // dataGridViewCola
            // 
            this.dataGridViewCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCola.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewCola.Name = "dataGridViewCola";
            this.dataGridViewCola.Size = new System.Drawing.Size(699, 197);
            this.dataGridViewCola.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bto_Eliminar_Lista);
            this.tabPage3.Controls.Add(this.bto_Reporte_Lista);
            this.tabPage3.Controls.Add(this.dataGridViewLista);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(810, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bto_Eliminar_Lista
            // 
            this.bto_Eliminar_Lista.Location = new System.Drawing.Point(729, 59);
            this.bto_Eliminar_Lista.Name = "bto_Eliminar_Lista";
            this.bto_Eliminar_Lista.Size = new System.Drawing.Size(75, 23);
            this.bto_Eliminar_Lista.TabIndex = 5;
            this.bto_Eliminar_Lista.Text = "Eliminar";
            this.bto_Eliminar_Lista.UseVisualStyleBackColor = true;
            this.bto_Eliminar_Lista.Click += new System.EventHandler(this.bto_Eliminar_Lista_Click);
            // 
            // bto_Reporte_Lista
            // 
            this.bto_Reporte_Lista.Location = new System.Drawing.Point(729, 17);
            this.bto_Reporte_Lista.Name = "bto_Reporte_Lista";
            this.bto_Reporte_Lista.Size = new System.Drawing.Size(75, 23);
            this.bto_Reporte_Lista.TabIndex = 4;
            this.bto_Reporte_Lista.Text = "Reporte";
            this.bto_Reporte_Lista.UseVisualStyleBackColor = true;
            this.bto_Reporte_Lista.Click += new System.EventHandler(this.bto_Reporte_Lista_Click);
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(699, 197);
            this.dataGridViewLista.TabIndex = 3;
            // 
            // FormularioDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(897, 474);
            this.ControlBox = false;
            this.Controls.Add(this.tabPageDatos);
            this.Controls.Add(this.cb_Estructura);
            this.Controls.Add(this.RaBto_Laboratorio);
            this.Controls.Add(this.DTP_FechaRegistro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bto_Salir);
            this.Controls.Add(this.bto_Limpiar);
            this.Controls.Add(this.bto_Registrar);
            this.Controls.Add(this.txt_Reporte);
            this.Controls.Add(this.txtValorCopago);
            this.Controls.Add(this.cb_Estrato);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Nombre_Completo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RaBto_Medicina);
            this.Controls.Add(this.cb_TipoID);
            this.Controls.Add(this.txt_Numero_Identificacion);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormularioDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuarios";
            this.Load += new System.EventHandler(this.FormularioDatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabPageDatos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPila)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCola)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Numero_Identificacion;
        private System.Windows.Forms.ComboBox cb_TipoID;
        private System.Windows.Forms.RadioButton RaBto_Medicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nombre_Completo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.ComboBox cb_Estrato;
        private System.Windows.Forms.TextBox txtValorCopago;
        private System.Windows.Forms.TextBox txt_Reporte;
        private System.Windows.Forms.Button bto_Registrar;
        private System.Windows.Forms.Button bto_Limpiar;
        private System.Windows.Forms.Button bto_Salir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DTP_FechaRegistro;
        private System.Windows.Forms.RadioButton RaBto_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoID;
        private System.Windows.Forms.ComboBox cb_Estructura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabPageDatos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bto_Eliminar_Pila;
        private System.Windows.Forms.Button bto_Reporte_Pila;
        private System.Windows.Forms.DataGridView dataGridViewPila;
        private System.Windows.Forms.Button bto_Eliminar_Cola;
        private System.Windows.Forms.Button bto_Reporte_Cola;
        private System.Windows.Forms.DataGridView dataGridViewCola;
        private System.Windows.Forms.Button bto_Eliminar_Lista;
        private System.Windows.Forms.Button bto_Reporte_Lista;
        private System.Windows.Forms.DataGridView dataGridViewLista;
    }
}