namespace BlazedTwoThings.Data
{
  class Category
  {
    public int Id { get; set; }
    public string? Keterangan { get; set; }
    public bool isActive { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
  }
}