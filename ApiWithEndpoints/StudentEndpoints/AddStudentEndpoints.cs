

using ApiWithEndpoints.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithEndpoints.StudentEndpoints
{
    public class AddStudentEndpoints :EndpointBaseAsync
        .WithRequest<StudentDto>.
        WithActionResult
    {
        private readonly DataContext _context;
        public AddStudentEndpoints(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AddStudent")]
        public override async Task<ActionResult> HandleAsync(StudentDto _student,CancellationToken cancellationToken = default)
        {
            Student student = new Student()
            {
                Name = _student.Name,
                Age = _student.Age,
                Address = _student.Address,
                Grade = _student.Grade
            };
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return(Ok(student));
        }
    }
}
