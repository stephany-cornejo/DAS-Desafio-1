using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DesafioDas.Models;

namespace DesafioDas;

public partial class Form1 : Form
{
    public static List<clsUsuarios> usuarios = new List<clsUsuarios>();
    public static List<clsLibros> libros = new List<clsLibros>();
    public static List<clsPrestamos> prestamos = new List<clsPrestamos>();

    private int nextIdUsuario = 1;
    private int nextIdLibro = 1;
    private int nextIdPrestamo = 1;
    private int idLibroEnEdicion = -1;
    private int idUsuarioEnEdicion = -1;
    private int idPrestamoEnEdicion = -1;

    public Form1()
    {
        InitializeComponent();
        SetupEventHandlers();
        InitializeDataGridView();
        CargarDatosIniciales();
        ActualizarComboBoxes();
    }

    private void SetupEventHandlers()
    {
        btnAgregar.Click += BtnAgregar_Click;
        btnEditar.Click += BtnEditar_Click;
        btnEliminar.Click += BtnEliminar_Click;
        btnGuardarLibro.Click += BtnGuardarLibro_Click;

        btnAgregarUsuario.Click += BtnAgregarUsuario_Click;
        btnEditarUsuario.Click += BtnEditarUsuario_Click;
        btnEliminarUsuario.Click += BtnEliminarUsuario_Click;
        btnGuardarUsuario.Click += BtnGuardarUsuario_Click;

        btnAgregarPrestamo.Click += BtnAgregarPrestamo_Click;
        btnEditarPrestamo.Click += BtnEditarPrestamo_Click;
        btnEliminarPrestamo.Click += BtnEliminarPrestamo_Click;
        btnGuardarPrestamo.Click += BtnGuardarPrestamo_Click;

        comboBoxUsuarios.SelectedIndexChanged += ComboBoxUsuarios_SelectedIndexChanged;
    }

