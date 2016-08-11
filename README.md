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

Capítulo 2
==========

O que é um requisito?
---------------------

É uma função específica que o seu sistema deve realizar para funcionar corretamente.

Um requisito é uma necessidade única que detalha o que um produto ou serviço em particular deve ser ou fazer. É mais comumente utilizado em um sentido formal na engenharia de sistemas ou engenharia de software.

Ouça o cliente
--------------

Quando se trata de requisitos, a melhor coisa que você pode fazer é deixar o cliente falar. E preste atenção no que o sistema precisa fazer; você pode descobrir como ele fará as coisas mais tarde.

**Planeje para quando as coisas derem errado!**

Caso de uso
-----------

Um caso de uso descreve o que o seu sistema faz para atingir um determinado objetivo do cliente.

Um caso de uso é uma técnica de captura de requisitos potenciais de um novo sistema ou de uma alteração no software. Cada caso de uso oferece uma ou mais situações que conduzem a como o sistema deve interagir com o usuário final ou com outro sistema para atingir um objetivo específico.

Um caso de uso, três partes
---------------------------

**Valor evidente**
Todos os casos de uso devem ter um valor evidente para o sistema. Se ele não ajudar o cliente a atingir seu objetivo, então não servirá para muita coisa.

**Início e fim**
Todos os casos de uso devem ter um ponto de partida e um ponto de chegada definidos. Algo deve iniciar o processo, e em seguida, deve haver uma condição que indique que o processo foi concluído.

**Iniciador externo**
Todos os casos de uso são disparados por um iniciador externo ao sistema. Em algumas ocasiões, esse iniciador é uma pessoa, mas ele poderia ser qualquer coisa fora do sistema.

Exemplo de um caso de uso:

Porta para cachorros do John e Tex
Ator principal: Tex
Ator Coadjuvante: John
Pré-condições:  A porta para cachorros está aberta para que Tex volte para dentro
Objetivo: Tex utiliza o banheiro e volta para dentro de casa sem trazer lama consigo

Caminho principal:

	1. Tex sai
	2. A porta para cachorros fecha automaticamente.
	3. Tex faz o que queria fazer.
	4. John pressiona um botão.
	5. A porta para cachorros abre.
	6. Tex volta para dentro.
	7. A porta fecha automaticamente.

Extensões:

	3.1. Tex se suja com a lama
	3.2. John limpa o Tex

**BULLETS**

	* Os requisitos são aquilo que deve funcionar corretamente em seu sistema.
	* Seus requisitos iniciais normalmente serão obtidos do cliente.
	* Para garantir que você possui um bom conjunto de requisitos, você deve desenvolver casos de uso para o seu sistema.
	* Um caso de uso possui um único objetivo, mas pode ter vários caminhos para alcançá-lo.
	* Um bom caso de uso possui uma condição inicial e uma final, um iniciador externo e um valor evidente para o usuário.
	* Um caso de uso é simplesmente uma estória sobre como o seu sistema funciona.
	* Você terá pelo menos um caso de uso para cada objetivo que o seu sistema deverá cumprir.
	* Depois que os seus casos de uso estiverem concluídos, você poderá refinar e adicionar requisitos.
	* Uma lista de requisitos que torna todos os seus casos de uso possíveis é um bom conjunto de requisitos.
	* O sistema deve funcionar no mundo real e não somente quando tudo ocorre conforme o esperado.
	* Quando algo dá errado, o seu sistema deve possuir caminhos alternativos para atingir seus objetivos.

Capítulo 3
==========

A única constante da análise e projeto de software
--------------------------------------------------

Os requisitos sempre mudam. Entretanto, se você tiver bons casos de uso, normalmente poderá alterar o seu software rapidamente para se ajustar aos novos requisitos.

Um caminho completo de um caso de uso, da primeira etapa até a última, é chamado de situação.

A maioria dos casos de usos possui várias situações diferentes, mas elas sempre compartilham o mesmo objetivo do usuário.

