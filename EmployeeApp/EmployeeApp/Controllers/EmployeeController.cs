using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public static SqlCommand GetConnection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=C:\USERS\OMKAR\SOURCE\REPOS\EMPLOYEEAPP\EMPLOYEEAPP\APP_DATA\EMPLOYEEDB.MDF;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            return cmd;
        }
        public ActionResult Index()
        {
            SqlCommand cmd = GetConnection();
            cmd.CommandText = "select * from Employee order by Name";
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            List<Employee> lstEmployee = new List<Employee>();
            while (dr.Read())
            {
                Employee E = new Employee();
                E.Id = Convert.ToInt32(dr["Id"]);
                E.Name = dr["Name"].ToString();
                E.Bsaic = Convert.ToDecimal(dr["Basic"]);
                E.DeptNo = Convert.ToSByte(dr["DeptNo"]);
                lstEmployee.Add(E);
            }
            return View(lstEmployee);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id=0)
        {
            SqlCommand cmd = GetConnection();
            cmd.CommandText = "select * from Employee where Id=@Id";
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            Employee E = new Employee();
            E.Id = Convert.ToInt32(dr["Id"]);
            E.Name = dr["Name"].ToString();
            E.Bsaic = Convert.ToDecimal(dr["Basic"]);
            E.DeptNo = Convert.ToSByte(dr["DeptNo"]);

            return View(E);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                SqlCommand cmd = GetConnection();
                cmd.CommandText = "insert into Employee values(@Name,@Basic,@DeptNo)";
                cmd.Parameters.AddWithValue("@Name",emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Bsaic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id=0)
        {
            SqlCommand cmd = GetConnection();
            cmd.CommandText = "select * from Employee where Id=@Id";
            cmd.Parameters.AddWithValue("@Id",id);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            Employee E = new Employee();
            E.Id = Convert.ToInt32(dr["Id"]);
            E.Name = dr["Name"].ToString();
            E.Bsaic = Convert.ToDecimal(dr["Basic"]);
            E.DeptNo = Convert.ToSByte(dr["DeptNo"]);

            return View(E);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Employee emp)
        {
            try
            {
                SqlCommand cmd = GetConnection();
                cmd.CommandText = "update Employee set name=@Name,Basic=@Basic,DeptNo=@DeptNo where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Bsaic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
              
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id=0)
        {
            SqlCommand cmd = GetConnection();
            cmd.CommandText = "select * from Employee where Id=@Id";
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            Employee E = new Employee();
            E.Id = Convert.ToInt32(dr["Id"]);
            E.Name = dr["Name"].ToString();
            E.Bsaic = Convert.ToDecimal(dr["Basic"]);
            E.DeptNo = Convert.ToSByte(dr["DeptNo"]);

            return View(E);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id,Employee e)
        {
            try
            {
                SqlCommand cmd = GetConnection();
                cmd.CommandText = "delete from Employee where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
