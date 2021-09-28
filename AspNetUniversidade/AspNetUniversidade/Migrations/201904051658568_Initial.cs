namespace AspNetUniversidade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        AlunoId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlunoId)
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        UniversidadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CursoId)
                .ForeignKey("dbo.Universidade", t => t.UniversidadeId, cascadeDelete: true)
                .Index(t => t.UniversidadeId);
            
            CreateTable(
                "dbo.Universidade",
                c => new
                    {
                        UniversidadeId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        cidade = c.String(),
                        uf = c.String(),
                    })
                .PrimaryKey(t => t.UniversidadeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluno", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Curso", "UniversidadeId", "dbo.Universidade");
            DropIndex("dbo.Curso", new[] { "UniversidadeId" });
            DropIndex("dbo.Aluno", new[] { "CursoId" });
            DropTable("dbo.Universidade");
            DropTable("dbo.Curso");
            DropTable("dbo.Aluno");
        }
    }
}
