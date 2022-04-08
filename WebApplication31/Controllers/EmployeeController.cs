using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.BI.Repository;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRep;

        public EmployeeController( IEmployeeRepo employeeRep )
        {
            _employeeRep = employeeRep;
        }
        [HttpGet]

        [Route("api/Names")]


        public IActionResult Names()
        {
      

            try
            {
                EmployeeVM vM = new EmployeeVM
                {
                    Name = "Mostafa",
                    Salary = "400"
                   
                };

                List<EmployeeVM> vMs = new List<EmployeeVM>();
                vMs.Add(vM);

                CustomeResponse custome = new CustomeResponse
                {
                    Code = "200",
                    Status = "Done",
                    Message = "Hello Mostafa"
                   
                };

                return Ok(custome);

            }
            catch (Exception)
            {

                return NotFound( new CustomeResponse { 
                
                    Code ="400",
                    Status = "eewwe",
                    Message ="Not Good man"
                });
            }
        }
        [HttpGet]

        [Route("/api/GetEmployee")]

        public IActionResult GetEmployee()
        {


            var data = _employeeRep.Get();
            return Ok(new CustomeResponse {

                Code = "200",
                Status = "Done",
                Records = data

            });
        }
        [HttpPost]

        [Route("/api/PostEmployees")]

        public IActionResult PostEmployee( EmployeeVM vM )
        {
            try
            {


                if (ModelState.IsValid)
                {

                    var data = _employeeRep.Create(vM);


                 CustomeResponse  custome =    new CustomeResponse
                 {

                     RecordsCustome = data,

                        Code = "200",
                        Status = "Done",

                    };
                    return Ok(custome);
                }

                return StatusCode(400, new CustomeResponse { Code="300"  ,Status="Done", Message="Darash" });
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPut]

        [Route("/api/PutEmployees")]

        public IActionResult PuttEmployee(EmployeeVM vM)
        {
            try
            {


                if (ModelState.IsValid)
                {

                    var data = _employeeRep.Update(vM);


                    CustomeResponse custome = new CustomeResponse
                    {

                        RecordsCustome = data,

                        Code = "200",
                        Status = "Done",

                    };
                    return Ok(custome);
                }

                return StatusCode(400, new CustomeResponse { Code = "300", Status = "Done", Message = "Darash" });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]

        [Route("/api/DeleteEmployees/{Id}")]

        public IActionResult DeleteEmployees(int  id)
        {
            try
            {


                if (ModelState.IsValid)
                {

                    var data = _employeeRep.Delete(id);


                    CustomeResponse custome = new CustomeResponse
                    {

                        RecordsCustome = data,

                        Code = "200",
                        Status = "Done",

                    };
                    return Ok(custome);
                }

                return StatusCode(400, new CustomeResponse { Code = "300", Status = "Done", Message = "Darash" });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
