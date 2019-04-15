namespace AspNetMedicos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        CidadesId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        EstadosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CidadesId)
                .ForeignKey("dbo.Estados", t => t.EstadosId, cascadeDelete: true)
                .Index(t => t.EstadosId);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        EstadosId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        sigla = c.String(),
                        PaisesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstadosId)
                .ForeignKey("dbo.Paises", t => t.PaisesId, cascadeDelete: true)
                .Index(t => t.PaisesId);
            
            CreateTable(
                "dbo.Paises",
                c => new
                    {
                        PaisesId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        sigla = c.String(),
                    })
                .PrimaryKey(t => t.PaisesId);
            
            CreateTable(
                "dbo.Especialidades",
                c => new
                    {
                        EspecialidadesId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                    })
                .PrimaryKey(t => t.EspecialidadesId);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        MedicosId = c.Int(nullable: false, identity: true),
                        crm = c.String(),
                        nome = c.String(),
                        endereco = c.String(),
                        bairro = c.String(),
                        email = c.String(),
                        atendeporconvenio = c.Boolean(nullable: false),
                        temclinica = c.Boolean(nullable: false),
                        websiteblog = c.String(),
                        CidadesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicosId)
                .ForeignKey("dbo.Cidades", t => t.CidadesId, cascadeDelete: true)
                .Index(t => t.CidadesId);
            
            CreateTable(
                "dbo.MedicosEspecialidades",
                c => new
                    {
                        MedicosEspecialidadesId = c.Int(nullable: false, identity: true),
                        MedicosId = c.Int(nullable: false),
                        EspecialidadesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicosEspecialidadesId)
                .ForeignKey("dbo.Especialidades", t => t.EspecialidadesId, cascadeDelete: true)
                .ForeignKey("dbo.Medicos", t => t.MedicosId, cascadeDelete: true)
                .Index(t => t.MedicosId)
                .Index(t => t.EspecialidadesId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuariosId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        usuario = c.String(),
                        senha = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.UsuariosId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MedicosEspecialidades", "MedicosId", "dbo.Medicos");
            DropForeignKey("dbo.MedicosEspecialidades", "EspecialidadesId", "dbo.Especialidades");
            DropForeignKey("dbo.Medicos", "CidadesId", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "EstadosId", "dbo.Estados");
            DropForeignKey("dbo.Estados", "PaisesId", "dbo.Paises");
            DropIndex("dbo.MedicosEspecialidades", new[] { "EspecialidadesId" });
            DropIndex("dbo.MedicosEspecialidades", new[] { "MedicosId" });
            DropIndex("dbo.Medicos", new[] { "CidadesId" });
            DropIndex("dbo.Estados", new[] { "PaisesId" });
            DropIndex("dbo.Cidades", new[] { "EstadosId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.MedicosEspecialidades");
            DropTable("dbo.Medicos");
            DropTable("dbo.Especialidades");
            DropTable("dbo.Paises");
            DropTable("dbo.Estados");
            DropTable("dbo.Cidades");
        }
    }
}
