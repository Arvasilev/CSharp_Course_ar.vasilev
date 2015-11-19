namespace Data
{
    class CreateTwoCards
    {
        public CreateTwoCards()
        {
            var card1 = new Card();
            card1.SetName("newName");

            var card2 = new Card();
            card2.SetId(123456);
        }
    }
}
