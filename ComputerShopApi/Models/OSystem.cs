using System.ComponentModel.DataAnnotations;
using System.Net.Quic;

namespace ComputerShopApi.Models
{
    public class OSystem
    {
        [Key]
        [MaxLength(36)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Version {  get; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
