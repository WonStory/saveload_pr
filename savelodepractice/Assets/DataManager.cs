using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Playerdata
{
   public string name;
   public int level;
   public int coin;
   public int item;
}




public class DataManager : MonoBehaviour
{
    //싱글톤
    public static DataManager instance;

    Playerdata nowplayer = new Playerdata(){name = "원선희", level = 20, coin = 5, item = 3};
    string Path;
    string filename = "save";

    private void Awake()
        {
            #region 싱글톤
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(instance.gameObject);
            }
            DontDestroyOnLoad(this.gameObject);
            #endregion
        
        
        Path = Application.persistentDataPath + "/";
        
        }
    /*
    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowplayer);
        File.WriteAllText(Path + filename,data);
    }
    public void LoadData()
    {
        File.ReadAllText(Path + filename)
        JsonUtility.FromJson<Playerdata>(data); //data에 덮어 씌워진다. 이제 파일네임 건드리면 플롯이 달라짐

    }
*/
    // Start is called before the first frame update
    void Start()
    {
        string data = JsonUtility.ToJson(nowplayer);
        File.WriteAllText(Path + filename,data);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
