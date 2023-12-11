await SimpleTask();
File.WriteAllText(@"SomeFile.txt", "blah blah");
string contents = await ReadFile();
Console.Write(contents);

async Task SimpleTask()
{
    Console.WriteLine("Starting of the task");
    await Task.Delay(1000); //force a delay
    Console.WriteLine("Task Completed");
}

async Task<string> ReadFile()
{
    using (StreamReader r = new StreamReader(@"SomeFile.txt"))
    {
        return await r.ReadToEndAsync();
    }
}