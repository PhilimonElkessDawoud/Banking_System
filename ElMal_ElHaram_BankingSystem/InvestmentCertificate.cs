using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMal_ElHaram_BankingSystem
{
    internal abstract class InvestmentCertificate
    {
        public abstract decimal AddInterest1(decimal amount);
        public abstract decimal AddInterest2(decimal amount);
        public abstract decimal AddInterest3(decimal amount);
    }
    internal class InvestmentCertificatePoor : InvestmentCertificate
    {
        public InvestmentCertificatePoor() {}
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
