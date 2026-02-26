using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace UI.Toast
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public class ToastView : MonoBehaviour
	{
		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D9")]
		public event Action<ToastView> HideCompleteEvent
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x5DC5", Offset = "0x5DC5", VA = "0x5DC5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x5DC6", Offset = "0x5DC6", VA = "0x5DC6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		public int AddedAtIndex
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x5DC7", Offset = "0x5DC7", VA = "0x5DC7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x5DC8", Offset = "0x5DC8", VA = "0x5DC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x5DC9", Offset = "0x5DC9", VA = "0x5DC9")]
		public void Show(ToastController.ToastData toastData, int addedAtIndex)
		{
		/* --- GHIDRA: <Hide>b__15_0 ---
		void UI_Toast_ToastView___Hide_b__15_0(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x54),0);
		  UI_Tabs_TabBar__get_SelectedItem(param1,param1);
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void UI_Toast_ToastView__Show(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a599c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Toast_ToastView__Hide_b__15_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		              );
		    DAT_ram_00a599c0 = '\x01';
		  }
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x2c),0);
		  uVar1 = Core_Animations_GameSpineUiAnimation__Play(*(undefined4 *)(param1 + 0x20),0.0,0.2,0);
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply(param1_00,param1,Method_UI_Toast_ToastView__Hide_b__15_0__,0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar1,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x2c),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x5DCA", Offset = "0x5DCA", VA = "0x5DCA")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void UI_Toast_ToastView__Hide(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x2c),0);
		  *(undefined4 *)(param1 + 0x30) = 0;
		  iVar2 = *(int *)(param1 + 0x28);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a599bc == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a599bc = '\x01';
		    }
		    iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                      (*(undefined4 *)(iVar2 + 0x14),0);
		    if (iVar1 != 0) {
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + 0x14),0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(param1_00,0);
		    }
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x5DCB", Offset = "0x5DCB", VA = "0x5DCB")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		void UI_Toast_ToastView__Reset(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a599c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a599c1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x5DCC", Offset = "0x5DCC", VA = "0x5DCC")]
		public ToastView()
		{
		}

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _rect;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _message;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x28")]
		private ToastController.ToastData _toastData;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x2C")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_HideCompleteEvent ---
		void UI_Toast_ToastView__add_HideCompleteEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a599be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToastView__TypeInfo);
		    DAT_ram_00a599be = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ToastView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ToastView__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: set_AddedAtIndex ---
		void UI_Toast_ToastView__set_AddedAtIndex(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a599bf == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    DAT_ram_00a599bf = '\x01';
		  }
		  *(int *)(param1 + 0x28) = param2;
		  iVar2 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(param2 + 0x10),*(undefined4 *)(iVar2 + 0x2d4))
		  ;
		  iVar2 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(param2 + 0xc),*(undefined4 *)(iVar2 + 0x2d4));
		  uVar1 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		  }
		  UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(uVar1,0);
		  UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(*(undefined4 *)(param1 + 0x10),0);
		  *(undefined4 *)(param1 + 0x30) = param3;
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param2 + 0x14),0);
		  if (iVar2 != 0) {
		    UnityEngine_GameObject___ctor(*(undefined4 *)(param2 + 0x14),*(undefined4 *)(param1 + 0x1c),0,0)
		    ;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param2 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0xc1f0000000000000;
		  local_18 = 0xc1f0000000000000;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar1,&local_18,0);
		  UnityEngine_CanvasGroup__get_alpha(*(undefined4 *)(param1 + 0x20),0.0,0);
		  uVar1 = Core_Animations_GameSpineUiAnimation__Play(*(undefined4 *)(param1 + 0x20),1.0,0.2,0);
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x2c),uVar1,0);
		  return;
		}
		*/

}
