using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class MonetizationManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

        string gameId = " ";
#if UNITY_IOS
        gameId = "3907066";
#elif UNITY_ANDROID
        gameId = "3907067";       

#endif
       

    }

}
