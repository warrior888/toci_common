﻿using System;
using System.Collections.Generic;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization.SQLQuery
{
    public abstract class SqlQuery : IQuery
    {
        protected const string ColumnsDelimiter = ",";

        protected Dictionary<Type, string> Surroundings = new Dictionary<Type, string>()
        {
            {typeof(int), ""},
            {typeof(string), "'"},
            {typeof(double), ""},
            {typeof(DateTime), "'"}
        };

        protected Dictionary<SelectClause, string> Signs = new Dictionary<SelectClause, string>()
        {
            {SelectClause.Equal, "="},
            {SelectClause.NotEqual, "!="}, 
            {SelectClause.Like, "LIKE"}    
        };

        public abstract string GetQuery(IModel model);

        protected string GetSurroundedValue<T>(T value)
        {
            // beatka 'beatka' 5 5
            return string.Format("{0}{1}{0}", Surroundings.ContainsKey(value.GetType()) ? Surroundings[value.GetType()] : "'", value);
        }

        protected string GetClauseSign(SelectClause clause)
        {
            return string.Format("{0}", Signs[(clause)]);
        }
    }
}
