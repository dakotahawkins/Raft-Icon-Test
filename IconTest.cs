namespace DakotaHawkins
{
    [ModTitle("Icon Test")] // The mod name.
    [ModDescription("Test Mod Please Ignore")] // Short description for the mod.
    [ModAuthor("Dakota Hawkins")] // The author name of the mod.
    [ModIconUrl("https://raw.githubusercontent.com/dakotahawkins/Raft-Icon-Test/master/icon.ico")] // An icon for your mod. Its recommended to be 128x128px and in .jpg format.
    [ModWallpaperUrl("https://raw.githubusercontent.com/dakotahawkins/Raft-Icon-Test/master/banner.jpg")] // A banner for your mod. Its recommended to be 330x100px and in .jpg format.
    [ModVersionCheckUrl("https://raw.githubusercontent.com/dakotahawkins/Raft-Icon-Test/master/version.txt")] // This is for update checking. Needs to be a .txt file with the latest mod version.
    [ModVersion("1.0")] // This is the mod version.
    [RaftVersion("Update 10.07 4497220")] // This is the recommended raft version.
    [ModIsPermanent(false)] // If your mod add new blocks, new items or just content you should set that to true. It loads the mod on start and prevents unloading.
    public class IconTest : Mod
    {
        /// <summary>
        /// URL root for current version of this mod.
        /// </summary>
        private const string MyCurrentUrlRoot =
            "https://raw.githubusercontent.com/dakotahawkins/Raft-Icon-Test/master/";

        // The Start() method is being called when your mod gets loaded.
        public void Start()
        {
            RConsole.Log("IconTest has been loaded!");
        }

        // The Update() method is being called every frame. Have fun!
        // public void Update()
        // {
        //
        // }

        // The OnModUnload() method is being called when your mod gets unloaded.
        public void OnModUnload()
        {
            RConsole.Log("IconTest has been unloaded!");
            Destroy(gameObject); // Please do not remove that line!
        }
    }
} // namespace DakotaHawkins
