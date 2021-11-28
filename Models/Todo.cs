using System;

namespace JDTodoList.WebApi.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Tilte { get; set; }
        public bool Done { get; set; }
        public DateTime DataDeCriação { get; set; }
        public DateTime UltimaAtualização { get; set; }
        public string User { get; set; }

    }
}