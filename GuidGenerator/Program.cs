// See https://aka.ms/new-console-template for more information

var diNewGuids = Directory.CreateDirectory("../guids/NewGuids");
while (true)
{
    var guid = Guid.NewGuid().ToString();
    File.Create(Path.Combine(diNewGuids.FullName, guid));
    Thread.Sleep(5000);
}
