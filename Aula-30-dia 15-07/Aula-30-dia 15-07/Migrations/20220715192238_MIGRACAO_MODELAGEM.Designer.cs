﻿// <auto-generated />
using System;
using Aula_30_dia_15_07.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aula_30_dia_15_07.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220715192238_MIGRACAO_MODELAGEM")]
    partial class MIGRACAO_MODELAGEM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Aula_30_dia_15_07.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Instituicaoid")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Instituicaoid");

                    b.ToTable("alunos", (string)null);
                });

            modelBuilder.Entity("Aula_30_dia_15_07.Models.Instituicao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("instituicoes", (string)null);
                });

            modelBuilder.Entity("Aula_30_dia_15_07.Models.Aluno", b =>
                {
                    b.HasOne("Aula_30_dia_15_07.Models.Instituicao", null)
                        .WithMany("alunos")
                        .HasForeignKey("Instituicaoid");
                });

            modelBuilder.Entity("Aula_30_dia_15_07.Models.Instituicao", b =>
                {
                    b.Navigation("alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
