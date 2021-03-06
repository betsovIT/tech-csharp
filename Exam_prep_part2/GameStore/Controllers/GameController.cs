﻿using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;
using GameStore.Data;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var allGames = db.Games.ToList();
                return View(allGames);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            Game newGame = new Game();

            newGame.Name = game.Name;
            newGame.Dlc = game.Dlc;
            newGame.Price = game.Price;
            newGame.Platform = game.Platform;                        

            using (var db = new GameStoreDbContext())
            {
                db.Games.Add(newGame);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(t => t.Id == id);
                if (gameToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(gameToEdit);
            }
                
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new GameStoreDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(t => t.Id == game.Id);
                gameToEdit.Name = game.Name;
                gameToEdit.Dlc = game.Dlc;
                gameToEdit.Price = game.Price;
                gameToEdit.Platform = game.Platform;
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToDelete = db.Games.FirstOrDefault(t => t.Id == id);
                if (gameToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(gameToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameToDelete = db.Games.FirstOrDefault(t => t.Id == game.Id);
                if (gameToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                db.Remove(gameToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}