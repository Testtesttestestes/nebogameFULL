using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	// Token: 0x02001377 RID: 4983
	[Token(Token = "0x2001377")]
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06007666 RID: 30310 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007667 RID: 30311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A9")]
		public string Term
		{
			[Token(Token = "0x6007666")]
			[Address(RVA = "0xBFE1", Offset = "0xBFE1", VA = "0xBFE1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007667")]
			[Address(RVA = "0xBFE2", Offset = "0xBFE2", VA = "0xBFE2")]
			set
			{
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007669 RID: 30313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AA")]
		public string SecondaryTerm
		{
			[Token(Token = "0x6007668")]
			[Address(RVA = "0xBFE3", Offset = "0xBFE3", VA = "0xBFE3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007669")]
			[Address(RVA = "0xBFE4", Offset = "0xBFE4", VA = "0xBFE4")]
			set
			{
			}
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766A")]
		[Address(RVA = "0xBFE5", Offset = "0xBFE5", VA = "0xBFE5")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void I2_Loc_Localize__Awake(undefined4 param1,undefined4 param2)
		
		{
		  I2_Loc_Localize__HasCallback(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766B")]
		[Address(RVA = "0xBFE6", Offset = "0xBFE6", VA = "0xBFE6")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		uint I2_Loc_Localize__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  iVar1 = I2_Loc_EventCallback__Execute(*(undefined4 *)(param1 + 0x58),0);
		  if (iVar1 == 0) {
		    iVar1 = UnityEngine_Events_UnityEventBase__FindMethod(*(undefined4 *)(param1 + 0x50),0);
		    uVar2 = (uint)(0 < iVar1);
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x600766C")]
		[Address(RVA = "0xBFE7", Offset = "0xBFE7", VA = "0xBFE7")]
		public bool HasCallback()
		{
		/* --- GHIDRA: HasCallback ---
		void I2_Loc_Localize__HasCallback(int param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  bool bVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  undefined4 *param2_00;
		  undefined4 *puVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  bVar2 = false;
		  if (DAT_ram_00a604cd == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_Localize_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10326);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    DAT_ram_00a604cd = '\x01';
		  }
		  if (param2 == 0) {
		    iVar4 = UnityEngine_Awaitable___c____cctor_b__76_1(param1,0);
		    if (iVar4 == 0) {
		      return;
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar4 = func_ii_3812(uVar3,0,0);
		    if (iVar4 != 0) {
		      return;
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    iVar4 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar3,0);
		    if (iVar4 == 0) {
		      return;
		    }
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
		  I2_Loc_LocalizeDropdown___ctor(param1);
		  iVar4 = func_ii_4769(**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),0);
		  if (iVar4 != 0) {
		    return;
		  }
		  if ((((*(char *)(param1 + 0x54) == '\0') && (param2 == 0)) &&
		      (iVar4 = I2_Loc_EventCallback__Execute(*(undefined4 *)(param1 + 0x58),0), iVar4 == 0)) &&
		     (iVar4 = UnityEngine_Events_UnityEventBase__FindMethod(*(undefined4 *)(param1 + 0x50),0),
		     iVar4 < 1)) {
		    uVar3 = *(undefined4 *)(param1 + 0x34);
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
		    I2_Loc_LocalizeDropdown___ctor(param1);
		    iVar4 = System_Collections_CollectionBase___ctor
		                      (uVar3,**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),0);
		    if (iVar4 != 0) {
		      return;
		    }
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
		  I2_Loc_LocalizeDropdown___ctor(param1);
		  *(undefined4 *)(param1 + 0x34) = **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  param2_00 = (undefined4 *)(param1 + 0x18);
		  iVar4 = func_ii_4769(*(undefined4 *)(param1 + 0x18),0);
		  if ((iVar4 != 0) || (iVar4 = func_ii_4769(*(undefined4 *)(param1 + 0x1c),0), iVar4 != 0)) {
		    I2_Loc_Localize__FindTarget(param1,param2_00,param1 + 0x1c,param1);
		  }
		  iVar4 = I2_Loc_LanguageSourceData__Import_CSV(0);
		  if ((iVar4 == 0) ||
		     ((iVar4 = I2_Loc_EventCallback__Execute(*(undefined4 *)(param1 + 0x58),0), iVar4 == 0 &&
		      (iVar4 = UnityEngine_Events_UnityEventBase__FindMethod(*(undefined4 *)(param1 + 0x50),0),
		      iVar4 < 1)))) {
		    bVar2 = true;
		    iVar4 = func_ii_4769(*param2_00,0);
		    if ((iVar4 != 0) && (iVar4 = func_ii_4769(*(undefined4 *)(param1 + 0x1c),0), iVar4 != 0)) {
		      return;
		    }
		  }
		  uVar3 = 0;
		  iVar4 = *(int *)(I2_Loc_Localize_TypeInfo + 0x5c);
		  *(int *)(iVar4 + 0x10) = param1;
		  uVar7 = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(iVar4 + 8) = uVar7;
		  *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(param1 + 0x1c);
		  iVar4 = func_ii_4769(uVar7,0);
		  if (iVar4 == 0) {
		    iVar4 = System_Collections_CollectionBase___ctor(*param2_00,StringLiteral_1331,0);
		    if (iVar4 == 0) {
		      uVar7 = *param2_00;
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      if (DAT_ram_00a60519 == '\0') {
		        Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		        DAT_ram_00a60519 = '\x01';
		      }
		      local_8 = 0;
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      func_ii_13839(uVar7,&local_8,0,0,1,0,0,0,1,param1);
		      uVar7 = local_8;
		    }
		    else {
		      uVar7 = 0;
		    }
		  }
		  else {
		    uVar7 = 0;
		  }
		  **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c) = uVar7;
		  iVar4 = func_ii_4769(*(undefined4 *)(param1 + 0x1c),0);
		  if ((iVar4 == 0) &&
		     (iVar4 = System_Collections_CollectionBase___ctor
		                        (*(undefined4 *)(param1 + 0x1c),StringLiteral_1331,0), iVar4 == 0)) {
		    uVar3 = *(undefined4 *)(param1 + 0x1c);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (DAT_ram_00a60519 == '\0') {
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a60519 = '\x01';
		    }
		    local_4 = 0;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    func_ii_13839(uVar3,&local_4,0,0,1,0,0,0,1,param1);
		    uVar3 = local_4;
		  }
		  *(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 4) = uVar3;
		  if (((bVar2) && (iVar4 = func_ii_4769(*param2_00,0), iVar4 != 0)) &&
		     (iVar4 = func_ii_4769(*(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 4),0),
		     iVar4 != 0)) {
		    return;
		  }
		  I2_Loc_SpecializationManager___cctor(*(undefined4 *)(param1 + 0x58),param1,0);
		  UnityEngine_Events_UnityEvent__GetDelegate(*(undefined4 *)(param1 + 0x50),0);
		  if (*(char *)(param1 + 0x44) != '\0') {
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    cVar1 = *(char *)(param1 + 0x43);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__ApplyLocalizationParams
		              (*(undefined4 *)(I2_Loc_Localize_TypeInfo + 0x5c),uVar3,(uint)(cVar1 != '\0'),param1);
		  }
		  iVar4 = I2_Loc_Localize__OnLocalize(param1,param1);
		  if (iVar4 == 0) {
		    return;
		  }
		  bVar2 = false;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) != '\0') {
		    bVar2 = *(char *)(param1 + 0x38) == '\0';
		  }
		  iVar4 = **(int **)(I2_Loc_Localize_TypeInfo + 0x5c);
		  if (iVar4 != 0) {
		    iVar6 = *(int *)(param1 + 0x20);
		    if (iVar6 == 1) {
		      uVar3 = System_Uri__get_Authority(iVar4,0);
		code_r0x81c9a176:
		      **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c) = uVar3;
		    }
		    else {
		      if (iVar6 == 2) {
		        uVar3 = func_ii_7775(iVar4,0);
		        goto code_r0x81c9a176;
		      }
		      if (iVar6 == 3) {
		        if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		        }
		        uVar3 = System_Text_RegularExpressions_Regex__Replace(iVar4,0);
		        goto code_r0x81c9a176;
		      }
		      if (iVar6 == 4) {
		        if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		        }
		        uVar3 = I2_Loc_GoogleTranslation__UppercaseFirst(iVar4,0);
		        goto code_r0x81c9a176;
		      }
		    }
		    iVar4 = func_ii_4769(*(undefined4 *)(param1 + 0x28),0);
		    if (iVar4 == 0) {
		      puVar5 = *(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c);
		      if (!bVar2) {
		        puVar5 = (undefined4 *)(param1 + 0x28);
		      }
		      puVar8 = (undefined4 *)(param1 + 0x28);
		      if (!bVar2) {
		        puVar8 = *(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c);
		      }
		      uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(*puVar5,*puVar8,0);
		      **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c) = uVar3;
		    }
		    iVar4 = func_ii_4769(*(undefined4 *)(param1 + 0x2c),0);
		    if (iVar4 == 0) {
		      puVar5 = (undefined4 *)(param1 + 0x2c);
		      if (!bVar2) {
		        puVar5 = *(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c);
		      }
		      puVar8 = *(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c);
		      if (!bVar2) {
		        puVar8 = (undefined4 *)(param1 + 0x2c);
		      }
		      uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(*puVar5,*puVar8,0);
		      **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c) = uVar3;
		    }
		    if (*(char *)(param1 + 0x42) != '\0') {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      if ((*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xe) != '\0') &&
		         (iVar4 = func_ii_4769(**(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c),0), iVar4 == 0)) {
		        param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		        func_ii_2101(param1_00,0);
		        uVar3 = func_ii_3010(**(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c),0,0);
		        func_ii_3135(param1_00,uVar3,0);
		        iVar4 = *(int *)(**(int **)(I2_Loc_Localize_TypeInfo + 0x5c) + 8);
		        if (1 < iVar4) {
		          iVar6 = 1;
		          do {
		            func_ii_3135(param1_00,0x20,0);
		            uVar3 = func_ii_3010(**(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c),iVar6,0);
		            func_ii_3135(param1_00,uVar3,0);
		            iVar6 = iVar6 + 1;
		          } while (iVar6 != iVar4);
		        }
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                          (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		        **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c) = uVar3;
		      }
		    }
		    if (((bVar2) &&
		        (iVar4 = **(int **)(param1 + 0x60),
		        iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                          (*(int **)(param1 + 0x60),*(undefined4 *)(iVar4 + 0x104)), iVar4 != 0)) &&
		       (iVar4 = func_ii_4769(**(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c),0), iVar4 == 0)) {
		      cVar1 = *(char *)(param1 + 0x40);
		      uVar3 = *(undefined4 *)(param1 + 0x3c);
		      uVar7 = **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c);
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar3 = I2_Loc_LocalizationManager__ApplyRTLfix(uVar7,uVar3,(uint)(cVar1 != '\0'),param1);
		      **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c) = uVar3;
		    }
		  }
		  iVar4 = *(int *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 4);
		  if (iVar4 == 0) goto code_r0x81c9a4c5;
		  iVar6 = *(int *)(param1 + 0x24);
		  if (iVar6 == 1) {
		    uVar3 = System_Uri__get_Authority(iVar4,0);
		code_r0x81c9a437:
		    *(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 4) = uVar3;
		  }
		  else {
		    if (iVar6 == 2) {
		      uVar3 = func_ii_7775(iVar4,0);
		      goto code_r0x81c9a437;
		    }
		    if (iVar6 == 3) {
		      if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		      }
		      uVar3 = System_Text_RegularExpressions_Regex__Replace(iVar4,0);
		      goto code_r0x81c9a437;
		    }
		    if (iVar6 == 4) {
		      if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		      }
		      uVar3 = I2_Loc_GoogleTranslation__UppercaseFirst(iVar4,0);
		      goto code_r0x81c9a437;
		    }
		  }
		  if (((bVar2) &&
		      (iVar4 = **(int **)(param1 + 0x60),
		      iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x108) * 4))
		                        (*(int **)(param1 + 0x60),*(undefined4 *)(iVar4 + 0x10c)), iVar4 != 0)) &&
		     (iVar4 = func_ii_4769(*(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 4),0),
		     iVar4 == 0)) {
		    uVar3 = *(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 4);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    uVar3 = I2_Loc_LocalizationManager__GetPluralType(uVar3,param1);
		    *(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 4) = uVar3;
		  }
		code_r0x81c9a4c5:
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x36) != '\0') {
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_10326,*param2_00,0);
		    **(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c) = uVar3;
		  }
		  iVar4 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf0) * 4))
		            (*(int **)(param1 + 0x60),param1,**(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c),
		             (*(undefined4 **)(I2_Loc_Localize_TypeInfo + 0x5c))[1],*(undefined4 *)(iVar4 + 0xf4));
		  *(undefined4 *)(*(int *)(I2_Loc_Localize_TypeInfo + 0x5c) + 0x10) = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766D")]
		[Address(RVA = "0xBFE8", Offset = "0xBFE8", VA = "0xBFE8")]
		public void OnLocalize(bool Force = false)
		{
		/* --- GHIDRA: OnLocalize ---
		undefined4 I2_Loc_Localize__OnLocalize(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param2_00;
		  undefined4 param2_01;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a604ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ILocalizeTargetDescriptor__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ILocalizeTargetDescriptor__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ILocalizeTargetDescriptor__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a604ce = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar4 = *(undefined4 *)(param1 + 0x60);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		  if ((iVar1 == 0) ||
		     (iVar1 = **(int **)(param1 + 0x60),
		     iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))
		                       (*(int **)(param1 + 0x60),param1,*(undefined4 *)(iVar1 + 0xe4)), iVar1 == 0))
		  {
		    uVar4 = *(undefined4 *)(param1 + 0x60);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		    if (iVar1 == 0) {
		      uVar4 = *(undefined4 *)(param1 + 100);
		    }
		    else {
		      uVar4 = *(undefined4 *)(param1 + 0x60);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Object__Destroy(uVar4,0);
		      *(undefined8 *)(param1 + 0x60) = 0;
		      uVar4 = 0;
		    }
		    iVar1 = func_ii_4769(uVar4,0);
		    if (iVar1 == 0) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,
		                 *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x2c),
		                 Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                             Method_System_Collections_Generic_List_Enumerator_ILocalizeTargetDescriptor__MoveNext__
		                            );
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c9acd6:
		            iVar1 = global_1;
		            iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		            if (iVar1 == iVar2) {
		              piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		              iVar2 = *piVar3;
		              DAT_ram_009d3e38 = 0;
		              local_20 = iVar2;
		              import::env::invoke_v(0x123);
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 != 1) {
		                if (iVar2 != 0) {
		                  System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		                goto code_r0x81c9ad69;
		              }
		              uVar4 = import::env::__cxa_find_matching_catch_2();
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x4a,&local_20)
		            ;
		            goto joined_r0x81c9ad64;
		          }
		          if (iVar2 == 0) goto code_r0x81c9ad69;
		          piVar3 = local_8._4_4_;
		          uVar4 = *(undefined4 *)(param1 + 100);
		          DAT_ram_009d3e38 = 0;
		          param2_00 = (int *)import::env::invoke_iii
		                                       (*(undefined4 *)(*local_8._4_4_ + 0xf0),local_8._4_4_,
		                                        *(undefined4 *)(*local_8._4_4_ + 0xf4));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c9acd6;
		          }
		          DAT_ram_009d3e38 = 0;
		          param2_01 = import::env::invoke_iii
		                                (*(undefined4 *)(*param2_00 + 0xd8),param2_00,
		                                 *(undefined4 *)(*param2_00 + 0xdc));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c9acd6;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar2 = System_Collections_CollectionBase___ctor(uVar4,param2_01,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c9acd6;
		          }
		        } while (iVar2 == 0);
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iiii
		                          (*(undefined4 *)(*piVar3 + 0xe0),piVar3,param1,
		                           *(undefined4 *)(*piVar3 + 0xe4));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c9acd6;
		        }
		        if (iVar2 == 0) {
		          uVar4 = *(undefined4 *)(param1 + 0x60);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii
		                            (*(undefined4 *)(*piVar3 + 0xe8),piVar3,param1,
		                             *(undefined4 *)(*piVar3 + 0xec));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c9acd6;
		          }
		          *(undefined4 *)(param1 + 0x60) = uVar4;
		        }
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c9acd6;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3b7,uVar4,0,0);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c9acd6;
		        }
		      } while (iVar2 == 0);
		    }
		    else {
		code_r0x81c9ad69:
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,
		                 *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x2c),
		                 Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                             Method_System_Collections_Generic_List_Enumerator_ILocalizeTargetDescriptor__MoveNext__
		                            );
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c9b018:
		            iVar1 = global_1;
		            iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		            if (iVar1 == iVar2) {
		              piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		              iVar2 = *piVar3;
		              DAT_ram_009d3e38 = 0;
		              local_20 = iVar2;
		              import::env::invoke_v(0x123);
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 != 1) {
		                if (iVar2 != 0) {
		                  System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		              uVar4 = import::env::__cxa_find_matching_catch_2();
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x4b,&local_20)
		            ;
		joined_r0x81c9ad64:
		            if (DAT_ram_009d3e38 == 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::__cxa_find_matching_catch_3(0);
		              unnamed_function_937();
		              do {
		                halt_trap();
		              } while( true );
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::__resumeException(uVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          piVar3 = local_8._4_4_;
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iiii
		                            (*(undefined4 *)(*local_8._4_4_ + 0xe0),local_8._4_4_,param1,
		                             *(undefined4 *)(*local_8._4_4_ + 0xe4));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c9b018;
		          }
		        } while (iVar2 == 0);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iiii
		                          (*(undefined4 *)(*piVar3 + 0xe8),piVar3,param1,
		                           *(undefined4 *)(*piVar3 + 0xec));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c9b018;
		        }
		        *(undefined4 *)(param1 + 0x60) = uVar4;
		        DAT_ram_009d3e38 = 0;
		        piVar3 = (int *)import::env::invoke_iii
		                                  (*(undefined4 *)(*piVar3 + 0xf0),piVar3,
		                                   *(undefined4 *)(*piVar3 + 0xf4));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c9b018;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (*(undefined4 *)(*piVar3 + 0xd8),piVar3,*(undefined4 *)(*piVar3 + 0xdc));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c9b018;
		        }
		        *(undefined4 *)(param1 + 100) = uVar4;
		        uVar4 = *(undefined4 *)(param1 + 0x60);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c9b018;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3b7,uVar4,0,0);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c9b018;
		        }
		      } while (iVar2 == 0);
		    }
		    DAT_ram_009d3e38 = 0;
		  }
		  return 1;
		}
		*/

		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00015768 File Offset: 0x00013968
		[Token(Token = "0x600766E")]
		[Address(RVA = "0xBFE9", Offset = "0xBFE9", VA = "0xBFE9")]
		public bool FindTarget()
		{
		/* --- GHIDRA: FindTarget ---
		void I2_Loc_Localize__FindTarget(int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604cf == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a604cf = '\x01';
		  }
		  *param2 = **(int **)(DAT_ram_00a66978 + 0x5c);
		  *param3 = **(int **)(DAT_ram_00a66978 + 0x5c);
		  iVar1 = I2_Loc_Localize__OnLocalize(param1,param1);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x60);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		    if (iVar1 != 0) {
		      iVar1 = **(int **)(param1 + 0x60);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 0x60),param1,*(undefined4 *)(param1 + 0x10),
		                 *(undefined4 *)(param1 + 0x14),param2,param3,*(undefined4 *)(iVar1 + 0xec));
		      iVar1 = I2_Loc_I2Utils__ReverseText(*param2,0,0);
		      *param2 = iVar1;
		    }
		    iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x10),0);
		    if (iVar1 == 0) {
		      *param2 = *(int *)(param1 + 0x10);
		    }
		    iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x14),0);
		    if (iVar1 == 0) {
		      *param3 = *(int *)(param1 + 0x14);
		    }
		    if (*param2 != 0) {
		      iVar1 = System_Convert__FromBase64String(*param2,0);
		      *param2 = iVar1;
		    }
		    if (*param3 != 0) {
		      iVar1 = System_Convert__FromBase64String(*param3,0);
		      *param3 = iVar1;
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766F")]
		[Address(RVA = "0xBFEA", Offset = "0xBFEA", VA = "0xBFEA")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		undefined4 I2_Loc_Localize__GetFinalTerms(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a604d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a604d0 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x60);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = **(int **)(param1 + 0x60);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x60),param1,0,0,&local_4,&local_8,*(undefined4 *)(iVar1 + 0xec));
		    uVar2 = local_4;
		  }
		  iVar1 = func_ii_4769(uVar2,0);
		  puVar3 = (undefined4 *)(param1 + 0x10);
		  if (iVar1 == 0) {
		    puVar3 = &local_4;
		  }
		  return *puVar3;
		}
		*/

		}

		// Token: 0x06007670 RID: 30320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007670")]
		[Address(RVA = "0xBFEB", Offset = "0xBFEB", VA = "0xBFEB")]
		public string GetMainTargetsText()
		{
		/* --- GHIDRA: GetMainTargetsText ---
		void I2_Loc_Localize__GetMainTargetsText
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 *param4,
		               undefined4 *param5,int param6,undefined4 param7)
		
		{
		  if (param6 != 0) {
		    param2 = I2_Loc_I2Utils__ReverseText(param2,0,0);
		  }
		  *param4 = param2;
		  *param5 = param3;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007671")]
		[Address(RVA = "0xBFEC", Offset = "0xBFEC", VA = "0xBFEC")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		/* --- GHIDRA: SetFinalTerms ---
		void I2_Loc_Localize__SetFinalTerms(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_4769(param2,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x18) = param2;
		    *(undefined4 *)(param1 + 0x10) = param2;
		  }
		  I2_Loc_Localize__HasCallback(param1,1,param2);
		  return;
		}
		*/

		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007672")]
		[Address(RVA = "0xBFED", Offset = "0xBFED", VA = "0xBFED")]
		public void SetTerm(string primary)
		{
		/* --- GHIDRA: SetTerm ---
		void I2_Loc_Localize__SetTerm(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a604d1 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_0__);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_1__);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_2__);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_3__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_Localize___c_TypeInfo);
		    DAT_ram_00a604d1 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x48);
		  if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Predicate_Object__TypeInfo);
		    func_ii_7297(iVar3,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_0__,0);
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  System_Collections_Generic_List_object___IsCompatibleObject
		            (uVar1,iVar3,Method_System_Collections_Generic_List_Object__RemoveAll__);
		  uVar1 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x48),Method_System_Linq_Enumerable_Distinct_Object___
		                    );
		  if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_Object__string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar3,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_1__,0);
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_GroupBy_Object__string___);
		  if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[3];
		  iVar3 = I2_Loc_Localize___c_TypeInfo;
		  if (param1_00 == 0) {
		    if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_IGrouping_string__Object___string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_00,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_2__,0);
		    iVar3 = I2_Loc_Localize___c_TypeInfo;
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 0xc) = param1_00;
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		    iVar3 = I2_Loc_Localize___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(iVar3 + 0x5c);
		  param1_01 = puVar2[4];
		  if (param1_01 == 0) {
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_IGrouping_string__Object___Object__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_01,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_3__,0);
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 0x10) = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__object__Int32Enum_
		                    (uVar1,param1_00,param1_01,
		                     Method_System_Linq_Enumerable_ToDictionary_IGrouping_string__Object___string__Object___
		                    );
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: SetTerm ---
		void I2_Loc_Localize__SetTerm(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a604d1 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_0__);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_1__);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_2__);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_3__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_Localize___c_TypeInfo);
		    DAT_ram_00a604d1 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x48);
		  if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Predicate_Object__TypeInfo);
		    func_ii_7297(iVar3,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_0__,0);
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  System_Collections_Generic_List_object___IsCompatibleObject
		            (uVar1,iVar3,Method_System_Collections_Generic_List_Object__RemoveAll__);
		  uVar1 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x48),Method_System_Linq_Enumerable_Distinct_Object___
		                    );
		  if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_Object__string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar3,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_1__,0);
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_GroupBy_Object__string___);
		  if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[3];
		  iVar3 = I2_Loc_Localize___c_TypeInfo;
		  if (param1_00 == 0) {
		    if (*(int *)(I2_Loc_Localize___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_Localize___c_TypeInfo);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_IGrouping_string__Object___string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_00,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_2__,0);
		    iVar3 = I2_Loc_Localize___c_TypeInfo;
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 0xc) = param1_00;
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		    iVar3 = I2_Loc_Localize___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(iVar3 + 0x5c);
		  param1_01 = puVar2[4];
		  if (param1_01 == 0) {
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		      puVar2 = *(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_IGrouping_string__Object___Object__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_01,uVar4,Method_I2_Loc_Localize___c__UpdateAssetDictionary_b__50_3__,0);
		    *(int *)(*(int *)(I2_Loc_Localize___c_TypeInfo + 0x5c) + 0x10) = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__object__Int32Enum_
		                    (uVar1,param1_00,param1_01,
		                     Method_System_Linq_Enumerable_ToDictionary_IGrouping_string__Object___string__Object___
		                    );
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06007673 RID: 30323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007673")]
		[Address(RVA = "0xBFEE", Offset = "0xBFEE", VA = "0xBFEE")]
		public void SetTerm(string primary, string secondary)
		{
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007674")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007675")]
		[Address(RVA = "0xBFEF", Offset = "0xBFEF", VA = "0xBFEF")]
		public void UpdateAssetDictionary()
		{
		/* --- GHIDRA: UpdateAssetDictionary ---
		void I2_Loc_Localize__UpdateAssetDictionary
		               (undefined4 param1,int param2,int *param3,undefined4 *param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = func_ii_4769(param2,0);
		  if ((((iVar1 == 0) && (1 < *(int *)(param2 + 8))) &&
		      (iVar1 = func_ii_3010(param2,0,0), iVar1 == 0x5b)) &&
		     (iVar1 = System_Xml_Schema_XmlSchemaException___ctor(param2,0x5d,0), 0 < iVar1)) {
		    uVar2 = System_Data_DataSet__ReadXmlSchema(param2,1,iVar1 + -1,0);
		    *param4 = uVar2;
		    iVar1 = System_String__get_Chars(param2,iVar1 + 1,0);
		    *param3 = iVar1;
		    return;
		  }
		  *param3 = param2;
		  *param4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  return;
		}
		*/

		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007676")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007677")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007678")]
		[Address(RVA = "0xBFF0", Offset = "0xBFF0", VA = "0xBFF0")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		/* --- GHIDRA: DeserializeTranslation ---
		undefined4 I2_Loc_Localize__DeserializeTranslation(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a604d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Contains__);
		    DAT_ram_00a604d2 = '\x01';
		  }
		  iVar1 = func_ii_4685(*(undefined4 *)(param1 + 0x48),param2,
		                       Method_System_Collections_Generic_List_Object__Contains__);
		  if (iVar1 == 0) {
		    uVar2 = I2_Loc_RegisterGlobalParameters___ctor(0);
		    uVar2 = I2_Loc_ResourceManager__FindAsset(uVar2,param2,0);
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007679")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x600767A")]
		[Address(RVA = "0xBFF1", Offset = "0xBFF1", VA = "0xBFF1")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
		/* --- GHIDRA: HasTranslatedObject ---
		void I2_Loc_Localize__HasTranslatedObject(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a604d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Contains__);
		    DAT_ram_00a604d3 = '\x01';
		  }
		  iVar2 = func_ii_4685(*(undefined4 *)(param1 + 0x48),param2,
		                       Method_System_Collections_Generic_List_Object__Contains__);
		  iVar1 = Method_System_Collections_Generic_List_Object__Add__;
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(param1 + 0x48);
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
		    I2_Loc_Localize__SetTerm(param1,param1);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767B")]
		[Address(RVA = "0xBFF2", Offset = "0xBFF2", VA = "0xBFF2")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		/* --- GHIDRA: AddTranslatedObject ---
		void I2_Loc_Localize__AddTranslatedObject(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a604d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604d4 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__get_CurrentLanguage(param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767C")]
		[Address(RVA = "0xBFF3", Offset = "0xBFF3", VA = "0xBFF3")]
		public void SetGlobalLanguage(string Language)
		{
		/* --- GHIDRA: SetGlobalLanguage ---
		void I2_Loc_Localize__SetGlobalLanguage(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a604d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__Object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_EventCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityEvent_TypeInfo);
		    DAT_ram_00a604d5 = '\x01';
		  }
		  uVar1 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  *(undefined2 *)(param1 + 0x43) = 0x101;
		  *(undefined2 *)(param1 + 0x40) = 0x101;
		  *(undefined1 *)(param1 + 0x30) = 1;
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Object__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Object___ctor__);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
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
		  param2_00 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__Object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (uVar1,param2_00,Method_System_Collections_Generic_Dictionary_string__Object___ctor__);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityEvent_TypeInfo);
		  UnityEngine_Events_UnityAction__Invoke(uVar1,0);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  uVar1 = unnamed_function_1417(I2_Loc_EventCallback_TypeInfo);
		  I2_Loc_EventCallback__HasCallback(uVar1,0);
		  *(undefined1 *)(param1 + 0x5d) = 1;
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600767D RID: 30333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767D")]
		[Address(RVA = "0xBFF4", Offset = "0xBFF4", VA = "0xBFF4")]
		public Localize()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_Localize___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a604d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_Localize___c_TypeInfo);
		    DAT_ram_00a604d6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(I2_Loc_Localize___c_TypeInfo);
		  **(undefined4 **)(I2_Loc_Localize___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003DF9 RID: 15865
		[Token(Token = "0x4003DF9")]
		[FieldOffset(Offset = "0x10")]
		public string mTerm;

		// Token: 0x04003DFA RID: 15866
		[Token(Token = "0x4003DFA")]
		[FieldOffset(Offset = "0x14")]
		public string mTermSecondary;

		// Token: 0x04003DFB RID: 15867
		[Token(Token = "0x4003DFB")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string FinalTerm;

		// Token: 0x04003DFC RID: 15868
		[Token(Token = "0x4003DFC")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		public string FinalSecondaryTerm;

		// Token: 0x04003DFD RID: 15869
		[Token(Token = "0x4003DFD")]
		[FieldOffset(Offset = "0x20")]
		public Localize.TermModification PrimaryTermModifier;

		// Token: 0x04003DFE RID: 15870
		[Token(Token = "0x4003DFE")]
		[FieldOffset(Offset = "0x24")]
		public Localize.TermModification SecondaryTermModifier;

		// Token: 0x04003DFF RID: 15871
		[Token(Token = "0x4003DFF")]
		[FieldOffset(Offset = "0x28")]
		public string TermPrefix;

		// Token: 0x04003E00 RID: 15872
		[Token(Token = "0x4003E00")]
		[FieldOffset(Offset = "0x2C")]
		public string TermSuffix;

		// Token: 0x04003E01 RID: 15873
		[Token(Token = "0x4003E01")]
		[FieldOffset(Offset = "0x30")]
		public bool LocalizeOnAwake;

		// Token: 0x04003E02 RID: 15874
		[Token(Token = "0x4003E02")]
		[FieldOffset(Offset = "0x34")]
		private string LastLocalizedLanguage;

		// Token: 0x04003E03 RID: 15875
		[Token(Token = "0x4003E03")]
		[FieldOffset(Offset = "0x38")]
		public bool IgnoreRTL;

		// Token: 0x04003E04 RID: 15876
		[Token(Token = "0x4003E04")]
		[FieldOffset(Offset = "0x3C")]
		public int MaxCharactersInRTL;

		// Token: 0x04003E05 RID: 15877
		[Token(Token = "0x4003E05")]
		[FieldOffset(Offset = "0x40")]
		public bool IgnoreNumbersInRTL;

		// Token: 0x04003E06 RID: 15878
		[Token(Token = "0x4003E06")]
		[FieldOffset(Offset = "0x41")]
		public bool CorrectAlignmentForRTL;

		// Token: 0x04003E07 RID: 15879
		[Token(Token = "0x4003E07")]
		[FieldOffset(Offset = "0x42")]
		public bool AddSpacesToJoinedLanguages;

		// Token: 0x04003E08 RID: 15880
		[Token(Token = "0x4003E08")]
		[FieldOffset(Offset = "0x43")]
		public bool AllowLocalizedParameters;

		// Token: 0x04003E09 RID: 15881
		[Token(Token = "0x4003E09")]
		[FieldOffset(Offset = "0x44")]
		public bool AllowParameters;

		// Token: 0x04003E0A RID: 15882
		[Token(Token = "0x4003E0A")]
		[FieldOffset(Offset = "0x48")]
		public List<UnityEngine.Object> TranslatedObjects;

		// Token: 0x04003E0B RID: 15883
		[Token(Token = "0x4003E0B")]
		[FieldOffset(Offset = "0x4C")]
		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		// Token: 0x04003E0C RID: 15884
		[Token(Token = "0x4003E0C")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent LocalizeEvent;

		// Token: 0x04003E0D RID: 15885
		[Token(Token = "0x4003E0D")]
		[FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		// Token: 0x04003E0E RID: 15886
		[Token(Token = "0x4003E0E")]
		[FieldOffset(Offset = "0x4")]
		public static string SecondaryTranslation;

		// Token: 0x04003E0F RID: 15887
		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x8")]
		public static string CallBackTerm;

		// Token: 0x04003E10 RID: 15888
		[Token(Token = "0x4003E10")]
		[FieldOffset(Offset = "0xC")]
		public static string CallBackSecondaryTerm;

		// Token: 0x04003E11 RID: 15889
		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x10")]
		public static Localize CurrentLocalizeComponent;

		// Token: 0x04003E12 RID: 15890
		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x54")]
		public bool AlwaysForceLocalize;

		// Token: 0x04003E13 RID: 15891
		[Token(Token = "0x4003E13")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		// Token: 0x04003E14 RID: 15892
		[Token(Token = "0x4003E14")]
		[FieldOffset(Offset = "0x5C")]
		public bool mGUI_ShowReferences;

		// Token: 0x04003E15 RID: 15893
		[Token(Token = "0x4003E15")]
		[FieldOffset(Offset = "0x5D")]
		public bool mGUI_ShowTems;

		// Token: 0x04003E16 RID: 15894
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x5E")]
		public bool mGUI_ShowCallback;

		// Token: 0x04003E17 RID: 15895
		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x60")]
		public ILocalizeTarget mLocalizeTarget;

		// Token: 0x04003E18 RID: 15896
		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0x64")]
		public string mLocalizeTargetName;

		// Token: 0x02001378 RID: 4984
		[Token(Token = "0x2001378")]
		public enum TermModification
		{
			// Token: 0x04003E1A RID: 15898
			[Token(Token = "0x4003E1A")]
			DontModify,
			// Token: 0x04003E1B RID: 15899
			[Token(Token = "0x4003E1B")]
			ToUpper,
			// Token: 0x04003E1C RID: 15900
			[Token(Token = "0x4003E1C")]
			ToLower,
			// Token: 0x04003E1D RID: 15901
			[Token(Token = "0x4003E1D")]
			ToUpperFirst,
			// Token: 0x04003E1E RID: 15902
			[Token(Token = "0x4003E1E")]
			ToTitle
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SecondaryTerm ---
		void I2_Loc_Localize__get_SecondaryTerm(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_4769(0,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x18) = 0;
		    *(undefined4 *)(param1 + 0x10) = 0;
		  }
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  I2_Loc_Localize__HasCallback(param1,1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_SecondaryTerm ---
		void I2_Loc_Localize__set_SecondaryTerm(int param1,undefined4 param2)
		
		{
		  I2_Loc_Localize__SetTerm(param1,param1);
		  I2_Loc_Localize__OnLocalize(param1,param1);
		  if (*(char *)(param1 + 0x30) != '\0') {
		    I2_Loc_Localize__HasCallback(param1,0,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: GetSecondaryTranslatedObj<object> ---
		undefined4
		I2_Loc_Localize__GetSecondaryTranslatedObj_object_(undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  
		  puVar2 = *(undefined4 **)(param3 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    puVar2 = *(undefined4 **)(param3 + 0x1c);
		  }
		  uVar1 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_(param1,param2,*puVar2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetObject<object> ---
		undefined4
		I2_Loc_Localize__GetObject_object_
		          (undefined4 param1,undefined4 *param2,undefined4 *param3,int param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  param1_00 = 0;
		  if ((*(int *)(param4 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo), *(int *)(param4 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		  }
		  local_4 = 0;
		  local_8 = 0;
		  I2_Loc_Localize__UpdateAssetDictionary(param1,*param2,&local_4,&local_8,0);
		  iVar1 = func_ii_4769(local_8,0);
		  uVar3 = local_8;
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(*(int *)(param4 + 0x1c) + 4);
		    if (*(int *)(iVar1 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(iVar1);
		    }
		    iVar2 = func_ii_4769(uVar3,0);
		    if (iVar2 == 0) {
		      iVar1 = *(int *)(*(int *)(iVar1 + 0x1c) + 4);
		      puVar4 = *(undefined4 **)(iVar1 + 0x1c);
		      if (puVar4 == (undefined4 *)0x0) {
		        System_ReadOnlySpan_char___GetPinnableReference(iVar1);
		        puVar4 = *(undefined4 **)(iVar1 + 0x1c);
		      }
		      param1_00 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		                            (param1,uVar3,*puVar4);
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		    if (iVar1 != 0) {
		      *param2 = local_4;
		      *param3 = local_8;
		    }
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(param1_00,0,0);
		  if (iVar1 != 0) {
		    uVar3 = *param3;
		    iVar1 = *(int *)(*(int *)(param4 + 0x1c) + 4);
		    if (*(int *)(iVar1 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(iVar1);
		    }
		    param1_00 = 0;
		    iVar2 = func_ii_4769(uVar3,0);
		    if (iVar2 == 0) {
		      iVar1 = *(int *)(*(int *)(iVar1 + 0x1c) + 4);
		      puVar4 = *(undefined4 **)(iVar1 + 0x1c);
		      if (puVar4 == (undefined4 *)0x0) {
		        System_ReadOnlySpan_char___GetPinnableReference(iVar1);
		        puVar4 = *(undefined4 **)(iVar1 + 0x1c);
		      }
		      param1_00 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		                            (param1,uVar3,*puVar4);
		    }
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: GetTranslatedObject<object> ---
		undefined4 I2_Loc_Localize__GetTranslatedObject_object_(int param1,int param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  piVar3 = *(int **)(param2 + 0x1c);
		  if (piVar3 == (int *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		    piVar3 = *(int **)(param2 + 0x1c);
		  }
		  iVar4 = *piVar3;
		  piVar3 = *(int **)(param1 + 8);
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (*(int *)(iVar4 + 0x10) == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        iVar5 = iVar5 + (*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)(iVar4 + 0x2c)) * 8 + 0xc0;
		        goto code_r0x820f051c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  iVar5 = func_ii_1080(piVar3,*(int *)(iVar4 + 0x10),(uint)*(ushort *)(iVar4 + 0x2c));
		code_r0x820f051c:
		  iVar4 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar5 + 4),iVar4);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 4) * 4))(piVar3,iVar4);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: FindTranslatedObject<object> ---
		undefined4
		I2_Loc_Localize__FindTranslatedObject_object_(undefined4 param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  iVar1 = func_ii_4769(param2,0);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		    puVar3 = *(undefined4 **)(iVar1 + 0x1c);
		    if (puVar3 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(iVar1);
		      puVar3 = *(undefined4 **)(iVar1 + 0x1c);
		    }
		    uVar2 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_(param1,param2,*puVar3)
		    ;
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

}
