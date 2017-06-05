namespace GApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationNames",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        BusinessEntity = c.String(),
                        ActionsNamesAsString = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Reference = c.String(),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Hidden = c.Boolean(nullable: false),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuItemApplications",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(maxLength: 65),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Title_French = c.String(),
                        Title_English = c.String(),
                        Title_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Login = c.String(maxLength: 255),
                        Password = c.String(),
                        Language = c.Int(nullable: false),
                        FirstName_French = c.String(),
                        FirstName_English = c.String(),
                        FirstName_Arab = c.String(),
                        LastName_French = c.String(),
                        LastName_English = c.String(),
                        LastName_Arab = c.String(),
                        CIN = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.Boolean(nullable: false),
                        ProfilePhoto = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.Login, unique: true)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Country_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.TaskProjects",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        Valide = c.Boolean(nullable: false),
                        DaysNumber = c.Int(nullable: false),
                        var_Int16 = c.Short(nullable: false),
                        var_Int64 = c.Long(nullable: false),
                        var_float = c.Single(nullable: false),
                        var_double = c.Double(nullable: false),
                        LocalizedTitle_French = c.String(),
                        LocalizedTitle_English = c.String(),
                        LocalizedTitle_Arab = c.String(),
                        EntityToManimulate = c.String(),
                        BusinessEntity = c.String(),
                        Categoy = c.Int(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Project_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Individuals",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName_French = c.String(),
                        FirstName_English = c.String(),
                        FirstName_Arab = c.String(),
                        LastName_French = c.String(),
                        LastName_English = c.String(),
                        LastName_Arab = c.String(),
                        CIN = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.Boolean(nullable: false),
                        ProfilePhoto = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GwinActivities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleAuthorizations",
                c => new
                    {
                        Role_Id = c.Long(nullable: false),
                        Authorization_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.Authorization_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Authorizations", t => t.Authorization_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Authorization_Id);
            
            CreateTable(
                "dbo.MenuItemApplicationRoles",
                c => new
                    {
                        MenuItemApplication_Id = c.Long(nullable: false),
                        Role_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.MenuItemApplication_Id, t.Role_Id })
                .ForeignKey("dbo.MenuItemApplications", t => t.MenuItemApplication_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.MenuItemApplication_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_Id = c.Long(nullable: false),
                        Role_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Role_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.TaskProjectIndividuals",
                c => new
                    {
                        TaskProject_Id = c.Long(nullable: false),
                        Individual_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.TaskProject_Id, t.Individual_Id })
                .ForeignKey("dbo.TaskProjects", t => t.TaskProject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Individuals", t => t.Individual_Id, cascadeDelete: true)
                .Index(t => t.TaskProject_Id)
                .Index(t => t.Individual_Id);
            
            CreateTable(
                "dbo.TaskProjectIndividual1",
                c => new
                    {
                        TaskProject_Id = c.Long(nullable: false),
                        Individual_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.TaskProject_Id, t.Individual_Id })
                .ForeignKey("dbo.TaskProjects", t => t.TaskProject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Individuals", t => t.Individual_Id, cascadeDelete: true)
                .Index(t => t.TaskProject_Id)
                .Index(t => t.Individual_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskProjectIndividual1", "Individual_Id", "dbo.Individuals");
            DropForeignKey("dbo.TaskProjectIndividual1", "TaskProject_Id", "dbo.TaskProjects");
            DropForeignKey("dbo.TaskProjects", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.TaskProjectIndividuals", "Individual_Id", "dbo.Individuals");
            DropForeignKey("dbo.TaskProjectIndividuals", "TaskProject_Id", "dbo.TaskProjects");
            DropForeignKey("dbo.Individuals", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.ContactInformations", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.MenuItemApplicationRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.MenuItemApplicationRoles", "MenuItemApplication_Id", "dbo.MenuItemApplications");
            DropForeignKey("dbo.RoleAuthorizations", "Authorization_Id", "dbo.Authorizations");
            DropForeignKey("dbo.RoleAuthorizations", "Role_Id", "dbo.Roles");
            DropIndex("dbo.TaskProjectIndividual1", new[] { "Individual_Id" });
            DropIndex("dbo.TaskProjectIndividual1", new[] { "TaskProject_Id" });
            DropIndex("dbo.TaskProjectIndividuals", new[] { "Individual_Id" });
            DropIndex("dbo.TaskProjectIndividuals", new[] { "TaskProject_Id" });
            DropIndex("dbo.UserRoles", new[] { "Role_Id" });
            DropIndex("dbo.UserRoles", new[] { "User_Id" });
            DropIndex("dbo.MenuItemApplicationRoles", new[] { "Role_Id" });
            DropIndex("dbo.MenuItemApplicationRoles", new[] { "MenuItemApplication_Id" });
            DropIndex("dbo.RoleAuthorizations", new[] { "Authorization_Id" });
            DropIndex("dbo.RoleAuthorizations", new[] { "Role_Id" });
            DropIndex("dbo.Individuals", new[] { "City_Id" });
            DropIndex("dbo.TaskProjects", new[] { "Project_Id" });
            DropIndex("dbo.ContactInformations", new[] { "City_Id" });
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropIndex("dbo.Users", new[] { "City_Id" });
            DropIndex("dbo.Users", new[] { "Login" });
            DropIndex("dbo.MenuItemApplications", new[] { "Code" });
            DropTable("dbo.TaskProjectIndividual1");
            DropTable("dbo.TaskProjectIndividuals");
            DropTable("dbo.UserRoles");
            DropTable("dbo.MenuItemApplicationRoles");
            DropTable("dbo.RoleAuthorizations");
            DropTable("dbo.GwinActivities");
            DropTable("dbo.Projects");
            DropTable("dbo.Individuals");
            DropTable("dbo.TaskProjects");
            DropTable("dbo.ContactInformations");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Users");
            DropTable("dbo.MenuItemApplications");
            DropTable("dbo.Roles");
            DropTable("dbo.Authorizations");
            DropTable("dbo.ApplicationNames");
        }
    }
}
