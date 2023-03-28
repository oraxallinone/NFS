using Microsoft.AspNetCore.Mvc;
using NFS.WEB.Areas.CSharp.Data;
using NFS.WEB.Areas.CSharp.Models;

namespace NFS.WEB.Areas.CSharp.Controllers
{
    [Area("CSharp")]
    public class CSharpIronManController : Controller
    {
        public IActionResult ReturnWithClass()
        {
            DbStudent db = new DbStudent() { DbId = 1, DbName = "satya", DbAge = 29 };
            var firstStudent =  ReturnStudent(db);
            return View(firstStudent);
        }

        #region ---------------- methods ----------------------
        public Student ReturnStudent(DbStudent db)
        {
            return new Student() { Id = db.DbId, Name = db.DbName, Age = db.DbAge };
        
        }
        #endregion
    }
}
