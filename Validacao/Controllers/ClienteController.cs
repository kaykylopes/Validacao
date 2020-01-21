﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacao.Models;

namespace Validacao.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index( Cliente cliente)
        {
            //if (string.IsNullOrEmpty(cliente.Nome))
            //    ModelState.AddModelError("Nome", "Nome é obrigatório");

            //if (string.IsNullOrEmpty(cliente.Email))
            //    ModelState.AddModelError("Email", "Campo Email é obrigatorio");

            //if (string.IsNullOrEmpty(cliente.Telefone))
            //    ModelState.AddModelError("Telefone", "Campo Telefone é obrigatorio");

            //if (cliente.Idade == 0)
            //{
            //    ModelState.AddModelError("Idade","Idade é obrigatorio");
            //}
            //else
            //{
            //    if(cliente.Idade <= 21)
            //    {
            //        ModelState.AddModelError("Idade", "Idade informado deve ser maior que 21 anos");
            //    }
            //}


            if (!ModelState.IsValid)
            {
                return View(cliente);
            }
            else
            {
                return View("Validacao", cliente);
            }
        }


        public ActionResult Validacao(Cliente cliente)
        {
            return View(cliente);
        }
    }
}