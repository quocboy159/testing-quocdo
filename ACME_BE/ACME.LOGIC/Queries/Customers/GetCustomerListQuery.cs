using ACME.LOGIC.Common;
using ACME.LOGIC.Entities;
using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ACME.LOGIC.Queries.Customers
{
    public sealed class GetCustomerListQuery : IQuery<IList<GetCustomerListQueryResult>>
    {
        internal sealed class GetCustomerListQueryHandler : IQueryHandler<GetCustomerListQuery, IList<GetCustomerListQueryResult>>
        {
            public IList<GetCustomerListQueryResult> Handle(GetCustomerListQuery query)
            {
                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    SeparatorChar = ',',
                    FirstLineHasColumnNames = true
                };
                CsvContext cc = new CsvContext();
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Sources/SampleData.csv");
                var customers = cc.Read<Customer>(path, inputFileDescription);
                var result = customers.Select(x => new GetCustomerListQueryResult
                {
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Phone1 = x.Phone1
                }).ToList();

                return result;
            }
        }
    }
}
