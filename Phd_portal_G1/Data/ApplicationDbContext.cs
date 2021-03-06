using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Phd_portal_G1.Models;

namespace Phd_portal_G1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<UserInfo> Userinfo { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SubmissionDetails> Submissions { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

           
        }
    }
}
