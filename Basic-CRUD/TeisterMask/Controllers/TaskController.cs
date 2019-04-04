﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TeisterMask.Data;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new TeisterMaskDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            using (var db = new TeisterMaskDbContext())
            {
                return this.View();
            }
        }

        [HttpPost]
        public IActionResult Create(string title, string status)
        {
            if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(status))
            {
                return RedirectToAction("Index");
            }
            Task task = new Task
            {
                Title = title,
                Status = status
            };
            using (var db = new TeisterMaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == id);
                if (taskToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(taskToEdit);

            }
        }
        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new TeisterMaskDbContext())
            {
                var taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == task.Id);
                
                taskToEdit.Title = task.Title;
                taskToEdit.Status = task.Status;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.FirstOrDefault(t => t.Id == id);
                if(taskToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(taskToDelete);
            }            
        }
        [HttpPost]
        public IActionResult Delete(Task task)
        {
            //if (!ModelState.IsValid)
            //{
            //    return RedirectToAction("Index");
            //}
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.FirstOrDefault(t => t.Id == task.Id);
                db.Tasks.Remove(taskToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");    
        }
    }
}
