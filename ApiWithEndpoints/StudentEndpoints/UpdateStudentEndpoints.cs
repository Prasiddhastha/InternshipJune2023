using ApiWithEndpoints.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithEndpoints.StudentEndpoints
{
    public class UpdateRequest
    {
        [FromRoute]
        public int Id { get; set; }

        [FromBody]
        public StudentDto studentDto { get; set; }
    }
    public class UpdateStudentEndpoints:EndpointBaseAsync.WithRequest<UpdateRequest>
        .WithActionResult<Student>
    {
        private readonly DataContext _context;

        public UpdateStudentEndpoints(DataContext context)
        {
            _context = context;
        }
        [HttpPut]
        [Route("UpdateStudent")]
        public override async Task<ActionResult<Student>> HandleAsync(UpdateRequest request, CancellationToken cancellationToken = default)
        {
            var student = await _context.Students.FindAsync(request.Id);

            if (student is null)
            {
                return Content("Data not found!!");
            }

            else
            {
                student.Name = request.studentDto.Name;
                student.Age = request.studentDto.Age;
                student.Address = request.studentDto.Address;
                student.Grade = request.studentDto.Grade;

                await _context.SaveChangesAsync();
                return Ok(student);
            }

        }
    }
}
