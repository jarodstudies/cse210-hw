
public class Word
{

    private string _text;
    private bool _IsHidden;

    public Word(string text)
    {
        //_text = text;
        _text = text;
        _IsHidden = false;
    }

    public void Hide()
    {
        string hiddenWord = new string('_' , _text.Length);
        _text = hiddenWord;
        _IsHidden = true;
        
    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return _IsHidden;
    }

    public string GetDipslayText()
    {

        return _text;


    }
}