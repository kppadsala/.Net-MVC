namespace EntityFrameWork.Data
{
    public class Currency
    {
        public int ID { get; set; }
        public string CurTitle { get; set; }
        public string CurDescription { get; set; }



        public ICollection<BookPrice> BookPrice { get; set; }

    }
}
