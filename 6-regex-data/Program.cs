using System.Globalization;

Console.WriteLine("====== MENU DE DATAS ======\n");

var cultura = new CultureInfo("pt-BR");

var agora = DateTime.Now;

string formatoCompleto = agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", cultura);

string apenasData = agora.ToString("dd/MM/yyyy", cultura);

string apenasHora = agora.ToString("HH", cultura);

string dataMesExtenso = agora.ToString("dd 'de' MMMM 'de' yyyy", cultura);

Console.WriteLine($"Formato Completo: {formatoCompleto}");
Console.WriteLine($"Apenas Data: {apenasData}");
Console.WriteLine($"Apenas Hora: {apenasHora}");
Console.WriteLine($"Data com mês por extenso: {dataMesExtenso}\n");

Console.WriteLine("====== MENU DE DATAS ======\n");