using System;
using Il2CppDummyDll;
using UI.SkinsV2;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001305 RID: 4869
	[Token(Token = "0x2001305")]
	public class TiledCloudSpriteWorldObject : WorldObject<TiledSpriteCloudWorldObjectArgs>
	{
		// Token: 0x060073D7 RID: 29655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D7")]
		[Address(RVA = "0xBDBA", Offset = "0xBDBA", VA = "0xBDBA", Slot = "11")]
		protected override void OnInit(TiledSpriteCloudWorldObjectArgs args)
		{
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D8")]
		[Address(RVA = "0xBDBB", Offset = "0xBDBB", VA = "0xBDBB")]
		public void OnOutOfRender()
		{
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D9")]
		[Address(RVA = "0xBDBC", Offset = "0xBDBC", VA = "0xBDBC")]
		public void UpdateOrder()
		{
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DA")]
		[Address(RVA = "0xBDBD", Offset = "0xBDBD", VA = "0xBDBD")]
		private void SetSprite(Sprite sprite)
		{
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0xBDBE", Offset = "0xBDBE", VA = "0xBDBE")]
		public TiledCloudSpriteWorldObject()
		{
		}

		// Token: 0x04003CAB RID: 15531
		[Token(Token = "0x4003CAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		// Token: 0x04003CAC RID: 15532
		[Token(Token = "0x4003CAC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SpriteRenderSkinResolver _skinResolver;
	}
}
