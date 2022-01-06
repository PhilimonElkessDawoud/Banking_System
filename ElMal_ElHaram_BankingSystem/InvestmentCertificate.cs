using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMal_ElHaram_BankingSystem
{
    internal abstract class InvestmentCertificate
    {
        private int id;
        private int num;
        private decimal amount;
        private DateTime startingdate;
        private int yearsnum;
        private DateTime expirydate;
        public InvestmentCertificate() {}
        public InvestmentCertificate(int id,int num, decimal amount, int currentyear, int currentmonth,int currentday, int yearsnum)
        {
            this.id = id;
            this.num = num;
            this.amount = amount;
            this.startingdate = DateTime.Now;
            this.yearsnum = yearsnum;
            this.expirydate = startingdate.AddYears(yearsnum);
        }

        public abstract decimal AddInterest1(decimal amount);
        public abstract decimal AddInterest2(decimal amount);
        public abstract decimal AddInterest3(decimal amount);
    }
    internal class InvestmentCertificatePoor : InvestmentCertificate
    {
        public InvestmentCertificatePoor() {}
        public InvestmentCertificatePoor(int id, int num, decimal amount, int currentyear, int currentmonth, int currentday, int yearsnum)
            
            : base(id, num, amount, currentyear, currentmonth, currentday, yearsnum) {}

        public sealed override decimal AddInterest1(decimal amount)
        {
            return amount + 0.11m * amount;
        }
        public sealed override decimal AddInterest2(decimal amount)
        {
            return amount + 0.12m * amount;
        }
        public sealed override decimal AddInterest3(decimal amount)
        {
            return amount + 0.14m * amount;
        }
    }
    internal class InvestmentCertificatePremium : InvestmentCertificate
    {
        public InvestmentCertificatePremium() {}
        public InvestmentCertificatePremium(int id,  int num, decimal amount, int currentyear, int currentmonth, int currentday, int yearsnum)
            
            : base(id, num, amount, currentyear, currentmonth, currentday, yearsnum) {}

        public sealed override decimal AddInterest1(decimal amount)
        {
            return amount + 0.14m * amount;
        }
        public sealed override decimal AddInterest2(decimal amount)
        {
            return amount + 0.15m * amount;
        }
        public sealed override decimal AddInterest3(decimal amount)
        {
            return amount + 0.17m * amount;
        }
    }
}
