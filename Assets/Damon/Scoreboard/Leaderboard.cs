using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{

    [SerializeField]
    private List<TextMeshProUGUI> names;

    [SerializeField]
    private List<TextMeshProUGUI> scrores;

    private string PublicLeaderboardKey =
        "37e5a04b034b9fc74f526cec98ebfb3a3f6702cb493ac40b0ba51d963d06c83d";

    private void Start()
    {
        GetLeaderboard();
    }

    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(PublicLeaderboardKey, ((msg) => {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            
            for (int i = 0; i < loopLength; ++i)
            {
                names[i].text = msg[i].Username;
                scrores[i].text = msg[i].Score.ToString();
            }
        }));
    }


    public void SetLeaderboardEntry(string username, int score) {
        LeaderboardCreator.UploadNewEntry(PublicLeaderboardKey, username, score, ((msg) => {
            GetLeaderboard();
        }));
    }

}
