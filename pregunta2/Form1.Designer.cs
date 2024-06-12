namespace pregunta2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nav_bar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom_img_label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lsImgs = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.nom_img = new System.Windows.Forms.Label();
            this.btn_guardar_color = new System.Windows.Forms.Button();
            this.textBoxNom_color = new System.Windows.Forms.TextBox();
            this.paleta_color = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxG1 = new System.Windows.Forms.TextBox();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_c_hex = new System.Windows.Forms.TextBox();
            this.escoge_color = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cargar_imagen = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vista_prev1 = new System.Windows.Forms.Button();
            this.panel_vista_img_color = new System.Windows.Forms.Panel();
            this.view_prev_img = new System.Windows.Forms.Button();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.textBoxG2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.nav_bar.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.75F));
            this.tableLayoutPanel1.Controls.Add(this.nav_bar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_contenedor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nav_bar
            // 
            this.nav_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nav_bar.Controls.Add(this.button2);
            this.nav_bar.Controls.Add(this.button1);
            this.nav_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nav_bar.Location = new System.Drawing.Point(3, 3);
            this.nav_bar.Name = "nav_bar";
            this.nav_bar.Size = new System.Drawing.Size(156, 444);
            this.nav_bar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Controls.Add(this.panel2);
            this.panel_contenedor.Controls.Add(this.panel1);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(165, 3);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(632, 444);
            this.panel_contenedor.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.nom_img_label);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.lsImgs);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 415);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 316);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 82);
            this.listBox1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(488, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(132, 362);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // nom_img_label
            // 
            this.nom_img_label.AutoSize = true;
            this.nom_img_label.Location = new System.Drawing.Point(125, 19);
            this.nom_img_label.Name = "nom_img_label";
            this.nom_img_label.Size = new System.Drawing.Size(81, 13);
            this.nom_img_label.TabIndex = 12;
            this.nom_img_label.Text = "Nombre imagen";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cargar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lsImgs
            // 
            this.lsImgs.FormattingEnabled = true;
            this.lsImgs.Location = new System.Drawing.Point(14, 316);
            this.lsImgs.Name = "lsImgs";
            this.lsImgs.Size = new System.Drawing.Size(270, 56);
            this.lsImgs.TabIndex = 10;
            this.lsImgs.SelectedIndexChanged += new System.EventHandler(this.lsImgs_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(13, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(469, 265);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ver Texturas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nom_img);
            this.panel1.Controls.Add(this.btn_guardar_color);
            this.panel1.Controls.Add(this.textBoxNom_color);
            this.panel1.Controls.Add(this.paleta_color);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxR1);
            this.panel1.Controls.Add(this.textBoxG1);
            this.panel1.Controls.Add(this.textBoxB1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_c_hex);
            this.panel1.Controls.Add(this.escoge_color);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cargar_imagen);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 417);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Nombre del color";
            // 
            // nom_img
            // 
            this.nom_img.AutoSize = true;
            this.nom_img.Location = new System.Drawing.Point(120, 33);
            this.nom_img.Name = "nom_img";
            this.nom_img.Size = new System.Drawing.Size(97, 13);
            this.nom_img.TabIndex = 59;
            this.nom_img.Text = "Nombre de archivo";
            // 
            // btn_guardar_color
            // 
            this.btn_guardar_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_guardar_color.Location = new System.Drawing.Point(10, 323);
            this.btn_guardar_color.Name = "btn_guardar_color";
            this.btn_guardar_color.Size = new System.Drawing.Size(104, 34);
            this.btn_guardar_color.TabIndex = 58;
            this.btn_guardar_color.Text = "Guardar color";
            this.btn_guardar_color.UseVisualStyleBackColor = true;
            this.btn_guardar_color.Click += new System.EventHandler(this.btn_guardar_color_Click);
            // 
            // textBoxNom_color
            // 
            this.textBoxNom_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNom_color.Location = new System.Drawing.Point(11, 297);
            this.textBoxNom_color.Name = "textBoxNom_color";
            this.textBoxNom_color.Size = new System.Drawing.Size(103, 20);
            this.textBoxNom_color.TabIndex = 56;
            // 
            // paleta_color
            // 
            this.paleta_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paleta_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paleta_color.Location = new System.Drawing.Point(14, 233);
            this.paleta_color.Name = "paleta_color";
            this.paleta_color.Size = new System.Drawing.Size(104, 33);
            this.paleta_color.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "B:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "G:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "R:";
            // 
            // textBoxR1
            // 
            this.textBoxR1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxR1.Location = new System.Drawing.Point(34, 155);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(83, 20);
            this.textBoxR1.TabIndex = 51;
            // 
            // textBoxG1
            // 
            this.textBoxG1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxG1.Location = new System.Drawing.Point(34, 181);
            this.textBoxG1.Name = "textBoxG1";
            this.textBoxG1.Size = new System.Drawing.Size(83, 20);
            this.textBoxG1.TabIndex = 50;
            // 
            // textBoxB1
            // 
            this.textBoxB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxB1.Location = new System.Drawing.Point(34, 207);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(83, 20);
            this.textBoxB1.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "HEX:";
            // 
            // textBox_c_hex
            // 
            this.textBox_c_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_c_hex.Location = new System.Drawing.Point(48, 129);
            this.textBox_c_hex.Name = "textBox_c_hex";
            this.textBox_c_hex.Size = new System.Drawing.Size(69, 20);
            this.textBox_c_hex.TabIndex = 47;
            // 
            // escoge_color
            // 
            this.escoge_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.escoge_color.Location = new System.Drawing.Point(14, 89);
            this.escoge_color.Name = "escoge_color";
            this.escoge_color.Size = new System.Drawing.Size(104, 34);
            this.escoge_color.TabIndex = 46;
            this.escoge_color.Text = "Escoger Color";
            this.escoge_color.UseVisualStyleBackColor = true;
            this.escoge_color.Click += new System.EventHandler(this.escoge_color_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(123, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 326);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // cargar_imagen
            // 
            this.cargar_imagen.Location = new System.Drawing.Point(14, 49);
            this.cargar_imagen.Name = "cargar_imagen";
            this.cargar_imagen.Size = new System.Drawing.Size(104, 34);
            this.cargar_imagen.TabIndex = 44;
            this.cargar_imagen.Text = "Cargar Imagen";
            this.cargar_imagen.UseVisualStyleBackColor = true;
            this.cargar_imagen.Click += new System.EventHandler(this.cargar_imagen_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(632, 30);
            this.panel5.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Texturas";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.vista_prev1);
            this.panel4.Controls.Add(this.panel_vista_img_color);
            this.panel4.Controls.Add(this.view_prev_img);
            this.panel4.Controls.Add(this.textBoxB2);
            this.panel4.Controls.Add(this.textBoxG2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBoxR2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 36);
            this.panel4.TabIndex = 27;
            // 
            // vista_prev1
            // 
            this.vista_prev1.Location = new System.Drawing.Point(435, 4);
            this.vista_prev1.Name = "vista_prev1";
            this.vista_prev1.Size = new System.Drawing.Size(90, 23);
            this.vista_prev1.TabIndex = 34;
            this.vista_prev1.Text = "Vista previa 1";
            this.vista_prev1.UseVisualStyleBackColor = true;
            this.vista_prev1.Click += new System.EventHandler(this.vista_prev1_Click);
            // 
            // panel_vista_img_color
            // 
            this.panel_vista_img_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_vista_img_color.Location = new System.Drawing.Point(344, 5);
            this.panel_vista_img_color.Name = "panel_vista_img_color";
            this.panel_vista_img_color.Size = new System.Drawing.Size(64, 22);
            this.panel_vista_img_color.TabIndex = 33;
            // 
            // view_prev_img
            // 
            this.view_prev_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.view_prev_img.Location = new System.Drawing.Point(531, 3);
            this.view_prev_img.Name = "view_prev_img";
            this.view_prev_img.Size = new System.Drawing.Size(89, 24);
            this.view_prev_img.TabIndex = 32;
            this.view_prev_img.Text = "Vista previa 2";
            this.view_prev_img.UseVisualStyleBackColor = true;
            this.view_prev_img.Click += new System.EventHandler(this.view_prev_img_Click);
            // 
            // textBoxB2
            // 
            this.textBoxB2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxB2.Location = new System.Drawing.Point(290, 6);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(48, 20);
            this.textBoxB2.TabIndex = 31;
            // 
            // textBoxG2
            // 
            this.textBoxG2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxG2.Location = new System.Drawing.Point(214, 6);
            this.textBoxG2.Name = "textBoxG2";
            this.textBoxG2.Size = new System.Drawing.Size(48, 20);
            this.textBoxG2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "R";
            // 
            // textBoxR2
            // 
            this.textBoxR2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxR2.Location = new System.Drawing.Point(140, 6);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(48, 20);
            this.textBoxR2.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.nav_bar.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel nav_bar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_vista_img_color;
        private System.Windows.Forms.Button view_prev_img;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.TextBox textBoxG2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label nom_img;
        private System.Windows.Forms.Button btn_guardar_color;
        private System.Windows.Forms.TextBox textBoxNom_color;
        private System.Windows.Forms.Panel paleta_color;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxG1;
        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_c_hex;
        private System.Windows.Forms.Button escoge_color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cargar_imagen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lsImgs;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label nom_img_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button vista_prev1;
    }
}

