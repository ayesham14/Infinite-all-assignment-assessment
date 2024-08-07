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
    public partial class UserForm : Form
    {
        private string connectionString = "Server=ICS-LT-F7HDR73\\SQLEXPRESS;Database=railwayDB;User Id=sa;Password=123456789";
        private string username;

        public UserForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadAvailableTrains();
        }

        private void LoadAvailableTrains()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Train WHERE train_status = 'active'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAvailableTrains.DataSource = dt;
            }
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            int tno = int.Parse(txtTno.Text);
            int seatsToBook = int.Parse(txtSeatsToBook.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Checks the seat availability
                    string checkQuery = "SELECT seats_available FROM Train WHERE tno = @tno";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction);
                    checkCmd.Parameters.AddWithValue("@tno", tno);
                    int seatsAvailable = (int)checkCmd.ExecuteScalar();

                    if (seatsAvailable >= seatsToBook)
                    {
                        // Books the tickets
                        string bookQuery = "INSERT INTO Bookings (userId, tno, seats_booked, booking_date) VALUES ((SELECT userId FROM Users WHERE username = @username), @tno, @seats, GETDATE())";
                        SqlCommand bookCmd = new SqlCommand(bookQuery, conn, transaction);
                        bookCmd.Parameters.AddWithValue("@username", username);
                        bookCmd.Parameters.AddWithValue("@tno", tno);
                        bookCmd.Parameters.AddWithValue("@seats", seatsToBook);
                        bookCmd.ExecuteNonQuery();

                        // Updating seat availability
                        string updateQuery = "UPDATE Train SET seats_available = seats_available - @seats WHERE tno = @tno";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@seats", seatsToBook);
                        updateCmd.Parameters.AddWithValue("@tno", tno);
                        updateCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Booking confirmed!");
                        LoadAvailableTrains();
                    }
                    else
                    {
                        MessageBox.Show("Not enough seats available.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            int bookingId = int.Parse(txtBookingId.Text);
            int seatsToCancel = int.Parse(txtSeatsToCancel.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Get the original booking
                    string bookingQuery = "SELECT seats_booked, tno FROM Bookings WHERE bookingId = @bookingId";
                    SqlCommand bookingCmd = new SqlCommand(bookingQuery, conn, transaction);
                    bookingCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    SqlDataReader reader = bookingCmd.ExecuteReader();


                    if (reader.Read())
                    {
                        int seatsBooked = (int)reader["seats_booked"];
                        int tno = (int)reader["tno"];
                        reader.Close();

                        if (seatsBooked >= seatsToCancel)
                        {
                            string cancelQuery = "INSERT INTO Cancellations (bookingId, seats_cancelled, cancellation_date) VALUES (@bookingId, @seats, GETDATE())";
                            SqlCommand cancelCmd = new SqlCommand(cancelQuery, conn, transaction);
                            cancelCmd.Parameters.AddWithValue("@bookingId", bookingId);
                            cancelCmd.Parameters.AddWithValue("@seats", seatsToCancel);
                            cancelCmd.ExecuteNonQuery();
                           
                            string updateBookingQuery = "UPDATE Bookings SET seats_booked = seats_booked - @seats WHERE bookingId = @bookingId";
                            SqlCommand updateBookingCmd = new SqlCommand(updateBookingQuery, conn, transaction);
                            updateBookingCmd.Parameters.AddWithValue("@seats", seatsToCancel);
                            updateBookingCmd.Parameters.AddWithValue("@bookingId", bookingId);
                            updateBookingCmd.ExecuteNonQuery();

                            string updateTrainQuery = "UPDATE Train SET seats_available = seats_available + @seats WHERE tno = @tno";
                            SqlCommand updateTrainCmd = new SqlCommand(updateTrainQuery, conn, transaction);
                            updateTrainCmd.Parameters.AddWithValue("@seats", seatsToCancel);
                            updateTrainCmd.Parameters.AddWithValue("@tno", tno);
                            updateTrainCmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Cancellation confirmed!");
                            LoadAvailableTrains();
                        }
                        else
                        {
                            MessageBox.Show("Cannot cancel more seats than booked.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Booking not found.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void txtTno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBookTicket_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtSeatsToBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}








