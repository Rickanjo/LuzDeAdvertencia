// Faça um simulador do circuito que controla a luz W. Receba o estado de cada um dos sensores ([A]tivado, [D]esativado) e calcule o estado da luz de advertência.
Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
Console.WriteLine("[A]tivado, [D]esativado\n");

Console.Write("Sensor de temperatura...:");
string temp = Console.ReadLine()!;

Console.Write("Sensor de pressão.......:");
string press = Console.ReadLine()!;

Console.Write("Sensor de rotação.......:");
string rot = Console.ReadLine()!;

if (temp == "A" && (press == "A" || rot == "D")) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("luz de advertência estará ATIVADA.");

} else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Luz de advertência estará DESATIVADA.");
}
Console.ResetColor();