using AsyncExamples.Entidades;
using AsyncExamples.Tarefas;

var joao = new Pessoa("Joao");
var maria = new Pessoa("Maria");
var jose = new Pessoa("Jose");

var aguardarIngredientes = Tarefa.AguardarIngredientes(jose);
var comprarFarinha = Tarefa.ComprarFarinha(maria);
var buscarOvos = Tarefa.BuscarOvos(joao);


var tarefaTerminouPriemro = await Task.WhenAny(aguardarIngredientes, comprarFarinha);

if (tarefaTerminouPriemro == comprarFarinha)
{
    await aguardarIngredientes;
    _ = await Tarefa.AssarPao(jose, await buscarOvos, await comprarFarinha);
}

if (tarefaTerminouPriemro == aguardarIngredientes)
    _ = await Tarefa.CozinharOmelete(jose, await buscarOvos);

