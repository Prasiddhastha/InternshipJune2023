using Microsoft.AspNetCore.Mvc;

namespace ApiWithEndpoints.StudentEndpoints
{
    public class ByIdEndpoints:EndpointBaseAsync.WithRequest<int>.WithActionResult<Student>
    {
        private readonly DataContext _context;
        public ByIdEndpoints(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetStudentById")]
        public override async Task<ActionResult<Student>> HandleAsync(int id, CancellationToken cancellationToken = default)
        {
            var data = await _context.Students.FindAsync(id);

            if (data is null)
            {
                return Content("Wrong id");
            }
            else
            {
                return Ok(data);
            }
        }
    }
}
