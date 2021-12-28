﻿using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Interfaces
{
    public interface IBookRepo
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
    }
}
