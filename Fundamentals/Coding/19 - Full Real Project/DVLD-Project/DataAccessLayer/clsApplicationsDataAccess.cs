﻿using Entities;
using Entities.Enums;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;


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

                                CASE A.ApplicationStatus
                                    WHEN 1 THEN 'Pending'
                                    WHEN 2 THEN 'Canceled'
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

        //public static bool IsApplicationExists(int applicationID)
        //{
        //    try
        //    {
        //        string query = "SELECT COUNT(*) FROM Applications WHERE ApplicationID = @ApplicationID";
        //        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand(query, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
        //                connection.Open();
        //                int count = (int)cmd.ExecuteScalar();
        //                return count > 0;
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Error checking if application exists: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("An error occurred: " + ex.Message);
        //    }
        //}

        //public static bool IsPendingApplication(int applicationID)
        //{
        //    try
        //    {
        //        string query = "SELECT ApplicationStatus FROM Applications WHERE ApplicationID = @ApplicationID";
        //        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand(query, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
        //                connection.Open();
        //                int status = (int)cmd.ExecuteScalar();
        //                return status == 1;
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Error checking if application is pending: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("An error occurred: " + ex.Message);
        //    }
        //}

        public static bool HasPendingApplication(int personID, int appTypeID)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID AND ApplicationStatus = 1 AND ApplicationTypeID = @AppTypeID";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AppTypeID", appTypeID);
                        cmd.Parameters.AddWithValue("@ApplicantPersonID", personID);
                        connection.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error checking for pending applications: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

        public static enAppStatus GetApplicationStatus(int personID, int appTypeID)
        {
            try
            {
                string query = "SELECT ApplicationStatus FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID AND ApplicationTypeID = @AppTypeID";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AppTypeID", appTypeID);
                        cmd.Parameters.AddWithValue("@ApplicantPersonID", personID);
                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int statusValue = Convert.ToInt32(result);
                            return (enAppStatus)statusValue;
                        }
                        else
                        {
                            // No application found, return NotFound status
                            return enAppStatus.NotFound;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error checking for pending or completed applications: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

        public static bool CancelApplication(int applicationID)
        {
            try
            {
                string query = "UPDATE Applications SET ApplicationStatus = 2 WHERE ApplicationID = @ApplicationID";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error canceling application: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

        public static DataTable GetApplicationDetailsByApplicationID(int applicationID, int drivingLicenseAppID)
        {
            DataTable dtApplication = new DataTable();
            try
            {
                string query = @"SELECT Applications.ApplicationID, Applications.ApplicationDate, Applications.ApplicationStatus, Applications.LastStatusDate, Applications.PaidFees,
                                People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS 'ApplicantName',
                                ApplicationTypes.ApplicationTypeTitle, Users.UserName,
                                (SELECT COUNT(*) 
                                FROM TestAppointments
                                JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                WHERE TestTypeID in (1, 2, 3) AND TestResult = 1 AND LocalDrivingLicenseApplicationID = @DLAppID
                                ) AS PassedTests

                                FROM Applications
                                JOIN People
                                ON Applications.ApplicantPersonID = People.PersonID
                                JOIN ApplicationTypes
                                ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
                                JOIN Users
                                ON Applications.CreatedByUserID = Users.UserID
                                WHERE ApplicationID = @AppID;";
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AppID", applicationID);
                        cmd.Parameters.AddWithValue("@DLAppID", drivingLicenseAppID); 
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtApplication.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Application Doesn't Exist: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
            return dtApplication;
        }
    }
}
