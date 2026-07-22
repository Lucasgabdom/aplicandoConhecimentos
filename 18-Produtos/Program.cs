ClienteVIP cliente1 = new ClienteVIP("Ouro", "VIP123", "João Silva", 35);
ClienteVIP cliente2 = new ClienteVIP("Prata", "VIP456", "Maria Souza", 28);


Console.WriteLine(@$"Cliente: {cliente1.Nome} 
Idade: {cliente1.Idade}
Nível VIP: {cliente1.NivelVIP}
Código VIP: {cliente1.CodigoVIP}");

Console.WriteLine($@"Cliente: {cliente2.Nome}
Idade: {cliente2.Idade}
Nível VIP: {cliente2.NivelVIP}
Código VIP: {cliente2.CodigoVIP}");