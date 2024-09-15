namespace soru11;

class Program
{ 
    static int Value(string input)
    {
        char[] sesliharf={'a','e','ı','i','o','ö','u','ü'};
       int sayaç=0;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < sesliharf.Length; j++)
            {
                if (input[i]==sesliharf[j])
                {
                    sayaç++;
                }
            }
            
        }
        return sayaç;

    }
    static void Main(string[] args)
    {
        string isim="elifnurbinici";
        System.Console.WriteLine(Value(isim));
    }
}
