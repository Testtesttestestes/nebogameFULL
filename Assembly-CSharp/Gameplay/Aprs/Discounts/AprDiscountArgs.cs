using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Aprs.Discounts
{
	// Token: 0x02000D6B RID: 3435
	[Token(Token = "0x2000D6B")]
	public class AprDiscountArgs : DiscountArgs
	{
		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06005431 RID: 21553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001124")]
		public MedalDicWrapper Medal
		{
			[Token(Token = "0x6005431")]
			[Address(RVA = "0xA1E8", Offset = "0xA1E8", VA = "0xA1E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005432")]
		[Address(RVA = "0xA1E9", Offset = "0xA1E9", VA = "0xA1E9")]
		public AprDiscountArgs(DiscountTargets discountTarget, MedalDicWrapper medal)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Discounts_AprDiscountArgs___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59445 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs__Dispose__);
		    DAT_ram_00a59445 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  Core_Cache_AbstractCache_ulong__object___Complete
		            (param1,Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs__Dispose__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Medal ---
		void Gameplay_Aprs_Discounts_AprDiscountArgs__get_Medal
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x14) = param3;
		  return;
		}
		*/

}
