int Max ( int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 22;
int b1 = 32;
int c1 = 42;

int a2 = 51;
int b2 = 53;
int c2 = 55;

int a3 = 61;
int b3 = 66;
int c3 = 70;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3,b3,c3);
int maxResult = Max(max1, max2, max3);

Console.WriteLine("Число равно " + maxResult);