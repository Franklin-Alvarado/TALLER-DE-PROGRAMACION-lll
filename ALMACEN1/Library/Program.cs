using Library;

Console.WriteLine("Storage");

Storage storage = new Storage("SUCCESS TECNOLOGY", "VILLAZON KM 6.5");

bool close = false;
do
{
    close = storage.MostrarOpciones();
} while (!close);

