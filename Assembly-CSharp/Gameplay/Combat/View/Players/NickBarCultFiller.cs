using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000951 RID: 2385
	[Token(Token = "0x2000951")]
	public class NickBarCultFiller : MonoBehaviour
	{
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B22")]
		public CultDic CultDic
		{
			[Token(Token = "0x6003877")]
			[Address(RVA = "0x8821", Offset = "0x8821", VA = "0x8821")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003878")]
			[Address(RVA = "0x8822", Offset = "0x8822", VA = "0x8822")]
			set
			{
			}
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x8823", Offset = "0x8823", VA = "0x8823", Slot = "4")]
		protected virtual void HandleCultDicChanged()
		{
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x8824", Offset = "0x8824", VA = "0x8824")]
		public void SetIconBackgroundAssetId(string assetId)
		{
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x8825", Offset = "0x8825", VA = "0x8825")]
		public void SetNickBackgroundAssetId(string assetId)
		{
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387C")]
		[Address(RVA = "0x8826", Offset = "0x8826", VA = "0x8826")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387D")]
		[Address(RVA = "0x8827", Offset = "0x8827", VA = "0x8827")]
		public NickBarCultFiller()
		{
		}

		// Token: 0x04001F3A RID: 7994
		[Token(Token = "0x4001F3A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _iconBackground;

		// Token: 0x04001F3B RID: 7995
		[Token(Token = "0x4001F3B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _nickbackground;

		// Token: 0x04001F3C RID: 7996
		[Token(Token = "0x4001F3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001F3D RID: 7997
		[Token(Token = "0x4001F3D")]
		[FieldOffset(Offset = "0x1C")]
		private CultDic _cultDic;
	}
}