**BULLETS**

	* Os requisitos sempre mudarão à medida que o projeto avançar.
	* Quando os requisitos mudam, o seu sistema deve evoluir para lidar com os novos requisitos.
	* Quando o seu sistema precisar funcionar de uma nova maneira ou de uma forma diferente, comece por atualizar o seu caso de uso.
	* Uma situação é um caminho único em um caso de uso, do início ao fim.
	* Um único caso de uso pode ter várias situações, desde que cada uma possua o mesmo objetivo do cliente.
	* Os caminhos alternativos podem ser etapas que ocorrem somente algumas vezes ou que oferecem caminhos totalmente diferentes por meio de partes de um caso de uso.
	* Se uma etapa for opcional no funcionamento de um sistema, ou se ela oferecer um caminho alternativo, usa as sub-etapas numeradas, como 3.1,4.1 e 5.1 ou 2.1.1, 2.2.1 e 2.3.1.
	* Quase sempre você deve tentar evitar o código duplicado. É um pesadelo para a manutenção e normalmente aponta para problemas na forma como o sistema foi projetado.

Capítulo 4
==========

A análise ajuda você a garantir o funcionamento do seu sistema em um contexto do mundo real.

A chave para garantir que as coisas funcionem e que o mundo real não acabe com a sua aplicação é a análise: descobrir potenciais problemas e então resolvê-los antes que você libere a sua aplicação para o mundo real.

**A PRIMEIRA ETAPA DE UMA BOA ANÁLISE É O DESCOBRIMENTO DE POTENCIAIS PROBLEMAS**

Normalmente há mais de uma maneira de resolver um problema, e nem sempre há somente solução “correta”.

Escreva os seus casos de uso de uma forma que faça sentido para você, para o seu chefe e para os seus clientes.

A análise e os seus casos de uso permitem que você mostre aos clientes, aos gerentes e a outros desenvolvedores como o seu sistema funciona em um contexto de mundo real.

Delegação
---------

A delegação protege seus objetos das mudanças de implementação feitas em outros objetos do software.

Observação UML: nameMethod: Atribute [*] ← indica a multiplicidade de um atributo: a quantidade de um certo tipo que pode ser armazenado pelo atributo.

Caso de Uso
-----------

Os substantivos de um caso de uso são normalmente as classe que precisam ser escritas e priorizadas em um sistema.

O exame dos substantivos (e dos verbos) do seu caso de uso para descobrir as classes e o métodos é chamado de análise textual.

Um bom caso de uso explica clara e precisamente que um sistema faz, em uma linguagem que pode ser facilmente compreendida.

Após a conclusão de um bom caso de uso, a análise textual é uma maneira fácil e rápida de descobrir as classes do seu sistema.

Preste atenção nos substantivos do seu caso de uso, mesmo quando eles não forem classes do seu sistema.

Pense como as classes que você possui podem oferecer suporte ao comportamento descrito pelo seu caso de uso.

Os verbos do seu caso de uso serão (normalmente) os métodos dos objetos do seu sistema
------------------------------------------------------------------------

Os substantivos do seu caso de uso normalmente são um bom ponto de partida para a descoberta das classes necessárias em seu sistema. Se você examinar os verbos do seu caso de uso, normalmente descobrirá os métodos necessários para os objetos que tais classes representam.

Os diagramas de classes são uma ótima maneira de obter uma visão geral do seu sistema e de mostrar suas partes para colegas e para outros programadores. Mas ainda há muita coisa que eles não mostram.

	1. Os diagramas de classe oferecem informações limitadas sobre o tipo
	2. Os diagramas de classe não dizem como você deve codificar seus métodos
	3. Os diagramas de classe oferecem somente uma visão geral do seu sistema

