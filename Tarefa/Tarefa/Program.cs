using Tarefa;


class Program

{

    public static void Main(string[] args)

    { 
        bool continuar = true;
        List<Tarefa.Tarefa> tarefas = new List<Tarefa.Tarefa>();
        while (continuar)
        {
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar Tarefa");
            Console.WriteLine("3. Marcar como Concluida");
            Console.WriteLine("4. Remover Tarefa");
            Console.WriteLine("5. Sair");
            int opcao = int.Parse(Console.ReadLine());
            Tarefa.Tarefa tarefa = new Tarefa.Tarefa();

            switch (opcao)

            {

                case 1:

                    try

                    {
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
                        Console.WriteLine($"Titulo: {item.Titulo}, Descrição: {item.Descricao}, Data Vencimento: {item.DataVencimento}");
                        
                    }
                    break;

                
                case 3:
                    Console.WriteLine("Digite o nome da tarefa: ");
                    tarefa.Titulo = Console.ReadLine();
                    for (int i = 0; i >= 0; i--)
                    {
                        if (tarefas[i].Titulo == tarefa.Titulo)
                        {
                            Console.WriteLine($"Tarefa encontrada: {tarefas[i].Titulo}, {tarefas[i].Descricao}, {tarefas[i].DataVencimento}");
                            Console.WriteLine("Digite sim para concluir");
                            string respota = Console.ReadLine();
                            if (respota.ToLower() == "sim")
                            {
                                Console.WriteLine("Tarefa removida com sucesso!");
                                tarefas.Remove(tarefas[i]);
                            }
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Digite o nome da tarefa: ");
                    tarefa.Titulo = Console.ReadLine();
                    for (int i = 0; i <= tarefas.Count - 1; i++)
                    {
                        Console.WriteLine($"Tarefa encontrada: {tarefas[i].Titulo}, {tarefas[i].Descricao}, {tarefas[i].DataVencimento}");
                        Console.WriteLine("Voce deseja remover a tarefa?");
                        string resposta2 = Console.ReadLine();
                        if (resposta2.ToLower() == "sim")
                        {
                            Console.WriteLine("Tarefa removida com sucesso!");
                            tarefas.Remove(tarefas[i]);
                        }
                    }

                    break;
                case 5:
                    Console.WriteLine("Digite sim para sair");
                    string sair = Console.ReadLine();
                    if (sair.ToLower() == "sim")
                    {
                        continuar = false;
                    }
                    else
                    {
                        Console.WriteLine("Voltando...");
                    }
                    break;

                    

            }

        }

    }

}