using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using suuapi.Tables;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace suuapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ILogger<DepartmentController> _logger;
        public DepartmentController(ILogger<DepartmentController> logger)
        {
            _logger = logger;
        }
        public DataTable filldatafromdb(string command="select * from [department]")
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-E7N09RL\SQLEXPRESS;Initial Catalog=suu;Integrated Security=True");
            connection.Open();
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = command;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        // GET: api/<DepartmentController>
        [HttpGet("department/")]
        public string getdepartment()
        {
            try
            {
                DataTable dataTable;
                dataTable = filldatafromdb("select * from [department]");
                Department department = new Department();
                List<Department> a = new List<Department>();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    department = new Department();
                    department.department_id = Convert.ToInt32(dataRow[0]);
                    department.faculty_id = Convert.ToInt32(dataRow[1]);
                    department.name_department = Convert.ToString(dataRow[2]);
                    department.short_name_department = Convert.ToString(dataRow[3]);
                    a.Add(department);
                }
                return JsonConvert.SerializeObject(a);
            }
            catch(Exception ex)
            {
                return (ex.Message);
            }
        }

    }

        //[Route("api/[controller]")]
        //[ApiController]
        //public class DepartmentController : ControllerBase
        //{
        //    // GET: api/<DepartmentController>
        //    [HttpGet]
        //    public IEnumerable<string> Get()
        //    {
        //        return new string[] { "value1", "value2" };
        //    }

  
        //    // GET api/<DepartmentController>/5
        //    [HttpGet("{id}")]
        //    public string Get(int id)
        //    {
        //        return "value";
        //    }

        //    // POST api/<DepartmentController>
        //    [HttpPost]
        //    public void Post([FromBody] string value)
        //    {
        //    }

        //    // PUT api/<DepartmentController>/5
        //    [HttpPut("{id}")]
        //    public void Put(int id, [FromBody] string value)
        //    {
        //    }

        //    // DELETE api/<DepartmentController>/5
        //    [HttpDelete("{id}")]
        //    public void Delete(int id)
        //    {
        //    }
        //}
    }
