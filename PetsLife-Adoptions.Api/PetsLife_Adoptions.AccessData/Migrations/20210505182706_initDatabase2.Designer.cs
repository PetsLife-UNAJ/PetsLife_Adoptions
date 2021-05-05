﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetsLife_Adoptions.AccessData;

namespace AccessData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210505182706_initDatabase2")]
    partial class initDatabase2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.Adoptante", b =>
                {
                    b.Property<int>("AdoptanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdoptanteId");

                    b.ToTable("Adoptantes");
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.AdoptanteMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdoptanteId")
                        .HasColumnType("int");

                    b.Property<int>("MascotaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdoptanteId");

                    b.HasIndex("MascotaID");

                    b.ToTable("AdoptanteMascotas");
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.Animal", b =>
                {
                    b.Property<int>("TipoAnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoAnimal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoAnimalId")
                        .HasName("AnimalId");

                    b.ToTable("Animales");

                    b.HasData(
                        new
                        {
                            TipoAnimalId = 1,
                            TipoAnimal = "Canino"
                        },
                        new
                        {
                            TipoAnimalId = 2,
                            TipoAnimal = "Felino"
                        },
                        new
                        {
                            TipoAnimalId = 3,
                            TipoAnimal = "Reptil"
                        },
                        new
                        {
                            TipoAnimalId = 4,
                            TipoAnimal = "Roedor"
                        },
                        new
                        {
                            TipoAnimalId = 5,
                            TipoAnimal = "Anfibio"
                        },
                        new
                        {
                            TipoAnimalId = 6,
                            TipoAnimal = "Mamifero"
                        },
                        new
                        {
                            TipoAnimalId = 7,
                            TipoAnimal = "Acuatico"
                        },
                        new
                        {
                            TipoAnimalId = 8,
                            TipoAnimal = "Artropodo"
                        },
                        new
                        {
                            TipoAnimalId = 9,
                            TipoAnimal = "Insecto"
                        },
                        new
                        {
                            TipoAnimalId = 10,
                            TipoAnimal = "Ave"
                        },
                        new
                        {
                            TipoAnimalId = 11,
                            TipoAnimal = "Aracnido"
                        });
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Adoptado")
                        .HasColumnType("bit");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Historia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.HasKey("MascotaId");

                    b.HasIndex("AnimalId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.AdoptanteMascota", b =>
                {
                    b.HasOne("PetsLife_Adoptions.Domain.Entities.Adoptante", "Adoptantes")
                        .WithMany("AdoptanteMascota")
                        .HasForeignKey("AdoptanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetsLife_Adoptions.Domain.Entities.Mascota", "Mascotas")
                        .WithMany("AdoptanteMascota")
                        .HasForeignKey("MascotaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adoptantes");

                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.Mascota", b =>
                {
                    b.HasOne("PetsLife_Adoptions.Domain.Entities.Animal", "Animales")
                        .WithMany("Mascotas")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animales");
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.Adoptante", b =>
                {
                    b.Navigation("AdoptanteMascota");
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.Animal", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("PetsLife_Adoptions.Domain.Entities.Mascota", b =>
                {
                    b.Navigation("AdoptanteMascota");
                });
#pragma warning restore 612, 618
        }
    }
}
