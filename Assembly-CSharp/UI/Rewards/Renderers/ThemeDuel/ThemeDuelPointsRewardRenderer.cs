using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI.Rewards.Renderers.ThemeDuel
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	public class ThemeDuelPointsRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x5EBC", Offset = "0x5EBC", VA = "0x5EBC", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x5EBD", Offset = "0x5EBD", VA = "0x5EBD", Slot = "10")]
		protected virtual string GetIconAssetId(ThemeDuelDic dict)
		{
			return null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x5EBE", Offset = "0x5EBE", VA = "0x5EBE")]
		public ThemeDuelPointsRewardRenderer()
		{
		}

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_resourceIdx")]
		[SerializeField]
		private ThemeDuelDic.Types.ContentResource _iconResourceIdx;
	}
}
