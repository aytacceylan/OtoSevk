using System.ComponentModel.DataAnnotations;

namespace OtoSevk.Entities
{
	public class Arac : IEntity
	{
		public int Id { get; set; }
		public int MarkaId { get; set; }
		[StringLength(50)]
		public int AracPlaka { get; set; }
		public string Renk { get; set; }
		public decimal Fiyati { get; set; }
		[StringLength(50)]
		public string Modeli { get; set; }
		[StringLength(50)]
		public string KasaTipi { get; set; }
		public  int ModelYili { get; set; }	
		public bool GorevdeMi { get; set; }	
		public string Notlar { get; set; }
		public Marka? Marka { get; set; }

	}
}
