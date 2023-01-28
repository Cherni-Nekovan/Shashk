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


void MakeAMove(Point CurrentPosition,Point NextPosition)
{
  

   


    Field[posotion1, position] = 'D';
}

class Point
{
    public int x { get; set; }
    private int y;

    public int Y
    {
        get { return y; }
        set {
            if (value == 'a') value = 1;
            if (value == 'b') value = 2;
            if (value == 'c') value = 3;
            if (value == 'd') value = 4;
            if (value == 'e') value = 5;
            if (value == 'f') value = 6;
            if (value == 'g') value = 7;
            if (value == 'h') value = 8; y = value; }
    }

}