using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Office.Models;

namespace Office.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u=>u.Email==user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Users.Add(user);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return RedirectToAction("Home");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost("login")]
        public IActionResult Login(LoginUser user)
        {
            if(ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u=>u.Email==user.LoginEmail);
                if(userInDb==null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);
                if(result==0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return RedirectToAction("Home");
                }
            }
            return View("Index");
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpGet("Home")]
        public IActionResult Home()
        {
            ViewBag.Users = _context.Users
                .ToList();
            if(HttpContext.Session.GetInt32("UserId")!=null){
                ViewBag.User = _context.Users
                    .FirstOrDefault(u=>u.UserId==HttpContext.Session.GetInt32("UserId"));
            }
            List<Todo> Activities = _context.Todos
                .Include(a=>a.Supporters)
                .Where(a=>a.Completed==false)
                .OrderBy(a=>a.DueDate)
                .ToList();
            return View("Home", Activities);
        
        }
        [HttpGet("Todoform")]
        public IActionResult TodoForm()
        {
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                ViewBag.User = HttpContext.Session.GetInt32("UserId");
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost("createTodo")]
        public IActionResult NewTodo(Todo newTodo)
        {
            if(ModelState.IsValid)
            {
                _context.Todos.Add(newTodo);
                _context.SaveChanges();
                return Redirect("Home");
            }
            else
            {
                return View("TodoForm");
            }
        }
        [HttpPost("rsvp")]
        public IActionResult Rsvp(int UserId, int TodoId)
        {
            Todo TheTodo = _context.Todos
                .FirstOrDefault(e=>e.TodoId==TodoId);
            if(UserId==1)
            {
                TheTodo.Completed = true;
                TheTodo.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return Redirect("Home");
            }
            var olduser = _context.Participations
                .FirstOrDefault(r=>r.UserId==UserId&&r.TodoId==TodoId);
            if(olduser!=null){
                _context.Participations.Remove(olduser);
                _context.SaveChanges();
                return Redirect("Home");
            }
            Participation newRsvp = new Participation();
            newRsvp.UserId = UserId;
            newRsvp.TodoId = TodoId;
            _context.Participations.Add(newRsvp);
            _context.SaveChanges();
            return Redirect("Home");
        }

        [HttpGet("Todo/{TodoId}")]
        public IActionResult TodoDetails(int TodoId)
        {   
            var activity = _context.Todos
                .Include(e=>e.Supporters)
                .ThenInclude(a=>a.User)
                .FirstOrDefault(e=>e.TodoId==TodoId);
            ViewBag.User = _context.Users
                .FirstOrDefault(u=>u.UserId==HttpContext.Session.GetInt32("UserId"));
            ViewBag.Giver = _context.Users
                .FirstOrDefault(u=>u.UserId==activity.UserId);
            return View(activity);
        }
        [HttpPost("rsvpdetails")]
        public IActionResult RsvpDetails(int UserId, int TodoId)
        {
            var TheTodo = _context.Todos
                .FirstOrDefault(e=>e.TodoId==TodoId);
            if(UserId==1)
            {
                TheTodo.Completed = true;
                return Redirect("Home");
            }
            var olduser = _context.Participations
                .FirstOrDefault(r=>r.UserId==UserId&&r.TodoId==TodoId);
            if(olduser!=null){
                _context.Participations.Remove(olduser);
                _context.SaveChanges();
                return Redirect("Todo/"+TodoId);
            }
            Participation newRsvp = new Participation();
            newRsvp.UserId = UserId;
            newRsvp.TodoId = TodoId;
            _context.Participations.Add(newRsvp);
            _context.SaveChanges();
            return Redirect("Todo/"+TodoId);
        }
        [HttpGet("progress")]
        public IActionResult Progress()
        {
            ViewBag.Complete = _context.Todos
                .Where(t=>t.Completed==true)
                .Where(t=>t.UpdatedAt>DateTime.Now.AddDays(-7))
                .OrderBy(t=>t.UpdatedAt)
                .ToList();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
