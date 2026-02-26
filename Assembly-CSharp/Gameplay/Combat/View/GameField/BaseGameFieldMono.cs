using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Data.User;
using DG.Tweening;
using Gameplay.Combat.Model;
using Gameplay.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200095F RID: 2399
	[Token(Token = "0x200095F")]
	public abstract class BaseGameFieldMono : MonoBehaviour, IInputPressHandler
	{
		// Token: 0x14000180 RID: 384
		// (add) Token: 0x060038DB RID: 14555 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060038DC RID: 14556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000180")]
		public event Action<StoneMono, StoneMono> SwapEvent
		{
			[Token(Token = "0x60038DB")]
			[Address(RVA = "0x8879", Offset = "0x8879", VA = "0x8879")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60038DC")]
			[Address(RVA = "0x887A", Offset = "0x887A", VA = "0x887A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000181 RID: 385
		// (add) Token: 0x060038DD RID: 14557 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060038DE RID: 14558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000181")]
		public event Action<BaseGameFieldMono> OnMouseDownEvent
		{
			[Token(Token = "0x60038DD")]
			[Address(RVA = "0x887B", Offset = "0x887B", VA = "0x887B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60038DE")]
			[Address(RVA = "0x887C", Offset = "0x887C", VA = "0x887C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x0000B490 File Offset: 0x00009690
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B32")]
		public uint RowNum
		{
			[Token(Token = "0x60038DF")]
			[Address(RVA = "0x887D", Offset = "0x887D", VA = "0x887D")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60038E0")]
			[Address(RVA = "0x887E", Offset = "0x887E", VA = "0x887E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x0000B4A8 File Offset: 0x000096A8
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B33")]
		public uint ColNum
		{
			[Token(Token = "0x60038E1")]
			[Address(RVA = "0x887F", Offset = "0x887F", VA = "0x887F")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60038E2")]
			[Address(RVA = "0x8880", Offset = "0x8880", VA = "0x8880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x0000B4C0 File Offset: 0x000096C0
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B34")]
		public bool IsPressed
		{
			[Token(Token = "0x60038E3")]
			[Address(RVA = "0x8881", Offset = "0x8881", VA = "0x8881")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60038E4")]
			[Address(RVA = "0x8882", Offset = "0x8882", VA = "0x8882")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E5")]
		[Address(RVA = "0x8883", Offset = "0x8883", VA = "0x8883", Slot = "5")]
		protected virtual void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__OnDestroy
		               (int param1,int param2,int param3,float param4,undefined4 param5)
		
		{
		  int param3_00;
		  int param3_01;
		  int param2_00;
		  int param2_01;
		  
		  param3_00 = *(int *)(param2 + 0x50);
		  param2_00 = *(int *)(param2 + 0x54);
		  *(int *)(*(int *)(param1 + 0x3c) +
		           (param3_00 + *(int *)(*(int *)(*(int *)(param1 + 0x3c) + 8) + 8) * param2_00) * 4 + 0x10)
		       = param3;
		  param3_01 = *(int *)(param3 + 0x50);
		  param2_01 = *(int *)(param3 + 0x54);
		  *(int *)(*(int *)(param1 + 0x3c) +
		           (param3_01 + *(int *)(*(int *)(*(int *)(param1 + 0x3c) + 8) + 8) * param2_01) * 4 + 0x10)
		       = param2;
		  Gameplay_Combat_View_GameField_StoneMono__Release(param3,param2_00,param3_00,param2);
		  Gameplay_Combat_View_GameField_StoneMono__Release(param2,param2_01,param3_01,param2);
		  Gameplay_Combat_View_GameField_BaseGameFieldMono__GetStoneUnderPoint(param2,param2,param4,param2);
		  Gameplay_Combat_View_GameField_BaseGameFieldMono__GetStoneUnderPoint(param2,param3,param4,param2);
		  return;
		}
		*/

		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E6")]
		[Address(RVA = "0x8884", Offset = "0x8884", VA = "0x8884")]
		protected void SwapStones(StoneMono from, StoneMono to, float duration)
		{
		/* --- GHIDRA: SwapStones ---
		uint Gameplay_Combat_View_GameField_BaseGameFieldMono__SwapStones
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a56720 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56720 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_3812(param2,0,0);
		  if ((uVar1 == 0) && (*(int *)(param1 + 0x20) = param2, *(char *)(param2 + 0x35) == '\0')) {
		    *(undefined1 *)(param2 + 0x34) = 1;
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param2,0);
		    local_10 = 1.1;
		    if (*(char *)(param2 + 0x34) == '\0') {
		      local_10 = 1.0;
		    }
		    local_18 = CONCAT44(local_10,local_10);
		    local_c = local_10;
		    local_8 = local_10;
		    local_4 = local_10;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar2,&local_18,0);
		    uVar2 = 10;
		    if (*(char *)(param2 + 0x34) == '\0') {
		      uVar2 = 0;
		    }
		    AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		              (*(undefined4 *)(param2 + 0x30),uVar2,0);
		  }
		  return uVar1 ^ 1;
		}
		*/

		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x60038E7")]
		[Address(RVA = "0x8885", Offset = "0x8885", VA = "0x8885")]
		private bool TrySelectStone(StoneMono stone)
		{
		/* --- GHIDRA: TrySelectStone ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__TrySelectStone(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a56721 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56721 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(param1 + 0x20);
		    if (*(char *)(iVar1 + 0x35) == '\0') {
		      *(undefined1 *)(iVar1 + 0x34) = 0;
		      uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (iVar1,0);
		      local_10 = 1.1;
		      if (*(char *)(iVar1 + 0x34) == '\0') {
		        local_10 = 1.0;
		      }
		      local_18 = CONCAT44(local_10,local_10);
		      local_c = local_10;
		      local_8 = local_10;
		      local_4 = local_10;
		      Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar2,&local_18,0);
		      uVar2 = 10;
		      if (*(char *)(iVar1 + 0x34) == '\0') {
		        uVar2 = 0;
		      }
		      AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		                (*(undefined4 *)(iVar1 + 0x30),uVar2,0);
		    }
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E8")]
		[Address(RVA = "0x8886", Offset = "0x8886", VA = "0x8886")]
		private void DeselectCurrentStone()
		{
		/* --- GHIDRA: DeselectCurrentStone ---
		undefined4
		Gameplay_Combat_View_GameField_BaseGameFieldMono__DeselectCurrentStone
		          (int param1,float *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  float fVar4;
		  float fVar5;
		  uint uVar6;
		  uint uVar7;
		  float4 local_c;
		  float4 local_8;
		  
		  fVar4 = *param2;
		  bVar1 = false;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  func_ii_7888(&local_c,uVar2,0);
		  fVar5 = param2[1];
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  func_ii_7888(&local_c,uVar2,0);
		  if (DAT_ram_00a648ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a648ed = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		    bVar1 = DAT_ram_00a648ed == '\0';
		  }
		  fVar4 = FLOOR(((fVar4 - (float)local_c) + 44.0) / 88.0);
		  if (ABS(fVar4) < 2.1474836e+09) {
		    uVar6 = (uint)fVar4;
		  }
		  else {
		    uVar6 = 0x80000000;
		  }
		  if (bVar1) {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a648ed = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  fVar4 = FLOOR(((fVar5 - (float)local_8) + 44.0) / 88.0);
		  if (ABS(fVar4) < 2.1474836e+09) {
		    uVar7 = (uint)fVar4;
		  }
		  else {
		    uVar7 = 0x80000000;
		  }
		  uVar2 = 0;
		  if (DAT_ram_00a56728 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56728 = '\x01';
		  }
		  if ((((-1 < (int)uVar7) && (-1 < (int)uVar6)) && (uVar7 <= *(int *)(param1 + 0x40) - 1U)) &&
		     (uVar6 <= *(int *)(param1 + 0x44) - 1U)) {
		    uVar2 = *(undefined4 *)
		             (*(int *)(param1 + 0x3c) +
		              (*(int *)(*(int *)(*(int *)(param1 + 0x3c) + 8) + 8) * uVar6 + uVar7) * 4 + 0x10);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar3 == 0) {
		      uVar2 = 0;
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038E9")]
		[Address(RVA = "0x8887", Offset = "0x8887", VA = "0x8887")]
		private StoneMono GetStoneUnderPoint(Vector2 pos)
		{
		/* --- GHIDRA: GetStoneUnderPoint ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__GetStoneUnderPoint
		               (undefined4 param1,int param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a56722 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Sequence___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a56722 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param2,0);
		  if (iVar1 != 0) {
		    if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		      func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		    }
		    param1_00 = DG_Tweening_DOTween__To(0);
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param2,0);
		    local_8 = *(undefined4 *)(param2 + 0x48);
		    local_10 = *(undefined8 *)(param2 + 0x40);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar2,&local_10,param3,0,0);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar2,7,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param2,0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar2,uVar3,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    DG_Tweening_TweenSettingsExtensions__Prepend(param1_00,uVar2,0);
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param2,0);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion(uVar2,1.0,param3 * 0.5,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param2,0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar2,uVar3,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    DG_Tweening_TweenParams___cctor(param1_00,uVar2,0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param2,0);
		    DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		              (param1_00,uVar2,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Sequence___);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EA")]
		[Address(RVA = "0x8888", Offset = "0x8888", VA = "0x8888")]
		private void MoveToIdlePosition(StoneMono stone, float duration)
		{
		/* --- GHIDRA: MoveToIdlePosition ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__MoveToIdlePosition
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a56723 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56723 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar3,0,0);
		  if (iVar1 == 0) {
		    if (*(int *)(param1 + 0x28) != 0) {
		      func_ii_7891(*(int *)(param1 + 0x28),1,0);
		    }
		    if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		      func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		    }
		    uVar3 = DG_Tweening_DOTween__To(0);
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x24),0);
		    local_8 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x48);
		    local_10 = *(undefined8 *)(*(int *)(param1 + 0x20) + 0x40);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar2,&local_10,param2,0,0);
		    DG_Tweening_TweenSettingsExtensions__Prepend(uVar3,uVar2,0);
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x24),0);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion(uVar2,1.0,param2 * 0.5,0);
		    DG_Tweening_TweenParams___cctor(uVar3,uVar2,0);
		    *(undefined4 *)(param1 + 0x28) = uVar3;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EB")]
		[Address(RVA = "0x8889", Offset = "0x8889", VA = "0x8889")]
		private void ShowSwapWithNeighborStone(float duration)
		{
		/* --- GHIDRA: ShowSwapWithNeighborStone ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__ShowSwapWithNeighborStone
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a56724 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_BaseGameFieldMono_ClickCanceledEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IPlayerInput_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56724 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo);
		  System_Action_object__ulong___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Combat_View_GameField_BaseGameFieldMono_ClickCanceledEvent__,0);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Input_IPlayerInput_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80c6ed8c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Input_IPlayerInput_TypeInfo,1);
		code_r0x80c6ed8c:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar5 != 0) {
		    iVar5 = *(int *)(param1 + 0x24);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar4 = UnityEngine_Component__GetComponent_object_(iVar5,0);
		    if (iVar4 == 0) {
		      Gameplay_Combat_View_GameField_BaseGameFieldMono__GetStoneUnderPoint
		                (iVar5,*(undefined4 *)(param1 + 0x20),*(float *)(param1 + 0x38),iVar5);
		    }
		    else {
		      iVar5 = *(int *)(param1 + 0x10);
		      if (iVar5 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                  (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(param1 + 0x20),
		                   *(undefined4 *)(param1 + 0x24),*(undefined4 *)(iVar5 + 0x14));
		      }
		      *(undefined4 *)(param1 + 0x24) = 0;
		    }
		    Gameplay_Combat_View_GameField_BaseGameFieldMono__TrySelectStone(param1,iVar5);
		  }
		  *(undefined1 *)(param1 + 0x48) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0x888A", Offset = "0x888A", VA = "0x888A")]
		private void ClickCanceledEvent(IPlayerInput input, InputAction.CallbackContext ctx)
		{
		/* --- GHIDRA: ClickCanceledEvent ---
		int Gameplay_Combat_View_GameField_BaseGameFieldMono__ClickCanceledEvent
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a56725 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_BaseGameFieldMono__DragCoroutine_d__35_TypeInfo);
		    DAT_ram_00a56725 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_GameField_BaseGameFieldMono__DragCoroutine_d__35_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 0x18) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x14) = param3;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x888B", Offset = "0x888B", VA = "0x888B")]
		private IEnumerator DragCoroutine(Camera cam, IPlayerInput input)
		{
		/* --- GHIDRA: DragCoroutine ---
		int Gameplay_Combat_View_GameField_BaseGameFieldMono__DragCoroutine(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a56726 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_FindFirstObjectByType_PlayerInputController___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56726 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 == 0) {
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = Com_TheFallenGames_OSA_Demos_HierarchyWithStickyHeaders_OSAHierarchyStickyHeader__InitWithCustomItemViewsHolder_object_
		                      (Method_UnityEngine_Object_FindFirstObjectByType_PlayerInputController___);
		    *(int *)(param1 + 0x2c) = iVar1;
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038EE")]
		[Address(RVA = "0x888C", Offset = "0x888C", VA = "0x888C")]
		private IPlayerInput GetPlayerInput()
		{
		/* --- GHIDRA: GetPlayerInput ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__GetPlayerInput
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x40) = param3;
		  *(undefined4 *)(param1 + 0x44) = param2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EF")]
		[Address(RVA = "0x888D", Offset = "0x888D", VA = "0x888D")]
		private void SetSize(uint colNum, uint rowNum)
		{
		/* --- GHIDRA: SetSize ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__SetSize
		               (int param1,int param2,undefined4 param3,float param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param2 + 0x10);
		  iVar2 = *(int *)(param2 + 0x14);
		  *(int *)(param1 + 0x40) = iVar2;
		  *(int *)(param1 + 0x44) = iVar1;
		  *(float *)(param1 + 0x38) = param4;
		  *(float *)(param1 + 0x34) = (float)(iVar2 * 0x58 - 0x58);
		  *(float *)(param1 + 0x30) = (float)(iVar1 * 0x58 - 0x58);
		  return;
		}
		*/

		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F0")]
		[Address(RVA = "0x888E", Offset = "0x888E", VA = "0x888E", Slot = "6")]
		public virtual void InitField(GameFieldGamesData fieldData, UserSettings settings, float swapDuration)
		{
		/* --- GHIDRA: InitField ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__InitField
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a56727 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_BaseGameFieldMono_ClickCanceledEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IPlayerInput_TypeInfo);
		    DAT_ram_00a56727 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x14);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo);
		  System_Action_object__ulong___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Combat_View_GameField_BaseGameFieldMono_ClickCanceledEvent__,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Input_IPlayerInput_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80c6f03a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Input_IPlayerInput_TypeInfo,0);
		code_r0x80c6f03a:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a56725 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_BaseGameFieldMono__DragCoroutine_d__35_TypeInfo);
		    DAT_ram_00a56725 = '\x01';
		  }
		  iVar4 = unnamed_function_1417
		                    (Gameplay_Combat_View_GameField_BaseGameFieldMono__DragCoroutine_d__35_TypeInfo)
		  ;
		  *(int *)(iVar4 + 0x18) = param1;
		  *(undefined4 *)(iVar4 + 8) = 0;
		  *(int **)(iVar4 + 0x14) = param2;
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  uVar2 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar4,0);
		  *(undefined1 *)(param1 + 0x48) = 1;
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F1")]
		[Address(RVA = "0x888F", Offset = "0x888F", VA = "0x888F", Slot = "7")]
		public virtual void HandlePressDown(IPlayerInput input)
		{
		/* --- GHIDRA: HandlePressDown ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__HandlePressDown(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a56729 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_BaseGameFieldMono_ClickCanceledEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IPlayerInput_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56729 = '\x01';
		  }
		  if (DAT_ram_00a56726 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_FindFirstObjectByType_PlayerInputController___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56726 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x2c);
		  if (param1_00 == (int *)0x0) {
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    param1_00 = (int *)Com_TheFallenGames_OSA_Demos_HierarchyWithStickyHeaders_OSAHierarchyStickyHeader__InitWithCustomItemViewsHolder_object_
		                                 (
		                                 Method_UnityEngine_Object_FindFirstObjectByType_PlayerInputController___
		                                 );
		    *(int **)(param1 + 0x2c) = param1_00;
		  }
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo);
		  System_Action_object__ulong___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Combat_View_GameField_BaseGameFieldMono_ClickCanceledEvent__,0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Input_IPlayerInput_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80c6f1d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Input_IPlayerInput_TypeInfo,1);
		code_r0x80c6f1d2:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar4 != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x24);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar4 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar4 != 0) {
		      Gameplay_Combat_View_GameField_BaseGameFieldMono__GetStoneUnderPoint
		                (uVar2,*(undefined4 *)(param1 + 0x24),*(float *)(param1 + 0x38),uVar2);
		    }
		    Gameplay_Combat_View_GameField_BaseGameFieldMono__GetStoneUnderPoint
		              (uVar2,*(undefined4 *)(param1 + 0x20),*(float *)(param1 + 0x38),uVar2);
		    Gameplay_Combat_View_GameField_BaseGameFieldMono__TrySelectStone(param1,uVar2);
		  }
		  *(undefined1 *)(param1 + 0x48) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x60038F2")]
		[Address(RVA = "0x37A9", Offset = "0x37A9", VA = "0x37A9")]
		public bool TryGetStoneMonoByCoords(int col, int row, out StoneMono stone)
		{
		/* --- GHIDRA: TryGetStoneMonoByCoords ---
		undefined4
		Gameplay_Combat_View_GameField_BaseGameFieldMono__TryGetStoneMonoByCoords
		          (int *param1,int *param2,undefined4 param3,int param4)
		
		{
		  longlong lVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  int *param1_00;
		  int iVar5;
		  uint uVar6;
		  undefined4 local_44;
		  longlong local_40;
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  int *local_c;
		  undefined8 local_8;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a5cd78 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_FieldChange_IFieldChange_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5cd78 = '\x01';
		  }
		  local_40 = 0;
		  local_44 = 0;
		  param1_00 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x20);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81617ad4;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x81617ad4:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (*(char *)(iVar5 + 10) == '\0') {
		    uVar3 = 0;
		  }
		  else {
		    uVar6 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_Model_FieldChange_IFieldChange_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x81617b5d;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Combat_Model_FieldChange_IFieldChange_TypeInfo,2);
		code_r0x81617b5d:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,&local_40,puVar2[1]);
		    if (iVar5 == 0) {
		      uVar3 = 0;
		    }
		    else {
		      iVar5 = *(int *)param1[2];
		      uVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        ((int *)param1[2],*(undefined4 *)(iVar5 + 0x104));
		      lVar4 = Core_Data_UserData__get_UserId(uVar3,0);
		      lVar1 = local_40;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar5 = Gameplay_Combat_View_AbstractCombatView__ShowGameOver
		                        (uVar3,param3,(uint)(lVar4 == lVar1),&local_44,0);
		      local_10 = local_44;
		      if (iVar5 == 0) {
		        uVar3 = 0;
		      }
		      else {
		        iVar5 = *(int *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0xc0);
		        local_8 = 0;
		        System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_
		                  (&local_34,0);
		        local_18 = local_2c;
		        local_24 = 0xffffffff;
		        local_20 = local_34;
		        local_c = param1;
		        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                  (&local_20,&local_24,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x130));
		        uVar3 = 1;
		      }
		    }
		  }
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x8890", Offset = "0x8890", VA = "0x8890")]
		public void StopHandlePlayerInput()
		{
		/* --- GHIDRA: StopHandlePlayerInput ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__StopHandlePlayerInput
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5672a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_StoneMono____TypeInfo);
		    DAT_ram_00a5672a = '\x01';
		  }
		  if (DAT_ram_00a65d40 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		    DAT_ram_00a65d40 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x30) = **(undefined8 **)(UnityEngine_Vector2_TypeInfo + 0x5c);
		  local_8 = 0x100000001;
		  uVar1 = unnamed_function_2396(Gameplay_Combat_View_GameField_StoneMono____TypeInfo,&local_8);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F4")]
		[Address(RVA = "0x8891", Offset = "0x8891", VA = "0x8891")]
		protected BaseGameFieldMono()
		{
		}

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("mainCamera")]
		[SerializeField]
		protected Camera _mainCamera;

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _dragCoroutine;

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		[FieldOffset(Offset = "0x20")]
		private StoneMono _currentStone;

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x24")]
		private StoneMono _neighborStone;

		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0x28")]
		private Sequence _neighbourStoneSequence;

		// Token: 0x04001F70 RID: 8048
		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0x2C")]
		private IPlayerInput _playerInputCache;

		// Token: 0x04001F71 RID: 8049
		[Token(Token = "0x4001F71")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 _maxStonePosition;

		// Token: 0x04001F72 RID: 8050
		[Token(Token = "0x4001F72")]
		[FieldOffset(Offset = "0x38")]
		private float _swapDuration;

		// Token: 0x04001F73 RID: 8051
		[Token(Token = "0x4001F73")]
		[FieldOffset(Offset = "0x3C")]
		protected StoneMono[,] _allStones;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SwapEvent ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__add_SwapEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5671c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_StoneMono__StoneMono__TypeInfo);
		    DAT_ram_00a5671c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_StoneMono__StoneMono__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_StoneMono__StoneMono__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SwapEvent ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__remove_SwapEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5671d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		    DAT_ram_00a5671d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BaseGameFieldMono__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseGameFieldMono__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnMouseDownEvent ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__add_OnMouseDownEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5671e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		    DAT_ram_00a5671e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BaseGameFieldMono__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseGameFieldMono__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: set_IsPressed ---
		void Gameplay_Combat_View_GameField_BaseGameFieldMono__set_IsPressed(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int param1_00;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5671f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5671f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  iVar1 = System_Array__CreateInstanceImpl(param1_00,0,0);
		  iVar2 = System_Array__CreateInstanceImpl(param1_00,1,0);
		  for (iVar3 = System_Array__GetRank(param1_00,0,0); iVar3 <= iVar1; iVar3 = iVar3 + 1) {
		    for (iVar4 = System_Array__GetRank(param1_00,1,0); iVar4 <= iVar2; iVar4 = iVar4 + 1) {
		      uVar6 = *(undefined4 *)
		               (param1_00 + (*(int *)(*(int *)(param1_00 + 8) + 8) * iVar3 + iVar4) * 4 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar5 = UnityEngine_Component__GetComponent_object_(uVar6,0);
		      if (iVar5 != 0) {
		        uVar6 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (uVar6,0);
		        func_ii_8007(uVar6,0,0);
		      }
		    }
		  }
		  return;
		}
		*/

}
