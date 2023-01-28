




var Field = new char[9, 9] 
{
       { ' ', '1', '2', '3', '4', '5', '6', '7','8' },

    { 'a',    ' ', 'b', ' ', 'b', ' ', 'b', ' ','b' },
    { 'b',    'b', ' ', 'b', ' ', 'b', ' ', 'b',' ' },
    { 'c',    ' ', 'b', ' ', 'b', ' ', 'b', ' ','b' },
    { 'd',    '#', ' ', '#', ' ', '#', ' ', '#',' ' },
    { 'e',    ' ', '#', ' ', '#', ' ', '#', ' ','#' },
    { 'f',    'w', ' ', 'w', ' ', 'w', ' ', 'w',' ' },
    { 'g',    ' ', 'w', ' ', 'w', ' ', 'w', ' ','w' },
    { 'h',    'w', ' ', 'w', ' ', 'w', ' ', 'w',' ' }
};

char[] tail = new char[6] { '#', ' ', 'w', 'b', 'W', 'B' };

void MakeAMove(Point currentPosition,Point nextPosition,string WhosTurn)
{
    char NextValue = Field[nextPosition.x, nextPosition.y];
    char CurrentValue = Field[currentPosition.x, currentPosition.y];

    if (nextPosition.x!= currentPosition.x-1 || nextPosition.x != currentPosition.x + 1)
    {
        /////Ex
    }
    if (nextPosition.y != currentPosition.y +1 )
    {
        /////Ex
    }

    if(CurrentValue == ' ' || (WhosTurn=="white"&& (NextValue=='W' || NextValue == 'w'))|| (WhosTurn == "white" && (CurrentValue == 'b' || CurrentValue == 'B')))
    {
        //////Ex
    }
    if (CurrentValue == ' ' || (WhosTurn == "black" && (NextValue == 'B' || NextValue == 'b')) || (WhosTurn == "white" && (CurrentValue == 'W' || CurrentValue == 'w')))
    {
        //////Ex
    }


    if (WhosTurn == "black" && (NextValue == 'W'|| NextValue == 'w'))
    {
        Beat(currentPosition,nextPosition);
    }
    if (WhosTurn == "white" && (NextValue == 'b' || NextValue == 'b'))
    {
        Beat(currentPosition, nextPosition);
    }

    
    Field[nextPosition.x, nextPosition.y] = CurrentValue;
   

}
void Beat(Point currentPosition, Point nextPosition)
{
    Field[nextPosition.x, nextPosition.y] = Field[currentPosition.x, currentPosition.y];
    Field[currentPosition.x, currentPosition.y] = ' ';
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
            if (value == 'a') _y = 1;
            if (value == 'b') _y = 2;
            if (value == 'c') _y = 3;
            if (value == 'd') _y = 4;
            if (value == 'e') _y = 5;
            if (value == 'f') _y = 6;
            if (value == 'g') _y = 7;
            if (value == 'h') _y = 8;
             else
            {
                ////logic
            }
        }
    }

}