using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TelerikRazorTest.Models;

namespace TelerikRazorTest.Controllers
{
    public class DataController : Controller
    {
        private readonly IDbConnection _conn;

        public DataController(IDbConnection conn)
        {
            _conn = conn;
        }

        public IActionResult Index()
        {
            IEnumerable<auth_Users> list = this._conn.Query<auth_Users>("Select * from auth_Users");
            return View(list);
        }
    }
}
