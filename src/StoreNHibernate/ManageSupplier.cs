using Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreNHibernate
{
    public class ManageSupplier
    {
        public void AddSupplier(Supplier supplier)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(supplier);
                    transaction.Commit();
                }
            }
        }

        public void DeleteSupplier(Supplier supplier)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(supplier);
                    transaction.Commit();
                }
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(supplier);
                    transaction.Commit();
                }
            }
        }
    }
}