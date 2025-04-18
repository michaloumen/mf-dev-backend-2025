﻿using mf_dev_backend_2025.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2025.Controllers
{
    [Authorize]
    public class VeículosController : Controller
    {
        private readonly AppDbContext _context;
        public VeículosController(AppDbContext context)
        {
            _context = context;
        }

        // cada função aqui no controller é uma página
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veículos.ToListAsync();
            return View(dados);
        }

        // get de veículos
        public IActionResult Create()
        {
            return View();
        }

        // post de veículos
        [HttpPost]
        public async Task<IActionResult> Create(Veículo veículo)
        {
            if (ModelState.IsValid)
            {
                _context.Veículos.Add(veículo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(veículo);
        }

        // edição
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var dados = await _context.Veículos.FindAsync(id);
            if (dados == null) return NotFound();
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Veículo veículo)
        {
            // isso é porque o id do veículo não pode ser alterado
            if (id != veículo.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Veículos.Update(veículo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var dados = await _context.Veículos.FindAsync(id);
            if (dados == null) return NotFound();
            return View(dados);
        }

        // pra fazer o delete, antes tem que recuperar os dados que é igual o details
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var dados = await _context.Veículos.FindAsync(id);
            if (dados == null) return NotFound();
            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null) return NotFound();
            var dados = await _context.Veículos.FindAsync(id);
            if (dados == null) return NotFound();
            _context.Veículos.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Relatorio(int? id) 
        {
            if (id == null) return NotFound();
            var veiculo = await _context.Veículos.FindAsync(id);
            if(veiculo == null) return NotFound();
            var consumos = await _context.Consumos
                .Where(c => c.VeiculoId == id)
                .OrderByDescending(c => c.Data)
                .ToListAsync();
            decimal total = consumos.Sum(c => c.Valor);
            ViewBag.Veiculo = veiculo;
            ViewBag.Total = total;
            return View(consumos);
        }
    }
}
