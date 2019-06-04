using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using movil1.Backend.Models;
using movil1.Common.Models;

namespace movil1.Backend.Controllers
{
    public class AlimentsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Aliments
        public async Task<ActionResult> Index()
        {
            return View(await db.Aliments.ToListAsync());
        }

        // GET: Aliments/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aliment aliment = await db.Aliments.FindAsync(id);
            if (aliment == null)
            {
                return HttpNotFound();
            }
            return View(aliment);
        }

        // GET: Aliments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aliments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdAliment,Alimento,Calorias,Grasas,Proteinas,Carbohidratos,IdPorcion")] Aliment aliment)
        {
            if (ModelState.IsValid)
            {
                db.Aliments.Add(aliment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(aliment);
        }

        // GET: Aliments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aliment aliment = await db.Aliments.FindAsync(id);
            if (aliment == null)
            {
                return HttpNotFound();
            }
            return View(aliment);
        }

        // POST: Aliments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdAliment,Alimento,Calorias,Grasas,Proteinas,Carbohidratos,IdPorcion")] Aliment aliment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aliment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(aliment);
        }

        // GET: Aliments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aliment aliment = await db.Aliments.FindAsync(id);
            if (aliment == null)
            {
                return HttpNotFound();
            }
            return View(aliment);
        }

        // POST: Aliments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Aliment aliment = await db.Aliments.FindAsync(id);
            db.Aliments.Remove(aliment);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
