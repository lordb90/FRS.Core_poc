using AutoMapper;
using FRS.Core.Api.Dtos;
using FRS.Core.Application.Services;
using FRS.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FRS.Core.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : ControllerBase
    {
        private readonly ILpmasterService _service;
        private readonly IMapper _mapper;

        public SubjectController(ILpmasterService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<SubjectDto>>> Get()
        {
            var lpmasters = await _service.GetAllLpmasterAsync();
            var subjects = _mapper.Map<List<SubjectDto>>(lpmasters);
            return Ok(subjects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubjectDto>> Get(int id)
        {
            var lpmaster = await _service.GetLpmasterAsync(id);
            if (lpmaster == null)
            {
                return NotFound();
            }
            var subject = _mapper.Map<SubjectDto>(lpmaster);
            return Ok(subject);
        }

        [HttpPost]
        public async Task<ActionResult<SubjectDto>> Post(SubjectDto subjectDto)
        {
            var lpmaster = _mapper.Map<Lpmaster>(subjectDto);
            await _service.AddAsync(lpmaster);
            return CreatedAtAction(nameof(Get), new { id = lpmaster.Id }, _mapper.Map<SubjectDto>(lpmaster));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, SubjectDto subjectDto)
        {
            var lpmaster = _mapper.Map<Lpmaster>(subjectDto);
            if (id != lpmaster.Id)
            {
                return BadRequest();
            }
            await _service.UpdateAsync(lpmaster);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var subject = await _service.GetLpmasterAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            await _service.DeleteAsync(subject);
            return NoContent();
        }
    }
}
