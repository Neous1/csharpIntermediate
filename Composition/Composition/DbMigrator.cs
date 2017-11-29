namespace Composition
{
    public class DbMigrator
        //class responsible for migrating the database
    {
        private readonly Logger _logger;

        //create a constructor with a parameter of type Logger to create 
        // an association to the logger class
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating blah blah .....");
        }

    }
}