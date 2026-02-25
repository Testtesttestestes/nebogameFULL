using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200139F RID: 5023
	[Token(Token = "0x200139F")]
	public class CoroutineManager : MonoBehaviour
	{
		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x0600779F RID: 30623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017B5")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x600779F")]
			[Address(RVA = "0xC0FD", Offset = "0xC0FD", VA = "0xC0FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A0")]
		[Address(RVA = "0xC0FE", Offset = "0xC0FE", VA = "0xC0FE")]
		private void Awake()
		{
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077A1")]
		[Address(RVA = "0xC0FF", Offset = "0xC0FF", VA = "0xC0FF")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A2")]
		[Address(RVA = "0xC100", Offset = "0xC100", VA = "0xC100")]
		public CoroutineManager()
		{
		}

		// Token: 0x04003E71 RID: 15985
		[Token(Token = "0x4003E71")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;
	}
}
