using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using IAT.Web.Models.DAL;

namespace IAT.Web.Migrations
{
    [DbContext(typeof(IATDataContext))]
    [Migration("20151109061846_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta8-15964")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IAT.Web.Models.DAL.Entities.App", b =>
                {
                    b.Property<int>("AppID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppName");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<byte[]>("Icon");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<int>("RecordStatus");

                    b.HasKey("AppID");

                    b.Annotation("Relational:TableName", "Apps");
                });

            modelBuilder.Entity("IAT.Web.Models.DAL.Entities.AppException", b =>
                {
                    b.Property<int>("AppExcetionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppName");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("Date");

                    b.Property<string>("ExceptionMessage");

                    b.Property<string>("ExceptionStackTrace");

                    b.Property<string>("ExceptionTitle");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<int>("RecordStatus");

                    b.HasKey("AppExcetionID");

                    b.Annotation("Relational:TableName", "Exceptions");
                });

            modelBuilder.Entity("IAT.Web.Models.DAL.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Firstname");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Lastname");

                    b.Property<string>("Middlename");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Password");

                    b.Property<int>("RecordStatus");

                    b.Property<string>("Username");

                    b.HasKey("UserID");

                    b.Annotation("Relational:TableName", "Users");
                });
        }
    }
}
