using System;
using Core.Dict;
using Il2CppDummyDll;

namespace Core.Data
{
	// Token: 0x020010B6 RID: 4278
	[Token(Token = "0x20010B6")]
	public class ArtikulDataCustom : ArtikulData
	{
		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060063B4 RID: 25524 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x170013FE")]
		public override int CurrentDurability
		{
			[Token(Token = "0x60063B4")]
			[Address(RVA = "0xAFB6", Offset = "0xAFB6", VA = "0xAFB6", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B5")]
		[Address(RVA = "0xAFB7", Offset = "0xAFB7", VA = "0xAFB7")]
		public void SetCurrentDurability(int value)
		{
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60063B6")]
		[Address(RVA = "0xAFB8", Offset = "0xAFB8", VA = "0xAFB8")]
		public new static ArtikulDataCustom Create(uint artikulId, IDictProvider provider)
		{
			return null;
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B7")]
		[Address(RVA = "0xAFB9", Offset = "0xAFB9", VA = "0xAFB9")]
		public ArtikulDataCustom()
		{
		}

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x38")]
		private int _currentDurability;
	}
}
