//### **4. Conta Corrente e Conta Poupança**
// Utilizando a classe `ContaBancaria` criada no exercício 1, crie duas subclasses:
//- `ContaCorrente`: possui um método `CobrarTaxa()` que reduz o saldo em um valor fixo (ex: 10).
//- `ContaPoupanca`: possui um método `RenderJuros()`, que aumenta o saldo em 5%.
//Crie instâncias de ambas as classes, faça depósitos e utilize seus métodos específicos.

using ExerciciosHeranca;

ContaPoupanca poupeBem = new ContaPoupanca();
poupeBem.Depositar(1000);
poupeBem.VerSaldo();
poupeBem.RenderJuros();


ContaCorrente correnteBem = new ContaCorrente();
correnteBem.Depositar(1000);
correnteBem.VerSaldo();
correnteBem.RenderJuros();
correnteBem.VerSaldo();