using System;
using Il2CppDummyDll;
using UI.Informer.Network;
using UnityEngine;

namespace UI.Informer
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public class InformerView : MonoBehaviour
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700019A")]
		public LowNetworkResponseAbilityInformerView LowNetworkResponseAbilityInformer
		{
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x5F63", Offset = "0x5F63", VA = "0x5F63")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700019B")]
		public Transform NetworkResponseTimeExceeded
		{
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x5F64", Offset = "0x5F64", VA = "0x5F64")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x5F65", Offset = "0x5F65", VA = "0x5F65")]
		public InformerView()
		{
		}

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LowNetworkResponseAbilityInformerView lowNetworkResponseAbilityInformer;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _networkResponseTimeExceeded;
	}
}
