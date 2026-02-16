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
		public bool AktifMi { get; set; }


	}
}
