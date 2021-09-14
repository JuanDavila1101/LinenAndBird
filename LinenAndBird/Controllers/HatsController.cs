﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinenAndBird.Models;
using LinenAndBird.DataAccess;

namespace LinenAndBird.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class HatsController : ControllerBase
  {
    HatRepository _repo;
    public HatsController()
    {
      _repo = new HatRepository();
    }

    [HttpGet]
    public List<Hat> GetAllHats()
    {
      return _repo.GetAll();
    }

    //Paramater must match the argument in the Get method. Get method will utilize the URL to pass the style. 
    [HttpGet("styles/{style}")]
    public List<Hat> GetHatsByStyle(HatStyle style)
    {
      return _repo.GetByStyle(style);
    }

    [HttpPost]
    public void AddAHat(Hat newHat)
    {
      _repo.Add(newHat);
    }
  }
  ////  [Route("api/[controller]")]     // Exposed at this endpoint
  //[Route("api/hats")]
  //[ApiController]                 // An api controller, so it return json or xml 
  //public class HatsController : ControllerBase
  //{


  //  static List<HatModel> _hats = new List<HatModel>
  //   {
  //        new HatModel
  //        {
  //            Color = "Red",
  //            Designer = "Chesty Puller",
  //            Style = HatStyle.Normal
  //        },
  //        new HatModel
  //        {
  //            Color = "White",
  //            Designer = "Daniel Daly",
  //            Style = HatStyle.OpenBack
  //        },
  //    new HatModel
  //    {
  //      Color = "Blue",
  //      Designer = "Smedley Butler",
  //      Style = HatStyle.WhiteBrim
  //    }
  //    };



  //  [HttpGet]
  //  public List<HatModel> GetAllHats()
  //  {
  //    return _hats;
  //    // Model
  //    // they are for sending/ receive data to a consumer
  //    // set of properties so I can store data incide of a class

  //    //  return new List<HatModel>
  //    //  {
  //    //    new HatModel
  //    //     {
  //    //    Color = "Red",
  //    //  Designer = "Chesty Puller",
  //    //  Style = HatStyle.Normal
  //    //},
  //    //            new HatModel
  //    //     {
  //    //    Color = "White",
  //    //  Designer = "Daniel Daly",
  //    //  Style = HatStyle.OpenBack
  //    //},
  //    //new HatModel
  //    //     {
  //    //    Color = "Blue",
  //    //  Designer = "Smedley Butler",
  //    //  Style = HatStyle.WhiteBrim
  //    //},
  //    //  };
  //  }




  //  [HttpPost]
  //  public void AddHat(HatModel newHat)
  //  {
  //    _hats.Add(newHat);
  //  }


  //  //public List<HatModel> GetHatModels(HatStyle style)
  //  //{
  //  //  var matches = _hats.Where(hat => hat.Style == style);
  //  //  return matches.ToList();
  //  //}

  //  public IEnumerable<HatModel> GetHatModels(HatStyle style)
  //  {
  //    var matches = _hats.Where(hat => hat.Style == style);
  //    return matches;
  //  }





  //}

}
