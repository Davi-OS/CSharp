using System.ComponentModel;

namespace TaskSystem.Enuns
{
    public enum StatusTask
    {
        [Description("A fazer")]
        Afazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido!")]
        Concluido = 3,

    }
}
