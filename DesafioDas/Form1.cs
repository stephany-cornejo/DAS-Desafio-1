namespace DesafioDas;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        SetupEventHandlers();
        InitializeDataGridView();
    }
    
    private void SetupEventHandlers()
    {
        btnAgregar.Click += BtnAgregar_Click;
        btnEditar.Click += BtnEditar_Click;
        btnEliminar.Click += BtnEliminar_Click;
        btnAgregarUsuario.Click += BtnAgregarUsuario_Click;
        btnEditarUsuario.Click += BtnEditarUsuario_Click;
        btnEliminarUsuario.Click += BtnEliminarUsuario_Click;
        btnAgregarPrestamo.Click += BtnAgregarPrestamo_Click;
        btnEditarPrestamo.Click += BtnEditarPrestamo_Click;
        btnEliminarPrestamo.Click += BtnEliminarPrestamo_Click;
    }
    
    private void InitializeDataGridView()
    {
        dataGridViewLibros.Columns.Clear();
        dataGridViewLibros.Columns.Add("ID", "ID");
        dataGridViewLibros.Columns.Add("Titulo", "Título");
        dataGridViewLibros.Columns.Add("Autor", "Autor");
        dataGridViewLibros.Columns.Add("Año", "Año");
        dataGridViewLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        // Adjust column widths - ID 40px
        dataGridViewLibros.Columns["ID"].Width = 40;
        dataGridViewLibros.Columns["Titulo"].Width = 150;
        dataGridViewLibros.Columns["Autor"].Width = 150;
        dataGridViewLibros.Columns["Año"].Width = 60;
        
        dataGridViewUsuarios.Columns.Clear();
        dataGridViewUsuarios.Columns.Add("ID", "ID");
        dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");
        dataGridViewUsuarios.Columns.Add("CorreoElectronico", "Correo Electrónico");
        dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        // Adjust column widths - ID 40px
        dataGridViewUsuarios.Columns["ID"].Width = 40;
        
        dataGridViewPrestamos.Columns.Clear();
        dataGridViewPrestamos.Columns.Add("ID", "ID");
        dataGridViewPrestamos.Columns.Add("Libro", "Libro");
        dataGridViewPrestamos.Columns.Add("FechaPrestamo", "Fecha-Préstamo");
        dataGridViewPrestamos.Columns.Add("FechaDevolucion", "Fecha-Devolución");
        dataGridViewPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        // Adjust column widths - ID 40px
        dataGridViewPrestamos.Columns["ID"].Width = 40;
    }
    
    private void BtnAgregar_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Complete el formulario e intentelo nuevamente", "Agregar Libro");
    }
    
    private void BtnEditar_Click(object? sender, EventArgs e)
    {
        if (dataGridViewLibros.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un libro para editar", "Advertencia");
            return;
        }
        // TODO: Implement edit logic
        MessageBox.Show("Funcionalidad de edición por implementar", "Editar Libro");
    }
    
    private void BtnEliminar_Click(object? sender, EventArgs e)
    {
        if (dataGridViewLibros.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un libro para eliminar", "Advertencia");
            return;
        }
        // TODO: Implement delete logic
        MessageBox.Show("Funcionalidad de eliminación por implementar", "Eliminar Libro");
    }
    
    // ========== USUARIOS EVENT HANDLERS ==========
    private void BtnAgregarUsuario_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Complete el formulario e intentelo nuevamente", "Agregar Usuario");
    }
    
    private void BtnEditarUsuario_Click(object? sender, EventArgs e)
    {
        if (dataGridViewUsuarios.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un usuario para editar", "Advertencia");
            return;
        }
        // TODO: Implement edit logic
        MessageBox.Show("Funcionalidad de edición por implementar", "Editar Usuario");
    }
    
    private void BtnEliminarUsuario_Click(object? sender, EventArgs e)
    {
        if (dataGridViewUsuarios.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un usuario para eliminar", "Advertencia");
            return;
        }
        // TODO: Implement delete logic
        MessageBox.Show("Funcionalidad de eliminación por implementar", "Eliminar Usuario");
    }
    
    // ========== PRÉSTAMOS EVENT HANDLERS ==========
    private void BtnAgregarPrestamo_Click(object? sender, EventArgs e)
    {
        if (comboBoxUsuarios.SelectedIndex == -1)
        {
            MessageBox.Show("Seleccione un usuario", "Advertencia");
            return;
        }
        MessageBox.Show("Complete los datos e intentelo nuevamente", "Agregar Préstamo");
    }
    
    private void BtnEditarPrestamo_Click(object? sender, EventArgs e)
    {
        if (dataGridViewPrestamos.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un préstamo para editar", "Advertencia");
            return;
        }
        // TODO: Implement edit logic
        MessageBox.Show("Funcionalidad de edición por implementar", "Editar Préstamo");
    }
    
    private void BtnEliminarPrestamo_Click(object? sender, EventArgs e)
    {
        if (dataGridViewPrestamos.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccione un préstamo para eliminar", "Advertencia");
            return;
        }
        // TODO: Implement delete logic
        MessageBox.Show("Funcionalidad de eliminación por implementar", "Eliminar Préstamo");
    }

}
