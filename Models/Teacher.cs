using System;
using System.ComponentModel.DataAnnotations;
using ProyectoOctavoSEP.Models;


namespace ProyectoOctavoSEP.Models
{
    public class Teacher 
    {
       [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string CI { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string Mail { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone { get; set; }



    }
}
