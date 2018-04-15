using System;
using System.Collections.Generic;

namespace Kata.Domain
{
    public class Gym : EntityBase
    {
        public IEnumerable<MonthlyPackage> MonthlyPackages { get; } = new List<MonthlyPackage>();

        public void AddMonthlyPackage(MonthlyPackage monthlyPackage)
        {
            ((List<MonthlyPackage>)MonthlyPackages).Add(monthlyPackage);
        }
    }
}