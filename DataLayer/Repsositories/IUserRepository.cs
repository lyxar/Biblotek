﻿using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataLayer.Repsositories
{
    public interface IUserRepository
    {
        User GetBorrowedBooks(string rfid);
    }
}
