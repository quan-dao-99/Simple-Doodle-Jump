using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

public class GooglePlaySetup : MonoBehaviour
{
    private void Start()
    {
        if (Social.localUser.authenticated) return;

        var config = new PlayGamesClientConfiguration.Builder()
            .Build();

        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        SignIn();
    }

    public void SignIn()
    {
        Social.localUser.Authenticate((success => { }));
    }
}