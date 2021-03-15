//This is based on a shader from https://alastaira.wordpress.com/2014/12/30/adding-shadows-to-a-unity-vertexfragment-shader-in-7-easy-steps/

Shader "Custom/MobileARShadow"
{
		Properties
		{
			_Color("Main Color", Color) = (1,1,1,.5)
			_ShadowIntensity("Shadow Intensity", Range(0, 1)) = 0.6
		}

			SubShader
		{

			Tags {"Queue" = "Geometry" }

			Pass
			{
				Tags {"LightMode" = "ForwardBase" }
				Cull Back
				Blend SrcAlpha OneMinusSrcAlpha
				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#pragma multi_compile_fwdbase

				#include "UnityCG.cginc"
				#include "AutoLight.cginc"
				uniform fixed4  _Color;
				uniform float _ShadowIntensity;

				struct v2f
				{
					float4 pos : SV_POSITION;
					LIGHTING_COORDS(0,1)
				};
				v2f vert(appdata_base v)
				{
					v2f o;
					o.pos = UnityObjectToClipPos(v.vertex);
					TRANSFER_VERTEX_TO_FRAGMENT(o);

					return o;
				}
				fixed4 frag(v2f i) : COLOR
				{
					float attenuation = LIGHT_ATTENUATION(i);

					return fixed4(0,0,0,(1 - attenuation)*_ShadowIntensity) + _Color;
				}
				ENDCG
			}

		}
			Fallback "VertexLit"
	}