using Tarefa;

class Program
{
    public static void Main(string[] args)
    {
        List<Tarefa.Tarefa>  tarefas = new List<Tarefa.Tarefa>();
        
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar Tarefa");
            Console.WriteLine("3. Marcar como Concluida");
            Console.WriteLine("4. Remover Tarefa");
            Console.WriteLine("5. Sair");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    try
                    {
                        Tarefa.Tarefa tarefa = new Tarefa.Tarefa();
                        Console.WriteLine("Digite o nome da tarefa:");
                        tarefa.Titulo = Console.ReadLine();
                        Console.WriteLine("Digite o descrição da tarefa: ");
                        tarefa.Descricao = Console.ReadLine();
                        Console.WriteLine("Digite a data de vencimento da tarefa: ");
                        tarefa.DataVencimento = DateTime.Parse(Console.ReadLine());
                        tarefas.Add(tarefa);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Digite a data no seguinte formato yyyy/mm/dd");
                        Console.ReadKey();
                        break;
                    }  
                    
                case 2:
                    foreach (var item in tarefas)
                    {
                        Console.WriteLine($"Titulo: {item.Titulo}, Descrição: {item.Descricao}, Data  Vencimento: {item.DataVencimento}");
                    }
                    break;
                case 3:
                    Tarefa.Tarefa tarefa1 = new Tarefa.Tarefa();
                    Console.WriteLine("Digite qual tarefa quer marcar como concluida");
                    tarefa1.Titulo = Console.ReadLine();
                    foreach (var item in tarefas)
                    {
                        Console.WriteLine("Digite o nome da tarefa:");
                        tarefa1.Titulo = Console.ReadLine();
                        Console.WriteLine($"Deseja concluir a {tarefa1.Titulo}?");
                        Console.WriteLine("Digite True ou False para concluão da tarefa");
                        tarefa1.Concluida = bool.Parse(Console.ReadLine());
                        if (tarefa1.Concluida == true)
                        {
                            Console.WriteLine("Tarefa concluida com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Termine a tarefa: ");
                        }
                    }
                    Console.ReadKey();
                    
                    break;
                
            }
        }
    }
}