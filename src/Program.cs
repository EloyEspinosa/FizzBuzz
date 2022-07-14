using (FileStream file = File.OpenWrite("../fizzbuzz.py"))
{
    for (int i = 1; i <= 1000000; i++)
    {
        string output = "";
        if (i % 3 == 0) output += "Fizz";
        if (i % 5 == 0) output += "Buzz";
        else if (output == "") output += i;
        output = $"print(\"{output}\")\n";
        byte[] buffer = output.Select(x => (byte)x).ToArray();
        file.Write(buffer);
    }
}