using System;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	public class AppearRewardRenderer2 : AbstractRewardRender
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x5E87", Offset = "0x5E87", VA = "0x5E87", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x5E88", Offset = "0x5E88", VA = "0x5E88")]
		public AppearRewardRenderer2()
		{
		}

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AprView _aprViewPrefab;
	}
}
