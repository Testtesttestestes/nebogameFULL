using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	public class MedalOtherFilter : IMedalFilter
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000716")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025BD")]
			[Address(RVA = "0x76FB", Offset = "0x76FB", VA = "0x76FB", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025BE")]
			[Address(RVA = "0x76FC", Offset = "0x76FC", VA = "0x76FC", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x76FD", Offset = "0x76FD", VA = "0x76FD", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x76FE", Offset = "0x76FE", VA = "0x76FE")]
		public MedalOtherFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		uint Gameplay_Medals_Controller_Filters_MedalOtherFilter__set_FilterInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a57ddd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    DAT_ram_00a57ddd = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    return 1;
		  }
		  do {
		    piVar3 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                              (*(undefined4 *)(*(int *)(param2 + 8) + 8),
		                               Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                              );
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_ICollection_MedalDicWrapper__TypeInfo == *piVar7) {
		          puVar4 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e65119;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar3,
		                                  System_Collections_Generic_ICollection_MedalDicWrapper__TypeInfo,0
		                                 );
		code_r0x80e65119:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		    bVar1 = iVar5 < iVar6;
		    if (bVar1 == 0) {
		      return 0;
		    }
		    piVar3 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                              (*(undefined4 *)(*(int *)(param2 + 8) + 8),
		                               Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                              );
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IList_MedalDicWrapper__TypeInfo == *piVar7) {
		          puVar4 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e651b0;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar3,System_Collections_Generic_IList_MedalDicWrapper__TypeInfo,
		                                  0);
		code_r0x80e651b0:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,iVar5,puVar4[1]);
		    param1_00 = *(undefined4 *)(iVar6 + 0x10);
		    if (*(int *)(Gameplay_Medals_Model_MedalUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    }
		    iVar5 = iVar5 + 1;
		    iVar6 = Gameplay_Medals_Model_MedalTabBarItemData___ctor(param1_00,param1_00);
		    if (iVar6 != 0) {
		      return (uint)bVar1;
		    }
		  } while( true );
		}
		*/

}
