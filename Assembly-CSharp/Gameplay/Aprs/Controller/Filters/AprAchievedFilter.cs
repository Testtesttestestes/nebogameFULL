using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D75 RID: 3445
	[Token(Token = "0x2000D75")]
	public class AprAchievedFilter : IAprFilter
	{
		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06005476 RID: 21622 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005477 RID: 21623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112A")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6005476")]
			[Address(RVA = "0xA22C", Offset = "0xA22C", VA = "0xA22C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005477")]
			[Address(RVA = "0xA22D", Offset = "0xA22D", VA = "0xA22D", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x6005478")]
		[Address(RVA = "0xA22E", Offset = "0xA22E", VA = "0xA22E", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005479")]
		[Address(RVA = "0xA22F", Offset = "0xA22F", VA = "0xA22F")]
		public AprAchievedFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		uint Gameplay_Aprs_Controller_Filters_AprAchievedFilter__set_FilterInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    return 1;
		  }
		  if (DAT_ram_00a59431 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		    DAT_ram_00a59431 = '\x01';
		  }
		  return (uint)(0 < *(int *)(*(int *)(param2 + 0x28) + 0x10));
		}
		*/

}
