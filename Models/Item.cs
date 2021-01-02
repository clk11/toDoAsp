using System.ComponentModel.DataAnnotations;

namespace project.Models{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime data { get; set; }
    }
}