using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RailwayReservationSystem
{
    public partial class AdminForm : Form
    {
        private string connectionString = "Server=ICS-LT-F7HDR73\\SQLEXPRESS;Database=railwayDB;User Id=sa;Password=123456789";

        public AdminForm()
        {
            InitializeComponent();
            LoadTrainData();
        }

        private void LoadTrainData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Train";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTrains.DataSource = dt;
            }
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Train (tno, tname, [from], dest, price, class_of_travel, train_status, seats_available)"+"VALUES (@tno, @tname, @from, @dest, @price, @class, @status, @seats)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tno", txtTno.Text);
                cmd.Parameters.AddWithValue("@tname", txtTname.Text);
                cmd.Parameters.AddWithValue("@from", txtFrom.Text);
                cmd.Parameters.AddWithValue("@dest", txtDest.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@class", txtClass.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@seats", txtSeats.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadTrainData();
            }
        }

        private void btnUpdateTrain_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Train SET tname = @tname, [from] = @from, dest = @dest, price = @price, " +
                               "class_of_travel = @class, train_status = @status, seats_available = @seats WHERE tno = @tno";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tno", txtTno.Text);
                cmd.Parameters.AddWithValue("@tname", txtTname.Text);
                cmd.Parameters.AddWithValue("@from", txtFrom.Text);
                cmd.Parameters.AddWithValue("@dest", txtDest.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@class", txtClass.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@seats", txtSeats.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadTrainData();
            }
        }

        private void btnDeleteTrain_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Train WHERE tno = @tno";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tno", txtTno.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadTrainData();
            }
        }

        private void txtTno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewTrains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
