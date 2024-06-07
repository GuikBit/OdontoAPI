﻿// <auto-generated />
using System;
using DentistaApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DentistaApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DentistaApi.Models.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrganizacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("OrganizacaoId");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("DentistaApi.Models.Anamnese", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alergia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Gravida")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hipertensao")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProblemaSaude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Remedio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("SangramentoExcessivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tratamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("TraumatismoFace")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Anamnese");
                });

            modelBuilder.Entity("DentistaApi.Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Bonificacao")
                        .HasColumnType("double");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdUserUpdade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrganizacaoId")
                        .HasColumnType("int");

                    b.Property<double>("Salario")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("OrganizacaoId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("DentistaApi.Models.Consulta", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ausente")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ConsultaEspecialidadeId")
                        .HasColumnType("int");

                    b.Property<string>("CorDentista")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataConsultaReserva")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataHoraFimAtendimento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataHoraInicioAtendimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DentistaId")
                        .HasColumnType("int");

                    b.Property<string>("NomePaciente")
                        .HasColumnType("longtext");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("OrganizacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int?>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Procedimentos")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.Property<int>("TempoPrevisto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaEspecialidadeId");

                    b.HasIndex("DentistaId");

                    b.HasIndex("OrganizacaoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("PagamentoId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("DentistaApi.Models.ConsultaEspecialidade", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DataCadastro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DataUpdade")
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("ValorBase")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("ConsultaEspecialidades");
                });

            modelBuilder.Entity("DentistaApi.Models.Dentista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CRO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("CorDentista")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EspecialidadeId")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrganizacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("OrganizacaoId");

                    b.ToTable("Dentistas");
                });

            modelBuilder.Entity("DentistaApi.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Referencia")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("DentistaApi.Models.Especialidade", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("DentistaApi.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCargo")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrganizacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCargo");

                    b.HasIndex("OrganizacaoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("DentistaApi.Models.Organizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Whastapp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Organizacao");
                });

            modelBuilder.Entity("DentistaApi.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnamneseId")
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("FotoPerfil")
                        .HasColumnType("longtext");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumPasta")
                        .HasColumnType("longtext");

                    b.Property<int>("OrganizacaoId")
                        .HasColumnType("int");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AnamneseId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("OrganizacaoId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("DentistaApi.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Acrecimo")
                        .HasColumnType("double");

                    b.Property<double>("Desconto")
                        .HasColumnType("double");

                    b.Property<bool>("FatFechado")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.Property<int>("qtdParcela")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("DentistaApi.Models.Parcela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EhEntrada")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("FormaDePagamento")
                        .HasColumnType("int");

                    b.Property<int?>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("ValorParcela")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("PagamentoId");

                    b.ToTable("Parcela");
                });

            modelBuilder.Entity("DentistaApi.Models.Responsavel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DentistaApi.Models.Administrador", b =>
                {
                    b.HasOne("DentistaApi.Models.Organizacao", "IdOrganizacao")
                        .WithMany()
                        .HasForeignKey("OrganizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdOrganizacao");
                });

            modelBuilder.Entity("DentistaApi.Models.Cargo", b =>
                {
                    b.HasOne("DentistaApi.Models.Organizacao", "IdOrganizacao")
                        .WithMany("Cargos")
                        .HasForeignKey("OrganizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdOrganizacao");
                });

            modelBuilder.Entity("DentistaApi.Models.Consulta", b =>
                {
                    b.HasOne("DentistaApi.Models.ConsultaEspecialidade", "ConsultaEspecialidade")
                        .WithMany()
                        .HasForeignKey("ConsultaEspecialidadeId");

                    b.HasOne("DentistaApi.Models.Dentista", "Dentista")
                        .WithMany("Consultas")
                        .HasForeignKey("DentistaId");

                    b.HasOne("DentistaApi.Models.Organizacao", null)
                        .WithMany("Consultas")
                        .HasForeignKey("OrganizacaoId");

                    b.HasOne("DentistaApi.Models.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId");

                    b.HasOne("DentistaApi.Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId");

                    b.Navigation("ConsultaEspecialidade");

                    b.Navigation("Dentista");

                    b.Navigation("Paciente");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("DentistaApi.Models.Dentista", b =>
                {
                    b.HasOne("DentistaApi.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.HasOne("DentistaApi.Models.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId");

                    b.HasOne("DentistaApi.Models.Organizacao", "IdOrganizacao")
                        .WithMany("Dentistas")
                        .HasForeignKey("OrganizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Especialidade");

                    b.Navigation("IdOrganizacao");
                });

            modelBuilder.Entity("DentistaApi.Models.Funcionario", b =>
                {
                    b.HasOne("DentistaApi.Models.Cargo", "cargo")
                        .WithMany()
                        .HasForeignKey("IdCargo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistaApi.Models.Organizacao", "IdOrganizacao")
                        .WithMany("Funcionarios")
                        .HasForeignKey("OrganizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdOrganizacao");

                    b.Navigation("cargo");
                });

            modelBuilder.Entity("DentistaApi.Models.Organizacao", b =>
                {
                    b.HasOne("DentistaApi.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("DentistaApi.Models.Paciente", b =>
                {
                    b.HasOne("DentistaApi.Models.Anamnese", "Anamnese")
                        .WithMany()
                        .HasForeignKey("AnamneseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistaApi.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistaApi.Models.Organizacao", "IdOrganizacao")
                        .WithMany("Pacientes")
                        .HasForeignKey("OrganizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistaApi.Models.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anamnese");

                    b.Navigation("Endereco");

                    b.Navigation("IdOrganizacao");

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("DentistaApi.Models.Parcela", b =>
                {
                    b.HasOne("DentistaApi.Models.Pagamento", null)
                        .WithMany("Parcelas")
                        .HasForeignKey("PagamentoId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DentistaApi.Models.Dentista", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("DentistaApi.Models.Organizacao", b =>
                {
                    b.Navigation("Cargos");

                    b.Navigation("Consultas");

                    b.Navigation("Dentistas");

                    b.Navigation("Funcionarios");

                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("DentistaApi.Models.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("DentistaApi.Models.Pagamento", b =>
                {
                    b.Navigation("Parcelas");
                });
#pragma warning restore 612, 618
        }
    }
}
