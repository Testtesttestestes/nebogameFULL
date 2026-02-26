using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C5B RID: 3163
	[Token(Token = "0x2000C5B")]
	public class BankTabData
	{
		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FA5")]
		public string Title
		{
			[Token(Token = "0x6004D46")]
			[Address(RVA = "0x9B80", Offset = "0x9B80", VA = "0x9B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06004D47 RID: 19783 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		[Token(Token = "0x17000FA6")]
		public uint TabId
		{
			[Token(Token = "0x6004D47")]
			[Address(RVA = "0x9B81", Offset = "0x9B81", VA = "0x9B81")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D48")]
		[Address(RVA = "0x9B82", Offset = "0x9B82", VA = "0x9B82")]
		public BankTabData(PaymentTabsDic paymentTabsDic, OptionTypesDic optionTypesDic)
		{
		}

		// Token: 0x04002A2C RID: 10796
		[Token(Token = "0x4002A2C")]
		[FieldOffset(Offset = "0x8")]
		public readonly OptionTypesDic.Types.OptionType OptionType;

		// Token: 0x04002A2D RID: 10797
		[Token(Token = "0x4002A2D")]
		[FieldOffset(Offset = "0xC")]
		public readonly PaymentTabsDic PaymentTabsDic;

		// Token: 0x04002A2E RID: 10798
		[Token(Token = "0x4002A2E")]
		[FieldOffset(Offset = "0x10")]
		public readonly OptionTypesDic OptionTypesDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TabId ---
		void Gameplay_Bank_Model_BankTabData__get_TabId
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  *(int *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 8) = *(undefined4 *)(param3 + 0xc);
		  return;
		}
		*/

}
