
var alvo = Argument("alvo", "Testar");
var configuracao = Argument("configuracao", "Release");
var solucao = "./CadernoDeOracao.sln";

///////////////////////////////////////////////////////
// TAREFAS
///////////////////////////////////////////////////////

Task("Limpar")
    .Does(() =>
    {
        DotNetClean(solucao);
    });

Task("Restaurar")
    .IsDependentOn("Limpar")
    .Does(() =>
    {
        DotNetRestore();
    });

Task("Compilar")
    .IsDependentOn("Restaurar")
    .Does(() =>
    {
        DotNetBuild(solucao);
    });

Task("Testar")
    .IsDependentOn("Compilar")
    .Does(() =>
    {
        DotNetTest();
    });

///////////////////////////////////////////////////////
// EXECUÇÃO
///////////////////////////////////////////////////////

RunTarget(alvo);

