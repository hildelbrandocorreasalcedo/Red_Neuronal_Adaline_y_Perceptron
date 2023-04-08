namespace RedesNeuronales
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartErrorvsIteracion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CartesianVariacionRealDeseada = new LiveCharts.WinForms.CartesianChart();
            this.lblIteracion = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.CartesianErrors = new LiveCharts.WinForms.CartesianChart();
            this.CmbAlgoritmoEntrenamiento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NudRataDinamica = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNoIteraciones = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTopologiaRed = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Capa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neuronas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nudNumeroCapas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPatrones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtEntradas = new System.Windows.Forms.TextBox();
            this.TxtSalidas = new System.Windows.Forms.TextBox();
            this.TxtPatrones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.BtIngresarDatos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nudErrorMaximo = new System.Windows.Forms.NumericUpDown();
            this.nudRataAprendizaje = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label16 = new System.Windows.Forms.Label();
            this.BtDetener = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtEntrenar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pixel1 = new System.Windows.Forms.PictureBox();
            this.pixel2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.DgvParametrosSimulacion = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSimular = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorvsIteracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRataDinamica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopologiaRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCapas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrones)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudErrorMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRataAprendizaje)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixel2)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvParametrosSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chartErrorvsIteracion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 347);
            this.panel2.TabIndex = 0;
            // 
            // chartErrorvsIteracion
            // 
            this.chartErrorvsIteracion.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartErrorvsIteracion.ChartAreas.Add(chartArea1);
            this.chartErrorvsIteracion.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartErrorvsIteracion.Legends.Add(legend1);
            this.chartErrorvsIteracion.Location = new System.Drawing.Point(0, 0);
            this.chartErrorvsIteracion.Name = "chartErrorvsIteracion";
            this.chartErrorvsIteracion.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartErrorvsIteracion.Series.Add(series1);
            this.chartErrorvsIteracion.Size = new System.Drawing.Size(489, 343);
            this.chartErrorvsIteracion.TabIndex = 0;
            this.chartErrorvsIteracion.Text = "Error Por Iteracion";
            // 
            // CartesianVariacionRealDeseada
            // 
            this.CartesianVariacionRealDeseada.BackColor = System.Drawing.Color.Transparent;
            this.CartesianVariacionRealDeseada.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartesianVariacionRealDeseada.ForeColor = System.Drawing.Color.White;
            this.CartesianVariacionRealDeseada.Location = new System.Drawing.Point(36, 638);
            this.CartesianVariacionRealDeseada.Margin = new System.Windows.Forms.Padding(4);
            this.CartesianVariacionRealDeseada.Name = "CartesianVariacionRealDeseada";
            this.CartesianVariacionRealDeseada.Size = new System.Drawing.Size(684, 404);
            this.CartesianVariacionRealDeseada.TabIndex = 0;
            this.CartesianVariacionRealDeseada.Text = "cartesianChart1";
            this.CartesianVariacionRealDeseada.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CartesianVariacionRealDeseada_ChildChanged);
            // 
            // lblIteracion
            // 
            this.lblIteracion.AutoSize = true;
            this.lblIteracion.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteracion.ForeColor = System.Drawing.Color.White;
            this.lblIteracion.Location = new System.Drawing.Point(1664, 823);
            this.lblIteracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIteracion.Name = "lblIteracion";
            this.lblIteracion.Size = new System.Drawing.Size(158, 39);
            this.lblIteracion.TabIndex = 1;
            this.lblIteracion.Text = "Iteracion: ";
            this.lblIteracion.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(834, 823);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(161, 39);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Error RMS";
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // CartesianErrors
            // 
            this.CartesianErrors.BackColor = System.Drawing.Color.Transparent;
            this.CartesianErrors.ForeColor = System.Drawing.Color.White;
            this.CartesianErrors.Location = new System.Drawing.Point(1216, 510);
            this.CartesianErrors.Margin = new System.Windows.Forms.Padding(4);
            this.CartesianErrors.Name = "CartesianErrors";
            this.CartesianErrors.Size = new System.Drawing.Size(655, 298);
            this.CartesianErrors.TabIndex = 0;
            this.CartesianErrors.Text = "CartesianErrors";
            // 
            // CmbAlgoritmoEntrenamiento
            // 
            this.CmbAlgoritmoEntrenamiento.DisplayMember = "1";
            this.CmbAlgoritmoEntrenamiento.Enabled = false;
            this.CmbAlgoritmoEntrenamiento.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAlgoritmoEntrenamiento.FormattingEnabled = true;
            this.CmbAlgoritmoEntrenamiento.Items.AddRange(new object[] {
            "Regla Delta"});
            this.CmbAlgoritmoEntrenamiento.Location = new System.Drawing.Point(358, 140);
            this.CmbAlgoritmoEntrenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.CmbAlgoritmoEntrenamiento.Name = "CmbAlgoritmoEntrenamiento";
            this.CmbAlgoritmoEntrenamiento.Size = new System.Drawing.Size(230, 32);
            this.CmbAlgoritmoEntrenamiento.TabIndex = 15;
            this.CmbAlgoritmoEntrenamiento.SelectedIndexChanged += new System.EventHandler(this.CmbAlgoritmoEntrenamiento_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(9, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Algoritmo de entrenamiento";
            // 
            // NudRataDinamica
            // 
            this.NudRataDinamica.DecimalPlaces = 5;
            this.NudRataDinamica.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudRataDinamica.Location = new System.Drawing.Point(18, 1016);
            this.NudRataDinamica.Margin = new System.Windows.Forms.Padding(4);
            this.NudRataDinamica.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudRataDinamica.Name = "NudRataDinamica";
            this.NudRataDinamica.Size = new System.Drawing.Size(10, 38);
            this.NudRataDinamica.TabIndex = 13;
            this.NudRataDinamica.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            this.NudRataDinamica.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rata de Aprendizaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Error Maximo";
            // 
            // nudNoIteraciones
            // 
            this.nudNoIteraciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNoIteraciones.Location = new System.Drawing.Point(256, 37);
            this.nudNoIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.nudNoIteraciones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNoIteraciones.Name = "nudNoIteraciones";
            this.nudNoIteraciones.Size = new System.Drawing.Size(115, 38);
            this.nudNoIteraciones.TabIndex = 10;
            this.nudNoIteraciones.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(22, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "N° Iteraciones";
            // 
            // dgvTopologiaRed
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTopologiaRed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTopologiaRed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.dgvTopologiaRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopologiaRed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(11)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopologiaRed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTopologiaRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopologiaRed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Capa,
            this.Neuronas,
            this.Activacion});
            this.dgvTopologiaRed.DoubleBuffered = true;
            this.dgvTopologiaRed.EnableHeadersVisualStyles = false;
            this.dgvTopologiaRed.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(11)))), ((int)(((byte)(151)))));
            this.dgvTopologiaRed.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgvTopologiaRed.Location = new System.Drawing.Point(25, 180);
            this.dgvTopologiaRed.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTopologiaRed.Name = "dgvTopologiaRed";
            this.dgvTopologiaRed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTopologiaRed.RowHeadersWidth = 51;
            this.dgvTopologiaRed.Size = new System.Drawing.Size(563, 99);
            this.dgvTopologiaRed.TabIndex = 4;
            this.dgvTopologiaRed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopologiaRed_CellContentClick);
            this.dgvTopologiaRed.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvTopologiaRed_EditingControlShowing);
            // 
            // Capa
            // 
            this.Capa.HeaderText = "Capas";
            this.Capa.MinimumWidth = 6;
            this.Capa.Name = "Capa";
            this.Capa.Width = 125;
            // 
            // Neuronas
            // 
            this.Neuronas.HeaderText = "Neuronas";
            this.Neuronas.MinimumWidth = 6;
            this.Neuronas.Name = "Neuronas";
            this.Neuronas.Width = 125;
            // 
            // Activacion
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Activacion.HeaderText = "FuncionActivacion";
            this.Activacion.Items.AddRange(new object[] {
            "Escalon",
            "Lineal"});
            this.Activacion.MinimumWidth = 6;
            this.Activacion.Name = "Activacion";
            this.Activacion.ToolTipText = "Funcion de Activacion";
            this.Activacion.Width = 190;
            // 
            // nudNumeroCapas
            // 
            this.nudNumeroCapas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNumeroCapas.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumeroCapas.Location = new System.Drawing.Point(589, 333);
            this.nudNumeroCapas.Margin = new System.Windows.Forms.Padding(4);
            this.nudNumeroCapas.Name = "nudNumeroCapas";
            this.nudNumeroCapas.Size = new System.Drawing.Size(13, 30);
            this.nudNumeroCapas.TabIndex = 12;
            this.nudNumeroCapas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroCapas.Visible = false;
            this.nudNumeroCapas.ValueChanged += new System.EventHandler(this.NudNumeroCapas_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(113, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(388, 37);
            this.label10.TabIndex = 17;
            this.label10.Text = "2) Configuracion de la Red";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPatrones
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPatrones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatrones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.dgvPatrones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatrones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(11)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(11)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatrones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPatrones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatrones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entradas,
            this.Salidas});
            this.dgvPatrones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatrones.DoubleBuffered = true;
            this.dgvPatrones.EnableHeadersVisualStyles = false;
            this.dgvPatrones.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(11)))), ((int)(((byte)(151)))));
            this.dgvPatrones.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgvPatrones.Location = new System.Drawing.Point(0, 0);
            this.dgvPatrones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPatrones.Name = "dgvPatrones";
            this.dgvPatrones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatrones.RowHeadersWidth = 51;
            this.dgvPatrones.Size = new System.Drawing.Size(682, 329);
            this.dgvPatrones.TabIndex = 0;
            // 
            // Entradas
            // 
            this.Entradas.HeaderText = "Entradas(X)";
            this.Entradas.MinimumWidth = 6;
            this.Entradas.Name = "Entradas";
            this.Entradas.Width = 125;
            // 
            // Salidas
            // 
            this.Salidas.HeaderText = "Salidas(YD)";
            this.Salidas.MinimumWidth = 6;
            this.Salidas.Name = "Salidas";
            this.Salidas.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 116);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(799, -2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1123, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(409, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 45);
            this.label6.TabIndex = 37;
            this.label6.Text = "RED NURONAL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(332, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(472, 45);
            this.label11.TabIndex = 36;
            this.label11.Text = "INTELIGENCIA ARTIFICIAL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, -39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.TxtEntradas);
            this.panel3.Controls.Add(this.TxtSalidas);
            this.panel3.Controls.Add(this.TxtPatrones);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.BtIngresarDatos);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.bunifuGradientPanel1);
            this.panel3.Location = new System.Drawing.Point(10, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 445);
            this.panel3.TabIndex = 21;
            // 
            // TxtEntradas
            // 
            this.TxtEntradas.Enabled = false;
            this.TxtEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEntradas.Location = new System.Drawing.Point(296, 406);
            this.TxtEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEntradas.Name = "TxtEntradas";
            this.TxtEntradas.Size = new System.Drawing.Size(98, 30);
            this.TxtEntradas.TabIndex = 92;
            // 
            // TxtSalidas
            // 
            this.TxtSalidas.Enabled = false;
            this.TxtSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalidas.Location = new System.Drawing.Point(425, 406);
            this.TxtSalidas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSalidas.Name = "TxtSalidas";
            this.TxtSalidas.Size = new System.Drawing.Size(88, 30);
            this.TxtSalidas.TabIndex = 93;
            // 
            // TxtPatrones
            // 
            this.TxtPatrones.Enabled = false;
            this.TxtPatrones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatrones.Location = new System.Drawing.Point(546, 406);
            this.TxtPatrones.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPatrones.Name = "TxtPatrones";
            this.TxtPatrones.Size = new System.Drawing.Size(98, 30);
            this.TxtPatrones.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(540, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 89;
            this.label1.Text = "#Patrones";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(279, 371);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 31);
            this.label17.TabIndex = 90;
            this.label17.Text = "#Entradas";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(421, 371);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 31);
            this.label20.TabIndex = 91;
            this.label20.Text = "#Salidas";
            // 
            // BtIngresarDatos
            // 
            this.BtIngresarDatos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtIngresarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.BtIngresarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIngresarDatos.BorderRadius = 0;
            this.BtIngresarDatos.ButtonText = "Ingresar Datos";
            this.BtIngresarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtIngresarDatos.DisabledColor = System.Drawing.Color.Gray;
            this.BtIngresarDatos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtIngresarDatos.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtIngresarDatos.Iconimage")));
            this.BtIngresarDatos.Iconimage_right = null;
            this.BtIngresarDatos.Iconimage_right_Selected = null;
            this.BtIngresarDatos.Iconimage_Selected = null;
            this.BtIngresarDatos.IconMarginLeft = 0;
            this.BtIngresarDatos.IconMarginRight = 0;
            this.BtIngresarDatos.IconRightVisible = true;
            this.BtIngresarDatos.IconRightZoom = 0D;
            this.BtIngresarDatos.IconVisible = true;
            this.BtIngresarDatos.IconZoom = 90D;
            this.BtIngresarDatos.IsTab = false;
            this.BtIngresarDatos.Location = new System.Drawing.Point(13, 375);
            this.BtIngresarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtIngresarDatos.Name = "BtIngresarDatos";
            this.BtIngresarDatos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.BtIngresarDatos.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.BtIngresarDatos.OnHoverTextColor = System.Drawing.Color.White;
            this.BtIngresarDatos.selected = false;
            this.BtIngresarDatos.Size = new System.Drawing.Size(213, 47);
            this.BtIngresarDatos.TabIndex = 1;
            this.BtIngresarDatos.Text = "Ingresar Datos";
            this.BtIngresarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtIngresarDatos.Textcolor = System.Drawing.Color.White;
            this.BtIngresarDatos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIngresarDatos.Click += new System.EventHandler(this.BtIngresarDatos_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(139, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(389, 37);
            this.label12.TabIndex = 17;
            this.label12.Text = "1) Parametros de entradas";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dgvPatrones);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(6, 39);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(682, 329);
            this.bunifuGradientPanel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.bunifuFlatButton7);
            this.panel4.Controls.Add(this.bunifuFlatButton6);
            this.panel4.Controls.Add(this.bunifuFlatButton5);
            this.panel4.Controls.Add(this.bunifuFlatButton3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.nudNumeroCapas);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.CmbAlgoritmoEntrenamiento);
            this.panel4.Controls.Add(this.dgvTopologiaRed);
            this.panel4.Location = new System.Drawing.Point(5, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 294);
            this.panel4.TabIndex = 24;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Adaline";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(431, 90);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(167, 47);
            this.bunifuFlatButton7.TabIndex = 104;
            this.bunifuFlatButton7.Text = "Adaline";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.AllowDrop = true;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Perceptron";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(246, 90);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(167, 47);
            this.bunifuFlatButton6.TabIndex = 103;
            this.bunifuFlatButton6.Text = "Perceptron";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Unicapa";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(246, 39);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(167, 47);
            this.bunifuFlatButton5.TabIndex = 102;
            this.bunifuFlatButton5.Text = "Unicapa";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.AllowDrop = true;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "multicapa";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(431, 39);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(167, 47);
            this.bunifuFlatButton3.TabIndex = 20;
            this.bunifuFlatButton3.Text = "multicapa";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 38);
            this.label7.TabIndex = 101;
            this.label7.Text = "Nombre Red";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(107, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 38);
            this.label13.TabIndex = 98;
            this.label13.Text = "Tipo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.bunifuFlatButton2);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.bunifuFlatButton1);
            this.panel5.Location = new System.Drawing.Point(3, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 119);
            this.panel5.TabIndex = 27;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Cargar pesos y umbrales";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(289, 51);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(227, 54);
            this.bunifuFlatButton2.TabIndex = 34;
            this.bunifuFlatButton2.Text = "Cargar pesos y umbrales";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(1, 6);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(525, 37);
            this.label14.TabIndex = 18;
            this.label14.Text = "3) Inicializacion de pesos y umbrales";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Crear Pesos y Umbrales NUEVOS";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(4, 51);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(269, 54);
            this.bunifuFlatButton1.TabIndex = 20;
            this.bunifuFlatButton1.Text = "Crear Pesos y Umbrales NUEVOS";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.nudErrorMaximo);
            this.panel6.Controls.Add(this.nudRataAprendizaje);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.nudNoIteraciones);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(3, 134);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 173);
            this.panel6.TabIndex = 29;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // nudErrorMaximo
            // 
            this.nudErrorMaximo.DecimalPlaces = 50;
            this.nudErrorMaximo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.nudErrorMaximo.Location = new System.Drawing.Point(256, 81);
            this.nudErrorMaximo.Margin = new System.Windows.Forms.Padding(4);
            this.nudErrorMaximo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudErrorMaximo.Name = "nudErrorMaximo";
            this.nudErrorMaximo.Size = new System.Drawing.Size(115, 38);
            this.nudErrorMaximo.TabIndex = 108;
            this.nudErrorMaximo.Value = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            // 
            // nudRataAprendizaje
            // 
            this.nudRataAprendizaje.DecimalPlaces = 5;
            this.nudRataAprendizaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.nudRataAprendizaje.Location = new System.Drawing.Point(256, 125);
            this.nudRataAprendizaje.Margin = new System.Windows.Forms.Padding(4);
            this.nudRataAprendizaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRataAprendizaje.Name = "nudRataAprendizaje";
            this.nudRataAprendizaje.Size = new System.Drawing.Size(115, 38);
            this.nudRataAprendizaje.TabIndex = 107;
            this.nudRataAprendizaje.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(24, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(474, 37);
            this.label15.TabIndex = 28;
            this.label15.Text = "4) Parametros de entrenamiento";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.panel8.Controls.Add(this.bunifuFlatButton4);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.BtDetener);
            this.panel8.Controls.Add(this.BtEntrenar);
            this.panel8.Location = new System.Drawing.Point(801, 509);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(359, 250);
            this.panel8.TabIndex = 31;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Iniciar nuevo entrenamiento";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(57, 172);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(239, 70);
            this.bunifuFlatButton4.TabIndex = 35;
            this.bunifuFlatButton4.Text = "Iniciar nuevo entrenamiento";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(59, 17);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(261, 37);
            this.label16.TabIndex = 27;
            this.label16.Text = "5) Entrenamiento";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtDetener
            // 
            this.BtDetener.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.BtDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtDetener.BorderRadius = 0;
            this.BtDetener.ButtonText = "Stop";
            this.BtDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtDetener.DisabledColor = System.Drawing.Color.Gray;
            this.BtDetener.Iconcolor = System.Drawing.Color.Transparent;
            this.BtDetener.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtDetener.Iconimage")));
            this.BtDetener.Iconimage_right = null;
            this.BtDetener.Iconimage_right_Selected = null;
            this.BtDetener.Iconimage_Selected = null;
            this.BtDetener.IconMarginLeft = 0;
            this.BtDetener.IconMarginRight = 0;
            this.BtDetener.IconRightVisible = true;
            this.BtDetener.IconRightZoom = 0D;
            this.BtDetener.IconVisible = true;
            this.BtDetener.IconZoom = 90D;
            this.BtDetener.IsTab = false;
            this.BtDetener.Location = new System.Drawing.Point(92, 117);
            this.BtDetener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtDetener.Name = "BtDetener";
            this.BtDetener.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.BtDetener.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.BtDetener.OnHoverTextColor = System.Drawing.Color.White;
            this.BtDetener.selected = false;
            this.BtDetener.Size = new System.Drawing.Size(171, 47);
            this.BtDetener.TabIndex = 34;
            this.BtDetener.Text = "Stop";
            this.BtDetener.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDetener.Textcolor = System.Drawing.Color.White;
            this.BtDetener.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDetener.Click += new System.EventHandler(this.BtDetener_Click);
            // 
            // BtEntrenar
            // 
            this.BtEntrenar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtEntrenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.BtEntrenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEntrenar.BorderRadius = 0;
            this.BtEntrenar.ButtonText = "Entrenar";
            this.BtEntrenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEntrenar.DisabledColor = System.Drawing.Color.Gray;
            this.BtEntrenar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtEntrenar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtEntrenar.Iconimage")));
            this.BtEntrenar.Iconimage_right = null;
            this.BtEntrenar.Iconimage_right_Selected = null;
            this.BtEntrenar.Iconimage_Selected = null;
            this.BtEntrenar.IconMarginLeft = 0;
            this.BtEntrenar.IconMarginRight = 0;
            this.BtEntrenar.IconRightVisible = true;
            this.BtEntrenar.IconRightZoom = 0D;
            this.BtEntrenar.IconVisible = true;
            this.BtEntrenar.IconZoom = 90D;
            this.BtEntrenar.IsTab = false;
            this.BtEntrenar.Location = new System.Drawing.Point(92, 62);
            this.BtEntrenar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtEntrenar.Name = "BtEntrenar";
            this.BtEntrenar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.BtEntrenar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.BtEntrenar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtEntrenar.selected = false;
            this.BtEntrenar.Size = new System.Drawing.Size(171, 47);
            this.BtEntrenar.TabIndex = 20;
            this.BtEntrenar.Text = "Entrenar";
            this.BtEntrenar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEntrenar.Textcolor = System.Drawing.Color.White;
            this.BtEntrenar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEntrenar.Click += new System.EventHandler(this.BtEntrenar_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(0, 1030);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(10, 38);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1270, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 37);
            this.label5.TabIndex = 32;
            this.label5.Text = "Grafica Error de iteracion vs iteracion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(252, 584);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 37);
            this.label9.TabIndex = 33;
            this.label9.Text = "Grafica YD vs YR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(12, 122);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(726, 459);
            this.panel7.TabIndex = 34;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Location = new System.Drawing.Point(744, 122);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(624, 319);
            this.panel9.TabIndex = 35;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Location = new System.Drawing.Point(1377, 122);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(535, 319);
            this.panel10.TabIndex = 36;
            // 
            // pixel1
            // 
            this.pixel1.Image = ((System.Drawing.Image)(resources.GetObject("pixel1.Image")));
            this.pixel1.Location = new System.Drawing.Point(35, 623);
            this.pixel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pixel1.Name = "pixel1";
            this.pixel1.Size = new System.Drawing.Size(687, 676);
            this.pixel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixel1.TabIndex = 104;
            this.pixel1.TabStop = false;
            // 
            // pixel2
            // 
            this.pixel2.Image = ((System.Drawing.Image)(resources.GetObject("pixel2.Image")));
            this.pixel2.Location = new System.Drawing.Point(1190, 488);
            this.pixel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pixel2.Name = "pixel2";
            this.pixel2.Size = new System.Drawing.Size(709, 797);
            this.pixel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixel2.TabIndex = 105;
            this.pixel2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.panel11.Controls.Add(this.label18);
            this.panel11.Controls.Add(this.DgvParametrosSimulacion);
            this.panel11.Controls.Add(this.btnSimular);
            this.panel11.Location = new System.Drawing.Point(756, 874);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1142, 175);
            this.panel11.TabIndex = 106;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(430, 1);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(319, 37);
            this.label18.TabIndex = 29;
            this.label18.Text = "6) Fase de Simulacion";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvParametrosSimulacion
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvParametrosSimulacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvParametrosSimulacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.DgvParametrosSimulacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvParametrosSimulacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvParametrosSimulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvParametrosSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvParametrosSimulacion.DoubleBuffered = true;
            this.DgvParametrosSimulacion.EnableHeadersVisualStyles = false;
            this.DgvParametrosSimulacion.HeaderBgColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvParametrosSimulacion.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.DgvParametrosSimulacion.Location = new System.Drawing.Point(29, 39);
            this.DgvParametrosSimulacion.Margin = new System.Windows.Forms.Padding(4);
            this.DgvParametrosSimulacion.Name = "DgvParametrosSimulacion";
            this.DgvParametrosSimulacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvParametrosSimulacion.RowHeadersWidth = 51;
            this.DgvParametrosSimulacion.Size = new System.Drawing.Size(1082, 84);
            this.DgvParametrosSimulacion.TabIndex = 4;
            this.DgvParametrosSimulacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvParametrosSimulacion_KeyDown);
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(5)))), ((int)(((byte)(194)))));
            this.btnSimular.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.ForeColor = System.Drawing.Color.White;
            this.btnSimular.Location = new System.Drawing.Point(396, 128);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(328, 45);
            this.btnSimular.TabIndex = 22;
            this.btnSimular.Text = "Simular patrones";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.pixel2);
            this.Controls.Add(this.pixel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudRataDinamica);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.CartesianErrors);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblIteracion);
            this.Controls.Add(this.CartesianVariacionRealDeseada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Red_Neuronal_Adaline_y_Perceptron";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorvsIteracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRataDinamica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopologiaRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCapas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudErrorMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRataAprendizaje)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pixel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixel2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvParametrosSimulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartErrorvsIteracion;
        private LiveCharts.WinForms.CartesianChart CartesianErrors;
        private LiveCharts.WinForms.CartesianChart CartesianVariacionRealDeseada;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTopologiaRed;
        private System.Windows.Forms.ComboBox CmbAlgoritmoEntrenamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudRataDinamica;
        private System.Windows.Forms.NumericUpDown nudNumeroCapas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNoIteraciones;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPatrones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblIteracion;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salidas;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtIngresarDatos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton BtEntrenar;
        private Bunifu.Framework.UI.BunifuFlatButton BtDetener;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pixel1;
        private System.Windows.Forms.PictureBox pixel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.NumericUpDown nudErrorMaximo;
        private System.Windows.Forms.NumericUpDown nudRataAprendizaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neuronas;
        private System.Windows.Forms.DataGridViewComboBoxColumn Activacion;
        private System.Windows.Forms.TextBox TxtEntradas;
        private System.Windows.Forms.TextBox TxtSalidas;
        private System.Windows.Forms.TextBox TxtPatrones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvParametrosSimulacion;
        private System.Windows.Forms.Button btnSimular;
    }
}

