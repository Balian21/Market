using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace iBlogs.Data
{
    //[Class(Table = "blogger")]
    //public class Blogger
    //{
    //    [Id(0, Column = "Id", TypeType = typeof(string), Name = "Id")]
    //    [Generator(1, Class = "uuid.hex")]
    //    public virtual string Id { get; protected set; }

    //    [Property]
    //    public virtual string Login { get; set; }

    //    IList<Article> articles = new List<Article>();

    //    [Bag(0, Cascade = "all", Lazy = CollectionLazy.True)]
    //    [Key(1, Column = "BlogerId")]
    //    [OneToMany(2, ClassType = typeof(Article))]
    //    public virtual IList<Article> Articles { get { return articles; } set { articles = value; } }
    //}
}