namespace Lab1
{
    partial class uTunes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uTunes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.nowPlaying = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCancion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtCanciones = new System.Windows.Forms.DataGridView();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAgregarPlaylist = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbDes = new System.Windows.Forms.RadioButton();
            this.rdbAs = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.lblNombrePlaylist = new System.Windows.Forms.Label();
            this.dtPlaylist = new System.Windows.Forms.DataGridView();
            this.mediaP = new AxWMPLib.AxWindowsMediaPlayer();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenu});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(960, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // userMenu
            // 
            this.userMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(59, 20);
            this.userMenu.Text = "Usuario";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowPlaying});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // nowPlaying
            // 
            this.nowPlaying.Name = "nowPlaying";
            this.nowPlaying.Size = new System.Drawing.Size(188, 17);
            this.nowPlaying.Text = "Ninguna cancion en reproduccion";
            this.nowPlaying.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Busca una canción:";
            // 
            // txtCancion
            // 
            this.txtCancion.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancion.Location = new System.Drawing.Point(12, 79);
            this.txtCancion.Name = "txtCancion";
            this.txtCancion.Size = new System.Drawing.Size(485, 26);
            this.txtCancion.TabIndex = 6;
            this.txtCancion.TextChanged += new System.EventHandler(this.txtCancion_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(522, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(400, 27);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtCanciones
            // 
            this.dtCanciones.AllowUserToAddRows = false;
            this.dtCanciones.AllowUserToDeleteRows = false;
            this.dtCanciones.AllowUserToResizeColumns = false;
            this.dtCanciones.AllowUserToResizeRows = false;
            this.dtCanciones.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtCanciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCanciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Artista,
            this.Genero,
            this.Duracion,
            this.url});
            this.dtCanciones.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCanciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtCanciones.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dtCanciones.Location = new System.Drawing.Point(12, 111);
            this.dtCanciones.Name = "dtCanciones";
            this.dtCanciones.ReadOnly = true;
            this.dtCanciones.RowHeadersVisible = false;
            this.dtCanciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtCanciones.Size = new System.Drawing.Size(910, 325);
            this.dtCanciones.TabIndex = 9;
            this.dtCanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCanciones_CellContentClick);
            this.dtCanciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCanciones_CellContentDoubleClick);
            this.dtCanciones.SelectionChanged += new System.EventHandler(this.dtCanciones_SelectionChanged);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(31, 447);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(917, 46);
            this.mediaPlayer.TabIndex = 12;
            this.mediaPlayer.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.mediaPlayer_EndOfStream);
            // 
            // btnAgregarPlaylist
            // 
            this.btnAgregarPlaylist.Enabled = false;
            this.btnAgregarPlaylist.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlaylist.Location = new System.Drawing.Point(522, 45);
            this.btnAgregarPlaylist.Name = "btnAgregarPlaylist";
            this.btnAgregarPlaylist.Size = new System.Drawing.Size(184, 27);
            this.btnAgregarPlaylist.TabIndex = 13;
            this.btnAgregarPlaylist.Text = "Agregar a la playlist";
            this.btnAgregarPlaylist.UseVisualStyleBackColor = true;
            this.btnAgregarPlaylist.Click += new System.EventHandler(this.btnAgregarPlaylist_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 465);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAgregarPlaylist);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.dtCanciones);
            this.tabPage1.Controls.Add(this.txtCancion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Canciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(734, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 27);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Subir una cancion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.rdbDes);
            this.tabPage2.Controls.Add(this.rdbAs);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbOrdenar);
            this.tabPage2.Controls.Add(this.lblNombrePlaylist);
            this.tabPage2.Controls.Add(this.dtPlaylist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Playlist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdbDes
            // 
            this.rdbDes.AutoSize = true;
            this.rdbDes.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDes.Location = new System.Drawing.Point(271, 347);
            this.rdbDes.Name = "rdbDes";
            this.rdbDes.Size = new System.Drawing.Size(157, 22);
            this.rdbDes.TabIndex = 21;
            this.rdbDes.TabStop = true;
            this.rdbDes.Text = "Descendentemente";
            this.rdbDes.UseVisualStyleBackColor = true;
            // 
            // rdbAs
            // 
            this.rdbAs.AutoSize = true;
            this.rdbAs.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAs.Location = new System.Drawing.Point(434, 345);
            this.rdbAs.Name = "rdbAs";
            this.rdbAs.Size = new System.Drawing.Size(148, 22);
            this.rdbAs.TabIndex = 20;
            this.rdbAs.TabStop = true;
            this.rdbAs.Text = "Ascendentemente";
            this.rdbAs.UseVisualStyleBackColor = true;
            this.rdbAs.CheckedChanged += new System.EventHandler(this.rdbAs_CheckedChanged);
            this.rdbAs.EnabledChanged += new System.EventHandler(this.rdbAs_EnabledChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(24, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ordenar Por";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Titulo",
            "Duración"});
            this.cmbOrdenar.Location = new System.Drawing.Point(144, 346);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 26);
            this.cmbOrdenar.TabIndex = 18;
            this.cmbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenar_SelectedIndexChanged);
            // 
            // lblNombrePlaylist
            // 
            this.lblNombrePlaylist.AutoSize = true;
            this.lblNombrePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePlaylist.Font = new System.Drawing.Font("Eras Medium ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlaylist.ForeColor = System.Drawing.Color.Snow;
            this.lblNombrePlaylist.Location = new System.Drawing.Point(358, 19);
            this.lblNombrePlaylist.Name = "lblNombrePlaylist";
            this.lblNombrePlaylist.Size = new System.Drawing.Size(137, 31);
            this.lblNombrePlaylist.TabIndex = 17;
            this.lblNombrePlaylist.Text = "Mi PlayList";
            // 
            // dtPlaylist
            // 
            this.dtPlaylist.AllowUserToAddRows = false;
            this.dtPlaylist.AllowUserToDeleteRows = false;
            this.dtPlaylist.AllowUserToResizeColumns = false;
            this.dtPlaylist.AllowUserToResizeRows = false;
            this.dtPlaylist.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPlaylist.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtPlaylist.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dtPlaylist.Location = new System.Drawing.Point(12, 67);
            this.dtPlaylist.Name = "dtPlaylist";
            this.dtPlaylist.ReadOnly = true;
            this.dtPlaylist.RowHeadersVisible = false;
            this.dtPlaylist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtPlaylist.Size = new System.Drawing.Size(910, 266);
            this.dtPlaylist.TabIndex = 10;
            this.dtPlaylist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPlaylist_CellDoubleClick);
            this.dtPlaylist.SelectionChanged += new System.EventHandler(this.dtPlaylist_SelectionChanged);
            // 
            // mediaP
            // 
            this.mediaP.Enabled = true;
            this.mediaP.Location = new System.Drawing.Point(12, 517);
            this.mediaP.Name = "mediaP";
            this.mediaP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaP.OcxState")));
            this.mediaP.Size = new System.Drawing.Size(936, 46);
            this.mediaP.TabIndex = 15;
            // 
            // openDialog
            // 
            this.openDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDialog_FileOk);
            // 
            // Titulo
            // 
            this.Titulo.FillWeight = 1F;
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Titulo.Width = 383;
            // 
            // Artista
            // 
            this.Artista.FillWeight = 110F;
            this.Artista.Frozen = true;
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            this.Artista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Artista.Width = 319;
            // 
            // Genero
            // 
            this.Genero.Frozen = true;
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Genero.Width = 105;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // url
            // 
            this.url.HeaderText = "url";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 1F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 383;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 110F;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Artista";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 319;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "url";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // uTunes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.mediaP);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "uTunes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uTunes";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem userMenu;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel nowPlaying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCancion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtCanciones;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button btnAgregarPlaylist;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AxWMPLib.AxWindowsMediaPlayer mediaP;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.DataGridView dtPlaylist;
        private System.Windows.Forms.Label lblNombrePlaylist;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rdbDes;
        private System.Windows.Forms.RadioButton rdbAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}