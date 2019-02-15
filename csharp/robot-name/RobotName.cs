using System;
using System.Collections.Generic;

public class Robot
{
    private static HashSet<string> names = new HashSet<string>();
    private Random rnd = new Random();
    private string _name;
    public string Name
    {
        get
        {
            if (_name != null) return _name;
            string nme = getLetter()+getLetter()+getNumber()+getNumber()+getNumber();
            while(names.Contains(nme)){
                nme = getLetter()+getLetter()+getNumber()+getNumber()+getNumber();
            }
            _name = nme;
            names.Add(_name);
            return nme;
        }
    }

    private string getLetter(){
        int num = rnd.Next(0,26);
        return ((char)('A' + num)).ToString();
    }
    private string getNumber(){
        return rnd.Next(0,10).ToString();
    }
    public void Reset()
    {
        names.Remove(_name);
        _name = null;
    }
}