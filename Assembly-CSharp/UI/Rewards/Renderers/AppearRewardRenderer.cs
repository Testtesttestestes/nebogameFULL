using System;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public class AppearRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x5E85", Offset = "0x5E85", VA = "0x5E85", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x5E86", Offset = "0x5E86", VA = "0x5E86")]
		public AppearRewardRenderer()
		{
		}

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AprView _aprViewPrefab;
	}
}
