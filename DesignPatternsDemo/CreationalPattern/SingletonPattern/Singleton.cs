namespace DesignPatternsDemo.CreationalPattern.SingletonPattern
{
    public class Singleton
    {
        private static readonly Singleton Instance = new Singleton();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return Instance;
        }
    }
}