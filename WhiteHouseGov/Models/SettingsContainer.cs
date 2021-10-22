using System.ComponentModel.DataAnnotations.Schema;

namespace WhiteHouseGov.Models
{
    public abstract class SettingsContainer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}