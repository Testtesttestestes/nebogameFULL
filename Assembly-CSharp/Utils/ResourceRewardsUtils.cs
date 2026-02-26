using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Utils
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public static class ResourceRewardsUtils
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x5756", Offset = "0x5756", VA = "0x5756")]
		private static Dictionary<RewardTypes, Resources> GetRewardToResourceDict()
		{
		/* --- GHIDRA: GetRewardToResourceDict ---
		void Utils_ResourceRewardsUtils__GetRewardToResourceDict
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a62814 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_RewardTypes___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils_TypeInfo);
		    DAT_ram_00a62814 = '\x01';
		  }
		  if (*(int *)(Utils_ResourceRewardsUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_ResourceRewardsUtils_TypeInfo);
		  }
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (**(undefined4 **)(Utils_ResourceRewardsUtils_TypeInfo + 0x5c),param2,
		                     Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    *param1 = 0;
		    return;
		  }
		  if (*(int *)(Utils_ResourceRewardsUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_ResourceRewardsUtils_TypeInfo);
		  }
		  param2_00 = GAFInternal_Reader_GAFReader__OpenTag
		                        (**(undefined4 **)(Utils_ResourceRewardsUtils_TypeInfo + 0x5c),param2,
		                         Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__get_Item__
		                        );
		  *param1 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor(param1,param2_00,Method_System_Nullable_RewardTypes___ctor__)
		  ;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x5757", Offset = "0x5757", VA = "0x5757")]
		public static RewardTypes? GetRewardTypes(Resources resource)
		{
		/* --- GHIDRA: GetRewardTypes ---
		void Utils_ResourceRewardsUtils__GetRewardTypes
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a62815 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RewardTypes__Resources__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RewardTypes__Resources__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils_TypeInfo);
		    DAT_ram_00a62815 = '\x01';
		  }
		  if (*(int *)(Utils_ResourceRewardsUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_ResourceRewardsUtils_TypeInfo);
		  }
		  uVar1 = Utils_OpTokenRepository__Cancel(param2);
		  iVar2 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_RewardTypes__Resources__ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    *param1 = 0;
		    return;
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_RewardTypes__Resources__get_Item__
		                    );
		  *param1 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor(param1,uVar1,Method_System_Nullable_Resources___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x5758", Offset = "0x5758", VA = "0x5758")]
		public static Resources? GetResources(RewardTypes reward)
		{
		/* --- GHIDRA: GetResources ---
		void Utils_ResourceRewardsUtils__GetResources(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a62816 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__RewardTypes___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Resources__RewardTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils_TypeInfo);
		    DAT_ram_00a62816 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_Resources__RewardTypes__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_Resources__RewardTypes___ctor__)
		  ;
		  func_ii_19537(param1_00,1,1,
		                Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__Add__);
		  func_ii_19537(param1_00,2,2,
		                Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__Add__);
		  func_ii_19537(param1_00,3,6,
		                Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__Add__);
		  func_ii_19537(param1_00,4,0x1a,
		                Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__Add__);
		  func_ii_19537(param1_00,5,s_Texture2DArray___dx_dx_d__is_too_ram_0001867d + 0x23,
		                Method_System_Collections_Generic_Dictionary_Resources__RewardTypes__Add__);
		  **(undefined4 **)(Utils_ResourceRewardsUtils_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Resources, RewardTypes> _resourceToRewardDict;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		void Utils_ResourceRewardsUtils___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a62817 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils___c_TypeInfo);
		    DAT_ram_00a62817 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_ResourceRewardsUtils___c_TypeInfo);
		  **(undefined4 **)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

}
