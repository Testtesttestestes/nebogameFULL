using System;
using System.Collections;
using Gameplay.Combat.View.GameField;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000985 RID: 2437
	[Token(Token = "0x2000985")]
	[Serializable]
	public class LoseFieldAnimation : IDisposable
	{
		// Token: 0x06003A29 RID: 14889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A29")]
		[Address(RVA = "0x89A5", Offset = "0x89A5", VA = "0x89A5")]
		public void StartAnimation(StoneMono[,] stones, Transform parent)
		{
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A2A")]
		[Address(RVA = "0x89A6", Offset = "0x89A6", VA = "0x89A6")]
		private IEnumerator LoseEffect(StoneMono[,] stones)
		{
			return null;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A2B")]
		[Address(RVA = "0x89A7", Offset = "0x89A7", VA = "0x89A7", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x89A8", Offset = "0x89A8", VA = "0x89A8")]
		public LoseFieldAnimation()
		{
		}

		// Token: 0x0400201A RID: 8218
		[Token(Token = "0x400201A")]
		[FieldOffset(Offset = "0x8")]
		private Coroutine _routine;
	}
}
