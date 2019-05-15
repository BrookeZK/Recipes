﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes.Models;

namespace Recipes.Migrations
{
    [DbContext(typeof(RecipeContext))]
    partial class RecipeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Recipes.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Recipes.Models.Ingredient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("ingredients");
                });

            modelBuilder.Entity("Recipes.Models.Join", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("category_id");

                    b.Property<int>("ingredient_id");

                    b.Property<int>("recipe_id");

                    b.HasKey("id");

                    b.ToTable("join");
                });

            modelBuilder.Entity("Recipes.Models.Recipe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("instructions");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
