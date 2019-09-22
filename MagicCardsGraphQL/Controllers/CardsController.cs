using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicCardsGraphQL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicCardsGraphQL.Controllers
{
    [Route("api/cards")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly CardsRepository _cardsRepository;

        public CardsController(CardsRepository cardsRepository)
        {
            _cardsRepository = cardsRepository;
        }

        [HttpGet()]
        public JsonResult GetCards()
        {
            return new JsonResult(_cardsRepository.GetAll());
        }
    }
}