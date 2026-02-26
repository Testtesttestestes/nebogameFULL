using System;
using System.Runtime.InteropServices;
using AssetContent;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations;
using UnityEngine;
using Utils;

namespace Gameplay.Portals.View.Balance
{
	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	public class PortalsBalanceView : MonoBehaviour
	{
		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006A0")]
		private CanvasGroup CanvasGroup
		{
			[Token(Token = "0x600238A")]
			[Address(RVA = "0x74DC", Offset = "0x74DC", VA = "0x74DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x74DD", Offset = "0x74DD", VA = "0x74DD")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Portals_View_Balance_PortalsBalanceView__Awake(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param1_00;
		  uint uVar5;
		  undefined8 uVar6;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58119 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    DAT_ram_00a58119 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea477c;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea477c:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  iVar4 = *(int *)(iVar4 + 0x10);
		  *(int *)(param1 + 0x24) = iVar4;
		  iVar4 = *(int *)(iVar4 + 0x10);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),(uint)(iVar4 != 0),0);
		  if (iVar4 != 0) {
		    iVar4 = *(int *)(param1 + 0x1c);
		    uVar2 = Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		                      (*(undefined4 *)(*(int *)(param1 + 0x24) + 0x3c),0xc3,0);
		    *(undefined4 *)(iVar4 + 0x28) = uVar2;
		    iVar4 = *(int *)(param1 + 0x24);
		    if (*(int *)(iVar4 + 0x10) != 0) {
		      param1_00 = *(undefined4 *)(param1 + 0x18);
		      uVar2 = Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon32(*(undefined4 *)(iVar4 + 0x3c),0);
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar2,0);
		    }
		    local_8 = 0;
		    local_30 = 0;
		    local_10 = 0;
		    local_38 = 0;
		    Gameplay_Portals_View_Balance_PortalsBalanceView__UserInfoChanged(param1,&local_38,iVar4);
		    Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x28),0);
		    if (DAT_ram_00a58117 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		      DAT_ram_00a58117 = '\x01';
		    }
		    if (*(int *)(param1 + 0x20) == 0) {
		      uVar2 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		      *(undefined4 *)(param1 + 0x20) = uVar2;
		    }
		    else {
		      uVar2 = *(undefined4 *)(param1 + 0x20);
		    }
		    UnityEngine_CanvasGroup__get_alpha(uVar2,0.0,0);
		    if (DAT_ram_00a58117 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		      DAT_ram_00a58117 = '\x01';
		    }
		    if (*(int *)(param1 + 0x20) == 0) {
		      uVar2 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		      *(undefined4 *)(param1 + 0x20) = uVar2;
		    }
		    else {
		      uVar2 = *(undefined4 *)(param1 + 0x20);
		    }
		    uVar2 = Core_Animations_GameSpineUiAnimation__Play(uVar2,1.0,0.5,0);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar2,6,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                      );
		    Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x28),uVar2,0);
		    piVar3 = (int *)UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x14),0);
		    if ((piVar3 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar3)) {
		      System_Activator__CreateInstance(piVar3,UnityEngine_RectTransform_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    UnityEngine_RectTransform__set_anchorMax(&local_18,piVar3,0);
		    if (DAT_ram_00a648f4 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		      DAT_ram_00a648f4 = '\x01';
		    }
		    uVar6 = *(undefined8 *)(*(int *)(UnityEngine_Vector2_TypeInfo + 0x5c) + 0x10);
		    local_40 = CONCAT44((float)((ulonglong)uVar6 >> 0x20) * 100.0 +
		                        (float)((ulonglong)local_18 >> 0x20),(float)uVar6 * 100.0 + (float)local_18)
		    ;
		    local_20 = local_40;
		    UnityEngine_RectTransform__get_anchoredPosition(piVar3,&local_40,0);
		    local_48 = local_18;
		    local_28 = local_18;
		    uVar2 = DG_Tweening_DOTweenModuleUI__DOScale(piVar3,&local_48,0.5,0,0);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar2,6,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		                      );
		    Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x28),uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x74DE", Offset = "0x74DE", VA = "0x74DE")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Portals_View_Balance_PortalsBalanceView__Start(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = 0;
		  local_18 = 0;
		  local_10 = 0;
		  local_20 = 0;
		  Gameplay_Portals_View_Balance_PortalsBalanceView__UserInfoChanged(param1,&local_20,&local_20);
		  return;
		}
		*/

		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x74DF", Offset = "0x74DF", VA = "0x74DF")]
		private void UserInfoChanged()
		{
		/* --- GHIDRA: UserInfoChanged ---
		void Gameplay_Portals_View_Balance_PortalsBalanceView__UserInfoChanged
		               (int param1,char *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  ulonglong uVar3;
		  int *piVar4;
		  uint uVar5;
		  undefined8 param2_00;
		  int iVar6;
		  
		  if (DAT_ram_00a5811a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a5811a = '\x01';
		  }
		  if (*param2 == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar5 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar5 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar5 * 8 + 4) * 8 + iVar6 + 0x290);
		          goto code_r0x80ea4ae3;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar5);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea4ae3:
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))
		                      (CONCAT44(in_register_20000004,piVar4),
		                       CONCAT44(in_register_20000014,puVar1[1]));
		    iVar6 = *(int *)(*(int *)(iVar6 + 0x10) + 0x18);
		    if (iVar6 == 0) {
		      param2_00 = 0;
		    }
		    else {
		      param2_00 = *(undefined8 *)(iVar6 + 0x10);
		    }
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (param2,param2_00,Method_System_Nullable_ulong___ctor__);
		    in_register_20000014 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  uVar3 = System_Nullable_TimeSpan___get_HasValue(param2,Method_System_Nullable_ulong__get_Value__);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar2 = UI_SimpleIconValue__set_IconAssetId((double)uVar3,StringLiteral_28780,0);
		  iVar6 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar4,CONCAT44(in_register_20000014,uVar2),*(undefined4 *)(iVar6 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x74E0", Offset = "0x74E0", VA = "0x74E0")]
		private void DisplayCurrentBalance([Optional] ulong? balance)
		{
		/* --- GHIDRA: DisplayCurrentBalance ---
		void Gameplay_Portals_View_Balance_PortalsBalanceView__DisplayCurrentBalance
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5811b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_Balance_PortalsBalanceView_UserInfoChanged__);
		    DAT_ram_00a5811b = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea4c97;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea4c97:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  param1_01 = *(undefined4 *)(iVar5 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Portals_View_Balance_PortalsBalanceView_UserInfoChanged__,0);
		  piVar3 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x28) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x28) = piVar3, *piVar3 != iVar4)) {
		    System_Activator__CreateInstance(piVar3,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x28),0);
		  return;
		}
		*/

		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x74E1", Offset = "0x74E1", VA = "0x74E1")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Portals_View_Balance_PortalsBalanceView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (*(int *)(*(int *)(param1 + 0x24) + 0x10) != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x18);
		    param2_00 = Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon32
		                          (*(undefined4 *)(*(int *)(param1 + 0x24) + 0x3c),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x74E2", Offset = "0x74E2", VA = "0x74E2")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_Portals_View_Balance_PortalsBalanceView__UpdateView(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5811c == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a5811c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x74E3", Offset = "0x74E3", VA = "0x74E3")]
		public PortalsBalanceView()
		{
		}

		// Token: 0x0400139D RID: 5021
		[Token(Token = "0x400139D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x0400139E RID: 5022
		[Token(Token = "0x400139E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x0400139F RID: 5023
		[Token(Token = "0x400139F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x040013A0 RID: 5024
		[Token(Token = "0x40013A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextToolTip _currencyToolTip;

		// Token: 0x040013A1 RID: 5025
		[Token(Token = "0x40013A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup _canvasGroup;

		// Token: 0x040013A2 RID: 5026
		[Token(Token = "0x40013A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private PortalsModel _model;

		// Token: 0x040013A3 RID: 5027
		[Token(Token = "0x40013A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CanvasGroup ---
		void Gameplay_Portals_View_Balance_PortalsBalanceView__get_CanvasGroup
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58118 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_Balance_PortalsBalanceView_UserInfoChanged__);
		    DAT_ram_00a58118 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea461c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea461c:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  param1_01 = *(undefined4 *)(iVar5 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Portals_View_Balance_PortalsBalanceView_UserInfoChanged__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x28) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x28) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
