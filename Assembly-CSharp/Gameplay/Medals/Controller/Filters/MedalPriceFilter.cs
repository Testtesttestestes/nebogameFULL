using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	public class MedalPriceFilter : IMedalFilter
	{
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000717")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025C1")]
			[Address(RVA = "0x76FF", Offset = "0x76FF", VA = "0x76FF", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025C2")]
			[Address(RVA = "0x7700", Offset = "0x7700", VA = "0x7700", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x7701", Offset = "0x7701", VA = "0x7701", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x7702", Offset = "0x7702", VA = "0x7702")]
		public MedalPriceFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		uint Gameplay_Medals_Controller_Filters_MedalPriceFilter__set_FilterInfo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a57dde == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a57dde = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    return 1;
		  }
		  iVar1 = Core_Data_MedalData__get_CurrentMedal(param2,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x24),0);
		    uVar2 = uVar2 ^ 1;
		  }
		  return uVar2;
		}
		*/

}
