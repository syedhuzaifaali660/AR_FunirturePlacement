//Attach this script to your GameObject (make sure it has a Renderer component)
//Click on the GameObject. Attach your own Textures in the GameObject’s Inspector.

//This script takes your GameObject’s material and changes its Normal Map, Albedo, and Metallic properties to the Textures you attach in the GameObject’s Inspector. This happens when you enter Play Mode

using UnityEngine;

public class MaterialTexture : MonoBehaviour
{

    #region //Variable Assignment
    //CUSTOME TEXTURE RENDER ARRAY
    public Texture[] BaseTexture;
    public Texture[] NormalMaps;
    public Texture[] HeightMaps;
    public Renderer[] m_Renderer;

    //FOR SETTING VALUES OF METALLIC AND SMOOTHNESS
    float Metallic = 2.0f;
    float Gloss = 3.0f;
    #endregion

    #region //FOR GETTING A SPECIFIC SHADER
    //Shader shader1;
    //private Renderer[] rend;
    #endregion


#line hidden
    //public void TextureChanger1(int DefineStartingIndex)
    //{
    //    //Fetch the Renderer from the GameObject
    //    //AND APPLYING TEXTURES
    //    for (int i = DefineStartingIndex; i < (m_Renderer.Length); i++)
    //    {


    //        m_Renderer[i] = m_Renderer[i].GetComponent<Renderer>();
    //        //m_Renderer[i].material.shader = shader1;


    //        //Make sure to enable the Keywords
    //        m_Renderer[i].material.EnableKeyword("_NORMALMAP");
    //        m_Renderer[i].material.EnableKeyword("_PARALLAXMAP");

    //        //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
    //        m_Renderer[i].material.SetTexture("_MainTex", BaseTexture[i]);

    //        //Set the Texture for normal maps 
    //        m_Renderer[i].material.SetTexture("_BumpMap", NormalMaps[i]);
    //        m_Renderer[i].material.SetTexture("_BumpMap", HeightMaps[i]);
    //        m_Renderer[i].material.SetFloat("_Metallic", Metallic);
    //        m_Renderer[i].material.SetFloat("_Glossiness", Gloss);
    //        m_Renderer[i].material.SetTexture("_DetailMask", BaseTexture[i]);
    //    }
#line hidden


    void Update()
    {
        //DEFINNING THE SHADER WE WANT
        //shader1 = Shader.Find("Mobile/Bumped Diffuse");
        //m_Renderer[i].material.shader = shader1;
        
        #region //this code takes GO render and textures which are then placed on a GO with specified values
        //Fetch the Renderer from the GameObject
        //AND APPLYING TEXTURES
        for (int j = 0; j < (BaseTexture.Length)-1; j++)
        {
            //Debug.Log("This is render length---->" + m_Renderer.Length);
            //Debug.Log("\n this is j-->" + j);
            for (int i = 0; i < (m_Renderer.Length); i++)
            {
                //if(j==0 && i==0 || j==1 && i==0)
                //{
                //    Debug.Log("J inner loop of i -------->" + j);
                //}

                m_Renderer[i] = m_Renderer[i].GetComponent<Renderer>();
                //Debug.Log("Render loop i ------>" + i);

                //Make sure to enable the Keywords
                //m_Renderer[i].material.EnableKeyword("_NORMALMAP");
                //m_Renderer[i].material.EnableKeyword("_ParallaxMap");
                //m_Renderer[i].material.EnableKeyword("_DETAIL_MULX2");

                //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
                m_Renderer[i].material.SetTexture("_MainTex", BaseTexture[j]);

                //Set the Texture for normal maps 
                m_Renderer[i].material.SetTexture("_BumpMap", NormalMaps[j]);
                m_Renderer[i].material.SetTexture("_ParallaxMap", HeightMaps[j]);
                m_Renderer[i].material.SetTexture("_DetailAlbedoMap", BaseTexture[j]);

                //SETTING GLOSS AND MATELLIC FLAOT STATIC VALUES 
                m_Renderer[i].material.SetFloat("_Metallic", Metallic);
                m_Renderer[i].material.SetFloat("_Glossiness", Gloss);

            }

        }
        #endregion

    }



}