using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D78 RID: 3448
	[Token(Token = "0x2000D78")]
	public class AprSkillFilter : IAprFilter
	{
		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005483 RID: 21635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112D")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6005482")]
			[Address(RVA = "0xA238", Offset = "0xA238", VA = "0xA238", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005483")]
			[Address(RVA = "0xA239", Offset = "0xA239", VA = "0xA239", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x6005484")]
		[Address(RVA = "0xA23A", Offset = "0xA23A", VA = "0xA23A", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005485")]
		[Address(RVA = "0xA23B", Offset = "0xA23B", VA = "0xA23B")]
		public AprSkillFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Aprs_Controller_Filters_AprSkillFilter__set_FilterInfo
		          (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59479 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    DAT_ram_00a59479 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) != '\0') {
		    param1_00 = *(int **)(*(int *)(param1 + 8) + 0xc);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(System_Collections_Generic_List_int__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(System_Collections_Generic_List_int__TypeInfo + 0xb8) * 4 + -4)
		          != System_Collections_Generic_List_int__TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,System_Collections_Generic_List_int__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar1 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x10);
		    if (*(int *)(Gameplay_Medals_Model_MedalUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    }
		    uVar1 = func_ii_7213(uVar1,param1_00,0);
		    return uVar1;
		  }
		  return 1;
		}
		*/

}
