namespace WindowsFormsApp1
{
    internal class Phrase
    {
        private string headerText;
        private object text;

        public Phrase(string headerText, object text)
        {
            this.headerText = headerText;
            this.text = text;
        }
    }
}