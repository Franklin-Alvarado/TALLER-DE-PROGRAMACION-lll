using DadosProject;

bool leave = false;
ManoContext manoContext = new ManoContext();
List<Dado> dados = new List<Dado> { new Dado(), new Dado(), new Dado(), new Dado(), new Dado() };
do
{
    bool isFull = false, isEscalera = false, isPoker = false;
    Console.WriteLine("Lanzamiento de dados:");
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1. Lanzar");
    Console.WriteLine("2. Limpiar");
    Console.WriteLine("3. Salir");

    string option = Console.ReadLine();


    switch (option)
    {

        case "1":
            foreach(Dado dado in dados)
            {
                dado.Lanzar();
                Console.Write(dado.Value + " ");
            }
            Console.WriteLine();
            isFull = manoContext.Verificar(ManoContext.Manos.Full, dados);
            isPoker = manoContext.Verificar(ManoContext.Manos.Poker, dados);
            isEscalera = manoContext.Verificar(ManoContext.Manos.Escalera, dados);
            if (!isFull && !isEscalera && !isPoker) Console.WriteLine("No hay nada"); 
            break;
        case "2":
            Console.Clear();
            break;
        case "3":
            leave = true;
            break;
        default:
            break;
    }
}while (!leave);