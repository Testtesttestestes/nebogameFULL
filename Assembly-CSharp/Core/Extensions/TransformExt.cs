using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Extensions
{
	// Token: 0x02000F10 RID: 3856
	[Token(Token = "0x2000F10")]
	public static class TransformExt
	{
		// Token: 0x06005D3C RID: 23868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0xA9B1", Offset = "0xA9B1", VA = "0xA9B1")]
		public static void ToTransformData(this Transform transform, out TransformExt.TransformData td)
		{
		/* --- GHIDRA: ToTransformData ---
		void Core_Extensions_TransformExt__ToTransformData(undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined8 local_18;
		  float4 local_10;
		  undefined4 local_c;
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  UnityEngine_RectTransform__set_anchoredPosition3D(auStack_8,param1,0);
		  local_c = local_4;
		  local_18 = CONCAT44(local_4,param2);
		  local_10 = (float4)param2;
		  UnityEngine_RectTransform__get_offsetMin(param1,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0xA9B2", Offset = "0xA9B2", VA = "0xA9B2")]
		public static void SetLeft(this RectTransform rt, float left)
		{
		/* --- GHIDRA: SetLeft ---
		void Core_Extensions_TransformExt__SetLeft(undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined8 local_18;
		  float4 local_10;
		  undefined4 local_c;
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  UnityEngine_RectTransform__set_offsetMin(auStack_8,param1,0);
		  local_10 = (float4)-param2;
		  local_c = local_4;
		  local_18 = CONCAT44(local_4,local_10);
		  UnityEngine_RectTransform__get_offsetMax(param1,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0xA9B3", Offset = "0xA9B3", VA = "0xA9B3")]
		public static void SetRight(this RectTransform rt, float right)
		{
		/* --- GHIDRA: SetRight ---
		void Core_Extensions_TransformExt__SetRight(undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined8 local_18;
		  undefined4 local_10;
		  float4 local_c;
		  undefined4 local_8 [2];
		  
		  UnityEngine_RectTransform__set_offsetMin(local_8,param1,0);
		  local_c = (float4)-param2;
		  local_10 = local_8[0];
		  local_18 = CONCAT44(local_c,local_8[0]);
		  UnityEngine_RectTransform__get_offsetMax(param1,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3F")]
		[Address(RVA = "0xA9B4", Offset = "0xA9B4", VA = "0xA9B4")]
		public static void SetTop(this RectTransform rt, float top)
		{
		/* --- GHIDRA: SetTop ---
		void Core_Extensions_TransformExt__SetTop(undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined8 local_18;
		  undefined4 local_10;
		  float4 local_c;
		  undefined4 local_8 [2];
		  
		  UnityEngine_RectTransform__set_anchoredPosition3D(local_8,param1,0);
		  local_10 = local_8[0];
		  local_18 = CONCAT44(param2,local_8[0]);
		  local_c = (float4)param2;
		  UnityEngine_RectTransform__get_offsetMin(param1,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D40")]
		[Address(RVA = "0xA9B5", Offset = "0xA9B5", VA = "0xA9B5")]
		public static void SetBottom(this RectTransform rt, float bottom)
		{
		/* --- GHIDRA: SetBottom ---
		void Core_Extensions_TransformExt__SetBottom(uint *param1,uint param2,undefined4 param3)
		
		{
		  *param1 = *param1 | param2;
		  return;
		}
		*/

		}

		// Token: 0x02000F11 RID: 3857
		[Token(Token = "0x2000F11")]
		[Serializable]
		public struct TransformData
		{
			// Token: 0x040032D9 RID: 13017
			[Token(Token = "0x40032D9")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x040032DA RID: 13018
			[Token(Token = "0x40032DA")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			// Token: 0x040032DB RID: 13019
			[Token(Token = "0x40032DB")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 localPosition;

			// Token: 0x040032DC RID: 13020
			[Token(Token = "0x40032DC")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 localScale;

			// Token: 0x040032DD RID: 13021
			[Token(Token = "0x40032DD")]
			[FieldOffset(Offset = "0x34")]
			public Quaternion localRotation;

			// Token: 0x040032DE RID: 13022
			[Token(Token = "0x40032DE")]
			[FieldOffset(Offset = "0x44")]
			public Transform parent;
		}
	}
}
