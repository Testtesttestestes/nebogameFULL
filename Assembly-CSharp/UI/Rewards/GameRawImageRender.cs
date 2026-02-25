using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	public class GameRawImageRender : AbstractRewardRender
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		public string ImageAssetId
		{
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x5E5D", Offset = "0x5E5D", VA = "0x5E5D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x5E5E", Offset = "0x5E5E", VA = "0x5E5E")]
			set
			{
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x5E5F", Offset = "0x5E5F", VA = "0x5E5F", Slot = "5")]
		public override AbstractRewardRender Render(RewardsContainer container, RewardData reward)
		{
			return null;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x5E60", Offset = "0x5E60", VA = "0x5E60")]
		public GameRawImageRender()
		{
		}

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImage _image;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x2C")]
		private string _imageAssetId;
	}
}
