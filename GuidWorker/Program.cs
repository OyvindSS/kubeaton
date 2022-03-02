// See https://aka.ms/new-console-template for more information

var di = Directory.CreateDirectory("MovedGuids");
while (true)
{
    var file = Directory.EnumerateFiles("NewGuids").FirstOrDefault();
    if (file != null)
    {
        File.Move(file, Path.Combine(di.FullName, Path.GetFileName(file)));
    }
    Thread.Sleep(7500);
}