**BULLETS**

	* A análise ajuda você a garantir que o se u software funciona no contexto do mundo real e não somente em uma ambiente perfeito.
	* Os casos de uso devem ser entendidos por você, por seus gerentes, por seus clientes e por outros programadores.
	* Você deve escrever seus casos de uso no formato que tiver mais utilidade para você e para as outras pessoas que os examinarão.
	* Um bom caso de uso apresenta com precisão o que um sistema faz, mas não indica como ele executará essa tarefa.
	* Cada caso de uso deve se concentrar em apenas um objetivo do cliente. Se você tiver vários objetivos, precisará escrever vários casos de uso.
	* Os diagramas de classe oferecem uma maneira fácil de mostrar o seu sistema e a construção do seu código em uma visão geral.
	* Os atributos de um diagrama de classes normalmente mapeiam as variáveis membro das suas classes.
	* As operações em um diagrama de classes normalmente representam os métodos das suas classes.
	* Os diagramas de classes ignoram vários detalhes, como os construtores de classes, algumas informações sobre os tipos e a finalidade das operações das suas classes.
	* A análise textual ajuda você a traduzir um caso de uso para as classes, atributos  operações do código.
	* Os substantivos de um caso de uso são candidatos a classes de seu sistema e os verbos são candidatos a métodos das classes do seu sistema.

Bullets - Opções além da herança
======================

Delegação
-------------

Quando você entrega a responsabilidade de uma determinada tarefa para outra classe ou método.

A delegação é melhor utilizada quando você deseja usar a funcionalidade de outra classe, ou seja, sem alterar o comportamento.

Se você precisa usar funcionalidade em outra classe, mas não deseja mudá-la, considere o uso da delegação em vez da herança.

Delegue comportamento à outra classe quando você não quiser alterá-lo, mas não é responsabilidade do seu objeto implementar tal comportamento por conta própria.

Se você precisar de comportamento de outra classe, mas não precisar alterá-lo, basta delegar para tal classe para usar o comportamento desejado.

Composição
----------

Use a composição para juntar comportamento de outras classes.
Quando referenciamos todas uma família de comportamentos estamos usando composição.

A composição é mais poderosa quando você deseja usar o comportamento definido em um interface, e então opta por uma das implementações da interface, tanto no tempo de compilação como no tempo de execução.

A composição permite que você utilize o comportamento de uma família de outras classes e altere no tempo de execução.

Em uma composição, o objeto composto de outros comportamentos possui tais comportamentos. Quando o objeto é destruído, seus comportamentos também o serão.

Os comportamentos em uma composição não existem fora da própria composição.

Agregação
---------

O que acontece quando você deseja todos os benefícios da composição – flexibilidade ao escolher um comportamento e conformidade com o LSP - , mas os seus objetos compostos precisam existir fora do seu objeto principal? = AGREGAÇÃO!

Quando uma classe é usada como parte de outra classe, mas ainda assim existe fora dela.

Agregação versus composição
---------------------------

É fácil ficarmos confusos em relação a quando usar composição e quando devemos usar agregação. A forma mais fácil de descobrir qual delas usar é perguntando a si mesmo o objeto cujo comportamento eu quero utilizar existe fora do objeto que usa seu comportamento.

Se o objeto fizer sentido por conta própria, então você deve usar a agregação; caso contrário, utilize a composição. Mas tenha cuidado! Algumas vezes, uma mudança mínima no uso dos seus objetos pode fazer toda a diferença.

Composição
----------

Você pode reutilizar o comportamento de uma ou mais classes, em particular de uma família de classes, com a composição. O seu objeto **possui completamente** os objetos compostos e eles não existem fora da utilização desse objeto.

A composição permite que você escolha um comportamento de uma família de comportamentos, quase sempre por meio de implementações de uma interface.

Quando você utiliza a composição, o objeto composto possui os comportamentos que utiliza, que deixarão de existir assim que o objeto composto for destruído.

Agregação
---------

Quando você quiser obter as vantagens da composição, mas estiver usando o comportamento de um objeto que existe fora do seu objeto, utilize a agregação.

A agregação permite que você use os comportamentos de outras classe sem limitar o tempo de vida desses comportamentos.

