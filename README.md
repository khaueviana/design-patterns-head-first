Design Patterns - Head First
==============
Nesse projeto apresento alguns Design Patterns, tendo como referência o livro (clichê, mas útil) Use a Cabeça (Head First) - Design Patterns

Padrões Criacionais
-------------------

Envolvem a criação de instâncias de objetos; todos fornecem alguma maneira de desconectar o cliente dos objetos a partir dos quais serão geradas instâncias.

Exemplos:

	* Singleton
	* Prototype
	* Builder
	* Factory Method
	* Abstract Factory


Padrões Estruturais
-------------------

Permitem que você organize classes ou objetos em estruturas maiores

Exemplos:

	* Decorator
	* Composite
	* Facade
	* Bridge
	* FlyWeight
	* Adapter


Padrões Comportamentais
-----------------------

Preocupam-se com a forma como as classes e objetos interagem e com a distribuição de responsabilidades

Exemplos:

	* Template Method
	* Mediator
	* Visitor
	* Iterator
	* Memento
	* Command Strategy
	* Interpreter
	* Chair of Reponsability
	* State Observer

Padrões
=======

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

![enter image description here](https://lh3.googleusercontent.com/-s8wVMaqai3c/V5Vp8ydkvzI/AAAAAAAAc1I/AqUrfJCftmIS_qZfnXJs3NBq3ibsSroAACLcB/s0/proxy.gif "proxy.gif")

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

Capítulo 1
==========

Grande software em três etapas simples:

	1.  Verifique se o seu software faz o que o cliente deseja que ele faça
	2. Aplique os princípios básicos da OO para adicionar flexibilidade
	3. Empenhe-se para ter um projeto reutilizável e que possa ser mantido

Não crie problemas para resolver problemas

Use uma descrição textual do problema que você está tentando resolver para garantir que o seu projeto esteja alinhado à funcionalidade esperada de sua aplicação.

	1. Os objetos devem fazer o que seus nomes indicam. Se um objeto é chamado de Jato, ele provavelmente deve decolar(), aterrissar(), mas não deve ter pegarPassagem() – isso é tarefa de outro objeto e não pertence a Jato.

	2. Cada objeto deve representar um único conceito. Você não deseja objetos, que tenham duas ou três tarefas. Evite um objeto Pato que represente um pato real, um pato de borracha e alguém que caia em qualquer golpe bobo.

	3. As propriedades não utilizadas são um peso morto. Se você possui um objeto que é frequentemente usado com propriedade sem valor ou nulas, provavelmente haverá um objeto executando mais de uma tarefa. Se você raramente possui valores para uma determinada propriedade, por que ela faz parte do objeto? Será que não podemos usar um objeto melhor  com somente um subconjunto dessas propriedades?


Encapsulamento, conceito baseado no projeto do Head First.
----------------------------------------------------------

O encapsulamento também está relacionado à divisão de sua aplicação em partes lógicas, além de mantê-las separadas. Assim da mesma forma que você mantém os dados de suas classes separados do resto do comportamento da sua aplicação, podemos manter as propriedades genéricas de uma guitarra separadas do próprio objeto Guitar.

Esse é o poder do encapsulamento: ao dividir sua aplicação em partes diferentes, você pode alterar uma parte sem precisar mudar as outras. Em geral, você deve encapsular as partes da sua aplicação que possam varias separadas das partes que permanecerão as mesmas.

Delegar
-------

 A delegação acontece quando um objeto precisa executar uma certa tarefa e, em vez de executá-la diretamente, ele solicita que outro objeto lide com ela (ou, em algumas ocasiões, lide com somente uma parte da tarefa). Assim, neste quebra-cabeça de projeto, você quer que o método search() de Inventory peça que GuitarSpech diga se duas especificações são iguais, em vez de comparar os dois objetos GuitarSpec diretamente, no próprio método search().search() delega a comparação GuitarSpec.
 

A delegação permite que cada objeto se preocupe com a sua própria regularidade (ou com alguma outra tarefa). Isso significa que os seus objetos são mais independentes uns dos outros, ou mais livremente unidos. Os objetos livremente unidos podem ser retirados de uma aplicação e facilmente reutilizados em outra, uma vez que eles não estão totalmente amarrados ao código de outros projetos.

Os objetos estão livremente unidos em sua aplicação quando cada um possui uma única tarefa específica, não executando qualquer outra. Assim, a funcionalidade da sua aplicação é espalhada por vários objetos bem definidos, que realizam uma única tarefa de forma muito eficiente.

As aplicações livremente unidas geralmente são mais flexíveis e fáceis de alterar. Uma vez que cada objeto e bastante independente dos outros, você pode fazer uma alteração no comportamento de um objeto sem ter de alterar todos os outros. Portanto, adicionar novos recursos ou funcionalidades se torna muito mais fácil.

**DEFINIÇÃO SIMPLES: Ato de um objeto encaminhar uma operação para outro objeto, a ser executada em nome do primeiro.**

**BULLETS**

	* Não é preciso muita coisa para que algo dê errado com uma aplicação frágil.

	* Você pode usar princípios da OO, como encapsulamento e delegação, para criar aplicações flexíveis.

	* O encapsulamento divide sua aplicação em partes lógicas.

	* A delegação oferece outro objeto a responsabilidade de lidar com uma determinada tarefa.

	* Sempre inicie um projeto pela descoberta do que o cliente deseja.

	* Depois de deixar a funcionalidade básica de uma aplicação funcionando, trabalhe no refinamento do projeto para que ela se torne flexível.

	* Com um projeto funcional e flexível, você pode empregar padrões de projeto para aperfeiçoá-lo e para tornar a sua aplicação mais fácil de reutilizar.

	* Descubra as partes da sua aplicação que estão em constante mudança e tente separá-las das partes que não mudam.

	* Criar uma aplicação que funcione bem mas que possua um projeto fraco deixará o cliente satisfeito, embora deixe para você a dor, o sofrimento e várias noites corrigindo os problemas.

	* Análise e Projeto de Orientação a Objetos (AePOO) oferece uma maneira de produzir aplicações bem projetadas que satisfaz tanto o cliente como o programador.
