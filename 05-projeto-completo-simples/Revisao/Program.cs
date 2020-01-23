using System;

namespace Revisao
{
    class Program
    {
        private static Aluno[] AddAluno(Aluno[] alunos)
        {
            int indice = 0;

            Console.WriteLine("Talk a name to student:");
            Aluno aluno = new Aluno();
            
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Talk a score to student:");
            if (decimal.TryParse(Console.ReadLine(),out decimal nota))
            {
                aluno.Nota = nota;
            }
            else{
                throw new ArgumentException("Valor da nota tem que ser um número!");
            }

            foreach(var alu in alunos)
            {
                if(!string.IsNullOrEmpty(alu.Nome))
                {
                    indice++;
                }
            }
            
            if (indice<4){
                
                alunos[indice] = aluno;
            }

            return alunos;
            
        }

        private static void ListAluno(Aluno[] alunos)
        {
            foreach(Aluno aluno in alunos)
            {
                if(!string.IsNullOrEmpty(aluno.Nome))
                {
                    Console.WriteLine($"ALUNO: {aluno.Nome} - NOTA: {aluno.Nota}");
                }
            }
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.Read();
        }
        private static Boolean Opcao (string opcaoUsuario, ref Aluno[] alunos)
        {
            switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: new student
                        alunos = AddAluno(alunos);
                        return true;

                    case "2":
                        //TODO: list students
                        ListAluno(alunos);
                        return true;

                    case "3":
                        //TODO: Average
                        decimal notaTotal = 0;
                        int division = 0;

                        foreach(var aluno in alunos)
                        {
                            if(!string.IsNullOrEmpty(aluno.Nome))
                            {
                                notaTotal += aluno.Nota;
                                division += 1 ;
                            }
                        }
                        Console.WriteLine(decimal.Floor(notaTotal/division));
                        Console.Write("Pressione qualquer tecla para continuar...");
                        Console.Read();

                        return true;
                    case "X":
                        return false;

                    default:
                        Console.WriteLine("Essa opção não existe!");
                        return true;
                }
        }
        private static string Menu()
        {
            Console.Clear();
            Console.WriteLine("Option select: ");
            Console.WriteLine("1 - New student ");
            Console.WriteLine("2 - List students");
            Console.WriteLine("3 - Average");
            Console.WriteLine("X - Exit");
            Console.WriteLine("");
            return Console.ReadLine().ToUpper();
        }

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            while (Opcao(Menu(),ref alunos)){}
        }
    }
}
