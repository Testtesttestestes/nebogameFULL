using System;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000782 RID: 1922
	[Token(Token = "0x2000782")]
	public class AprSmallTagView : MonoBehaviour
	{
		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008CA")]
		public AprViewSmall AprView
		{
			[Token(Token = "0x6002DBF")]
			[Address(RVA = "0x7E3D", Offset = "0x7E3D", VA = "0x7E3D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x7E3E", Offset = "0x7E3E", VA = "0x7E3E")]
		public AprSmallTagView()
		{
		}

		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AprViewSmall _aprView;
	}
}
