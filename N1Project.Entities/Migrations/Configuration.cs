namespace N1Project.Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<N1Project.Entities.Context.N1ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "N1Project.Entities.Context.N1ProjectContext";
        }

        protected override void Seed(N1Project.Entities.Context.N1ProjectContext context)
        {

        }
    }
}
