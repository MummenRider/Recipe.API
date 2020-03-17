﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RECIPE_API.Persistence;

namespace RECIPE_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200317012210_Requirement-Added")]
    partial class RequirementAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RECIPE_API.Domain.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 100,
                            CategoryName = "Chicken"
                        },
                        new
                        {
                            CategoryId = 101,
                            CategoryName = "Beef"
                        },
                        new
                        {
                            CategoryId = 102,
                            CategoryName = "Pork"
                        });
                });

            modelBuilder.Entity("RECIPE_API.Domain.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingridients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1000,
                            CategoryId = 100,
                            ImageUrl = "https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Filipino-Chicken-Adobo_EXPS_THAM18_212833_C11_09_8b.jpg",
                            Ingridients = "8 skinless chicken drumsticks, on the bone,1/3 cup low sodium soy sauce, use gluten-free soy sauce for GF and coconut aminos for Paleo,1 / 3 cup apple cider vinegar,1 small head of garlic, crushed,6 ground peppercorns,4 bay leaves,1 jalapeño, chopped(optional)",
                            Summary = "Chicken braised in vinegar and soy sauce with lots of garlic. This easy, savory chicken dish has become a staple in my home. As this simmers, your kitchen fills with an intoxicating sweet and sour aroma that will leave you anxious to eat.",
                            Title = "Chicken Adobo"
                        },
                        new
                        {
                            RecipeId = 1001,
                            CategoryId = 100,
                            ImageUrl = "https://i.pinimg.com/originals/1d/96/84/1d96844b21a7e547cb4a433cb41c1b4f.jpg",
                            Ingridients = "2 lbs chicken cut into serving pieces,2 tablespoons ginger minced,2 tablespoons garlic minced,3/4 cup lemongrass chopped,1 cup coconut vinegar,1/2 cup lemon or calamansi juice,1 tablespoon salt,1/4 cup brown sugar,1 cup lemon soda softdrink,1/2 tablespoon ground black pepper",
                            Summary = "Chicken Inasal is a grilled chicken dish and one of the well known Ilonggo dishes. This is done by marinating chicken pieces in a unique blend of spices and grilling them until done.",
                            Title = "Chicken Inasal"
                        });
                });

            modelBuilder.Entity("RECIPE_API.Domain.Models.Recipe", b =>
                {
                    b.HasOne("RECIPE_API.Domain.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
