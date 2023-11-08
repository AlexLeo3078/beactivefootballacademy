namespace beactivefootballacademy.DataModel.ProductId
{
    public class Paging
    {
        public int total { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string external_id { get; set; }
        public string name { get; set; }
        public int variants { get; set; }
        public int synced { get; set; }
        public string thumbnail_url { get; set; }
        public bool is_ignored { get; set; }
    }

    public class Root
    {
        public int code { get; set; }
        public List<Result> result { get; set; }
        public List<object> extra { get; set; }
        public Paging paging { get; set; }
    }
}