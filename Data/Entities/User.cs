using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BionicalTechTest.Data.Entities
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string County { get; set; }
        [Required]
        [RegularExpression("^(([gG][iI][rR] {0,}0[aA]{2})|((([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y]?[0-9][0-9]?|(([a-pr-uwyzA-PR-UWYZ][0-9][a-hjkstuwA-HJKSTUW]|([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y][0-9[abehmnprv-yABEHMNPRV-Y])))&[0-9][abd-hjlnp-uw-zABD-HJLNP-UW-Z]{2}))$",ErrorMessage ="Invalid PostCode")]
        public string Postcode { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}