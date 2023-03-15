namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'ABC')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'DEF')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'XYZ')");
        }
        
        public override void Down()
        {
        }
    }
}
