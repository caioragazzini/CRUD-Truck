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
    public class TruckModelController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public TruckModelController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TruckModelDto>> Get()
        {
            var truckModel = _uow.TruckModelBll.Get().ToList();
            var truckModelDto = _mapper.Map<List<TruckModelDto>>(truckModel);
            return truckModelDto;
        }


        [HttpGet("{id}", Name = "GetTruckModel")]
        public ActionResult<TruckModelDto> Get(int id)
        {
            var truckModel = _uow.TruckModelBll.GetById(x => x.TruckModelId == id);
            if (truckModel == null)
            {
                return NotFound();
            }
            var truckModelDto = _mapper.Map<TruckModelDto>(truckModel);
            return truckModelDto;

        }

        [HttpPost]
        public ActionResult Post([FromBody] TruckModelDto truckModelDto)
        {
            var truckModel = _mapper.Map<TruckModel>(truckModelDto);

            _uow.TruckModelBll.Add(truckModel);
            _uow.Commit();

            var truckModelDTO = _mapper.Map<TruckModelDto>(truckModel);

            return new CreatedAtRouteResult("GetTruckModel",
                new { id = truckModel.TruckModelId}, truckModelDTO);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TruckModelDto truckModelDto)
        {
            truckModelDto.TruckModelId = id;
            if (id != truckModelDto.TruckModelId)
            {
                return BadRequest();
            }

            var truckModel= _mapper.Map<TruckModel>(truckModelDto);

            _uow.TruckModelBll.Update(truckModel);
            _uow.Commit();
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult<TruckModelDto> Delete(int id)
        {
            var truckModel = _uow.TruckModelBll.GetById(p => p.TruckModelId == id);

            if (truckModel == null)
            {
                return NotFound();
            }
            _uow.TruckModelBll.Delete(truckModel);
            _uow.Commit();

            var truckModelDto = _mapper.Map<TruckModelDto>(truckModel);

            return truckModelDto;
        }




    }
}
