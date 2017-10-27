using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Ceramics.Data;

namespace Ceramics.Migrations
{
    [DbContext(typeof(ClassContext))]
    partial class ClassContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ceramics.Models.DataModels.ClassModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsCancelled");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Ceramics.Models.DataModels.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClassModelId");

                    b.Property<string>("Email");

                    b.Property<bool>("GoodStanding");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("ClassModelId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Ceramics.Models.DataModels.StudentModel", b =>
                {
                    b.HasOne("Ceramics.Models.DataModels.ClassModel")
                        .WithMany("Students")
                        .HasForeignKey("ClassModelId");
                });
        }
    }
}
