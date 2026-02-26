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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BankOptionView ---
		void Gameplay_Bank_View_BankOptionViewHolder__get_BankOptionView(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59794 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_BankOptionView___);
		    DAT_ram_00a59794 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_BankOptionView___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
