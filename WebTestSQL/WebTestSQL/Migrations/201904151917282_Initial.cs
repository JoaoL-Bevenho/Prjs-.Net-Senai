namespace WebTestSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuariosId = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        login = c.String(nullable: false, maxLength: 255),
                        senha = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.UsuariosId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
