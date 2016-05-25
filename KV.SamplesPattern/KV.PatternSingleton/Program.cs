namespace KV.PatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria uma instância
            MyFirstSingleton f = MyFirstSingleton.GetInstance();

            //Mantém a mesma instância criada anteriormente
            MyFirstSingleton s = MyFirstSingleton.GetInstance();
        }
    }
}