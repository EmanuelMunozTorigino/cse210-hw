public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;

    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {       // ternary operator - first condition if is true, 
        //string letters = "abcdefghijklmnñopqrstuvwxyz";


        return _isHidden ? "____" : _text;
        /*return _isHidden ? _text.Replace(letters, "_") "____" : _text; */
    }




}