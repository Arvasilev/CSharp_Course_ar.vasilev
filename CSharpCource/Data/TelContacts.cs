using Data;

namespace ContactsCard
{
    class TelContacts : Contacts
    {
        private string _telephoneZone;

        public TelContacts (string cname, string telCode) : base(cname)
        {
         _telephoneZone = telCode;
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format("Код города: {0}", _telephoneZone);
        }
    }
}