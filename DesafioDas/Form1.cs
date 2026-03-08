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
    }
    
    private void InitializeDataGridView()
    {
        dataGridViewLibros.Columns.Clear();
        dataGridViewLibros.Columns.Add("ID", "ID");
        dataGridViewLibros.Columns.Add("Titulo", "Título");
        dataGridViewLibros.Columns.Add("Autor", "Autor");
        dataGridViewLibros.Columns.Add("Año", "Año");
        dataGridViewLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
        dataGridViewUsuarios.Columns.Clear();
        dataGridViewUsuarios.Columns.Add("ID", "ID");
        dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");
        dataGridViewUsuarios.Columns.Add("CorreoElectronico", "Correo Electrónico");
        dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }
    
    private void BtnAgregar_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Modo agregar: Complete el formulario", "Agregar Libro");
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
        MessageBox.Show("Modo agregar usuario: Complete los datos", "Agregar Usuario");
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

}
