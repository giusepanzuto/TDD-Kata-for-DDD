using System;
using System.Collections.Generic;
using System.Linq;
using Kata.Domain.Entity;

namespace Kata.Domain.Aggregate
{
    public class Gym : EntityBase
    {
        private readonly List<MonthlyPackage> _monthlyPackages = new List<MonthlyPackage>();
        public IEnumerable<MonthlyPackage> MonthlyPackages => _monthlyPackages.ToList();

        public void AddMonthlyPackage(MonthlyPackage monthlyPackage)
        {
            if (_monthlyPackages.Contains(monthlyPackage))
                throw new ArgumentException("You cannot add a duplicate MonthlyPackage.");

            _monthlyPackages.Add(monthlyPackage);
        }
    }
}