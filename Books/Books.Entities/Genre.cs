using System.ComponentModel.DataAnnotations;

namespace Books.Entities
{
    public enum Genre
    {
        [Display(Name="Non Fiction")]
        NonFinction,
        Romance,
        Action,
        [Display(Name = "Science Fiction")]
        ScienceFiction
    }
}
