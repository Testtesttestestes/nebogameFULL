using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020013A7 RID: 5031
	[Token(Token = "0x20013A7")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		// Token: 0x060077BF RID: 30655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077BF")]
		[Address(RVA = "0xC11A", Offset = "0xC11A", VA = "0xC11A", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
		/* --- GHIDRA: GetParameterValue ---
		void I2_Loc_LocalizationParamsManager__GetParameterValue
		               (int param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint uVar3;
		  uint param3_00;
		  undefined8 uVar4;
		  undefined8 local_18;
		  undefined8 local_10;
		  uint local_8;
		  
		  param3_00 = 0;
		  if (DAT_ram_00a54e11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__set_Item__
		              );
		    DAT_ram_00a54e11 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x10);
		  uVar3 = *(uint *)(iVar2 + 0xc);
		  if (0 < (int)uVar3) {
		    do {
		      UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		                (&local_8,*(undefined4 *)(param1 + 0x10),param3_00,
		                 Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__get_Item__
		                );
		      iVar2 = System_Collections_CollectionBase___ctor(local_8,param2,0);
		      if (iVar2 != 0) {
		        UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		                  (&local_8,*(undefined4 *)(param1 + 0x10),param3_00,
		                   Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__get_Item__
		                  );
		        local_18 = CONCAT44(param3,local_8);
		        _local_8 = local_18;
		        System_Collections_Generic_List_XmlSchemaObjectTable_XmlSchemaObjectEntry___get_Item
		                  (*(undefined4 *)(param1 + 0x10),param3_00,&local_18,
		                   Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__set_Item__
		                  );
		        goto code_r0x80b1f3b2;
		      }
		      param3_00 = param3_00 + 1;
		    } while (param3_00 != uVar3);
		    iVar2 = *(int *)(param1 + 0x10);
		    uVar3 = *(uint *)(iVar2 + 0xc);
		  }
		  iVar1 = Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue__Add__;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  uVar4 = CONCAT44(param3,param2);
		  if (uVar3 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		    *(uint *)(iVar2 + 0xc) = uVar3 + 1;
		    *(undefined8 *)(*(int *)(iVar2 + 8) + uVar3 * 8 + 0x10) = uVar4;
		  }
		  else {
		    local_10 = uVar4;
		    _local_8 = uVar4;
		    Core_Data_CollectionData__get_CollectionId
		              (iVar2,&local_10,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		code_r0x80b1f3b2:
		  if (param4 != 0) {
		    if (DAT_ram_00a54e12 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Localize___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a54e12 = '\x01';
		    }
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Localize___);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		    if (iVar2 != 0) {
		      I2_Loc_Localize__HasCallback(param1_00,1,0);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C0")]
		[Address(RVA = "0xC11B", Offset = "0xC11B", VA = "0xC11B")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		/* --- GHIDRA: SetParameterValue ---
		void I2_Loc_LocalizationParamsManager__SetParameterValue(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a54e12 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Localize___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54e12 = '\x01';
		  }
		  param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Localize___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    I2_Loc_Localize__HasCallback(param1_00,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C1")]
		[Address(RVA = "0xC11C", Offset = "0xC11C", VA = "0xC11C")]
		public void OnLocalize()
		{
		/* --- GHIDRA: OnLocalize ---
		void I2_Loc_LocalizationParamsManager__OnLocalize(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x14) != '\0') {
		    I2_Loc_LocalizationParamsManager__OnEnable(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C2")]
		[Address(RVA = "0xC11D", Offset = "0xC11D", VA = "0xC11D", Slot = "5")]
		public virtual void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void I2_Loc_LocalizationParamsManager__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a54e13 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Contains__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e13 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = func_ii_4685(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),
		                       param1,
		                       Method_System_Collections_Generic_List_ILocalizationParamsManager__Contains__
		                      );
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar1 = Method_System_Collections_Generic_List_ILocalizationParamsManager__Add__;
		    param1_00 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param1,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    I2_Loc_LocalizationManager__GetAppName(1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C3")]
		[Address(RVA = "0xC11E", Offset = "0xC11E", VA = "0xC11E")]
		public void DoAutoRegister()
		{
		/* --- GHIDRA: DoAutoRegister ---
		void I2_Loc_LocalizationParamsManager__DoAutoRegister(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e14 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Remove__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e14 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  func_ii_4876(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),param1,
		               Method_System_Collections_Generic_List_ILocalizationParamsManager__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C4")]
		[Address(RVA = "0xC11F", Offset = "0xC11F", VA = "0xC11F")]
		public void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void I2_Loc_LocalizationParamsManager__OnDisable(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54e15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_LocalizationParamsManager_ParamValue__TypeInfo);
		    DAT_ram_00a54e15 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_LocalizationParamsManager_ParamValue__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_LocalizationParamsManager_ParamValue___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C5")]
		[Address(RVA = "0xC120", Offset = "0xC120", VA = "0xC120")]
		public LocalizationParamsManager()
		{
		}

		// Token: 0x04003E7C RID: 15996
		[Token(Token = "0x4003E7C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<LocalizationParamsManager.ParamValue> _Params;

		// Token: 0x04003E7D RID: 15997
		[Token(Token = "0x4003E7D")]
		[FieldOffset(Offset = "0x14")]
		public bool _IsGlobalManager;

		// Token: 0x020013A8 RID: 5032
		[Token(Token = "0x20013A8")]
		[Serializable]
		public struct ParamValue
		{
			// Token: 0x04003E7E RID: 15998
			[Token(Token = "0x4003E7E")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			// Token: 0x04003E7F RID: 15999
			[Token(Token = "0x4003E7F")]
			[FieldOffset(Offset = "0x4")]
			public string Value;
		}
	}
}
