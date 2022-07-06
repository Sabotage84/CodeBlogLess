using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace EFLess
{
    public class MyDBContext : DbContext
    {
        protected MyDBContext(): base("DbConnectionString")
        {
        }
    }
}
