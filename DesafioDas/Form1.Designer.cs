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
    private Label labelTituloLibros;
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
        this.dataGridViewLibros.Location = new System.Drawing.Point(12, 40);
        this.dataGridViewLibros.Size = new System.Drawing.Size(760, 200);
        this.dataGridViewLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewLibros.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
        this.dataGridViewLibros.BorderStyle = BorderStyle.Fixed3D;
        this.tabPageLibros.Controls.Add(this.dataGridViewLibros);
        
        // Title for Libros
        this.labelTituloLibros = new Label();
        this.labelTituloLibros.Text = "Administrar libros";
        this.labelTituloLibros.Location = new System.Drawing.Point(12, 12);
        this.labelTituloLibros.Size = new System.Drawing.Size(400, 25);
        this.labelTituloLibros.Font = new System.Drawing.Font(this.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);
        this.tabPageLibros.Controls.Add(this.labelTituloLibros);
        
        // Buttons for Libros
        int btnWidth = 90;
        int btnHeight = 30;
        int btnSpacing = 100;
        int librosButtonsY = 240 + 100;  // 100px distance from DataGridView
        
        this.btnAgregar = CreateButton("Agregar", 12, librosButtonsY, btnWidth, btnHeight);
        this.btnEditar = CreateButton("Editar", 12 + btnSpacing, librosButtonsY, btnWidth, btnHeight);
        this.btnEliminar = CreateButton("Eliminar", 12 + btnSpacing * 2, librosButtonsY, btnWidth, btnHeight);
        
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
