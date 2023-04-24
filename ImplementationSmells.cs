namespace TestDesignite
{
    internal class ImplementationSmells
    {
        public void LongParameterListTest(string param1, string param2, string param3, string param4, string param5, string param6)
        {
            Console.WriteLine(param1 + param2);
        }

        public void TestDuplicatedCode()
        {
            Console.WriteLine("Duplicated Code");
        }

        public void TesteDuplicatedCpode()
        {
            Console.WriteLine("Duplicated Code");
        }

        public static double TestDuplicatedCode(double valor1, double valor2, string operacao)
        {
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                    }
                    break;
                case "^":
                    resultado = Math.Pow(valor1, valor2);
                    break;
                case "sqrt":
                    resultado = Math.Sqrt(valor1);
                    break;
                case "sin":
                    resultado = Math.Sin(valor1);
                    break;
                case "cos":
                    resultado = Math.Cos(valor1);
                    break;
                case "tan":
                    resultado = Math.Tan(valor1);
                    break;
                case "log":
                    resultado = Math.Log10(valor1);
                    break;
                default:
                    Console.WriteLine("Erro: Operação inválida.");
                    break;
            }

            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");
            Console.WriteLine("Teste Long Method");

            return resultado;
        }

    }
}
