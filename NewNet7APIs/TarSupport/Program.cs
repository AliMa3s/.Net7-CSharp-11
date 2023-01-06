
using System.Formats.Tar;

var targetTarFile = @"D:\temp2\documents.tar";


if (File.Exists(targetTarFile))
{
    File.Delete(targetTarFile);
}

TarFile.CreateFromDirectory(@"D:\temp", targetTarFile, false);


var destination = @$"D:\temp\{Guid.NewGuid()}";
Directory.CreateDirectory(destination);
TarFile.ExtractToDirectory(targetTarFile, destination, true);

