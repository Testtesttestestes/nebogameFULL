using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Billing.View
{
	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000BDE")]
	public class BankBalanceView : MonoBehaviour
	{
		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F0D")]
		protected CanvasGroup CanvasGroup
		{
			[Token(Token = "0x6004A92")]
			[Address(RVA = "0x98F4", Offset = "0x98F4", VA = "0x98F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A93")]
		[Address(RVA = "0x98F5", Offset = "0x98F5", VA = "0x98F5")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Billing_View_BankBalanceView__Awake(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  float4 local_34;
		  float4 local_30;
		  undefined4 local_2c;
		  float4 local_28;
		  float4 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a608f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a608f6 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x198);
		        goto code_r0x81cf8e2a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x81cf8e2a:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  piVar5 = *(int **)(iVar6 + 0x18);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf8) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0xfc));
		  if ((iVar6 == 0) ||
		     (iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf0) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0xf4)), iVar6 == 0)) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x14),0,0);
		  }
		  else {
		    uVar1 = (uint)(0.0 < *(double *)(piVar5 + 6));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x14),uVar1,0);
		    if (uVar1 != 0) {
		      Gameplay_Billing_View_BankBalanceView__BalanceChanged(param1,uVar1);
		      Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x1c),0);
		      if (DAT_ram_00a608f4 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        DAT_ram_00a608f4 = '\x01';
		      }
		      if (*(int *)(param1 + 0x18) == 0) {
		        uVar3 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                             Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        *(undefined4 *)(param1 + 0x18) = uVar3;
		      }
		      else {
		        uVar3 = *(undefined4 *)(param1 + 0x18);
		      }
		      UnityEngine_CanvasGroup__get_alpha(uVar3,0.0,0);
		      if (DAT_ram_00a608f4 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        DAT_ram_00a608f4 = '\x01';
		      }
		      if (*(int *)(param1 + 0x18) == 0) {
		        uVar3 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                             Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		        *(undefined4 *)(param1 + 0x18) = uVar3;
		      }
		      else {
		        uVar3 = *(undefined4 *)(param1 + 0x18);
		      }
		      uVar3 = Core_Animations_GameSpineUiAnimation__Play(uVar3,1.0,0.5,0);
		      uVar3 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar3,6,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x1c),uVar3,0);
		      uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x14),0);
		      UnityEngine_Transform___ctor(&local_1c,uVar3,0);
		      local_8 = local_14;
		      local_10 = local_1c;
		      uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x14),0);
		      uVar4 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x14),0);
		      UnityEngine_Transform___ctor(&local_28,uVar4,0);
		      uVar4 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x14),0);
		      UnityEngine_Transform___ctor(&local_28,uVar4,0);
		      local_2c = 0;
		      local_38 = 0;
		      local_34 = local_28;
		      local_30 = (float4)((float)local_24 + 100.0);
		      local_40 = CONCAT44(local_30,local_28);
		      Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar3,&local_40,0);
		      uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x14),0);
		      local_48 = local_8;
		      local_50 = local_10;
		      uVar3 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar3,&local_50,0.5,0,0);
		      uVar3 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar3,6,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x1c),uVar3,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A94")]
		[Address(RVA = "0x98F6", Offset = "0x98F6", VA = "0x98F6")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Billing_View_BankBalanceView__Start(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Billing_View_BankBalanceView__BalanceChanged(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A95")]
		[Address(RVA = "0x98F7", Offset = "0x98F7", VA = "0x98F7")]
		private void BalanceChanged()
		{
		/* --- GHIDRA: BalanceChanged ---
		void Gameplay_Billing_View_BankBalanceView__BalanceChanged(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param3;
		  int *piVar5;
		  int *piVar6;
		  int iVar7;
		  double param1_00;
		  uint uVar8;
		  
		  if (DAT_ram_00a608f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a608f7 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0x198);
		        goto code_r0x81cf9168;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x81cf9168:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(in_register_20000004,piVar6),puVar3[1]);
		  param1_00 = *(double *)(*(int *)(iVar7 + 0x18) + 0x18);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar4 = UI_SimpleIconValue__set_IconAssetId(param1_00,StringLiteral_28780,0);
		  uVar2 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0x198);
		        goto code_r0x81cf9243;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x81cf9243:
		  uVar1 = CONCAT44(uVar2,piVar6);
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(uVar1,puVar3[1]);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param3 = Core_Extensions_Dict_CultRatingKindDicExt__GetDescription
		                     (*(undefined4 *)(*(int *)(iVar7 + 0x18) + 0xc),0);
		  uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar4,StringLiteral_118,param3,0);
		  iVar7 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		            (CONCAT44(uVar2,piVar5),uVar4,*(undefined4 *)(iVar7 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A96")]
		[Address(RVA = "0x98F8", Offset = "0x98F8", VA = "0x98F8")]
		private void DisplayCurrentBalance()
		{
		/* --- GHIDRA: DisplayCurrentBalance ---
		void Gameplay_Billing_View_BankBalanceView__DisplayCurrentBalance(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a608f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Billing_View_BankBalanceView_BalanceChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a608f8 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x198);
		        goto code_r0x81cf9370;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x81cf9370:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x10);
		  param1_01 = *(undefined4 *)(iVar5 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Billing_View_BankBalanceView_BalanceChanged__,0);
		  piVar3 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar4)) {
		    System_Activator__CreateInstance(piVar3,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A97")]
		[Address(RVA = "0x98F9", Offset = "0x98F9", VA = "0x98F9")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Billing_View_BankBalanceView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a608f9 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A98")]
		[Address(RVA = "0x98FA", Offset = "0x98FA", VA = "0x98FA")]
		public BankBalanceView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Billing_View_BankBalanceView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a608fa == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12572);
		    DAT_ram_00a608fa = '\x01';
		  }
		  return StringLiteral_12572;
		}
		*/

		}

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		[FieldOffset(Offset = "0x1C")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CanvasGroup ---
		void Gameplay_Billing_View_BankBalanceView__get_CanvasGroup(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a608f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Billing_View_BankBalanceView_BalanceChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a608f5 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x198);
		        goto code_r0x81cf8cc4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x81cf8cc4:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x10);
		  param1_01 = *(undefined4 *)(iVar5 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Billing_View_BankBalanceView_BalanceChanged__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
