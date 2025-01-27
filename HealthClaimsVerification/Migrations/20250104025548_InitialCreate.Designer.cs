﻿// <auto-generated />
using HealthClaimsVerification.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthClaimsVerification.Migrations
{
    [DbContext(typeof(HealthClaimsContext))]
    [Migration("20250104025548_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HealthClaimsVerification.Models.HealthClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ConfidenceScore")
                        .HasColumnType("float");

                    b.Property<int>("InfluencerId")
                        .HasColumnType("int");

                    b.Property<string>("VerificationStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InfluencerId");

                    b.ToTable("HealthClaims");
                });

            modelBuilder.Entity("HealthClaimsVerification.Models.Influencer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Followers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Influencers");
                });

            modelBuilder.Entity("HealthClaimsVerification.Models.HealthClaim", b =>
                {
                    b.HasOne("HealthClaimsVerification.Models.Influencer", "Influencer")
                        .WithMany("HealthClaims")
                        .HasForeignKey("InfluencerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Influencer");
                });

            modelBuilder.Entity("HealthClaimsVerification.Models.Influencer", b =>
                {
                    b.Navigation("HealthClaims");
                });
#pragma warning restore 612, 618
        }
    }
}
