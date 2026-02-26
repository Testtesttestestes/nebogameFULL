using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.ContextMenu
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	public class ContextMenuController : MonoBehaviour, IDeselectHandler, IEventSystemHandler
	{
		// Token: 0x140000F4 RID: 244
		// (add) Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F4")]
		public event Action<IBaseContextMenu> ContextMenuShowEvent
		{
			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x60EC", Offset = "0x60EC", VA = "0x60EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x60ED", Offset = "0x60ED", VA = "0x60ED")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000F5 RID: 245
		// (add) Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F5")]
		public event Action<IBaseContextMenu> ContextMenuHideEvent
		{
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x60EE", Offset = "0x60EE", VA = "0x60EE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x60EF", Offset = "0x60EF", VA = "0x60EF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E69")]
		public TMenu Show<TOptions, TMenu>(ContextMenuId menuId, TOptions options, Vector2 position) where TMenu : IContextMenu<TOptions>
		{
			return null;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x60F0", Offset = "0x60F0", VA = "0x60F0")]
		private void HideCurrentContextMenu()
		{
		/* --- GHIDRA: <Show>b__13_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType> ---
		int * UI_ContextMenu_ContextMenuController___Show_b__13_0___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                (int param1,undefined4 param2,undefined4 param3,undefined8 *param4,int param5)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  uint *puVar2;
		  float fVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined8 uVar6;
		  float fVar7;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  float fVar11;
		  float fVar12;
		  undefined8 local_58;
		  undefined4 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  float4 local_2c;
		  float4 local_28;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  float local_10;
		  float local_c;
		  undefined4 local_8;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_EventSystem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_IGuideTarget___);
		    Mono_Security_ASN1__get_Item(&UI_ContextMenu_IBaseContextMenu_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  UI_ContextMenu_ContextMenuController__remove_ContextMenuHideEvent(param1,0);
		  UI_Elements_AnimatedElements_AnimateRotation___ctor
		            (&local_20,*(undefined4 *)(param1 + 0x14),param2,0);
		  uVar1 = local_20._4_4_;
		  uVar6 = *param4;
		  if (DAT_ram_00a65d4a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Quaternion_TypeInfo);
		    DAT_ram_00a65d4a = '\x01';
		  }
		  local_18 = (*(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c))[1];
		  local_20 = **(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c);
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  local_30 = 0;
		  local_8 = 0;
		  local_40 = local_18;
		  fVar7 = (float)((ulonglong)uVar6 >> 0x20);
		  fVar12 = (float)uVar6;
		  local_48 = local_20;
		  local_38 = uVar6;
		  local_10 = fVar12;
		  local_c = fVar7;
		  uVar1 = UnityEngine_Object__Instantiate_object_
		                    (uVar1,&local_38,&local_48,uVar4,
		                     Method_UnityEngine_Object_Instantiate_GameObject___);
		  param1_00 = (int *)func_ii_6601(uVar1,**(undefined4 **)(param5 + 0x1c));
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_IGuideTarget___);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  iVar5 = *(int *)(*(int *)(param5 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  iVar9 = *param1_00;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (iVar5 == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x828b5437;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,iVar5,0);
		code_r0x828b5437:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param3,puVar2[1]);
		  *(int **)(param1 + 0x20) = param1_00;
		  if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		  }
		  uVar1 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  UnityEngine_EventSystems_EventSystem__get_baseEventDataCache(uVar1,uVar4,0);
		  iVar5 = *(int *)(param1 + 0x24);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(iVar5 + 0x14));
		  }
		  iVar5 = *(int *)(*(int *)(param5 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  iVar9 = *param1_00;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (iVar5 == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 200);
		        goto code_r0x828b551d;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,iVar5,1);
		code_r0x828b551d:
		  (**(code **)((ulonglong)*puVar2 * 4))(&local_20,param1_00,puVar2[1]);
		  uVar6 = local_20;
		  uVar10 = 0;
		  fVar3 = UnityEngine_Canvas__get_pixelRect(*(undefined4 *)(param1 + 0x18),0);
		  iVar5 = UnityEngine_RefreshRate__ToString(0);
		  iVar9 = UnityEngine_Screen__get_width(0);
		  iVar8 = *param1_00;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (UI_ContextMenu_IBaseContextMenu_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x828b55bc;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,UI_ContextMenu_IBaseContextMenu_TypeInfo,1);
		code_r0x828b55bc:
		  uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  local_24 = 0;
		  local_50 = 0;
		  local_2c = (float4)(fVar3 * (float)uVar6 * 0.5);
		  fVar11 = (float)iVar5 - (float)local_2c;
		  if (fVar12 <= (float)iVar5 - (float)local_2c) {
		    fVar11 = fVar12;
		  }
		  if ((float)local_2c <= fVar12) {
		    local_2c = (float4)fVar11;
		  }
		  local_28 = (float4)(fVar3 * (float)((ulonglong)uVar6 >> 0x20) * 0.5);
		  fVar12 = (float)iVar9 - (float)local_28;
		  if (fVar7 <= (float)iVar9 - (float)local_28) {
		    fVar12 = fVar7;
		  }
		  if ((float)local_28 <= fVar7) {
		    local_28 = (float4)fVar12;
		  }
		  local_58 = CONCAT44(local_28,local_2c);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOTime(uVar1,&local_58,0.1,0,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar4 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply(uVar4,param1,*(undefined4 *)(*(int *)(param5 + 0x1c) + 0x1c),0);
		  DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar1,uVar4,
		             Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  return param1_00;
		}
		*/

		/* --- GHIDRA: <Show>b__13_0<object, object> ---
		void UI_ContextMenu_ContextMenuController___Show_b__13_0_object__object_
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a65d48 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    DAT_ram_00a65d48 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x30);
		  if (param1_01 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x828b5224;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo
		                                  ,4);
		code_r0x828b5224:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    UnityEngine_Object__op_Implicit(param1_00,1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: HideCurrentContextMenu ---
		void UI_ContextMenu_ContextMenuController__HideCurrentContextMenu
		               (undefined4 param1,undefined4 param2)
		
		{
		  UI_ContextMenu_ContextMenuController__OnDeselect(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x60F1", Offset = "0x60F1", VA = "0x60F1")]
		public void RequestHide()
		{
		/* --- GHIDRA: RequestHide ---
		void UI_ContextMenu_ContextMenuController__RequestHide(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x2c) = 0;
		  UI_ContextMenu_ContextMenuController__remove_ContextMenuHideEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x60F2", Offset = "0x60F2", VA = "0x60F2")]
		public void ForceHide()
		{
		/* --- GHIDRA: ForceHide ---
		void UI_ContextMenu_ContextMenuController__ForceHide
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a639be == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_PointerEventData_TypeInfo);
		    DAT_ram_00a639be = '\x01';
		  }
		  UI_ContextMenu_ContextMenuController__OnDeselect(param1,param2);
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(UnityEngine_EventSystems_PointerEventData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param2 + 0xb8)) &&
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(UnityEngine_EventSystems_PointerEventData_TypeInfo + 0xb8) * 4 + -4
		                ) == UnityEngine_EventSystems_PointerEventData_TypeInfo)) {
		      *(undefined1 *)(param2 + 0x2f) = 0;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x60F3", Offset = "0x60F3", VA = "0x60F3", Slot = "4")]
		public void OnDeselect(BaseEventData eventData)
		{
		/* --- GHIDRA: OnDeselect ---
		void UI_ContextMenu_ContextMenuController__OnDeselect(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param1_00;
		  int iVar7;
		  
		  if (DAT_ram_00a639bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ContextMenu_ContextMenuController_HandleTargetAchievedStartEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a639bf = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1e8);
		        goto code_r0x82325b81;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x82325b81:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = **(int **)(iVar6 + 0x10);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x10),*(undefined4 *)(iVar7 + 0x104));
		  iVar6 = *(int *)(iVar6 + 0x24);
		  *(bool *)(param1 + 0x2c) = iVar6 == 0;
		  if (iVar6 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1e8);
		          goto code_r0x82325c57;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x82325c57:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    iVar7 = **(int **)(iVar6 + 0x10);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                      (*(int **)(iVar6 + 0x10),*(undefined4 *)(iVar7 + 0x114));
		    param1_00 = *(undefined4 *)(iVar6 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_GuideConfig__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_UI_ContextMenu_ContextMenuController_HandleTargetAchievedStartEvent__,0);
		    iVar7 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		    uVar3 = System_Action_GuideConfig__TypeInfo;
		    if (iVar7 == 0) {
		      *(undefined4 *)(iVar6 + 0x1c) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar7,System_Action_GuideConfig__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x1c) = iVar4;
		    uVar3 = System_Action_GuideConfig__TypeInfo;
		    iVar6 = func_ii_1082(iVar7,System_Action_GuideConfig__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x60F4", Offset = "0x60F4", VA = "0x60F4")]
		private void ValidateHide()
		{
		/* --- GHIDRA: ValidateHide ---
		void UI_ContextMenu_ContextMenuController__ValidateHide
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a639c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ContextMenu_ContextMenuController_HandleTargetAchievedStartEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_EventSystem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a639c0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1e8);
		        goto code_r0x82325e54;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x82325e54:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar7 = **(int **)(iVar5 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar7 + 0x114));
		  uVar6 = *(undefined4 *)(iVar5 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_GuideConfig__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_UI_ContextMenu_ContextMenuController_HandleTargetAchievedStartEvent__,0);
		  iVar7 = func_ii_7048(uVar6,uVar3,0);
		  uVar3 = System_Action_GuideConfig__TypeInfo;
		  if (iVar7 == 0) {
		    *(undefined4 *)(iVar5 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar7,System_Action_GuideConfig__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0x1c) = iVar4;
		    uVar3 = System_Action_GuideConfig__TypeInfo;
		    iVar5 = func_ii_1082(iVar7,System_Action_GuideConfig__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor(param2,0);
		  if (*(int *)(*(int *)(iVar5 + 0x24) + 0xc) == 2) {
		    if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		    }
		    uVar3 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    UnityEngine_EventSystems_EventSystem__get_baseEventDataCache(uVar3,uVar6,0);
		    return;
		  }
		  *(undefined1 *)(param1 + 0x2c) = 1;
		  return;
		}
		*/

		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x60F5", Offset = "0x60F5", VA = "0x60F5")]
		private void HandleTargetAchievedStartEvent(GuideConfig config)
		{
		/* --- GHIDRA: HandleTargetAchievedStartEvent ---
		void UI_ContextMenu_ContextMenuController__HandleTargetAchievedStartEvent
		               (int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x2c) != '\0') {
		    UI_ContextMenu_ContextMenuController__remove_ContextMenuHideEvent(param1,param1);
		  }
		  *(undefined1 *)(param1 + 0x2c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x60F6", Offset = "0x60F6", VA = "0x60F6")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x60F7", Offset = "0x60F7", VA = "0x60F7")]
		public ContextMenuController()
		{
		}

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ContextMenuConfiguration _config;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x1C")]
		private ContextMenuController _instance;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x20")]
		private IBaseContextMenu _currentContextMenu;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x2C")]
		private bool _wasDeselected;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x30")]
		public IGuideTarget GuideTarget;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ContextMenuShowEvent ---
		void UI_ContextMenu_ContextMenuController__add_ContextMenuShowEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseContextMenu__TypeInfo);
		    DAT_ram_00a639ba = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseContextMenu__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseContextMenu__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ContextMenuShowEvent ---
		void UI_ContextMenu_ContextMenuController__remove_ContextMenuShowEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseContextMenu__TypeInfo);
		    DAT_ram_00a639bb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseContextMenu__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseContextMenu__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ContextMenuHideEvent ---
		void UI_ContextMenu_ContextMenuController__add_ContextMenuHideEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseContextMenu__TypeInfo);
		    DAT_ram_00a639bc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseContextMenu__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseContextMenu__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ContextMenuHideEvent ---
		void UI_ContextMenu_ContextMenuController__remove_ContextMenuHideEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a639bd == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ContextMenu_IBaseContextMenu_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639bd = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x20);
		  if (piVar4 != (int *)0x0) {
		    iVar5 = *(int *)(param1 + 0x28);
		    if (iVar5 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),piVar4,*(undefined4 *)(iVar5 + 0x14));
		      piVar4 = *(int **)(param1 + 0x20);
		    }
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (UI_ContextMenu_IBaseContextMenu_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)
		           ) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x823259e3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,UI_ContextMenu_IBaseContextMenu_TypeInfo,1);
		code_r0x823259e3:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    func_ii_8007(uVar3,0,0);
		    piVar4 = *(int **)(param1 + 0x20);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (UI_ContextMenu_IBaseContextMenu_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)
		           ) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82325a6f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,UI_ContextMenu_IBaseContextMenu_TypeInfo,0);
		code_r0x82325a6f:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar3,0);
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: Show<object, object> ---
		void UI_ContextMenu_ContextMenuController__Show_object__object_
		               (int param1,undefined4 param2,undefined4 ****param3,undefined8 *param4,
		               undefined4 param5,int param6)
		
		{
		  ushort uVar1;
		  float fVar2;
		  undefined4 uVar3;
		  float *pfVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int param3_00;
		  int iVar9;
		  float fVar10;
		  float fVar11;
		  float fVar12;
		  undefined4 uVar13;
		  undefined4 *puVar14;
		  undefined8 uVar15;
		  uint uVar16;
		  int iVar17;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  float4 local_34;
		  float4 local_30;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 ***local_14;
		  float local_10;
		  float local_c;
		  undefined4 local_8;
		  
		  iVar6 = *(int *)(param6 + 0x1c);
		  local_14 = param3;
		  if (iVar6 == 0) {
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_EventSystem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_IGuideTarget___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    iVar6 = *(int *)(param6 + 0x1c);
		    if (iVar6 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param6);
		      iVar6 = *(int *)(param6 + 0x1c);
		    }
		  }
		  iVar7 = *(int *)(*(int *)(iVar6 + 8) + 0x84);
		  iVar8 = *(int *)(iVar6 + 4);
		  param3_00 = *(int *)(iVar8 + 0x84);
		  uVar1 = *(ushort *)(iVar8 + 0xbd);
		  iVar6 = param3_00;
		  if ((uVar1 & 1) == 0) {
		    iVar6 = func_ii_1079(iVar8);
		    iVar8 = *(int *)(*(int *)(param6 + 0x1c) + 4);
		    uVar1 = *(ushort *)(iVar8 + 0xbd);
		    iVar6 = *(int *)(iVar6 + 0x84);
		  }
		  iVar9 = (int)&local_60 - (iVar6 + 0x17U & 0xfffffff0);
		  iVar6 = iVar8;
		  if ((uVar1 & 1) == 0) {
		    iVar6 = func_ii_1079(iVar8);
		    iVar8 = *(int *)(*(int *)(param6 + 0x1c) + 4);
		    uVar1 = *(ushort *)(iVar8 + 0xbd);
		  }
		  iVar6 = iVar9 - (*(int *)(iVar6 + 0x84) + 0x17U & 0xfffffff0);
		  if ((uVar1 & 1) == 0) {
		    iVar8 = func_ii_1079(iVar8);
		  }
		  iVar8 = iVar6 - (*(int *)(iVar8 + 0x84) + 0x17U & 0xfffffff0);
		  fVar10 = (float)(iVar8 - (iVar7 + 0xfU & 0xfffffff0));
		  uVar16 = param3_00 + 0xfU & 0xfffffff0;
		  fVar11 = (float)((int)fVar10 - uVar16);
		  UI_ContextMenu_ContextMenuController__remove_ContextMenuHideEvent(param1,0);
		  UI_Elements_AnimatedElements_AnimateRotation___ctor
		            (&local_28,*(undefined4 *)(param1 + 0x14),param2,0);
		  uVar3 = local_28._4_4_;
		  uVar15 = *param4;
		  if (DAT_ram_00a65d4a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Quaternion_TypeInfo);
		    DAT_ram_00a65d4a = '\x01';
		  }
		  fVar12 = (float)((ulonglong)uVar15 >> 0x20);
		  fVar2 = (float)uVar15;
		  local_20 = (*(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c))[1];
		  local_28 = **(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c);
		  uVar13 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  local_38 = 0;
		  local_8 = 0;
		  local_48 = local_20;
		  local_50 = local_28;
		  local_40 = uVar15;
		  local_10 = fVar2;
		  local_c = fVar12;
		  uVar3 = UnityEngine_Object__Instantiate_object_
		                    (uVar3,&local_40,&local_50,uVar13,
		                     Method_UnityEngine_Object_Instantiate_GameObject___);
		  puVar14 = (undefined4 *)**(int **)(param6 + 0x1c);
		  local_10 = fVar11;
		  (**(code **)((ulonglong)(uint)puVar14[2] * 4))(*puVar14,puVar14,uVar3,&local_10,fVar11);
		  uVar13 = unnamed_function_713(((int)fVar11 - uVar16) - uVar16,fVar11,param3_00);
		  uVar3 = func_ii_6601(uVar3,Method_UnityEngine_GameObject_GetComponent_IGuideTarget___);
		  *(undefined4 *)(param1 + 0x30) = uVar3;
		  iVar17 = *(int *)(param6 + 0x1c);
		  if (-1 < *(int *)(*(int *)(iVar17 + 8) + 0x14)) {
		    param3 = &local_14;
		  }
		  pfVar4 = (float *)unnamed_function_713(fVar10,param3,iVar7);
		  iVar7 = *(int *)(iVar17 + 4);
		  if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		    iVar7 = func_ii_1079(iVar7);
		    iVar17 = *(int *)(param6 + 0x1c);
		  }
		  if (-1 < *(int *)(*(int *)(iVar17 + 8) + 0x14)) {
		    fVar10 = *pfVar4;
		  }
		  local_10 = fVar10;
		  func_ii_8296(iVar7,*(undefined4 *)(iVar17 + 0x10),iVar9,uVar13,&local_10,fVar10);
		  uVar3 = unnamed_function_713((int)fVar11 - uVar16,uVar13,param3_00);
		  uVar3 = func_ii_1081(*(undefined4 *)(*(int *)(param6 + 0x1c) + 4),uVar3);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		  }
		  uVar3 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  UnityEngine_EventSystems_EventSystem__get_baseEventDataCache(uVar3,uVar5,0);
		  iVar7 = *(int *)(param1 + 0x24);
		  if (iVar7 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(iVar7 + 0x14));
		  }
		  iVar7 = *(int *)(param6 + 0x1c);
		  iVar9 = *(int *)(iVar7 + 4);
		  if ((*(byte *)(iVar9 + 0xbd) & 1) == 0) {
		    iVar9 = func_ii_1079(iVar9);
		    iVar7 = *(int *)(param6 + 0x1c);
		  }
		  func_ii_8296(iVar9,*(undefined4 *)(iVar7 + 0x14),iVar6,uVar13,0,&local_28);
		  uVar15 = local_28;
		  fVar10 = UnityEngine_Canvas__get_pixelRect(*(undefined4 *)(param1 + 0x18),0);
		  iVar9 = UnityEngine_RefreshRate__ToString(0);
		  iVar17 = UnityEngine_Screen__get_width(0);
		  iVar6 = *(int *)(param6 + 0x1c);
		  iVar7 = *(int *)(iVar6 + 4);
		  if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		    iVar7 = func_ii_1079(iVar7);
		    iVar6 = *(int *)(param6 + 0x1c);
		  }
		  func_ii_8296(iVar7,*(undefined4 *)(iVar6 + 0x18),iVar8,uVar13,0,&local_28);
		  local_2c = 0;
		  local_58 = 0;
		  local_34 = (float4)(fVar10 * (float)uVar15 * 0.5);
		  fVar11 = (float)iVar9 - (float)local_34;
		  if (fVar2 <= (float)iVar9 - (float)local_34) {
		    fVar11 = fVar2;
		  }
		  if ((float)local_34 <= fVar2) {
		    local_34 = (float4)fVar11;
		  }
		  local_30 = (float4)(fVar10 * (float)((ulonglong)uVar15 >> 0x20) * 0.5);
		  fVar10 = (float)iVar17 - (float)local_30;
		  if (fVar12 <= (float)iVar17 - (float)local_30) {
		    fVar10 = fVar12;
		  }
		  if ((float)local_30 <= fVar12) {
		    local_30 = (float4)fVar10;
		  }
		  local_60 = CONCAT44(local_30,local_34);
		  uVar3 = DG_Tweening_ShortcutExtensions__DOTime((undefined4)local_28,&local_60,0.1,0,0);
		  uVar3 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar3,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar5 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply(uVar5,param1,*(undefined4 *)(*(int *)(param6 + 0x1c) + 0x1c),0);
		  DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar3,uVar5,
		             Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  unnamed_function_713(param5,uVar13,param3_00);
		  return;
		}
		*/


		/* --- GHIDRA: Show<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType> ---
		uint UI_ContextMenu_ContextMenuController__Show___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		               (int *param1,int param2,int param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  uVar1 = 0;
		  if (*(int *)(param3 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    if (*(int *)(param3 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		    }
		  }
		  if (param1 == (int *)0x0) {
		    uVar6 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar6 = unnamed_function_1417(uVar6);
		    uVar7 = unnamed_function_2232(&StringLiteral_21404);
		    Mono_Security_X509_X509Certificate___ctor(uVar6,uVar7,0);
		    func_ii_1050(uVar6,param3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param2 == 0) {
		    uVar6 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar6 = unnamed_function_1417(uVar6);
		    uVar7 = unnamed_function_2232(&StringLiteral_26138);
		    Mono_Security_X509_X509Certificate___ctor(uVar6,uVar7,0);
		    func_ii_1050(uVar6,param3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar8 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		    iVar8 = func_ii_1079(iVar8);
		  }
		  iVar10 = *param1;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (iVar8 == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x828b5c49;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1,iVar8,0);
		code_r0x828b5c49:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param1,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x828b5d19;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x828b5d5d:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x828b5ef0:
		      iVar8 = global_1;
		      iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar10) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar6);
		        iVar10 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar10;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        uVar1 = 1;
		        if (iVar8 != 1) goto code_r0x828b5f3b;
		        uVar6 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000051d5 + 4,&local_c);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x828b5d19:
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x828b5d5d;
		    if (uVar1 == 0) break;
		    iVar8 = *(int *)(*(int *)(param3 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar8);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x828b5db9;
		code_r0x828b5eca:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x828b5ef0;
		    }
		code_r0x828b5db9:
		    iVar10 = *piVar5;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		        if (iVar8 == *piVar9) {
		          puVar4 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x828b5e3f;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,iVar8,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x828b5eca;
		code_r0x828b5e3f:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x828b5eca;
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iiii
		                       (*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x20),uVar6,
		                        *(undefined4 *)(param2 + 0x14));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x828b5ef0;
		    }
		  } while (iVar10 != 0);
		  uVar1 = uVar1 ^ 1;
		  iVar10 = 0;
		code_r0x828b5f3b:
		  piVar5 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar2 = 0;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x828b5fb3;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x828b5fb3:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  }
		  if (iVar10 == 0) {
		    return uVar1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
