//using System.Data;
//using System.Data.SqlClient;

//namespace DotNETcoreApiLuminarTask1.Model
//{
//    public class EmployeeDB
//    {
//        //SqlConnection con = new SqlConnection(@"server=YOUR_SERVER;database=ASP_Core;Trusted_Connection=True;TrustServerCertificate=True;");
//        SqlConnection con = new SqlConnection(@"server=DESKTOP-J1L5ATQ\SQLEXPRESS;database=ASP_Core;Trusted_Connection=True;TrustServerCertificate=True;");


//        //-----------------------------------------------------------Insert-----------------------------------------------------------------------------------
//        public string InsertDB(Employee objcls)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_EmpInsert", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@empna", objcls.ename);
//                cmd.Parameters.AddWithValue("@empaddr", objcls.eaddr);
//                cmd.Parameters.AddWithValue("@empsal", objcls.esal);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();
//                return ("Inserted successfully");
//            }
//            catch (Exception ex)
//            {
//                if (con.State == ConnectionState.Open)
//                {
//                    con.Close();
//                }
//                return ex.Message.ToString();
//            }
//        }

//        //----------------------------------------------Select From DB------------------------------------------------

//        public List<Employee> SelectDB()
//        {
//            var list = new List<Employee>();

//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_selectAll", con);
//                con.Open();
//                SqlDataReader sdr = cmd.ExecuteReader();

//                while (sdr.Read())
//                {
//                    var o = new Employee
//                    {
//                        eid = Convert.ToInt32(sdr["Emp_id"]),
//                        ename = sdr["Emp_Name"].ToString(),
//                        eaddr = sdr["Emp_Address"].ToString(),
//                        esal = sdr["Emp_Salary"].ToString()
//                    };

//                    list.Add(o);
//                }

//                con.Close();
//                return list;
//            }
//            catch (Exception)
//            {
//                if (con.State == ConnectionState.Open)
//                { 
//                    con.Close();
//                }

//            }
//            return list;
//        }

////-------------------------------------------------Delete----------------------------------------------------
//        public string DeleteDB(int id)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_delete", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@eid", id);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                return ("Deleted successfully");
//            }
//            catch (Exception ex)
//            {
//                if (con.State == ConnectionState.Open)
//                { 
//                    con.Close();
//                }
//                return (ex.Message.ToString());
//            }
//        }

//        //-----------------------------------------------------------Update DB---------------------------------------

//        public string UpdateDB(Employee emp)
//        {
//            string retval = "";

//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_update", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@eid", emp.eid);
//                cmd.Parameters.AddWithValue("@esal", emp.esal);
//                cmd.Parameters.AddWithValue("@eaddr", emp.eaddr);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                retval = "Ok...updated";
//            }
//            catch (Exception ex)
//            {
//                if (con.State == ConnectionState.Open)
//                { 
//                    con.Close();
//                }
//                return (ex.Message);
//            }

//            return (retval);
//        }




//    }
//}







//--------------------------------------------TEST---------------------------------------------





//using System.Data;
//using System.Data.SqlClient;

//namespace DotNETcoreApiLuminarTask1.Model
//{
//    public class EmployeeDB
//    {
//        SqlConnection con = new SqlConnection(@"server=DESKTOP-J1L5ATQ\SQLEXPRESS;database=ASP_Core;Trusted_Connection=True;TrustServerCertificate=True;");

//        public string InsertDB(Employee obj)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_EmpInsert", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@empna", obj.Name);
//                cmd.Parameters.AddWithValue("@empaddr", obj.Address);
//                cmd.Parameters.AddWithValue("@empsal", obj.Salary);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                return "Inserted successfully";
//            }
//            catch (Exception ex)
//            {
//                if (con.State == ConnectionState.Open)
//                    con.Close();
//                return ex.Message;
//            }
//        }

//        public List<Employee> SelectDB()
//        {
//            var list = new List<Employee>();

//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_selectAll", con);
//                con.Open();
//                SqlDataReader sdr = cmd.ExecuteReader();

