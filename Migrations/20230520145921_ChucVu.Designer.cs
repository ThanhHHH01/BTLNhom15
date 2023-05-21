﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTLNHOM15.Migrations
{
    [DbContext(typeof(MvcGymContext))]
    [Migration("20230520145921_ChucVu")]
    partial class ChucVu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("BTLNHOM15.Models.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenChucVu")
                        .HasColumnType("TEXT");

                    b.HasKey("MaChucVu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("BTLNHOM15.Models.GoiTap", b =>
                {
                    b.Property<string>("MaGoiTap")
                        .HasColumnType("TEXT");

                    b.Property<string>("GiaGoi")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenGoi")
                        .HasColumnType("TEXT");

                    b.HasKey("MaGoiTap");

                    b.ToTable("GoiTap");
                });

            modelBuilder.Entity("BTLNHOM15.Models.HoiVien", b =>
                {
                    b.Property<string>("HoiVienID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailHV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaGoiTap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Ngaybatdau")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Ngayketthuc")
                        .HasColumnType("TEXT");

                    b.Property<string>("SĐT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HoiVienID");

                    b.HasIndex("MaGoiTap");

                    b.ToTable("HoiVien");
                });

            modelBuilder.Entity("BTLNHOM15.Models.NhanVien", b =>
                {
                    b.Property<string>("MaID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaChucVu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SĐT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaID");

                    b.HasIndex("MaChucVu");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("BTLNHOM15.Models.ThanhToan", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("TEXT");

                    b.Property<string>("HoiVienID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaGoiTap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaTinhTrang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Ngayban")
                        .HasColumnType("TEXT");

                    b.HasKey("MaHD");

                    b.HasIndex("HoiVienID");

                    b.HasIndex("MaGoiTap");

                    b.HasIndex("MaTinhTrang");

                    b.ToTable("ThanhToan");
                });

            modelBuilder.Entity("BTLNHOM15.Models.ThietBi", b =>
                {
                    b.Property<string>("MaTB")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaTinhTrang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Soluong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenTB")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaTB");

                    b.HasIndex("MaTinhTrang");

                    b.ToTable("ThietBi");
                });

            modelBuilder.Entity("BTLNHOM15.Models.TinhTrang", b =>
                {
                    b.Property<string>("MaTinhTrang")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaTB")
                        .HasColumnType("TEXT");

                    b.Property<string>("NoidungTT")
                        .HasColumnType("TEXT");

                    b.HasKey("MaTinhTrang");

                    b.HasIndex("MaTB");

                    b.ToTable("TinhTrang");
                });

            modelBuilder.Entity("BTLNHOM15.Models.HoiVien", b =>
                {
                    b.HasOne("BTLNHOM15.Models.GoiTap", "GoiTap")
                        .WithMany()
                        .HasForeignKey("MaGoiTap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoiTap");
                });

            modelBuilder.Entity("BTLNHOM15.Models.NhanVien", b =>
                {
                    b.HasOne("BTLNHOM15.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("MaChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("BTLNHOM15.Models.ThanhToan", b =>
                {
                    b.HasOne("BTLNHOM15.Models.HoiVien", "HoiVien")
                        .WithMany()
                        .HasForeignKey("HoiVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BTLNHOM15.Models.GoiTap", "GoiTap")
                        .WithMany()
                        .HasForeignKey("MaGoiTap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BTLNHOM15.Models.TinhTrang", "TinhTrang")
                        .WithMany()
                        .HasForeignKey("MaTinhTrang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoiTap");

                    b.Navigation("HoiVien");

                    b.Navigation("TinhTrang");
                });

            modelBuilder.Entity("BTLNHOM15.Models.ThietBi", b =>
                {
                    b.HasOne("BTLNHOM15.Models.TinhTrang", "TinhTrang")
                        .WithMany()
                        .HasForeignKey("MaTinhTrang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TinhTrang");
                });

            modelBuilder.Entity("BTLNHOM15.Models.TinhTrang", b =>
                {
                    b.HasOne("BTLNHOM15.Models.ThietBi", "ThietBi")
                        .WithMany()
                        .HasForeignKey("MaTB");

                    b.Navigation("ThietBi");
                });
#pragma warning restore 612, 618
        }
    }
}
