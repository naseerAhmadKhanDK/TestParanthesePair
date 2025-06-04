//This program find the paranthese/Currely and brakut braces balance
//that is each start opening have closing then it return true.
string input="[{(a+b)-(a*t)()}]";

Console.WriteLine($"The given input{input} have balance paranthese:"+CheckParenthese(input));
Console.WriteLine($"The given input{input} have balance Currely Braces:" + CheckCurrelyBraces(input));
Console.WriteLine($"The given input have{input} balance Braket Braces:" + CheckBrakutBrace(input));
Console.WriteLine($"the give input have total no of :{CheckForTotalParenthese(input)} paranthes/braces/breaket brucess");

static int CheckForTotalParenthese(string input)
{
   // string checkParenthes = "(,),{,},[,]";
    int count= 0;
    foreach (char c in input)
    {

        if(c == '('||c==')'||c=='{'||c=='}'||c=='['||c==']')
        {
            count++;
            
        }
        
    }
    return count;
    
}
static bool CheckParenthese(string input) {
    int countOpening = 0;
    int countClosing = 0;    

        foreach (char c in input)
        {
            if (c == '(')
            {
                countOpening++;

            }
            if (c == ')')
            {
                countClosing++;
            }
        }
        if (countOpening == countClosing)
        {
            return true;
        }
        else return false;
   

}

static bool CheckCurrelyBraces(string input)
{
    int countOpening = 0;
    int countClosing = 0;
    foreach (char c in input)
    {
        if (c == '{')
        {
            countOpening++;

        }
        if (c == '}')
        {
            countClosing++;
        }
    }
    if (countOpening == countClosing)
    {
        return true;
    }
    else return false;

}
static bool CheckBrakutBrace(string input)
{
    int countOpening = 0;
    int countClosing = 0;
    foreach (char c in input)
    {
        if (c == '[')
        {
            countOpening++;

        }
        if (c == ']')
        {
            countClosing++;
        }
    }
    if (countOpening == countClosing)
    {
        return true;
    }
    else return false;

}

