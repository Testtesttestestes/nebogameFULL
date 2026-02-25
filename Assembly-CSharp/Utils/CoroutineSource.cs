using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class CoroutineSource : MonoBehaviour
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x56D7", Offset = "0x56D7", VA = "0x56D7")]
		private static CoroutineSource GetMono()
		{
			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x56D8", Offset = "0x56D8", VA = "0x56D8")]
		public static Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x56D9", Offset = "0x56D9", VA = "0x56D9")]
		public static void StopCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1F0F", Offset = "0x1F0F", VA = "0x1F0F")]
		public static void StopCoroutine(Coroutine routine)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x56DA", Offset = "0x56DA", VA = "0x56DA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x56DB", Offset = "0x56DB", VA = "0x56DB")]
		public CoroutineSource()
		{
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineSource _coroutineSource;
	}
}
