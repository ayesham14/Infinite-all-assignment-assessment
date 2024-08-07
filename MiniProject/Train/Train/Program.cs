using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

class Program
{
    private static string connectionString = "Server=ICS-LT-F7HDR73\\SQLEXPRESS;Database=TrainBookingDB;User Id=sa;Password=123456789;";
    static void Main(string[] args)
    {

        Console.WriteLine("WELCOME TO RAILWAYS");
        Console.WriteLine("===================");
        Console.WriteLine("Are you an Admin or a Normal User?");
        string userType = Console.ReadLine();

        try
        {
            if (userType.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                AdminActions();
            }
            else if (userType.Equals("User", StringComparison.OrdinalIgnoreCase))
            {
                UserActions();
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void AdminActions()
    {
        try
        {
            Console.WriteLine("Admin Panel");
            Console.WriteLine("1. View Trains");
            Console.WriteLine("2. Edit Train Details");
            Console.WriteLine("3. View All Users");
            Console.WriteLine("4. View All Bookings");
            Console.WriteLine("5. View Cancellation History");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ViewTrains();
                    break;
                case "2":
                    EditTrainDetails();
                    break;
                case "3":
                    ViewAllUsers();
                    break;
                case "4":
                    ViewAllBookings();
                    break;
                case "5":
                    ViewCancellationHistory();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void UserActions()
    {
        try
        {
            Console.WriteLine("User Panel");
            Console.WriteLine("1. Book Tickets");
            Console.WriteLine("2. Cancel Booking");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BookTickets();
                    break;
                case "2":
                    CancelBooking();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void ViewTrains()
    {
        try
        {
            DataTable trains = GetTrains();
            foreach (DataRow row in trains.Rows)
            {
                Console.WriteLine($"Train ID: {row["TrainID"]}, Train Name: {row["TrainName"]}, Destination: {row["Destination"]}, Starting Location: {row["StartingLocation"]}, Seats Available: {row["SeatsAvailable"]}, Price per Seat: {row["PricePerSeat"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while viewing trains: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void EditTrainDetails()
    {
        try
        {
            Console.WriteLine("Enter Train ID to edit:");
            int trainId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Train Name:");
            string trainName = Console.ReadLine();

            Console.WriteLine("Enter new Destination:");
            string destination = Console.ReadLine();

            Console.WriteLine("Enter new Starting Location:");
            string startingLocation = Console.ReadLine();

            Console.WriteLine("Enter new Seats Available:");
            int seatsAvailable = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Price per Seat:");
            decimal pricePerSeat = decimal.Parse(Console.ReadLine());

            EditTrain(trainId, trainName, destination, startingLocation, seatsAvailable, pricePerSeat);
            Console.WriteLine("Train details updated.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while editing train details: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void ViewAllUsers()
    {
        try
        {
            DataTable users = GetUsers();
            foreach (DataRow row in users.Rows)
            {
                Console.WriteLine($"User ID: {row["UserID"]}, Username: {row["Username"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while viewing users: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void ViewAllBookings()
    {
        try
        {
            DataTable bookings = GetBookings();
            foreach (DataRow row in bookings.Rows)
            {
                Console.WriteLine($"Booking ID: {row["BookingID"]}, UserID: {row["UserID"]}, TrainID: {row["TrainID"]}, Seats Booked: {row["SeatsBooked"]}, Booking Date: {row["BookingDate"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while viewing bookings: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void ViewCancellationHistory()
    {
        try
        {
            DataTable cancellations = GetCancellations();
            foreach (DataRow row in cancellations.Rows)
            {
                Console.WriteLine($"Cancellation ID: {row["CancellationID"]}, BookingID: {row["BookingID"]}, Cancellation Date: {row["CancellationDate"]}, Refund Amount: {row["RefundAmount"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while viewing cancellations: {ex.Message}");
        }
        finally
        {
            Console.ReadLine();
        }
    }

    static void BookTickets()
    {
        try
        {
            // Display all available trains
            DataTable trains = GetTrains();
            Console.WriteLine("Available Trains:");
            foreach (DataRow row in trains.Rows)
            {
                Console.WriteLine($"Train ID: {row["TrainID"]}, Train Name: {row["TrainName"]}, Destination: {row["Destination"]}, Starting Location: {row["StartingLocation"]}, Seats Available: {row["SeatsAvailable"]}, Price per Seat: {row["PricePerSeat"]}");
            }

            Console.WriteLine("Enter User ID:");
            int userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Train ID to book:");
            int trainId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of seats to book:");
            int seatsBooked = int.Parse(Console.ReadLine());

            // Assuming train exists and seats are available
            DataRow trainRow = trains.AsEnumerable().FirstOrDefault(row => (int)row["TrainID"] == trainId);
            if (trainRow != null)
            {
                int availableSeats = (int)trainRow["SeatsAvailable"];
                if (availableSeats >= seatsBooked)
                {
                    AddBooking(userId, trainId, seatsBooked);

                    // Update available seats
                    EditTrain(trainId, (string)trainRow["TrainName"], (string)trainRow["Destination"], (string)trainRow["StartingLocation"], availableSeats - seatsBooked, (decimal)trainRow["PricePerSeat"]);

                    // Print ticket
                    Console.WriteLine("\nTicket Booked Successfully!");
                    Console.WriteLine($"Train Name: {trainRow["TrainName"]}");
                    Console.WriteLine($"Destination: {trainRow["Destination"]}");
                    Console.WriteLine($"Starting Location: {trainRow["StartingLocation"]}");
                    Console.WriteLine($"Date: {DateTime.Now}");
                    Console.WriteLine($"Seats Booked: {seatsBooked}");
                    Console.WriteLine($"Price per Seat: {trainRow["PricePerSeat"]}");
                    Console.WriteLine($"Total Price: {seatsBooked * (decimal)trainRow["PricePerSeat"]}");
                }
                else
                {
                    Console.WriteLine("Not enough seats available.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Train ID.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while booking tickets: {ex.Message}");
        }
        finally
        {
            Console.ReadLine(); 
        }
    }

    static void CancelBooking()
    {
        try
        {
            Console.WriteLine("Enter Booking ID to cancel:");
            int bookingId = int.Parse(Console.ReadLine());

            // Fetch booking details
            DataTable bookings = GetBookings();
            DataRow bookingRow = bookings.AsEnumerable().FirstOrDefault(row => (int)row["BookingID"] == bookingId);
            if (bookingRow != null)
            {
                int trainId = (int)bookingRow["TrainID"];
                int seatsBooked = (int)bookingRow["SeatsBooked"];

                // Fetch train details
                DataTable trains = GetTrains();
                DataRow trainRow = trains.AsEnumerable().FirstOrDefault(row => (int)row["TrainID"] == trainId);

                if (trainRow != null)
                {
                    decimal refundAmount = seatsBooked * (decimal)trainRow["PricePerSeat"];

                    // Cancel booking
                    CancelBookingProcess(bookingId, refundAmount);

                    // Print cancellation message
                    Console.WriteLine("\nTicket Cancelled Successfully!");
                    Console.WriteLine($"Refund Amount: {refundAmount}");
                }
                else
                {
                    Console.WriteLine("Invalid Train ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Booking ID.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while cancelling the booking: {ex.Message}");
        }
        finally
        {
            Console.ReadLine();
        }
    }

    static DataTable GetTrains()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Trains";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while retrieving trains: {ex.Message}");
            return new DataTable(); 
        }
    }

    static void EditTrain(int trainId, string trainName, string destination, string startingLocation, int seatsAvailable, decimal pricePerSeat)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Open the connection before executing the command

                string query = "UPDATE Trains SET TrainName = @TrainName, Destination = @Destination, StartingLocation = @StartingLocation, SeatsAvailable = @SeatsAvailable, PricePerSeat = @PricePerSeat WHERE TrainID = @TrainID";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TrainID", trainId);
                command.Parameters.AddWithValue("@TrainName", trainName);
                command.Parameters.AddWithValue("@Destination", destination);
                command.Parameters.AddWithValue("@StartingLocation", startingLocation);
                command.Parameters.AddWithValue("@SeatsAvailable", seatsAvailable);
                command.Parameters.AddWithValue("@PricePerSeat", pricePerSeat);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while editing the train: {ex.Message}");
        }
    }

    static DataTable GetUsers()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while retrieving users: {ex.Message}");
            return new DataTable(); 
        }
    }

    static DataTable GetBookings()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bookings";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while retrieving bookings: {ex.Message}");
            return new DataTable(); 
        }
    }

    static DataTable GetCancellations()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cancellations";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while retrieving cancellations: {ex.Message}");
            return new DataTable(); 
        }
    }

    static void AddBooking(int userId, int trainId, int seatsBooked)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); 

                string query = "INSERT INTO Bookings (UserID, TrainID, SeatsBooked, BookingDate) VALUES (@UserID, @TrainID, @SeatsBooked, @BookingDate)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@TrainID", trainId);
                command.Parameters.AddWithValue("@SeatsBooked", seatsBooked);
                command.Parameters.AddWithValue("@BookingDate", DateTime.Now);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while adding the booking: {ex.Message}");
        }
    }

    static void CancelBookingProcess(int bookingId, decimal refundAmount)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); 

                // Retrieve the train ID and seats booked for the cancellation
                DataTable bookings = GetBookings();
                DataRow bookingRow = bookings.AsEnumerable().FirstOrDefault(row => (int)row["BookingID"] == bookingId);
                if (bookingRow != null)
                {
                    int trainId = (int)bookingRow["TrainID"];
                    int seatsBooked = (int)bookingRow["SeatsBooked"];

                    // Fetch train details
                    DataTable trains = GetTrains();
                    DataRow trainRow = trains.AsEnumerable().FirstOrDefault(row => (int)row["TrainID"] == trainId);
                    if (trainRow != null)
                    {
                        int availableSeats = (int)trainRow["SeatsAvailable"];

                        // Cancel booking
                        string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@BookingID", bookingId);
                        command.ExecuteNonQuery();

                        // Update available seats
                        EditTrain(trainId, (string)trainRow["TrainName"], (string)trainRow["Destination"], (string)trainRow["StartingLocation"], availableSeats + seatsBooked, (decimal)trainRow["PricePerSeat"]);

                        // Record the cancellation
                        query = "INSERT INTO Cancellations (BookingID, CancellationDate, RefundAmount) VALUES (@BookingID, @CancellationDate, @RefundAmount)";
                        command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@BookingID", bookingId);
                        command.Parameters.AddWithValue("@CancellationDate", DateTime.Now);
                        command.Parameters.AddWithValue("@RefundAmount", refundAmount);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while processing the cancellation: {ex.Message}");
        }
    }
}