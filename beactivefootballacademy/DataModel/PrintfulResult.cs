namespace beactivefootballacademy.DataModel
{
	public class File
	{
		public int id { get; set; }
		public string type { get; set; }
		public string hash { get; set; }
		public object url { get; set; }
		public string filename { get; set; }
		public string mime_type { get; set; }
		public int size { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public int? dpi { get; set; }
		public string status { get; set; }
		public int created { get; set; }
		public string thumbnail_url { get; set; }
		public string preview_url { get; set; }
		public bool visible { get; set; }
		public bool is_temporary { get; set; }
		public object stitch_count_tier { get; set; }
	}

	public class Option
	{
		public string id { get; set; }
		public object value { get; set; }
	}

	public class Product
	{
		public int variant_id { get; set; }
		public int product_id { get; set; }
		public string image { get; set; }
		public string name { get; set; }
	}

	public class Result
	{
		public SyncProduct sync_product { get; set; }
		public List<SyncVariant> sync_variants { get; set; }
	}

	public class Root
	{
		public int code { get; set; }
		public Result result { get; set; }
		public List<object> extra { get; set; }
	}

	public class SyncProduct
	{
		public int id { get; set; }
		public string external_id { get; set; }
		public string name { get; set; }
		public int variants { get; set; }
		public int synced { get; set; }
		public string thumbnail_url { get; set; }
		public bool is_ignored { get; set; }
	}

	public class SyncVariant
	{
		public object id { get; set; }
		public string external_id { get; set; }
		public int sync_product_id { get; set; }
		public string name { get; set; }
		public bool synced { get; set; }
		public int variant_id { get; set; }
		public int main_category_id { get; set; }
		public object warehouse_product_variant_id { get; set; }
		public string retail_price { get; set; }
		public string sku { get; set; }
		public string currency { get; set; }
		public Product product { get; set; }
		public List<File> files { get; set; }
		public List<Option> options { get; set; }
		public bool is_ignored { get; set; }
		public string size { get; set; }
		public string color { get; set; }
		public string availability_status { get; set; }
	}
}