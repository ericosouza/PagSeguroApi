namespace PagSeguroApi.Model
{
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
        public dynamic Data { get; set; }
    }
}
