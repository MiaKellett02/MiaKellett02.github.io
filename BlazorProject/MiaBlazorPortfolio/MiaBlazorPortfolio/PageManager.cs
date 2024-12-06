namespace MiaBlazorPortfolio
{
    public class PageManager
    {
        private string m_homeLocation = "";

        public string GetHomeLocation()
        {
            return m_homeLocation;
        }

        public void SetHomeLocation(string location)
        {
            m_homeLocation = location;
        }
    }
}
