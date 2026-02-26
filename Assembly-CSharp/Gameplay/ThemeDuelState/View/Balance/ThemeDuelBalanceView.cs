using System;
using System.Runtime.InteropServices;
using AssetContent;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.ThemeDuelState.View.Balance
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	public class ThemeDuelBalanceView : MonoBehaviour
	{
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053B")]
		private CanvasGroup CanvasGroup
		{
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x6EC1", Offset = "0x6EC1", VA = "0x6EC1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x6EC2", Offset = "0x6EC2", VA = "0x6EC2")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__Awake(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  float fVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 param1_00;
		  uint uVar6;
		  undefined8 uVar7;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58582 == '\0') {
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
		    DAT_ram_00a58582 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar6 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f07e2b;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f07e2b:
		  iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  iVar5 = *(int *)(iVar5 + 0x14);
		  *(int *)(param1 + 0x20) = iVar5;
		  fVar2 = func_ii_7103(*(undefined4 *)(iVar5 + 0x34),0);
		  if (fVar2 <= 0.0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x14),0,0);
		  }
		  else {
		    iVar5 = *(int *)(iVar5 + 0x10);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x14),(uint)(iVar5 != 0),0);
		    if (iVar5 != 0) {
		      uVar3 = 0;
		      iVar5 = *(int *)(param1 + 0x20);
		      fVar2 = func_ii_7103(*(undefined4 *)(iVar5 + 0x34),0);
		      if (0.0 < fVar2) {
		        uVar3 = *(undefined4 *)(iVar5 + 0x10);
		      }
		      fVar2 = func_ii_7103(*(undefined4 *)(iVar5 + 0x34),0);
		      if ((0.0 < fVar2) && (*(int *)(iVar5 + 0x10) != 0)) {
		        param1_00 = *(undefined4 *)(param1 + 0x18);
		        uVar3 = Core_Extensions_Dict_ThemeDuelDicExt__GetIcon32AssetId(uVar3,0);
		        Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar3,0);
		      }
		      local_8 = 0;
		      local_30 = 0;
		      local_10 = 0;
		      local_38 = 0;
		      Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__BalanceChanged
		                (param1,&local_38,iVar5);
		      Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x24),0);
		      if (DAT_ram_00a58580 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        DAT_ram_00a58580 = '\x01';
		      }
		      if (*(int *)(param1 + 0x1c) == 0) {
		        uVar3 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                             Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        *(undefined4 *)(param1 + 0x1c) = uVar3;
		      }
		      else {
		        uVar3 = *(undefined4 *)(param1 + 0x1c);
		      }
		      UnityEngine_CanvasGroup__get_alpha(uVar3,0.0,0);
		      if (DAT_ram_00a58580 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        DAT_ram_00a58580 = '\x01';
		      }
		      if (*(int *)(param1 + 0x1c) == 0) {
		        uVar3 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                             Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        *(undefined4 *)(param1 + 0x1c) = uVar3;
		      }
		      else {
		        uVar3 = *(undefined4 *)(param1 + 0x1c);
		      }
		      uVar3 = Core_Animations_GameSpineUiAnimation__Play(uVar3,1.0,0.5,0);
		      uVar3 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar3,6,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x24),uVar3,0);
		      piVar4 = (int *)UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x14),0);
		      if ((piVar4 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar4)) {
		        System_Activator__CreateInstance(piVar4,UnityEngine_RectTransform_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      UnityEngine_RectTransform__set_anchorMax(&local_18,piVar4,0);
		      if (DAT_ram_00a648f4 == '\0') {
		        Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		        DAT_ram_00a648f4 = '\x01';
		      }
		      uVar7 = *(undefined8 *)(*(int *)(UnityEngine_Vector2_TypeInfo + 0x5c) + 0x10);
		      local_40 = CONCAT44((float)((ulonglong)uVar7 >> 0x20) * 100.0 +
		                          (float)((ulonglong)local_18 >> 0x20),
		                          (float)uVar7 * 100.0 + (float)local_18);
		      local_20 = local_40;
		      UnityEngine_RectTransform__get_anchoredPosition(piVar4,&local_40,0);
		      local_48 = local_18;
		      local_28 = local_18;
		      uVar3 = DG_Tweening_DOTweenModuleUI__DOScale(piVar4,&local_48,0.5,0,0);
		      uVar3 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar3,6,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x24),uVar3,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x6EC3", Offset = "0x6EC3", VA = "0x6EC3")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__Start
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58583 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long___ctor__);
		    DAT_ram_00a58583 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Core_Log_Files_FileDownloadLogger__LogDownload
		            (&local_10,param2,Method_System_Nullable_long___ctor__);
		  local_18 = local_8;
		  local_20 = local_10;
		  Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__BalanceChanged
		            (param1,&local_20,&local_20);
		  return;
		}
		*/

		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x6EC4", Offset = "0x6EC4", VA = "0x6EC4")]
		private void BalanceChanged(long balance)
		{
		/* --- GHIDRA: BalanceChanged ---
		void Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__BalanceChanged
		               (int param1,char *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int *piVar4;
		  uint uVar5;
		  undefined8 param2_00;
		  int iVar6;
		  
		  if (DAT_ram_00a58584 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a58584 = '\x01';
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
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar5 * 8 + 4) * 8 + iVar6 + 0x288);
		          goto code_r0x80f081d3;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar5);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f081d3:
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))
		                      (CONCAT44(in_register_20000004,piVar4),
		                       CONCAT44(in_register_20000014,puVar1[1]));
		    iVar6 = *(int *)(iVar6 + 0x14);
		    if (DAT_ram_00a58587 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		      DAT_ram_00a58587 = '\x01';
		    }
		    param2_00 = *(undefined8 *)(iVar6 + 0x20);
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (param2,param2_00,Method_System_Nullable_long___ctor__);
		    in_register_20000014 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  lVar3 = System_Nullable_TimeSpan___get_HasValue(param2,Method_System_Nullable_long__get_Value__);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar2 = UI_SimpleIconValue__set_IconAssetId((double)lVar3,StringLiteral_28780,0);
		  iVar6 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar4,CONCAT44(in_register_20000014,uVar2),*(undefined4 *)(iVar6 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x6EC5", Offset = "0x6EC5", VA = "0x6EC5")]
		private void DisplayCurrentBalance([Optional] long? balance)
		{
		/* --- GHIDRA: DisplayCurrentBalance ---
		void Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__DisplayCurrentBalance
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58585 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView_BalanceChanged__);
		    DAT_ram_00a58585 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f08457;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f08457:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView_BalanceChanged__,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_long__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x20) = iVar4;
		    uVar3 = System_Action_long__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/

		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x6EC6", Offset = "0x6EC6", VA = "0x6EC6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  
		  uVar2 = 0;
		  iVar3 = *(int *)(param1 + 0x20);
		  fVar1 = func_ii_7103(*(undefined4 *)(iVar3 + 0x34),0);
		  if (0.0 < fVar1) {
		    uVar2 = *(undefined4 *)(iVar3 + 0x10);
		  }
		  fVar1 = func_ii_7103(*(undefined4 *)(iVar3 + 0x34),0);
		  if ((0.0 < fVar1) && (*(int *)(iVar3 + 0x10) != 0)) {
		    param1_00 = *(undefined4 *)(param1 + 0x18);
		    uVar2 = Core_Extensions_Dict_ThemeDuelDicExt__GetIcon32AssetId(uVar2,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x6EC7", Offset = "0x6EC7", VA = "0x6EC7")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__UpdateView
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58586 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a58586 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x6EC8", Offset = "0x6EC8", VA = "0x6EC8")]
		public ThemeDuelBalanceView()
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView___ctor(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  uint uVar2;
		  
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		  if (0.0 < fVar1) {
		    uVar2 = (uint)(*(int *)(param1 + 0x10) != 0);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CanvasGroup _canvasGroup;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ThemeDuelStateModel _model;

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CanvasGroup ---
		void Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView__get_CanvasGroup
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58581 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView_BalanceChanged__);
		    DAT_ram_00a58581 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f07cb9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f07cb9:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView_BalanceChanged__,0);
		  iVar5 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_long__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x20) = iVar4;
		    uVar3 = System_Action_long__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
