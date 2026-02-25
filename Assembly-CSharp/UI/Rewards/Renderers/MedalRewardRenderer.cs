using System;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public class MedalRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000B99 RID: 2969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x5EB2", Offset = "0x5EB2", VA = "0x5EB2", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x5EB3", Offset = "0x5EB3", VA = "0x5EB3")]
		public MedalRewardRenderer()
		{
		}

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalView _medalViewPrefab;
	}
}
