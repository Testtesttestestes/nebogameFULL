using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D8A RID: 3466
	[Token(Token = "0x2000D8A")]
	internal class AntiqModel : AbstractModel
	{
		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060054D1 RID: 21713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001147")]
		public IList<GroupData> Groups
		{
			[Token(Token = "0x60054D1")]
			[Address(RVA = "0xA27C", Offset = "0xA27C", VA = "0xA27C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054D3 RID: 21715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001148")]
		public GroupData CurrentGroup
		{
			[Token(Token = "0x60054D2")]
			[Address(RVA = "0xA27D", Offset = "0xA27D", VA = "0xA27D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054D3")]
			[Address(RVA = "0xA27E", Offset = "0xA27E", VA = "0xA27E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060054D4 RID: 21716 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054D5 RID: 21717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001149")]
		public ArtifactData CurrentArtifact
		{
			[Token(Token = "0x60054D4")]
			[Address(RVA = "0xA27F", Offset = "0xA27F", VA = "0xA27F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054D5")]
			[Address(RVA = "0xA280", Offset = "0xA280", VA = "0xA280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0xA281", Offset = "0xA281", VA = "0xA281")]
		public AntiqModel(CategoryData defaultCategory, Filter filter, IDictProvider dictProvider, PopupController popupController, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Antiq_Model_AntiqModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a59497 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GroupData__TypeInfo);
		    DAT_ram_00a59497 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x24);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GroupData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8100d9fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_GroupData__TypeInfo
		                                ,0);
		code_r0x8100d9fb:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return (uint)(1 < iVar3);
		}
		*/

		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0xA282", Offset = "0xA282", VA = "0xA282")]
		public bool GetIsGroupsScrollEnabled()
		{
		/* --- GHIDRA: GetIsGroupsScrollEnabled ---
		uint Gameplay_Antiq_Model_AntiqModel__GetIsGroupsScrollEnabled(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a59498 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__);
		    DAT_ram_00a59498 = '\x01';
		  }
		  if (*(int *)(param1 + 0x28) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Sirenix_Utilities_ImmutableList___Il2CppFullySharedGenericType___System_Collections_IList_set_Item
		                      (*(undefined4 *)(*(int *)(param1 + 0x28) + 8),
		                       Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__
		                      );
		    uVar2 = (uint)(1 < iVar1);
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0xA283", Offset = "0xA283", VA = "0xA283")]
		public bool GetIsArtifactsScrollEnabled()
		{
		/* --- GHIDRA: GetIsArtifactsScrollEnabled ---
		int Gameplay_Antiq_Model_AntiqModel__GetIsArtifactsScrollEnabled(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int param1_00;
		  int iVar3;
		  int *param1_01;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59499 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_CategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_Antiq_Types_ArtifactGroupsDic_Types_CategoryDic__CategoryData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CategoryData___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_Antiq_Types_ArtifactGroupsDic_Types_CategoryDic__CategoryData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CategoryData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CategoryData__Sort__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_CategoryData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_ObjectModel_ReadOnlyCollection_CategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Model_AntiqModel___c__GetCategories_b__20_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Model_AntiqModel___c__GetCategories_b__20_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_AntiqModel___c_TypeInfo);
		    DAT_ram_00a59499 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0xc);
		  if (iVar3 == 0) {
		    uVar1 = 0;
		    param1_01 = *(int **)(param1 + 0x14);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x8100db4c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8100db4c:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    uVar4 = *(undefined4 *)(iVar3 + 0x324);
		    if (*(int *)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x5c);
		    iVar3 = puVar5[1];
		    if (iVar3 == 0) {
		      if (*(int *)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo);
		        puVar5 = *(undefined4 **)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar5;
		      iVar3 = unnamed_function_1417
		                        (
		                        System_Func_Antiq_Types_ArtifactGroupsDic_Types_CategoryDic__CategoryData__TypeInfo
		                        );
		      System_Linq_Enumerable__Where_object_
		                (iVar3,param2_00,Method_Gameplay_Antiq_Model_AntiqModel___c__GetCategories_b__20_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x5c) + 4) = iVar3;
		    }
		    uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar4,iVar3,
		                       Method_System_Linq_Enumerable_Select_Antiq_Types_ArtifactGroupsDic_Types_CategoryDic__CategoryData___
		                      );
		    param1_00 = System_Linq_Enumerable__Select_object__object_
		                          (uVar4,Method_System_Linq_Enumerable_ToList_CategoryData___);
		    iVar3 = Method_System_Collections_Generic_List_CategoryData__Add__;
		    uVar4 = *(undefined4 *)(param1 + 0x1c);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar1 = *(uint *)(param1_00 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		    if (*(int *)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x5c);
		    iVar3 = puVar5[2];
		    if (iVar3 == 0) {
		      if (*(int *)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo);
		        puVar5 = *(undefined4 **)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar5;
		      iVar3 = unnamed_function_1417(System_Comparison_CategoryData__TypeInfo);
		      System_Collections_Generic_Comparer_object___get_Default
		                (iVar3,uVar4,Method_Gameplay_Antiq_Model_AntiqModel___c__GetCategories_b__20_1__,0);
		      *(int *)(*(int *)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x5c) + 8) = iVar3;
		    }
		    Google_Protobuf_Collections_RepeatedField_uint___Contains
		              (param1_00,iVar3,Method_System_Collections_Generic_List_CategoryData__Sort__);
		    iVar3 = unnamed_function_1417
		                      (System_Collections_ObjectModel_ReadOnlyCollection_CategoryData__TypeInfo);
		    System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		              (iVar3,param1_00,
		               Method_System_Collections_ObjectModel_ReadOnlyCollection_CategoryData___ctor__);
		    *(int *)(param1 + 0xc) = iVar3;
		  }
		  return iVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054D9")]
		[Address(RVA = "0xA284", Offset = "0xA284", VA = "0xA284")]
		[NotNull]
		public ReadOnlyCollection<CategoryData> GetCategories()
		{
		/* --- GHIDRA: GetCategories ---
		void Gameplay_Antiq_Model_AntiqModel__GetCategories(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5949a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_AddRange_ArtifactData___);
		    DAT_ram_00a5949a = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ArtifactData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x8100ddb0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_ArtifactData__TypeInfo,3);
		code_r0x8100ddb0:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_Sirenix_Utilities_LinqExtensions_AddRange_ArtifactData___);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DA")]
		[Address(RVA = "0xA285", Offset = "0xA285", VA = "0xA285")]
		public void SetArtifacts(IList<ArtifactData> value)
		{
		/* --- GHIDRA: SetArtifacts ---
		undefined4
		Gameplay_Antiq_Model_AntiqModel__SetArtifacts
		          (uint param1,int *param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 in_register_20000014;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  ulonglong param2_00;
		  int local_4;
		  
		  if (DAT_ram_00a5949c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5949c = '\x01';
		  }
		  local_4 = 0;
		  *param4 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8100df6e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8100df6e:
		  uVar2 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,CONCAT44(in_register_20000014,puVar3[1]))
		  ;
		  param2_00 = (ulonglong)param1;
		  iVar5 = func_ii_10817(param1_00,param2_00,&local_4,0);
		  if (iVar5 != 0) {
		    uVar2 = (undefined4)(param2_00 >> 0x20);
		    piVar4 = (int *)Core_Gameplay_Managers_UserManager__get_User(param3,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                      (piVar4,CONCAT44(uVar2,*(undefined4 *)(local_4 + 0x18)),param4,
		                       *(undefined4 *)(*piVar4 + 0x104));
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x1D20", Offset = "0x1D20", VA = "0x1D20")]
		public ArtifactData GetArtifact(ulong id)
		{
			return null;
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0xA286", Offset = "0xA286", VA = "0xA286")]
		public static bool TryGetEffectValue(Antiq.Types.EffectsDic.Types.EffectID effectID, IDictProvider dictProvider, UserData user, out TriggerValue trigger)
		{
		/* --- GHIDRA: TryGetEffectValue ---
		int Gameplay_Antiq_Model_AntiqModel__TryGetEffectValue
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5949d == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_Antiq_Types_EffectsDic_Types_EffectID_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_Antiq_Types_EffectsDic_Types_EffectID_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__TypeInfo);
		    DAT_ram_00a5949d = '\x01';
		  }
		  local_8 = 0;
		  iVar2 = unnamed_function_1417
		                    (System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,
		             Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID___ctor__);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  uVar3 = Protocol_Dic_Antiq_Types_EffectsDic_Types_EffectID_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar3 = System_Enum__GetUnderlyingType(uVar3,0);
		  local_4 = (int *)System_Array__Sort(uVar3,0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		code_r0x80ff9fae:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80ffa054;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ffa098:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ffa31b;
		      }
		code_r0x80ffa054:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ffa098;
		      if (iVar9 == 0) goto code_r0x80ffa364;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(piVar10[1] * 8 + iVar9 + 200);
		            goto code_r0x80ffa143;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ffa1f7:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ffa31b;
		      }
		code_r0x80ffa143:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = (int *)import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ffa1f7;
		      if (piVar7 == (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0xa7);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x80ffa46d:
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x80ffa230:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ffa31b;
		      }
		      if (*(int *)(*piVar7 + 0x20) !=
		          *(int *)(Protocol_Dic_Antiq_Types_EffectsDic_Types_EffectID_TypeInfo + 0x20)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                   Protocol_Dic_Antiq_Types_EffectsDic_Types_EffectID_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80ffa230;
		        goto code_r0x80ffa46d;
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)func_ii_15774(piVar7);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ffa1f7;
		      uVar3 = *puVar4;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x29c,param1,uVar3,param2
		                         ,param3,uVar3);
		      iVar6 = DAT_ram_009d3e38;
		      iVar9 = Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ffa31b;
		      }
		    } while (iVar5 == 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = uVar3;
		      goto code_r0x80ff9fae;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x9f,iVar2,uVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ffa31b:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80ffa364:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar7 = (int *)*local_c;
		      if (piVar7 != (int *)0x0) {
		        iVar9 = *piVar7;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80ffa3f4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80ffa3f4:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (local_14 == 0) {
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x29d,&local_14);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054DD")]
		[Address(RVA = "0xA287", Offset = "0xA287", VA = "0xA287")]
		public static List<Antiq.Types.EffectsDic.Types.EffectID> GetAntiqEffectsIndexes(UserData user, CombatTypes combatType, UserTypes opponentType)
		{
		/* --- GHIDRA: GetAntiqEffectsIndexes ---
		void Gameplay_Antiq_Model_AntiqModel__GetAntiqEffectsIndexes(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5949f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_AntiqModel___c_TypeInfo);
		    DAT_ram_00a5949f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Antiq_Model_AntiqModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x60054DE")]
		[Address(RVA = "0x1E23", Offset = "0x1E23", VA = "0x1E23")]
		private static bool HasEffectValue(UserData user, Antiq.Types.EffectsDic.Types.EffectID effectID, CombatTypes combatType, UserTypes opponentType)
		{
			return default(bool);
		}

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0xC")]
		private ReadOnlyCollection<CategoryData> _categories;

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList<ArtifactData> _artifacts;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x14")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x18")]
		public readonly Filter Filter;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x1C")]
		public readonly CategoryData DefaultCategory;

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x20")]
		public readonly PopupController PopupController;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentArtifact ---
		void Gameplay_Antiq_Model_AntiqModel__set_CurrentArtifact
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59496 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    DAT_ram_00a59496 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_GroupData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_GroupData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param6,0);
		  *(undefined4 *)(param1 + 0x20) = param5;
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  return;
		}
		*/

}
