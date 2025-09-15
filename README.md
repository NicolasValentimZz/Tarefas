Projeto em C# de um gerenciador de tarefas, onde temos 5 opcções.

1 - Que é a de adicionar tarefas, nela, nós podemos escrever o nome de nossa tarefa, por uma descrição, e tbm uma data de vencimento onde foi posto um tratamento de erro para especificar o jeito da data.

2 - Listar tarefa onde nós podemos ver todas as tarefas cadastradas em nosso sistema.

3 - Marcar como concluida, essa foi a parte mais desafiadora pra mim, me deu um pouco de trabalho e levou dias para ser concluida. Estava usando foreach em vez de usar o laço, o laço for por sua vez
ele vem decrementando até chegar no indice 0, onde atribuimos a varivel i a lista de tarefas. Chegando no indice ele vai me retornar verdadeiro ou falso se a minha tarefa se encontra na lista.
Fazendo essa verificaçào ele me perguntara se desejo concluir a terefa. Marcando sim como resposta entra o if em ação, onde ele está instruido para ler a entrada do usuario. A respota sendo verdadeira
nos passamos para a outra parte do codigo que a remoção da tarefa da lista de "listar tarefas".

4 - Remover tarefas foi a mesma lógica do marcar como concluida. Mas dessa vez foi incrementando na lista "tarefas" até encontrar o valor verdadeiro. Encontrando irá pedir uma entrada via teclado, 
pondo sim, o if entra em açao e no fazemos a remocao da tarefa da lista.

5 - Aqui e encerramneto do programa, onde fazemos uma verricação para enecer ele com if e usando a variavel declrada no começo "continuar".

1 - Tela de Adicionar tarefas.
<img width="1919" height="1080" alt="tela1" src="https://github.com/user-attachments/assets/2934e731-b154-45cf-8154-1e4dee3b5eee" />

Continuação da tela 1.
<img width="1919" height="1080" alt="tela2" src="https://github.com/user-attachments/assets/3595b17d-fdd7-4d32-936c-7ac6e7d991c1" />

Final da Tela 1
<img width="1919" height="1080" alt="tela3" src="https://github.com/user-attachments/assets/99ff0adf-49d0-4a4c-bbe0-77200ca2bb27" />

Resultado final da tela 1
<img width="1919" height="1080" alt="tela4" src="https://github.com/user-attachments/assets/18bdb061-444f-4f0b-902f-25e068115207" />

Lista de tarefas na tela 2. O restante segue o mesmo padrão.
<img width="1919" height="1080" alt="tela6" src="https://github.com/user-attachments/assets/be9ff29d-ffc3-44fd-848a-63d5e7a3cd37" />


