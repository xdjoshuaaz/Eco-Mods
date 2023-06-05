using Eco.Gameplay.Components;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using xdjoshuaaz;

namespace Eco.Mods.TechTree {
#region Boxes
    public partial class IceboxObject {       
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier = Config.ShelfLifeOfFoodStorage.Icebox;
            Log.WriteLine(new LocString($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}"));
        }
    }

    public partial class RefrigeratorObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier = Config.ShelfLifeOfFoodStorage.Refrigerator;
            Log.WriteLine(new LocString($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}"));
        }
    }

    public partial class IndustrialRefrigeratorObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier = Config.ShelfLifeOfFoodStorage.IndustrialRefrigerator;
            Log.WriteLine(new LocString($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}"));
        }
    }
#endregion

#region Siloes
    public partial class StorageSiloObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier = Config.ShelfLifeOfFoodStorage.StorageSilo;
            Log.WriteLine(new LocString($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}"));
        }
    }

    public partial class PoweredStorageSiloObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier = Config.ShelfLifeOfFoodStorage.PoweredStorageSilo;
            Log.WriteLine(new LocString($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}"));
        }
    }
#endregion
}