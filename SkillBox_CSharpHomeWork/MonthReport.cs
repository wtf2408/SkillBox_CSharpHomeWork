using System;
using System.Security.Cryptography.X509Certificates;

namespace SkillBox_CSharp
{
    struct MonthReport
    {
        public string Month { get; private set; }

        public int Income { get; private set; }

        public int Expense { get; private set; }

        public string Print()
        {
            return $"Месяц - {Month} доход - {Income} расход - {Expense}";
        }
        public MonthReport(string Month, int Income, int Expense)
        {
            this.Month = Month;
            this.Income = Income;
            this.Expense = Expense;
        }

    }
}
