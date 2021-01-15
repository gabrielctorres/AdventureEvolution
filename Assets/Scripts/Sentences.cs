using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sentences")]
public class Sentences : ScriptableObject
{
    [TextArea(3, 10)]
    public string[] senteces;
}
