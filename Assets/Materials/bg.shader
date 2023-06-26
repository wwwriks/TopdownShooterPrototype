Shader "Unlit/bg"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            uniform float _XSpeed;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            float Rand(fixed2 st)
            {
                return frac(sin(dot(st, fixed2(12, 78))) * 42758);
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // fixed4 col = tex2D(_MainTex, i.uv);
                fixed2 st = i.uv * 2.0 - 1.0;
                st = 1.0 - abs(st);
                float r = sin((_Time.y + i.uv.y * st.x) * 10);
                fixed4 col = fixed4(0.1 * r , 0.4 * r, 1.0, 1.0) + (st.x / 2.0) * (st.y + 0.5);
                // if (col.r < 0.5) discard;
                return col;
            }
            ENDCG
        }
    }
}
