using UnityEngine;

public class MateriaAssignningTOMultipleGO : MonoBehaviour
{
    #region //Variable Assignment
    [Header("GAME OBJECTS")]
    public GameObject[] thegameobjects;
    public GameObject[] thegameobjects2;
    [Header("MATERIALS")]
    public Material FrontMaterial1, SideMaterial1, FrontMaterial2, SideMaterial2, FrontMaterial3, SideMaterial3;
    #endregion


    #region //ASSIGNNING MATERIAL TO MULTIPLE GAMEOBJECTS
   public void AssignSameMaterialToMultipleGO(int TextureButton)
    {
        if (TextureButton == 0)
        {
            foreach (var obj in thegameobjects )
            {
                obj.GetComponent<Renderer>().sharedMaterial = FrontMaterial1;
            }

            foreach (var obj2 in thegameobjects2)
            {
                obj2.GetComponent<Renderer>().sharedMaterial = SideMaterial1;
            }
        }
        else if(TextureButton == 1)
        {
            foreach (var obj in thegameobjects)
            {
                obj.GetComponent<Renderer>().sharedMaterial = FrontMaterial2;
            }

            foreach (var obj2 in thegameobjects2)
            {
                obj2.GetComponent<Renderer>().sharedMaterial = SideMaterial2;
            }
        }
        else
        {
            foreach (var obj in thegameobjects)
            {
                obj.GetComponent<Renderer>().sharedMaterial = FrontMaterial3;
            }

            foreach (var obj2 in thegameobjects2)
            {
                obj2.GetComponent<Renderer>().sharedMaterial = SideMaterial3;
            }
        }
    }
    #endregion




    #region //ORIGINAL CODE
    //public GameObject[] thegameobjects;
    //public Material materialtobeassigned;
    //public void AssignMaterialToTheThreeObjects()
    //{
    //    foreach (var obj in thegameobjects)
    //    {
    //        obj.GetComponent<Renderer>().sharedMaterial = materialtobeassigned;
    //    }
    //}

    #endregion
}