    private void InitializeDataGridView()
    {
        // Libros
        dataGridViewLibros.Columns.Clear();
        dataGridViewLibros.RowHeadersVisible = false;
        dataGridViewLibros.Columns.Add("ID", "ID");
        dataGridViewLibros.Columns.Add("Titulo", "Título");
        dataGridViewLibros.Columns.Add("Autor", "Autor");
        dataGridViewLibros.Columns.Add("Año", "Año");
        dataGridViewLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        dataGridViewLibros.Columns["ID"].Width = 40;
        dataGridViewLibros.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridViewLibros.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewLibros.Columns["Autor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewLibros.Columns["Año"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        
        // Usuarios
        dataGridViewUsuarios.Columns.Clear();
        dataGridViewUsuarios.RowHeadersVisible = false;
        dataGridViewUsuarios.Columns.Add("ID", "ID");
        dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");
        dataGridViewUsuarios.Columns.Add("CorreoElectronico", "Correo Electrónico");
        dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        dataGridViewUsuarios.Columns["ID"].Width = 40;
        dataGridViewUsuarios.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridViewUsuarios.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewUsuarios.Columns["CorreoElectronico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        
        // Préstamos
        dataGridViewPrestamos.Columns.Clear();
        dataGridViewPrestamos.RowHeadersVisible = false;
        dataGridViewPrestamos.Columns.Add("ID", "ID");
        dataGridViewPrestamos.Columns.Add("Libro", "Libro");
        dataGridViewPrestamos.Columns.Add("FechaPrestamo", "Fecha-Préstamo");
        dataGridViewPrestamos.Columns.Add("FechaDevolucion", "Fecha-Devolución");
        dataGridViewPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        dataGridViewPrestamos.Columns["ID"].Width = 40;
        dataGridViewPrestamos.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridViewPrestamos.Columns["Libro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewPrestamos.Columns["FechaPrestamo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewPrestamos.Columns["FechaDevolucion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void CargarDatosIniciales()
    {
        usuarios.Add(new clsUsuarios("Ana García", "anagarcia78@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Antonio Barrientos", "barrientos99@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Miguel Anaya", "anaya.miguel@hotmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Marcos Cortejo", "cor-mar238@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Maribel Guardado", "mariguardado@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Lisbeth Argueta", "liss34@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Lily Acosta", "lilies09@hotmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Ana Castro", "castro32@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Bryan Castillo", "castillo27@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Jose Bonilla", "josee36bonilla@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Kimberly Chacón", "chaconchacon@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Katerin Gonzalez", "rosesarered@gmail.com") { Id = nextIdUsuario++ });
        usuarios.Add(new clsUsuarios("Kevin Trujillo", "trujillo3kevin@gmail.com") { Id = nextIdUsuario++ });

        libros.Add(new clsLibros("Cien Años de Soledad", "Gabriel García Márquez", "1967") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("La Casa de los Espiritus", "Isabel Allende", "1982") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Como Agua para Chocolate", "Laura Esquivel", "1989") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Delirios", "Laura Restrepo", "2004") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("La Fiesta del Chivo", "Mario Vargas LLosa", "2000") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Los Pasos Perdidos", "Alejo Carpentier", "1953") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Romeo y Julieta", "William Shakespeare", "1597") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Don Quijote de la Mancha", "Miguel de Cervantes", "1605") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Orgullo y Prejuicio", "Jane Austen", "1813") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Frankenstein", "Mary Shelley", "1818") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Los 3 Mosqueteros", "Alexandre Dumas", "1844") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Cumbres Borrascosas", "Emily Bronte", "1847") { Id = nextIdLibro++ });
        libros.Add(new clsLibros("Jane Eyre", "Charlotte Bronte", "1847") { Id = nextIdLibro++ });    

        prestamos.Add(new clsPrestamos(1, 1, "1984", "Juan Pérez", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(7)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(2, 2, "Don Quijote", "María García", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(2)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(7, 5, "Romeo y Julieta", "Maribel Guardado", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(17)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(10, 7, "Frankenstein", "Lily Acosta", DateTime.Now.AddDays(-20), DateTime.Now.AddDays(1)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(1, 5, "Don Quijote", "Maribel Guardado", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(5)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(6, 2, "Los Pasos Perdidos", "Juan Pérez", DateTime.Now.AddDays(-12), DateTime.Now.AddDays(15)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(4, 7, "Delirios", "Lily Acosta", DateTime.Now.AddDays(-29), DateTime.Now.AddDays(-3)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(7, 8, "Romeo y Julieta", "Ana Castro", DateTime.Now.AddDays(-28), DateTime.Now.AddDays(-1)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(13, 10, "Jane Eyre", "José Bonilla", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(12)) { Id = nextIdPrestamo++ });
        prestamos.Add(new clsPrestamos(10, 9, "Frankenstein", "Bryan Castillo", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(16)) { Id = nextIdPrestamo++ });



        ActualizarDataGridViews();
    }

    private void ActualizarDataGridViews()
    {
        ActualizarDataGridViewLibros();
        ActualizarDataGridViewUsuarios();
        ActualizarDataGridViewPrestamos();
    }

    private void ActualizarDataGridViewLibros()
    {
        dataGridViewLibros.Rows.Clear();
        foreach (var libro in libros.OrderBy(l => l.Id))
        {
            dataGridViewLibros.Rows.Add(libro.Id, libro.Titulo, libro.Autor, libro.Anio);
        }
    }

    private void ActualizarDataGridViewUsuarios()
    {
        dataGridViewUsuarios.Rows.Clear();
        foreach (var usuario in usuarios.OrderBy(u => u.Id))
        {
            dataGridViewUsuarios.Rows.Add(usuario.Id, usuario.FullName, usuario.Correo);
        }
    }

    private void ActualizarDataGridViewPrestamos()
    {
        ActualizarDataGridViewPrestamos(-1);
    }

    private void ActualizarDataGridViewPrestamos(int idUsuarioFiltro)
    {
        dataGridViewPrestamos.Rows.Clear();
        var prestamosFiltrados = idUsuarioFiltro == -1 
            ? prestamos.OrderBy(p => p.Id) 
            : prestamos.Where(p => p.IdUsuario == idUsuarioFiltro).OrderBy(p => p.Id);
        
        foreach (var prestamo in prestamosFiltrados)
        {
            dataGridViewPrestamos.Rows.Add(prestamo.Id, prestamo.NombreLibro, prestamo.FechaPrestamo.ToShortDateString(), prestamo.FechaDevolucion.ToShortDateString());
        }
    }

    private void ActualizarComboBoxes()
    {
        comboBoxUsuarios.DataSource = null;
        var usuariosConTodos = new List<clsUsuarios> { new clsUsuarios("Todos los préstamos", "todas@todas.com") { Id = -1 } };
        usuariosConTodos.AddRange(usuarios);
        comboBoxUsuarios.DataSource = usuariosConTodos;
        comboBoxUsuarios.DisplayMember = "FullName";
        comboBoxUsuarios.ValueMember = "Id";
        comboBoxUsuarios.SelectedIndex = 0;

        comboBoxPrestamoUsuario.DataSource = null;
        var usuariosConDefault = new List<clsUsuarios> { new clsUsuarios("", "") { Id = -1 } };
        usuariosConDefault.AddRange(usuarios);
        comboBoxPrestamoUsuario.DataSource = usuariosConDefault;
        comboBoxPrestamoUsuario.DisplayMember = "FullName";
        comboBoxPrestamoUsuario.ValueMember = "Id";
        comboBoxPrestamoUsuario.SelectedIndex = 0;

        comboBoxPrestamoLibro.DataSource = null;
        var librosConDefault = new List<clsLibros> { new clsLibros("", "", "") { Id = -1 } };
        librosConDefault.AddRange(libros);
        comboBoxPrestamoLibro.DataSource = librosConDefault;
        comboBoxPrestamoLibro.DisplayMember = "Titulo";
        comboBoxPrestamoLibro.ValueMember = "Id";
        comboBoxPrestamoLibro.SelectedIndex = 0;
    }

    // ========== LIBROS ==========
    private void BtnAgregar_Click(object? sender, EventArgs e)
    {
        idLibroEnEdicion = -1;
        LimpiarInputsLibros();
        MostrarInputsLibros();
    }

    private void BtnEditar_Click(object? sender, EventArgs e)
    {
        if (dataGridViewLibros.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un libro para editar", "Advertencia");
            return;
        }

        int indexSeleccionado = dataGridViewLibros.SelectedRows[0].Index;
        int idLibro = (int)dataGridViewLibros.Rows[indexSeleccionado].Cells["ID"].Value;
        var libro = libros.FirstOrDefault(l => l.Id == idLibro);

        if (libro == null)
        {
            MessageBox.Show("Libro no encontrado", "Error");
            return;
        }

        idLibroEnEdicion = libro.Id;
        textBoxLibroTitulo.Text = libro.Titulo;
        textBoxLibroAutor.Text = libro.Autor;
        textBoxLibroAño.Text = libro.Anio;
        MostrarInputsLibros();
    }

    private void BtnEliminar_Click(object? sender, EventArgs e)
    {
        if (dataGridViewLibros.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un libro para eliminar", "Advertencia");
            return;
        }

        if (MessageBox.Show("¿Está seguro de que desea eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            int indexSeleccionado = dataGridViewLibros.SelectedRows[0].Index;
            int idLibro = (int)dataGridViewLibros.Rows[indexSeleccionado].Cells["ID"].Value;
            libros.RemoveAll(l => l.Id == idLibro);
            ActualizarDataGridViewLibros();
            MessageBox.Show("Libro eliminado exitosamente", "Éxito");
        }
    }

    private void BtnGuardarLibro_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxLibroTitulo.Text) || 
            string.IsNullOrWhiteSpace(textBoxLibroAutor.Text) || 
            string.IsNullOrWhiteSpace(textBoxLibroAño.Text))
        {
            MessageBox.Show("Complete todos los campos e intente de nuevo", "Error");
            return;
        }

        if (idLibroEnEdicion == -1)
        {
            var nuevoLibro = new clsLibros(textBoxLibroTitulo.Text, textBoxLibroAutor.Text, textBoxLibroAño.Text);
            nuevoLibro.Id = nextIdLibro++;
            libros.Add(nuevoLibro);
            MessageBox.Show("Libro agregado exitosamente", "Éxito");
        }
        else
        {
            var libro = libros.FirstOrDefault(l => l.Id == idLibroEnEdicion);
            if (libro != null)
            {
                libro.Titulo = textBoxLibroTitulo.Text;
                libro.Autor = textBoxLibroAutor.Text;
                libro.Anio = textBoxLibroAño.Text;
                MessageBox.Show("Libro editado exitosamente", "Éxito");
            }
        }

        OcultarInputsLibros();
        ActualizarDataGridViewLibros();
        ActualizarComboBoxes();
    }

    private void MostrarInputsLibros()
    {
        labelLibroTitulo.Visible = true;
        textBoxLibroTitulo.Visible = true;
        labelLibroAutor.Visible = true;
        textBoxLibroAutor.Visible = true;
        labelLibroAño.Visible = true;
        textBoxLibroAño.Visible = true;
        btnGuardarLibro.Visible = true;
    }

    private void OcultarInputsLibros()
    {
        labelLibroTitulo.Visible = false;
        textBoxLibroTitulo.Visible = false;
        labelLibroAutor.Visible = false;
        textBoxLibroAutor.Visible = false;
        labelLibroAño.Visible = false;
        textBoxLibroAño.Visible = false;
        btnGuardarLibro.Visible = false;
    }

    private void LimpiarInputsLibros()
    {
        textBoxLibroTitulo.Text = string.Empty;
        textBoxLibroAutor.Text = string.Empty;
        textBoxLibroAño.Text = string.Empty;
    }

    // ========== USUARIOS ==========
    private void BtnAgregarUsuario_Click(object? sender, EventArgs e)
    {
        idUsuarioEnEdicion = -1;
        LimpiarInputsUsuarios();
        MostrarInputsUsuarios();
    }

    private void BtnEditarUsuario_Click(object? sender, EventArgs e)
    {
        if (dataGridViewUsuarios.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un usuario para editar", "Advertencia");
            return;
        }

        int indexSeleccionado = dataGridViewUsuarios.SelectedRows[0].Index;
        int idUsuario = (int)dataGridViewUsuarios.Rows[indexSeleccionado].Cells["ID"].Value;
        var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);

        if (usuario == null)
        {
            MessageBox.Show("Usuario no encontrado", "Error");
            return;
        }

        idUsuarioEnEdicion = usuario.Id;
        textBoxUsuarioNombre.Text = usuario.FullName;
        textBoxUsuarioCorreo.Text = usuario.Correo;
        MostrarInputsUsuarios();
    }

    private void BtnEliminarUsuario_Click(object? sender, EventArgs e)
    {
        if (dataGridViewUsuarios.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un usuario para eliminar", "Advertencia");
            return;
        }

        if (MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            int indexSeleccionado = dataGridViewUsuarios.SelectedRows[0].Index;
            int idUsuario = (int)dataGridViewUsuarios.Rows[indexSeleccionado].Cells["ID"].Value;
            usuarios.RemoveAll(u => u.Id == idUsuario);
            prestamos.RemoveAll(p => p.IdUsuario == idUsuario);
            ActualizarDataGridViewUsuarios();
            ActualizarDataGridViewPrestamos();
            ActualizarComboBoxes();
            MessageBox.Show("Usuario eliminado exitosamente", "Éxito");
        }
    }

    private void BtnGuardarUsuario_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxUsuarioNombre.Text) || 
            string.IsNullOrWhiteSpace(textBoxUsuarioCorreo.Text))
        {
            MessageBox.Show("Complete todos los campos e intente de nuevo", "Error");
            return;
        }

        if (idUsuarioEnEdicion == -1)
        {
            var nuevoUsuario = new clsUsuarios(textBoxUsuarioNombre.Text, textBoxUsuarioCorreo.Text);
            nuevoUsuario.Id = nextIdUsuario++;
            usuarios.Add(nuevoUsuario);
            MessageBox.Show("Usuario agregado exitosamente", "Éxito");
        }
        else
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuarioEnEdicion);
            if (usuario != null)
            {
                usuario.FullName = textBoxUsuarioNombre.Text;
                usuario.Correo = textBoxUsuarioCorreo.Text;
                MessageBox.Show("Usuario editado exitosamente", "Éxito");
            }
        }

        OcultarInputsUsuarios();
        ActualizarDataGridViewUsuarios();
        ActualizarComboBoxes();
    }

    private void MostrarInputsUsuarios()
    {
        labelUsuarioNombre.Visible = true;
        textBoxUsuarioNombre.Visible = true;
        labelUsuarioCorreo.Visible = true;
        textBoxUsuarioCorreo.Visible = true;
        btnGuardarUsuario.Visible = true;
    }

    private void OcultarInputsUsuarios()
    {
        labelUsuarioNombre.Visible = false;
        textBoxUsuarioNombre.Visible = false;
        labelUsuarioCorreo.Visible = false;
        textBoxUsuarioCorreo.Visible = false;
        btnGuardarUsuario.Visible = false;
    }

    private void LimpiarInputsUsuarios()
    {
        textBoxUsuarioNombre.Text = string.Empty;
        textBoxUsuarioCorreo.Text = string.Empty;
    }

    // ========== PRÉSTAMOS ==========
    private void BtnAgregarPrestamo_Click(object? sender, EventArgs e)
    {
        idPrestamoEnEdicion = -1;
        LimpiarInputsPrestamos();
        MostrarInputsPrestamos();
    }

    private void BtnEditarPrestamo_Click(object? sender, EventArgs e)
    {
        if (dataGridViewPrestamos.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un préstamo para editar", "Advertencia");
            return;
        }

        int indexSeleccionado = dataGridViewPrestamos.SelectedRows[0].Index;
        int idPrestamo = (int)dataGridViewPrestamos.Rows[indexSeleccionado].Cells["ID"].Value;
        var prestamo = prestamos.FirstOrDefault(p => p.Id == idPrestamo);

        if (prestamo == null)
        {
            MessageBox.Show("Préstamo no encontrado", "Error");
            return;
        }

        idPrestamoEnEdicion = prestamo.Id;
        comboBoxPrestamoUsuario.SelectedValue = prestamo.IdUsuario;
        comboBoxPrestamoLibro.SelectedValue = prestamo.IdLibro;
        dateTimePickerPrestamoFechaPrestamo.Value = prestamo.FechaPrestamo;
        dateTimePickerPrestamoFechaDevolucion.Value = prestamo.FechaDevolucion;
        MostrarInputsPrestamos();
    }

    private void BtnEliminarPrestamo_Click(object? sender, EventArgs e)
    {
        LimpiarInputsPrestamos();
        if (dataGridViewPrestamos.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un préstamo para eliminar", "Advertencia");
            return;
        }

        if (MessageBox.Show("¿Está seguro de que desea eliminar este préstamo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            int indexSeleccionado = dataGridViewPrestamos.SelectedRows[0].Index;
            int idPrestamo = (int)dataGridViewPrestamos.Rows[indexSeleccionado].Cells["ID"].Value;
            prestamos.RemoveAll(p => p.Id == idPrestamo);
            ActualizarDataGridViewPrestamos();
            MessageBox.Show("Préstamo eliminado exitosamente", "Éxito");
        }
    }

    private void BtnGuardarPrestamo_Click(object? sender, EventArgs e)
    {
        int idUsuario = (int)(comboBoxPrestamoUsuario.SelectedValue ?? -1);
        int idLibro = (int)(comboBoxPrestamoLibro.SelectedValue ?? -1);

        if (idUsuario == -1 || idLibro == -1)
        {
            MessageBox.Show("Seleccione un usuario y un libro", "Error");
            return;
        }

        var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);
        var libro = libros.FirstOrDefault(l => l.Id == idLibro);

        if (usuario == null || libro == null)
        {
            MessageBox.Show("Usuario o libro no encontrado", "Error");
            return;
        }

        if (idPrestamoEnEdicion == -1)
        {
            var nuevoPrestamo = new clsPrestamos(idLibro, idUsuario, libro.Titulo, usuario.FullName,
                dateTimePickerPrestamoFechaPrestamo.Value, dateTimePickerPrestamoFechaDevolucion.Value);
            nuevoPrestamo.Id = nextIdPrestamo++;
            prestamos.Add(nuevoPrestamo);
            MessageBox.Show("Préstamo agregado exitosamente", "Éxito");
        }
        else
        {
            var prestamo = prestamos.FirstOrDefault(p => p.Id == idPrestamoEnEdicion);
            if (prestamo != null)
            {
                prestamo.IdLibro = idLibro;
                prestamo.IdUsuario = idUsuario;
                prestamo.NombreLibro = libro.Titulo;
                prestamo.NombreUsuario = usuario.FullName;
                prestamo.FechaPrestamo = dateTimePickerPrestamoFechaPrestamo.Value;
                prestamo.FechaDevolucion = dateTimePickerPrestamoFechaDevolucion.Value;
                MessageBox.Show("Préstamo editado exitosamente", "Éxito");
            }
        }

        OcultarInputsPrestamos();
        ActualizarDataGridViewPrestamos();
    }

    private void MostrarInputsPrestamos()
    {
        labelPrestamoUsuario.Visible = true;
        comboBoxPrestamoUsuario.Visible = true;
        labelPrestamoLibro.Visible = true;
        comboBoxPrestamoLibro.Visible = true;
        labelPrestamoFechaPrestamo.Visible = true;
        dateTimePickerPrestamoFechaPrestamo.Visible = true;
        labelPrestamoFechaDevolucion.Visible = true;
        dateTimePickerPrestamoFechaDevolucion.Visible = true;
        btnGuardarPrestamo.Visible = true;
    }

    private void OcultarInputsPrestamos()
    {
        labelPrestamoUsuario.Visible = false;
        comboBoxPrestamoUsuario.Visible = false;
        labelPrestamoLibro.Visible = false;
        comboBoxPrestamoLibro.Visible = false;
        labelPrestamoFechaPrestamo.Visible = false;
        dateTimePickerPrestamoFechaPrestamo.Visible = false;
        labelPrestamoFechaDevolucion.Visible = false;
        dateTimePickerPrestamoFechaDevolucion.Visible = false;
        btnGuardarPrestamo.Visible = false;
    }

    private void LimpiarInputsPrestamos()
    {
        comboBoxPrestamoUsuario.SelectedIndex = 0;
        comboBoxPrestamoLibro.SelectedIndex = 0;
        dateTimePickerPrestamoFechaPrestamo.Value = DateTime.Now;
        dateTimePickerPrestamoFechaDevolucion.Value = DateTime.Now.AddDays(14);
    }

    private void ComboBoxUsuarios_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (comboBoxUsuarios.SelectedValue is int idUsuario)
        {
            ActualizarDataGridViewPrestamos(idUsuario);
        }
    }
}
