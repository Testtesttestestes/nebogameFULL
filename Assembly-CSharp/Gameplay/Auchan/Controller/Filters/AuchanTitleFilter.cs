using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Auchan.Controller.Filters
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	public class AuchanTitleFilter : IAuchanItemFilter
	{
		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FED")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6004EB0")]
			[Address(RVA = "0x9CE1", Offset = "0x9CE1", VA = "0x9CE1", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EB1")]
			[Address(RVA = "0x9CE2", Offset = "0x9CE2", VA = "0x9CE2", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x9CE3", Offset = "0x9CE3", VA = "0x9CE3", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Auchan_Controller_Filters_AuchanTitleFilter__Filter(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58971 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_FilterInfo_TypeInfo);
		    DAT_ram_00a58971 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x9CE4", Offset = "0x9CE4", VA = "0x9CE4")]
		public AuchanTitleFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Auchan_Controller_Filters_AuchanTitleFilter__set_FilterInfo
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
		  param1_00 = Core_Data_ArtifactData__SetArtifactInfo(param2,0);
		  uVar1 = func_ii_7903(param1_00,uVar1,0);
		  return uVar1;
		}
		*/

}
