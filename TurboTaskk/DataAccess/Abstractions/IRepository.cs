﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboTaskk.DataAccess.Abstractions
{
    public interface IRepository<T>
    {
        T GetData(int id);
        ICollection<T> GetAll();
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
    }
}
