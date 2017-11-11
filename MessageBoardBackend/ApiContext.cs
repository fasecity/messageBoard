using MessageBoardBackend.Models;
using MessageBoardBackend.MyModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend
{
    
    public class ApiContext:DbContext
    {

        public static string CONNSTRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MessageBoardBackend_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }//---needs migration
        public DbSet<Staff> Staffs { get; set; }//--> staff subsystem Hackathon Model


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(CONNSTRING);
            

        }

    }
}
