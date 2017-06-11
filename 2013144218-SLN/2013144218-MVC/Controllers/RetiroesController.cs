using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2013144218_ENT.Entidades;
using _2013144218_PER;
using _2013144218_ENT.IRepositories;

namespace _2013144218_MVC.Controllers
{
    public class RetiroesController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;
        public RetiroesController()
        {

        }

        public RetiroesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Retiroes
        public ActionResult Index()
        {
            //  var retiros = db.Retiros.Include(r => r.ATM).Include(r => r.Dispensadorefectivo).Include(r => r.Pantalla).Include(r => r.Teclado);
            return View(_UnityOfWork.Retiro.GetAll());
        }

        // GET: Retiroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Retiro retiro = db.Retiros.Find(id);
            Retiro retiro = _UnityOfWork.Retiro.Get(id);
            if (retiro == null)
            {
                return HttpNotFound();
            }
            return View(retiro);
        }

        // GET: Retiroes/Create
        public ActionResult Create()
        {
            // ViewBag.idRetiro = new SelectList(db.ATMs, "idATM", "idATM");
            //ViewBag.idRetiro = new SelectList(db.DispensadorEfectivo_s, "idDispensadorefectivo", "idDispensadorefectivo");
            //ViewBag.idRetiro = new SelectList(db.Pantallas, "idPantalla", "idPantalla");
            //ViewBag.idRetiro = new SelectList(db.Teclados, "idTeclado", "Marca");
            return View();
        }

        // POST: Retiroes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRetiro,Monto,idATM,idTeclado,idPantalla,idDispensadorEfectivo")] Retiro retiro)
        {
            if (ModelState.IsValid)
            {
                // db.Retiros.Add(retiro);
                _UnityOfWork.Retiro.Add(retiro);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.idRetiro = new SelectList(db.ATMs, "idATM", "idATM", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.DispensadorEfectivo_s, "idDispensadorefectivo", "idDispensadorefectivo", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.Pantallas, "idPantalla", "idPantalla", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.Teclados, "idTeclado", "Marca", retiro.idRetiro);
            return View(retiro);
        }

        // GET: Retiroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Retiro retiro = db.Retiros.Find(id);
            Retiro retiro = _UnityOfWork.Retiro.Get(id);
            if (retiro == null)
            {
                return HttpNotFound();
            }
            // ViewBag.idRetiro = new SelectList(db.ATMs, "idATM", "idATM", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.DispensadorEfectivo_s, "idDispensadorefectivo", "idDispensadorefectivo", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.Pantallas, "idPantalla", "idPantalla", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.Teclados, "idTeclado", "Marca", retiro.idRetiro);
            return View(retiro);
        }

        // POST: Retiroes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRetiro,Monto,idATM,idTeclado,idPantalla,idDispensadorEfectivo")] Retiro retiro)
        {
            if (ModelState.IsValid)
            {
                //  db.Entry(retiro).State = EntityState.Modified;
                _UnityOfWork.StateModified(retiro);
                // db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            //  ViewBag.idRetiro = new SelectList(db.ATMs, "idATM", "idATM", retiro.idRetiro);
            //  ViewBag.idRetiro = new SelectList(db.DispensadorEfectivo_s, "idDispensadorefectivo", "idDispensadorefectivo", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.Pantallas, "idPantalla", "idPantalla", retiro.idRetiro);
            // ViewBag.idRetiro = new SelectList(db.Teclados, "idTeclado", "Marca", retiro.idRetiro);
            return View(retiro);
        }

        // GET: Retiroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //  Retiro retiro = db.Retiros.Find(id);
            Retiro retiro = _UnityOfWork.Retiro.Get(id);
            if (retiro == null)
            {
                return HttpNotFound();
            }
            return View(retiro);
        }

        // POST: Retiroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Retiro retiro = db.Retiros.Find(id);
            Retiro retiro = _UnityOfWork.Retiro.Get(id);

            // db.Retiros.Remove(retiro);
            _UnityOfWork.Retiro.Delete(retiro);
            // db.SaveChanges();
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
