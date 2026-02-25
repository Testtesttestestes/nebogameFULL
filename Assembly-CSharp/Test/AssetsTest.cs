using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent.Loaders;
using Il2CppDummyDll;
using UnityEngine;

namespace Test
{
	// Token: 0x02000E45 RID: 3653
	[Token(Token = "0x2000E45")]
	public class AssetsTest : MonoBehaviour
	{
		// Token: 0x0600598E RID: 22926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598E")]
		[Address(RVA = "0xA6BA", Offset = "0xA6BA", VA = "0xA6BA")]
		public void StartTest()
		{
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600598F")]
		[Address(RVA = "0xA6BB", Offset = "0xA6BB", VA = "0xA6BB")]
		private IEnumerator ChangeCoroutine()
		{
			return null;
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005990")]
		[Address(RVA = "0xA6BC", Offset = "0xA6BC", VA = "0xA6BC")]
		public AssetsTest()
		{
		}

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x18")]
		private List<GameRawImageLoader> _loaders;
	}
}
