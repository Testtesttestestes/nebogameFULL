using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Rewards.Renderers.Portals
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	public class PortalCurrencyRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x5EC4", Offset = "0x5EC4", VA = "0x5EC4", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x5EC5", Offset = "0x5EC5", VA = "0x5EC5", Slot = "10")]
		protected virtual string GetIconAssetId(PortalDic dict)
		{
			return null;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x5EC6", Offset = "0x5EC6", VA = "0x5EC6")]
		public PortalCurrencyRewardRenderer()
		{
		}

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PortalDic.Types.ContentResource _iconResourceIdx;
	}
}
