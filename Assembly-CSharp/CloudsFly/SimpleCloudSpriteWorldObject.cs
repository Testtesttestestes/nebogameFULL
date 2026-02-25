using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001304 RID: 4868
	[Token(Token = "0x2001304")]
	public class SimpleCloudSpriteWorldObject : WorldObject<SimpleSpriteCloudWorldObjectArgs>
	{
		// Token: 0x060073D3 RID: 29651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D3")]
		[Address(RVA = "0xBDB6", Offset = "0xBDB6", VA = "0xBDB6", Slot = "11")]
		protected override void OnInit(SimpleSpriteCloudWorldObjectArgs args)
		{
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D4")]
		[Address(RVA = "0xBDB7", Offset = "0xBDB7", VA = "0xBDB7")]
		public void OnOutOfRender()
		{
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D5")]
		[Address(RVA = "0xBDB8", Offset = "0xBDB8", VA = "0xBDB8")]
		public void UpdateOrder()
		{
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D6")]
		[Address(RVA = "0xBDB9", Offset = "0xBDB9", VA = "0xBDB9")]
		public SimpleCloudSpriteWorldObject()
		{
		}

		// Token: 0x04003CAA RID: 15530
		[Token(Token = "0x4003CAA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;
	}
}
