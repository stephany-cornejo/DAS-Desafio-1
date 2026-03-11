namespace DesafioDas;

partial class Form1
{

    private System.ComponentModel.IContainer components = null;

    private TabControl tabControlMain;
    private TabPage tabPageLibros;
    private TabPage tabPageUsuarios;
    private TabPage tabPagePrestamos;

    // Libros Controles
    private DataGridView dataGridViewLibros;
    private Label labelTituloLibros;
    private Button btnAgregar;
    private Button btnEditar;
    private Button btnEliminar;
    private Button btnGuardarLibro;
    private Label labelLibroTitulo;
    private TextBox textBoxLibroTitulo;
    private Label labelLibroAutor;
    private TextBox textBoxLibroAutor;
    private Label labelLibroAño;
    private TextBox textBoxLibroAño;
    
    // Usuarios Controles
    private Label labelTituloUsuarios;
    private DataGridView dataGridViewUsuarios;
    private Button btnAgregarUsuario;
    private Button btnEditarUsuario;
    private Button btnEliminarUsuario;
    private Button btnGuardarUsuario;
    private Label labelUsuarioNombre;
    private TextBox textBoxUsuarioNombre;
    private Label labelUsuarioCorreo;
    private TextBox textBoxUsuarioCorreo;
    
    // Préstamos Controles
    private Label labelTituloPrestamos;
    private ComboBox comboBoxUsuarios;
    private DataGridView dataGridViewPrestamos;
    private Button btnAgregarPrestamo;
    private Button btnEditarPrestamo;
    private Button btnEliminarPrestamo;
    private Button btnGuardarPrestamo;
    private Label labelPrestamoUsuario;
    private ComboBox comboBoxPrestamoUsuario;
    private Label labelPrestamoLibro;
    private ComboBox comboBoxPrestamoLibro;
    private Label labelPrestamoFechaPrestamo;
    private DateTimePicker dateTimePickerPrestamoFechaPrestamo;
    private Label labelPrestamoFechaDevolucion;
    private DateTimePicker dateTimePickerPrestamoFechaDevolucion;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        
        
        this.tabControlMain = new TabControl();
        this.tabPageLibros = new TabPage();
        this.tabPageUsuarios = new TabPage();
        this.tabPagePrestamos = new TabPage();
        
        
        this.tabControlMain.Controls.Add(this.tabPageLibros);
        this.tabControlMain.Controls.Add(this.tabPageUsuarios);
        this.tabControlMain.Controls.Add(this.tabPagePrestamos);
        
        this.tabPageLibros.Text = "Libros";
        this.tabPageUsuarios.Text = "Usuarios";
        this.tabPagePrestamos.Text = "Préstamos";
        
