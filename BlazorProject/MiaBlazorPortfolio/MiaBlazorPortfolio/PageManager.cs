namespace MiaBlazorPortfolio
{
    public class PageManager
    {
        private string m_homeLocation = "";
        private bool m_isOnHomePage = false;

        //Repository and page link stuff.
        public const string NO_LINK = "empty";
        private Dictionary<string, string> m_pageRepositories = new Dictionary<string, string>
            {
                { "FromageFortress", NO_LINK },
                { "SkullSluggery", NO_LINK },
                { "OccultOffensive", "https://github.com/SkyeRiches/Occult-Tower-Defense"},
                { "VoxelTerrain", "https://github.com/MiaKellett02/Marching_Cubes_Terrain_Base"},
                { "VietnamActionAdventure", "https://github.com/MiaKellett02/VietnamActionAdventure" },
                { "WhiteEagleDown", "https://github.com/MiaKellett02/Global_Game_Jam_2022" },
                { "OBJModelViewer", "https://github.com/MiaKellett02/OBJ_Model_Viewer"},
                { "MissileCommand",  "https://github.com/MiaKellett02/MissileCommandEngine"},
            };

        public Dictionary<string, string> PageRepositories
        {
            get { return m_pageRepositories; }
            private set { m_pageRepositories = value; }
        }

        private Dictionary<string, string> m_pageDownloadLinks = new Dictionary<string, string>
            {
                { "FromageFortress", "https://coldsoupstudios.itch.io/fromage-fortress-v4-2" },
                { "SkullSluggery", NO_LINK },
                { "OccultOffensive", "https://thestaticvoids.itch.io/occult-offensive"},
                { "VoxelTerrain", NO_LINK},
                { "VietnamActionAdventure", "https://fastest-mia.itch.io/vietnam-action-adventure" },
                { "WhiteEagleDown", "https://fastest-mia.itch.io/white-eagle-down" },
                { "OBJModelViewer", "https://fastest-mia.itch.io/obj-model-viewer"},
                { "MissileCommand",  "https://fastest-mia.itch.io/missile-command"},
            };

        public Dictionary<string, string> PageDownloadLinks
        {
            get { return m_pageDownloadLinks; }
            private set { m_pageDownloadLinks = value; }
        }

        //Public Functions.
        public string GetHomeLocation()
        {
            return m_homeLocation;
        }

        public void SetHomeLocation(string location)
        {
            m_homeLocation = location;
        }

        public void SetIsOnHomePage(bool isOnHomePage)
        {
            m_isOnHomePage = isOnHomePage;
        }

        public bool GetIsOnHomePage()
        {
            return m_isOnHomePage;
        }
    }
}
