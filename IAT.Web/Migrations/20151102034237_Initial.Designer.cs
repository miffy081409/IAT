using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using IAT.Web.Models.DAL;
using Microsoft.Data.Entity.SqlServer.Metadata;

namespace IAT.Web.Migrations
{
    [DbContext(typeof(IATDataContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20151102034237_Initial"; }
        }

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta7-15540")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn);

            modelBuilder.Entity("IAT.Web.Models.DAL.Entities.AppException", b =>
                {
                    b.Property<int>("AppExcetionID");

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

                    b.Key("AppExcetionID");

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

                    b.Key("UserID");

                    b.Annotation("Relational:TableName", "Users");
                });
        }
    }
}
