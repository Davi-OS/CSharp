using TaskSystem.Enuns;

namespace TaskSystem.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public StatusTask Status { get; set; }
        public int? UsuarioId { get; set; }
        public virtual UserModel? Usuario { get; set; }
    }
}
