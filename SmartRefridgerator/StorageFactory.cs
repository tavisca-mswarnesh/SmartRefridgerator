using System;

namespace SmartRefridgerator
{
    class StorageFactory
    {
        public IStorage GetStorage(string storage)
        {
            switch(storage.ToLowerInvariant())
            {
                case "inmemory":
                    return new InMemoryStorage();
                case "filebasestorage":
                    return new FileBasedStorage();
                default:
                    throw new  NotImplementedException();

            }
        }
    }

}
