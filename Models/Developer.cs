namespace edd_blazor_server_poc.Models
{
    public sealed class Developer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter last name")]
        public string LastName { get; set; }

        public string PreferredLanguage { get; set; }

        public int Experience { get; set; }

        [Required(ErrorMessage = "Enter country")]
        [Range(1, 4, ErrorMessage = "Enter a country")]
        public int CountryId { get; set; }

        public string OtherCountry { get; set; }
    }
}