using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	public class WaveAnimation : MonoBehaviour
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x5C55", Offset = "0x5C55", VA = "0x5C55")]
		private void Awake()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x5C56", Offset = "0x5C56", VA = "0x5C56")]
		private void Update()
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x5C57", Offset = "0x5C57", VA = "0x5C57")]
		public WaveAnimation()
		{
		}

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _speed;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _amount;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 _initPosition;
	}
}
