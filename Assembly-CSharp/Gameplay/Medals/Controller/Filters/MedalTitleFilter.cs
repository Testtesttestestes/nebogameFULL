using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	public class MedalTitleFilter : IMedalFilter
	{
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000719")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025C9")]
			[Address(RVA = "0x7707", Offset = "0x7707", VA = "0x7707", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025CA")]
			[Address(RVA = "0x7708", Offset = "0x7708", VA = "0x7708", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x7709", Offset = "0x7709", VA = "0x7709", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x770A", Offset = "0x770A", VA = "0x770A")]
		public MedalTitleFilter()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Medals_Controller_Filters_MedalTitleFilter___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57de0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_FilterInfo_TypeInfo);
		    DAT_ram_00a57de0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Medals_Controller_Filters_MedalTitleFilter__set_FilterInfo
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  
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
		  param1_00 = Core_Data_MedalData___ctor(param2,0);
		  uVar1 = func_ii_7903(param1_00,uVar1,0);
		  return uVar1;
		}
		*/

}
