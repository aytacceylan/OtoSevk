using System.ComponentModel.DataAnnotations;

namespace OtoSevk.Entities
{
	public class Surucu : IEntity
	{
		public int Id { get; set; }
		[StringLength(50)]
		public string Adi { get; set; }
		[StringLength(50)]
		public string Soyadi { get; set; }
		[StringLength(50)]
		public string Email { get; set; }
		[StringLength(20)]
		public string Telefon { get; set; }
		[StringLength(50)]
		public string SurucuAdi { get; set; }
		[StringLength(50)]
		public string Sifre { get; set; }
		[StringLength(50)]
		public int RolId { get; set; }
		public bool AktifMi { get; set; }
		public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;




	}
}
