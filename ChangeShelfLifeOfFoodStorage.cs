using Eco.Shared.Utils;
using xdjoshuaaz;

namespace xdjoshuaaz {
    public static class Config {
        public static readonly float ShelfLifeScalar = 2f;
    }
}

namespace Eco.Mods.TechTree {
#region Boxes
    public partial class IceboxObject {
        

        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier *= Config.ShelfLifeScalar;
            Log.WriteLine($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}");
        }
    }

    public partial class RefrigeratorObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier *= Config.ShelfLifeScalar;
            Log.WriteLine($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}");
        }
    }

    public partial class IndustrialRefrigeratorObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier *= Config.ShelfLifeScalar;
            Log.WriteLine($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}");
        }
    }
#endregion

#region Siloes
    public partial class StorageSiloObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier *= Config.ShelfLifeScalar;
            Log.WriteLine($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}");
        }
    }

    public partial class PoweredStorageSiloObject { 
        partial void ModsPostInitialize() {
            var storage = this.GetComponent<PublicStorageComponent>();
            storage.ShelfLifeMultiplier *= Config.ShelfLifeScalar;
            Log.WriteLine($"{GetType().Name} ShelfLifeMultiplier is now {storage.ShelfLifeMultiplier}");
        }
    }
#endregion
}
