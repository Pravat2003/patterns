using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Domain.Models;

namespace RepositoryPattern.Infrastructure.Repositories
{
    public class RoleRepository:Repository<Role>
    {
        public RoleRepository(SchoolContext context):base(context)
        {

        }
        public override Role Add(Role entity)
        {
            return base.Add(entity);
        }

        public override IEnumerable<Role> GetAll()
        {
            return base.GetAll();
        }

        public override Role Remove(Role entity)
        {
            return base.Remove(entity);
        }
    }
}
