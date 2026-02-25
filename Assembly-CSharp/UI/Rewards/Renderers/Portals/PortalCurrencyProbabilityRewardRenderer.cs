using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Rewards.Renderers.Portals
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	public class PortalCurrencyProbabilityRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x5EC1", Offset = "0x5EC1", VA = "0x5EC1", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x5EC2", Offset = "0x5EC2", VA = "0x5EC2", Slot = "10")]
		protected virtual string GetIconAssetId(PortalDic dict)
		{
			return null;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x5EC3", Offset = "0x5EC3", VA = "0x5EC3")]
		public PortalCurrencyProbabilityRewardRenderer()
		{
		}

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PortalDic.Types.ContentResource _iconResourceIdx;
	}
}
