using System;

public class Reference


//Private Stores book,chapter,verse,endverse
{  


    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


//constructor for a single reference
    public Reference( string bookName, int chapter, int chapterVerse)
    {
        _book = bookName;
        _chapter = chapter;
        _verse = chapterVerse;
        _endVerse = 0;
    }


//constructor for range of verse

    public Reference(string bookName, int chapter, int chapterVerse, int chapterEndVerse)
    {
        _book =bookName;
        _chapter =chapter;
        _verse = chapterVerse;
        _endVerse  =chapterEndVerse;

    }


    // GetDisplayText: This method returns the formatted scripture reference as a string, either in the format of a single verse or a range.
    public string GetDisplayText() 
    {

        if (_endVerse == 0)
        {
            return $" {_book} {_chapter} {_verse}";

        }
        else {
            return $"{_book} {_chapter} {_verse} {_endVerse}";
        }
    }




}

