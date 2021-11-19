using System;

namespace stregsystem.Models
{
    public class SeasonalProduct : Product
    {
        public SeasonalProduct(int id, string name, decimal price, int active, DateTime startDate, DateTime endDate) : base(id, name, price, active)
        {

        }

        private DateTime _seasonStartDate;
        private DateTime _seasonEndDate;

        public DateTime SeasonStartDate {
            get => _seasonStartDate;
            private set {
                if (value == null)
                    throw new ArgumentNullException("StartDate can't be null");
                _seasonStartDate = value;
            }
        }
        public DateTime SeasonEndDate {
            get => _seasonEndDate;
            private set {
                if (value == null)
                    throw new ArgumentNullException("EndDate can't be null");
                if (value < _seasonStartDate)
                    throw new ArgumentException("End date must be later than start date");
                _seasonEndDate = value;
            }
        }
    }
}