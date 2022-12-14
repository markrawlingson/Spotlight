// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spotlight.Persistence;

#nullable disable

namespace Spotlight.Persistence.Migrations
{
    [DbContext(typeof(SpotlightContext))]
    [Migration("20221213043407_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Spotlight.Entities.Controller", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShowId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Controllers");
                });

            modelBuilder.Entity("Spotlight.Entities.Model", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShowId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Spotlight.Entities.Preference", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("Spotlight.Entities.Sequence", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShowId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Sequences");
                });

            modelBuilder.Entity("Spotlight.Entities.Show", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("HouseImage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("Spotlight.Entities.Controller", b =>
                {
                    b.HasOne("Spotlight.Entities.Show", "Show")
                        .WithMany("Controllers")
                        .HasForeignKey("ShowId");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Spotlight.Entities.Model", b =>
                {
                    b.HasOne("Spotlight.Entities.Show", "Show")
                        .WithMany("Models")
                        .HasForeignKey("ShowId");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Spotlight.Entities.Sequence", b =>
                {
                    b.HasOne("Spotlight.Entities.Show", "Show")
                        .WithMany("Sequences")
                        .HasForeignKey("ShowId");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Spotlight.Entities.Show", b =>
                {
                    b.Navigation("Controllers");

                    b.Navigation("Models");

                    b.Navigation("Sequences");
                });
#pragma warning restore 612, 618
        }
    }
}
