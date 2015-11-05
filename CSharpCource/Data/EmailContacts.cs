namespace Data
{
    class EmailContacts : Contacts
    {
       private string _alias;

        public EmailContacts(string cname, string aliasEmail):base(cname)
        {
           _alias = aliasEmail;
        }

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format("mailto: {0}", _alias);
            
        }
    }
}
