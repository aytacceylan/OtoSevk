namespace OtoSevk.Entities
{
	internal class Sevk : IEntity
	{
		public int Id { get; set; }
		public int AracId { get; set; }
		public int AracPlaka { get; set; }
		public int SurucuId { get; set; }
		public DateTime SevkTarihi { get; set; }
		public DateTime? SevkSaati { get; set; }
		public DateTime? SevkDonusTarihi { get; set; }
		public DateTime? SevkDonusSaati { get; set; }
		public string? SevkNedeni { get; set; }
		public string? SevkYeri { get; set; }
		public Arac? Arac { get; set; }
		public int AracKomutaniID { get; set; }
		public string AracKomutaniAdi { get; set; }
		public string AracKomutaniSoyadi { get; set; }
		public AracKomutani? AracKomutani { get; set; }
		public string AracKomutaniTelefon { get; set; }
		public int YapilanKM { get; set; }
		public int YolcuAdedi { get; set; }
		public string? NotlarTasinanYuk { get; set; }
		public string? CikisTuru { get; set; }
  		public string? Acıklamalar{ get; set; }


	}
}
