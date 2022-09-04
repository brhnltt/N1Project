using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using N1Project.Entities.Context;
using N1Project.Entities.Interfaces;
using N1Project.Entities.Repositories;
using N1Project.Entities.Tables;
using N1Project.Entities.Validations;

namespace N1Project.Entities.Data_Access
{
    public class TanimDAL : EntityRepositoryBase<N1ProjectContext, Tanim,TanimValidator>
    {

    }
}
