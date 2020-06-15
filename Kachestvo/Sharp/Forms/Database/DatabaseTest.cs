using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kachestvo.Sharp.Database;
using Microsoft.AspNet.SignalR.Client;
using MySql.Data.MySqlClient;

namespace Kachestvo.Forms.Database
{
    public partial class DatabaseTest : Form
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kachestvo;";
        private MySqlConnection databaseConnection;
        private MySqlDataAdapter dataAdapter;
        private string _name, _comment;
        HubConnection _hubConnection;
        IHubProxy hubProxy;

        public DatabaseTest()
        {
            InitializeComponent();
            shortcutMethod();

            //_hubConnection = new HubConnection("http://localhost:8080/signalr/hubs");
            //hubProxy = _hubConnection.CreateHubProxy("kachestvoDatabaseHub");
            //_hubConnection.Start().Wait();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            shortcutMethod();
        }

        private void btnSendComment_Click(object sender, EventArgs e)
        {
            //hubProxy.Invoke("sendNextPrompt", textBox1.Text, "Window App User").Wait();

            string query = "INSERT INTO comments(`Name`, `Comment`) VALUES ('" + txtName.Text + "' , '" + txtComment.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            commentConnection();
        }

        private void shortcutMethod()
        {
            commentConnection();
            nextConnection();
            previousConnection();
        }

        #region Database Connection

        private void commentConnection()
        {
            string query = "SELECT * FROM comments";

            databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            if (this.isConnectionOpen())
            {
                dataAdapter = new MySqlDataAdapter("select * from comments", databaseConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataComments.DataSource = ds.Tables[0];

                this.databaseConnection.Close();
            }
        }

        private void nextConnection()
        {
            string query = "SELECT * FROM next";

            databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            if (this.isConnectionOpen())
            {
                dataAdapter = new MySqlDataAdapter("select * from next", databaseConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataNext.DataSource = ds.Tables[0];

                this.databaseConnection.Close();
            }
        }

        private void previousConnection()
        {
            string query = "SELECT * FROM previous";

            databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            if (this.isConnectionOpen())
            {
                dataAdapter = new MySqlDataAdapter("select * from previous", databaseConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataPrevious.DataSource = ds.Tables[0];

                this.databaseConnection.Close();
            }
        }

        private bool isConnectionOpen()
        {
            try
            {
                databaseConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Server'a bağlanılamadı.");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        #endregion

        #region TextBox Utils

        private void txtName_Enter(object sender, EventArgs e)
        {
            textAttachments();
            if (_name == "Name & Surname")
            {
                txtName.Text = "";
            }


        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            textAttachments();
            if (_name == "")
            {
                txtName.Text = "Name & Surname";
            }
        }

        private void txtComment_Enter(object sender, EventArgs e)
        {
            textAttachments();
            if (_comment == "Comment")
            {
                txtComment.Text = "";
            }
        }

        private void txtComment_Leave(object sender, EventArgs e)
        {
            textAttachments();
            if (_comment == "")
            {
                txtComment.Text = "Comment";
            }
        }


        private void textAttachments()
        {
            _name = txtName.Text;
            _comment = txtComment.Text;

        }

        #endregion
    }
}
