namespace Data
{
    using System;
    using System.Xml.Linq;

    public class EmailContact : Contact, IComparable, ICloneable
    {
       private string _alias;
       private readonly string _email;

        public EmailContact(string cname, string aliasEmail):base(cname)
        {
           _alias = cname;
           _email = aliasEmail;
        }

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        public string ToString()
        {
            return base.ToString()+ string.Format("mailto:{0} ({1})", _email, _alias);
        }
        public  object Clone()
        {
            return new EmailContact(Name, Alias);

        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var otherEmail = obj as EmailContact;
            if (otherEmail != null)
            {
                //сравниваю по имени
                if (!this.Name.Equals(otherEmail.Name))
                    return this.Name.CompareTo(otherEmail.Name);
                //если равны - возвращаю позицию alias
                return this.Alias.CompareTo(otherEmail.Alias);
            }

            else
            {
                throw new ArgumentException("Object is not a Email");

            }

        }
   
        public  XElement ToXml()
        {
            var contact = new XElement("Email");
            contact.Add(new XAttribute("Name", this.Name));
            contact.Add(new XAttribute("Alias", this.Alias));
            return contact;
        }
    }
}