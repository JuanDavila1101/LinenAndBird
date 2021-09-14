﻿using LinenAndBird.DataAccess;
using LinenAndBird.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinenAndBird.Controllers
{
  [Route("api/birds")]
  [ApiController]
  public class BirdsController : ControllerBase
  {

    BirdRepository _repo;
    public BirdsController()
    {
      _repo = new BirdRepository();
    }

    [HttpGet]
    public IEnumerable<Bird> GetAllBirds()
    {
      return _repo.GetAll();
    }

    [HttpPost]
    public IActionResult AddBird(Bird newBird)
    {
      if (string.IsNullOrEmpty(newBird.Name) || string.IsNullOrEmpty(newBird.Color))
      {
        return BadRequest("Name and Color are required fields");
      }
      _repo.Add(newBird);
      return Ok();
    }
  }
}
