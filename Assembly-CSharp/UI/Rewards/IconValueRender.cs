using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	public class IconValueRender : AbstractRewardRender
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700017D")]
		public GameRawImage Icon
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x5E61", Offset = "0x5E61", VA = "0x5E61")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x5E62", Offset = "0x5E62", VA = "0x5E62")]
		public void SetValueVColor(Color32 color)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		public string IconAssetId
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x5E63", Offset = "0x5E63", VA = "0x5E63")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x5E64", Offset = "0x5E64", VA = "0x5E64")]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		public string Value
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x5E65", Offset = "0x5E65", VA = "0x5E65")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x5E66", Offset = "0x5E66", VA = "0x5E66")]
			set
			{
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x5E67", Offset = "0x5E67", VA = "0x5E67")]
		public void SetIcon(Sprite value)
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x5E68", Offset = "0x5E68", VA = "0x5E68")]
		public void SetIcon(Texture value)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x5E69", Offset = "0x5E69", VA = "0x5E69", Slot = "10")]
		protected virtual void HandleValueChanged()
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x5E6A", Offset = "0x5E6A", VA = "0x5E6A", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x5E6B", Offset = "0x5E6B", VA = "0x5E6B", Slot = "5")]
		public override AbstractRewardRender Render(RewardsContainer container, RewardData reward)
		{
			return null;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x5E6C", Offset = "0x5E6C", VA = "0x5E6C")]
		public IconValueRender()
		{
		}

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _valueTextField;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x30")]
		private string _value;
	}
}
