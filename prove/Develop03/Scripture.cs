 public class Scripture 
 
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split().Select(wordText => new Word(wordText)).ToList();

        
    
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomWord = new Random();

        
        for (int i = 0; i < numberToHide; i++ )
        {

            int index = randomWord.Next(_words.Count);
            _words[index].Hide();
            
            // if (false)
            // {
                
            // }

            // else 
            // {
            //     break;
            // }

        }

    }

    public string GetDipslayText()
    {
        string displayText = $"{_reference.GetDipslayText()} ";
        foreach (Word word in _words)
        {
            displayText += word.GetDipslayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
{

    return _words.All(word => word.IsHidden()) ;
}


}