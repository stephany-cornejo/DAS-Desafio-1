namespace DesafioDas;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // TabControl
    private TabControl tabControlMain;
    private TabPage tabPageLibros;
    private TabPage tabPageUsuarios;

    // Libros Tab Controls
    private DataGridView dataGridViewLibros;
    private Label labelID;
    private TextBox textBoxID;
    private Label labelTitulo;
    private TextBox textBoxTitulo;
    private Label labelAutor;
    private TextBox textBoxAutor;
    private Label labelAño;
    private TextBox textBoxAño;
    private Button btnAgregar;
    private Button btnEditar;
    private Button btnEliminar;
    
    // Usuarios Tab Controls
    private Label labelTituloUsuarios;
    private DataGridView dataGridViewUsuarios;
    private Button btnAgregarUsuario;
    private Button btnEditarUsuario;
    private Button btnEliminarUsuario;

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
        
        // Main TabControl
        this.tabControlMain = new TabControl();
        this.tabPageLibros = new TabPage();
        
        // Tab: Libros
        this.tabControlMain.Controls.Add(this.tabPageLibros);
        this.tabPageLibros.Text = "Libros";
        this.tabPageLibros.BackColor = System.Drawing.SystemColors.Control;
        
        // Tab: Usuarios
        this.tabPageUsuarios = new TabPage();
        this.tabControlMain.Controls.Add(this.tabPageUsuarios);
        this.tabPageUsuarios.Text = "Usuarios";
        this.tabPageUsuarios.BackColor = System.Drawing.SystemColors.Control;
        
        // DataGridView
        this.dataGridViewLibros = new DataGridView();
        this.dataGridViewLibros.Location = new System.Drawing.Point(12, 12);
        this.dataGridViewLibros.Size = new System.Drawing.Size(760, 250);
        this.dataGridViewLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        this.dataGridViewLibros.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        this.dataGridViewLibros.BorderStyle = BorderStyle.Fixed3D;
        this.tabPageLibros.Controls.Add(this.dataGridViewLibros);
        
        // Input Panel for Books
        int panelY = 270;
        int panelX = 12;
        int labelWidth = 130;
        int inputWidth = 200;
        int spacing = 35;
        int columnSpacing = 400;
        
        // Row 1: ID and Titulo
        this.labelID = CreateLabel("ID:", panelX, panelY, labelWidth);
        this.textBoxID = CreateTextBox(panelX + labelWidth, panelY, inputWidth);
        this.textBoxID.ReadOnly = true;
        this.labelTitulo = CreateLabel("Título:", panelX + columnSpacing, panelY, labelWidth);
        this.textBoxTitulo = CreateTextBox(panelX + columnSpacing + labelWidth, panelY, inputWidth);
        
        this.tabPageLibros.Controls.Add(this.labelID);
        this.tabPageLibros.Controls.Add(this.textBoxID);
        this.tabPageLibros.Controls.Add(this.labelTitulo);
        this.tabPageLibros.Controls.Add(this.textBoxTitulo);
        
        // Row 2: Autor and Año
        panelY += spacing;
        this.labelAutor = CreateLabel("Autor:", panelX, panelY, labelWidth);
        this.textBoxAutor = CreateTextBox(panelX + labelWidth, panelY, inputWidth);
        this.labelAño = CreateLabel("Año:", panelX + columnSpacing, panelY, labelWidth);
        this.textBoxAño = CreateTextBox(panelX + columnSpacing + labelWidth, panelY, inputWidth / 2);
        
        this.tabPageLibros.Controls.Add(this.labelAutor);
        this.tabPageLibros.Controls.Add(this.textBoxAutor);
        this.tabPageLibros.Controls.Add(this.labelAño);
        this.tabPageLibros.Controls.Add(this.textBoxAño);
        
        // Buttons
        panelY += spacing + 10;
        int btnWidth = 90;
        int btnHeight = 30;
        int btnSpacing = 100;
        
        this.btnAgregar = CreateButton("Agregar", panelX, panelY, btnWidth, btnHeight);
        this.btnEditar = CreateButton("Editar", panelX + btnSpacing, panelY, btnWidth, btnHeight);
        this.btnEliminar = CreateButton("Eliminar", panelX + btnSpacing * 2, panelY, btnWidth, btnHeight);
        
        this.tabPageLibros.Controls.Add(this.btnAgregar);
        this.tabPageLibros.Controls.Add(this.btnEditar);
        this.tabPageLibros.Controls.Add(this.btnEliminar);
        
        // ========== USUARIOS TAB ==========
        int usuariosPanelX = 12;
        int usuariosPanelY = 12;
        
        // Title Label
        this.labelTituloUsuarios = new Label();
        this.labelTituloUsuarios.Text = "Administrar usuarios";
        this.labelTituloUsuarios.Location = new System.Drawing.Point(usuariosPanelX, usuariosPanelY);
        this.labelTituloUsuarios.Size = new System.Drawing.Size(400, 25);
        this.labelTituloUsuarios.Font = new System.Drawing.Font(this.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
        this.tabPageUsuarios.Controls.Add(this.labelTituloUsuarios);
        
        // DataGridView for Usuarios
        usuariosPanelY += 35;
        this.dataGridViewUsuarios = new DataGridView();
        this.dataGridViewUsuarios.Location = new System.Drawing.Point(usuariosPanelX, usuariosPanelY);
        this.dataGridViewUsuarios.Size = new System.Drawing.Size(500, 200);
        this.dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        this.dataGridViewUsuarios.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        this.dataGridViewUsuarios.BorderStyle = BorderStyle.Fixed3D;
        this.dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.tabPageUsuarios.Controls.Add(this.dataGridViewUsuarios);
        
        // Buttons for Usuarios
        usuariosPanelY += 210;
        this.btnAgregarUsuario = CreateButton("Agregar", usuariosPanelX, usuariosPanelY, btnWidth, btnHeight);
        this.btnEditarUsuario = CreateButton("Editar", usuariosPanelX + btnSpacing, usuariosPanelY, btnWidth, btnHeight);
        this.btnEliminarUsuario = CreateButton("Eliminar", usuariosPanelX + btnSpacing * 2, usuariosPanelY, btnWidth, btnHeight);
        
        this.tabPageUsuarios.Controls.Add(this.btnAgregarUsuario);
        this.tabPageUsuarios.Controls.Add(this.btnEditarUsuario);
        this.tabPageUsuarios.Controls.Add(this.btnEliminarUsuario);
        
        // Form properties
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 500);
        this.Text = "Sistema de Gestión de Biblioteca";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Controls.Add(this.tabControlMain);
        this.tabControlMain.Dock = DockStyle.Fill;
    }
    
    // Helper methods
    private Label CreateLabel(string text, int x, int y, int width)
    {
        Label label = new Label();
        label.Text = text;
        label.Location = new System.Drawing.Point(x, y);
        label.Size = new System.Drawing.Size(width, 25);
        label.AutoSize = false;
        label.TextAlign = ContentAlignment.MiddleRight;
        return label;
    }
    
    private TextBox CreateTextBox(int x, int y, int width)
    {
        TextBox textBox = new TextBox();
        textBox.Location = new System.Drawing.Point(x, y);
        textBox.Size = new System.Drawing.Size(width, 25);
        return textBox;
    }
    
    private Button CreateButton(string text, int x, int y, int width, int height)
    {
        Button button = new Button();
        button.Text = text;
        button.Location = new System.Drawing.Point(x, y);
        button.Size = new System.Drawing.Size(width, height);
        button.UseVisualStyleBackColor = true;
        return button;
    }

    #endregion
}
