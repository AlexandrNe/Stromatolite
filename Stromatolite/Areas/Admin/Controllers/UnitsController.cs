﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stromatolite.Models;
using Stromatolite.DAL;

namespace Stromatolite.Areas.Admin.Controllers
{
    public class UnitsController : Controller
    {
        private DataAccessLayer DAL = new DataAccessLayer();

        // GET: Admin/Units
        //public async Task<ActionResult> Index()
        //{
        //    return View(await db.Units.ToListAsync());
        //}

        public PartialViewResult _Index()
        {
            var units = DAL.uof.UnitRepository.Get();
            return PartialView(units);
        }

        // GET: Admin/Units/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Unit unit = await db.Units.FindAsync(id);
        //    if (unit == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(unit);
        //}

        // GET: Admin/Units/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Units/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "UnitID,Title")] Unit unit)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Units.Add(unit);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }

        //    return View(unit);
        //}

        // GET: Admin/Units/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Unit unit = await db.Units.FindAsync(id);
        //    if (unit == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(unit);
        //}

        // POST: Admin/Units/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "UnitID,Title")] Unit unit)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(unit).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(unit);
        //}

        // GET: Admin/Units/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Unit unit = await db.Units.FindAsync(id);
        //    if (unit == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(unit);
        //}

        // POST: Admin/Units/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Unit unit = await db.Units.FindAsync(id);
        //    db.Units.Remove(unit);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

       
    }
}
