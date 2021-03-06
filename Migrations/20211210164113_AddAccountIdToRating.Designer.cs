// <auto-generated />
using System;
using Clothing_Store.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clothing_Store.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211210164113_AddAccountIdToRating")]
    partial class AddAccountIdToRating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clothing_Store.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Clothing_Store.Models.CartDetails", b =>
                {
                    b.Property<int>("accountID")
                        .HasColumnType("int");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("accountID", "productID");

                    b.HasIndex("productID");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("Clothing_Store.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SecretNumber")
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7);

                    b.Property<DateTime>("ValidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AccountID")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Clothing_Store.Models.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(100);

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("productID");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Clothing_Store.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(100);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Clothing_Store.Models.ProductTag", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("TagID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("Clothing_Store.Models.Promotion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(100);

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("Promotion");
                });

            modelBuilder.Entity("Clothing_Store.Models.Rating", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.Property<int?>("accountID")
                        .HasColumnType("int");

                    b.Property<int?>("productID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("accountID");

                    b.HasIndex("productID");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Clothing_Store.Models.Receipt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<DateTime>("DeliveryAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<string>("Method")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<string>("Notes")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("OrderAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SecretNumber")
                        .HasColumnType("nvarchar(7)")
                        .HasMaxLength(7);

                    b.Property<int>("ShippingCost")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(255);

                    b.Property<int>("TotalDiscount")
                        .HasColumnType("int");

                    b.Property<int>("TotalPay")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("accountID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("accountID");

                    b.ToTable("Receipt");
                });

            modelBuilder.Entity("Clothing_Store.Models.ReceiptDetail", b =>
                {
                    b.Property<int>("ReceiptID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(50);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("ReceiptID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("ReceipDetail");
                });

            modelBuilder.Entity("Clothing_Store.Models.RequestForgotPassword", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ExpiredIn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("RequestForgotPassword");
                });

            modelBuilder.Entity("Clothing_Store.Models.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Clothing_Store.Models.Warehouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("Sold")
                        .HasColumnType("int");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("productID");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Clothing_Store.Models.CartDetails", b =>
                {
                    b.HasOne("Clothing_Store.Models.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clothing_Store.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clothing_Store.Models.Customer", b =>
                {
                    b.HasOne("Clothing_Store.Models.Account", "account")
                        .WithOne("customer")
                        .HasForeignKey("Clothing_Store.Models.Customer", "AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clothing_Store.Models.Image", b =>
                {
                    b.HasOne("Clothing_Store.Models.Product", "product")
                        .WithMany("images")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clothing_Store.Models.ProductTag", b =>
                {
                    b.HasOne("Clothing_Store.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clothing_Store.Models.Tag", "tag")
                        .WithMany()
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clothing_Store.Models.Promotion", b =>
                {
                    b.HasOne("Clothing_Store.Models.Product", "product")
                        .WithOne("promotion")
                        .HasForeignKey("Clothing_Store.Models.Promotion", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clothing_Store.Models.Rating", b =>
                {
                    b.HasOne("Clothing_Store.Models.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountID");

                    b.HasOne("Clothing_Store.Models.Product", "product")
                        .WithMany("ratings")
                        .HasForeignKey("productID");
                });

            modelBuilder.Entity("Clothing_Store.Models.Receipt", b =>
                {
                    b.HasOne("Clothing_Store.Models.Account", "account")
                        .WithMany("receipts")
                        .HasForeignKey("accountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clothing_Store.Models.ReceiptDetail", b =>
                {
                    b.HasOne("Clothing_Store.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clothing_Store.Models.Receipt", "receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clothing_Store.Models.Warehouse", b =>
                {
                    b.HasOne("Clothing_Store.Models.Product", "product")
                        .WithMany("warehouses")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
