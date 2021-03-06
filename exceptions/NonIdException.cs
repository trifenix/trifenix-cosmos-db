﻿using System;
using trifenix.connect.model;

namespace trifenix.connect.db.cosmos.exceptions
{

    /// <summary>
    /// Excepción lanzada cuando no existe id.
    /// </summary>
    /// <typeparam name="T">Tipo de elemento que lanza el error</typeparam>
    public class NonIdException<T> : BaseException<T> where T:DocumentDb {
        public NonIdException(T docBase) : base(docBase) { }

        public override string Message => $"el elemento de tipo {DbObject.GetType()} no  tiene id";
    }


    /// <summary>
    /// Excepción base.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseException<T> : Exception where T:DocumentDb {
        public BaseException(T docBase) {
            DbObject = docBase;
        }

        public T DbObject { get; }
    }
}