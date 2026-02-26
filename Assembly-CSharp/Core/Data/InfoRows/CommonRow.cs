using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Data.InfoRows
{
	// Token: 0x020010DF RID: 4319
	[Token(Token = "0x20010DF")]
	public class CommonRow : IInformationRow
	{
		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600651B RID: 25883 RVA: 0x000133F8 File Offset: 0x000115F8
		// (set) Token: 0x0600651C RID: 25884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001479")]
		public InformationRowTypes Type
		{
			[Token(Token = "0x600651B")]
			[Address(RVA = "0xB0EC", Offset = "0xB0EC", VA = "0xB0EC", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return InformationRowTypes.Title;
			}
			[Token(Token = "0x600651C")]
			[Address(RVA = "0xB0ED", Offset = "0xB0ED", VA = "0xB0ED")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x0600651D RID: 25885 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600651E RID: 25886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147A")]
		public string Title
		{
			[Token(Token = "0x600651D")]
			[Address(RVA = "0xB0EE", Offset = "0xB0EE", VA = "0xB0EE", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600651E")]
			[Address(RVA = "0xB0EF", Offset = "0xB0EF", VA = "0xB0EF", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600651F")]
		[Address(RVA = "0xB0F0", Offset = "0xB0F0", VA = "0xB0F0")]
		public CommonRow()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_InfoRows_CommonRow___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 8) = 2;
		  return;
		}
		*/

		}
	}
}
