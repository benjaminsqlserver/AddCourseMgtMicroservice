﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagement.Databases;

#nullable disable

namespace StudentManagement.Migrations
{
    [DbContext(typeof(StudentManagementDbContext))]
    partial class StudentManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagement.Domain.Countries.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_name");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_on");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified_on");

                    b.HasKey("Id")
                        .HasName("pk_countries");

                    b.ToTable("countries", (string)null);
                });

            modelBuilder.Entity("StudentManagement.Domain.Genders.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_on");

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("gender_name");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified_on");

                    b.HasKey("Id")
                        .HasName("pk_genders");

                    b.ToTable("genders", (string)null);
                });

            modelBuilder.Entity("StudentManagement.Domain.NextOfKinContactInformations.NextOfKinContactInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<Guid>("CountryID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("country_id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_on");

                    b.Property<string>("HouseAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("house_address");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified_on");

                    b.Property<Guid>("NextOfKinID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("next_of_kin_id");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("state");

                    b.Property<Guid?>("StudentNextOfKinId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("student_next_of_kin_id");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("zip_code");

                    b.HasKey("Id")
                        .HasName("pk_next_of_kin_contact_informations");

                    b.HasIndex("CountryID")
                        .HasDatabaseName("ix_next_of_kin_contact_informations_country_id");

                    b.HasIndex("StudentNextOfKinId")
                        .HasDatabaseName("ix_next_of_kin_contact_informations_student_next_of_kin_id");

                    b.ToTable("next_of_kin_contact_informations", (string)null);
                });

            modelBuilder.Entity("StudentManagement.Domain.Relationships.Relationship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_on");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("RelationshipName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("relationship_name");

                    b.HasKey("Id")
                        .HasName("pk_relationships");

                    b.ToTable("relationships", (string)null);
                });

            modelBuilder.Entity("StudentManagement.Domain.StudentContactInformations.StudentContactInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<Guid>("CountryID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("country_id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_on");

                    b.Property<string>("HouseAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("house_address");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("state");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("student_id");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("zip_code");

                    b.HasKey("Id")
                        .HasName("pk_student_contact_informations");

                    b.HasIndex("CountryID")
                        .HasDatabaseName("ix_student_contact_informations_country_id");

                    b.HasIndex("StudentID")
                        .HasDatabaseName("ix_student_contact_informations_student_id");

                    b.ToTable("student_contact_informations", (string)null);
                });

            modelBuilder.Entity("StudentManagement.Domain.StudentNextOfKins.StudentNextOfKin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_on");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("gender_id");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<Guid>("RelationshipID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("relationship_id");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("student_id");

                    b.HasKey("Id")
                        .HasName("pk_student_next_of_kins");

                    b.HasIndex("GenderId")
                        .HasDatabaseName("ix_student_next_of_kins_gender_id");

                    b.HasIndex("RelationshipID")
                        .HasDatabaseName("ix_student_next_of_kins_relationship_id");

                    b.HasIndex("StudentID")
                        .HasDatabaseName("ix_student_next_of_kins_student_id");

                    b.ToTable("student_next_of_kins", (string)null);
                });

            modelBuilder.Entity("StudentManagement.Domain.Students.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("created_on");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("gender_id");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("MatriculationNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("matriculation_number");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_students");

                    b.HasIndex("GenderId")
                        .HasDatabaseName("ix_students_gender_id");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("StudentManagement.Domain.NextOfKinContactInformations.NextOfKinContactInformation", b =>
                {
                    b.HasOne("StudentManagement.Domain.Countries.Country", "Country")
                        .WithMany("NextOfKinContactInformations")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_next_of_kin_contact_informations_countries_country_id");

                    b.HasOne("StudentManagement.Domain.StudentNextOfKins.StudentNextOfKin", "StudentNextOfKin")
                        .WithMany("NextOfKinContactInformations")
                        .HasForeignKey("StudentNextOfKinId")
                        .HasConstraintName("fk_next_of_kin_contact_informations_student_next_of_kins_student_next_of_kin_id");

                    b.Navigation("Country");

                    b.Navigation("StudentNextOfKin");
                });

            modelBuilder.Entity("StudentManagement.Domain.StudentContactInformations.StudentContactInformation", b =>
                {
                    b.HasOne("StudentManagement.Domain.Countries.Country", "Country")
                        .WithMany("StudentContactInformations")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_student_contact_informations_countries_country_id");

                    b.HasOne("StudentManagement.Domain.Students.Student", "Student")
                        .WithMany("StudentContactInformations")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_student_contact_informations_students_student_id");

                    b.Navigation("Country");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagement.Domain.StudentNextOfKins.StudentNextOfKin", b =>
                {
                    b.HasOne("StudentManagement.Domain.Genders.Gender", "Gender")
                        .WithMany("StudentNextOfKins")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_student_next_of_kins_genders_gender_id");

                    b.HasOne("StudentManagement.Domain.Relationships.Relationship", "Relationship")
                        .WithMany("StudentNextOfKins")
                        .HasForeignKey("RelationshipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_student_next_of_kins_relationships_relationship_id");

                    b.HasOne("StudentManagement.Domain.Students.Student", "Student")
                        .WithMany("StudentNextOfKins")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_student_next_of_kins_students_student_id");

                    b.Navigation("Gender");

                    b.Navigation("Relationship");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagement.Domain.Students.Student", b =>
                {
                    b.HasOne("StudentManagement.Domain.Genders.Gender", "Gender")
                        .WithMany("Students")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_students_genders_gender_id");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("StudentManagement.Domain.Countries.Country", b =>
                {
                    b.Navigation("NextOfKinContactInformations");

                    b.Navigation("StudentContactInformations");
                });

            modelBuilder.Entity("StudentManagement.Domain.Genders.Gender", b =>
                {
                    b.Navigation("StudentNextOfKins");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentManagement.Domain.Relationships.Relationship", b =>
                {
                    b.Navigation("StudentNextOfKins");
                });

            modelBuilder.Entity("StudentManagement.Domain.StudentNextOfKins.StudentNextOfKin", b =>
                {
                    b.Navigation("NextOfKinContactInformations");
                });

            modelBuilder.Entity("StudentManagement.Domain.Students.Student", b =>
                {
                    b.Navigation("StudentContactInformations");

                    b.Navigation("StudentNextOfKins");
                });
#pragma warning restore 612, 618
        }
    }
}
