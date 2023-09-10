﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {

        }

        private IEnumerable<Evento> evento = new Evento[]{
            new() {
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "São Paulo",
                Lote = "1º Lote",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                ImageURL = "foto1.png"
            },
            new() {
                EventoId = 2,
                Tema = ".Net 5 Avançado",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/mm/yyyy"),
                ImageURL = "foto2.png"
            },
            new() {
                EventoId = 3,
                Tema = "Angular 11 Avançado",
                Local = "Rio de Janeiro",
                Lote = "1º Lote",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.AddDays(6).ToString("dd/mm/yyyy"),
                ImageURL = "foto2.png"
            },
        };

        public IEnumerable<Evento> Evento { get => evento; set => evento = value; }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return Evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return Evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            Console.WriteLine($"Alteração do ID {id}");
            return $"Exemplo de PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete do id = {id}";
        }
    }
}