using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	public class ClanCultWithBackground : MonoBehaviour
	{
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000414")]
		public CultDic CultDic
		{
			[Token(Token = "0x600179A")]
			[Address(RVA = "0x6955", Offset = "0x6955", VA = "0x6955")]
			get
			{
				return null;
			}
			[Token(Token = "0x600179B")]
			[Address(RVA = "0x6956", Offset = "0x6956", VA = "0x6956")]
			set
			{
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000415")]
		public ClanCultDic ClanCultDic
		{
			[Token(Token = "0x600179C")]
			[Address(RVA = "0x6957", Offset = "0x6957", VA = "0x6957")]
			get
			{
				return null;
			}
			[Token(Token = "0x600179D")]
			[Address(RVA = "0x6958", Offset = "0x6958", VA = "0x6958")]
			set
			{
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x6959", Offset = "0x6959", VA = "0x6959", Slot = "4")]
		protected virtual void HandleCultDicChanged()
		{
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x695A", Offset = "0x695A", VA = "0x695A", Slot = "5")]
		protected virtual void HandleClanCultDicChanged()
		{
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x695B", Offset = "0x695B", VA = "0x695B")]
		private void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x695C", Offset = "0x695C", VA = "0x695C")]
		public void SetBackgroundAssetId(string assetId)
		{
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x695D", Offset = "0x695D", VA = "0x695D")]
		public ClanCultWithBackground()
		{
		}

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _background;

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0x18")]
		private CultDic _cultDic;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0x1C")]
		private ClanCultDic _clanCultDic;
	}
}
