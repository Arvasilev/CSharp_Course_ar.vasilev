namespace ContactsCard
{
    using System;
    using System.Xml.Linq;

    using Data;

    class PhoneContact : Contact, IComparable, ICloneable
    {
        private string _telephoneZone;

        public PhoneContact (string cname, string telCode) : base(cname)
        {
         _telephoneZone = telCode;
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format("Телефон: {0}", _telephoneZone);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var otherPhone = obj as PhoneContact;
            if (otherPhone != null)
            {
                if (!this._telephoneZone.Equals(otherPhone._telephoneZone))
                    return this.Name.CompareTo(otherPhone.Name);
                return this._telephoneZone.CompareTo(otherPhone._telephoneZone);
            }

            else
                throw new ArgumentException("Object is not a Phone");
        }
        public object Clone()
        {
            return new PhoneContact(Name, _telephoneZone);

        }

        public XElement ToXml()
        {
            var contact = new XElement("TelephoneContact");
            contact.Add(new XAttribute("Name", this.Name));
            contact.Add(new XAttribute("Zone", this._telephoneZone));
            return contact;
        }
    }
}