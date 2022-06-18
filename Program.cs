Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome To Math Solver 9000");
Console.ForegroundColor = ConsoleColor.White;
Menu();

void Menu()
{
    Console.ForegroundColor= ConsoleColor.DarkMagenta;
    Console.WriteLine("\nEnter (R) for Quadratic equation root calculator");
    Console.WriteLine("Enter (H) for Heron volume calculator");
    Console.WriteLine("Enter (C) for Cosine theorem calculator");
    Console.WriteLine("Enter (P) for Pythagorean theorem calculator");
    Console.WriteLine("Enter (G) for Quadratic equation generator");
    Console.WriteLine("Enter (U) for Shared devider calculator");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nEnter (X) to exit");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\nInput: ");
    String ans = Console.ReadLine();
    if (ans == "R" || ans == "r")
    {
        RootCalculator();
    }
    if (ans == "H" || ans == "h")
    {
        HeronFormula();
    }
    if (ans == "C" || ans == "c")
    {
        CosineTheorem();
    }
    if (ans == "P" || ans == "p")
    {
        Pythagorean();
    }
    if (ans == "G" || ans == "g")
    {
        QuadraticGenerator();
    }
    if (ans == "U" || ans == "u")
    {
        SharedDevider();
    }
    if (ans == "X" || ans == "x")
    {
        Exit();
    }
    else
    {
        Menu();
    }
}

void RootCalculator()
{
    Calculate();
    void Calculate()
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("aX^2 + bX + c = 0");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
        Console.WriteLine("Input a, b and c");
        Console.Write("\na = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        float D = b * b - 4 * a * c;

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\nD = " + D);

        D = MathF.Sqrt(D);
        float x1 = (-b - D) / (2 * a);
        float x2 = (-b + D) / (2 * a);

        
        Console.WriteLine("X1 = " + x1 + "\nX2 = " + x2);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Repeat();
    }

    void Repeat()
    {
        Console.WriteLine("\n\nRepeat? (Y/N)");
        String ans = Console.ReadLine();

        if (ans == "Y" || ans == "y")
        {
            Calculate();
        }
        if (ans == "N" || ans == "n")
        {
            Menu();
        }
        else
        {
            Repeat();
        }
    }

    
}

void QuadraticGenerator()
{
    Calculate();
    void Calculate()
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("aX^2+bX+c = 0");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\nInput X1 and X2");
        Console.Write("X1 = ");
        float x1 = float.Parse(Console.ReadLine());
        Console.Write("X2 = ");
        float x2 = float.Parse(Console.ReadLine());

        float b = -(x1 + x2);
        float c = x1 * x2;

        Console.BackgroundColor= ConsoleColor.White;
        Console.ForegroundColor= ConsoleColor.Black;

        Console.WriteLine("\nX^2 + (" + b + ")X + (" + c + ") = 0");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Repeat();
    }
    
    void Repeat()
    {
        Console.WriteLine("\n\nRepeat? (Y/N)");
        String ans = Console.ReadLine();

        if (ans == "Y" || ans == "y")
        {
            Calculate();
        }
        if (ans == "N" || ans == "n")
        {
            Menu();
        }
        else
        {
            Repeat();
        }
    }
}

void HeronFormula()
{
    Calculate();
    void Calculate()
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("S = √(P*(P-a)(P-b)(P-c))");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\nInput a, b and c");
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        float p = (a + b + c) / 2;

        Console.BackgroundColor= ConsoleColor.White;
        Console.ForegroundColor= ConsoleColor.Black;
        Console.WriteLine("\nP/2 = " + p);
        Console.WriteLine("S = " + MathF.Sqrt(p * (p - a) * (p - b) * (p - c)));
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Repeat();
    }

    void Repeat()
    {
        Console.WriteLine("\n\nRepeat? (Y/N)");
        String ans = Console.ReadLine();

        if (ans == "Y" || ans == "y")
        {
            Calculate();
        }
        if (ans == "N" || ans == "n")
        {
            Menu();
        }
        else
        {
            Repeat();
        }
    }
}

void Pythagorean()
{
    Calculate();
    void Calculate()
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("a^2 + b^2 = c^2");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\nInput a and b");
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("c = " + MathF.Sqrt((a * a + b * b)));

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Repeat();
    }

    void Repeat()
    {
        Console.WriteLine("\n\nRepeat? (Y/N)");
        String ans = Console.ReadLine();

        if (ans == "Y" || ans == "y")
        {
            Calculate();
        }
        if (ans == "N" || ans == "n")
        {
            Menu();
        }
        else
        {
            Repeat();
        }
    }
}

void CosineTheorem()
{
    Calculate();
    void Calculate()
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("a^2 + b^2 - 2*a*b*Cosφ = c^2");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\n Input a, b and φ");
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("φ = ");
        float phi = float.Parse(Console.ReadLine());
        float cosPhi = 0;

        if (phi == 0)
        {
            cosPhi = 1;
        }
        else if (phi == 30)
        {
            cosPhi = (MathF.Sqrt(3))/2;
        }
        else if (phi == 45)
        {
            cosPhi = (MathF.Sqrt(2))/2;
        }
        else if (phi == 60)
        {
            cosPhi = 0.5f;
        }
        else if (phi == 90)
        {
            cosPhi = 0;
        }
        else if (phi == 120)
        {
            cosPhi = -0.5f;
        }
        else
        {
            Calculate();
        }
        if (a < 0)
        {
            a = -a;
        }
        if (b < 0)
        {
            b = -b;
        }

        float c = (a * a + b * b) - 2 * (a * b * cosPhi);
        c = MathF.Sqrt(c);

        Console.BackgroundColor=ConsoleColor.White;
        Console.ForegroundColor=ConsoleColor.Black;

        Console.WriteLine("\nc = " + c);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Repeat();
    }

    void Repeat()
    {
        Console.WriteLine("\n\nRepeat? (Y/N)");
        String ans = Console.ReadLine();

        if (ans == "Y" || ans == "y")
        {
            Calculate();
        }
        if (ans == "N" || ans == "n")
        {
            Menu();
        }
        else
        {
            Repeat();
        }
    }
}

void SharedDevider()
{
    Calculate();
    void Calculate()
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("a/b = (a/c) / (b/c)");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\nInput a and b");
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\nShared Deviders Are: ");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        void remainder (decimal c)
        {
            decimal r1 = decimal.Remainder(a, c);
            decimal r2 = decimal.Remainder(b, c);
            
            if (r1 == 0 && r2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write(c + "; ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            return;
        }

        for (int i = 1; i < 10000; i++)
        {
            remainder(i);
        }


        Repeat();
    }

    void Repeat()
    {
        Console.WriteLine("\n\nRepeat? (Y/N)");
        String ans = Console.ReadLine();

        if (ans == "Y" || ans == "y")
        {
            Calculate();
        }
        if (ans == "N" || ans == "n")
        {
            Menu();
        }
        else
        {
            Repeat();
        }
    }
}

void Exit()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\nGoodbye ♥");
    Console.ForegroundColor = ConsoleColor.White;
    
    System.Threading.Thread.Sleep(700);
    Environment.Exit(0);
}