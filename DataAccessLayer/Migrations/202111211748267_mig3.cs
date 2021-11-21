namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "Category_WriterID", "dbo.Writers");
            DropForeignKey("dbo.Headings", "Writer_WriterID1", "dbo.Writers");
            DropForeignKey("dbo.Headings", "Writer_WriterID", "dbo.Writers");
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            DropIndex("dbo.Headings", new[] { "Writer_WriterID" });
            DropIndex("dbo.Headings", new[] { "Category_WriterID" });
            DropIndex("dbo.Headings", new[] { "Writer_WriterID1" });
            DropColumn("dbo.Headings", "CategoryID");
            DropColumn("dbo.Headings", "WriterID");
            DropColumn("dbo.Headings", "WriterID");
            RenameColumn(table: "dbo.Headings", name: "Category_WriterID", newName: "CategoryID");
            RenameColumn(table: "dbo.Headings", name: "Writer_WriterID1", newName: "WriterID");
            RenameColumn(table: "dbo.Headings", name: "Writer_WriterID", newName: "WriterID");
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            CreateIndex("dbo.Headings", "CategoryID");
            CreateIndex("dbo.Headings", "WriterID");
            AddForeignKey("dbo.Headings", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            AddForeignKey("dbo.Headings", "WriterID", "dbo.Writers", "WriterID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Headings", new[] { "WriterID" });
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            AlterColumn("dbo.Headings", "WriterID", c => c.Int());
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int());
            AlterColumn("dbo.Headings", "WriterID", c => c.Int());
            RenameColumn(table: "dbo.Headings", name: "WriterID", newName: "Writer_WriterID");
            RenameColumn(table: "dbo.Headings", name: "WriterID", newName: "Writer_WriterID1");
            RenameColumn(table: "dbo.Headings", name: "CategoryID", newName: "Category_WriterID");
            AddColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AddColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AddColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Headings", "Writer_WriterID1");
            CreateIndex("dbo.Headings", "Category_WriterID");
            CreateIndex("dbo.Headings", "Writer_WriterID");
            CreateIndex("dbo.Headings", "CategoryID");
            AddForeignKey("dbo.Headings", "Writer_WriterID", "dbo.Writers", "WriterID");
            AddForeignKey("dbo.Headings", "Writer_WriterID1", "dbo.Writers", "WriterID");
            AddForeignKey("dbo.Headings", "Category_WriterID", "dbo.Writers", "WriterID");
        }
    }
}
