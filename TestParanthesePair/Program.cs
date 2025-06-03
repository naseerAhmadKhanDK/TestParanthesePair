//This program find the paranthese/Currely and brakut braces balance
//that is each start opening have closing then it return true.
string input="[{(a+b)-(a*t)()}]";

Console.WriteLine($"The given input have balance paranthese:"+CheckParenthese(input));
Console.WriteLine($"The given input have balance Currely Braces:" + CheckCurrelyBraces(input));
Console.WriteLine($"The given input have balance Braket Braces:" + CheckBrakutBrace(input));

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

