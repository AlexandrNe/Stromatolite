﻿using Stromatolite.DAL;
using Stromatolite.Models;
using Stromatolite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Stromatolite.Controllers
{
    public class OffersController : Controller
    {
        private DataAccessLayer DAL = new DataAccessLayer();

        // GET: Offers
        //public ActionResult Index()
        //{
        //    OfferViewModel offerViewModel = new OfferViewModel();
        //    var offers = DAL.uof.OfferRepository.Get();
        //    return View(offerViewModel);
        //}

        //public ActionResult _Index()
        //{
        //    var offers = DAL.uof.OfferRepository.Get();
        //    return View(offers);
        //}

        // GET: Offers/Details/5
        public async Task<ActionResult> Details(string url)
        {
            if (url == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            url = DAL.ClearSpecChars(url);
            Offer offer = await DAL.uof.OfferRepository.GetByFieldAsync(f => f.Product.SEOurl == url);
            
            if (offer == null)
            {
                return HttpNotFound();
            }
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Details", offer);
            }
            ViewBag.Title = offer.Product.TitleFull;
            return View(offer);
        }

        // GET: Offers/Create
    
    }
}
