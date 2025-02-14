
namespace SplinterCellCTCOOPSaver
{

    enum ClientType {
        Client = 'Client',
        Host = 'Host'
    }
    public static class Utils
    {

      

        public static buildPath(ClientType clientType)
        {

            return this.basePath + "CacheCoopQuickSaveHost.sav{ }
                ";
        }
    }
}