using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.ContextMenu;
using UI.UserContextMenu.ContextElements;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UserContextMenu
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public class UserContextMenu : MonoBehaviour, IContextMenu<IUserMenuContext>, IBaseContextMenu
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		public IUserMenuContext Context
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x5C93", Offset = "0x5C93", VA = "0x5C93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x5C94", Offset = "0x5C94", VA = "0x5C94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x5C95", Offset = "0x5C95", VA = "0x5C95")]
		public static List<AbstractUserContextMenuElement> GetAllElements()
		{
		/* --- GHIDRA: GetAllElements ---
		void UI_UserContextMenu_UserContextMenu__GetAllElements
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  uint *puVar6;
		  int param1_01;
		  int iVar7;
		  int *param1_02;
		  int iVar8;
		  uint uVar9;
		  int param2_00;
		  undefined8 local_90;
		  undefined4 local_88;
		  undefined8 local_80;
		  undefined4 local_78;
		  undefined8 local_70;
		  undefined4 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  uint local_34;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined4 local_28;
		  int *piStack_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5b8bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractUserContextMenuElement__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractUserContextMenuElement__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractUserContextMenuElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_AbstractUserContextMenuElement__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_UserContextMenu_UserContextMenu_ElementOnSelectEvent__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10018);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10017);
		    DAT_ram_00a5b8bd = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  *(undefined4 *)(param1 + 0x28) = param2;
		  uVar2 = UI_UserContextMenu_UserContextMenu__set_Context(param2);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,uVar2,
		             Method_System_Collections_Generic_List_AbstractUserContextMenuElement__GetEnumerator__)
		  ;
		  local_8._4_4_ = piStack_24;
		  local_10 = CONCAT44(puStack_2c,local_30);
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AbstractUserContextMenuElement__MoveNext__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8138d354;
		    }
		    if (iVar3 == 0) goto code_r0x8138d3aa;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*local_8._4_4_ + 0xf0),local_8._4_4_,*(undefined4 *)(param1 + 0x28),
		               *(undefined4 *)(*local_8._4_4_ + 0xf4));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8138d354:
		  iVar8 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar3;
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
		code_r0x8138d3aa:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = unnamed_function_1417
		                            (
		                            System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__TypeInfo
		                            );
		      System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		                (param1_00,
		                 Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement___ctor__
		                );
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,uVar2,
		                 Method_System_Collections_Generic_List_AbstractUserContextMenuElement__GetEnumerator__
		                );
		      local_8._4_4_ = piStack_24;
		      local_10 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_10;
		code_r0x8138d440:
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                             Method_System_Collections_Generic_List_Enumerator_AbstractUserContextMenuElement__MoveNext__
		                            );
		          piVar5 = local_8._4_4_;
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8138d807;
		          }
		          if (iVar3 == 0) goto code_r0x8138d85d;
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iiii
		                            (*(undefined4 *)(*local_8._4_4_ + 0xe8),local_8._4_4_,
		                             *(undefined4 *)(param1 + 0x28),*(undefined4 *)(*local_8._4_4_ + 0xec));
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8138d807;
		          }
		        } while (iVar3 == 0);
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,param1_00,
		                           piVar5[3],
		                           Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__ContainsKey__
		                          );
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8138d807;
		        }
		        uVar9 = piVar5[3];
		        if (iVar3 == 0) {
		          if ((uVar9 != 0) &&
		             ((longlong)(ulonglong)uVar9 <= (longlong)*(int *)(*(int *)(param1 + 0x1c) + 0xc))) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,param1_00,uVar9,
		                       piVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__Add__
		                      );
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x8138d807;
		            }
		            goto code_r0x8138d440;
		          }
		          iVar3 = piVar5[2];
		          DAT_ram_009d3e38 = 0;
		          local_34 = uVar9;
		          uVar2 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958
		                             ,&local_34);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8138d807;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,
		                             StringLiteral_10017,iVar3,uVar2,0);
		          if (DAT_ram_009d3e38 != 1) {
		            if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         OKG_Logs_Debug_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x8138d77e;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc5,uVar2,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x8138d440;
		          }
		code_r0x8138d77e:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8138d807;
		        }
		        DAT_ram_009d3e38 = 0;
		        local_34 = uVar9;
		        uVar2 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                           &local_34);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8138d807;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param1_00,
		                           piVar5[3],
		                           Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__get_Item__
		                          );
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8138d807;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiiiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x24e,
		                           StringLiteral_10018,uVar2,*(undefined4 *)(iVar3 + 8),piVar5[2],0);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,OKG_Logs_Debug_TypeInfo
		                    );
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x310,uVar2,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8138d807:
		      iVar8 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar3;
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
		code_r0x8138d85d:
		          DAT_ram_009d3e38 = 0;
		          uVar9 = 0;
		          piVar5 = *(int **)(param1 + 0x14);
		          param1_02 = *(int **)(param1 + 0x28);
		          iVar8 = *param1_02;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            do {
		              if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		                  *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		                puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x8138d8d6;
		              }
		              uVar9 = uVar9 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		          }
		          puVar6 = (uint *)func_ii_1080(param1_02,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138d8d6:
		          uVar9 = 0;
		          uVar2 = (**(code **)((ulonglong)*puVar6 * 4))(param1_02,puVar6[1]);
		          uVar2 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(uVar2,0);
		          iVar8 = *piVar5;
		          (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		                    (piVar5,uVar2,*(undefined4 *)(iVar8 + 0x2d4));
		          uVar2 = *(undefined4 *)(param1 + 0x18);
		          piVar5 = *(int **)(param1 + 0x28);
		          iVar8 = *piVar5;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            do {
		              if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		                  *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		                puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x8138d97c;
		              }
		              uVar9 = uVar9 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		          }
		          puVar6 = (uint *)func_ii_1080(piVar5,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138d97c:
		          uVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          Gameplay_Rating_View_UserView__get_UserData(uVar2,uVar4,0);
		          uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(param1 + 0x10),0);
		          if (DAT_ram_00a65020 == '\0') {
		            Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		            DAT_ram_00a65020 = '\x01';
		          }
		          local_60 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		          local_58 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		          local_40 = local_60;
		          local_38 = local_58;
		          Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar2,&local_60,0);
		          uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(param1 + 0x10),0);
		          if (DAT_ram_00a6501f == '\0') {
		            Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		            DAT_ram_00a6501f = '\x01';
		          }
		          local_68 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		          local_70 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		          uVar2 = System_Collections_Generic_Queue_object___Dequeue(uVar2,&local_70,0.1,0);
		          DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,0x1b,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		          iVar8 = *(int *)(param1 + 0x1c);
		          if (0 < *(int *)(iVar8 + 0xc)) {
		            do {
		              iVar3 = *(int *)(iVar8 + param2_00 * 4 + 0x10);
		              param2_00 = param2_00 + 1;
		              iVar8 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                                (param1_00,param2_00,&local_14,
		                                 Method_System_Collections_Generic_Dictionary_uint__AbstractUserContextMenuElement__TryGetValue__
		                                );
		              if (iVar8 != 0) {
		                uVar2 = unnamed_function_1417(System_Action_UserContextMenuElement__TypeInfo);
		                UnityEngine_UIElements_VisualElement__get_layout
		                          (uVar2,param1,
		                           Method_UI_UserContextMenu_UserContextMenu_ElementOnSelectEvent__,0);
		                if (DAT_ram_00a5b8c1 == '\0') {
		                  Mono_Security_ASN1__get_Item(&System_Action_UserContextMenuElement__TypeInfo);
		                  DAT_ram_00a5b8c1 = '\x01';
		                }
		                iVar8 = *(int *)(iVar3 + 0x2c);
		                do {
		                  iVar7 = 0;
		                  param1_01 = UnityEngine_UI_Image__set_sprite(iVar8,uVar2,0);
		                  uVar4 = System_Action_UserContextMenuElement__TypeInfo;
		                  if ((param1_01 != 0) &&
		                     (iVar7 = func_ii_1082(param1_01,System_Action_UserContextMenuElement__TypeInfo)
		                     , iVar7 == 0)) {
		                    System_Activator__CreateInstance(param1_01,uVar4);
		                    do {
		                      halt_trap();
		                    } while( true );
		                  }
		                  iVar7 = func_ii_4329(iVar3 + 0x2c,iVar7,iVar8);
		                  bVar1 = iVar7 != iVar8;
		                  iVar8 = iVar7;
		                } while (bVar1);
		              }
		              uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                (iVar3,0);
		              UnityEngine_Transform___ctor(&local_30,uVar2,0);
		              local_18 = local_28;
		              local_20 = CONCAT44(puStack_2c,local_30);
		              uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                (iVar3,0);
		              if (DAT_ram_00a65020 == '\0') {
		                Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		                DAT_ram_00a65020 = '\x01';
		              }
		              local_80 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		              local_78 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		              local_50 = local_80;
		              local_48 = local_78;
		              Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar2,&local_80,0);
		              uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                (iVar3,0);
		              local_88 = local_18;
		              local_90 = local_20;
		              uVar2 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar2,&local_90,0.1,0,0);
		              uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                                (uVar2,6,
		                                 Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                                );
		              DG_Tweening_DOTweenModuleUI__DOFade
		                        (uVar2,0.02,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		                        );
		              UI_UserContextMenu_UserContextMenuElement__get_AbstractContextMenuElement
		                        (iVar3,local_14,&local_18);
		              iVar8 = *(int *)(param1 + 0x1c);
		            } while (param2_00 < *(int *)(iVar8 + 0xc));
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x16b,&local_30);
		      goto joined_r0x8138dc84;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x16a,&local_30);
		joined_r0x8138dc84:
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
		*/

			return null;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x5C96", Offset = "0x5C96", VA = "0x5C96", Slot = "4")]
		public void Show(IUserMenuContext context)
		{
		/* --- GHIDRA: Show ---
		void UI_UserContextMenu_UserContextMenu__Show(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param2 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf8) * 4))
		            (*(int **)(param2 + 0x30),*(undefined4 *)(param1 + 0x28),*(undefined4 *)(iVar1 + 0xfc));
		  return;
		}
		*/

		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x5C97", Offset = "0x5C97", VA = "0x5C97")]
		private void ElementOnSelectEvent(UserContextMenuElement element)
		{
		/* --- GHIDRA: ElementOnSelectEvent ---
		void UI_UserContextMenu_UserContextMenu__ElementOnSelectEvent(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  undefined4 uVar3;
		  int iVar4;
		  int param1_02;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5b8be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_UserContextMenu_UserContextMenu_ElementOnSelectEvent__);
		    DAT_ram_00a5b8be = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      param1_02 = *(int *)(iVar4 + iVar5 * 4 + 0x10);
		      uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1_02,0);
		      if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		        func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		      }
		      DG_Tweening_DOTween__KillAll(uVar3,0,0);
		      uVar3 = unnamed_function_1417(System_Action_UserContextMenuElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,Method_UI_UserContextMenu_UserContextMenu_ElementOnSelectEvent__,0);
		      if (DAT_ram_00a5b8c2 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_UserContextMenuElement__TypeInfo);
		        DAT_ram_00a5b8c2 = '\x01';
		      }
		      param1_00 = *(int *)(param1_02 + 0x2c);
		      do {
		        iVar2 = 0;
		        param1_01 = func_ii_7048(param1_00,uVar3,0);
		        param2_00 = System_Action_UserContextMenuElement__TypeInfo;
		        if ((param1_01 != 0) &&
		           (iVar2 = func_ii_1082(param1_01,System_Action_UserContextMenuElement__TypeInfo),
		           iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_01,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(param1_02 + 0x2c,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar4 + 0xc));
		  }
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  func_ii_8007(uVar3,0,0);
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x5C98", Offset = "0x5C98", VA = "0x5C98")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_UserContextMenu_UserContextMenu__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5b8bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b8bf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x2c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x140000D1 RID: 209
		// (add) Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600091B RID: 2331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D1")]
		public event Action CloseEvent
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x5C99", Offset = "0x5C99", VA = "0x5C99")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x5C9A", Offset = "0x5C9A", VA = "0x5C9A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x17000127")]
		public Vector2 MenuSize
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x5C9B", Offset = "0x5C9B", VA = "0x5C9B", Slot = "5")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000128")]
		public GameObject GameObject
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x5C9C", Offset = "0x5C9C", VA = "0x5C9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x5C9D", Offset = "0x5C9D", VA = "0x5C9D")]
		public UserContextMenu()
		{
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x5C9E", Offset = "0x5C9E", VA = "0x5C9E", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x5C9F", Offset = "0x5C9F", VA = "0x5C9F", Slot = "7")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		public const ContextMenuId MenuId = ContextMenuId.Users;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _itemTitleLabel;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserView _itemView;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UserContextMenuElement[] _elements;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _menuSize;

		// Token: 0x02000128 RID: 296
		[Token(Token = "0x2000128")]
		public class MenuContext : IUserMenuContext
		{
			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000921 RID: 2337 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000129")]
			public UserData User
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0x5CA0", Offset = "0x5CA0", VA = "0x5CA0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000922")]
				[Address(RVA = "0x5CA1", Offset = "0x5CA1", VA = "0x5CA1", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x5CA2", Offset = "0x5CA2", VA = "0x5CA2")]
			public MenuContext()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Context ---
		int UI_UserContextMenu_UserContextMenu__set_Context(undefined4 param1)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a5b8bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Chat_Model_Data_ContextMenu_Elements_AddToFavoriteContextMenuElement_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_Elements_ChatReport_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractUserContextMenuElement___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_AbstractUserContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_Model_Data_ContextMenu_Elements_MessageToUser_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_Model_Data_ContextMenu_Elements_PrivatMessageToUser_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_UserContextMenu_ContextElements_ProfileUserContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_Model_Data_ContextMenu_Elements_RejectReport_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_Model_Data_ContextMenu_Elements_RemoveFromFavorite_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_Model_ContextMenu_Elements_RemoveFromTeamElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_UserContextMenu_ContextElements_SendGiftContextMenuElement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement_TypeInfo);
		    DAT_ram_00a5b8bc = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_AbstractUserContextMenuElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_AbstractUserContextMenuElement___ctor__);
		  uVar2 = unnamed_function_1417
		                    (UI_UserContextMenu_ContextElements_ProfileUserContextMenuElement_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (UI_UserContextMenu_ContextElements_SendGiftContextMenuElement_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Chat_Model_Data_ContextMenu_Elements_AddToFavoriteContextMenuElement_TypeInfo
		                    );
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Chat_Model_Data_ContextMenu_Elements_RemoveFromFavorite_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Chat_Model_Data_ContextMenu_Elements_PrivatMessageToUser_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Chat_Model_Data_ContextMenu_Elements_MessageToUser_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Chat_Model_Data_ContextMenu_Elements_ChatReport_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Chat_Model_Data_ContextMenu_Elements_RejectReport_TypeInfo)
		  ;
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Boss_Model_ContextMenu_Elements_RemoveFromTeamElement_TypeInfo);
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement_TypeInfo
		                    );
		  iVar1 = Method_System_Collections_Generic_List_AbstractUserContextMenuElement__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return param1_00;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return param1_00;
		}
		*/


		/* --- GHIDRA: add_CloseEvent ---
		void UI_UserContextMenu_UserContextMenu__add_CloseEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5b8c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b8c0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x2c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
