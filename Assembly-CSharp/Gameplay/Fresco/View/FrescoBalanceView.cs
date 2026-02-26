using System;
using System.Runtime.InteropServices;
using Gameplay.Fresco.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007EA RID: 2026
	[Token(Token = "0x20007EA")]
	public class FrescoBalanceView : MonoBehaviour
	{
		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700093A")]
		private CanvasGroup CanvasGroup
		{
			[Token(Token = "0x6002F8E")]
			[Address(RVA = "0x7FF4", Offset = "0x7FF4", VA = "0x7FF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x7FF5", Offset = "0x7FF5", VA = "0x7FF5")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Fresco_View_FrescoBalanceView__Awake(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a57553 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_View_FrescoBalanceView_UniversalFragmentsCountChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57553 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x2a8);
		        goto code_r0x80da7ea8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3d);
		code_r0x80da7ea8:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Gameplay_Fresco_View_FrescoBalanceView_UniversalFragmentsCountChanged__,0);
		  iVar6 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x24) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0x24) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
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

		// Token: 0x06002F90 RID: 12176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x7FF6", Offset = "0x7FF6", VA = "0x7FF6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Fresco_View_FrescoBalanceView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57554 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57554 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x2a8);
		        goto code_r0x80da8027;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3d);
		code_r0x80da8027:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar4 + 0x104));
		  *(int *)(param1 + 0x20) = iVar3;
		  iVar3 = *(int *)(iVar3 + 0x14);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),(uint)(iVar3 != 0),0);
		  if (iVar3 != 0) {
		    local_10 = 0;
		    local_8 = 0;
		    Gameplay_Fresco_View_FrescoBalanceView__UniversalFragmentsCountChanged(param1,&local_10,iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x7FF7", Offset = "0x7FF7", VA = "0x7FF7")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Fresco_View_FrescoBalanceView__Start
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 auStack_20 [8];
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57555 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    DAT_ram_00a57555 = '\x01';
		  }
		  local_8 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor(&local_8,param2,Method_System_Nullable_uint___ctor__);
		  local_10 = local_8;
		  local_18 = local_8;
		  Gameplay_Fresco_View_FrescoBalanceView__UniversalFragmentsCountChanged
		            (param1,&local_18,auStack_20);
		  return;
		}
		*/

		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x7FF8", Offset = "0x7FF8", VA = "0x7FF8")]
		private void UniversalFragmentsCountChanged(uint balance)
		{
		/* --- GHIDRA: UniversalFragmentsCountChanged ---
		void Gameplay_Fresco_View_FrescoBalanceView__UniversalFragmentsCountChanged
		               (int param1,char *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57556 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a57556 = '\x01';
		  }
		  if (*param2 == '\0') {
		    System_Data_SqlTypes_SqlInt32___ctor
		              (param2,*(undefined4 *)(*(int *)(param1 + 0x20) + 0x2c),
		               Method_System_Nullable_uint___ctor__);
		  }
		  piVar3 = *(int **)(param1 + 0x10);
		  uVar1 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                    (param2,Method_System_Nullable_uint__get_Value__);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar2 = UI_SimpleIconValue__set_IconAssetId((double)uVar1,StringLiteral_28780,0);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x7FF9", Offset = "0x7FF9", VA = "0x7FF9")]
		private void DisplayCurrentBalance([Optional] uint? balance)
		{
		/* --- GHIDRA: DisplayCurrentBalance ---
		void Gameplay_Fresco_View_FrescoBalanceView__DisplayCurrentBalance(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57557 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a57557 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F94")]
		[Address(RVA = "0x7FFA", Offset = "0x7FFA", VA = "0x7FFA")]
		public FrescoBalanceView()
		{
		}

		// Token: 0x040019E0 RID: 6624
		[Token(Token = "0x40019E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _balanceLabel;

		// Token: 0x040019E1 RID: 6625
		[Token(Token = "0x40019E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _view;

		// Token: 0x040019E2 RID: 6626
		[Token(Token = "0x40019E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _installButton;

		// Token: 0x040019E3 RID: 6627
		[Token(Token = "0x40019E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CanvasGroup _canvasGroup;

		// Token: 0x040019E4 RID: 6628
		[Token(Token = "0x40019E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FrescoModel _model;

		// Token: 0x040019E5 RID: 6629
		[Token(Token = "0x40019E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CanvasGroup ---
		void Gameplay_Fresco_View_FrescoBalanceView__get_CanvasGroup(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a57552 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_View_FrescoBalanceView_UniversalFragmentsCountChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57552 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x2a8);
		        goto code_r0x80da7d34;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3d);
		code_r0x80da7d34:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Gameplay_Fresco_View_FrescoBalanceView_UniversalFragmentsCountChanged__,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x24) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar5 + 0x24) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		    if (iVar5 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
