
using SplinterCellCTCOOPSaver;

namespace SplinterCellCTCOOPSaver
{

    enum ClientType
    {
        Client = 'Client',
        Host = 'Host'
    }
    public static class SplinterCellCoopManager
    {

        private ClientType ClientType
        {
            get; set;
        }

        private string BasePath
        {
            get
            {
                return $"C:\Users\\{Environment.UserName}\\AppData\Local\Ubisoft\Tom Clancy's Splinter Cell Chaos Theory";
            }
        }



        private string OriginalSaveFile
        {
            get
            {
                return $"{this.BasePath}\CacheCoopQuickSave{this.ClientType}.sav";
            }
        }


        public SplinterCellCoopManager(ClientType clientType)
        {
            this.ClientType = clientType;
        }
        

    }

}