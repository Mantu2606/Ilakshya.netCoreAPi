using AutoMapper;
using ILakshya.Dal;
using ILakshya.Model;
using ILakshya.WebApi.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ILakshya.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
            private readonly ICommonRepository<Student> _studentRepository;
            private readonly IMapper _mapper;
           public StudentController(ICommonRepository<Student> repository, IMapper mapper)
            {
                _studentRepository = repository;
                 _mapper = mapper;  
            }
            // Get ALl API 
            [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
            [Authorize(Roles = "Student, Teacher, Admin")]
            public ActionResult<IEnumerable<StudentDto>> Get()
            {
               var students = _studentRepository.GetAll();
              if(students.Count <= 0) { 
              return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<StudentDto>>(students)); 
              
            }
             // Get by Id 
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "Student, Teacher, Admin")]
       
           public ActionResult<StudentDto>  GetDetails(int id)
            {
               var student = _studentRepository.GetDetails(id);
                return  student == null ? NotFound() : Ok(_mapper.Map<StudentDto> (student)); 
            }

            [HttpPost]
            [ProducesResponseType(StatusCodes.Status201Created)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
           [Authorize(Roles = "Teacher, Admin")]
        public ActionResult Create(NewStudentDto student) // in origingal NewStudentDto -> Student 
        {
            var studentModel = _mapper.Map<Student> (student);
                _studentRepository.Insert(studentModel);
                var result = _studentRepository.SaveChanges();
                if (result > 0)
                {
                  var studentDetails = _mapper.Map<StudentDto>(studentModel);
                    return CreatedAtAction("GetDetails", new { id = studentDetails.StuEnrollNo }, studentDetails);
                }
                return BadRequest();
            }

            [HttpPut]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [Authorize(Roles = "Teacher, Admin")]
        public ActionResult Update(Student student)
            {
                _studentRepository.Update(student);
                var result = _studentRepository.SaveChanges();
                if (result > 0)
                {
                    return NoContent();
                }
                return BadRequest();
            }
            [HttpDelete("{id}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [Authorize(Roles = "Teacher, Admin")]
        public ActionResult<Student> Delete(int id)
            {
                var student = _studentRepository.GetDetails(id);
                if (student == null)
                {
                    return NotFound();
                }
                else
                {
                    _studentRepository.Delete(student);
                    _studentRepository.SaveChanges();
                    return NoContent();
                }
            }
        }
    }