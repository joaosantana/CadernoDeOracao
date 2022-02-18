///////////////////////////////////////////////////////
// VARIÁVEIS
///////////////////////////////////////////////////////

var alvo = Argument("alvo", "Testar");
var solucao = "./CadernoDeOracao.sln";

var setupclean = new DotNetCleanSettings
{
    Configuration = "Release"
};

var setupbuild = new DotNetBuildSettings
{
    Configuration = "Release"
};

///////////////////////////////////////////////////////
// TAREFAS
///////////////////////////////////////////////////////

Task("Limpar")
    .Does(() =>
    {
        DotNetClean(solucao, setupclean);
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
        DotNetBuild(solucao, setupbuild);
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

