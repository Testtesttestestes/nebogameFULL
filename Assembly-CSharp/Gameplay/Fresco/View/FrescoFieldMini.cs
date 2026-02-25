using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x20007F5")]
	public class FrescoFieldMini : FrescoField
	{
		// Token: 0x06002FDB RID: 12251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x8041", Offset = "0x8041", VA = "0x8041", Slot = "15")]
		protected override void ValidateSize(int sizeX, int sizeY, FrescoSpriteSelectorSO.SpriteSelectorElement spriteElement)
		{
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x8042", Offset = "0x8042", VA = "0x8042")]
		public FrescoFieldMini()
		{
		}

		// Token: 0x04001A29 RID: 6697
		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _field;
	}
}
