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
    public class CuentasController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;

        public CuentasController()
        {

        }

        public CuentasController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }



        // GET: Cuentas
        public ActionResult Index()
        {
            // var cuentas = db.Cuentas.Include(c => c.BaseDatos);
            return View(_UnityOfWork.Cuenta.GetAll());
        }

        // GET: Cuentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cuenta cuenta = db.Cuentas.Find(id);
            Cuenta cuenta = _UnityOfWork.Cuenta.Get(id);
            if (cuenta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta);
        }

        // GET: Cuentas/Create
        public ActionResult Create()
        {
            //ViewBag.idBaseDatos = new SelectList(db.BaseDatos_s, "idBaseDatos", "Administrador");
            return View();
        }

        // POST: Cuentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCuenta,NumeroCuenta,pin,saldo,idBaseDatos")] Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                // db.Cuentas.Add(cuenta);
                _UnityOfWork.Cuenta.Add(cuenta);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.idBaseDatos = new SelectList(db.BaseDatos_s, "idBaseDatos", "Administrador", cuenta.idBaseDatos);
            return View(cuenta);
        }

        // GET: Cuentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           // Cuenta cuenta = db.Cuentas.Find(id);
            Cuenta cuenta = _UnityOfWork.Cuenta.Get(id);
            if (cuenta == null)
            {
                return HttpNotFound();
            }
            //ViewBag.idBaseDatos = new SelectList(db.BaseDatos_s, "idBaseDatos", "Administrador", cuenta.idBaseDatos);
            return View(cuenta);
        }

        // POST: Cuentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCuenta,NumeroCuenta,pin,saldo,idBaseDatos")] Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(cuenta).State = EntityState.Modified;

                _UnityOfWork.StateModified(cuenta);

                // db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
           // ViewBag.idBaseDatos = new SelectList(db.BaseDatos_s, "idBaseDatos", "Administrador", cuenta.idBaseDatos);
            return View(cuenta);
        }

        // GET: Cuentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //  Cuenta cuenta = db.Cuentas.Find(id);
            Cuenta cuenta = _UnityOfWork.Cuenta.Get(id);
            if (cuenta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta);
        }

        // POST: Cuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // Cuenta cuenta = db.Cuentas.Find(id);
            Cuenta cuenta = _UnityOfWork.Cuenta.Get(id);
            // db.Cuentas.Remove(cuenta);
            _UnityOfWork.Cuenta.Delete(cuenta);
            //db.SaveChanges();
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // db.Dispose();
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
