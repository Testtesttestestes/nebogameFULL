using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Collections.Controller.Filters
{
	// Token: 0x020009EB RID: 2539
	[Token(Token = "0x20009EB")]
	public class CollectionSkillFilter : ICollectionFilter
	{
		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003CA9 RID: 15529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF1")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6003CA8")]
			[Address(RVA = "0x8B6F", Offset = "0x8B6F", VA = "0x8B6F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CA9")]
			[Address(RVA = "0x8B70", Offset = "0x8B70", VA = "0x8B70", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x8B71", Offset = "0x8B71", VA = "0x8B71", Slot = "6")]
		public bool Filter(CollectionData collectionData)
		{
			return default(bool);
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x8B72", Offset = "0x8B72", VA = "0x8B72")]
		public CollectionSkillFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Collections_Controller_Filters_CollectionSkillFilter__set_FilterInfo
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57eeb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    DAT_ram_00a57eeb = '\x01';
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
		    uVar1 = Core_Data_CollectionData__get_CurrentMedalDic(param2,0);
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
