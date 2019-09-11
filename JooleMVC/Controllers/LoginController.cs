using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleDAL;
using JooleDAL.Entity;
using JooleDAL.Repositories;

namespace JooleMVC.Controllers
{
    public class LoginController : Controller
    {
        JooleDAL.Repositories.UnitOfWork obj = new JooleDAL.Repositories.UnitOfWork();
        //hjhfythfg
        //public LoginController(JooleDAL.Repositories.IUnitOfWork unitofwork)
        //{
        //    _uow = unitofwork;

        //    //_uow = JooleDAL.Repositories.IUnitOfWork(JEentity);
        //    //_uow = new JooleDAL.Repositories.UnitOfWork(new JooleDAL.Entity.JooleEntities);
        //}


        // GET: Login
        public ActionResult Index()
        {
            //uof.tblProduct.GetProducts.where();
            return View();
        }

        public ActionResult LoginPage()
        {
            //_uow.Products.GetAllProducts();
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
