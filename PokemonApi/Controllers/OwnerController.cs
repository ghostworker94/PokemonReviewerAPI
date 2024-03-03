using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOwner _ownerRepository;
        public OwnerController(IOwner ownerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _ownerRepository = ownerRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Owner>))]
        public ActionResult GetOwners()
        {
            var owners = _mapper.Map<List<OwnerDto>>(_ownerRepository.GetOwners());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(owners);
        }
        [HttpGet("{ownerId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Owner>))]
        [ProducesResponseType(400)]
        public ActionResult<Owner> GetOwner(int ownerId)
        {
            if (!_ownerRepository.OwnerExists(ownerId))
            {
                return NotFound();
            }
            var owner = _mapper.Map<OwnerDto>(_ownerRepository.GetOwner(ownerId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(owner);
        }
        [HttpGet("pokemon/owner/{ownerId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Owner>))]
        [ProducesResponseType(400)]

        public ActionResult<List<Pokemon>> GetPokemonByOwner(int ownerId)
        {
            if (!_ownerRepository.OwnerExists(ownerId))
            {
                return NotFound();
            }
            var pokemon = _mapper.Map<List<PokemonDto>>(_ownerRepository.GetPokemonByOwner(ownerId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemon);
        }

        [HttpGet("pokemon/{pokeId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Owner>))]
        [ProducesResponseType(400)]
        public ActionResult<List<Owner>> GetOwnerOfAPokemon(int pokeId)
        {
            var pokemon = _mapper.Map<OwnerDto>(_ownerRepository.GetOwnerOfAPokemon(pokeId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemon);
        }
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public ActionResult CreateOwner([FromBody] OwnerDto ownerCreate)
        {
            if (ownerCreate == null)
            {
                return BadRequest(ModelState);
            }
            if (_ownerRepository.OwnerExists(ownerCreate.Id))
            {
                ModelState.AddModelError("", "Owner Exists");
                return StatusCode(404, ModelState);
            }
            var owner = _mapper.Map<Owner>(ownerCreate);
            if (!_ownerRepository.CreateOwner(owner))
            {
                ModelState.AddModelError("", $"Something went wrong saving this owner");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
        [HttpPut("{ownerId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult UpdateOwner(int ownerId, [FromBody] OwnerDto ownerUpdate)
        {
            if (ownerUpdate == null)
            {
                return BadRequest(ModelState);
            }
            if (ownerId != ownerUpdate.Id)
            {
                return BadRequest(ModelState);
            }
            if (!_ownerRepository.OwnerExists(ownerId))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var owner = _mapper.Map<Owner>(ownerUpdate);
            if (!_ownerRepository.UpdateOwner(owner))
            {
                ModelState.AddModelError("", $"Something went wrong while updating owner {owner.FirstName} {owner.LastName}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
        [HttpDelete("{ownerId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult DeleteOwner(int ownerId)
        {
            if (!_ownerRepository.OwnerExists(ownerId))
            {
                return NotFound();
            }
            var owner = _ownerRepository.GetOwner(ownerId);
            if (!_ownerRepository.DeleteOwner(owner))
            {
                ModelState.AddModelError("", $"Something went wrong while deleting owner: {owner.FirstName} {owner.LastName}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
    }
}