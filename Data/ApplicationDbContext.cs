/******************************************************************************************************************************
 * Student Name: Dakota Parrish
 * Project Name: NETD3202 Lab 5 - Communication Activity
 * Course Code: NETD3202
 * Date: December 12, 2020
 * Purpose: The purpose of this class is to be the context class for the whole web application. It includes everything from the 
 * previous lab using the entity framework and adds what was recently learned using the identity framework. 
 * ***************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NETD3202Lab5_CommActivity.Models;

namespace NETD3202Lab5_CommActivity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VideoGame> VideoGames { get; set; }

        //Sets another database/table for the VideoGameDetails class. Named AdditionalGameDetails.
        public DbSet<VideoGameDetails> AdditionalGameDetails { get; set; }
    }
}
