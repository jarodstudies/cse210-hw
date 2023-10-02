public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = -1;

    public Reference(string book, int chapter, int verse)
    {

        _book = book;
        _chapter = chapter;
        _verse =  verse;

    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {

        _book = book;
        _chapter = chapter;
        _verse =  verse;
        _endVerse = endVerse;

    }


    public string GetDipslayText()
    {
        if (_endVerse == -1 )
        {
            
            string display = $"{_book} {_chapter}:{_verse} ";
            //Console.Write(display);
            return display;
        }

        else 
        {
            string display = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
            //Console.Write(display);
            return display;
        };
        
    }

}