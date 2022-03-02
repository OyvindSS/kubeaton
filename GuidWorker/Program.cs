// See https://aka.ms/new-console-template for more information
var diNewGuids = Directory.CreateDirectory("../guids/NewGuids");
var diMovedGuids = Directory.CreateDirectory("../guids/MovedGuids");
while (true)
{
    var file = Directory.EnumerateFiles("../guids/NewGuids").FirstOrDefault();
    if (file != null)
    {
        File.Move(file, Path.Combine(diMovedGuids.FullName, Path.GetFileName(file)));
    }
    Thread.Sleep(7500);
}