        // ========== LIBROS TAB ==========
        this.labelTituloLibros = new Label();
        this.labelTituloLibros.Text = "Administrar libros";
        this.labelTituloLibros.Location = new System.Drawing.Point(12, 12);
        this.labelTituloLibros.Size = new System.Drawing.Size(400, 25);
        this.labelTituloLibros.Font = new System.Drawing.Font(this.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
        this.tabPageLibros.Controls.Add(this.labelTituloLibros);
        
        // DataGridView Libros
        this.dataGridViewLibros = new DataGridView();
        this.dataGridViewLibros.Location = new System.Drawing.Point(12, 40);
        this.dataGridViewLibros.Size = new System.Drawing.Size(580, 200);
        this.dataGridViewLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewLibros.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        this.dataGridViewLibros.BorderStyle = BorderStyle.Fixed3D;
        this.dataGridViewLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.tabPageLibros.Controls.Add(this.dataGridViewLibros);
        
        int libroInputY = 250;
        
        this.labelLibroTitulo = new Label();
        this.labelLibroTitulo.Text = "Título:";
        this.labelLibroTitulo.Location = new System.Drawing.Point(12, libroInputY);
        this.labelLibroTitulo.Size = new System.Drawing.Size(100, 25);
        this.labelLibroTitulo.Visible = false;
        this.tabPageLibros.Controls.Add(this.labelLibroTitulo);
        
        this.textBoxLibroTitulo = new TextBox();
        this.textBoxLibroTitulo.Location = new System.Drawing.Point(120, libroInputY);
        this.textBoxLibroTitulo.Size = new System.Drawing.Size(200, 25);
        this.textBoxLibroTitulo.Visible = false;
        this.tabPageLibros.Controls.Add(this.textBoxLibroTitulo);
        
        this.labelLibroAutor = new Label();
        this.labelLibroAutor.Text = "Autor:";
        this.labelLibroAutor.Location = new System.Drawing.Point(12, libroInputY + 35);
        this.labelLibroAutor.Size = new System.Drawing.Size(100, 25);
        this.labelLibroAutor.Visible = false;
        this.tabPageLibros.Controls.Add(this.labelLibroAutor);
        
        this.textBoxLibroAutor = new TextBox();
        this.textBoxLibroAutor.Location = new System.Drawing.Point(120, libroInputY + 35);
        this.textBoxLibroAutor.Size = new System.Drawing.Size(200, 25);
        this.textBoxLibroAutor.Visible = false;
        this.tabPageLibros.Controls.Add(this.textBoxLibroAutor);
        
        this.labelLibroAño = new Label();
        this.labelLibroAño.Text = "Año:";
        this.labelLibroAño.Location = new System.Drawing.Point(12, libroInputY + 70);
        this.labelLibroAño.Size = new System.Drawing.Size(100, 25);
        this.labelLibroAño.Visible = false;
        this.tabPageLibros.Controls.Add(this.labelLibroAño);
        
        this.textBoxLibroAño = new TextBox();
        this.textBoxLibroAño.Location = new System.Drawing.Point(120, libroInputY + 70);
        this.textBoxLibroAño.Size = new System.Drawing.Size(200, 25);
        this.textBoxLibroAño.Visible = false;
        this.tabPageLibros.Controls.Add(this.textBoxLibroAño);
        
        this.btnAgregar = new Button();
        this.btnAgregar.Text = "Agregar";
        this.btnAgregar.Location = new System.Drawing.Point(12, libroInputY + 110);
        this.btnAgregar.Size = new System.Drawing.Size(90, 30);
        this.tabPageLibros.Controls.Add(this.btnAgregar);
        
        this.btnEditar = new Button();
        this.btnEditar.Text = "Editar";
        this.btnEditar.Location = new System.Drawing.Point(112, libroInputY + 110);
        this.btnEditar.Size = new System.Drawing.Size(90, 30);
        this.tabPageLibros.Controls.Add(this.btnEditar);
        
        this.btnEliminar = new Button();
        this.btnEliminar.Text = "Eliminar";
        this.btnEliminar.Location = new System.Drawing.Point(212, libroInputY + 110);
        this.btnEliminar.Size = new System.Drawing.Size(90, 30);
        this.tabPageLibros.Controls.Add(this.btnEliminar);
        
        this.btnGuardarLibro = new Button();
        this.btnGuardarLibro.Text = "Guardar";
        this.btnGuardarLibro.Location = new System.Drawing.Point(312, libroInputY + 110);
        this.btnGuardarLibro.Size = new System.Drawing.Size(90, 30);
        this.btnGuardarLibro.Visible = false;
        this.tabPageLibros.Controls.Add(this.btnGuardarLibro);
        
        // ========== USUARIOS TAB ==========
        this.labelTituloUsuarios = new Label();
        this.labelTituloUsuarios.Text = "Administrar usuarios";
        this.labelTituloUsuarios.Location = new System.Drawing.Point(12, 12);
        this.labelTituloUsuarios.Size = new System.Drawing.Size(400, 25);
        this.labelTituloUsuarios.Font = new System.Drawing.Font(this.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
        this.tabPageUsuarios.Controls.Add(this.labelTituloUsuarios);
        
        // DataGridView Usuarios
        this.dataGridViewUsuarios = new DataGridView();
        this.dataGridViewUsuarios.Location = new System.Drawing.Point(12, 47);
        this.dataGridViewUsuarios.Size = new System.Drawing.Size(580, 200);
        this.dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewUsuarios.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        this.dataGridViewUsuarios.BorderStyle = BorderStyle.Fixed3D;
        this.dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.tabPageUsuarios.Controls.Add(this.dataGridViewUsuarios);
        
        int usuarioInputY = 255;
        
        this.labelUsuarioNombre = new Label();
        this.labelUsuarioNombre.Text = "Nombre:";
        this.labelUsuarioNombre.Location = new System.Drawing.Point(12, usuarioInputY);
        this.labelUsuarioNombre.Size = new System.Drawing.Size(100, 25);
        this.labelUsuarioNombre.Visible = false;
        this.tabPageUsuarios.Controls.Add(this.labelUsuarioNombre);
        
        this.textBoxUsuarioNombre = new TextBox();
        this.textBoxUsuarioNombre.Location = new System.Drawing.Point(120, usuarioInputY);
        this.textBoxUsuarioNombre.Size = new System.Drawing.Size(200, 25);
        this.textBoxUsuarioNombre.Visible = false;
        this.tabPageUsuarios.Controls.Add(this.textBoxUsuarioNombre);
        
        this.labelUsuarioCorreo = new Label();
        this.labelUsuarioCorreo.Text = "Correo:";
        this.labelUsuarioCorreo.Location = new System.Drawing.Point(12, usuarioInputY + 35);
        this.labelUsuarioCorreo.Size = new System.Drawing.Size(100, 25);
        this.labelUsuarioCorreo.Visible = false;
        this.tabPageUsuarios.Controls.Add(this.labelUsuarioCorreo);
        
        this.textBoxUsuarioCorreo = new TextBox();
        this.textBoxUsuarioCorreo.Location = new System.Drawing.Point(120, usuarioInputY + 35);
        this.textBoxUsuarioCorreo.Size = new System.Drawing.Size(200, 25);
        this.textBoxUsuarioCorreo.Visible = false;
        this.tabPageUsuarios.Controls.Add(this.textBoxUsuarioCorreo);
        
        this.btnAgregarUsuario = new Button();
        this.btnAgregarUsuario.Text = "Agregar";
        this.btnAgregarUsuario.Location = new System.Drawing.Point(12, usuarioInputY + 75);
        this.btnAgregarUsuario.Size = new System.Drawing.Size(90, 30);
        this.tabPageUsuarios.Controls.Add(this.btnAgregarUsuario);
        
        this.btnEditarUsuario = new Button();
        this.btnEditarUsuario.Text = "Editar";
        this.btnEditarUsuario.Location = new System.Drawing.Point(112, usuarioInputY + 75);
        this.btnEditarUsuario.Size = new System.Drawing.Size(90, 30);
        this.tabPageUsuarios.Controls.Add(this.btnEditarUsuario);
        
        this.btnEliminarUsuario = new Button();
        this.btnEliminarUsuario.Text = "Eliminar";
        this.btnEliminarUsuario.Location = new System.Drawing.Point(212, usuarioInputY + 75);
        this.btnEliminarUsuario.Size = new System.Drawing.Size(90, 30);
        this.tabPageUsuarios.Controls.Add(this.btnEliminarUsuario);
        
        this.btnGuardarUsuario = new Button();
        this.btnGuardarUsuario.Text = "Guardar";
        this.btnGuardarUsuario.Location = new System.Drawing.Point(312, usuarioInputY + 75);
        this.btnGuardarUsuario.Size = new System.Drawing.Size(90, 30);
        this.btnGuardarUsuario.Visible = false;
        this.tabPageUsuarios.Controls.Add(this.btnGuardarUsuario);
        
        // ========== PRÉSTAMOS TAB ==========
        this.labelTituloPrestamos = new Label();
        this.labelTituloPrestamos.Text = "Gestionar Préstamos";
        this.labelTituloPrestamos.Location = new System.Drawing.Point(12, 12);
        this.labelTituloPrestamos.Size = new System.Drawing.Size(400, 25);
        this.labelTituloPrestamos.Font = new System.Drawing.Font(this.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
        this.tabPagePrestamos.Controls.Add(this.labelTituloPrestamos);
        
        this.comboBoxUsuarios = new ComboBox();
        this.comboBoxUsuarios.Location = new System.Drawing.Point(12, 47);
        this.comboBoxUsuarios.Size = new System.Drawing.Size(300, 25);
        this.comboBoxUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
        this.tabPagePrestamos.Controls.Add(this.comboBoxUsuarios);
        
        // DataGridView Préstamos
        this.dataGridViewPrestamos = new DataGridView();
        this.dataGridViewPrestamos.Location = new System.Drawing.Point(12, 82);
        this.dataGridViewPrestamos.Size = new System.Drawing.Size(580, 200);
        this.dataGridViewPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewPrestamos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        this.dataGridViewPrestamos.BorderStyle = BorderStyle.Fixed3D;
        this.dataGridViewPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.tabPagePrestamos.Controls.Add(this.dataGridViewPrestamos);
        
        int prestamoInputY = 290;
        
        this.labelPrestamoUsuario = new Label();
        this.labelPrestamoUsuario.Text = "Usuario:";
        this.labelPrestamoUsuario.Location = new System.Drawing.Point(12, prestamoInputY);
        this.labelPrestamoUsuario.Size = new System.Drawing.Size(100, 25);
        this.labelPrestamoUsuario.Visible = false;
        this.tabPagePrestamos.Controls.Add(this.labelPrestamoUsuario);
        
        this.comboBoxPrestamoUsuario = new ComboBox();
        this.comboBoxPrestamoUsuario.Location = new System.Drawing.Point(120, prestamoInputY);
        this.comboBoxPrestamoUsuario.Size = new System.Drawing.Size(200, 25);
        this.comboBoxPrestamoUsuario.Visible = false;
        this.comboBoxPrestamoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        this.tabPagePrestamos.Controls.Add(this.comboBoxPrestamoUsuario);
        
        this.labelPrestamoLibro = new Label();
        this.labelPrestamoLibro.Text = "Libro:";
        this.labelPrestamoLibro.Location = new System.Drawing.Point(12, prestamoInputY + 35);
        this.labelPrestamoLibro.Size = new System.Drawing.Size(100, 25);
        this.labelPrestamoLibro.Visible = false;
        this.tabPagePrestamos.Controls.Add(this.labelPrestamoLibro);
        
        this.comboBoxPrestamoLibro = new ComboBox();
        this.comboBoxPrestamoLibro.Location = new System.Drawing.Point(120, prestamoInputY + 35);
        this.comboBoxPrestamoLibro.Size = new System.Drawing.Size(200, 25);
        this.comboBoxPrestamoLibro.Visible = false;
        this.comboBoxPrestamoLibro.DropDownStyle = ComboBoxStyle.DropDownList;
        this.tabPagePrestamos.Controls.Add(this.comboBoxPrestamoLibro);
        
        this.labelPrestamoFechaPrestamo = new Label();
        this.labelPrestamoFechaPrestamo.Text = "Fecha Préstamo:";
        this.labelPrestamoFechaPrestamo.Location = new System.Drawing.Point(12, prestamoInputY + 70);
        this.labelPrestamoFechaPrestamo.Size = new System.Drawing.Size(100, 25);
        this.labelPrestamoFechaPrestamo.Visible = false;
        this.tabPagePrestamos.Controls.Add(this.labelPrestamoFechaPrestamo);
        
        this.dateTimePickerPrestamoFechaPrestamo = new DateTimePicker();
        this.dateTimePickerPrestamoFechaPrestamo.Location = new System.Drawing.Point(120, prestamoInputY + 70);
        this.dateTimePickerPrestamoFechaPrestamo.Size = new System.Drawing.Size(200, 25);
        this.dateTimePickerPrestamoFechaPrestamo.Visible = false;
        this.tabPagePrestamos.Controls.Add(this.dateTimePickerPrestamoFechaPrestamo);
        
        this.labelPrestamoFechaDevolucion = new Label();
        this.labelPrestamoFechaDevolucion.Text = "Fecha Devolución:";
        this.labelPrestamoFechaDevolucion.Location = new System.Drawing.Point(12, prestamoInputY + 105);
        this.labelPrestamoFechaDevolucion.Size = new System.Drawing.Size(100, 25);
        this.labelPrestamoFechaDevolucion.Visible = false;
        this.tabPagePrestamos.Controls.Add(this.labelPrestamoFechaDevolucion);
        
        this.dateTimePickerPrestamoFechaDevolucion = new DateTimePicker();
        this.dateTimePickerPrestamoFechaDevolucion.Location = new System.Drawing.Point(120, prestamoInputY + 105);
        this.dateTimePickerPrestamoFechaDevolucion.Size = new System.Drawing.Size(200, 25);
        this.dateTimePickerPrestamoFechaDevolucion.Visible = false;
        this.tabPagePrestamos.Controls.Add(this.dateTimePickerPrestamoFechaDevolucion);
        
        this.btnAgregarPrestamo = new Button();
        this.btnAgregarPrestamo.Text = "Agregar";
        this.btnAgregarPrestamo.Location = new System.Drawing.Point(12, prestamoInputY + 145);
        this.btnAgregarPrestamo.Size = new System.Drawing.Size(90, 30);
        this.tabPagePrestamos.Controls.Add(this.btnAgregarPrestamo);
        
        this.btnEditarPrestamo = new Button();
        this.btnEditarPrestamo.Text = "Editar";
        this.btnEditarPrestamo.Location = new System.Drawing.Point(112, prestamoInputY + 145);
        this.btnEditarPrestamo.Size = new System.Drawing.Size(90, 30);
        this.tabPagePrestamos.Controls.Add(this.btnEditarPrestamo);
        
        this.btnEliminarPrestamo = new Button();
        this.btnEliminarPrestamo.Text = "Eliminar";
        this.btnEliminarPrestamo.Location = new System.Drawing.Point(212, prestamoInputY + 145);
        this.btnEliminarPrestamo.Size = new System.Drawing.Size(90, 30);
        this.tabPagePrestamos.Controls.Add(this.btnEliminarPrestamo);
        
        this.btnGuardarPrestamo = new Button();
        this.btnGuardarPrestamo.Text = "Guardar";
        this.btnGuardarPrestamo.Location = new System.Drawing.Point(312, prestamoInputY + 145);
        this.btnGuardarPrestamo.Size = new System.Drawing.Size(90, 30);
        this.btnGuardarPrestamo.Visible = false;
        this.tabPagePrestamos.Controls.Add(this.btnGuardarPrestamo);
        
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(620, 500);
        this.Text = "Sistema de Gestión de Biblioteca";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Controls.Add(this.tabControlMain);
        this.tabControlMain.Dock = DockStyle.Fill;
    }

    #endregion
}
