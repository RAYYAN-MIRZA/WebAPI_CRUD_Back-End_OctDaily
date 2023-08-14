
// Main Controller of the website.

// This is controlling the HTTP requests
// i.e. it contains the logic behind of GET,POST,UPDATE,DELETE
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using MySql.Data.MySqlClient;

namespace WebApplication1.Controllers
{
    public class Student_dataController : ApiController
    {
        public HttpResponseMessage Get()
        {
            // SQL QUERY TO GET DATA FROM TABLE
            string query = @"
                    select* from
                    finaltable
                    ";
            DataTable table = new DataTable();
            // STUDENTS_DATA : is the connection string, which is intialized in " Web.confiq " file 
            //                 tagged  under connectionStrings like this 	<connectionStrings>..... </connectionStrings>
            
            //NOTE :This Connection string should be changed in order to connect to a different sql server! In the Web.config file     
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["STUDENTS_DATA"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
     
        // POST method == INSERTING DATA INTO THE DATA BASE!
        public string Post(Student_data dat)
        {
            try
            {
                // SQL QUERY TO INSERT DATA INTO TABLE
                string query = @"
            INSERT INTO finaltable
            (ROLL_NO,NAME, FIELD, NATIONALITY, BATCH, EMAIL)
            VALUES
            (@roll,@Name, @Field, @Nationality, @Batch, @Email)";

                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["STUDENTS_DATA"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@roll", dat.ROLL_NO);
                    cmd.Parameters.AddWithValue("@Name", dat.NAME);
                    cmd.Parameters.AddWithValue("@Field", dat.FIELD);
                    cmd.Parameters.AddWithValue("@Nationality", dat.NATIONALITY);
                    cmd.Parameters.AddWithValue("@Batch", dat.BATCH);
                    cmd.Parameters.AddWithValue("@Email", dat.EMAIL);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return "ADDED, Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add!!";
            }
        }

        // PUT method == UPDATING DATA IN THE DATBASE
        public string Put(Student_data data)
        {

            try
            {
                string query = @"
            UPDATE finaltable
            SET ROLL_NO=@roll,
                NAME = @Name,
                FIELD = @Field,
                NATIONALITY = @Nationality,
                BATCH = @Batch,
                EMAIL = @Email
            WHERE ID = @id";

                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["STUDENTS_DATA"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@roll", data.ROLL_NO);
                    cmd.Parameters.AddWithValue("@Name", data.NAME);
                    cmd.Parameters.AddWithValue("@Field", data.FIELD);
                    cmd.Parameters.AddWithValue("@Nationality", data.NATIONALITY);
                    cmd.Parameters.AddWithValue("@Batch", data.BATCH);
                    cmd.Parameters.AddWithValue("@Email", data.EMAIL);
                    cmd.Parameters.AddWithValue("@id", data.ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return "UPDATED, Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to UPDATE!!";
            }
        }

        // DELETE REQUEST: DELETING A STUDENT'S DATA FROM THE DATABASE
        public string Delete(int id)
        {
            try
            {
                string query = @"
              delete from finaltable
              where ID=" + id + @"";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["STUDENTS_DATA"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "DELETED, Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to DELETE!!";
            }
        }



    }
}
