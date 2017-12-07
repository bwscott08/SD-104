namespace Hangman_GUI
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HangmanDBContext : DbContext
    {
        // Your context has been configured to use a 'HangmanDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Hangman_GUI.HangmanDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HangmanDBContext' 
        // connection string in the application configuration file.
        public HangmanDBContext()
            : base("name=HangmanDBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<HangmanGamer> HangmanGamers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}