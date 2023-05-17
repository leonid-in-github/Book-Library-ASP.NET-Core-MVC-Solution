﻿using BookLibrary.Storage.Models.Book;

namespace BookLibrary.WebServer.Models.Books
{
    public class EditBookModel : ActionBookModel
    {
        public string UpdateBookMassege { get; set; }

        public EditBookModel() { }

        public EditBookModel(Book bookItem) : base(bookItem) { }
    }
}
