# Escalonador

### FCFS (First Come FirstServed).
A implementação deste algoritmo é bastante simples: basta uma fila simples para 
gerenciar os processos. Uma vez que o processo ganhe o uso da CPU, aguarda-se seu 
término para pegar o próximo da fila.


### SJF (Shortest Job First) ###
Neste esquema, o processo que declarar o menor tempo de  utilização da CPU e estiver 
disponível para escalonamento, será o escolhido.


### RR (Round Robin) ###
É um escalonamento  com fila circular e onde todos os processos possuem a mesma fatia 
de tempo (quantum) para usar a CPU. Caso o processo não termine nesta fatia de tempo, 
ele volta para a fila de processos prontos para esperar a próxima rodada de execução.

### SRTF (Shortest Remaining Time First)
É um escalonamento cooperativo, ou seja, uma vez que uma tarefa recebe o processador, 
ela executa até encerrar (ou liberá-lo explicitamente). 
Em uma variante preemptiva, o escalonador deve comparar a duração prevista de cada 
nova tarefa que ingressa no sistema com o tempo de processamento restante das 
demais tarefas presentes, inclusive aquela que está executando no momento.

### PRIOc e PRIOp
Processos com prioridade mais alta possuem probabilidade de serem escalonados mais 
vezes. Uma maneira bastante simples de controle de processos com prioridade é com a 
utilização de múltiplas filas de processos, uma para cada prioridade.
No escalonamento por prioridade preemptivo (PRIOp), quando uma tarefa de maior 
prioridade se torna disponível para execução, o escalonador entrega o processador a ela, 
trazendo a tarefa atualmente em execução de volta para a fila de prontas, ou seja, a 
tarefa em execução pode ser “preemptada” por uma nova tarefa mais prioritária.