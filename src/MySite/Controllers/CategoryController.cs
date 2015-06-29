using FluentNHibernate;
using Model;
using NHibernate;
using NHibernate.Linq;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Show()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var categories = session.Query<Category>()
                                    .Where(p => p.Parent == null)
                                    .ToList();
                return View(categories);
            }
        }

        public ActionResult ShowItems(int? id = null, int page = 1)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var childrenCategories = session.Query<Category>().Where(c => c.Parent.Id == id).ToList(); // проверка есть ли у категории дочерние элементы
                var rootCategory = session.Get<Category>(id);
                ViewBag.RootId = rootCategory.Id;

                int pageSize = 5;

                if (childrenCategories.Count != 0)
                {
                    return View("Show", childrenCategories); // вывод представления с дочерними категориями
                }
                else
                {
                    return View(CurrentProducts(id).ToPagedList(page, pageSize)); // выводим постранично продукты выбранной категории // избавиться от ToPagedList
                }
            }
        }

        public IList<Product> CurrentProducts(int? id) //возвращает продукты выбранной категории
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session.Query<Product>()
                                .Where(p => p.Category.Id == id)
                                .ToList();
                return products;
            }
        }

        public FileContentResult GetImage(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var category = session.Query<Category>()
                                .FirstOrDefault(p => p.Id == id);
                if (category != null && category.ImageMimeType != null)
                {
                    return File(category.ImageData, category.ImageMimeType);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}