//                while (sdr.Read())
//                {
//                    var o = new Employee
//                    {
//                        Id = Convert.ToInt32(sdr["Id"]),
//                        Name = sdr["Name"].ToString(),
//                        Address = sdr["Address"].ToString(),
//                        Salary = Convert.ToDecimal(sdr["Salary"])
//                    };
//                    list.Add(o);
//                }

//                con.Close();
//            }
//            catch (Exception)
//            {
//                if (con.State == ConnectionState.Open)
//                    con.Close();
//            }

//            return list;
//        }

//        public string DeleteDB(int id)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_delete", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@eid", id);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                return "Deleted successfully";
//            }
//            catch (Exception ex)
//            {
//                if (con.State == ConnectionState.Open)
//                    con.Close();
//                return ex.Message;
//            }
//        }

//        public string UpdateDB(Employee emp)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand("sp_update", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@eid", emp.Id);
//                cmd.Parameters.AddWithValue("@eaddr", emp.Address);
//                cmd.Parameters.AddWithValue("@esal", emp.Salary);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();

//                return "Updated successfully";
//            }
//            catch (Exception ex)
//            {
//                if (con.State == ConnectionState.Open)
//                    con.Close();
//                return ex.Message;
//            }
//        }
//    }
//}




//----------------------------------------------------------------------------------------------------------



using System.Data;
using System.Data.SqlClient;

namespace DotNETcoreApiLuminarTask1.Model
{
    public class EmployeeDB
    {
        //SqlConnection con = new SqlConnection(@"server=YOUR_SERVER;database=ASP_Core;Trusted_Connection=True;TrustServerCertificate=True;");
        SqlConnection con = new SqlConnection(@"server=DESKTOP-J1L5ATQ\SQLEXPRESS;database=ASP_Core;Trusted_Connection=True;TrustServerCertificate=True;");


        //-----------------------------------------------------------Insert-----------------------------------------------------------------------------------
        public string InsertDB(Employee objcls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EmpInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empna", objcls.Name);
                cmd.Parameters.AddWithValue("@empaddr", objcls.Address);
                cmd.Parameters.AddWithValue("@empsal", objcls.Salary);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Inserted successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return ex.Message.ToString();
            }
        }

        //------------------------------------------------------------Select by ID ------------------------------------------

        public Employee SelectDetailsWithId(int id)
        {
            var getdata = new Employee();

            try
            {
                    SqlCommand cmd = new SqlCommand("sp_selectProfile", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        getdata = new Employee
                        {
                            Id = Convert.ToInt32(sdr["Id"]), //set
                            Name = sdr["Name"].ToString(),
                            Address = sdr["Address"].ToString(),
                            Salary = Convert.ToDecimal(sdr["Salary"]),

                        };
                    }

                    con.Close();
                    return getdata; // ("oK...");
            } 
            catch (Exception)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();                
                }
                throw;
            }
        }


        //----------------------------------------------Select ALL From DB------------------------------------------------

        public List<Employee> SelectDB()
        {
            var list = new List<Employee>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_selectAll", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    var o = new Employee
                    {
                        Id = Convert.ToInt32(sdr["Id"]),
                        Name = sdr["Name"].ToString(),
                        Address = sdr["Address"].ToString(),
                        Salary = Convert.ToDecimal(sdr["Salary"])
                    };

                    list.Add(o);
                }

                con.Close();
                return list;
            }
            catch (Exception)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            return list;
        }

        //-------------------------------------------------Delete----------------------------------------------------
        public string DeleteDB(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return ("Deleted successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }

        //-----------------------------------------------------------Update DB---------------------------------------

        public string UpdateDB(Employee emp)
        {
            string retval = "";

            try
            {
                SqlCommand cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", emp.Id);
                cmd.Parameters.AddWithValue("@eName", emp.Name);
                cmd.Parameters.AddWithValue("@esal", emp.Salary);
                cmd.Parameters.AddWithValue("@eaddr", emp.Address);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                retval = "Ok...updated";
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message);
            }

            return (retval);
        }




    }
}
