using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D79 RID: 3449
	[Token(Token = "0x2000D79")]
	public class AprTitleFilter : IAprFilter
	{
		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005487 RID: 21639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112E")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6005486")]
			[Address(RVA = "0xA23C", Offset = "0xA23C", VA = "0xA23C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005487")]
			[Address(RVA = "0xA23D", Offset = "0xA23D", VA = "0xA23D", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x6005488")]
		[Address(RVA = "0xA23E", Offset = "0xA23E", VA = "0xA23E", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005489")]
		[Address(RVA = "0xA23F", Offset = "0xA23F", VA = "0xA23F")]
		public AprTitleFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Aprs_Controller_Filters_AprTitleFilter__set_FilterInfo
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int param1_02;
		  
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    return 1;
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  if ((param1_01 != (int *)0x0) && (DAT_ram_00a66978 != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,DAT_ram_00a66978);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = func_ii_7775(param1_01,0);
		  param1_02 = *(int *)(param2 + 0xc);
		  if (param1_02 == 0) {
		    if (DAT_ram_00a5942a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__)
		      ;
		      DAT_ram_00a5942a = '\x01';
		    }
		    param1_00 = func_ii_14054(*(undefined4 *)(*(int *)(param2 + 0x14) + 0x10),0);
		    param1_02 = func_ii_7775(param1_00,0);
		    *(int *)(param2 + 0xc) = param1_02;
		  }
		  uVar1 = func_ii_7903(param1_02,uVar1,0);
		  return uVar1;
		}
		*/

}
