namespace Composition
{
    public class Installer
    {
        private readonly Logger _l;
        public Installer(Logger l)
        {
            _l = l;
        }
        public void Install()
        {
            _l.Log("We are installing");
        }
         
    }
}
