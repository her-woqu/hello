using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XireManager.Models;

namespace XireManager.Migrations.Seeds
{
    public class ActionLinkCreator
    {
        private readonly XireManager.Models.XireManagerEntities _context;

        public ActionLinkCreator(XireManager.Models.XireManagerEntities context)
        {
            _context = context;
        }

        public void Seed()
        {
            var initialActionLinks = new List<ActionLinks>
            {
            new ActionLinks
            {
                Name = "主页",
                Controller = "Home",
                Action = "index",
            }
          };
            foreach (var action in initialActionLinks)
            {
                if (_context.ActionLinks.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.ActionLinks.Add(action);
            }
            _context.SaveChanges();
        }
    }
}
