﻿// <auto-generated />
using System;
using Walsun.Erp.PaymentService.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace Walsun.Erp.PaymentService.Migrations
{
    [DbContext(typeof(PaymentServiceDbContext))]
    [Migration("20211129051351_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Walsun.Erp.PaymentService.PaymentRequests.PaymentRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("BuyerId")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("FailReason")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PaymentRequests");
                });

            modelBuilder.Entity("Walsun.Erp.PaymentService.PaymentRequests.PaymentRequestProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("PaymentRequestId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("ReferenceId")
                        .HasColumnType("text");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("PaymentRequestId");

                    b.ToTable("PaymentRequestProduct");
                });

            modelBuilder.Entity("Walsun.Erp.PaymentService.PaymentRequests.PaymentRequestProduct", b =>
                {
                    b.HasOne("Walsun.Erp.PaymentService.PaymentRequests.PaymentRequest", null)
                        .WithMany("Products")
                        .HasForeignKey("PaymentRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Walsun.Erp.PaymentService.PaymentRequests.PaymentRequest", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
