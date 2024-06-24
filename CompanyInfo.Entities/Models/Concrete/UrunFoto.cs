using CompanyInfo.Entities.Models.Abstract;

namespace CompanyInfo.Entities.Models.Concrete
{
    public class UrunFoto :BaseEntity
    {
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public string Name { get; set; }
        public string? FileType { get; set; }
        public string? FilePath { get; set; }
        public byte[] DataFiles { get; set; }


    }
}