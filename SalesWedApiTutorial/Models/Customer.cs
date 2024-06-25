using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWedApiTutorial.Models;

public class Customer {

    public int id {  get; set; }
    [StringLength(30)]
    public string name { get; set; } = string.Empty;
    [StringLength(30)]
    public string city { get; set; } = string.Empty;
    [StringLength(2)]
    public string State { get; set; } = string.Empty;
    [Column(TypeName = "decimal(9,2)")]
    public decimal Sales { get; set; }
    [Column(TypeName = "bit")]
    public bool Active { get; set; }    

}
