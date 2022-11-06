using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CatParts
{
   head, paws, tail
}

[CreateAssetMenu(fileName = "CatSO", menuName = "Cat Game/Create New CatSO", order = 1)]
public class CatSO : ScriptableObject

{
    public string catName;
    public List<PartData> catPartData = new List<PartData>();
    public List<Sprite> catStates;
}

[System.Serializable]
public struct PartData
{
    public CatParts catPart;
    public int score;
}