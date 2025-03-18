namespace EntityFrameWork.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string LanTitle { get; set; }
        public string LanDescription { get; set; }




        public ICollection<Book> Book { get; set; } 

    }
}
