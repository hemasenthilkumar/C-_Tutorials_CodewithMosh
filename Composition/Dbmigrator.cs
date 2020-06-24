namespace Composition
{
    public class Dbmigrator
    {
        private readonly Logger _l;
        public Dbmigrator(Logger l)
        {
            _l = l;
        }
        public void migrate()
        {
            _l.Log("We are migrating");
           
        }
    }
}
