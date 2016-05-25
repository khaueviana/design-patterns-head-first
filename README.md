Design Pattern
==============
Nesse projeto apresento alguns Design Patterns, tendo como referência o livro (clichê, mas útil) Use a Cabeça - Design Patterns.

Abstract Factory Design Pattern
-------------------------------
O padrão Abstract Factory fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.
Utilização da composição de objetos: a criação de objetos é implementada em métodos expostos na interface de fábrica.

Adapter Design Pattern
----------------------
Padrão Adapter converte a interface de uma classe para outra interface que o cliente espera encontrar. O adaptador permite que classes com interfaces incompatíveis trabalhem juntas.
  
Command Design Pattern
----------------------
O Padrão Command encapsula uma solicitação como um objeto, o que lhe permite parametrizar outros objetos com o diferentes solicitações, enfileirar ou registrar solicitações e implementar recursos de cancelamento de operações.

Composite Design Pattern
------------------------
O Padrão Composite permite que você componha objetos em estruturas de árvore para representar hierarquias parte-todo (árvore de objetos que são feitos de partes). Com esse padrão, os clientes podem tratar objetos individuais ou composições de objetos de maneira uniforme.

O Padrão Composite permite construir estruturas de objetos na forma de árvores, contendo tanto composições de objetos como objetos individuais atuando como nós.

Usando uma estrutura composta, podemos aplicar as mesmas operações tanto à composição como a objetos individuais. Em outras palavras, na maioria dos casos ignorar as diferenças entre composições de objetos e objetos individuais.

![Diagrama Composite Design Pattern](https://lh3.googleusercontent.com/-2-4t2osOYDo/V0UOpAMl7-I/AAAAAAAAcdk/pDzRFBxruNId58i25cK1x-nYPYTmkxueACLcB/s0/CompositeDiagram.png "CompositeDiagram.png")

Decorator Design Pattern
------------------------
Padrão Decorator anexa responsabilidades adicionais a um objeto dinamicamente. Os decoradores fornecem uma alternativa flexível de subclasse para estender a funcionalidade.

Facade Design Pattern
---------------------
O Padrão Facade fornece uma interface unificada para um conjunto de interface em um subsistema. A fachada define uma interface de nível mais alto que facilita a utilização do subsistema.

Factory Method Design Pattern
-----------------------------
O padrão Factory Method define uma interface para criar um objeto, mas permite às classes decidir qual classe instanciar. O Factory Method permite a uma classe deferir a instanciação para subclasses.

Utiliza a herança, a criação de objetos é delegada a subclasses que implementam o método fábrica para criar objetos.

Iterator Design Pattern
-----------------------
O padrão Iterator fornece uma maneira de acessar sequencialmente os elementos de um objeto agregado sem expor a sua representação subjacente.
  ![Diagrama Iterator Design Pattern](https://lh3.googleusercontent.com/-LMy2fB05z8Y/V0UO5tdKvuI/AAAAAAAAcds/reAo2GiP5A0iZ6qLdJQ5iOMoMEwqqgyewCLcB/s0/IteratorDiagram.png "IteratorDiagram.png")
  
Observer Design Pattern
-----------------------
Padrão Observer define a dependência um-para-muitos entre objetos para que quando um objeto mude de estado todos os seus dependentes sejam avisados e atualizados automaticamente.

Proxy Design Pattern
--------------------
O Padrão Proxy fornece um substituto ou representante de outro objeto para controlar o acesso a ele.

 - O Proxy controla o acesso a um objeto remoto; 
 - Um Proxy Virtual controla o acesso a um recurso cuja criação é onerosa; 
 - Um Proxy de proteção controla o acesso a um recurso com base em direitos de acesso.

Singleton Design Pattern
------------------------
O Padrão Singleton garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.

O Singleton pode ter um problema de múltiplos acessos, para isso é necessário utilizar o “syncronized” do java ou “lock” do C#.

State Design Pattern
--------------------
O Padrão State permite que um objeto altere o seu comportamento quando o seu estado interno muda. O objeto parecerá mudado de classe.

![Diagrama State Design Pattern](https://lh3.googleusercontent.com/-ax3w8XYjkbE/V0UPG6dviEI/AAAAAAAAcd0/fboxk6diw7wzDZAxGuE-5QY-lbtxyafhQCLcB/s0/StateDiagram.png "StateDiagram.png")

**State x Stategy**

Com o Padrão State, temos um conjunto de comportamentos encapsulados em objetos de estado; a qualquer momento, o contexto está delegando tarefas a um desses estados. Com o tempo, o estado atual muda para um dos demais objetos de estado para refletir o estado interno do contexto; portanto, o comportamento do próprio contexto também muda ao longo do tempo. O cliente geralmente sabe muito pouco ou nada sobre os objetos de estado.

Com Stategy, o cliente geralmente especifica o objeto de estratégia com o qual o contexto é composto. Nesse caso, embora o padrão proporcione a flexibilidade necessária para mudar o objeto de estratégia durante a execução, frequentemente há um objeto de estratégia que é mais apropriado para um objeto de contexto.

Via de regra, deve-se pensar no Padrão Strategy como uma alternativa flexível à criação de subclasses; quando você usa hereditariedade para definir comportamento de uma classe, o resultado é um comportamento imutável mesmo que seja necessário introduzir alterações. Com a Stategy, você pode mudar o comportamento estabelecendo uma composição com um objeto diferente.

O padrão State, por sua vez, deve ser encarado como uma alternativa à inclusão de uma longa lista de instruções condicionais no seu contexto; ao encapsular os comportamentos dentro de objetos de estado, você pode simplesmente mudar o objeto de estado para mudar o comportamento do contexto.

Strategy Design Pattern
-----------------------
Padrão Strategy define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis. A estratégia deixa o algoritmo variam independentemente dos clientes que o utilizam.

Template Method Design Pattern
------------------------------
O Padrão Template Method define o esqueleto de um algoritmo dentro de um método, transferindo alguns de seus passos para as subclasses. O Template Method permite que as subclasses redefinam certos passos de um algoritmo sem alterar a estrutura do próprio algoritmo.

**Utilizando Gancho / Hook**

Um ganhco ou hook é um método que é declarado na classe abstrata mas só recebe como padrão uma implementação vazia. Isto permite que as subclasses usem o gancho para se conectarem ao algoritmo em vários pontos, caso assim o desejem; uma subclasse também pode simplesmente ignorar o gancho.

O gancho deve ser um comportamento opcional.


  
