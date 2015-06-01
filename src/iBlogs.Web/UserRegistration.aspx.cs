using iBlogs.Data;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEnvironment = NHibernate.Cfg.Environment;

namespace iBlogs.Web
{
    public partial class UserRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RegistrationButton_Click(object sender, EventArgs e)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                if (!string.IsNullOrEmpty(TextBox1.Text))
                {
                    Blogger blogger = session.CreateCriteria<Blogger>()
                        .Add(Expression.Eq("Login", TextBox1.Text))
                        .UniqueResult<Blogger>();
                    if (blogger == null)
                    {
                        Blogger newBloger = new Blogger();
                        newBloger.Login = TextBox1.Text;
                        Label2.Visible = true;
                        Label2.Text = "This Login is good";
                        session.Save(newBloger);
                        session.Flush();
                    }
                    else
                    {
                        Label2.Text = "This Login already exists";
                        Label2.Visible = true;
                    }
                }
                else
                {
                    Label2.Text = "Enter login";
                    Label2.Visible = true;
                }

            }
        }
    }
}