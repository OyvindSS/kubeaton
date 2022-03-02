// See https://aka.ms/new-console-template for more information

var di = Directory.CreateDirectory("NewGuids");
while (true)
{
    var guid = Guid.NewGuid().ToString();
    File.Create(Path.Combine(di.FullName, guid));
    Thread.Sleep(5000);
}
