using System;
using System.Collections.Generic;

namespace Kata.Domain
{
    public class Gym : EntityBase
    {
        public IEnumerable<MonthlyPackage> MonthlyPackages { get; } = new List<MonthlyPackage>();

        public void AddMonthlyPackage(MonthlyPackage monthlyPackage)
        {
            var _list = (List<MonthlyPackage>)MonthlyPackages;

            if(_list.Contains(monthlyPackage))
                throw new ArgumentException("You cannot add a duplicate MonthlyPackage.");

            _list.Add(monthlyPackage);
        }
    }
}