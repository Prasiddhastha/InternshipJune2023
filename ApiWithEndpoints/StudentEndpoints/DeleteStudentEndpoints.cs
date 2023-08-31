using Microsoft.AspNetCore.Mvc;

namespace ApiWithEndpoints.StudentEndpoints
{
    public class DeleteStudentEndpoints:EndpointBaseAsync
        .WithRequest<int>.WithActionResult<Student>
    {
        private readonly DataContext _context;

        public DeleteStudentEndpoints(DataContext context)
        {
            _context = context;
        }

        [HttpDelete]
        [Route("DeleteStudent")]
        public override async Task<ActionResult<Student>> HandleAsync(int id, CancellationToken cancellationToken = default)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound("Wrong id");
            }
            else
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return Ok("Deleted");
            }
        }
    }
}
