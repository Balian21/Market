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
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                if (!string.IsNullOrEmpty(TextBox1.Text))
                {
                    Blogger blogger = session.CreateCriteria<Blogger>()
                        .Add(Expression.Eq("Login", TextBox1.Text))
                        .UniqueResult<Blogger>();
                    if (blogger != null)
                    {
                        Label2.Visible = true;
                        Label2.Text = "This Login is good";

                        Session.Add("BloggerId", blogger.Id);
                    }
                    else
                    {
                        Label2.Text = "This Login does not exist";
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