using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View
{
	// Token: 0x02000915 RID: 2325
	[Token(Token = "0x2000915")]
	public class CombatEventsToast : MonoBehaviour
	{
		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACE")]
		public TextMeshProUGUI TextField
		{
			[Token(Token = "0x60036C5")]
			[Address(RVA = "0x86B4", Offset = "0x86B4", VA = "0x86B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x86B5", Offset = "0x86B5", VA = "0x86B5")]
		private void Awake()
		{
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x86B6", Offset = "0x86B6", VA = "0x86B6")]
		public void Show()
		{
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x86B7", Offset = "0x86B7", VA = "0x86B7")]
		public void Hide()
		{
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x0000AFE0 File Offset: 0x000091E0
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACF")]
		public float Duration
		{
			[Token(Token = "0x60036C9")]
			[Address(RVA = "0x86B8", Offset = "0x86B8", VA = "0x86B8")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60036CA")]
			[Address(RVA = "0x86B9", Offset = "0x86B9", VA = "0x86B9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x86BA", Offset = "0x86BA", VA = "0x86BA")]
		public void Play()
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_CombatEventsToast__Play(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/

		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x86BB", Offset = "0x86BB", VA = "0x86BB")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_CombatEventsToast__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b1e == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a63b1e = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x18) = 0x435c000000000000;
		  *(undefined4 *)(param1 + 0x20) = 0;
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x28) = 0x3f99999a;
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x86BC", Offset = "0x86BC", VA = "0x86BC")]
		public CombatEventsToast()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_CombatEventsToast___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63b1f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    DAT_ram_00a63b1f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Func_CombatGameOverView__bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_CombatGameOverView__bool__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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

		}

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04001DF8 RID: 7672
		[Token(Token = "0x4001DF8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04001DF9 RID: 7673
		[Token(Token = "0x4001DF9")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 _offset;

		// Token: 0x04001DFA RID: 7674
		[Token(Token = "0x4001DFA")]
		[FieldOffset(Offset = "0x24")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Duration ---
		void Gameplay_Combat_View_CombatEventsToast__set_Duration(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  float local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  float4 local_24;
		  float4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63b1d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a63b1d = '\x01';
		  }
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x24),0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  UnityEngine_Transform___ctor(&local_c,uVar1,0);
		  local_28 = local_4;
		  local_30 = local_c;
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  UnityEngine_Transform___ctor(&local_18,uVar1,0);
		  local_38 = (float)local_10 - *(float *)(param1 + 0x20);
		  local_20 = (float4)((float)local_14 - *(float *)(param1 + 0x1c));
		  local_24 = (float4)((float)local_18 - *(float *)(param1 + 0x18));
		  local_40 = CONCAT44(local_20,local_24);
		  local_1c = (float4)local_38;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar1,&local_40,0);
		  UnityEngine_CanvasGroup__get_alpha(*(undefined4 *)(param1 + 0x14),0.0,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_48 = local_28;
		  local_50 = local_30;
		  uVar1 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar1,&local_50,*(float *)(param1 + 0x28),0,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,0xf,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x24),uVar1,0);
		  uVar1 = Core_Animations_GameSpineUiAnimation__Play
		                    (*(undefined4 *)(param1 + 0x14),1.0,*(float *)(param1 + 0x28),0);
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x24),uVar1,0);
		  return;
		}
		*/

}
