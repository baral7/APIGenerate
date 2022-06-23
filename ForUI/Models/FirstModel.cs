using System.ComponentModel.DataAnnotations;

namespace ForUI.Models
{
    public class FirstModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

    }
}
