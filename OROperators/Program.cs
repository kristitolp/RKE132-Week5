
//Math >= 90 or chemistry >= 90
//math && chemistry || math && biology || chemistry and biology


int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());



if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted!");

}

else
{
    Console.WriteLine("Your application has been denied");
}