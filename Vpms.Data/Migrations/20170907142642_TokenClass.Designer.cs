using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Vpms.Data;

namespace Vpms.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170907142642_TokenClass")]
    partial class TokenClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vpms.Model.Entities.Token", b =>
                {
                    b.Property<string>("TokenId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TokenExpireDate");

                    b.Property<string>("UserName");

                    b.HasKey("TokenId");

                    b.ToTable("Token");
                });

            modelBuilder.Entity("Vpms.Model.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
        }
    }
}
