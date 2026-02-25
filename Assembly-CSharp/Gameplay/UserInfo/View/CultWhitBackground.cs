using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	public class CultWhitBackground : CultView
	{
		// Token: 0x060017C9 RID: 6089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x6984", Offset = "0x6984", VA = "0x6984")]
		public void SetBackgroundAssetId(string assetId)
		{
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x6985", Offset = "0x6985", VA = "0x6985", Slot = "4")]
		protected override void HandleCultDicChanged()
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x6986", Offset = "0x6986", VA = "0x6986")]
		public CultWhitBackground()
		{
		}

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _background;
	}
}
