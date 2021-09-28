namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropIndex("dbo.Headings", new[] { "WriterID" });
            AddColumn("dbo.Headings", "Writer_WriterID", c => c.Int());
            AddColumn("dbo.Headings", "Category_WriterID", c => c.Int());
            AddColumn("dbo.Headings", "Writer_WriterID1", c => c.Int());
            CreateIndex("dbo.Headings", "Writer_WriterID");
            CreateIndex("dbo.Headings", "Category_WriterID");
            CreateIndex("dbo.Headings", "Writer_WriterID1");
            AddForeignKey("dbo.Headings", "Category_WriterID", "dbo.Writers", "WriterID");
            AddForeignKey("dbo.Headings", "Writer_WriterID1", "dbo.Writers", "WriterID");
            AddForeignKey("dbo.Headings", "Writer_WriterID", "dbo.Writers", "WriterID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "Writer_WriterID", "dbo.Writers");
            DropForeignKey("dbo.Headings", "Writer_WriterID1", "dbo.Writers");
            DropForeignKey("dbo.Headings", "Category_WriterID", "dbo.Writers");
            DropIndex("dbo.Headings", new[] { "Writer_WriterID1" });
            DropIndex("dbo.Headings", new[] { "Category_WriterID" });
            DropIndex("dbo.Headings", new[] { "Writer_WriterID" });
            DropColumn("dbo.Headings", "Writer_WriterID1");
            DropColumn("dbo.Headings", "Category_WriterID");
            DropColumn("dbo.Headings", "Writer_WriterID");
            CreateIndex("dbo.Headings", "WriterID");
            AddForeignKey("dbo.Headings", "WriterID", "dbo.Writers", "WriterID", cascadeDelete: true);
            AddForeignKey("dbo.Headings", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
    }
}
