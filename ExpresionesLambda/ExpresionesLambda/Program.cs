
//lambdaexpression dos variables
Func<int, int, int> ft = (a, b) =>  a + b;

//le para una variable
Func<int, int> fr = a  => a * 5;

//le multilinea una variable
Func<int, int> fb = a => 
{  
    a = a + 5;
    return a + 2; 
};

Algodon((a, b) => ( a + b ), 5);
void Algodon (Func<int,int,int>algodon, int number)
{
    int result = algodon(number, number);
}