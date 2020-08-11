﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool_WAPI.Data;

namespace SmartSchool_WAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("SmartSchool_WAPI.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Marta",
                            sobrenome = "Kent",
                            telefone = "33225555"
                        },
                        new
                        {
                            id = 2,
                            nome = "Paula",
                            sobrenome = "Isabela",
                            telefone = "3354288"
                        },
                        new
                        {
                            id = 3,
                            nome = "Laura",
                            sobrenome = "Antonia",
                            telefone = "55668899"
                        },
                        new
                        {
                            id = 4,
                            nome = "Luiza",
                            sobrenome = "Maria",
                            telefone = "6565659"
                        },
                        new
                        {
                            id = 5,
                            nome = "Lucas",
                            sobrenome = "Machado",
                            telefone = "565685415"
                        },
                        new
                        {
                            id = 6,
                            nome = "Pedro",
                            sobrenome = "Alvares",
                            telefone = "456454545"
                        },
                        new
                        {
                            id = 7,
                            nome = "Paulo",
                            sobrenome = "José",
                            telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool_WAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ProfessorId = 1,
                            nome = "Matemática"
                        },
                        new
                        {
                            id = 2,
                            ProfessorId = 2,
                            nome = "Física"
                        },
                        new
                        {
                            id = 3,
                            ProfessorId = 3,
                            nome = "Português"
                        },
                        new
                        {
                            id = 4,
                            ProfessorId = 4,
                            nome = "Inglês"
                        },
                        new
                        {
                            id = 5,
                            ProfessorId = 5,
                            nome = "Programação"
                        });
                });

            modelBuilder.Entity("SmartSchool_WAPI.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Lauro"
                        },
                        new
                        {
                            id = 2,
                            nome = "Roberto"
                        },
                        new
                        {
                            id = 3,
                            nome = "Ronaldo"
                        },
                        new
                        {
                            id = 4,
                            nome = "Rodrigo"
                        },
                        new
                        {
                            id = 5,
                            nome = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmartSchool_WAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool_WAPI.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool_WAPI.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool_WAPI.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool_WAPI.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
