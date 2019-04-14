using BackendFinal.Db.Models.Contracts;

namespace BackendFinal.Db.Models
{
    public class Model : IIdentifiable
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
