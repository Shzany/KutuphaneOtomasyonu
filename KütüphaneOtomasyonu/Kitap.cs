using System;
using System.Text.Json.Serialization;

namespace K�t�phaneOtomasyonu
{
    public class Kitap
    {
        [JsonPropertyName("isbn")]
        public string ISBN { get; set; }

        [JsonPropertyName("ad")]
        public string Ad { get; set; }

        [JsonPropertyName("yazar")]
        public string Yazar { get; set; }

        [JsonPropertyName("yayinEvi")]
        public string YayinEvi { get; set; }

        [JsonPropertyName("sayfaSayisi")]
        public int SayfaSayisi { get; set; }

        [JsonPropertyName("kategori")]
        public string Kategori { get; set; }

        [JsonPropertyName("yayinTarihi")]
        public string YayinTarihi { get; set; }

        [JsonPropertyName("oduncAlanTC")]
        public string OduncAlanTC { get; set; }

        [JsonPropertyName("oduncTarihi")]
        public string OduncTarihi { get; set; }

        [JsonPropertyName("iadeTarihi")]
        public string IadeTarihi { get; set; }

        [JsonConstructor]
        public Kitap()
        {
            // Initialize with empty strings to prevent null reference exceptions
            ISBN = string.Empty;
            Ad = string.Empty;
            Yazar = string.Empty;
            YayinEvi = string.Empty;
            Kategori = string.Empty;
            YayinTarihi = string.Empty;
        }

        public bool OduncDurumu()
        {
            return !string.IsNullOrEmpty(OduncAlanTC);
        }

        public override string ToString()
        {
            return $"{ISBN} - {Ad} - {Yazar}";
        }
    }
}