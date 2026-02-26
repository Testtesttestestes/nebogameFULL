using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D6 RID: 4310
	[Token(Token = "0x20010D6")]
	public class Skills : Dictionary<int, Skill>
	{
		// Token: 0x060064FB RID: 25851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FB")]
		[Address(RVA = "0xB0D3", Offset = "0xB0D3", VA = "0xB0D3")]
		public void AddSkill(Skill value)
		{
		/* --- GHIDRA: AddSkill ---
		undefined4
		Core_Data_Skills_Skills__AddSkill
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param3_00;
		  
		  if (DAT_ram_00a6082e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skills_TypeInfo);
		    DAT_ram_00a6082e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Data_Skills_Skills_TypeInfo);
		  if (DAT_ram_00a60832 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		    DAT_ram_00a60832 = '\x01';
		  }
		  param2_00 = 0;
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		  uVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (param2,Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		  uVar2 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (param3,Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  iVar3 = UnityEngine_Mathf__Min(uVar1,uVar2,0);
		  if (0 < iVar3) {
		    do {
		      uVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                        (param2,param2_00,
		                         Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		      uVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                        (param3,param2_00,
		                         Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		      param3_00 = Gameplay_Boss_Model_TeamData_TeamAssistantData__set_RawMercenaryInfo
		                            (uVar1,uVar2,param2_00);
		      if (DAT_ram_00a6082d == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_Dictionary_int__Skill__Add__);
		        DAT_ram_00a6082d = '\x01';
		      }
		      UnityEngine_Object__GetInstanceID
		                (param1_00,*(undefined4 *)(param3_00 + 8),param3_00,
		                 Method_System_Collections_Generic_Dictionary_int__Skill__Add__);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FC")]
		[Address(RVA = "0xB0D4", Offset = "0xB0D4", VA = "0xB0D4")]
		public Skills AddMods(Skills s1, Skills s2)
		{
		/* --- GHIDRA: AddMods ---
		undefined4 Core_Data_Skills_Skills__AddMods(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param3;
		  undefined8 uVar1;
		  int param2_00;
		  int param2_01;
		  
		  if (DAT_ram_00a6082f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skills_TypeInfo);
		    DAT_ram_00a6082f = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Data_Skills_Skills_TypeInfo);
		  if (DAT_ram_00a60832 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		    DAT_ram_00a60832 = '\x01';
		  }
		  param2_00 = 0;
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		  if (0 < *(int *)(param1 + 0xc)) {
		    do {
		      uVar1 = System_Collections_Generic_List_ulong___get_Count
		                        (param1,param2_00,Method_System_Collections_Generic_List_long__get_Item__);
		      if (DAT_ram_00a60831 == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skill_TypeInfo);
		        DAT_ram_00a60831 = '\x01';
		      }
		      param3 = unnamed_function_1417(Core_Data_Skills_Skill_TypeInfo);
		      *(undefined8 *)(param3 + 0x10) = uVar1;
		      *(int *)(param3 + 8) = param2_00;
		      param2_01 = param2_00;
		      if (DAT_ram_00a6082d == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_Dictionary_int__Skill__Add__);
		        DAT_ram_00a6082d = '\x01';
		        param2_01 = *(int *)(param3 + 8);
		      }
		      UnityEngine_Object__GetInstanceID
		                (param1_00,param2_01,param3,
		                 Method_System_Collections_Generic_Dictionary_int__Skill__Add__);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1 + 0xc));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FD")]
		[Address(RVA = "0xB0D5", Offset = "0xB0D5", VA = "0xB0D5")]
		public static Skills ParseSkills(List<long> value)
		{
		/* --- GHIDRA: ParseSkills ---
		undefined4 Core_Data_Skills_Skills__ParseSkills(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a60830 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_long___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Skills_Skills___c__ParseSkills_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skills___c_TypeInfo);
		    DAT_ram_00a60830 = '\x01';
		  }
		  if (*(int *)(Core_Data_Skills_Skills___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_Skills_Skills___c_TypeInfo);
		  }
		  piVar2 = *(int **)(Core_Data_Skills_Skills___c_TypeInfo + 0x5c);
		  param1_00 = piVar2[1];
		  param2_00 = Core_Data_Skills_Skills___c_TypeInfo;
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Data_Skills_Skills___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_Skills_Skills___c_TypeInfo);
		      piVar2 = *(int **)(Core_Data_Skills_Skills___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *piVar2;
		    param1_00 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		    System_Func_uint__Int32Enum___Invoke
		              (param1_00,param2_00,Method_Core_Data_Skills_Skills___c__ParseSkills_b__3_0__,0);
		    *(int *)(*(int *)(Core_Data_Skills_Skills___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (param1,param1_00,Method_System_Linq_Enumerable_Select_uint__long___);
		  uVar1 = System_Linq_Enumerable__ToList_int_(uVar1,Method_System_Linq_Enumerable_ToList_long___);
		  uVar1 = Core_Data_Skills_Skills__AddMods(uVar1,param2_00);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: ParseSkills ---
		undefined4 Core_Data_Skills_Skills__ParseSkills(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a60830 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_long___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Skills_Skills___c__ParseSkills_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skills___c_TypeInfo);
		    DAT_ram_00a60830 = '\x01';
		  }
		  if (*(int *)(Core_Data_Skills_Skills___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_Skills_Skills___c_TypeInfo);
		  }
		  piVar2 = *(int **)(Core_Data_Skills_Skills___c_TypeInfo + 0x5c);
		  param1_00 = piVar2[1];
		  param2_00 = Core_Data_Skills_Skills___c_TypeInfo;
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Data_Skills_Skills___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_Skills_Skills___c_TypeInfo);
		      piVar2 = *(int **)(Core_Data_Skills_Skills___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *piVar2;
		    param1_00 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		    System_Func_uint__Int32Enum___Invoke
		              (param1_00,param2_00,Method_Core_Data_Skills_Skills___c__ParseSkills_b__3_0__,0);
		    *(int *)(*(int *)(Core_Data_Skills_Skills___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (param1,param1_00,Method_System_Linq_Enumerable_Select_uint__long___);
		  uVar1 = System_Linq_Enumerable__ToList_int_(uVar1,Method_System_Linq_Enumerable_ToList_long___);
		  uVar1 = Core_Data_Skills_Skills__AddMods(uVar1,param2_00);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FE")]
		[Address(RVA = "0xB0D6", Offset = "0xB0D6", VA = "0xB0D6")]
		public static Skills ParseSkills(IList<uint> value)
		{
			return null;
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0xB0D7", Offset = "0xB0D7", VA = "0xB0D7")]
		public static Skill ParseSkill(int id, long value)
		{
			return null;
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006500")]
		[Address(RVA = "0xB0D8", Offset = "0xB0D8", VA = "0xB0D8", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Data_Skills_Skills__ToString(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60832 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		    DAT_ram_00a60832 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1,Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006501")]
		[Address(RVA = "0xB0D9", Offset = "0xB0D9", VA = "0xB0D9")]
		public Skills()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_Skills_Skills___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60833 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skills___c_TypeInfo);
		    DAT_ram_00a60833 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Data_Skills_Skills___c_TypeInfo);
		  **(undefined4 **)(Core_Data_Skills_Skills___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
