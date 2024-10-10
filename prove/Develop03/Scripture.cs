public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Divide the scripture in word
        string[] words = text.Split(' ');

        // Create a new array of Object(Word)
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }




    public void HideRandmomWords(int numberToHide)
    {
        Random randomPos = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = randomPos.Next(_words.Count);
            _words[index].Hide();
        }

    }

    public string GetDisplayText()
    {
        //      return $"{_reference} - {_words}";

        string scripture = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }
        return scripture.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {

            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}