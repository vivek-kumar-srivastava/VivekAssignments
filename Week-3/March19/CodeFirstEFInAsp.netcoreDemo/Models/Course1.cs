using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEFInAsp.netcoreDemo.Models
{
    public class Course1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [Column("Stitle",TypeName = "varchar")]
        public String Title { get; set; }

        [Required]
        [MaxLength(220)]
        public string Description { get; set; }

        public float fullprice { get; set; }

        public Author1 Author {  get; set; }  //Creating object To Connect Author1


        [ForeignKey("Author")]                //creating an id of the above object to use it as a foreign key
        public int AuthorId { get; set; }

    }
}
