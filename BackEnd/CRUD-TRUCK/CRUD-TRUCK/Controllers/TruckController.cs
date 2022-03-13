using AutoMapper;
using CRUD_TRUCK.DTOs;
using CRUD_TRUCK.Models;
using CRUD_TRUCK.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_TRUCK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public TruckController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TruckDto>> Get()
        {
            var truck = _uow.TruckBll.Get().ToList();
            var TruckDto = _mapper.Map<List<TruckDto>>(truck);
            return TruckDto;
        }


        [HttpGet("{id}", Name = "Gettruck")]
        public ActionResult<TruckDto> Get(int id)
        {
            var truck = _uow.TruckBll.GetById(x => x.TruckId == id);
            if (truck == null)
            {
                return NotFound();
            }
            var TruckDto = _mapper.Map<TruckDto>(truck);
            return TruckDto;

        }

        [HttpPost]
        public ActionResult Post([FromBody] TruckDto truckDto)
        {
            var truck = _mapper.Map<Truck>(truckDto);

            _uow.TruckBll.Add(truck);
            _uow.Commit();

            var TruckDTO = _mapper.Map<TruckDto>(truck);

            return new CreatedAtRouteResult("GetTruck",
                new { id = truck.TruckId }, TruckDTO);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TruckDto truckDto)
        {
            truckDto.TruckId = id;
            if (id != truckDto.TruckId)
            {
                return BadRequest();
            }

            var truck = _mapper.Map<Truck>(truckDto);

            _uow.TruckBll.Update(truck);
            _uow.Commit();
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult<TruckDto> Delete(int id)
        {
            var truck = _uow.TruckBll.GetById(p => p.TruckId == id);

            if (truck == null)
            {
                return NotFound();
            }
            _uow.TruckBll.Delete(truck);
            _uow.Commit();

            var truckDTO = _mapper.Map<TruckDto>(truck);

            return truckDTO;
        }
    }
}
