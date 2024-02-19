using System;
namespace DateTestUnitaire
{
	public class DateValidator
	{
		public DateValidator()
		{
		}

		public bool IsDateValid(string date)
		{

            string[] dateDivisé = date.Split('-');

            if (dateDivisé.Length != 3)
			{
				return false;
				
            }

			foreach (string part in date.Split('-'))
			{
				if (!int.TryParse(part, out _))
				{
					return false;
				}

			}

			int day = int.Parse(dateDivisé[0]);
			int month = int.Parse(dateDivisé[1]);
            int year = int.Parse(dateDivisé[2]);

			if (day < 1 || day > 31)
			{
				return false;
			}

			if (month < 1 || month > 12)
			{
				return false;
			}

			if (year < 2000 || year > DateTime.Now.Year)
			{
				return false;
			}

            if (day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                return false;
            }

            return true;
        }
	}
}

