namespace ContactsCard
{
    using System;

    using Data;

    class PhoneContact : Contact, IComparable
    {
        private string _telephoneZone;

        public PhoneContact (string cname, string telCode) : base(cname)
        {
         _telephoneZone = telCode;
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format("Код города: {0}", _telephoneZone);
        }
    }
}