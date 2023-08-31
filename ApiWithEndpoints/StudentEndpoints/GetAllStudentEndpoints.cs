using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiWithEndpoints.StudentEndpoints
{
    public class GetAllStudentEndpoints:EndpointBaseSync.WithoutRequest
        .WithActionResult<IEnumerable<Student>>
    {
        private readonly DataContext _context;
        public GetAllStudentEndpoints(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetStudents")]
        public override  ActionResult<IEnumerable<Student>> Handle()
        {
            return Ok( _context.Students.ToList());
        }
    }
}
