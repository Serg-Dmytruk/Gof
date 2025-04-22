using Facade;
using Facade.Subsystem;

var castingFacade = new CastingFacade(new DeviceExplorer());

await castingFacade.CastAsync(Guid.NewGuid(), Guid.NewGuid());