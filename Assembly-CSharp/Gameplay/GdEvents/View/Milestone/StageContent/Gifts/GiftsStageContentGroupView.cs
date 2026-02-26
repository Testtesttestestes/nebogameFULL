using System;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Gifts
{
	// Token: 0x0200072D RID: 1837
	[Token(Token = "0x200072D")]
	public class GiftsStageContentGroupView : AbstractStageContentGroupView<SocialGiftDic>
	{
		// Token: 0x06002BE2 RID: 11234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x7C73", Offset = "0x7C73", VA = "0x7C73")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView__OnDestroy
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int param1_00;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  
		  iVar9 = 0;
		  if (DAT_ram_00a5a282 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_SocialGiftDic__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SocialGiftDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView_HandleClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GiftView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a282 = '\x01';
		  }
		  if ((param3 != 0) && (iVar4 = *(int *)(param3 + 8), 0 < *(int *)(iVar4 + 0xc))) {
		    do {
		      iVar5 = *(int *)(iVar4 + iVar9 * 4 + 0x10);
		      uVar6 = *(undefined4 *)(param1 + 0x14);
		      uVar7 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar3 = func_ii_6805(uVar7,uVar6,Method_UnityEngine_Object_Instantiate_GiftView___);
		      if ((*(int *)(iVar3 + 0x1c) != iVar5) && (*(int *)(iVar3 + 0x1c) = iVar5, iVar5 != 0)) {
		        piVar8 = *(int **)(iVar3 + 0x10);
		        uVar6 = Core_Extensions_Dict_SocialGiftDicExt__GetIconAssetId(iVar5,0);
		        iVar2 = *piVar8;
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		                  (piVar8,uVar6,*(undefined4 *)(iVar2 + 0x2d4));
		        uVar7 = *(undefined4 *)(iVar3 + 0x14);
		        uVar6 = Core_Extensions_Dict_SlotMachineSymbolDicExt__GetIconAssetId
		                          (*(undefined4 *)(iVar3 + 0x1c),0);
		        Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar7,uVar6,0);
		      }
		      if (*(char *)(iVar5 + 0x14) != '\0') {
		        uVar6 = unnamed_function_1417(System_Action_SocialGiftDic__TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar6,param1,
		                   Method_Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView_HandleClickEvent__
		                   ,0);
		        if (DAT_ram_00a5a27f == '\0') {
		          Mono_Security_ASN1__get_Item(&System_Action_SocialGiftDic__TypeInfo);
		          DAT_ram_00a5a27f = '\x01';
		        }
		        iVar5 = *(int *)(iVar3 + 0x18);
		        do {
		          iVar2 = 0;
		          param1_00 = UnityEngine_UI_Image__set_sprite(iVar5,uVar6,0);
		          uVar7 = System_Action_SocialGiftDic__TypeInfo;
		          if ((param1_00 != 0) &&
		             (iVar2 = func_ii_1082(param1_00,System_Action_SocialGiftDic__TypeInfo), iVar2 == 0)) {
		            System_Activator__CreateInstance(param1_00,uVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          iVar2 = func_ii_4329(iVar3 + 0x18,iVar2,iVar5);
		          bVar1 = iVar2 != iVar5;
		          iVar5 = iVar2;
		        } while (bVar1);
		      }
		      iVar9 = iVar9 + 1;
		    } while (iVar9 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x7C74", Offset = "0x7C74", VA = "0x7C74", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<SocialGiftDic> fromData, StageContentData<SocialGiftDic> toData)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView__HandleDataChanged
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a283 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_GdEvents_View_GiftWindow_GiftWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GiftWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12624);
		    DAT_ram_00a5a283 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x811f2869;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x811f2869:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x811f28eb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x811f28eb:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = unnamed_function_1417(Gameplay_Gifts_GdEvents_View_GiftWindow_GiftWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(iVar4,0);
		  *(undefined4 *)(iVar4 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12624,iVar4,
		             Method_UI_Windows_PopupController_Show_GiftWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x7C75", Offset = "0x7C75", VA = "0x7C75")]
		private void HandleClickEvent(SocialGiftDic data)
		{
		/* --- GHIDRA: HandleClickEvent ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView__HandleClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a284 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_SocialGiftDic___ctor__
		              );
		    DAT_ram_00a5a284 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_SocialGiftDic___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x7C76", Offset = "0x7C76", VA = "0x7C76")]
		public GiftsStageContentGroupView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a285 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_CollectionData__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Collections_CollectionsStageContentGroupView_HandleItemClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5a285 = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x811f2a9b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f2d59:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f2d61;
		    }
		code_r0x811f2a9b:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f2d59;
		    if (iVar7 == 0) goto code_r0x811f2daa;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x811f2b78;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f2d27:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f2d61;
		    }
		code_r0x811f2b78:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f2d27;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f2d61;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f2d61;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x202,uVar3,
		                       Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f2d61;
		    }
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_PointerEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,param2_00,param1,
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Collections_CollectionsStageContentGroupView_HandleItemClickEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21,uVar3,param2_00,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f2d61:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x811f2daa:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811f2e3a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x811f2e3a:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x281,&local_14);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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

		}

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GiftView _giftPrefab;
	}
}
