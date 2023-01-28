var Field = new char[9, 9] 
{
       { ' ', '1', '2', '3', '4', '5', '6', '7','8' },

    { 'a',    ' ', 'b', ' ', 'b', ' ', 'b', ' ','b' },
    { 'b',    'b', ' ', 'b', ' ', 'b', ' ', 'b',' ' },
    { 'c',    ' ', 'b', ' ', 'b', ' ', 'b', ' ','b' },
    { 'd',    ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },
    { 'e',    ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' },
    { 'f',    'w', ' ', 'w', ' ', 'w', ' ', 'w',' ' },
    { 'g',    ' ', 'w', ' ', 'w', ' ', 'w', ' ','w' },
    { 'h',    'w', ' ', 'w', ' ', 'w', ' ', 'w',' ' }
};

char[] tail = new char[6] { '#', ' ', 'w', 'b', 'W', 'B' };

void MakeAMove(Point currentPosition,Point nextPosition,string WhosTurn)
{
    char NextValue= Field[nextPosition.x, nextPosition.y];
    if (NextValue.ToString() == tail[3].ToString().ToUpper())
    {
        /////абстрактная функция бить
    }

    char CurrentValue = Field[currentPosition.x, currentPosition.y];
    if (CurrentValue != ' ' && WhosTurn.ToLower()=="white" && CurrentValue!='b'&& NextValue.ToString()!= tail[3].ToString().ToUpper())
    {
    Field[nextPosition.x, nextPosition.y] = CurrentValue;
    }
    if (CurrentValue != ' ' && WhosTurn.ToString().ToLower() == "black" && CurrentValue != 'w'&& NextValue.ToString() != tail[4].ToString().ToUpper())
    {
        Field[nextPosition.x, nextPosition.y] = CurrentValue;
    }

}

class Point
{
    private int _x;

    public int x
    {
        get { return _x; }
        set {
            if (value > 0 && value < 9)
            {
                _x = value;
            }
            else
            {
                ////logic
            }
        }
    }

    private int _y;

    public int y
    {
        get { return _y; }
        set {
            if (value == 'a') value = 1;
            if (value == 'b') value = 2;
            if (value == 'c') value = 3;
            if (value == 'd') value = 4;
            if (value == 'e') value = 5;
            if (value == 'f') value = 6;
            if (value == 'g') value = 7;
            if (value == 'h') value = 8; _y = value;
             else
            {
                ////logic
            }
        }
    }

}