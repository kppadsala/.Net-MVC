﻿namespace EntityFrameWork.Data
{
    public class BookPrice
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int CurrencyID { get; set; }
        public int Amount { get; set; }



        public Book Book { get; set; }
        public Currency Currency { get; set; }
    }
}