Os comportamentos agregados continuam a existir mesmo depois que o objeto agregado seja destruído.

Bullets - Arquitetura
=====================


A arquitetura é a sua estrutura de projeto e destaca as partes mais importantes da sua aplicação e os relacionamentos entre elas.

A arquitetura é a estrutura organizacional de um sistema, incluindo a sua decomposição em partes, sua conectividade, mecanismos de interação e os princípios e decisões norteadores utilizados no projeto.

As partes da sua aplicação que são realmente importantes são arquiteturalmente significativas e você deve se concentrar nelas PRIMEIRO.

Nos projetos menores, nós usamos uma lista de requisitos para escrever a 
funcionalidade; nos projetos maiores, temos usado uma lista de recursos para descobrir como as coisas funcionam.

As três perguntas da arquitetura

	1 Ele faz parte da essência do sistema. 
	  
	  O recurso é realmente fundamental para a função do sistema? Pense desta maneira: você pode imaginar o sistema sem tal recurso? Se a resposta for negativa, então provavelmente você encontrou um recurso que faz parte da essência de um sistema.
	  
	2 Mas o que isso significa?
	
	  Se você não ter certeza sobre o que realmente significa a descrição de um determinado recurso, é provável que seja muito importante prestar atenção nele. Sempre que estiver indeciso sobre o que algo significa, você pode perder muito tempo ou criar problemas para o resto do sistema. Passe um tempo com esses recursos no início, em vez de deixar para mais tarde.
	  
	3 Como eu faço isto?
	
	  Outro local em que você deve prestar atenção logo cedo é nos recursos que parecem ser realmente difíceis de implementar, ou nas tarefas de programação totalmente novas para você. Se você não tem menor ideia de como vai lidar com um determinado problema, é melhor passar algum tempo antes examinando esse recurso, para que ele não crie um monte de problemas pelo caminho.

A essência de um sistema é o que é no seu nível mais básico.

Concentre-se em um recurso por vez para reduzir os riscos em seu projeto.

Não se distraia com recursos que não ajudarão a reduzir os riscos.

A arquitetura é a sua estrutura de projeto e destaca as partes mais importantes da sua aplicação e os relacionamentos entre elas.

Os atributos comuns são mais do que simplesmente nomes de propriedades... Você precisa fazer um exame mais profundo.

Análise dos atributos comuns: o caminho para o software flexível.
O bom projeto reduzirá os riscos.

Algumas vezes a melhor forma de escrever um grande código é adiar essa atividade o máximo que você puder.

**Indecisão sobre um recurso:**

**1 Pergunte ao cliente.**
**O que o recurso significa?**

**2 Análise dos atributos comuns:**
**Como eu posso usar este recurso no meu sistema?**

**3 Plano de implementação.***

Os clientes não pagam você para obterem um grande código, eles o pagam para terem um grande software.

**BULLETS**

	* A arquitetura ajuda você a transformar todos os seus diagramas, planos e listas de recursos em uma aplicação bem ordenada.
	* Os recursos do seu sistema que são mais importantes para o projeto são arquiteturalmente significativos.
	* Concentre-se primeiro nos recursos que são a essência do seu sistema, cujos significados não estejam claros ou que você não saiba como eles serão implementados.
	* Tudo o que você fizer nas fases arquiteturais de um projeto deve reduzir os riscos ao sucesso do seu projeto.
	* Se você ão precisar de todos os detalhes de um caso de uso, pode escrever uma situação detalhando como o seu software poderia ser usado para ajudá-lo a obter requisitos mais rapidamente.
	* Quando você não estiver certo dobre o significado de um recurso, converse com o cliente e então tente generalizar as respostas obtidas para ter um bom entendimento sobre o recurso.
	* Utiliza a análise dos atributos comuns para criar soluções de software flexíveis.
	* Os clientes estão muito mais interessados em um software que faça o que eles querem e que seja entregue no prazo do que no código que você acha que está muito legal.
