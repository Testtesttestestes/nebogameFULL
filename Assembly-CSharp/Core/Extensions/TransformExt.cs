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
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0xA9B2", Offset = "0xA9B2", VA = "0xA9B2")]
		public static void SetLeft(this RectTransform rt, float left)
		{
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0xA9B3", Offset = "0xA9B3", VA = "0xA9B3")]
		public static void SetRight(this RectTransform rt, float right)
		{
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3F")]
		[Address(RVA = "0xA9B4", Offset = "0xA9B4", VA = "0xA9B4")]
		public static void SetTop(this RectTransform rt, float top)
		{
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D40")]
		[Address(RVA = "0xA9B5", Offset = "0xA9B5", VA = "0xA9B5")]
		public static void SetBottom(this RectTransform rt, float bottom)
		{
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
