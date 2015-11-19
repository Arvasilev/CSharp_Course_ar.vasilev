namespace Data
{
    class EmailContact : Contact
    {
       private string _alias;
       private string _email;

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

        public override string ToString()
        {
            return base.ToString()+ string.Format("mailto:{0} ({1})", _email, _alias);
            
        }
    }
}
