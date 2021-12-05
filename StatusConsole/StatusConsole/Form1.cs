using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace StatusConsole
{
    public partial class Form1 : Form
    {
        //Definiendo variables globales necesarias para arduino
        public SerialPort serialPort1;

        //Definiendo variables globales
        public double temperatura;
        public string nombre = string.Empty;

        public Form1()
        {
            InitializeComponent();

            //Método para llenar el combobox a penas inicie el programa
            llenarCombobox();


            //Inicializando puerto serial
            serialPort1 = new SerialPort();
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;
            serialPort1.DtrEnable = true;
            serialPort1.Open();

            serialPort1.DataReceived += serialPort1_DataReceived;
        }

        //3 métodos necesarios para la comunicación entre c# y arduino
        public void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = string.Empty;


            line = serialPort1.ReadLine();


            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        public delegate void LineReceivedEvent(string line);

        public void LineReceived(string line)
        {
            labelArduino.Text = line.TrimEnd('\r');
        }


        //método para leer la temperatura del usuario seleccionado por el combobox
        private void readStatus_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.Text == "")
            {
                MessageBox.Show("Por favor seleccione un cliente");
            }
            else
            {
                //Llenando variable 'nombre' con el combobox seleccionado
                nombre = comboBoxClientes.Text;

                //Llenando variable 'temperatura' con la temperatura correspondiente del nombre seleciconado por el combobox
                temperatura = obtenerTemperatura(nombre);

                //Mostrando en la etiqueta 'etiquetaTempBD' la temperatura correspondiente según la BD
                etiquetaTempBD.Text = temperatura.ToString();
            }
        }

        //Llenando el combobox con SOLO los nombres de los clientes registrados en la base de datos
        public void llenarCombobox()
        {
            comboBoxClientes.Items.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=registros;";
            // Tu consulta en SQL
            string query = "SELECT * FROM clientes_tabla ORDER BY id ASC";

            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            // A consultar !
            try
            {
                // Abre la base de datos
                databaseConnection.Open();

                // Ejecuta la consultas
                reader = commandDatabase.ExecuteReader();

                // Hasta el momento todo bien, es decir datos obtenidos

                // IMPORTANTE :#
                // Si tu consulta retorna un resultado, usa el siguiente proceso para obtener datos

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // En nuestra base de datos, el array contiene:  ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Hacer algo con cada fila obtenida

                        comboBoxClientes.Items.Add(reader.GetString(1));
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }

                // Cerrar la conexión
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                Console.WriteLine(ex.Message);
            }
        }

        //Obteniendo valor de la temperatura de la BD con el nombre
        public double obtenerTemperatura(string nombre)
        {
            double temp = 0;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=registros;";
            // Tu consulta en SQL
            string query = "SELECT * FROM clientes_tabla WHERE `nombre`= '" + nombre +"'";

            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            // A consultar !
            try
            {
                // Abre la base de datos
                databaseConnection.Open();

                // Ejecuta la consultas
                reader = commandDatabase.ExecuteReader();

                // Hasta el momento todo bien, es decir datos obtenidos

                // IMPORTANTE :#
                // Si tu consulta retorna un resultado, usa el siguiente proceso para obtener datos

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // En nuestra base de datos, el array contiene:  ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Hacer algo con cada fila obtenida
                        if (Convert.ToDouble(reader.GetString(7)) == 0)
                        {
                            MessageBox.Show("Temperatura aún no registrada para " + reader.GetString(1) + "");
                            
                            temp = Convert.ToDouble(reader.GetString(7));
                        }
                        else
                        {
                            MessageBox.Show("¡Temperatura encontrada para: " + reader.GetString(1) + "!");
                            temp = Convert.ToDouble(reader.GetString(7));
                        }
                    }
                    Console.ReadKey();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                    temp = 0;
                }

                // Cerrar la conexión
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                Console.WriteLine(ex.Message);
            }
            return temp;
        }

        //Botón de registrar temperatura actual en la base de datos
        private void registrarUpdateTemp_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.Text == string.Empty)
            {
                MessageBox.Show("Por favor seleccione un cliente");
            }
            else
            {
                string temp = (labelArduino.Text).ToString();
                string temp2 = temp.TrimEnd('0');
                string temp3 = temp2.TrimEnd('.');
                
                //mandando llamar método para hacer update
                updateUser(comboBoxClientes.Text, temp3);
            }
        }

        //método que actualiza
        public static void updateUser(string nombre, string temperatura)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=registros;";
            // Actualizar la fila user con ID 1
            string query = "UPDATE `clientes_tabla` SET  `temperatura`='"+ temperatura + "' WHERE `nombre`='"+ nombre +"'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Actualizado satisfactoriamente
                MessageBox.Show("Actualizado satisfactoriamente");
                
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, quizás el ID no existe
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizarB_Click(object sender, EventArgs e)
        {
            llenarCombobox();
        }
    }
}
