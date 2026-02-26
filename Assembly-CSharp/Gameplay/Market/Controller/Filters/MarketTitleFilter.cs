using System;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x200063D")]
	public class MarketTitleFilter : IMarketFilter
	{
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000740")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026C4")]
			[Address(RVA = "0x77F9", Offset = "0x77F9", VA = "0x77F9", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026C5")]
			[Address(RVA = "0x77FA", Offset = "0x77FA", VA = "0x77FA", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x77FB", Offset = "0x77FB", VA = "0x77FB", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Market_Controller_Filters_MarketTitleFilter__Filter(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  
		  param1_00 = *(int **)(*(int *)(param1 + 0xc) + 0xc);
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param1 + 8) = 0;
		    return;
		  }
		  if (DAT_ram_00a66978 != *param1_00) {
		    System_Activator__CreateInstance(param1_00,DAT_ram_00a66978);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = func_ii_7775(param1_00,0);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x77FC", Offset = "0x77FC", VA = "0x77FC", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x77FD", Offset = "0x77FD", VA = "0x77FD")]
		public MarketTitleFilter()
		{
		}

		// Token: 0x04001529 RID: 5417
		[Token(Token = "0x4001529")]
		[FieldOffset(Offset = "0x8")]
		private string _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Market_Controller_Filters_MarketTitleFilter__set_FilterInfo
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (*(char *)(*(int *)(param1 + 0xc) + 0x10) != '\0') {
		    uVar1 = Core_Data_ArtifactData__SetArtifactInfo(*(undefined4 *)(param2 + 8),0);
		    uVar1 = func_ii_7903(uVar1,*(undefined4 *)(param1 + 8),0);
		    return uVar1;
		  }
		  return 1;
		}
		*/

}
