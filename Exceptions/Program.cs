using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

public class CustomException : Exception
{
    public CustomException(string message)
        : base(message)
    { }

    protected CustomException(SerializationInfo info, StreamingContext ctxt)
        : base(info, ctxt)
    { }
}

public class Program
{
    public static void DivisionOperation()
    {
        double numerator = 1;
        double denominator = 0;
        bool completed = false;
        try
        {
            numerator /= denominator;
            completed = true;
        } catch (Exception e){
            throw new CustomException("Division by zero!");
        }
        finally
        {
            if (completed) { Console.WriteLine($"Divison: {numerator}"); } else { Console.WriteLine("Division by zero!"); }
        }
    }

    public static void ListOperation()
    {
        List<int> list = new List<int>() { 0, 1 };
        bool completed = false;
        try
        {
            Console.WriteLine(list[2]);
            completed = true;
        }
        catch (Exception e)
        {
            throw new CustomException("List index out of range!");
        }
        finally
        {
            if (completed) { Console.WriteLine($"Value: {list[2]}"); } else { Console.WriteLine("Unable to get value by index!"); }
        }
    }

    public static void StringToIntConvert()
    {
        string str = "asd";
        int convertedString = 0;
        bool completed = false;
        try
        {
            convertedString = Convert.ToInt32(str);
            completed = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (completed) { Console.WriteLine($"Converted string: {convertedString}"); } else { Console.WriteLine("Unable to convert!"); }
        }
    }

    static void Main(string[] args)
    {
        DivisionOperation();
        ListOperation();
        StringToIntConvert();
    }
}