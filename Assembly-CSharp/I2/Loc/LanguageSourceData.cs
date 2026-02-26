using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x0200136E RID: 4974
	[Token(Token = "0x200136E")]
	[ExecuteInEditMode]
	[Serializable]
	public class LanguageSourceData
	{
		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x060075FE RID: 30206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017A6")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x60075FE")]
			[Address(RVA = "0xBF85", Offset = "0xBF85", VA = "0xBF85")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000307 RID: 775
		// (add) Token: 0x060075FF RID: 30207 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007600 RID: 30208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000307")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60075FF")]
			[Address(RVA = "0xBF86", Offset = "0xBF86", VA = "0xBF86")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007600")]
			[Address(RVA = "0xBF87", Offset = "0xBF87", VA = "0xBF87")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007601")]
		[Address(RVA = "0xBF88", Offset = "0xBF88", VA = "0xBF88")]
		public void Awake()
		{
		/* --- GHIDRA: Awake ---
		void I2_Loc_LanguageSourceData__Awake(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6047e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6047e = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (DAT_ram_00a6050f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__Remove__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6050f = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  func_ii_4876(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param1,
		               Method_System_Collections_Generic_List_LanguageSourceData__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x06007602 RID: 30210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007602")]
		[Address(RVA = "0xBF89", Offset = "0xBF89", VA = "0xBF89")]
		public void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		uint I2_Loc_LanguageSourceData__OnDestroy(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a6047f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a6047f = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param2 + 0x24) + 0xc);
		  if (iVar3 == *(int *)(*(int *)(param1 + 0x24) + 0xc)) {
		    if (0 < iVar3) {
		      iVar4 = 0;
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar4,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar2 = I2_Loc_LanguageSourceData__Import_Google_Result
		                          (param2,*(undefined4 *)(iVar2 + 8),1,1,iVar4);
		        if (iVar2 < 0) {
		          return 0;
		        }
		        iVar4 = iVar4 + 1;
		      } while (iVar4 != iVar3);
		    }
		    iVar4 = *(int *)(*(int *)(param2 + 0x10) + 0xc);
		    iVar3 = *(int *)(param1 + 0x10);
		    if ((iVar4 == *(int *)(iVar3 + 0xc)) && (uVar1 = 1, 0 < iVar4)) {
		      iVar4 = 0;
		      do {
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (iVar3,iVar4,Method_System_Collections_Generic_List_TermData__get_Item__);
		        iVar3 = func_ii_13851(param2,*(undefined4 *)(iVar3 + 8),0,iVar4);
		        uVar1 = (uint)(iVar3 != 0);
		        if (iVar3 == 0) {
		          return 0;
		        }
		        iVar4 = iVar4 + 1;
		        iVar3 = *(int *)(param1 + 0x10);
		      } while (iVar4 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06007603 RID: 30211 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x6007603")]
		[Address(RVA = "0xBF8A", Offset = "0xBF8A", VA = "0xBF8A")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
		/* --- GHIDRA: IsEqualTo ---
		uint I2_Loc_LanguageSourceData__IsEqualTo(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a60480 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60480 = '\x01';
		  }
		  uVar1 = 1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (iVar3 < 1) {
		    uVar1 = 0;
		  }
		  else {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                             param2_00,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      if (((param1_00 != 0) &&
		          (iVar2 = I2_Loc_LanguageSourceData__OnDestroy(param1_00,param1,param2_00),
		          param1 != param1_00)) && (iVar2 != 0)) {
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      uVar1 = (uint)(param2_00 < iVar3);
		    } while (param2_00 != iVar3);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x6007604")]
		[Address(RVA = "0xBF8B", Offset = "0xBF8B", VA = "0xBF8B")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007605")]
		[Address(RVA = "0x3603", Offset = "0x3603", VA = "0x3603")]
		public void ClearAllData()
		{
		/* --- GHIDRA: ClearAllData ---
		int I2_Loc_LanguageSourceData__ClearAllData(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  int iVar3;
		  int param1_00;
		  undefined4 param2_01;
		  uint uVar4;
		  
		  if (DAT_ram_00a604ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string____Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string_____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string____TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18846);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18962);
		    DAT_ram_00a604ca = '\x01';
		  }
		  param2_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(param2_00 + 0x10) = StringLiteral_18846;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = StringLiteral_18962;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string____TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string_____ctor__);
		  iVar3 = System_UriBuilder___ctor(param1,iVar3,0,0);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar2 = 0;
		    do {
		      param2_01 = System_UriBuilder___ctor(*(undefined4 *)(iVar3 + iVar2 * 4 + 0x10),param2_00,0,0);
		      iVar1 = Method_System_Collections_Generic_List_string____Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar4 = *(uint *)(param1_00 + 0xc);
		      if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = param2_01;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2_01,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar3 + 0xc));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06007606 RID: 30214 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x6007606")]
		[Address(RVA = "0xBF8C", Offset = "0xBF8C", VA = "0xBF8C")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007607")]
		[Address(RVA = "0xBF8D", Offset = "0xBF8D", VA = "0xBF8D")]
		public void Editor_SetDirty()
		{
		/* --- GHIDRA: Editor_SetDirty ---
		void I2_Loc_LanguageSourceData__Editor_SetDirty(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a60482 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_Object___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_Object__string___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_IGrouping_string__Object___string__Object___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_string__Object___Object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Object__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_string__Object___string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__RemoveAll__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_Object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_3__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData___c_TypeInfo);
		    DAT_ram_00a60482 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x54);
		  if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Predicate_Object__TypeInfo);
		    func_ii_7297(iVar3,uVar4,Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_0__,0
		                );
		    *(int *)(*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  System_Collections_Generic_List_object___IsCompatibleObject
		            (uVar1,iVar3,Method_System_Collections_Generic_List_Object__RemoveAll__);
		  uVar1 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x54),Method_System_Linq_Enumerable_Distinct_Object___
		                    );
		  if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_Object__string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar3,uVar4,Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_1__,0);
		    *(int *)(*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  uVar1 = System_Linq_Enumerable__GroupBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,iVar3,
		                     *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8),
		                     Method_System_Linq_Enumerable_GroupBy_Object__string___);
		  if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[3];
		  iVar3 = I2_Loc_LanguageSourceData___c_TypeInfo;
		  if (param1_00 == 0) {
		    if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_IGrouping_string__Object___string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_00,uVar4,Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_2__
		               ,0);
		    iVar3 = I2_Loc_LanguageSourceData___c_TypeInfo;
		    *(int *)(*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c) + 0xc) = param1_00;
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		    iVar3 = I2_Loc_LanguageSourceData___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(iVar3 + 0x5c);
		  param1_01 = puVar2[4];
		  if (param1_01 == 0) {
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		      puVar2 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_IGrouping_string__Object___Object__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_01,uVar4,Method_I2_Loc_LanguageSourceData___c__UpdateAssetDictionary_b__39_3__
		               ,0);
		    *(int *)(*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c) + 0x10) = param1_01;
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__object__Int32Enum_
		                    (uVar1,param1_00,param1_01,
		                     *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8),
		                     Method_System_Linq_Enumerable_ToDictionary_IGrouping_string__Object___string__Object___
		                    );
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007608")]
		[Address(RVA = "0xBF8E", Offset = "0xBF8E", VA = "0xBF8E")]
		public void UpdateAssetDictionary()
		{
		/* --- GHIDRA: UpdateAssetDictionary ---
		undefined4
		I2_Loc_LanguageSourceData__UpdateAssetDictionary(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60483 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__get_Count__);
		    DAT_ram_00a60483 = '\x01';
		  }
		  local_4 = 0;
		  uVar2 = 0;
		  if (*(int *)(param1 + 0x54) != 0) {
		    if ((*(int *)(param1 + 0x58) == 0) ||
		       (iVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                          (*(int *)(param1 + 0x58),
		                           Method_System_Collections_Generic_Dictionary_string__Object__get_Count__)
		       , iVar1 != *(int *)(*(int *)(param1 + 0x54) + 0xc))) {
		      I2_Loc_LanguageSourceData__Editor_SetDirty(param1,auStack_10);
		    }
		    iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                      (*(undefined4 *)(param1 + 0x58),param2,&local_4,
		                       Method_System_Collections_Generic_Dictionary_string__Object__TryGetValue__);
		    uVar2 = local_4;
		    if (iVar1 == 0) {
		      uVar2 = 0;
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06007609 RID: 30217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007609")]
		[Address(RVA = "0xBF8F", Offset = "0xBF8F", VA = "0xBF8F")]
		public UnityEngine.Object FindAsset(string Name)
		{
		/* --- GHIDRA: FindAsset ---
		undefined4 I2_Loc_LanguageSourceData__FindAsset(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60484 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Contains__);
		    DAT_ram_00a60484 = '\x01';
		  }
		  uVar1 = func_ii_4685(*(undefined4 *)(param1 + 0x54),param2,
		                       Method_System_Collections_Generic_List_Object__Contains__);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x600760A")]
		[Address(RVA = "0xBF90", Offset = "0xBF90", VA = "0xBF90")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
		/* --- GHIDRA: HasAsset ---
		void I2_Loc_LanguageSourceData__HasAsset(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a60485 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Contains__);
		    DAT_ram_00a60485 = '\x01';
		  }
		  iVar2 = func_ii_4685(*(undefined4 *)(param1 + 0x54),param2,
		                       Method_System_Collections_Generic_List_Object__Contains__);
		  iVar1 = Method_System_Collections_Generic_List_Object__Add__;
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(param1 + 0x54);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar3 = *(uint *)(iVar2 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar3 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar3 * 4 + 0x10) = param2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    I2_Loc_LanguageSourceData__Editor_SetDirty(param1,param1);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760B")]
		[Address(RVA = "0xBF91", Offset = "0xBF91", VA = "0xBF91")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		/* --- GHIDRA: AddAsset ---
		undefined4 I2_Loc_LanguageSourceData__AddAsset(int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a60486 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18954);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18959);
		    DAT_ram_00a60486 = '\x01';
		  }
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x24),param2,
		                     Method_System_Collections_Generic_List_LanguageData__get_Item__);
		  if ((*(byte *)(iVar2 + 0x10) & 4) == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(*(int *)(param1 + 0x10) + 0xc)) {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(int *)(param1 + 0x10),0,
		                         Method_System_Collections_Generic_List_TermData__get_Item__);
		      func_ii_2010(param1_00,*(undefined4 *)(iVar2 + 8),0);
		      func_ii_2010(param1_00,StringLiteral_2361,0);
		      local_4 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + param2 * 4 + 0x10);
		      if ((((*(int *)(param1 + 0x1c) == 1) && (iVar3 = func_ii_4769(local_4,0), iVar3 != 0)) &&
		          (iVar3 = I2_Loc_LanguageSourceData__TryGetTranslation
		                             (param1,iVar2,&local_4,param2,0,1,param1_00), iVar3 != 0)) &&
		         (func_ii_2010(param1_00,StringLiteral_18954,0), param3 != 0)) {
		        *(undefined4 *)(*(int *)(iVar2 + 0x14) + param2 * 4 + 0x10) = local_4;
		      }
		      uVar1 = local_4;
		      iVar2 = func_ii_4769(local_4,0);
		      if (iVar2 == 0) {
		        func_ii_2010(param1_00,uVar1,0);
		      }
		      if (1 < *(int *)(*(int *)(param1 + 0x10) + 0xc)) {
		        iVar2 = 1;
		        do {
		          func_ii_2010(param1_00,StringLiteral_18959,0);
		          iVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x10),iVar2,
		                             Method_System_Collections_Generic_List_TermData__get_Item__);
		          func_ii_2010(param1_00,*(undefined4 *)(iVar3 + 8),0);
		          func_ii_2010(param1_00,StringLiteral_2361,0);
		          local_4 = *(undefined4 *)(*(int *)(iVar3 + 0x14) + param2 * 4 + 0x10);
		          if (((*(int *)(param1 + 0x1c) == 1) && (iVar4 = func_ii_4769(local_4,0), iVar4 != 0)) &&
		             ((iVar4 = I2_Loc_LanguageSourceData__TryGetTranslation
		                                 (param1,iVar3,&local_4,param2,0,1,param1_00), iVar4 != 0 &&
		              (func_ii_2010(param1_00,StringLiteral_18954,0), param3 != 0)))) {
		            *(undefined4 *)(*(int *)(iVar3 + 0x14) + param2 * 4 + 0x10) = local_4;
		          }
		          uVar1 = local_4;
		          iVar3 = func_ii_4769(local_4,0);
		          if (iVar3 == 0) {
		            func_ii_2010(param1_00,uVar1,0);
		          }
		          iVar2 = iVar2 + 1;
		        } while (iVar2 < *(int *)(*(int *)(param1 + 0x10) + 0xc));
		      }
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600760C RID: 30220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600760C")]
		[Address(RVA = "0xBF92", Offset = "0xBF92", VA = "0xBF92")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
		/* --- GHIDRA: Export_Language_to_Cache ---
		void I2_Loc_LanguageSourceData__Export_Language_to_Cache
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60489 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_774);
		    DAT_ram_00a60489 = '\x01';
		  }
		  iVar1 = func_ii_4769(param2,0);
		  if (iVar1 == 0) {
		    iVar1 = System_String__Substring(param2,StringLiteral_774,4,0);
		    if ((iVar1 != 0) ||
		       (iVar1 = System_String__Substring(param2,StringLiteral_2361,4,0), iVar1 != 0)) {
		      func_ii_3135(param1,0x27,0);
		    }
		    func_ii_2010(param1,param2,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600760D")]
		[Address(RVA = "0x35F9", Offset = "0x35F9", VA = "0x35F9")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true, bool sortRows = true)
		{
			return null;
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760E")]
		[Address(RVA = "0x35F1", Offset = "0x35F1", VA = "0x35F1")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		/* --- GHIDRA: AppendI2Term ---
		undefined4 I2_Loc_LanguageSourceData__AppendI2Term(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  int iVar2;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a54dfb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    DAT_ram_00a54dfb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  iVar1 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param1_01 = *(undefined4 *)(iVar1 + iVar2 * 4 + 0x10);
		      if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		      }
		      I2_Loc_SpecializationManager__GetSpecializations(param1_01,param1_00,0);
		      iVar2 = iVar2 + 1;
		      iVar1 = *(int *)(param1 + 0x14);
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760F")]
		[Address(RVA = "0xBF93", Offset = "0xBF93", VA = "0xBF93")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		/* --- GHIDRA: AppendI2Text ---
		/* WARNING: Removing unreachable block (ram,0x81c940ee) */
		
		undefined4
		I2_Loc_LanguageSourceData__AppendI2Text
		          (int param1,int param2,undefined4 param3,int param4,int param5,undefined4 param6)
		
		{
		  bool bVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param3_00;
		  undefined4 *puVar7;
		  undefined4 uVar8;
		  undefined1 auStack_50 [8];
		  int local_48;
		  undefined8 *local_44;
		  int local_40;
		  undefined8 *puStack_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6048a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_TermData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_LanguageData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_LanguageData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_LanguageData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__get_Current__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__Sort__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LanguageSourceData___c__Export_CSV_b__47_0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10253);
		    DAT_ram_00a6048a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  param3_00 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xc);
		  local_48 = CONCAT22(local_48._2_2_,(short)param3);
		  uVar2 = func_ii_1081(DAT_ram_00a66974,&local_48);
		  System_Net_DigestHeaderParser__get_QOP(param1_00,StringLiteral_10253,uVar2,0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_40,*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_List_LanguageData__GetEnumerator__);
		  local_8 = local_38;
		  local_40 = 0;
		  puStack_3c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_LanguageData__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c93a85;
		    }
		    if (iVar3 == 0) goto code_r0x81c93adb;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = local_8._4_4_;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x141,param1_00,param3,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c93a85;
		    }
		    if ((*(byte *)(iVar3 + 0x10) & 1) != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x141,param1_00,0x24,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81c93a85;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar3 + 0xc);
		    uVar8 = *(undefined4 *)(iVar3 + 8);
		    if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_GoogleLanguages_TypeInfo);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81c93a85;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s___Scripting__UnityEngine__Player_ram_000035bf + 0x2f,uVar8,uVar2,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c93a85;
		    }
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_LanguageSourceData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s___Scripting__UnityEngine__Player_ram_000035bf + 0x35,param1_00,uVar2,param3,
		               auStack_50);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c93a85:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_40 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81c93adb:
		      DAT_ram_009d3e38 = 0;
		      func_ii_2010(param1_00,StringLiteral_47,0);
		      if (param5 != 0) {
		        uVar2 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		        }
		        puVar7 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		        iVar6 = puVar7[6];
		        if (iVar6 == 0) {
		          if (*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LanguageSourceData___c_TypeInfo);
		            puVar7 = *(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c);
		          }
		          uVar8 = *puVar7;
		          iVar6 = unnamed_function_1417(System_Comparison_TermData__TypeInfo);
		          System_Collections_Generic_Comparer_object___get_Default
		                    (iVar6,uVar8,Method_I2_Loc_LanguageSourceData___c__Export_CSV_b__47_0__,0);
		          *(int *)(*(int *)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c) + 0x18) = iVar6;
		        }
		        Google_Protobuf_Collections_RepeatedField_uint___Contains
		                  (uVar2,iVar6,Method_System_Collections_Generic_List_TermData__Sort__);
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_40,*(undefined4 *)(param1 + 0x10),
		                 Method_System_Collections_Generic_List_TermData__GetEnumerator__);
		      local_18 = local_38;
		      local_20 = CONCAT44(puStack_3c,local_40);
		      local_48 = 0;
		      local_44 = &local_20;
		code_r0x81c93c0f:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_TermData__MoveNext__);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar6 = global_1;
		          goto code_r0x81c94242;
		        }
		        if (iVar3 == 0) goto code_r0x81c942de;
		        DAT_ram_009d3e38 = 0;
		        iVar3 = local_18._4_4_;
		        iVar5 = func_ii_4769(param2,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar6 = global_1;
		          goto code_r0x81c94242;
		        }
		        if (iVar5 == 0) {
		          if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       I2_Loc_LanguageSourceData_TypeInfo);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar6 = global_1;
		              goto code_r0x81c94242;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar5 = System_Collections_CollectionBase___ctor
		                            (param2,**(undefined4 **)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c),0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x81c94242;
		          }
		          if (iVar5 != 0) {
		            uVar2 = *(undefined4 *)(iVar3 + 8);
		            if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         I2_Loc_LanguageSourceData_TypeInfo);
		              iVar6 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar6 = global_1;
		                goto code_r0x81c94242;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iiii
		                              (s___Scripting__UnityEngine__Player_ram_000035bf + 0x31,uVar2,
		                               *(undefined4 *)
		                                (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar6 = global_1;
		              goto code_r0x81c94242;
		            }
		            if (iVar5 < 0) goto code_r0x81c93db5;
		          }
		          uVar8 = *(undefined4 *)(iVar3 + 8);
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iiii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,param2,
		                             StringLiteral_1618,0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x81c94242;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc6,uVar8,uVar2,4,0)
		          ;
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x81c94242;
		          }
		          if (iVar5 == 0) goto code_r0x81c93c0f;
		          DAT_ram_009d3e38 = 0;
		          iVar5 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                            (param2,*(undefined4 *)(iVar3 + 8),0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x81c94242;
		          }
		          if (iVar5 == 0) goto code_r0x81c93c0f;
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc5,
		                             *(undefined4 *)(iVar3 + 8),*(int *)(param2 + 8) + 1,0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x81c94242;
		          }
		        }
		        else {
		code_r0x81c93db5:
		          uVar8 = *(undefined4 *)(iVar3 + 8);
		        }
		        if (param4 != 0) {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iii
		                            (s___Scripting__UnityEngine__Player_ram_000035bf + 0x33,iVar3,0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x81c94242;
		          }
		          DAT_ram_009d3e38 = 0;
		          System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                    (&local_40,uVar2,Method_System_Collections_Generic_List_string__GetEnumerator__)
		          ;
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x81c94242;
		          }
		          local_28 = local_38;
		          local_30 = CONCAT44(puStack_3c,local_40);
		          local_40 = 0;
		          puStack_3c = &local_30;
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_30,
		                               Method_System_Collections_Generic_List_Enumerator_string__MoveNext__)
		            ;
		            if (DAT_ram_009d3e38 == 1) break;
		            if (iVar6 == 0) {
		              iVar6 = 0;
		              bVar1 = false;
		              goto code_r0x81c940c2;
		            }
		            uVar2 = local_28._4_4_;
		            if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         I2_Loc_LanguageSourceData_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiiiiii
		                      (s___Scripting__UnityEngine__Player_ram_000035bf + 0x37,param1_00,param3_00,
		                       uVar8,iVar3,uVar2,param3,auStack_50);
		          } while (DAT_ram_009d3e38 != 1);
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar6 = global_1;
		          iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar6 == iVar5) {
		            piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		            iVar6 = *piVar4;
		            DAT_ram_009d3e38 = 0;
		            local_40 = iVar6;
		            import::env::invoke_v(0x123);
		            iVar5 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            bVar1 = true;
		            if (iVar5 != 1) {
		code_r0x81c940c2:
		              if (iVar6 != 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar6);
		                iVar6 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar6 != 1) {
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar6 = global_1;
		                goto code_r0x81c94242;
		              }
		              if (bVar1) goto code_r0x81c94128;
		              goto code_r0x81c93c0f;
		            }
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x38,&local_40);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) goto code_r0x81c942d4;
		          goto code_r0x81c94242;
		        }
		code_r0x81c94128:
		        if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     I2_Loc_LanguageSourceData_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiiiiii
		                  (s___Scripting__UnityEngine__Player_ram_000035bf + 0x37,param1_00,param3_00,uVar8,
		                   iVar3,0,param3,auStack_50);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		code_r0x81c94242:
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar6) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_48 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x81c942de:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                            (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		          return uVar2;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x39,&local_48);
		      goto joined_r0x81c942d1;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x36,&local_40);
		joined_r0x81c942d1:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81c942d4:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007610")]
		[Address(RVA = "0xBF94", Offset = "0xBF94", VA = "0xBF94")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true, bool sortRows = true)
		{
		/* --- GHIDRA: Export_CSV ---
		void I2_Loc_LanguageSourceData__Export_CSV
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined2 local_2;
		  
		  local_2 = (undefined2)param3;
		  if (DAT_ram_00a6048d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_56);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19016);
		    Mono_Security_ASN1__get_Item(&StringLiteral_593);
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    Mono_Security_ASN1__get_Item(&StringLiteral_555);
		    DAT_ram_00a6048d = '\x01';
		  }
		  iVar1 = func_ii_4769(param2,0);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_7088(param2,StringLiteral_19016,StringLiteral_47,0);
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    uVar3 = System_Text_StringBuilder___ctor(&local_2,0);
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,StringLiteral_56,0);
		    uVar3 = I2_Loc_StringObfucator__XoREncode(uVar3,0);
		    iVar1 = func_ii_13807(uVar2,uVar3,0);
		    if (iVar1 < 0) {
		      func_ii_2010(param1,param4,0);
		      func_ii_2010(param1,uVar2,0);
		    }
		    else {
		      uVar2 = func_ii_7088(uVar2,StringLiteral_527,StringLiteral_555,0);
		      func_ii_8933(param1,StringLiteral_593,param4,uVar2,0);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007611")]
		[Address(RVA = "0x35F6", Offset = "0x35F6", VA = "0x35F6")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007612")]
		[Address(RVA = "0x35F4", Offset = "0x35F4", VA = "0x35F4")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		/* --- GHIDRA: AppendString ---
		int * I2_Loc_LanguageSourceData__AppendString(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007613 RID: 30227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007613")]
		[Address(RVA = "0xBF95", Offset = "0xBF95", VA = "0xBF95")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		/* --- GHIDRA: AppendTranslation ---
		undefined4
		I2_Loc_LanguageSourceData__AppendTranslation(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined1 auStack_10 [4];
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6048e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_WWWForm_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22513);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14262);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28120);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24954);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19683);
		    Mono_Security_ASN1__get_Item(&I2_Loc_eSpreadsheetUpdateMode_TypeInfo);
		    DAT_ram_00a6048e = '\x01';
		  }
		  uVar1 = I2_Loc_LanguageSourceData__Export_Google_CreateWWWcall(param1,auStack_10);
		  param1_00 = unnamed_function_1417(UnityEngine_WWWForm_TypeInfo);
		  UnityEngine_WWWForm__get_DefaultEncoding(param1_00,0);
		  func_ii_8959(param1_00,StringLiteral_24954,*(undefined4 *)(param1 + 0x34),0);
		  func_ii_8959(param1_00,StringLiteral_19683,StringLiteral_14262,0);
		  func_ii_8959(param1_00,StringLiteral_22513,uVar1,0);
		  local_8 = 0xffffffff;
		  local_c = I2_Loc_eSpreadsheetUpdateMode_TypeInfo;
		  local_4 = param2;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  func_ii_8959(param1_00,StringLiteral_28120,uVar1,0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar1 = I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(param1,auStack_10);
		  uVar1 = UnityEngine_Networking_UnityWebRequest__Put(uVar1,param1_00,0);
		  I2_Loc_I2Utils__GetCaptureMatch(uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007614")]
		[Address(RVA = "0xBF96", Offset = "0xBF96", VA = "0xBF96")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
		/* --- GHIDRA: Export_Google_CreateWWWcall ---
		undefined4
		I2_Loc_LanguageSourceData__Export_Google_CreateWWWcall(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6048f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2111);
		    DAT_ram_00a6048f = '\x01';
		  }
		  uVar2 = I2_Loc_LanguageSourceData__HasUnloadedLanguages(param1,1,0,&local_20);
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar2,Method_System_Collections_Generic_List_string__GetEnumerator__);
		  local_8 = local_18;
		  DAT_ram_009d3e38 = 0;
		  local_20 = 0;
		  puStack_1c = local_10;
		  iVar3 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                     Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    if (iVar3 == 0) goto code_r0x81c94c5c;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    uVar4 = import::env::invoke_iiiiiii
		                      (s___Scripting__UnityEngine__Player_ram_000035bf + 0x3a,param1,local_8._4_4_,
		                       0x2c,1,1,&local_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar2,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_iiii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,
		                   StringLiteral_2111,0);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            do {
		              DAT_ram_009d3e38 = 0;
		              iVar3 = import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                                 Method_System_Collections_Generic_List_Enumerator_string__MoveNext__
		                                );
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x81c94bbc;
		              }
		              if (iVar3 == 0) goto code_r0x81c94c5c;
		              DAT_ram_009d3e38 = 0;
		              uVar2 = local_8._4_4_;
		              import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,
		                         StringLiteral_2111,0);
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x81c94bbc;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iiiiiii
		                                (s___Scripting__UnityEngine__Player_ram_000035bf + 0x3a,param1,uVar2
		                                 ,0x2c,1,1,&local_20);
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x81c94bbc;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar2,0);
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x81c94bbc;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,
		                         StringLiteral_2111,0);
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x81c94bbc;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		            } while (iVar1 != 1);
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		    }
		  }
		code_r0x81c94bbc:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81c94c5c:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		      return uVar2;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x3b,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007615")]
		[Address(RVA = "0xBF97", Offset = "0xBF97", VA = "0xBF97")]
		private string Export_Google_CreateData()
		{
		/* --- GHIDRA: Export_Google_CreateData ---
		undefined4
		I2_Loc_LanguageSourceData__Export_Google_CreateData
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = I2_Loc_LocalizationReader__ReadCSVfile(param3,param5,param4);
		  uVar1 = I2_Loc_LocalizationReader__ReadI2CSV(param1,param2,uVar1,param4,param4);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007616")]
		[Address(RVA = "0xBF98", Offset = "0xBF98", VA = "0xBF98")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
		/* --- GHIDRA: Import_CSV ---
		undefined4
		I2_Loc_LanguageSourceData__Import_CSV
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = I2_Loc_LanguageSourceData__ClearAllData(param3,param4);
		  uVar1 = I2_Loc_LocalizationReader__ReadI2CSV(param1,param2,uVar1,param4,param4);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: Import_CSV ---
		undefined4
		I2_Loc_LanguageSourceData__Import_CSV
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = I2_Loc_LanguageSourceData__ClearAllData(param3,param4);
		  uVar1 = I2_Loc_LocalizationReader__ReadI2CSV(param1,param2,uVar1,param4,param4);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007617")]
		[Address(RVA = "0xBF99", Offset = "0xBF99", VA = "0xBF99")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
		/* --- GHIDRA: Import_I2CSV ---
		uint I2_Loc_LanguageSourceData__Import_I2CSV
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  
		  iVar3 = *(int *)(param3 + 0xc);
		  if (iVar3 < 1) {
		    return 0;
		  }
		  iVar1 = 0;
		  iVar2 = System_Xml_XmlTextEncoder__StartAttribute(param2,*(undefined4 *)(param3 + 0x10),5,0);
		  if (iVar2 < 0) {
		    do {
		      iVar1 = iVar1 + 1;
		      if (iVar3 == iVar1) break;
		      iVar2 = System_Xml_XmlTextEncoder__StartAttribute
		                        (param2,*(undefined4 *)(param3 + iVar1 * 4 + 0x10),5,0);
		    } while (iVar2 < 0);
		    uVar4 = (uint)(iVar1 < iVar3);
		  }
		  else {
		    uVar4 = 1;
		  }
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007618")]
		[Address(RVA = "0x3605", Offset = "0x3605", VA = "0x3605")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x6007619")]
		[Address(RVA = "0xBF9A", Offset = "0xBF9A", VA = "0xBF9A")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
		/* --- GHIDRA: ArrayContains ---
		undefined4 I2_Loc_LanguageSourceData__ArrayContains(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a60491 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_eTermType_TypeInfo);
		    DAT_ram_00a60491 = '\x01';
		  }
		  local_8 = 0xffffffff;
		  local_c = I2_Loc_eTermType_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		  if (iVar3 == 0) {
		    local_8 = 0x1ffffffff;
		    local_c = I2_Loc_eTermType_TypeInfo;
		    uVar1 = 1;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		    if (iVar3 == 0) {
		      local_8 = 0x2ffffffff;
		      local_c = I2_Loc_eTermType_TypeInfo;
		      uVar1 = 2;
		      uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		      iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		      if (iVar3 == 0) {
		        local_8 = 0x3ffffffff;
		        local_c = I2_Loc_eTermType_TypeInfo;
		        uVar1 = 3;
		        uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		        iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		        if (iVar3 == 0) {
		          local_8 = 0x4ffffffff;
		          local_c = I2_Loc_eTermType_TypeInfo;
		          uVar1 = 4;
		          uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		          iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		          if (iVar3 == 0) {
		            local_8 = 0x5ffffffff;
		            local_c = I2_Loc_eTermType_TypeInfo;
		            uVar1 = 5;
		            uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		            iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		            if (iVar3 == 0) {
		              local_8 = 0x6ffffffff;
		              local_c = I2_Loc_eTermType_TypeInfo;
		              uVar1 = 6;
		              uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		              iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		              if (iVar3 == 0) {
		                local_8 = 0x7ffffffff;
		                local_c = I2_Loc_eTermType_TypeInfo;
		                uVar1 = 7;
		                uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		                iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		                if (iVar3 == 0) {
		                  local_8 = 0x8ffffffff;
		                  local_c = I2_Loc_eTermType_TypeInfo;
		                  uVar1 = 8;
		                  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		                  iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		                  if (iVar3 == 0) {
		                    local_8 = 0x9ffffffff;
		                    local_c = I2_Loc_eTermType_TypeInfo;
		                    uVar1 = 9;
		                    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		                    iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		                    if (iVar3 == 0) {
		                      local_8 = 0xaffffffff;
		                      local_c = I2_Loc_eTermType_TypeInfo;
		                      uVar1 = 10;
		                      uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		                      iVar3 = Newtonsoft_Json_JsonSerializationException__Create(uVar2,param1,5,0);
		                      if (iVar3 == 0) {
		                        uVar1 = 0;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x600761A")]
		[Address(RVA = "0xBF9B", Offset = "0xBF9B", VA = "0xBF9B")]
		public static eTermType GetTermType(string type)
		{
		/* --- GHIDRA: GetTermType ---
		void I2_Loc_LanguageSourceData__GetTermType
		               (undefined4 param1,int param2,int param3,int param4,int param5,undefined4 param6)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a60492 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18954);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18959);
		    DAT_ram_00a60492 = '\x01';
		  }
		  if (0 < *(int *)(param3 + 8)) {
		    do {
		      iVar2 = func_ii_13789(param3,StringLiteral_18959,iVar1,4,0);
		      if (iVar2 < 0) {
		        iVar2 = *(int *)(param3 + 8);
		      }
		      iVar3 = func_ii_13789(param3,StringLiteral_2361,iVar1,4,0);
		      if (iVar2 <= iVar3) {
		        return;
		      }
		      param2_00 = System_Data_DataSet__ReadXmlSchema(param3,iVar1,iVar3 - iVar1,0);
		      iVar1 = func_ii_13851(param1,param2_00,0,iVar1);
		      if (iVar1 != 0) {
		        param1_00 = 0;
		        iVar3 = iVar3 + 1;
		        if (iVar2 != iVar3) {
		          iVar3 = System_Data_DataSet__ReadXmlSchema(param3,iVar3,iVar2 - iVar3,0);
		          iVar4 = System_String__Substring(iVar3,StringLiteral_18954,4,0);
		          param1_00 = iVar3;
		          if ((iVar4 != 0) && (param1_00 = 0, param4 != 0)) {
		            param1_00 = System_String__get_Chars(iVar3,6,0);
		          }
		          if ((param5 != 0) && (param1_00 != 0)) {
		            if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		            }
		            param1_00 = I2_Loc_SpecializationManager___ctor(param1_00,0,0);
		          }
		        }
		        *(int *)(*(int *)(iVar1 + 0x14) + param2 * 4 + 0x10) = param1_00;
		      }
		      iVar1 = iVar2 + 5;
		    } while (iVar1 < *(int *)(param3 + 8));
		  }
		  return;
		}
		*/

			return eTermType.Text;
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761B")]
		[Address(RVA = "0xBF9C", Offset = "0xBF9C", VA = "0xBF9C")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		/* --- GHIDRA: Import_Language_from_Cache ---
		void I2_Loc_LanguageSourceData__Import_Language_from_Cache(undefined4 param1)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int param2;
		  
		  param2 = 0;
		  if (DAT_ram_00a60493 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60493 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param1_00 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),0,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		  if (DAT_ram_00a604e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e6 = '\x01';
		  }
		  iVar4 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(iVar4);
		  iVar2 = I2_Loc_LanguageSourceData__Import_Google_Result
		                    (param1_00,**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),1,1,
		                     iVar4);
		  iVar4 = *(int *)(param1_00 + 0x10);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      iVar1 = 0;
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar4,param2,Method_System_Collections_Generic_List_TermData__get_Item__);
		      iVar4 = *(int *)(iVar3 + 0x14);
		      if (0 < *(int *)(iVar4 + 0xc)) {
		        do {
		          if (iVar1 != iVar2) {
		            *(undefined4 *)(iVar4 + iVar1 * 4 + 0x10) = 0;
		            iVar4 = *(int *)(iVar3 + 0x14);
		          }
		          iVar1 = iVar1 + 1;
		        } while (iVar1 < *(int *)(iVar4 + 0xc));
		      }
		      param2 = param2 + 1;
		      iVar4 = *(int *)(param1_00 + 0x10);
		    } while (param2 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761C")]
		[Address(RVA = "0xBF9D", Offset = "0xBF9D", VA = "0xBF9D")]
		public static void FreeUnusedLanguages()
		{
		/* --- GHIDRA: FreeUnusedLanguages ---
		void I2_Loc_LanguageSourceData__FreeUnusedLanguages(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  longlong local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a60494 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_StringObfucator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1564);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18953);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8922);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8921);
		    DAT_ram_00a60494 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x40) != 1) &&
		     (iVar1 = I2_Loc_LanguageSourceData__Import_CSV(0), iVar1 != 0)) {
		    uVar2 = func_ii_13821(param1,param1);
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_8922,uVar2,StringLiteral_1564,0);
		    iVar1 = I2_Loc_PersistentStorage__CanAccessFiles(1,uVar3,0,0);
		    iVar4 = func_ii_4769(iVar1,0);
		    if (iVar4 == 0) {
		      iVar4 = System_String__Substring(iVar1,StringLiteral_18953,4,0);
		      if (iVar4 != 0) {
		        uVar3 = System_Data_DataSet__ReadXmlSchema(iVar1,5,*(int *)(iVar1 + 8) + -5,0);
		        if (*(int *)(I2_Loc_StringObfucator_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_StringObfucator_TypeInfo);
		        }
		        iVar1 = I2_Loc_SetLanguageDropdown___ctor(uVar3,0);
		      }
		      uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_8921,uVar2,0);
		      iVar4 = I2_Loc_PersistentStorage__DeleteSetting(uVar3,0);
		      if (iVar4 != 0) {
		        uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_8921,uVar2,0);
		        iVar4 = Mycom_Tracker_Unity_Ads_AdFormat___cctor(uVar3,*(undefined4 *)(param1 + 0x3c),0);
		        uVar3 = *(undefined4 *)(param1 + 0x3c);
		        local_8 = 0;
		        local_10 = 0;
		        iVar5 = func_ii_4769(iVar4,0);
		        if ((iVar5 == 0) &&
		           ((((iVar5 = func_ii_4769(uVar3,0), iVar5 != 0 ||
		              (iVar5 = System_Collections_Specialized_NameValueCollection__get_Item
		                                 (iVar4,&local_10,0), iVar5 == 0)) ||
		             (iVar5 = System_Collections_Specialized_NameValueCollection__get_Item(uVar3,&local_8,0)
		             , iVar5 == 0)) || (local_8 < local_10)))) {
		          if (0x13 < *(int *)(iVar4 + 8)) {
		            iVar4 = **(int **)(DAT_ram_00a66978 + 0x5c);
		          }
		          *(int *)(param1 + 0x3c) = iVar4;
		          I2_Loc_LanguageSourceData__HasGoogleSpreadsheet(param1,iVar1,1,0,param1);
		          return;
		        }
		      }
		      uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_8922,uVar2,StringLiteral_1564,0);
		      I2_Loc_PersistentStorage__LoadFile(1,uVar3,0,0);
		      uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_8921,uVar2,0);
		      I2_Loc_PersistentStorage__GetSetting_String(uVar2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761D")]
		[Address(RVA = "0xBF9E", Offset = "0xBF9E", VA = "0xBF9E")]
		public void Import_Google_FromCache()
		{
		/* --- GHIDRA: Import_Google_FromCache ---
		uint I2_Loc_LanguageSourceData__Import_Google_FromCache
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  longlong local_10;
		  longlong local_8;
		  
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = 0;
		  iVar2 = func_ii_4769(param3,0);
		  if (iVar2 == 0) {
		    uVar1 = 1;
		    iVar2 = func_ii_4769(param2,0);
		    if (((iVar2 == 0) &&
		        (iVar2 = System_Collections_Specialized_NameValueCollection__get_Item(param3,&local_10,0),
		        uVar1 = 1, iVar2 != 0)) &&
		       (iVar2 = System_Collections_Specialized_NameValueCollection__get_Item(param2,&local_8,0),
		       iVar2 != 0)) {
		      uVar1 = (uint)(local_8 < local_10);
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600761E RID: 30238 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x600761E")]
		[Address(RVA = "0xBF9F", Offset = "0xBF9F", VA = "0xBF9F")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
		/* --- GHIDRA: IsNewerVersion ---
		void I2_Loc_LanguageSourceData__IsNewerVersion
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 *param2_00;
		  undefined4 uVar6;
		  undefined8 uVar7;
		  double dVar8;
		  undefined1 auStack_20 [8];
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60495 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10363);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60495 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if ((param2 == 0) && (*(int *)(param1 + 0x40) == 1)) {
		    return;
		  }
		  iVar1 = I2_Loc_LanguageSourceData__Import_CSV(0);
		  if (iVar1 == 0) {
		    return;
		  }
		  iVar1 = *(int *)(param1 + 0x40);
		  uVar2 = func_ii_13821(param1,auStack_20);
		  if ((param2 != 0) || (iVar1 == 0)) goto code_r0x81c9125e;
		  uVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_10363,uVar2,0);
		  uVar6 = Mycom_Tracker_Unity_Ads_AdFormat___cctor(uVar6,StringLiteral_5,0);
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_DateTime_TypeInfo);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) goto code_r0x81c90f6d;
		    uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x81c90f6d:
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s___Scripting__UnityEngine__Player_ram_000035bf + 0x2b,uVar6,&local_8,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (iVar3 == 0) goto code_r0x81c9125e;
		      if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_DateTime_TypeInfo)
		        ;
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c91118;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar7 = unnamed_function_184055(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32b,0);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar7 = unnamed_function_184066
		                          (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x3d3,uVar7,local_8,0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          local_10 = uVar7;
		          if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       System_TimeSpan_TypeInfo);
		            iVar4 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar4 == 1) {
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81c91118;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          dVar8 = System_DateTime__TryParse(&local_10,0);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) {
		            if (iVar1 == 2) {
		              if (dVar8 < 1.0) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		            }
		            else if (iVar1 == 3) {
		              if (dVar8 < 8.0) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		            }
		            else if (iVar1 == 4) {
		              if (dVar8 < 31.0) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		            }
		            else {
		              if (iVar1 == 5) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              if ((iVar1 == 6) && (dVar8 < 2.0)) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		            }
		            goto code_r0x81c9125e;
		          }
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		      }
		    }
		  }
		code_r0x81c91118:
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar4) {
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar6);
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar6,
		                         *(undefined4 *)*puVar5);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar4 != 0) {
		          import::env::__cxa_end_catch();
		code_r0x81c9125e:
		          uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_10363,uVar2,0);
		          if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_DateTime_TypeInfo);
		          }
		          local_18 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		          uVar6 = System_DateTime__ToLocalTime(&local_18,0);
		          I2_Loc_PersistentStorage__SaveFile(uVar2,uVar6,0);
		          if (DAT_ram_00a60497 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&I2_Loc_LanguageSourceData__Import_Google_Coroutine_d__65_TypeInfo);
		            DAT_ram_00a60497 = '\x01';
		          }
		          iVar1 = unnamed_function_1417
		                            (I2_Loc_LanguageSourceData__Import_Google_Coroutine_d__65_TypeInfo);
		          *(undefined1 *)(iVar1 + 0x15) = (undefined1)param3;
		          *(char *)(iVar1 + 0x14) = (char)param2;
		          *(int *)(iVar1 + 0x10) = param1;
		          *(undefined4 *)(iVar1 + 8) = 0;
		          I2_Loc_CoroutineManager__Awake(iVar1,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81c91306;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81c91306:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761F")]
		[Address(RVA = "0xBFA0", Offset = "0xBFA0", VA = "0xBFA0")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		/* --- GHIDRA: Import_Google ---
		int I2_Loc_LanguageSourceData__Import_Google
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60497 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData__Import_Google_Coroutine_d__65_TypeInfo)
		    ;
		    DAT_ram_00a60497 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_LanguageSourceData__Import_Google_Coroutine_d__65_TypeInfo);
		  *(undefined1 *)(iVar1 + 0x15) = (undefined1)param3;
		  *(undefined1 *)(iVar1 + 0x14) = (undefined1)param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007620")]
		[Address(RVA = "0x35FE", Offset = "0x35FE", VA = "0x35FE")]
		private string GetSourcePlayerPrefName()
		{
		/* --- GHIDRA: GetSourcePlayerPrefName ---
		undefined4 I2_Loc_LanguageSourceData__GetSourcePlayerPrefName(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param2_00;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_01;
		  
		  if (DAT_ram_00a54e2e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_StringObfucator_TypeInfo);
		    DAT_ram_00a54e2e = '\x01';
		  }
		  if (*(int *)(I2_Loc_StringObfucator_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               I2_Loc_StringObfucator_TypeInfo);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) goto code_r0x80b2406b;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x80b2406b:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x127,param1,param1);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (DAT_ram_00a54e30 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&System_Convert_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a54e30 = '\x01';
		          goto code_r0x80b240e2;
		        }
		      }
		      else {
		code_r0x80b240e2:
		        DAT_ram_009d3e38 = 0;
		        param2_00 = (int *)import::env::invoke_ii
		                                     (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x22c,0);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iiii
		                            (*(undefined4 *)(*param2_00 + 0x158),param2_00,uVar2,
		                             *(undefined4 *)(*param2_00 + 0x15c));
		          if (DAT_ram_009d3e38 != 1) {
		            if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         System_Convert_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80b241c4;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::invoke_iii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x187,uVar2,0);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              return uVar2;
		            }
		          }
		        }
		      }
		code_r0x80b241c4:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar3 != 0) {
		          import::env::__cxa_end_catch();
		          return 0;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80b242e9;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80b242e9:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007621")]
		[Address(RVA = "0xBFA1", Offset = "0xBFA1", VA = "0xBFA1")]
		private IEnumerator Import_Google_Coroutine(bool forceUpdate, bool JustCheck)
		{
		/* --- GHIDRA: Import_Google_Coroutine ---
		void I2_Loc_LanguageSourceData__Import_Google_Coroutine
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60498 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LanguageSourceData_ApplyDownloadedDataOnSceneLoaded__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		    DAT_ram_00a60498 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		  UnityEngine_Events_UnityAction_InputAction_CallbackContext___Invoke
		            (param1_00,param1,Method_I2_Loc_LanguageSourceData_ApplyDownloadedDataOnSceneLoaded__,0)
		  ;
		  if (*(int *)(UnityEngine_SceneManagement_SceneManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_SceneManagement_SceneManager_TypeInfo);
		  }
		  UnityEngine_SceneManagement_SceneManager__add_sceneLoaded(param1_00,0);
		  I2_Loc_LanguageSourceData__ApplyDownloadedDataOnSceneLoaded(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007622")]
		[Address(RVA = "0xBFA2", Offset = "0xBFA2", VA = "0xBFA2")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		/* --- GHIDRA: ApplyDownloadedDataOnSceneLoaded ---
		void I2_Loc_LanguageSourceData__ApplyDownloadedDataOnSceneLoaded(int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a60499 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6631);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6630);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60499 = '\x01';
		  }
		  iVar2 = func_ii_4769(*(undefined4 *)(param1 + 0x5c),0);
		  if (iVar2 == 0) {
		    param1_00 = I2_Loc_LanguageSourceData__HasGoogleSpreadsheet
		                          (param1,*(undefined4 *)(param1 + 0x5c),1,1,param1);
		    iVar2 = func_ii_4769(param1_00,0);
		    iVar3 = *(int *)(param1 + 0x50);
		    if (iVar2 == 0) {
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),param1,0,StringLiteral_5,
		                   *(undefined4 *)(iVar3 + 0x14));
		      }
		      puVar1 = &StringLiteral_6631;
		      iVar2 = *(int *)(OKG_Logs_Debug_TypeInfo + 0x74);
		    }
		    else {
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),param1,1,StringLiteral_5,
		                   *(undefined4 *)(iVar3 + 0x14));
		      }
		      iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      I2_Loc_LocalizationManager__GetAppName(1,iVar2);
		      puVar1 = &StringLiteral_6630;
		      iVar2 = *(int *)(OKG_Logs_Debug_TypeInfo + 0x74);
		    }
		    if (iVar2 == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(*puVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007623")]
		[Address(RVA = "0xBFA3", Offset = "0xBFA3", VA = "0xBFA3")]
		public void ApplyDownloadedDataFromGoogle()
		{
		/* --- GHIDRA: ApplyDownloadedDataFromGoogle ---
		undefined4
		I2_Loc_LanguageSourceData__ApplyDownloadedDataFromGoogle
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int param1_00;
		  int *piVar5;
		  longlong local_10;
		  longlong local_8;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a6049a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8921);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1739);
		    DAT_ram_00a6049a = '\x01';
		  }
		  iVar1 = I2_Loc_LanguageSourceData__Import_Google_CreateWWWcall(param1,param1);
		  if (iVar1 != 0) {
		    piVar4 = (int *)(param1 + 0x3c);
		    uVar2 = func_ii_13821(param1,param1);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_8921,uVar2,0);
		    iVar1 = Mycom_Tracker_Unity_Ads_AdFormat___cctor(uVar2,*(undefined4 *)(param1 + 0x3c),0);
		    if (0x13 < *(int *)(iVar1 + 8)) {
		      iVar1 = **(int **)(DAT_ram_00a66978 + 0x5c);
		    }
		    param1_00 = *piVar4;
		    local_8 = 0;
		    local_10 = 0;
		    iVar3 = func_ii_4769(param1_00,0);
		    if ((iVar3 == 0) &&
		       ((((iVar3 = func_ii_4769(iVar1,0), iVar3 != 0 ||
		          (iVar3 = System_Collections_Specialized_NameValueCollection__get_Item
		                             (param1_00,&local_10,0), iVar3 == 0)) ||
		         (iVar3 = System_Collections_Specialized_NameValueCollection__get_Item(iVar1,&local_8,0),
		         iVar3 == 0)) || (local_8 < local_10)))) {
		      *piVar4 = iVar1;
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    uVar2 = I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(param1,param1);
		    piVar5 = &StringLiteral_1739;
		    if (param2 == 0) {
		      piVar5 = piVar4;
		    }
		    uVar2 = func_ii_8529(StringLiteral_28717,uVar2,*(undefined4 *)(param1 + 0x34),*piVar5,0);
		    uVar2 = UnityEngine_Networking_UnityWebRequest__get_timeout(uVar2,0);
		    I2_Loc_I2Utils__GetCaptureMatch(uVar2,0);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007624")]
		[Address(RVA = "0xBFA4", Offset = "0xBFA4", VA = "0xBFA4")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
		/* --- GHIDRA: Import_Google_CreateWWWcall ---
		uint I2_Loc_LanguageSourceData__Import_Google_CreateWWWcall(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a6049b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6049b = '\x01';
		  }
		  iVar2 = func_ii_4769(*(undefined4 *)(param1 + 0x30),0);
		  if ((iVar2 == 0) && (iVar2 = func_ii_4769(*(undefined4 *)(param1 + 0x34),0), iVar2 == 0)) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    param1_00 = I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(param1,param1);
		    uVar1 = func_ii_4769(param1_00,0);
		    uVar1 = uVar1 ^ 1;
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x6007625")]
		[Address(RVA = "0xBFA5", Offset = "0xBFA5", VA = "0xBFA5")]
		public bool HasGoogleSpreadsheet()
		{
		/* --- GHIDRA: HasGoogleSpreadsheet ---
		undefined4
		I2_Loc_LanguageSourceData__HasGoogleSpreadsheet
		          (int param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  undefined4 *param2_00;
		  undefined4 uVar9;
		  int iVar10;
		  int *param1_00;
		  int iVar11;
		  longlong local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a6049c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_StringObfucator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18853);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1564);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9522);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18852);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26585);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18952);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10357);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18953);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28247);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8922);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8921);
		    Mono_Security_ASN1__get_Item(&StringLiteral_555);
		    DAT_ram_00a6049c = '\x01';
		  }
		  uVar9 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  DAT_ram_009d3e38 = 0;
		  iVar1 = func_ii_4769(param2,0);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    if (iVar1 != 0) {
		      DAT_ram_009d3e38 = 0;
		      return uVar9;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_555,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (iVar1 != 0) {
		        DAT_ram_009d3e38 = 0;
		        return uVar9;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iiiii
		                        (s___Scripting__UnityEngine__UIElem_ram_00003206 + 0x24,param2,
		                         StringLiteral_28247,4,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiiii
		                          (s___Scripting__UnityEngine__UIElem_ram_00003206 + 0x24,param2,
		                           StringLiteral_26585,4,0);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          if ((int)(uVar2 | uVar3) < 0) {
		            DAT_ram_009d3e38 = 0;
		            return StringLiteral_9522;
		          }
		          iVar10 = *(int *)(StringLiteral_26585 + 8);
		          DAT_ram_009d3e38 = 0;
		          iVar11 = *(int *)(StringLiteral_28247 + 8) + uVar2;
		          iVar1 = import::env::invoke_iiiiii
		                            (s___Scripting__UnityEngine__Player_ram_000035bf + 0x1f,param2,
		                             StringLiteral_1236,iVar11,4,0);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar1 = import::env::invoke_iiiii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xc1,param2,iVar11,
		                               iVar1 - iVar11,0);
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 1) {
		              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              DAT_ram_009d3e38 = 0;
		              iVar10 = uVar3 + iVar10;
		              iVar11 = import::env::invoke_iiiiii
		                                 (s___Scripting__UnityEngine__Player_ram_000035bf + 0x1f,param2,
		                                  StringLiteral_1236,iVar10,4,0);
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar8 == 1) {
		                uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iiiii
		                                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xc1,param2,
		                                   iVar10,iVar11 - iVar10,0);
		                iVar8 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar8 == 1) {
		                  uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		                else {
		                  DAT_ram_009d3e38 = 0;
		                  iVar10 = import::env::invoke_iii
		                                     (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2f6,uVar4,
		                                      0);
		                  iVar8 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar8 == 1) {
		                    uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  }
		                  else {
		                    if (0x13 < *(int *)(iVar1 + 8)) {
		                      iVar1 = **(int **)(DAT_ram_00a66978 + 0x5c);
		                    }
		                    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_vi
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                 I2_Loc_LocalizationManager_TypeInfo);
		                      if (DAT_ram_009d3e38 != 1) goto code_r0x81c96e82;
		code_r0x81c97587:
		                      DAT_ram_009d3e38 = 0;
		                      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    }
		                    else {
		code_r0x81c96e82:
		                      if (iVar10 != 5) {
		                        DAT_ram_009d3e38 = 0;
		                        return StringLiteral_15637;
		                      }
		                      if (param4 == 0) {
		code_r0x81c971ce:
		                        *(int *)(param1 + 0x3c) = iVar1;
		                        if (param3 == 1) {
		                          DAT_ram_009d3e38 = 0;
		                          import::env::invoke_vii
		                                    (s___Scripting__UnityEngine__Player_ram_000035bf + 0x44,param1,
		                                     uVar9);
		                          if (DAT_ram_009d3e38 == 1) goto code_r0x81c97587;
		                        }
		                        DAT_ram_009d3e38 = 0;
		                        iVar8 = import::env::invoke_iiiii
		                                          (s___Scripting__UnityEngine__UIElem_ram_00003206 + 0x24,
		                                           param2,StringLiteral_18952,4,0);
		                        iVar1 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar1 == 1) {
		                          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                        else {
		                          while (iVar1 = param3, 0 < iVar8) {
		                            DAT_ram_009d3e38 = 0;
		                            iVar8 = iVar8 + *(int *)(StringLiteral_18952 + 8);
		                            iVar11 = import::env::invoke_iiiiii
		                                               (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                                0x1f,param2,StringLiteral_18852,iVar8,4,0);
		                            iVar10 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar10 == 1) {
		                              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c9758f;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            uVar4 = import::env::invoke_iiiii
		                                              (s_struct_Uniforms___color__array<v_ram_000013c7 +
		                                               0xc1,param2,iVar8,iVar11 - iVar8,0);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c9758f;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            iVar11 = *(int *)(StringLiteral_18852 + 8) + iVar11;
		                            iVar10 = import::env::invoke_iiiiii
		                                               (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                                0x1f,param2,StringLiteral_18853,iVar11,4,0);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c9758f;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            uVar6 = import::env::invoke_iiiii
		                                              (s_struct_Uniforms___color__array<v_ram_000013c7 +
		                                               0xc1,param2,iVar11,iVar10 - iVar11,0);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c9758f;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            iVar8 = import::env::invoke_iiiiii
		                                              (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                               0x1f,param2,StringLiteral_18952,iVar10,4,0);
		                            iVar10 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar10 == 1) {
		                              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c9758f;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            uVar6 = import::env::invoke_iii
		                                              (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                               0x45,uVar6,uVar9);
		                            if (DAT_ram_009d3e38 == 1) {
		code_r0x81c9754b:
		                              DAT_ram_009d3e38 = 0;
		                              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c9758f;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_iiiiii
		                                      (s___Scripting__UnityEngine__Player_ram_000035bf + 0x46,param1
		                                       ,uVar4,uVar6,iVar1,uVar9);
		                            if (DAT_ram_009d3e38 == 1) goto code_r0x81c9754b;
		                            param3 = 2;
		                            if (iVar1 != 1) {
		                              param3 = iVar1;
		                            }
		                          }
		                          *(undefined1 *)(param1 + 0xe) = 1;
		                          DAT_ram_009d3e38 = 0;
		                          iVar1 = import::env::invoke_ii
		                                            (s___Scripting__UnityEngine__Player_ram_000035bf + 0x47,
		                                             0);
		                          iVar8 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar8 == 1) {
		                            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          }
		                          else {
		                            if (iVar1 != 0) {
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_viiii
		                                        (s___Scripting__UnityEngine__Player_ram_000035bf + 0x48,
		                                         param1,1,uVar9,uVar9);
		                              if (DAT_ram_009d3e38 == 1) goto code_r0x81c97587;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            func_ii_4769(uVar9,0);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 != 1) {
		                              DAT_ram_009d3e38 = 0;
		                              return uVar9;
		                            }
		                            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          }
		                        }
		                      }
		                      else {
		                        uVar4 = *(undefined4 *)(param1 + 0x3c);
		                        local_8 = 0;
		                        DAT_ram_009d3e38 = 0;
		                        local_10 = 0;
		                        iVar8 = func_ii_4769(iVar1,0);
		                        if (DAT_ram_009d3e38 != 1) {
		                          if (iVar8 != 0) {
		                            DAT_ram_009d3e38 = 0;
		                            return StringLiteral_10357;
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          iVar8 = func_ii_4769(uVar4,0);
		                          if (DAT_ram_009d3e38 != 1) {
		                            if (iVar8 == 0) {
		                              DAT_ram_009d3e38 = 0;
		                              iVar8 = import::env::invoke_iiii
		                                                (s_struct_VertexOutput____builtin_p_ram_00002c3d +
		                                                 0xab,iVar1,&local_10,0);
		                              if (DAT_ram_009d3e38 == 1) goto code_r0x81c97569;
		                              if (iVar8 != 0) {
		                                DAT_ram_009d3e38 = 0;
		                                iVar8 = import::env::invoke_iiii
		                                                  (s_struct_VertexOutput____builtin_p_ram_00002c3d +
		                                                   0xab,uVar4,&local_8,0);
		                                if (DAT_ram_009d3e38 == 1) goto code_r0x81c97569;
		                                if ((iVar8 != 0) && (local_10 <= local_8)) {
		                                  DAT_ram_009d3e38 = 0;
		                                  return StringLiteral_10357;
		                                }
		                              }
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            uVar4 = import::env::invoke_iii
		                                              (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                               0x3f,param1,uVar9);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            }
		                            else {
		                              DAT_ram_009d3e38 = 0;
		                              uVar6 = import::env::invoke_iiiii
		                                                (s_struct_Uniforms___color__vec4<f3_ram_00000856 +
		                                                 0x26e,StringLiteral_8922,uVar4,StringLiteral_1564,0
		                                                );
		                              iVar8 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar8 == 1) {
		                                uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              }
		                              else {
		                                if (*(int *)(I2_Loc_StringObfucator_TypeInfo + 0x74) == 0) {
		                                  DAT_ram_009d3e38 = 0;
		                                  import::env::invoke_vi
		                                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180
		                                             ,I2_Loc_StringObfucator_TypeInfo);
		                                  iVar8 = DAT_ram_009d3e38;
		                                  DAT_ram_009d3e38 = 0;
		                                  if (iVar8 == 1) {
		                                    uVar9 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                    goto code_r0x81c9758f;
		                                  }
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                uVar5 = import::env::invoke_iii
		                                                  (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                                   0x40,param2,0);
		                                iVar8 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar8 == 1) {
		                                  uVar9 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                }
		                                else {
		                                  DAT_ram_009d3e38 = 0;
		                                  uVar5 = import::env::invoke_iiii
		                                                    (s_var<private>_posTex__array<vec4<_ram_00000655
		                                                     + 0x1e4,StringLiteral_18953,uVar5,0);
		                                  iVar8 = DAT_ram_009d3e38;
		                                  DAT_ram_009d3e38 = 0;
		                                  if (iVar8 == 1) {
		                                    uVar9 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                  }
		                                  else {
		                                    DAT_ram_009d3e38 = 0;
		                                    import::env::invoke_iiiiii
		                                              (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                               0x41,1,uVar6,uVar5,1,0);
		                                    iVar8 = DAT_ram_009d3e38;
		                                    DAT_ram_009d3e38 = 0;
		                                    if (iVar8 == 1) {
		                                      uVar9 = import::env::__cxa_find_matching_catch_3
		                                                        (&DAT_ram_0072c9c8);
		                                    }
		                                    else {
		                                      DAT_ram_009d3e38 = 0;
		                                      uVar4 = import::env::invoke_iiii
		                                                        (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x1e4,StringLiteral_8921,uVar4,0);
		                                      iVar8 = DAT_ram_009d3e38;
		                                      DAT_ram_009d3e38 = 0;
		                                      if (iVar8 == 1) {
		                                        uVar9 = import::env::__cxa_find_matching_catch_3
		                                                          (&DAT_ram_0072c9c8);
		                                      }
		                                      else {
		                                        DAT_ram_009d3e38 = 0;
		                                        import::env::invoke_viii
		                                                  (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                                   0x42,uVar4,iVar1,0);
		                                        if (DAT_ram_009d3e38 != 1) {
		                                          DAT_ram_009d3e38 = 0;
		                                          import::env::invoke_vi
		                                                    (s___Scripting__UnityEngine__Player_ram_000035bf
		                                                     + 0x43,0);
		                                          if (DAT_ram_009d3e38 != 1) goto code_r0x81c971ce;
		                                        }
		                                        DAT_ram_009d3e38 = 0;
		                                        uVar9 = import::env::__cxa_find_matching_catch_3
		                                                          (&DAT_ram_0072c9c8);
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                            goto code_r0x81c9758f;
		                          }
		                        }
		code_r0x81c97569:
		                        DAT_ram_009d3e38 = 0;
		                        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		  }
		code_r0x81c9758f:
		  iVar8 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar1) {
		    puVar7 = (undefined4 *)import::env::__cxa_begin_catch(uVar9);
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar9,
		                         *(undefined4 *)*puVar7);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar1 != 0) {
		          param1_00 = (int *)*puVar7;
		          import::env::__cxa_end_catch();
		          iVar8 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar8 + 0x74) == 0) {
		            func_ii_306000(iVar8);
		          }
		          func_ii_7830(param1_00,0);
		          uVar9 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                            (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		          return uVar9;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar7;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81c976d5;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81c976d5:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar9);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007626")]
		[Address(RVA = "0xBFA6", Offset = "0xBFA6", VA = "0xBFA6")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
		/* --- GHIDRA: Import_Google_Result ---
		undefined4
		I2_Loc_LanguageSourceData__Import_Google_Result
		          (int param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a6049d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a6049d = '\x01';
		  }
		  iVar7 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		  if (0 < iVar7) {
		    iVar3 = 0;
		    if (param4 == 0) {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar3,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar2 = func_ii_3039(*(undefined4 *)(iVar2 + 8),param2,5,0);
		        if (iVar2 == 0) {
		          return iVar3;
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 != iVar7);
		    }
		    else {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar3,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        if ((*(byte *)(iVar2 + 0x10) & 1) == 0) {
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),iVar3,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar2 = func_ii_3039(*(undefined4 *)(iVar2 + 8),param2,5,0);
		          if (iVar2 == 0) {
		            return iVar3;
		          }
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 != iVar7);
		    }
		  }
		  if ((param3 != 0) && (iVar7 = *(int *)(*(int *)(param1 + 0x24) + 0xc), 0 < iVar7)) {
		    iVar3 = 0;
		    iVar2 = -1;
		    if (param4 == 0) {
		      iVar1 = 0;
		      do {
		        iVar5 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar1,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        uVar8 = *(undefined4 *)(iVar5 + 8);
		        if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		        }
		        iVar6 = I2_Loc_LanguageSourceData__GetLanguageIndexFromCode(uVar8,param2,iVar2);
		        iVar5 = iVar1;
		        if (iVar6 <= iVar3) {
		          iVar5 = iVar2;
		          iVar6 = iVar3;
		        }
		        iVar3 = iVar6;
		        iVar2 = iVar5;
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar7);
		    }
		    else {
		      iVar5 = 0;
		      iVar1 = iVar2;
		      do {
		        iVar4 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar5,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar2 = iVar1;
		        iVar6 = iVar3;
		        if ((*(byte *)(iVar4 + 0x10) & 1) == 0) {
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),iVar5,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          uVar8 = *(undefined4 *)(iVar2 + 8);
		          if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		          }
		          iVar6 = I2_Loc_LanguageSourceData__GetLanguageIndexFromCode(uVar8,param2,iVar1);
		          iVar2 = iVar5;
		          if (iVar6 <= iVar3) {
		            iVar2 = iVar1;
		            iVar6 = iVar3;
		          }
		        }
		        iVar5 = iVar5 + 1;
		        iVar1 = iVar2;
		        iVar3 = iVar6;
		      } while (iVar5 != iVar7);
		    }
		    if (-1 < iVar2) {
		      return iVar2;
		    }
		  }
		  return 0xffffffff;
		}
		*/

			return null;
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x6007627")]
		[Address(RVA = "0xBFA7", Offset = "0xBFA7", VA = "0xBFA7")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
		/* --- GHIDRA: GetLanguageIndex ---
		undefined4
		I2_Loc_LanguageSourceData__GetLanguageIndex
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6049e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a6049e = '\x01';
		  }
		  param2_00 = I2_Loc_LanguageSourceData__Import_Google_Result(param1,param2,param3,0,param1);
		  if (param2_00 < 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0x24),param2_00,
		                       Method_System_Collections_Generic_List_LanguageData__get_Item__);
		  }
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007628")]
		[Address(RVA = "0xBFA8", Offset = "0xBFA8", VA = "0xBFA8")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
		/* --- GHIDRA: GetLanguageData ---
		undefined4
		I2_Loc_LanguageSourceData__GetLanguageData(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6049f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6049f = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (DAT_ram_00a604e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e6 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(param2);
		  uVar2 = **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x24),param2,
		                     Method_System_Collections_Generic_List_LanguageData__get_Item__);
		  uVar2 = System_Collections_CollectionBase___ctor(uVar2,*(undefined4 *)(iVar1 + 8),0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x6007629")]
		[Address(RVA = "0xBFA9", Offset = "0xBFA9", VA = "0xBFA9")]
		public bool IsCurrentLanguage(int languageIndex)
		{
		/* --- GHIDRA: IsCurrentLanguage ---
		undefined4
		I2_Loc_LanguageSourceData__IsCurrentLanguage
		          (int param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a604a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a604a0 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		  if (0 < iVar2) {
		    if (param4 == 0) {
		      do {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar3,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar1 = func_ii_3039(*(undefined4 *)(iVar1 + 0xc),param2,5,0);
		        if (iVar1 == 0) {
		          return iVar3;
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 != iVar2);
		    }
		    else {
		      do {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar3,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        if ((*(byte *)(iVar1 + 0x10) & 1) == 0) {
		          iVar1 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),iVar3,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar1 = func_ii_3039(*(undefined4 *)(iVar1 + 0xc),param2,5,0);
		          if (iVar1 == 0) {
		            return iVar3;
		          }
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 != iVar2);
		    }
		  }
		  if ((param3 == 0) && (iVar3 = *(int *)(*(int *)(param1 + 0x24) + 0xc), 0 < iVar3)) {
		    iVar2 = 0;
		    if (param4 == 0) {
		      do {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar2,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar1 = func_ii_3029(*(undefined4 *)(iVar1 + 0xc),0,param2,0,2,5,0);
		        if (iVar1 == 0) {
		          return iVar2;
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar3);
		    }
		    else {
		      do {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),iVar2,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        if ((*(byte *)(iVar1 + 0x10) & 1) == 0) {
		          iVar1 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),iVar2,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar1 = func_ii_3029(*(undefined4 *)(iVar1 + 0xc),0,param2,0,2,5,0);
		          if (iVar1 == 0) {
		            return iVar2;
		          }
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar3);
		    }
		  }
		  return 0xffffffff;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x600762A")]
		[Address(RVA = "0xBFAA", Offset = "0xBFAA", VA = "0xBFAA")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
		/* --- GHIDRA: GetLanguageIndexFromCode ---
		int I2_Loc_LanguageSourceData__GetLanguageIndexFromCode
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param1_00;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  
		  iVar7 = 0;
		  iVar1 = 0;
		  if (DAT_ram_00a604a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1073);
		    DAT_ram_00a604a1 = '\x01';
		  }
		  iVar2 = func_ii_4769(param1,0);
		  if ((iVar2 == 0) && (iVar2 = func_ii_4769(param2,0), iVar2 == 0)) {
		    uVar3 = I2_Loc_StringObfucator__XoREncode(StringLiteral_1073,0);
		    uVar4 = func_ii_7775(param1,0);
		    iVar2 = Facebook_Unity_FBLocation__FromDictionary(uVar4,uVar3,0);
		    uVar4 = func_ii_7775(param2,0);
		    param1_00 = Facebook_Unity_FBLocation__FromDictionary(uVar4,uVar3,0);
		    iVar1 = 0;
		    if (0 < *(int *)(iVar2 + 0xc)) {
		      iVar6 = 0;
		      do {
		        uVar3 = *(undefined4 *)(iVar2 + iVar6 * 4 + 0x10);
		        iVar5 = func_ii_4769(uVar3,0);
		        if (iVar5 == 0) {
		          iVar5 = System_Uri__get_Scheme
		                            (param1_00,uVar3,Method_System_Linq_Enumerable_Contains_string___);
		          iVar1 = iVar5 + iVar1;
		        }
		        iVar6 = iVar6 + 1;
		      } while (iVar6 < *(int *)(iVar2 + 0xc));
		    }
		    if (0 < *(int *)(param1_00 + 0xc)) {
		      do {
		        uVar3 = *(undefined4 *)(param1_00 + iVar7 * 4 + 0x10);
		        iVar6 = func_ii_4769(uVar3,0);
		        if (iVar6 == 0) {
		          iVar6 = System_Uri__get_Scheme
		                            (iVar2,uVar3,Method_System_Linq_Enumerable_Contains_string___);
		          iVar1 = iVar6 + iVar1;
		        }
		        iVar7 = iVar7 + 1;
		      } while (iVar7 < *(int *)(param1_00 + 0xc));
		    }
		  }
		  return iVar1;
		}
		*/

			return 0;
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x600762B")]
		[Address(RVA = "0xBFAB", Offset = "0xBFAB", VA = "0xBFAB")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
		/* --- GHIDRA: GetCommonWordInLanguageNames ---
		uint I2_Loc_LanguageSourceData__GetCommonWordInLanguageNames
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a604a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    DAT_ram_00a604a2 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		  }
		  if (DAT_ram_00a604a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1085);
		    DAT_ram_00a604a3 = '\x01';
		  }
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_1085,0);
		  iVar2 = func_ii_13807(param1,uVar1,0);
		  if (-1 < iVar2) {
		    uVar1 = System_Data_DataSet__ReadXmlSchema(param1,0,iVar2,0);
		    param1 = System_Convert__FromBase64String(uVar1,0);
		  }
		  if (DAT_ram_00a604a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1085);
		    DAT_ram_00a604a3 = '\x01';
		  }
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_1085,0);
		  iVar2 = func_ii_13807(param2,uVar1,0);
		  if (-1 < iVar2) {
		    uVar1 = System_Data_DataSet__ReadXmlSchema(param2,0,iVar2,0);
		    param2 = System_Convert__FromBase64String(uVar1,0);
		  }
		  iVar2 = func_ii_3039(param1,param2,5,0);
		  return (uint)(iVar2 == 0);
		}
		*/

			return 0;
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x600762C")]
		[Address(RVA = "0xBFAC", Offset = "0xBFAC", VA = "0xBFAC")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
		/* --- GHIDRA: AreTheSameLanguage ---
		undefined4 I2_Loc_LanguageSourceData__AreTheSameLanguage(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param3;
		  
		  if (DAT_ram_00a604a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1085);
		    DAT_ram_00a604a3 = '\x01';
		  }
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_1085,0);
		  param3 = func_ii_13807(param1,uVar1,0);
		  if (-1 < param3) {
		    uVar1 = System_Data_DataSet__ReadXmlSchema(param1,0,param3,0);
		    param1 = System_Convert__FromBase64String(uVar1,0);
		  }
		  return param1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600762D")]
		[Address(RVA = "0xBFAD", Offset = "0xBFAD", VA = "0xBFAD")]
		public static string GetLanguageWithoutRegion(string Language)
		{
		/* --- GHIDRA: GetLanguageWithoutRegion ---
		void I2_Loc_LanguageSourceData__GetLanguageWithoutRegion
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a604a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    DAT_ram_00a604a4 = '\x01';
		  }
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  param3_00 = I2_Loc_EventCallback___ctor(param2,0,0);
		  I2_Loc_LanguageSourceData__AddLanguage(param1,param2,param3_00,param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762E")]
		[Address(RVA = "0xBFAE", Offset = "0xBFAE", VA = "0xBFAE")]
		public void AddLanguage(string LanguageName)
		{
		/* --- GHIDRA: AddLanguage ---
		void I2_Loc_LanguageSourceData__AddLanguage(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int param2_01;
		  int iVar5;
		  int param2_02;
		  int iVar6;
		  int iVar7;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a604a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_byte___);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    DAT_ram_00a604a6 = '\x01';
		  }
		  if (DAT_ram_00a6049d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a6049d = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		  if (0 < iVar4) {
		    do {
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x24),param2_01,
		                         Method_System_Collections_Generic_List_LanguageData__get_Item__);
		      iVar3 = func_ii_3039(*(undefined4 *)(iVar3 + 8),param2,5,0);
		      if (iVar3 == 0) {
		        iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		        if (0 < iVar4) {
		          iVar5 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		          param2_02 = iVar5 + -1;
		          param2_00 = 0;
		          iVar7 = param2_01 + 1;
		          iVar3 = iVar7;
		          iVar2 = param2_01;
		          if (iVar7 < iVar5) {
		            do {
		              do {
		                iVar1 = iVar3;
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                iVar6 = *(int *)(iVar3 + 0x14);
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                *(undefined4 *)(iVar6 + iVar2 * 4 + 0x10) =
		                     *(undefined4 *)(*(int *)(iVar3 + 0x14) + iVar1 * 4 + 0x10);
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                iVar6 = *(int *)(iVar3 + 0x18);
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                *(undefined1 *)(iVar6 + iVar2 + 0x10) =
		                     *(undefined1 *)(*(int *)(iVar3 + 0x18) + iVar1 + 0x10);
		                iVar3 = iVar1 + 1;
		                iVar2 = iVar1;
		              } while (iVar1 + 1 != iVar5);
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x14,param2_02,Method_System_Array_Resize_string___);
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x18,param2_02,Method_System_Array_Resize_byte___);
		              param2_00 = param2_00 + 1;
		              iVar3 = iVar7;
		              iVar2 = param2_01;
		            } while (param2_00 != iVar4);
		          }
		          else {
		            do {
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x14,param2_02,Method_System_Array_Resize_string___);
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x18,param2_02,Method_System_Array_Resize_byte___);
		              param2_00 = param2_00 + 1;
		            } while (param2_00 != iVar4);
		          }
		        }
		        UnityEngine_TextCore_Glyph__set_atlasIndex
		                  (*(undefined4 *)(param1 + 0x24),param2_01,
		                   Method_System_Collections_Generic_List_LanguageData__RemoveAt__);
		        return;
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar4);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: AddLanguage ---
		void I2_Loc_LanguageSourceData__AddLanguage(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int param2_01;
		  int iVar5;
		  int param2_02;
		  int iVar6;
		  int iVar7;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a604a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_byte___);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    DAT_ram_00a604a6 = '\x01';
		  }
		  if (DAT_ram_00a6049d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a6049d = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		  if (0 < iVar4) {
		    do {
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x24),param2_01,
		                         Method_System_Collections_Generic_List_LanguageData__get_Item__);
		      iVar3 = func_ii_3039(*(undefined4 *)(iVar3 + 8),param2,5,0);
		      if (iVar3 == 0) {
		        iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		        if (0 < iVar4) {
		          iVar5 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		          param2_02 = iVar5 + -1;
		          param2_00 = 0;
		          iVar7 = param2_01 + 1;
		          iVar3 = iVar7;
		          iVar2 = param2_01;
		          if (iVar7 < iVar5) {
		            do {
		              do {
		                iVar1 = iVar3;
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                iVar6 = *(int *)(iVar3 + 0x14);
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                *(undefined4 *)(iVar6 + iVar2 * 4 + 0x10) =
		                     *(undefined4 *)(*(int *)(iVar3 + 0x14) + iVar1 * 4 + 0x10);
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                iVar6 = *(int *)(iVar3 + 0x18);
		                iVar3 = System_Linq_Enumerable__ToList_object_
		                                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                                   Method_System_Collections_Generic_List_TermData__get_Item__);
		                *(undefined1 *)(iVar6 + iVar2 + 0x10) =
		                     *(undefined1 *)(*(int *)(iVar3 + 0x18) + iVar1 + 0x10);
		                iVar3 = iVar1 + 1;
		                iVar2 = iVar1;
		              } while (iVar1 + 1 != iVar5);
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x14,param2_02,Method_System_Array_Resize_string___);
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x18,param2_02,Method_System_Array_Resize_byte___);
		              param2_00 = param2_00 + 1;
		              iVar3 = iVar7;
		              iVar2 = param2_01;
		            } while (param2_00 != iVar4);
		          }
		          else {
		            do {
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x14,param2_02,Method_System_Array_Resize_string___);
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x10),param2_00,
		                                 Method_System_Collections_Generic_List_TermData__get_Item__);
		              BestHTTP_SocketIO_Packet__EncodeBinary
		                        (iVar3 + 0x18,param2_02,Method_System_Array_Resize_byte___);
		              param2_00 = param2_00 + 1;
		            } while (param2_00 != iVar4);
		          }
		        }
		        UnityEngine_TextCore_Glyph__set_atlasIndex
		                  (*(undefined4 *)(param1 + 0x24),param2_01,
		                   Method_System_Collections_Generic_List_LanguageData__RemoveAt__);
		        return;
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762F")]
		[Address(RVA = "0xBFAF", Offset = "0xBFAF", VA = "0xBFAF")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007630")]
		[Address(RVA = "0xBFB0", Offset = "0xBFB0", VA = "0xBFB0")]
		public void RemoveLanguage(string LanguageName)
		{
		/* --- GHIDRA: RemoveLanguage ---
		int I2_Loc_LanguageSourceData__RemoveLanguage(int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a604a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a604a7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  iVar3 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		  if (0 < iVar3) {
		    if (param2 == 0) {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2_00,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar1 = Method_System_Collections_Generic_List_string__Add__;
		        uVar4 = *(undefined4 *)(iVar2 + 8);
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 != iVar3);
		    }
		    else {
		      do {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2_00,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        if ((*(byte *)(iVar1 + 0x10) & 1) == 0) {
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),param2_00,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar1 = Method_System_Collections_Generic_List_string__Add__;
		          uVar4 = *(undefined4 *)(iVar2 + 8);
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar5 = *(uint *)(param1_00 + 0xc);
		          if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		            *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,uVar4,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          }
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 != iVar3);
		    }
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007631")]
		[Address(RVA = "0xBFB1", Offset = "0xBFB1", VA = "0xBFB1")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
		/* --- GHIDRA: GetLanguages ---
		int I2_Loc_LanguageSourceData__GetLanguages(int param1,int param2,int param3,undefined4 param4)
		
		{
		  int param1_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a604a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a604a8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  iVar4 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		  if (0 < iVar4) {
		    do {
		      if ((param3 == 0) ||
		         (iVar1 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),param2_00,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__),
		         (*(byte *)(iVar1 + 0x10) & 1) == 0)) {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2_00,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar1 = *(int *)(iVar1 + 0xc);
		        if ((param2 == 0) && ((iVar1 != 0 && (2 < *(int *)(iVar1 + 8))))) {
		          iVar1 = System_Data_DataSet__ReadXmlSchema(iVar1,0,2,0);
		        }
		        iVar2 = func_ii_4769(iVar1,0);
		        if ((iVar2 == 0) &&
		           (iVar3 = func_ii_4685(param1_00,iVar1,
		                                 Method_System_Collections_Generic_List_string__Contains__),
		           iVar2 = Method_System_Collections_Generic_List_string__Add__, iVar3 == 0)) {
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar5 = *(uint *)(param1_00 + 0xc);
		          if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		            *(int *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = iVar1;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,iVar1,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar4);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007632")]
		[Address(RVA = "0xBFB2", Offset = "0xBFB2", VA = "0xBFB2")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
		/* --- GHIDRA: GetLanguagesCode ---
		uint I2_Loc_LanguageSourceData__GetLanguagesCode(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a604a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a604a9 = '\x01';
		  }
		  iVar1 = I2_Loc_LanguageSourceData__Import_Google_Result(param1,param2,0,1,param1);
		  if (iVar1 < 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0x24),iVar1,
		                       Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    uVar2 = (uint)((*(byte *)(iVar1 + 0x10) & 1) == 0);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00015648 File Offset: 0x00013848
		[Token(Token = "0x6007633")]
		[Address(RVA = "0xBFB3", Offset = "0xBFB3", VA = "0xBFB3")]
		public bool IsLanguageEnabled(string Language)
		{
		/* --- GHIDRA: IsLanguageEnabled ---
		void I2_Loc_LanguageSourceData__IsLanguageEnabled
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a604aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a604aa = '\x01';
		  }
		  if (DAT_ram_00a6049d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a6049d = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		  if (0 < iVar2) {
		    param2_00 = 0;
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x24),param2_00,
		                         Method_System_Collections_Generic_List_LanguageData__get_Item__);
		      iVar1 = func_ii_3039(*(undefined4 *)(iVar1 + 8),param2,5,0);
		      if (iVar1 == 0) {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2_00,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        *(byte *)(iVar2 + 0x10) = *(byte *)(iVar2 + 0x10) & 0xfe | (byte)param3 ^ 1;
		        return;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007634")]
		[Address(RVA = "0xBFB4", Offset = "0xBFB4", VA = "0xBFB4")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00015660 File Offset: 0x00013860
		[Token(Token = "0x6007635")]
		[Address(RVA = "0xBFB5", Offset = "0xBFB5", VA = "0xBFB5")]
		public bool AllowUnloadingLanguages()
		{
		/* --- GHIDRA: AllowUnloadingLanguages ---
		undefined4
		I2_Loc_LanguageSourceData__AllowUnloadingLanguages(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a604ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1564);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10352);
		    DAT_ram_00a604ab = '\x01';
		  }
		  if (param2 < 0) {
		    uVar2 = 0;
		  }
		  else {
		    param2_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		    *(undefined4 *)(param2_00 + 0x10) = StringLiteral_10352;
		    uVar2 = func_ii_13821(param1,param2_00);
		    *(undefined4 *)(param2_00 + 0x14) = uVar2;
		    *(undefined4 *)(param2_00 + 0x18) = StringLiteral_19176;
		    iVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0x24),param2,
		                       Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    *(undefined4 *)(param2_00 + 0x1c) = *(undefined4 *)(iVar1 + 8);
		    *(undefined4 *)(param2_00 + 0x20) = StringLiteral_1564;
		    uVar2 = System_Single__ToString(param2_00,0);
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007636")]
		[Address(RVA = "0xBFB6", Offset = "0xBFB6", VA = "0xBFB6")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
		/* --- GHIDRA: GetSavedLanguageFileName ---
		void I2_Loc_LanguageSourceData__GetSavedLanguageFileName
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5,int param6,
		               undefined4 param7)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a604ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a604ac = '\x01';
		  }
		  if ((*(int *)(param1 + 0x2c) != 0) &&
		     (iVar1 = I2_Loc_PersistentStorage__HasSetting(0), iVar1 != 0)) {
		    if ((-1 < param2) &&
		       ((param6 != 0 ||
		        (iVar1 = System_Linq_Enumerable__ToList_object_
		                           (*(undefined4 *)(param1 + 0x24),param2,
		                            Method_System_Collections_Generic_List_LanguageData__get_Item__),
		        (*(byte *)(iVar1 + 0x10) & 4) != 0)))) {
		      uVar2 = I2_Loc_LanguageSourceData__AllowUnloadingLanguages(param1,param2,param3);
		      uVar2 = I2_Loc_PersistentStorage__CanAccessFiles(2,uVar2,0,0);
		      iVar1 = func_ii_4769(uVar2,0);
		      if (iVar1 == 0) {
		        I2_Loc_LanguageSourceData__GetTermType(param1,param2,uVar2,param4,param5,param3);
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        *(byte *)(iVar1 + 0x10) = *(byte *)(iVar1 + 0x10) & 0xfb;
		      }
		    }
		    if (param3 != 0) {
		      iVar1 = 0;
		      iVar3 = I2_Loc_LanguageSourceData__Import_CSV(0);
		      if ((iVar3 != 0) && (iVar3 = *(int *)(param1 + 0x24), 0 < *(int *)(iVar3 + 0xc))) {
		        do {
		          if (param2 != iVar1) {
		            I2_Loc_LanguageSourceData__LoadAllLanguages(param1,iVar1,iVar1);
		            iVar3 = *(int *)(param1 + 0x24);
		          }
		          iVar1 = iVar1 + 1;
		        } while (iVar1 < *(int *)(iVar3 + 0xc));
		      }
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007637")]
		[Address(RVA = "0xBFB7", Offset = "0xBFB7", VA = "0xBFB7")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		/* --- GHIDRA: LoadLanguage ---
		void I2_Loc_LanguageSourceData__LoadLanguage(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a604ad == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    DAT_ram_00a604ad = '\x01';
		  }
		  if (0 < *(int *)(*(int *)(param1 + 0x24) + 0xc)) {
		    do {
		      I2_Loc_LanguageSourceData__GetSavedLanguageFileName(param1,param2_00,0,0,0,param2,param2_00);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(*(int *)(param1 + 0x24) + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007638")]
		[Address(RVA = "0xBFB8", Offset = "0xBFB8", VA = "0xBFB8")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		/* --- GHIDRA: LoadAllLanguages ---
		void I2_Loc_LanguageSourceData__LoadAllLanguages(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined1 auStack_20 [8];
		  undefined4 local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a604ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a604ae = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if ((((*(int *)(param1 + 0x2c) != 0) &&
		       (iVar1 = I2_Loc_PersistentStorage__HasSetting(0), iVar1 != 0)) &&
		      (iVar1 = I2_Loc_LanguageSourceData__Import_CSV(0), iVar1 != 0)) &&
		     (((iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__),
		       (*(byte *)(iVar1 + 0x10) & 4) == 0 &&
		       (iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x24),param2,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__),
		       (*(byte *)(iVar1 + 0x10) & 2) == 0)) &&
		      (iVar1 = I2_Loc_LanguageSourceData__GetLanguageData(param1,param2,auStack_20), iVar1 == 0))))
		  {
		    uVar2 = I2_Loc_LanguageSourceData__AllowUnloadingLanguages(param1,param2,auStack_20);
		    iVar1 = I2_Loc_PersistentStorage__DeleteFile(2,uVar2,1,0);
		    if (iVar1 != 0) {
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_10,*(undefined4 *)(param1 + 0x10),
		                 Method_System_Collections_Generic_List_TermData__GetEnumerator__);
		      local_18 = 0;
		      local_14 = &local_10;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_TermData__MoveNext__);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) break;
		        if (iVar3 == 0) goto code_r0x81c96621;
		        *(undefined4 *)(*(int *)(local_8._4_4_ + 0x14) + param2 * 4 + 0x10) = 0;
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		        local_18 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x81c96621:
		          DAT_ram_009d3e38 = 0;
		          I2_Loc_TermData__GetAllSpecializations(&local_18);
		          iVar1 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),param2,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          *(byte *)(iVar1 + 0x10) = *(byte *)(iVar1 + 0x10) | 4;
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x3e,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007639")]
		[Address(RVA = "0xBFB9", Offset = "0xBFB9", VA = "0xBFB9")]
		public void UnloadLanguage(int languageIndex)
		{
		/* --- GHIDRA: UnloadLanguage ---
		undefined4 I2_Loc_LanguageSourceData__UnloadLanguage(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  uint uVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a604b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    DAT_ram_00a604b0 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x24);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,param2_00,
		                         Method_System_Collections_Generic_List_LanguageData__get_Item__);
		      uVar2 = (*(byte *)(iVar1 + 0x10) & 4) >> 2;
		      if (uVar2 != 0) {
		        return uVar2;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x24);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		    return 0;
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763A")]
		[Address(RVA = "0x3607", Offset = "0x3607", VA = "0x3607")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x600763B")]
		[Address(RVA = "0xBFBA", Offset = "0xBFBA", VA = "0xBFBA")]
		public bool HasUnloadedLanguages()
		{
		/* --- GHIDRA: HasUnloadedLanguages ---
		int I2_Loc_LanguageSourceData__HasUnloadedLanguages
		              (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint uVar5;
		  int iVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a604b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TermData__get_Current__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Sort__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a604b1 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (param3 == 0) {
		    param3 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param3,Method_System_Collections_Generic_List_string___ctor__);
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_List_TermData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_TermData__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c94f19;
		    }
		    if (iVar1 == 0) break;
		    uVar3 = *(undefined4 *)(local_8._4_4_ + 8);
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_LanguageSourceData_TypeInfo);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81c94f19;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s___Scripting__UnityEngine__Player_ram_000035bf + 0x3c,uVar3,param2,param3);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c94f19;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ca,param3,uVar3,
		                       Method_System_Collections_Generic_List_string__Contains__);
		    iVar1 = DAT_ram_009d3e38;
		    iVar6 = Method_System_Collections_Generic_List_string__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81c94f19;
		    }
		    if (iVar2 == 0) {
		      *(int *)(param3 + 0x10) = *(int *)(param3 + 0x10) + 1;
		      uVar5 = *(uint *)(param3 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(param3 + 8) + 0xc)) {
		        *(uint *)(param3 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(param3 + 8) + uVar5 * 4 + 0x10) = uVar3;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param3,uVar3,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c94f19:
		          iVar6 = global_1;
		          iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar6 == iVar1) {
		            piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		            iVar6 = *piVar4;
		            iVar1 = 0;
		            DAT_ram_009d3e38 = 0;
		            local_18 = iVar6;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		code_r0x81c94f66:
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 == 0) {
		                if ((iVar1 == 0) ||
		                   ((((iVar1 != 1 && (iVar1 != 2)) && (iVar1 != 3)) &&
		                    ((iVar1 != 4 && (iVar1 == 5)))))) {
		                  func_ii_15909(param3,Method_System_Collections_Generic_List_string__Sort__);
		                }
		                return param3;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x3d,&local_18);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) {
		            import::env::__resumeException(uVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		  }
		  iVar1 = 5;
		  iVar6 = local_18;
		  goto code_r0x81c94f66;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600763C")]
		[Address(RVA = "0xBFBB", Offset = "0xBFBB", VA = "0xBFBB")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
		/* --- GHIDRA: GetCategories ---
		undefined4 I2_Loc_LanguageSourceData__GetCategories(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a604b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    DAT_ram_00a604b2 = '\x01';
		  }
		  if (param2 == 0) {
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    iVar1 = System_String__LastIndexOf
		                      (param1,*(undefined4 *)
		                               (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		  }
		  else {
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    iVar1 = func_ii_13807(param1,*(undefined4 *)
		                                  (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		  }
		  if (-1 < iVar1) {
		    param1 = System_String__get_Chars(param1,iVar1 + 1,0);
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600763D")]
		[Address(RVA = "0xBFBC", Offset = "0xBFBC", VA = "0xBFBC")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
		/* --- GHIDRA: GetKeyFromFullTerm ---
		void I2_Loc_LanguageSourceData__GetKeyFromFullTerm
		               (undefined4 param1,undefined4 *param2,undefined4 *param3,int param4,undefined4 param5
		               )
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a604b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    DAT_ram_00a604b4 = '\x01';
		  }
		  if (param4 == 0) {
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    param3_00 = System_String__LastIndexOf
		                          (param1,*(undefined4 *)
		                                   (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		  }
		  else {
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    param3_00 = func_ii_13807(param1,*(undefined4 *)
		                                      (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		  }
		  if (param3_00 < 0) {
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    *param3 = **(undefined4 **)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c);
		    *param2 = param1;
		    return;
		  }
		  uVar1 = System_Data_DataSet__ReadXmlSchema(param1,0,param3_00,0);
		  *param3 = uVar1;
		  uVar1 = System_String__get_Chars(param1,param3_00 + 1,0);
		  *param2 = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600763E")]
		[Address(RVA = "0x35FB", Offset = "0x35FB", VA = "0x35FB")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763F")]
		[Address(RVA = "0xBFBD", Offset = "0xBFBD", VA = "0xBFBD")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		/* --- GHIDRA: DeserializeFullTerm ---
		void I2_Loc_LanguageSourceData__DeserializeFullTerm(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a604b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__get_Comparer__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__TermData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a604b5 = '\x01';
		  }
		  if (((param2 != 0) || (*(int *)(param1 + 0x18) == 0)) ||
		     (iVar5 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                        (*(int *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Dictionary_string__TermData__get_Count__)
		     , iVar5 != *(int *)(*(int *)(param1 + 0x10) + 0xc))) {
		    if (*(char *)(param1 + 0x14) == '\0') {
		      if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_StringComparer_TypeInfo);
		      }
		      if (DAT_ram_00a6628f == '\0') {
		        Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		        DAT_ram_00a6628f = '\x01';
		      }
		      if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_StringComparer_TypeInfo);
		      }
		      piVar4 = (int *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		    }
		    else {
		      if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_StringComparer_TypeInfo);
		      }
		      if (DAT_ram_00a66702 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		        DAT_ram_00a66702 = '\x01';
		      }
		      if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_StringComparer_TypeInfo);
		      }
		      piVar4 = (int *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 0xc);
		    }
		    iVar5 = *piVar4;
		    iVar1 = System_Collections_Generic_Dictionary_object__int___System_Collections_IEnumerable_GetEnumerator
		                      (*(undefined4 *)(param1 + 0x18),
		                       Method_System_Collections_Generic_Dictionary_string__TermData__get_Comparer__
		                      );
		    if (iVar5 == iVar1) {
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 0x18),
		                 Method_System_Collections_Generic_Dictionary_string__TermData__Clear__);
		    }
		    else {
		      uVar3 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_string__TermData__TypeInfo);
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		                (uVar3,iVar5,Method_System_Collections_Generic_Dictionary_string__TermData___ctor__)
		      ;
		      *(undefined4 *)(param1 + 0x18) = uVar3;
		    }
		    iVar1 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		    if (0 < iVar1) {
		      iVar5 = 0;
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x10),iVar5,
		                           Method_System_Collections_Generic_List_TermData__get_Item__);
		        if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		        }
		        I2_Loc_LanguageSourceData__RemoveTerm((undefined4 *)(iVar2 + 8),iVar5);
		        param1_00 = *(undefined4 *)(param1 + 0x18);
		        param2_00 = *(undefined4 *)(iVar2 + 8);
		        uVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x10),iVar5,
		                           Method_System_Collections_Generic_List_TermData__get_Item__);
		        func_ii_2946(param1_00,param2_00,uVar3,
		                     Method_System_Collections_Generic_Dictionary_string__TermData__set_Item__);
		        uVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x10),iVar5,
		                           Method_System_Collections_Generic_List_TermData__get_Item__);
		        I2_Loc_TermData__IsAutoTranslated(uVar3,0);
		        iVar5 = iVar5 + 1;
		      } while (iVar5 != iVar1);
		    }
		    iVar1 = I2_Loc_LanguageSourceData__Import_CSV(0);
		    if (iVar1 != 0) {
		      I2_Loc_I2Utils__IsPlaying(param1,1,iVar5,iVar5);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007640")]
		[Address(RVA = "0xBFBE", Offset = "0xBFBE", VA = "0xBFBE")]
		public void UpdateDictionary(bool force = false)
		{
		/* --- GHIDRA: UpdateDictionary ---
		undefined4
		I2_Loc_LanguageSourceData__UpdateDictionary
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6,undefined4 param7)
		
		{
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = 0;
		  I2_Loc_LanguageSourceData__GetTranslation
		            (param1,param2,&local_4,param3,param4,param5,param6,auStack_10);
		  return local_4;
		}
		*/

		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007641")]
		[Address(RVA = "0xBFBF", Offset = "0xBFBF", VA = "0xBFBF")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
		/* --- GHIDRA: GetTranslation ---
		undefined4
		I2_Loc_LanguageSourceData__GetTranslation
		          (int param1,undefined4 param2,undefined4 *param3,int param4,undefined4 param5,int param6,
		          undefined4 param7,undefined4 param8)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a604b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_Localize_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1354);
		    Mono_Security_ASN1__get_Item(&StringLiteral_774);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19128);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2055);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11143);
		    DAT_ram_00a604b6 = '\x01';
		  }
		  if (param4 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (DAT_ram_00a604e6 == '\0') {
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a604e6 = '\x01';
		    }
		    iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizeDropdown___ctor(iVar1);
		    param4 = **(int **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  }
		  iVar1 = I2_Loc_LanguageSourceData__Import_Google_Result(param1,param4,1,0,param4);
		  if ((-1 < iVar1) &&
		     ((param6 == 0 ||
		      (iVar2 = System_Linq_Enumerable__ToList_object_
		                         (*(undefined4 *)(param1 + 0x24),iVar1,
		                          Method_System_Collections_Generic_List_LanguageData__get_Item__),
		      (*(byte *)(iVar2 + 0x10) & 1) == 0)))) {
		    iVar2 = func_ii_13851(param1,param2,param7,iVar1);
		    if (iVar2 != 0) {
		      uVar3 = I2_Loc_LocalizeTarget_UnityUI_Text___ctor(iVar2,iVar1,param5,1,0);
		      *param3 = uVar3;
		      iVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_1354,0);
		      if (iVar4 != 0) {
		        *param3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		        return 1;
		      }
		      iVar4 = func_ii_4769(*param3,0);
		      if (iVar4 == 0) {
		        return 1;
		      }
		      *param3 = 0;
		    }
		    iVar4 = *(int *)(param1 + 0x1c);
		    if (iVar4 == 2) {
		      uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_2055,param2,StringLiteral_19128,0);
		      *param3 = uVar3;
		      uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_11143,param2,StringLiteral_774,0);
		      param2_00 = *(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 0x10);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      OKG_Logs_Debug__GetContent(uVar3,param2_00,0);
		      return 0;
		    }
		    if ((iVar2 != 0) && (iVar4 == 1)) {
		      uVar3 = I2_Loc_LanguageSourceData__TryGetTranslation
		                        (param1,iVar2,param3,iVar1,param5,param6,iVar1);
		      return uVar3;
		    }
		    if (iVar4 == 0) {
		      *param3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		      return 0;
		    }
		    if (((iVar4 != 1) && (iVar4 != 2)) && (iVar4 == 3)) {
		      *param3 = param2;
		      return 0;
		    }
		  }
		  *param3 = 0;
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x6007642")]
		[Address(RVA = "0xBFC0", Offset = "0xBFC0", VA = "0xBFC0")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
		/* --- GHIDRA: TryGetTranslation ---
		undefined4
		I2_Loc_LanguageSourceData__TryGetTranslation
		          (int param1,undefined4 param2,undefined4 *param3,int param4,undefined4 param5,int param6,
		          undefined4 param7)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a604b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    DAT_ram_00a604b7 = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x24),param4,
		                     Method_System_Collections_Generic_List_LanguageData__get_Item__);
		  iVar1 = *(int *)(iVar1 + 0xc);
		  iVar2 = func_ii_4769(iVar1,0);
		  if (iVar2 == 0) {
		    iVar2 = func_ii_7903(iVar1,StringLiteral_1331,0);
		    if (iVar2 != 0) {
		      uVar3 = System_Xml_Schema_XmlSchemaException___ctor(iVar1,0x2d,0);
		      iVar1 = System_Data_DataSet__ReadXmlSchema(iVar1,0,uVar3,0);
		    }
		    iVar2 = *(int *)(param1 + 0x24);
		    if (*(int *)(iVar2 + 0xc) < 1) goto code_r0x81c928b1;
		    param2_00 = 0;
		    if (param6 == 0) {
		      do {
		        if (param4 != param2_00) {
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (iVar2,param2_00,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar2 = System_String__Substring(*(undefined4 *)(iVar2 + 0xc),iVar1,4,0);
		          if (iVar2 != 0) {
		            uVar3 = I2_Loc_LocalizeTarget_UnityUI_Text___ctor(param2,param2_00,param5,1,0);
		            *param3 = uVar3;
		            iVar2 = func_ii_4769(uVar3,0);
		            if (iVar2 == 0) {
		              return 1;
		            }
		          }
		        }
		        param2_00 = param2_00 + 1;
		        iVar2 = *(int *)(param1 + 0x24);
		        iVar4 = *(int *)(iVar2 + 0xc);
		      } while (param2_00 < iVar4);
		    }
		    else {
		      do {
		        if (param4 != param2_00) {
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (iVar2,param2_00,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar2 = System_String__Substring(*(undefined4 *)(iVar2 + 0xc),iVar1,4,0);
		          if ((iVar2 != 0) &&
		             (iVar2 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x24),param2_00,
		                                 Method_System_Collections_Generic_List_LanguageData__get_Item__),
		             (*(byte *)(iVar2 + 0x10) & 1) == 0)) {
		            uVar3 = I2_Loc_LocalizeTarget_UnityUI_Text___ctor(param2,param2_00,param5,1,0);
		            *param3 = uVar3;
		            iVar2 = func_ii_4769(uVar3,0);
		            if (iVar2 == 0) {
		              return 1;
		            }
		          }
		        }
		        param2_00 = param2_00 + 1;
		        iVar2 = *(int *)(param1 + 0x24);
		        iVar4 = *(int *)(iVar2 + 0xc);
		      } while (param2_00 < iVar4);
		    }
		  }
		  else {
		    iVar2 = *(int *)(param1 + 0x24);
		    iVar4 = *(int *)(iVar2 + 0xc);
		  }
		  if (0 < iVar4) {
		    if (iVar1 == 0) {
		      iVar1 = 0;
		      if (param6 == 0) {
		        do {
		          if (param4 != iVar1) {
		            uVar3 = I2_Loc_LocalizeTarget_UnityUI_Text___ctor(param2,iVar1,param5,1,0);
		            *param3 = uVar3;
		            iVar2 = func_ii_4769(uVar3,0);
		            if (iVar2 == 0) {
		              return 1;
		            }
		            iVar2 = *(int *)(param1 + 0x24);
		          }
		          iVar1 = iVar1 + 1;
		        } while (iVar1 < *(int *)(iVar2 + 0xc));
		      }
		      else {
		        do {
		          if ((param4 != iVar1) &&
		             (iVar2 = System_Linq_Enumerable__ToList_object_
		                                (iVar2,iVar1,
		                                 Method_System_Collections_Generic_List_LanguageData__get_Item__),
		             (*(byte *)(iVar2 + 0x10) & 1) == 0)) {
		            uVar3 = I2_Loc_LocalizeTarget_UnityUI_Text___ctor(param2,iVar1,param5,1,0);
		            *param3 = uVar3;
		            iVar2 = func_ii_4769(uVar3,0);
		            if (iVar2 == 0) {
		              return 1;
		            }
		          }
		          iVar1 = iVar1 + 1;
		          iVar2 = *(int *)(param1 + 0x24);
		        } while (iVar1 < *(int *)(iVar2 + 0xc));
		      }
		    }
		    else {
		      iVar4 = 0;
		      do {
		        if (param4 != iVar4) {
		          if (param6 != 0) {
		            iVar2 = System_Linq_Enumerable__ToList_object_
		                              (iVar2,iVar4,
		                               Method_System_Collections_Generic_List_LanguageData__get_Item__);
		            if ((*(byte *)(iVar2 + 0x10) & 1) != 0) goto code_r0x81c927ed;
		            iVar2 = *(int *)(param1 + 0x24);
		          }
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (iVar2,iVar4,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar2 = System_String__Substring(*(undefined4 *)(iVar2 + 0xc),iVar1,4,0);
		          if (iVar2 == 0) {
		            uVar3 = I2_Loc_LocalizeTarget_UnityUI_Text___ctor(param2,iVar4,param5,1,0);
		            *param3 = uVar3;
		            iVar2 = func_ii_4769(uVar3,0);
		            if (iVar2 == 0) {
		              return 1;
		            }
		          }
		        }
		code_r0x81c927ed:
		        iVar4 = iVar4 + 1;
		        iVar2 = *(int *)(param1 + 0x24);
		      } while (iVar4 < *(int *)(iVar2 + 0xc));
		    }
		  }
		code_r0x81c928b1:
		  *param3 = 0;
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x6007643")]
		[Address(RVA = "0xBFC1", Offset = "0xBFC1", VA = "0xBFC1")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
		/* --- GHIDRA: TryGetFallbackTranslation ---
		uint I2_Loc_LanguageSourceData__TryGetFallbackTranslation
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_13851(param1,param2,0,param2);
		  return (uint)(iVar1 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007644")]
		[Address(RVA = "0x361D", Offset = "0x361D", VA = "0x361D")]
		public TermData AddTerm(string term)
		{
		/* --- GHIDRA: AddTerm ---
		void I2_Loc_LanguageSourceData__AddTerm(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a604bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    DAT_ram_00a604bb = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x10),param2_00,
		                         Method_System_Collections_Generic_List_TermData__get_Item__);
		      iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar1 + 8),param2,0);
		      if (iVar1 != 0) {
		        UnityEngine_TextCore_Glyph__set_atlasIndex
		                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                   Method_System_Collections_Generic_List_TermData__RemoveAt__);
		        System_Linq_Enumerable__First_KeyValuePair_object__object__
		                  (*(undefined4 *)(param1 + 0x18),param2,
		                   Method_System_Collections_Generic_Dictionary_string__TermData__Remove__);
		        return;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: AddTerm ---
		void I2_Loc_LanguageSourceData__AddTerm(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a604bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    DAT_ram_00a604bb = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x10),param2_00,
		                         Method_System_Collections_Generic_List_TermData__get_Item__);
		      iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar1 + 8),param2,0);
		      if (iVar1 != 0) {
		        UnityEngine_TextCore_Glyph__set_atlasIndex
		                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                   Method_System_Collections_Generic_List_TermData__RemoveAt__);
		        System_Linq_Enumerable__First_KeyValuePair_object__object__
		                  (*(undefined4 *)(param1 + 0x18),param2,
		                   Method_System_Collections_Generic_Dictionary_string__TermData__Remove__);
		        return;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007645")]
		[Address(RVA = "0x361C", Offset = "0x361C", VA = "0x361C")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
		/* --- GHIDRA: GetTermData ---
		undefined4
		I2_Loc_LanguageSourceData__GetTermData(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = I2_Loc_LanguageSourceData__GetTermsList(param1,param2,0,0,param2);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x6007646")]
		[Address(RVA = "0xBFC2", Offset = "0xBFC2", VA = "0xBFC2")]
		public bool ContainsTerm(string term)
		{
		/* --- GHIDRA: ContainsTerm ---
		int I2_Loc_LanguageSourceData__ContainsTerm(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a604b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__get_Keys__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a604b9 = '\x01';
		  }
		  iVar2 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 0x18),
		                     Method_System_Collections_Generic_Dictionary_string__TermData__get_Count__);
		  if (iVar2 != *(int *)(*(int *)(param1 + 0x10) + 0xc)) {
		    I2_Loc_LanguageSourceData__DeserializeFullTerm(param1,0,0);
		  }
		  iVar2 = func_ii_4769(param2,0);
		  if (iVar2 != 0) {
		    uVar4 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                      (*(undefined4 *)(param1 + 0x18),
		                       Method_System_Collections_Generic_Dictionary_string__TermData__get_Keys__);
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		    Sirenix_Utilities_LinqExtensions__Convert_object_
		              (param1_00,uVar4,Method_System_Collections_Generic_List_string___ctor__);
		    return param1_00;
		  }
		  param1_01 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,Method_System_Collections_Generic_List_string___ctor__);
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (iVar2,param2_00,Method_System_Collections_Generic_List_TermData__get_Item__
		                        );
		      uVar4 = *(undefined4 *)(iVar2 + 8);
		      if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		      }
		      uVar4 = func_ii_13818(uVar4,0,param2_00);
		      iVar3 = System_Collections_CollectionBase___ctor(uVar4,param2,0);
		      iVar1 = Method_System_Collections_Generic_List_string__Add__;
		      if (iVar3 != 0) {
		        uVar4 = *(undefined4 *)(iVar2 + 8);
		        *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_01 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		          *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		          *(undefined4 *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = uVar4;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_01,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x10);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return param1_01;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007647")]
		[Address(RVA = "0xBFC3", Offset = "0xBFC3", VA = "0xBFC3")]
		public List<string> GetTermsList([Optional] string Category)
		{
		/* --- GHIDRA: GetTermsList ---
		int I2_Loc_LanguageSourceData__GetTermsList
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  uint uVar3;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a604ba == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__Add__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_TermData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22882);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7316);
		    DAT_ram_00a604ba = '\x01';
		  }
		  if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		  }
		  I2_Loc_LanguageSourceData__RemoveTerm(&local_4,auStack_10);
		  param2_00 = System_Convert__FromBase64String(local_4,0);
		  if (*(int *)(*(int *)(param1 + 0x24) + 0xc) == 0) {
		    I2_Loc_LanguageSourceData__AddLanguage(param1,StringLiteral_7316,StringLiteral_22882,auStack_10)
		    ;
		  }
		  param1_00 = func_ii_13851(param1,param2_00,0,auStack_10);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(I2_Loc_TermData_TypeInfo);
		    I2_Loc_TermData__HasSpecializations(param1_00,0);
		    *(undefined4 *)(param1_00 + 0xc) = param3;
		    *(undefined4 *)(param1_00 + 8) = param2_00;
		    uVar2 = Mono_Security_ASN1Convert__ToOid
		                      (string___TypeInfo,*(undefined4 *)(*(int *)(param1 + 0x24) + 0xc));
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = Mono_Security_ASN1Convert__ToOid
		                      (byte___TypeInfo,*(undefined4 *)(*(int *)(param1 + 0x24) + 0xc));
		    *(undefined4 *)(param1_00 + 0x18) = uVar2;
		    iVar1 = Method_System_Collections_Generic_List_TermData__Add__;
		    param1_01 = *(int *)(param1 + 0x10);
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_01 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		      *(int *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = param1_00;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_01,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                );
		    }
		    System_Reflection_FieldInfo__get_IsStatic
		              (*(undefined4 *)(param1 + 0x18),param2_00,param1_00,
		               Method_System_Collections_Generic_Dictionary_string__TermData__Add__);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007648")]
		[Address(RVA = "0xBFC4", Offset = "0xBFC4", VA = "0xBFC4")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007649")]
		[Address(RVA = "0xBFC5", Offset = "0xBFC5", VA = "0xBFC5")]
		public void RemoveTerm(string term)
		{
		/* --- GHIDRA: RemoveTerm ---
		void I2_Loc_LanguageSourceData__RemoveTerm(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a604bc == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    DAT_ram_00a604bc = '\x01';
		  }
		  iVar1 = LunarConsolePlugin_CVarList__Find(*param1,0x5c,0x2f,0);
		  *param1 = iVar1;
		  iVar1 = System_Convert__FromBase64String(iVar1,0);
		  *param1 = iVar1;
		  if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		  }
		  iVar1 = System_String__Substring
		                    (iVar1,**(undefined4 **)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c),4,0);
		  if (iVar1 != 0) {
		    iVar1 = *(int *)(*param1 + 8);
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    param2_00 = *(int *)(**(int **)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 8);
		    if (param2_00 < iVar1) {
		      iVar1 = *param1;
		      if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		        param2_00 = *(int *)(**(int **)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 8);
		      }
		      iVar1 = func_ii_3010(iVar1,param2_00,0);
		      if (iVar1 == 0x2f) {
		        iVar1 = *param1;
		        if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		        }
		        iVar1 = System_String__get_Chars
		                          (iVar1,*(int *)(**(int **)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 8)
		                                 + 1,0);
		        *param1 = iVar1;
		      }
		    }
		  }
		  iVar1 = I2_Loc_I2Utils__ReverseText(*param1,1,0);
		  *param1 = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600764A")]
		[Address(RVA = "0xBFC6", Offset = "0xBFC6", VA = "0xBFC6")]
		public static void ValidateFullTerm(ref string Term)
		{
		/* --- GHIDRA: ValidateFullTerm ---
		void I2_Loc_LanguageSourceData__ValidateFullTerm(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a604bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__Object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__TermData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TermData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LanguageData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a604bd = '\x01';
		  }
		  *(undefined1 *)(param1 + 0xe) = 1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TermData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TermData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__TermData__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (uVar1,uVar2,Method_System_Collections_Generic_Dictionary_string__TermData___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = 1;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_LanguageData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_LanguageData___ctor__);
		  *(undefined4 *)(param1 + 0x48) = 1;
		  *(undefined8 *)(param1 + 0x40) = 0x200000003;
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Object__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Object___ctor__);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__Object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (uVar1,uVar2,Method_System_Collections_Generic_Dictionary_string__Object___ctor__);
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600764B")]
		[Address(RVA = "0xBFC7", Offset = "0xBFC7", VA = "0xBFC7")]
		public LanguageSourceData()
		{
		/* --- GHIDRA: .cctor ---
		void I2_Loc_LanguageSourceData___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a604bf == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData___c_TypeInfo);
		    DAT_ram_00a604bf = '\x01';
		  }
		  uVar1 = unnamed_function_1417(I2_Loc_LanguageSourceData___c_TypeInfo);
		  **(undefined4 **)(I2_Loc_LanguageSourceData___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void I2_Loc_LanguageSourceData___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a604be == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6424);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1687);
		    DAT_ram_00a604be = '\x01';
		  }
		  **(undefined4 **)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) = StringLiteral_6424;
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_1687,0);
		  *(undefined4 *)(*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003DB7 RID: 15799
		[Token(Token = "0x4003DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[NonSerialized]
		public ILanguageSource owner;

		// Token: 0x04003DB8 RID: 15800
		[Token(Token = "0x4003DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool UserAgreesToHaveItOnTheScene;

		// Token: 0x04003DB9 RID: 15801
		[Token(Token = "0x4003DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		// Token: 0x04003DBA RID: 15802
		[Token(Token = "0x4003DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool GoogleLiveSyncIsUptoDate;

		// Token: 0x04003DBB RID: 15803
		[Token(Token = "0x4003DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		[NonSerialized]
		public bool mIsGlobalSource;

		// Token: 0x04003DBC RID: 15804
		[Token(Token = "0x4003DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<TermData> mTerms;

		// Token: 0x04003DBD RID: 15805
		[Token(Token = "0x4003DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool CaseInsensitiveTerms;

		// Token: 0x04003DBE RID: 15806
		[Token(Token = "0x4003DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Dictionary<string, TermData> mDictionary;

		// Token: 0x04003DBF RID: 15807
		[Token(Token = "0x4003DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		// Token: 0x04003DC0 RID: 15808
		[Token(Token = "0x4003DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTerm_AppName;

		// Token: 0x04003DC1 RID: 15809
		[Token(Token = "0x4003DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public List<LanguageData> mLanguages;

		// Token: 0x04003DC2 RID: 15810
		[Token(Token = "0x4003DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IgnoreDeviceLanguage;

		// Token: 0x04003DC3 RID: 15811
		[Token(Token = "0x4003DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		// Token: 0x04003DC4 RID: 15812
		[Token(Token = "0x4003DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		// Token: 0x04003DC5 RID: 15813
		[Token(Token = "0x4003DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public string Google_SpreadsheetKey;

		// Token: 0x04003DC6 RID: 15814
		[Token(Token = "0x4003DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetName;

		// Token: 0x04003DC7 RID: 15815
		[Token(Token = "0x4003DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public string Google_LastUpdatedVersion;

		// Token: 0x04003DC8 RID: 15816
		[Token(Token = "0x4003DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		// Token: 0x04003DC9 RID: 15817
		[Token(Token = "0x4003DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		// Token: 0x04003DCA RID: 15818
		[Token(Token = "0x4003DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LanguageSourceData.eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		// Token: 0x04003DCB RID: 15819
		[Token(Token = "0x4003DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float GoogleUpdateDelay;

		// Token: 0x04003DCD RID: 15821
		[Token(Token = "0x4003DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public List<UnityEngine.Object> Assets;

		// Token: 0x04003DCE RID: 15822
		[Token(Token = "0x4003DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		// Token: 0x04003DCF RID: 15823
		[Token(Token = "0x4003DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private string mDelayedGoogleData;

		// Token: 0x04003DD0 RID: 15824
		[Token(Token = "0x4003DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		// Token: 0x04003DD1 RID: 15825
		[Token(Token = "0x4003DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static char[] CategorySeparators;

		// Token: 0x0200136F RID: 4975
		[Token(Token = "0x200136F")]
		public enum MissingTranslationAction
		{
			// Token: 0x04003DD3 RID: 15827
			[Token(Token = "0x4003DD3")]
			Empty,
			// Token: 0x04003DD4 RID: 15828
			[Token(Token = "0x4003DD4")]
			Fallback,
			// Token: 0x04003DD5 RID: 15829
			[Token(Token = "0x4003DD5")]
			ShowWarning,
			// Token: 0x04003DD6 RID: 15830
			[Token(Token = "0x4003DD6")]
			ShowTerm
		}

		// Token: 0x02001370 RID: 4976
		[Token(Token = "0x2001370")]
		public enum eAllowUnloadLanguages
		{
			// Token: 0x04003DD8 RID: 15832
			[Token(Token = "0x4003DD8")]
			Never,
			// Token: 0x04003DD9 RID: 15833
			[Token(Token = "0x4003DD9")]
			OnlyInDevice,
			// Token: 0x04003DDA RID: 15834
			[Token(Token = "0x4003DDA")]
			EditorAndDevice
		}

		// Token: 0x02001371 RID: 4977
		[Token(Token = "0x2001371")]
		public enum eGoogleUpdateFrequency
		{
			// Token: 0x04003DDC RID: 15836
			[Token(Token = "0x4003DDC")]
			Always,
			// Token: 0x04003DDD RID: 15837
			[Token(Token = "0x4003DDD")]
			Never,
			// Token: 0x04003DDE RID: 15838
			[Token(Token = "0x4003DDE")]
			Daily,
			// Token: 0x04003DDF RID: 15839
			[Token(Token = "0x4003DDF")]
			Weekly,
			// Token: 0x04003DE0 RID: 15840
			[Token(Token = "0x4003DE0")]
			Monthly,
			// Token: 0x04003DE1 RID: 15841
			[Token(Token = "0x4003DE1")]
			OnlyOnce,
			// Token: 0x04003DE2 RID: 15842
			[Token(Token = "0x4003DE2")]
			EveryOtherDay
		}

		// Token: 0x02001372 RID: 4978
		[Token(Token = "0x2001372")]
		public enum eGoogleUpdateSynchronization
		{
			// Token: 0x04003DE4 RID: 15844
			[Token(Token = "0x4003DE4")]
			Manual,
			// Token: 0x04003DE5 RID: 15845
			[Token(Token = "0x4003DE5")]
			OnSceneLoaded,
			// Token: 0x04003DE6 RID: 15846
			[Token(Token = "0x4003DE6")]
			AsSoonAsDownloaded
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ownerObject ---
		void I2_Loc_LanguageSourceData__get_ownerObject(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6047b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		    DAT_ram_00a6047b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo == *param1_01)
		         )) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_Event_OnSourceUpdateFromGoogle ---
		void I2_Loc_LanguageSourceData__add_Event_OnSourceUpdateFromGoogle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6047c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		    DAT_ram_00a6047c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_Event_OnSourceUpdateFromGoogle ---
		void I2_Loc_LanguageSourceData__remove_Event_OnSourceUpdateFromGoogle
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6047d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6047d = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__AllowSyncFromGoogle(param1,param1);
		  I2_Loc_LanguageSourceData__DeserializeFullTerm(param1,0,param1);
		  I2_Loc_LanguageSourceData__Editor_SetDirty(param1,param1);
		  I2_Loc_LocalizationManager__GetAppName(1,param1);
		  return;
		}
		*/

}
