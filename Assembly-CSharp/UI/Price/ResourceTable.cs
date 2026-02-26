using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Price
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	public class ResourceTable : MonoBehaviour
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x5F20", Offset = "0x5F20", VA = "0x5F20")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Price_ResourceTable__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a638f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_ResourceTable_MarkerClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a638f2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_UI_Price_ResourceTable_MarkerClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x5F21", Offset = "0x5F21", VA = "0x5F21")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Price_ResourceTable__OnDestroy(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int param1_00;
		  int iVar5;
		  undefined4 uVar6;
		  uint uVar7;
		  longlong lVar8;
		  longlong local_38;
		  longlong local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  longlong local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a638f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_Resources__BaseToolTipData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ResourceTable_ResourceInstance__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ResourceTable_ResourceInstance__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ResourceTable_ResourceInstance__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_TreasuryTitleIconValueBackground___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_ResourceTable_GetTooltipData__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_ResourceTable_MarkerClickedEventHandler__);
		    DAT_ram_00a638f3 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = param3;
		  *(int *)(param1 + 0x30) = param2;
		  UnityEngine_UIElements_FocusController__GetFocusTargets
		            (&local_30,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_ResourceTable_ResourceInstance__GetEnumerator__)
		  ;
		  local_8 = local_20;
		  local_10 = local_28;
		  local_18 = local_30;
		  local_30 = ZEXT48(&local_18) << 0x20;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x27,&local_18,
		                       Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__MoveNext__
		                      );
		    uVar3 = local_8;
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82315714;
		    }
		    if (iVar2 == 0) goto code_r0x8231576a;
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x823156ee:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82315714;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x381,uVar6,param1,
		               Method_UI_Price_ResourceTable_MarkerClickedEventHandler__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x823156ee;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x28,uVar3,uVar6,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x823156ee;
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_Resources__BaseToolTipData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x823156f8:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82315714;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x83,uVar6,param1,
		               Method_UI_Price_ResourceTable_GetTooltipData__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x823156f8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x29,uVar3,uVar6,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x823156f8;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,uVar3,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82315714:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_30 = CONCAT44(local_30._4_4_,iVar2);
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8231576a:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = *(int *)(param1 + 0x2c);
		      iVar2 = *(int *)(iVar5 + 0xc);
		      *(undefined4 *)(iVar5 + 0xc) = 0;
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar2,0);
		      }
		      iVar5 = *(int *)(param2 + 0x224);
		      if (0 < *(int *)(iVar5 + 0xc)) {
		        iVar2 = 0;
		        do {
		          iVar5 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (iVar5,iVar2,
		                             Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Item__
		                            );
		          uVar3 = *(undefined4 *)(param1 + 0x14);
		          uVar6 = *(undefined4 *)(param1 + 0x18);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          param1_00 = func_ii_6805(uVar6,uVar3,
		                                   Method_UnityEngine_Object_Instantiate_TreasuryTitleIconValueBackground___
		                                  );
		          *(undefined4 *)(param1_00 + 0x44) = *(undefined4 *)(iVar5 + 0xc);
		          uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		          UnityEngine_Events_UnityEvent__AddListener
		                    (uVar3,param1,Method_UI_Price_ResourceTable_MarkerClickedEventHandler__,0);
		          Gameplay_UserInfo_View_TitlePlaceIconValueBackground___ctor(param1_00,uVar3,0);
		          uVar3 = unnamed_function_1417(System_Func_Resources__BaseToolTipData__TypeInfo);
		          func_ii_8070(uVar3,param1,Method_UI_Price_ResourceTable_GetTooltipData__,0);
		          Gameplay_UserInfo_View_TreasuryTitleIconValueBackground__add_ClickEvent(param1_00,uVar3,0)
		          ;
		          Google_Protobuf_Collections_RepeatedField_ulong___get_Item(param1_00,iVar2,0);
		          uVar3 = func_ii_7611(iVar5,0);
		          Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId(param1_00,uVar3,0);
		          iVar1 = Method_System_Collections_Generic_List_ResourceTable_ResourceInstance__Add__;
		          uVar3 = *(undefined4 *)(iVar5 + 0xc);
		          iVar5 = *(int *)(param1 + 0x2c);
		          *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		          lVar8 = CONCAT44(param1_00,uVar3);
		          uVar7 = *(uint *)(iVar5 + 0xc);
		          if (uVar7 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		            *(uint *)(iVar5 + 0xc) = uVar7 + 1;
		            *(longlong *)(*(int *)(iVar5 + 8) + uVar7 * 8 + 0x10) = lVar8;
		          }
		          else {
		            local_38 = lVar8;
		            local_30 = lVar8;
		            Core_Data_CollectionData__get_CollectionId
		                      (iVar5,&local_38,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          }
		          uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (param1_00,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar3,1,0);
		          iVar2 = iVar2 + 1;
		          iVar5 = *(int *)(param2 + 0x224);
		        } while (iVar2 < *(int *)(iVar5 + 0xc));
		      }
		      *(undefined1 *)(param1 + 0x24) = 1;
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x2a,&local_30);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
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
		*/

		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x5F22", Offset = "0x5F22", VA = "0x5F22")]
		public void Init(Dictionaries dict, ZigguratLevelDic zigguratLevelDic)
		{
		/* --- GHIDRA: Init ---
		void UI_Price_ResourceTable__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a638f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4335);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4336);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2171);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2337);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2169);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4342);
		    DAT_ram_00a638f4 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4342,1,0,1,0,0,0,0);
		  param1_01 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_01,0);
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4336,1,0,1,0,0,0,0);
		  func_ii_2010(param1_01,uVar1,0);
		  func_ii_2010(param1_01,StringLiteral_2337,0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt___c__DisplayClass9_0___HasNewCurrency_b__0
		                    (*(undefined4 *)(*(int *)(param1 + 0x28) + 0x14),0);
		  uVar1 = 0x7ff80000;
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar2,NAN,0,StringLiteral_2169,0,0,0);
		  func_ii_2010(param1_01,uVar2,0);
		  func_ii_2010(param1_01,StringLiteral_2171,0);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4335,1,0,1,0,0,0,0);
		  func_ii_2010(param1_01,uVar2,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_01 + 0xd8) * 4))
		                    (param1_01,CONCAT44(uVar1,*(undefined4 *)(*param1_01 + 0xdc)));
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_16790,1,0,1,0,0,0,0);
		  UI_Windows_DialogWindow__get_CANCEL_LABEL(param1_00,uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x5F23", Offset = "0x5F23", VA = "0x5F23")]
		private void MarkerClickedEventHandler()
		{
		/* --- GHIDRA: MarkerClickedEventHandler ---
		void UI_Price_ResourceTable__MarkerClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  double dVar5;
		  double dVar6;
		  undefined4 uVar7;
		  uint param2_00;
		  int iVar8;
		  uint param3_00;
		  longlong param3_01;
		  int local_2c;
		  undefined1 *puStack_28;
		  undefined8 local_24;
		  int *local_1c;
		  undefined1 local_18 [8];
		  undefined4 local_10;
		  undefined4 uStack_c;
		  int *local_8;
		  
		  iVar8 = 0;
		  param2_00 = 0;
		  if (DAT_ram_00a638f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ResourceTable_ResourceInstance__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4545);
		    DAT_ram_00a638f5 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_4545,0);
		    return;
		  }
		  *(undefined4 *)(param1 + 0x34) = param2;
		  uVar7 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x14);
		  UnityEngine_UIElements_FocusController__GetFocusTargets
		            (&local_2c,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_ResourceTable_ResourceInstance__GetEnumerator__)
		  ;
		  local_8 = local_1c;
		  local_10 = (undefined4)local_24;
		  uStack_c = (undefined4)((ulonglong)local_24 >> 0x20);
		  local_2c = 0;
		  puStack_28 = local_18;
		  do {
		    while( true ) {
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x27,local_18,
		                           Method_System_Collections_Generic_List_Enumerator_ResourceTable_ResourceInstance__MoveNext__
		                          );
		        piVar4 = local_8;
		        uVar2 = uStack_c;
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82315ec5;
		        }
		        if (iVar1 == 0) goto code_r0x82315f1b;
		        DAT_ram_009d3e38 = 0;
		        dVar5 = func_ii_6906(param2,uStack_c,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82315ec5;
		        }
		        DAT_ram_009d3e38 = 0;
		        dVar6 = func_ii_6906(uVar7,uVar2,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82315ec5;
		        }
		        DAT_ram_009d3e38 = 0;
		        if (ABS(dVar5) < 9.223372036854776e+18) {
		          param3_01 = (longlong)dVar5;
		        }
		        else {
		          param3_01 = -0x8000000000000000;
		        }
		        unnamed_function_184058
		                  (*(undefined4 *)(*piVar4 + 0xe0),piVar4,param3_01,*(undefined4 *)(*piVar4 + 0xe4))
		        ;
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82315ec5;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe2,piVar4,iVar8,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82315ec5;
		        }
		        DAT_ram_009d3e38 = 0;
		        param3_00 = (uint)(dVar6 != 0.0 && 0.75 <= dVar5 / dVar6);
		        import::env::invoke_viii
		                  (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x2b,piVar4,param3_00,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82315ec5;
		        }
		        param2_00 = param3_00 | param2_00;
		        if (*(char *)(param1 + 0x10) != '\0') break;
		        iVar8 = iVar8 + 1;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar4,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82315e29;
		      if (dVar5 == 0.0) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,1,0);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      iVar8 = iVar8 + 1;
		      if (iVar3 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x82315ec5;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,0,0);
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x82315e29:
		  DAT_ram_009d3e38 = 0;
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82315ec5:
		  iVar8 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar7);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_2c = iVar3;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x82315f1b:
		      DAT_ram_009d3e38 = 0;
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x20),param2_00,0);
		      return;
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x2c,&local_2c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    import::env::__resumeException(uVar7);
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

		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x5F24", Offset = "0x5F24", VA = "0x5F24")]
		public void UpdateResources(ResourceSet resources)
		{
		/* --- GHIDRA: UpdateResources ---
		int UI_Price_ResourceTable__UpdateResources(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 local_18;
		  float8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a638f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2169);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4340);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4339);
		    DAT_ram_00a638f6 = '\x01';
		  }
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__GetValue(*(undefined4 *)(param1 + 0x30),param2,0);
		  uVar1 = Core_Extensions_Dict_ResourcesDicExt__GetIconForPriceSpellInCombatAssetId(uVar1,0);
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  System_Text_Latin1Encoding___cctor(param1_00,uVar1,0);
		  func_ii_2010(param1_00,StringLiteral_2169,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4339,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_10 = (float8)func_ii_6906(*(undefined4 *)(param1 + 0x34),param2,0);
		  uVar3 = func_ii_7515(&local_10,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_18;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,iVar2,0);
		  func_ii_2010(param1_00,uVar1,0);
		  local_8 = (float8)func_ii_6906(*(undefined4 *)(*(int *)(param1 + 0x28) + 0x14),param2,0);
		  if (0.0 < (double)local_8) {
		    func_ii_2010(param1_00,StringLiteral_2169,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4340,1,0,1,0,0,0,0);
		    iVar2 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    uVar3 = func_ii_7515(&local_8,0);
		    local_18 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_28217,uVar3,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar2 + 0x10) = local_18;
		    uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar1,iVar2,0);
		    func_ii_2010(param1_00,uVar1,0);
		  }
		  iVar2 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar2,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  *(undefined4 *)(iVar2 + 0x1c) = uVar1;
		  return iVar2;
		}
		*/

		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x5F25", Offset = "0x5F25", VA = "0x5F25")]
		private BaseToolTipData GetTooltipData(Protocol.Consts.Resources resourceId)
		{
		/* --- GHIDRA: GetTooltipData ---
		void UI_Price_ResourceTable__GetTooltipData(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a638f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ResourceTable_ResourceInstance___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ResourceTable_ResourceInstance__TypeInfo);
		    DAT_ram_00a638f7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_ResourceTable_ResourceInstance__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_ResourceTable_ResourceInstance___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x5F26", Offset = "0x5F26", VA = "0x5F26")]
		public ResourceTable()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		UI_Price_ResourceTable___ctor(int param1,int param2,double param3,int param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (*(char *)(param1 + 0x10) != '\0') {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param2 + 4),0);
		    if (param3 == 0.0) {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,0,0);
		      *(int *)(param4 + 4) = *(int *)(param4 + 4) + -1;
		      return *(undefined4 *)(param4 + 4);
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,1,0);
		  }
		  return *(undefined4 *)(param4 + 4);
		}
		*/

		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x5F27", Offset = "0x5F27", VA = "0x5F27")]
		[CompilerGenerated]
		private int <UpdateResources>g__HandleVisibility|15_0(in ResourceTable.ResourceInstance instance, double value, ref ResourceTable.<>c__DisplayClass15_0 A_3)
		{
			return 0;
		}

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		private const float WARNING_THRESHOLD = 0.75f;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _hideZeroElements;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TreasuryTitleIconValueBackground _rowPrefab;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _marker;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _warningGroup;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x24")]
		private bool _isInit;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x28")]
		private ZigguratLevelDic _levelDic;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<ResourceTable.ResourceInstance> _instances;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x30")]
		private Dictionaries _dict;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x34")]
		private ResourceSet _currentResources;

		// Token: 0x020001C7 RID: 455
		[Token(Token = "0x20001C7")]
		private readonly struct ResourceInstance
		{
			// Token: 0x06000C15 RID: 3093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x5F28", Offset = "0x5F28", VA = "0x5F28")]
			public ResourceInstance(uint resourceId, TreasuryTitleIconValueBackground instance)
			{
			}

			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			[FieldOffset(Offset = "0x0")]
			public readonly Protocol.Consts.Resources ResourceId;

			// Token: 0x040005AF RID: 1455
			[Token(Token = "0x40005AF")]
			[FieldOffset(Offset = "0x4")]
			public readonly TreasuryTitleIconValueBackground Instance;
		}
	}
}
