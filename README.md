# Jackal

![build and publish](https://github.com/rrennoir/Jackal/actions/workflows/dotnet.yml/badge.svg)

Shared memory reader for Assetto Corsa Competizione

## Example

```cs
use Jackal;

var reader = new JackalReader();

reader.PhysicsUpdated += physics => Console.WriteLine(physics);
reader.GraphicUpdated += graphics => Console.WriteLine(graphics);
reader.StaticInfosUpdated += statics => Console.WriteLine(statics);
reader.GameStatusUpdated += status => Console.WriteLine(status);

reader.Start();

Thread.Sleep(10000);

reader.Dispose();
```
