namespace PatternSingleton
{
    public class MyFirstSingleton
    {
        private static MyFirstSingleton uniqueFirstSingleton = new MyFirstSingleton();

        //Esse é o segredo: construtor privado
        private MyFirstSingleton()
        {
        }

        public static MyFirstSingleton GetInstance()
        {
            return uniqueFirstSingleton;
        }
    }
}