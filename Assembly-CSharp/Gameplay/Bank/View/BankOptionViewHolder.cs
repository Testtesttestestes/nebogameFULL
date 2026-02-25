using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C43 RID: 3139
	[Token(Token = "0x2000C43")]
	public class BankOptionViewHolder : BaseItemViewsHolder
	{
		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06004C95 RID: 19605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F6E")]
		public BankOptionView BankOptionView
		{
			[Token(Token = "0x6004C95")]
			[Address(RVA = "0x9AD6", Offset = "0x9AD6", VA = "0x9AD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C96")]
		[Address(RVA = "0x9AD7", Offset = "0x9AD7", VA = "0x9AD7", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C97")]
		[Address(RVA = "0x9AD8", Offset = "0x9AD8", VA = "0x9AD8")]
		public BankOptionViewHolder()
		{
		}

		// Token: 0x040029CB RID: 10699
		[Token(Token = "0x40029CB")]
		[FieldOffset(Offset = "0x14")]
		private BankOptionView _bankOptionView;
	}
}
