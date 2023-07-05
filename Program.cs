using WildFarm.Core;
using WildFarm.Factories;

IEngine engine = new Engine(new AnimalFactory());
engine.Run();