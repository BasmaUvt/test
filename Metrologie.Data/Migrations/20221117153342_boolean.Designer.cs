﻿// <auto-generated />
using System;
using Metrologie.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Metrologie.Data.Migrations
{
    [DbContext(typeof(MetrologieContext))]
    [Migration("20221117153342_boolean")]
    partial class boolean
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Metrologie.Domain.Models.Critere", b =>
                {
                    b.Property<Guid>("CritereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Axe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodeCritere")
                        .HasColumnType("int");

                    b.Property<int>("Coefficient")
                        .HasColumnType("int");

                    b.Property<string>("LibelleCritere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CritereId");

                    b.ToTable("Criteres");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Equipement", b =>
                {
                    b.Property<Guid>("EquipementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateEtalonnage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatePoinconnage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateReparation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateVerification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EchellonDeVerification")
                        .HasColumnType("int");

                    b.Property<int>("EtatEquipement")
                        .HasColumnType("int");

                    b.Property<Guid?>("FkFiliale")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdentifiantInterne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Libelle")
                        .HasColumnType("int");

                    b.Property<string>("Marque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NombreCapteurs")
                        .HasColumnType("int");

                    b.Property<int?>("NumApprobation")
                        .HasColumnType("int");

                    b.Property<int?>("NumVignette")
                        .HasColumnType("int");

                    b.Property<string>("NumeroSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("PorteMax")
                        .HasColumnType("real");

                    b.Property<float?>("PorteMin")
                        .HasColumnType("real");

                    b.Property<float?>("PressionMesuree")
                        .HasColumnType("real");

                    b.Property<float?>("Temperature")
                        .HasColumnType("real");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("grandeur")
                        .HasColumnType("int");

                    b.HasKey("EquipementId");

                    b.ToTable("Equipements");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Equipement");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Intervention", b =>
                {
                    b.Property<Guid>("IdIntervention")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateInterventionReelle")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePlannifiée")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EquipementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkEquipement")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkFiliale")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkPrestataire")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FktypeIntervention")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("FraisIntervention")
                        .HasColumnType("real");

                    b.Property<string>("LibelleIntervention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TypeInterventionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdIntervention");

                    b.HasIndex("EquipementId");

                    b.HasIndex("FkPrestataire");

                    b.HasIndex("TypeInterventionId");

                    b.ToTable("Interventions");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.NoteCritere", b =>
                {
                    b.Property<Guid>("NoteCritereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Axe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Done")
                        .HasColumnType("bit");

                    b.Property<Guid?>("FkCritere")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkFiliale")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Note")
                        .HasColumnType("float");

                    b.HasKey("NoteCritereId");

                    b.HasIndex("FkCritere");

                    b.ToTable("NoteCriteres");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Prestataire", b =>
                {
                    b.Property<Guid>("PrestataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomPrenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeAccredite")
                        .HasColumnType("int");

                    b.HasKey("PrestataireId");

                    b.ToTable("Prestataires");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.TypeIntervention", b =>
                {
                    b.Property<Guid>("TypeInterventionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LibelleTypeInterv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeInterventionId");

                    b.ToTable("TypeInterventions");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Bain", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Bain");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.CapteurDePression", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("CapteurDePression");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.ChambreFroide", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("ChambreFroide");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Conductivimetre", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Conductivimetre");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.DebimetreMassique", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("DebimetreMassique");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.DebimetreVolumetrique", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("DebimetreVolumetrique");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Ensacheuse", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Ensacheuse");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Etuve", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Etuve");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Four", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Four");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.ManometreDePression", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("ManometreDePression");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.PhMetre", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("PhMetre");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.PontsBasculeElectronique", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("PontsBasculeElectronique");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Refrigerateur", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Refrigerateur");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.SondeRedox", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("SondeRedox");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Thermohygometre", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Thermohygometre");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Thermometre", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("Thermometre");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.TransmtteurDePression", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("TransmtteurDePression");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.TunnelDeRefroidissement", b =>
                {
                    b.HasBaseType("Metrologie.Domain.Models.Equipement");

                    b.HasDiscriminator().HasValue("TunnelDeRefroidissement");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.Intervention", b =>
                {
                    b.HasOne("Metrologie.Domain.Models.Equipement", "Equipement")
                        .WithMany()
                        .HasForeignKey("EquipementId");

                    b.HasOne("Metrologie.Domain.Models.Prestataire", "Prestataire")
                        .WithMany("Interventions")
                        .HasForeignKey("FkPrestataire");

                    b.HasOne("Metrologie.Domain.Models.TypeIntervention", "TypeIntervention")
                        .WithMany()
                        .HasForeignKey("TypeInterventionId");
                });

            modelBuilder.Entity("Metrologie.Domain.Models.NoteCritere", b =>
                {
                    b.HasOne("Metrologie.Domain.Models.Critere", "Critere")
                        .WithMany("NoteCriteres")
                        .HasForeignKey("FkCritere");
                });
#pragma warning restore 612, 618
        }
    }
}
