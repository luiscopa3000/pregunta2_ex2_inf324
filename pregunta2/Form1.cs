using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pregunta2
{
    public partial class Form1 : Form
    {

        // Declaración de objetos para conexión y adaptador de datos
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataSet ds = new DataSet();
        Bitmap img_temp = null;


        int cR, cG, cB;
        int cmR, cmG, cmB;

        bool sw_click = false;
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "server=(local);user=sa;pwd=12345678;database=DBLuisImagen";

            panel1.Enabled = true;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;

            panel2.Enabled = false;
            panel2.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Enabled = true;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;

            panel2.Enabled = false;
            panel2.Visible = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {

            panel2.Enabled = true;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;

            panel1.Enabled = false;
            panel1.Visible = false;

            listar_img();
            listar_texturas();

        }


        private void cargar_imagen_Click(object sender, EventArgs e)
        {
            sw_click = false;
            // Configurar el filtro para el OpenFileDialog
            openFileDialog1.Filter = "Todos los archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nom_img.Text = Path.GetFileName(openFileDialog1.FileName);
                // Cargar la imagen seleccionada en un Bitmap
                Bitmap originalBmp = new Bitmap(openFileDialog1.FileName);

                // Redimensionar la imagen para que tenga el mismo tamaño que el PictureBox
                Bitmap resizedBmp = redimencionar(originalBmp, pictureBox1); ;

                // Mostrar la imagen redimensionada en el PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = resizedBmp;
                img_temp = resizedBmp;
            }

        }
        private void vista_prev1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (textBoxR1.Text != "" && textBoxG1.Text != "" && textBoxB1.Text != "")
                {
                    if (sw_click)
                    {
                        pictureBox1.Image = img_temp;
                        algoritmo_pintado1(textBoxR1.Text, textBoxG1.Text, textBoxB1.Text, pictureBox1);
                    }
                    else
                    {
                        MessageBox.Show($"Haz clic sobre una seccion de la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show($"Debe seleccionar el color a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Seleccione una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void view_prev_img_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (textBoxR1.Text != "" && textBoxG1.Text != "" && textBoxB1.Text != "")
                {
                    if (sw_click)
                    {
                        pictureBox1.Image = img_temp;
                        algoritmo_pintado2(textBoxR1.Text, textBoxG1.Text, textBoxB1.Text, pictureBox1);
                    }
                    else
                    {
                        MessageBox.Show($"Haz clic sobre una seccion de la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show($"Debe seleccionar el color a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Seleccione una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void escoge_color_Click(object sender, EventArgs e)
        {
            // Crear una instancia del ColorDialog
            ColorDialog colorDialog = new ColorDialog();

            // Mostrar el ColorDialog y verificar si el usuario seleccionó un color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener el color seleccionado
                Color color_seleccionado = colorDialog.Color;

                // Obtener los valores RGB
                int R = color_seleccionado.R;
                int G = color_seleccionado.G;
                int B = color_seleccionado.B;

                // Convertir el color a formato hexadecimal
                string hexColor = $"#{color_seleccionado.R:X2}{color_seleccionado.G:X2}{color_seleccionado.B:X2}";


                // Mostrar el color seleccionado y su valor hexadecimal
                //MessageBox.Show($"Color seleccionado: {hexColor}", "Color Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: cambiar el fondo del formulario al color seleccionado
                textBox_c_hex.Text = hexColor;
                textBoxR1.Text = R.ToString();
                textBoxG1.Text = G.ToString();
                textBoxB1.Text = B.ToString();
                paleta_color.BackColor = color_seleccionado;

            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            sw_click = true;
            
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();

            cmR = 0;
            cmG = 0;
            cmB = 0;
            for (int i = e.X; i < e.X + 10; i++)
            {
                for (int j = e.Y; j < e.Y + 10; j++)
                {
                    c = bmp.GetPixel(i, j);
                    cmR = cmR + c.R;
                    cmG = cmG + c.G;
                    cmB = cmB + c.B;

                }

            }

            cmR = cmR / 100;
            cmG = cmG / 100;
            cmB = cmB / 100;
            cR = cmR;
            cG = cmG;
            cB = cmB;

            c = Color.FromArgb(cmR, cmG, cmB);
            textBoxR2.Text = c.R.ToString();
            textBoxG2.Text = c.G.ToString();
            textBoxB2.Text = c.B.ToString();



            panel_vista_img_color.BackColor = c;


        }

        private void btn_guardar_color_Click(object sender, EventArgs e)
        {
            if (textBoxNom_color.Text != "")
            {
                if (obtener_img(nom_img.Text) == null)
                {
                    cargar_img_db();
                }
                cargar_textura_db();
                vaciaP1();
                MessageBox.Show($"Color Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"Ingresa el nombre con el que quieres guardar el color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_textura_db()
        {
            try
            {
                // Abre la conexión a la base de datos
                con.Open();

                // Prepara la consulta SQL para insertar datos
                string insertQuery = "INSERT INTO dbo.textura (nombre, r, g, b , hex, nom_color) VALUES (@nombre, @r, @g, @b , @hex, @nom_color)";

                SqlCommand comando = new SqlCommand(insertQuery, con);

                comando.Parameters.AddWithValue("@nombre", nom_img.Text);
                comando.Parameters.AddWithValue("@r", textBoxR2.Text);
                comando.Parameters.AddWithValue("@g", textBoxG2.Text);
                comando.Parameters.AddWithValue("@b", textBoxB2.Text);
                comando.Parameters.AddWithValue("@hex", textBox_c_hex.Text);
                comando.Parameters.AddWithValue("@nom_color", textBoxNom_color.Text);

                // Ejecuta la consulta
                int filasAfectadas = comando.ExecuteNonQuery();

                // Verifica si la inserción fue exitosa
                if (filasAfectadas == 0)
                {
                    MessageBox.Show("No se pudieron insertar los datos en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void cargar_img_db()
        {
            try
            {
                // Abre la conexión a la base de datos
                con.Open();

                // Prepara la consulta SQL para insertar datos
                string insertQuery = "INSERT INTO dbo.imagen (data, nombre) VALUES (@data, @nombre)";

                SqlCommand comando = new SqlCommand(insertQuery, con);

                // Convierte la imagen en un arreglo de bytes
                byte[] datosImagen = ImageToByteArray(img_temp);

                comando.Parameters.AddWithValue("@data", datosImagen);
                comando.Parameters.AddWithValue("@nombre", nom_img.Text); // Asegúrate de obtener el texto del textBox

                // Ejecuta la consulta
                int filasAfectadas = comando.ExecuteNonQuery();

                // Verifica si la inserción fue exitosa
                if (filasAfectadas == 0)
                {
                    MessageBox.Show("No se pudieron insertar los datos en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private string obtener_img(string nombreImagen)
        {
            try
            {
                // Abre la conexión a la base de datos
                con.Open();

                // Prepara la consulta SQL para recuperar la imagen y el nombre por nombre
                string selectQuery = "SELECT data, nombre FROM dbo.imagen WHERE nombre = @nombre";

                SqlCommand comando = new SqlCommand(selectQuery, con);
                comando.Parameters.AddWithValue("@nombre", nombreImagen);

                // Ejecuta la consulta y obtiene los datos de la imagen y el nombre
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    // Lee los datos de la imagen y el nombre
                    byte[] datosImagen = (byte[])reader["data"];
                    string nombreImagenObtenida = reader["nombre"].ToString();

                    // Convierte los datos de imagen en un Bitmap
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(datosImagen))
                    {
                        System.Drawing.Bitmap imagen = new System.Drawing.Bitmap(ms);

                        // Redimensiona la imagen
                        imagen = redimencionar(imagen, pictureBox3);
                        pictureBox3.Image = imagen;
                    }
                    return nombreImagenObtenida;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen desde la base de datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return null;
        }

        private void listar_texturas()
        {
            try
            {
                DataTable dataTable = new DataTable();
                // Abre la conexión a la base de datos
                con.Open();
                dataGridView1.DataSource = null;
                // Prepara la consulta SQL para recuperar los nombres de las imágenes
                string selectQuery = "SELECT nom_color, hex, r, g, b FROM dbo.textura";

                SqlCommand comando = new SqlCommand(selectQuery, con);

                // Ejecuta la consulta y lee los nombres de las imágenes
                SqlDataReader reader = comando.ExecuteReader();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los nombres de las imágenes desde la base de datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }


        private void listar_img()
        {
            try
            {
                // Abre la conexión a la base de datos
                con.Open();
                lsImgs.Items.Clear();
                // Prepara la consulta SQL para recuperar los nombres de las imágenes
                string selectQuery = "SELECT * FROM dbo.imagen";

                SqlCommand comando = new SqlCommand(selectQuery, con);

                // Ejecuta la consulta y lee los nombres de las imágenes
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();
                    lsImgs.Items.Add(nombre);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los nombres de las imágenes desde la base de datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void lsImgs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsImgs.SelectedItem != null)
            {
                string selectedItem = lsImgs.SelectedItem.ToString();
                obtener_img(selectedItem);
                nom_img_label.Text = selectedItem;
                listBox1.Items.Clear();
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Verifica que no se haya hecho clic en el encabezado de la columna
            if (e.RowIndex >= 0 && pictureBox3.Image != null)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Obtiene el valor de la celda de la columna "nombre"
                listBox1.Items.Add(row.Cells["nom_color"].Value.ToString());
                string nombre = row.Cells["nom_color"].Value.ToString();
                cR = int.Parse(row.Cells["r"].Value.ToString());
                cG = int.Parse(row.Cells["g"].Value.ToString());
                cB = int.Parse(row.Cells["b"].Value.ToString());



                Color tmpColor = HexARgb(row.Cells["hex"].Value.ToString());

                algoritmo_pintado2(tmpColor.R.ToString(), tmpColor.G.ToString(), tmpColor.B.ToString(), pictureBox3);
            }
            else
            {
                MessageBox.Show($"Debe seleccionar una imagen primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            sw_click = false;
            // Configurar el filtro para el OpenFileDialog
            openFileDialog1.Filter = "Todos los archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nom_img.Text = Path.GetFileName(openFileDialog1.FileName);
                // Cargar la imagen seleccionada en un Bitmap
                Bitmap originalBmp = new Bitmap(openFileDialog1.FileName);
                img_temp = originalBmp;

                // Redimensionar la imagen para que tenga el mismo tamaño que el PictureBox
                Bitmap resizedBmp = redimencionar(originalBmp, pictureBox1); ;

                // Mostrar la imagen redimensionada en el PictureBox
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = resizedBmp;
            }

        }

        // Método para convertir una imagen a una matriz de bytes
        private byte[] ImageToByteArray(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Puedes cambiar el formato de la imagen según tus necesidades
                return ms.ToArray();
            }
        }


        private void algoritmo_pintado1(string pR, string pG, string pB, PictureBox picEntrada)
        {
            Bitmap bmp = new Bitmap(picEntrada.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int ciR, ciG, ciB;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    ciR = c.R;
                    ciG = c.G;
                    ciB = c.B;
                    if (((cR - 10 < ciR) && (ciR < cR + 10)) && ((cG - 10 < ciG) && (ciG < cG + 10)) && ((cB - 10 < ciB) && (ciB < cB + 10)))
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(int.Parse(pR), int.Parse(pG), int.Parse(pB)));


                    }
                    else
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }


                }
            }
            picEntrada.Image = bmp2;
        }

        private void algoritmo_pintado2(string pR, string pG, string pB, PictureBox picEntrada)
        {

            Bitmap bmp = new Bitmap(picEntrada.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();

            int sR, sG, sB;
            sR = 0; sG = 0; sB = 0;
            for (int i = 0; i < bmp.Width - 10; i += 10)
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    sR = 0; sG = 0; sB = 0;
                    for (int ip = i; ip < i + 10; ip++)
                        for (int jp = j; jp < j + 10; jp++)
                        {
                            c = bmp.GetPixel(ip, jp);
                            sR = sR + c.R;
                            sG = sG + c.G;
                            sB = sB + c.B;
                        }
                    sR = sR / 100;
                    sG = sG / 100;
                    sB = sB / 100;

                    if (((cR - 10 < sR) && (sR < cR + 10)) && ((cG - 10 < sG) && (sG < cG + 10)) && ((cB - 10 < sB) && (sB < cB + 10)))
                    {
                        for (int ip = i; ip < i + 10; ip++)
                            for (int jp = j; jp < j + 10; jp++)
                            {
                                bmp2.SetPixel(ip, jp, Color.FromArgb(int.Parse(pR), int.Parse(pG), int.Parse(pB)));
                            }

                    }
                    else
                    {
                        for (int ip = i; ip < i + 10; ip++)
                            for (int jp = j; jp < j + 10; jp++)
                            {
                                c = bmp.GetPixel(ip, jp);
                                bmp2.SetPixel(ip, jp, Color.FromArgb(c.R, c.G, c.B));
                            }

                    }


                }
            picEntrada.Image = bmp2;
        }

        private Bitmap redimencionar(Bitmap imagenes, PictureBox picBox) {

            // Cargar la imagen seleccionada en un Bitmap
            Bitmap originalBmp = imagenes;
            // Redimensionar la imagen para que tenga el mismo tamaño que el PictureBox
            Bitmap resizedBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(resizedBmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalBmp, 0, 0, picBox.Width, picBox.Height);
            }
            return resizedBmp;
        }

        public static Color HexARgb(string hex)
        {
            // Elimina el carácter '#' si está presente
            if (hex.StartsWith("#"))
            {
                hex = hex.Substring(1);
            }
            // Convertir los valores hexadecimales a enteros
            int r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            int g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            int b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            return Color.FromArgb(r, g, b);
        }

        public void vaciaP1() {
            textBox_c_hex.Text = "";
            textBoxR1.Text = "";
            textBoxG1.Text = "";
            textBoxB1.Text = "";
            textBoxNom_color.Text = "";
            textBoxR2.Text = "";
            textBoxG2.Text = "";
            textBoxB2.Text = "";
            sw_click = false;
            pictureBox1.Image = img_temp;

        }
    }
}
