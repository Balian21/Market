using iBlogs.Data;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iBlogs.Web
{
    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                Blogger blogger = session.Get<Blogger>(blogerId.ToString());
                IList<Article> articles = blogger.Articles;
                UserArticles.DataSource = articles;
                UserArticles.DataBind();
            }
        }
    }
}