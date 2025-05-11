using Entities;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsApplicationsDataAccess
    {
        public static DataTable GetAllApplications()
        {
            DataTable dtApplications = new DataTable();
            try
            {
                string query = @"SELECT A.ApplicationID AS 'D.L Application ID', LC.ClassName AS 'License Class', P.NationalNo AS 'National Number',
                                CONCAT(P.FirstName, ' ', P.SecondName, ' ', P.ThirdName, ' ', P.LastName) AS 'Full Name',
                                A.ApplicationDate AS 'Created Application Date',
                                (
                                    SELECT COUNT(*) 
                                    FROM Applications A2 
                                    WHERE A2.ApplicantPersonID = A.ApplicantPersonID
                                    AND A2.ApplicationStatus = 3
                                )AS 'Passed Tests',
                                CASE A.ApplicationStatus
                                    WHEN 1 THEN 'Pending'
                                    WHEN 2 THEN 'Rejected'
                                    WHEN 3 THEN 'Passed'
                                    ELSE 'Unknown'
                                END AS 'Current Application Status'
                                FROM Applications A
                                JOIN LicenseClasses LC ON LC.LicenseClassID = A.ApplicationTypeID
                                JOIN People P ON A.ApplicantPersonID = P.PersonID
                                ORDER BY [National Number];";

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtApplications.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error retrieving application types: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
            return dtApplications;
        }

        public static int AddNewApplication(clsNewApplicationEventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Applications 
                                (ApplicantPersonID, ApplicationTypeID, ApplicationDate, 
                                ApplicationStatus, PaidFees, CreatedByUserID, LastStatusDate)
                                VALUES 
                                (@ApplicantPersonID, @ApplicationTypeID, @ApplicationDate, 
                                @ApplicationStatus, @PaidFees, @UserID, @LastStatusDate);
                                SELECT SCOPE_IDENTITY();";

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantPersonID", e.ApplicantPersonID);
                        cmd.Parameters.AddWithValue("@ApplicationTypeID", e.ApplicationTypeID);
                        cmd.Parameters.AddWithValue("@ApplicationDate", e.ApplicationCreatedDate);
                        cmd.Parameters.AddWithValue("@ApplicationStatus", e.ApplicationStatus);
                        cmd.Parameters.AddWithValue("@PaidFees", e.PaidFees);
                        cmd.Parameters.AddWithValue("@UserID", e.CreatedByUserID);
                        cmd.Parameters.AddWithValue("@LastStatusDate", e.ApplicationModifiedDate);

                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        throw new Exception("Failed to retrieve new application ID");
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error adding new application: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

        public static bool IsApplicationExists(int applicationID)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Applications WHERE ApplicationID = @ApplicationID";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        connection.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error checking if application exists: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

        public static bool IsPendingApplication(int applicationID)
        {
            try
            {
                string query = "SELECT ApplicationStatus FROM Applications WHERE ApplicationID = @ApplicationID";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        connection.Open();
                        int status = (int)cmd.ExecuteScalar();
                        return status == 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error checking if application is pending: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }
    }
}
