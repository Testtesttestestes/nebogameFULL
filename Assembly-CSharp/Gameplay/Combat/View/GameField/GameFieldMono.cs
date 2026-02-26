using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.User;
using Cysharp.Threading.Tasks;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField.Hint;
using Gameplay.Combat.View.Spells;
using Gameplay.Input;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000963 RID: 2403
	[Token(Token = "0x2000963")]
	public class GameFieldMono : BaseGameFieldMono
	{
		// Token: 0x14000182 RID: 386
		// (add) Token: 0x06003906 RID: 14598 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003907 RID: 14599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000182")]
		public event Action OnStoneDestroyed
		{
			[Token(Token = "0x6003906")]
			[Address(RVA = "0x88A3", Offset = "0x88A3", VA = "0x88A3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003907")]
			[Address(RVA = "0x88A4", Offset = "0x88A4", VA = "0x88A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000183 RID: 387
		// (add) Token: 0x06003908 RID: 14600 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003909 RID: 14601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000183")]
		public event Action OnGameOver
		{
			[Token(Token = "0x6003908")]
			[Address(RVA = "0x88A5", Offset = "0x88A5", VA = "0x88A5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003909")]
			[Address(RVA = "0x88A6", Offset = "0x88A6", VA = "0x88A6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000184 RID: 388
		// (add) Token: 0x0600390A RID: 14602 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600390B RID: 14603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000184")]
		public event Action OnInteractiveChanged
		{
			[Token(Token = "0x600390A")]
			[Address(RVA = "0x88A7", Offset = "0x88A7", VA = "0x88A7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600390B")]
			[Address(RVA = "0x88A8", Offset = "0x88A8", VA = "0x88A8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B38")]
		public StoneMono.StoneSkinProvider StoneSkin
		{
			[Token(Token = "0x600390C")]
			[Address(RVA = "0x88A9", Offset = "0x88A9", VA = "0x88A9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B39")]
		public SpellFieldFigure SpellFieldFigure
		{
			[Token(Token = "0x600390D")]
			[Address(RVA = "0x88AA", Offset = "0x88AA", VA = "0x88AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x0000B538 File Offset: 0x00009738
		// (set) Token: 0x0600390F RID: 14607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3A")]
		public bool FieldBlackoutVisible
		{
			[Token(Token = "0x600390E")]
			[Address(RVA = "0x88AB", Offset = "0x88AB", VA = "0x88AB")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600390F")]
			[Address(RVA = "0x88AC", Offset = "0x88AC", VA = "0x88AC")]
			set
			{
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x0000B550 File Offset: 0x00009750
		// (set) Token: 0x06003911 RID: 14609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3B")]
		public bool IsInteractive
		{
			[Token(Token = "0x6003910")]
			[Address(RVA = "0x88AD", Offset = "0x88AD", VA = "0x88AD")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003911")]
			[Address(RVA = "0x37A6", Offset = "0x37A6", VA = "0x37A6")]
			set
			{
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x0000B568 File Offset: 0x00009768
		// (set) Token: 0x06003913 RID: 14611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3C")]
		public bool EnableFollowFieldEffectFigureOnPointer
		{
			[Token(Token = "0x6003912")]
			[Address(RVA = "0x88AE", Offset = "0x88AE", VA = "0x88AE")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003913")]
			[Address(RVA = "0x88AF", Offset = "0x88AF", VA = "0x88AF")]
			set
			{
			}
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003914")]
		[Address(RVA = "0x88B0", Offset = "0x88B0", VA = "0x88B0", Slot = "5")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_GameField_GameFieldMono__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a56737 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_BoxCollider2D___);
		    DAT_ram_00a56737 = '\x01';
		  }
		  param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_BoxCollider2D___);
		  *(undefined4 *)(param1 + 0x9c) = param1_00;
		  UnityEngine_Object__op_Implicit(param1_00,(uint)*(byte *)(param1 + 0xb4),0);
		  iVar1 = *(int *)(param1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003915")]
		[Address(RVA = "0x88B1", Offset = "0x88B1", VA = "0x88B1")]
		private void Awake()
		{
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x88B2", Offset = "0x88B2", VA = "0x88B2")]
		private void ResetGlowPoolObjectCallback(StoneGlow pooledObject)
		{
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x88B3", Offset = "0x88B3", VA = "0x88B3")]
		private void ResetPoolObjectCallback(StoneMono pooledObject)
		{
		/* --- GHIDRA: ResetPoolObjectCallback ---
		void Gameplay_Combat_View_GameField_GameFieldMono__ResetPoolObjectCallback
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x9c),(uint)*(byte *)(param1 + 0xb4),0);
		  iVar1 = *(int *)(param1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003918")]
		[Address(RVA = "0x88B4", Offset = "0x88B4", VA = "0x88B4")]
		private void HandleIsInteractiveChanged()
		{
		/* --- GHIDRA: HandleIsInteractiveChanged ---
		int Gameplay_Combat_View_GameField_GameFieldMono__HandleIsInteractiveChanged
		              (int param1,undefined4 param2,int param3,int param4,float param5,float param6,
		              undefined4 param7)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined8 local_28;
		  float4 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a56738 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneMono__Get__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a56738 = '\x01';
		  }
		  param1_00 = Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                        (*(undefined4 *)(param1 + 0x90),
		                         Method_Utils_Cache_ObjectPool_StoneMono__Get__);
		  *(undefined4 *)(param1_00 + 0x3c) = *(undefined4 *)(param1 + 0xb8);
		  Gameplay_Combat_View_GameField_StoneMono__get_StoneType(param1_00,param2,param1_00);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  Gameplay_Combat_View_GameField_StoneMono__OnDestroy(param1_00,param1_00);
		  Gameplay_Combat_View_GameField_StoneMono__Release(param1_00,param3,param4,param1_00);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1_00,0);
		  local_c = *(float4 *)(param1_00 + 0x40);
		  local_10 = *(float4 *)(param1_00 + 0x48);
		  local_8 = (float4)(*(float *)(param1_00 + 0x44) + (float)*(int *)(param1 + 0x7c));
		  local_18 = CONCAT44(local_8,local_c);
		  local_4 = local_10;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar1,&local_18,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1_00,0);
		  uVar1 = UnityEngine_UI_Selectable__set_interactable(uVar1,0);
		  local_20 = *(float4 *)(param1_00 + 0x48);
		  local_28 = *(undefined8 *)(param1_00 + 0x40);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar1,&local_28,param5,0,0);
		  uVar1 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar1,param6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_00,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,param2_00,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  *(int *)(*(int *)(param1 + 0x3c) +
		           (*(int *)(*(int *)(*(int *)(param1 + 0x3c) + 8) + 8) * param3 + param4) * 4 + 0x10) =
		       param1_00;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003919")]
		[Address(RVA = "0x88B5", Offset = "0x88B5", VA = "0x88B5")]
		private StoneMono AddStone(StonesTypes type, int col, int row, float duration, float delay = 0f)
		{
		/* --- GHIDRA: AddStone ---
		void Gameplay_Combat_View_GameField_GameFieldMono__AddStone(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0xb5) != '\0') {
		    Gameplay_Combat_View_GameField_GameFieldMono__Update(param1,param1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600391A")]
		[Address(RVA = "0x19E3", Offset = "0x19E3", VA = "0x19E3")]
		private StoneMono AddStoneFromCenter(StonesTypes type, int col, int row, float duration)
		{
			return null;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391B")]
		[Address(RVA = "0x88B6", Offset = "0x88B6", VA = "0x88B6")]
		private void Update()
		{
		/* --- GHIDRA: Update ---
		void Gameplay_Combat_View_GameField_GameFieldMono__Update(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  float4 fVar2;
		  undefined4 uVar3;
		  double dVar4;
		  float fVar5;
		  float fVar6;
		  float fVar7;
		  int iVar8;
		  ulonglong uVar9;
		  undefined8 local_70;
		  undefined4 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined1 local_50 [8];
		  undefined4 local_48;
		  float4 local_44;
		  float4 local_40;
		  undefined4 local_3c;
		  float4 local_38;
		  float4 local_34;
		  float local_28;
		  float local_24;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5673a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    DAT_ram_00a5673a = '\x01';
		  }
		  if (DAT_ram_00a5a202 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		    DAT_ram_00a5a202 = '\x01';
		  }
		  UnityEngine_InputSystem_InputControl_Vector2___ReadUnprocessedValue
		            (&local_10,
		             *(undefined4 *)(**(int **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c) + 0xe8),
		             Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		  fVar5 = (float)((ulonglong)local_10 >> 0x20);
		  fVar1 = (float)local_10;
		  if (((*(float *)(param1 + 0xa0) != fVar1) || (*(float *)(param1 + 0xa4) != fVar5)) ||
		     (*(float *)(param1 + 0xa8) != 0.0)) {
		    local_20 = 0;
		    local_48 = 0;
		    local_28 = fVar1;
		    local_24 = fVar5;
		    UnityEngine_Camera__ViewportToWorldPoint(&local_1c,*(undefined4 *)(param1 + 0x18),local_50,0);
		    local_8 = local_14;
		    local_10 = local_1c;
		    uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param1,0);
		    local_58 = local_8;
		    local_60 = local_10;
		    UnityEngine_Transform__TransformPoint(&local_38,uVar3,&local_60,0);
		    fVar2 = local_34;
		    fVar6 = (float)local_38 / 88.0;
		    dVar4 = unnamed_function_4206((double)fVar6,&local_38);
		    if (0.0 <= fVar6) {
		      if (dVar4 == 0.5) {
		        dVar4 = (double)CONCAT44(local_34,local_38);
		        if (ABS(dVar4) < 9.223372036854776e+18) {
		          uVar9 = (ulonglong)dVar4;
		        }
		        else {
		          uVar9 = 0;
		        }
		        fVar6 = (float)dVar4;
		        if ((uVar9 & 1) != 0) {
		          fVar6 = (float)dVar4 + 1.0;
		        }
		      }
		      else {
		        fVar6 = FLOOR(fVar6 + 0.5);
		      }
		    }
		    else if (dVar4 == -0.5) {
		      dVar4 = (double)CONCAT44(local_34,local_38);
		      if (ABS(dVar4) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)dVar4;
		      }
		      else {
		        uVar9 = 0;
		      }
		      fVar6 = (float)dVar4;
		      if ((uVar9 & 1) != 0) {
		        fVar6 = (float)dVar4 + -1.0;
		      }
		    }
		    else {
		      fVar6 = CEIL(fVar6 + -0.5);
		    }
		    fVar7 = (float)fVar2 / 88.0;
		    dVar4 = unnamed_function_4206((double)fVar7,&local_38);
		    if (0.0 <= fVar7) {
		      if (dVar4 == 0.5) {
		        dVar4 = (double)CONCAT44(local_34,local_38);
		        if (ABS(dVar4) < 9.223372036854776e+18) {
		          uVar9 = (ulonglong)dVar4;
		        }
		        else {
		          uVar9 = 0;
		        }
		        fVar7 = (float)dVar4;
		        if ((uVar9 & 1) != 0) {
		          fVar7 = (float)dVar4 + 1.0;
		        }
		      }
		      else {
		        fVar7 = FLOOR(fVar7 + 0.5);
		      }
		    }
		    else if (dVar4 == -0.5) {
		      dVar4 = (double)CONCAT44(local_34,local_38);
		      if (ABS(dVar4) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)dVar4;
		      }
		      else {
		        uVar9 = 0;
		      }
		      fVar7 = (float)dVar4;
		      if ((uVar9 & 1) != 0) {
		        fVar7 = (float)dVar4 + -1.0;
		      }
		    }
		    else {
		      fVar7 = CEIL(fVar7 + -0.5);
		    }
		    if (((fVar6 < 0.0) || ((float)(*(int *)(param1 + 0x44) - 1) < fVar6)) || (fVar7 < 0.0)) {
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x6c),0);
		    }
		    else {
		      iVar8 = *(int *)(param1 + 0x40);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x6c),0);
		      if (fVar7 <= (float)(iVar8 - 1)) {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,(*(uint *)(param1 + 0xb0) ^ 0xffffffff) >> 0x1f,0);
		        *(int *)(param1 + 0xb0) = *(int *)(param1 + 0xb0) + 1;
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (*(undefined4 *)(param1 + 0x6c),0);
		        local_3c = 0;
		        local_68 = 0;
		        local_40 = (float4)(fVar7 * 88.0);
		        local_44 = (float4)(fVar6 * 88.0);
		        local_70 = CONCAT44(local_40,local_44);
		        Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar3,&local_70,0);
		        *(undefined4 *)(param1 + 0xa8) = 0;
		        *(float *)(param1 + 0xa4) = fVar5;
		        *(float *)(param1 + 0xa0) = fVar1;
		        return;
		      }
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(param1 + 0xb0) == 0),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391C")]
		[Address(RVA = "0x88B7", Offset = "0x88B7", VA = "0x88B7")]
		private void MoveFieldEffectFigureOnPointer()
		{
		/* --- GHIDRA: MoveFieldEffectFigureOnPointer ---
		void Gameplay_Combat_View_GameField_GameFieldMono__MoveFieldEffectFigureOnPointer
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  uint *puVar8;
		  int param1_01;
		  int *param1_02;
		  
		  if (DAT_ram_00a5673b == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Cache_IPool_IStoneParticles__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_StoneMono__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_StoneMono___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_StoneMono__TypeInfo);
		    DAT_ram_00a5673b = '\x01';
		  }
		  uVar3 = System_Array__InternalArray__ICollection_Clear(*(undefined4 *)(param1 + 0x3c),0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_StoneMono__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,uVar3,Method_System_Collections_Generic_List_StoneMono___ctor__);
		  param1_01 = *(int *)(param1 + 0x3c);
		  iVar4 = System_Array__CreateInstanceImpl(param1_01,0,0);
		  iVar5 = System_Array__CreateInstanceImpl(param1_01,1,0);
		  iVar6 = System_Array__GetRank(param1_01,0,0);
		  for (; iVar6 <= iVar4; iVar6 = iVar6 + 1) {
		    iVar7 = System_Array__GetRank(param1_01,1,0);
		    iVar1 = Method_System_Collections_Generic_List_StoneMono__Add__;
		    for (; Method_System_Collections_Generic_List_StoneMono__Add__ = iVar1, iVar7 <= iVar5;
		        iVar7 = iVar7 + 1) {
		      uVar3 = *(undefined4 *)
		               (param1_01 + (*(int *)(*(int *)(param1_01 + 8) + 8) * iVar6 + iVar7) * 4 + 0x10);
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar2 = *(uint *)(param1_00 + 0xc);
		      if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = uVar3;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      iVar1 = Method_System_Collections_Generic_List_StoneMono__Add__;
		    }
		  }
		  uVar2 = 0;
		  param1_02 = *(int **)(param1 + 0x98);
		  iVar6 = *param1_02;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Utils_Cache_IPool_IStoneParticles__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar8 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80c71779;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar8 = (uint *)func_ii_1080(param1_02,Utils_Cache_IPool_IStoneParticles__TypeInfo,0);
		code_r0x80c71779:
		  (**(code **)((ulonglong)*puVar8 * 4))(param1_02,puVar8[1]);
		  System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x88B8", Offset = "0x88B8", VA = "0x88B8")]
		private void StartWinAnimation()
		{
		/* --- GHIDRA: StartWinAnimation ---
		void Gameplay_Combat_View_GameField_GameFieldMono__StartWinAnimation(int param1,undefined4 param2)
		
		{
		  undefined4 param3;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x78);
		  param2_00 = *(undefined4 *)(param1 + 0x3c);
		  param3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param1,0);
		  Gameplay_Combat_View_Animations_EmptyCombatAnimation___ctor(param1_00,param2_00,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391E")]
		[Address(RVA = "0x88B9", Offset = "0x88B9", VA = "0x88B9")]
		private void StartLoseAnimation()
		{
		/* --- GHIDRA: StartLoseAnimation ---
		void Gameplay_Combat_View_GameField_GameFieldMono__StartLoseAnimation
		               (int param1,int param2,undefined4 param3,float param4,undefined4 param5)
		
		{
		  char cVar1;
		  float4 fVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  undefined8 local_28;
		  undefined8 local_20;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a5673c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_GameFieldMono_ResetGlowPoolObjectCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_GameFieldMono_ResetPoolObjectCallback__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPoolRestricted_StoneGlow___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPoolRestricted_StoneMono___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPoolRestricted_StoneGlow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPoolRestricted_StoneMono__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_BoxCollider2D___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneMono__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneGlow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_StoneMono____TypeInfo);
		    DAT_ram_00a5673c = '\x01';
		  }
		  *(int *)(param1 + 0xac) = param2;
		  iVar5 = *(int *)(param2 + 0x10);
		  iVar10 = *(int *)(param2 + 0x14);
		  *(int *)(param1 + 0x40) = iVar10;
		  *(int *)(param1 + 0x44) = iVar5;
		  *(float *)(param1 + 0x38) = param4;
		  *(float *)(param1 + 0x34) = (float)(iVar10 * 0x58 - 0x58);
		  *(float *)(param1 + 0x30) = (float)(iVar5 * 0x58 - 0x58);
		  iVar5 = *(int *)(param1 + 0x70);
		  *(undefined4 *)(iVar5 + 8) = param3;
		  uVar3 = Gameplay_Combat_View_GameField_CombatAnimationsMode__Init
		                    (iVar5,*(undefined4 *)(iVar5 + 0x14),param1);
		  *(undefined4 *)(param1 + 0x98) = uVar3;
		  uVar6 = *(undefined4 *)(param1 + 0x58);
		  uVar7 = *(undefined4 *)(param1 + 0x5c);
		  uVar3 = unnamed_function_1417(Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneMono__TypeInfo);
		  Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (uVar3,param1,
		             Method_Gameplay_Combat_View_GameField_GameFieldMono_ResetPoolObjectCallback__,0);
		  uVar4 = unnamed_function_1417(Utils_Cache_GameObjectPoolRestricted_StoneMono__TypeInfo);
		  UnityEngine_UIElements_UIR_Utility_GPUBuffer___Il2CppFullySharedGenericStructType___get_ElementStride
		            (uVar4,uVar6,uVar7,uVar3,Method_Utils_Cache_GameObjectPoolRestricted_StoneMono___ctor__)
		  ;
		  *(undefined4 *)(param1 + 0x90) = uVar4;
		  uVar3 = *(undefined4 *)(param1 + 0x60);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		  if (iVar5 != 0) {
		    uVar6 = *(undefined4 *)(param1 + 100);
		    uVar7 = *(undefined4 *)(param1 + 0x60);
		    uVar3 = unnamed_function_1417
		                      (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_StoneGlow__TypeInfo);
		    Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (uVar3,param1,
		               Method_Gameplay_Combat_View_GameField_GameFieldMono_ResetGlowPoolObjectCallback__,0);
		    uVar4 = unnamed_function_1417(Utils_Cache_GameObjectPoolRestricted_StoneGlow__TypeInfo);
		    UnityEngine_UIElements_UIR_Utility_GPUBuffer___Il2CppFullySharedGenericStructType___get_ElementStride
		              (uVar4,uVar7,uVar6,uVar3,
		               Method_Utils_Cache_GameObjectPoolRestricted_StoneGlow___ctor__);
		    *(undefined4 *)(param1 + 0x94) = uVar4;
		  }
		  iVar5 = *(int *)(param1 + 0x70);
		  if (DAT_ram_00a5672d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpactEmpty__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpact__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_GameFieldMono_ImpactDelegate_TypeInfo);
		    DAT_ram_00a5672d = '\x01';
		  }
		  cVar1 = *(char *)(*(int *)(iVar5 + 8) + 10);
		  iVar10 = unnamed_function_1417
		                     (Gameplay_Combat_View_GameField_GameFieldMono_ImpactDelegate_TypeInfo);
		  piVar8 = &Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpact__;
		  if (cVar1 == '\0') {
		    piVar8 = &Method_Gameplay_Combat_View_GameField_CombatAnimationsMode_HandleImpactEmpty__;
		  }
		  iVar9 = *piVar8;
		  uVar3 = *(undefined4 *)(iVar9 + 4);
		  *(int *)(iVar10 + 0x14) = iVar9;
		  *(undefined4 *)(iVar10 + 8) = uVar3;
		  *(int *)(iVar10 + 0x10) = iVar5;
		  cVar1 = *(char *)(iVar9 + 0x2e);
		  *(int *)(iVar10 + 0x20) = iVar10;
		  iVar5 = func_ii_4538(iVar9);
		  if (iVar5 == 0) {
		    if (cVar1 == '\x01') {
		      if (*(char *)(iVar10 + 0x38) == '\0') {
		        *(char **)(iVar10 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x215;
		      }
		      else {
		        iVar5 = unnamed_function_159288(iVar9);
		        iVar9 = func_ii_21171(iVar9);
		        if (iVar5 == 0) {
		          if (iVar9 == 0) {
		            *(char **)(iVar10 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x214;
		          }
		          else {
		            *(char **)(iVar10 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x213;
		          }
		        }
		        else if (iVar9 == 0) {
		          *(char **)(iVar10 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x212;
		        }
		        else {
		          *(char **)(iVar10 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x211;
		        }
		      }
		    }
		    else {
		      *(undefined4 *)(iVar10 + 0xc) = *(undefined4 *)(iVar10 + 8);
		      *(undefined4 *)(iVar10 + 0x20) = *(undefined4 *)(iVar10 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(iVar10 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x210;
		  }
		  else {
		    *(undefined4 *)(iVar10 + 0xc) = *(undefined4 *)(iVar10 + 8);
		    *(undefined4 *)(iVar10 + 0x20) = *(undefined4 *)(iVar10 + 0x10);
		  }
		  *(char **)(iVar10 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x216;
		  *(int *)(param1 + 0x8c) = iVar10;
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar3 = func_ii_6601(uVar3,Method_UnityEngine_GameObject_GetComponent_BoxCollider2D___);
		  local_4 = (float4)(float)(uint)(*(int *)(param1 + 0x40) * 0x58);
		  local_8 = (float4)(float)(uint)(*(int *)(param1 + 0x44) * 0x58);
		  local_20 = CONCAT44(local_4,local_8);
		  UnityEngine_BoxCollider2D__get_size(uVar3,&local_20,0);
		  UnityEngine_Collider2D__get_bounds_Injected(&local_10,uVar3,0);
		  fVar2 = local_10;
		  UnityEngine_Collider2D__get_bounds_Injected(&local_10,uVar3,0);
		  local_18 = (float4)((float)fVar2 * 0.5 + -44.0);
		  local_14 = (float4)((float)local_c * 0.5 + -44.0);
		  local_28 = CONCAT44(local_14,local_18);
		  UnityEngine_Rigidbody2D__set_bodyType_Injected(uVar3,&local_28,0);
		  _local_10 = *(ulonglong *)(param1 + 0x40) << 0x20 | *(ulonglong *)(param1 + 0x40) >> 0x20;
		  uVar3 = unnamed_function_2396(Gameplay_Combat_View_GameField_StoneMono____TypeInfo,&local_10);
		  *(undefined4 *)(param1 + 0x3c) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391F")]
		[Address(RVA = "0x88BA", Offset = "0x88BA", VA = "0x88BA", Slot = "6")]
		public override void InitField(GameFieldGamesData fieldData, UserSettings settings, float swapDuration)
		{
		/* --- GHIDRA: InitField ---
		void Gameplay_Combat_View_GameField_GameFieldMono__InitField
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (*(char *)(param2 + 8) == '\0') {
		    param1_00 = *(undefined4 *)(param1 + 0x78);
		    param2_00 = *(undefined4 *)(param1 + 0x3c);
		    param3_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (param1,0);
		    Gameplay_Combat_View_Animations_EmptyCombatAnimation___ctor(param1_00,param2_00,param3_00,0);
		  }
		  else {
		    Gameplay_Combat_View_GameField_GameFieldMono__MoveFieldEffectFigureOnPointer(param1,param1);
		  }
		  Gameplay_Combat_View_GameField_GameFieldMono__HandlePressDown(param1,param1);
		  iVar1 = *(int *)(param1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003920")]
		[Address(RVA = "0x37A8", Offset = "0x37A8", VA = "0x37A8")]
		public void ShowAddStones(IList<CellInfo> stones, float duration)
		{
		/* --- GHIDRA: ShowAddStones ---
		undefined4
		Gameplay_Combat_View_GameField_GameFieldMono__ShowAddStones
		          (int param1,uint param2,uint param3,undefined4 *param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a56728 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56728 = '\x01';
		  }
		  *param4 = 0;
		  if ((((-1 < (int)param3) && (-1 < (int)param2)) && (param3 <= *(int *)(param1 + 0x40) - 1U)) &&
		     (param2 <= *(int *)(param1 + 0x44) - 1U)) {
		    uVar1 = *(undefined4 *)
		             (*(int *)(param1 + 0x3c) +
		              (*(int *)(*(int *)(*(int *)(param1 + 0x3c) + 8) + 8) * param2 + param3) * 4 + 0x10);
		    *param4 = uVar1;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    uVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003921")]
		[Address(RVA = "0x37A7", Offset = "0x37A7", VA = "0x37A7")]
		public void ShowAddStonesFromCenter(IList<CellInfo> cells, float duration)
		{
		/* --- GHIDRA: ShowAddStonesFromCenter ---
		void Gameplay_Combat_View_GameField_GameFieldMono__ShowAddStonesFromCenter
		               (int param1,int *param2,float param3,undefined4 param4)
		
		{
		  uint uVar1;
		  float fVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5673d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_CellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_CellInfo__TypeInfo);
		    DAT_ram_00a5673d = '\x01';
		  }
		  fVar2 = Gameplay_Combat_Model_GameFieldGamesData__GetAnimationTimeByFieldChangeType
		                    (*(undefined4 *)(param1 + 0xac),2,0);
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_CellInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80c71c2e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_CellInfo__TypeInfo,0);
		code_r0x80c71c2e:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  fVar2 = Utils_MathUtils_MathUtils__SaferDivide(fVar2,uVar4,0);
		  do {
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_CellInfo__TypeInfo == *piVar7) {
		          puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80c71cb0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_CellInfo__TypeInfo,0
		                                 );
		code_r0x80c71cb0:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    if (iVar6 <= iVar5) {
		      Gameplay_Combat_View_GameField_GameFieldMono__HandlePressDown(param1,puVar3);
		      return;
		    }
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_CellInfo__TypeInfo == *piVar7) {
		          puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80c71d2f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_CellInfo__TypeInfo,0);
		code_r0x80c71d2f:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar5,puVar3[1]);
		    uVar4 = *(undefined4 *)(iVar6 + 0x10);
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_CellInfo__TypeInfo == *piVar7) {
		          puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80c71dae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_CellInfo__TypeInfo,0);
		code_r0x80c71dae:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar5,puVar3[1]);
		    param3_00 = *(undefined4 *)(*(int *)(iVar6 + 0xc) + 0xc);
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_CellInfo__TypeInfo == *piVar7) {
		          puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80c71e36;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_CellInfo__TypeInfo,0);
		code_r0x80c71e36:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar5,puVar3[1]);
		    Gameplay_Combat_View_GameField_GameFieldMono__HandleIsInteractiveChanged
		              (param1,uVar4,param3_00,*(undefined4 *)(*(int *)(iVar6 + 0xc) + 0x10),param3,
		               fVar2 * (float)iVar5,puVar3);
		    iVar5 = iVar5 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6003922")]
		[Address(RVA = "0x37AC", Offset = "0x37AC", VA = "0x37AC")]
		public UniTask ShowDestroyStones(List<StoneMono> stones, float destroyDuration, float shiftDuration)
		{
			return default(UniTask);
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003923")]
		[Address(RVA = "0x37AF", Offset = "0x37AF", VA = "0x37AF")]
		public void ShowSwapStones(int fromX, int fromY, int toX, int toY, float duration)
		{
		/* --- GHIDRA: ShowSwapStones ---
		void Gameplay_Combat_View_GameField_GameFieldMono__ShowSwapStones(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a532a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CombatEvent___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_CombatEvent__TypeInfo);
		    DAT_ram_00a532a0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_CombatEvent__TypeInfo)
		  ;
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_CombatEvent___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06003924 RID: 14628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003924")]
		[Address(RVA = "0x37B3", Offset = "0x37B3", VA = "0x37B3")]
		public void ShowClearFieldToCenter(float duration)
		{
		/* --- GHIDRA: ShowClearFieldToCenter ---
		int * Gameplay_Combat_View_GameField_GameFieldMono__ShowClearFieldToCenter(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  unnamed_function_103986(*(undefined4 *)param1[1]);
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003925")]
		[Address(RVA = "0x88BB", Offset = "0x88BB", VA = "0x88BB")]
		public void ShowEndAnimation(GameOverData gameOver)
		{
		/* --- GHIDRA: ShowEndAnimation ---
		void Gameplay_Combat_View_GameField_GameFieldMono__ShowEndAnimation
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Combat_View_GameField_BaseGameFieldMono__InitField(param1,param2,param1);
		  Gameplay_Combat_View_GameField_GameFieldMono__HandlePressDown(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003926 RID: 14630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003926")]
		[Address(RVA = "0x88BC", Offset = "0x88BC", VA = "0x88BC", Slot = "7")]
		public override void HandlePressDown(IPlayerInput input)
		{
		/* --- GHIDRA: HandlePressDown ---
		void Gameplay_Combat_View_GameField_GameFieldMono__HandlePressDown(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a56741 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_StoneGlow__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_StoneGlow__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_StoneGlow__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_StoneGlow__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_StoneGlow__GetEnumerator__)
		    ;
		    DAT_ram_00a56741 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x88),
		             Method_System_Collections_Generic_List_StoneGlow__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_StoneGlow__MoveNext__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c71fbf;
		    }
		    if (iVar1 == 0) goto code_r0x80c72015;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x218,local_8._4_4_,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x219,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c71fbf:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80c72015:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x88);
		      iVar1 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21a,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003927 RID: 14631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003927")]
		[Address(RVA = "0x88BD", Offset = "0x88BD", VA = "0x88BD")]
		public void HideHint()
		{
		/* --- GHIDRA: HideHint ---
		void Gameplay_Combat_View_GameField_GameFieldMono__HideHint(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a56743 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_StoneGlow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_StoneGlow__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_StoneMono_StoneSkinProvider_TypeInfo);
		    DAT_ram_00a56743 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x80) = 0x3f00000042b40000;
		  *(undefined4 *)(param1 + 0x7c) = 600;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_StoneGlow__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_StoneGlow___ctor__);
		  *(undefined4 *)(param1 + 0x88) = uVar1;
		  uVar1 = unnamed_function_1417(Gameplay_Combat_View_GameField_StoneMono_StoneSkinProvider_TypeInfo)
		  ;
		  Gameplay_Combat_View_GameField_StoneMono_StoneSkinProvider__SetupParticleMaterialProps
		            (uVar1,param1);
		  *(undefined4 *)(param1 + 0xb8) = uVar1;
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

		// Token: 0x06003928 RID: 14632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003928")]
		[Address(RVA = "0x1C30", Offset = "0x1C30", VA = "0x1C30")]
		public void Glow(StoneMono stone, out float duration)
		{
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x88BE", Offset = "0x88BE", VA = "0x88BE")]
		public GameFieldMono()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_GameField_GameFieldMono___ctor
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x215;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x214;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x213;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x212;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x211;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x210;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x216;
		  return;
		}
		*/

		}

		// Token: 0x04001F87 RID: 8071
		[Token(Token = "0x4001F87")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StoneMono _stonePrefab;

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Transform _stoneParent;

		// Token: 0x04001F89 RID: 8073
		[Token(Token = "0x4001F89")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StoneGlow _stoneGlow;

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Transform _glowParent;

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SpriteRenderer _fieldBlockSpriteRenderer;

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private SpellFieldFigure _spellfieldFigure;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CombatAnimationsMode _animationsConfig;

		// Token: 0x04001F8E RID: 8078
		[Token(Token = "0x4001F8E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private WinFieldAnimation _winAnimation;

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LoseFieldAnimation _loseAnimation;

		// Token: 0x04001F90 RID: 8080
		[Token(Token = "0x4001F90")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int _startStoneSpawnY;

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _clearCenterRotate;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _clearCenterFade;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<StoneGlow> _activeGlows;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x8C")]
		private GameFieldMono.ImpactDelegate _impact;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		[FieldOffset(Offset = "0x90")]
		private GameObjectPool<StoneMono> _stonePool;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x94")]
		private GameObjectPool<StoneGlow> _stoneGlowPool;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		[FieldOffset(Offset = "0x98")]
		private IPool<IStoneParticles> _particlesPool;

		// Token: 0x04001F98 RID: 8088
		[Token(Token = "0x4001F98")]
		[FieldOffset(Offset = "0x9C")]
		private BoxCollider2D _collider;

		// Token: 0x04001F99 RID: 8089
		[Token(Token = "0x4001F99")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 _lastMousePosition;

		// Token: 0x04001F9A RID: 8090
		[Token(Token = "0x4001F9A")]
		[FieldOffset(Offset = "0xAC")]
		private GameFieldGamesData _fieldData;

		// Token: 0x04001F9B RID: 8091
		[Token(Token = "0x4001F9B")]
		[FieldOffset(Offset = "0xB0")]
		private int _inBoundsCount;

		// Token: 0x04001F9C RID: 8092
		[Token(Token = "0x4001F9C")]
		[FieldOffset(Offset = "0xB4")]
		private bool _isInteractive;

		// Token: 0x04001F9D RID: 8093
		[Token(Token = "0x4001F9D")]
		[FieldOffset(Offset = "0xB5")]
		private bool _enableFollowFieldEffectFigureOnPointer;

		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		[FieldOffset(Offset = "0xB6")]
		private bool _fieldBlackoutVisible;

		// Token: 0x02000964 RID: 2404
		// (Invoke) Token: 0x0600392B RID: 14635
		[Token(Token = "0x2000964")]
		public delegate void ImpactDelegate(IEnumerable<StoneMono> stones, StoneMono[,] allStones);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnStoneDestroyed ---
		void Gameplay_Combat_View_GameField_GameFieldMono__add_OnStoneDestroyed
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a56731 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a56731 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x4c,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnStoneDestroyed ---
		void Gameplay_Combat_View_GameField_GameFieldMono__remove_OnStoneDestroyed
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a56732 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a56732 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnGameOver ---
		void Gameplay_Combat_View_GameField_GameFieldMono__add_OnGameOver
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a56733 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a56733 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnGameOver ---
		void Gameplay_Combat_View_GameField_GameFieldMono__remove_OnGameOver
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a56734 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a56734 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x54,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnInteractiveChanged ---
		void Gameplay_Combat_View_GameField_GameFieldMono__add_OnInteractiveChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a56735 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a56735 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x54,param1_01,param1_00);
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


		/* --- GHIDRA: get_FieldBlackoutVisible ---
		void Gameplay_Combat_View_GameField_GameFieldMono__get_FieldBlackoutVisible
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  
		  if (DAT_ram_00a56736 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a56736 = '\x01';
		  }
		  if (param2 != *(byte *)(param1 + 0xb6)) {
		    *(char *)(param1 + 0xb6) = (char)param2;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x68),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    func_ii_8007(*(undefined4 *)(param1 + 0x68),0,0);
		    fVar2 = 1.0;
		    if (*(char *)(param1 + 0xb6) == '\0') {
		      fVar2 = 0.0;
		    }
		    uVar1 = DG_Tweening_DOTweenModuleSprite__DOColor(*(undefined4 *)(param1 + 0x68),fVar2,0.2,0);
		    uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar1,6,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		                      );
		    fVar2 = 0.2;
		    if (*(char *)(param1 + 0xb6) == '\0') {
		      fVar2 = 0.0;
		    }
		    DG_Tweening_DOTweenModuleUI__DOFade
		              (uVar1,fVar2,
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		              );
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsInteractive ---
		void Gameplay_Combat_View_GameField_GameFieldMono__set_IsInteractive
		               (undefined4 param1,int *param2,float param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5673e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_CellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_CellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a5673e = '\x01';
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_CellInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80c7217d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_CellInfo__TypeInfo,0);
		code_r0x80c7217d:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80c7224b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x80c723d3:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c723db;
		    }
		code_r0x80c7224b:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x80c723d3;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      puVar2 = DAT_ram_009d3e38;
		      goto code_r0x80c72424;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_CellInfo__TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80c72325;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_CellInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x80c723bf:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c723db;
		    }
		code_r0x80c72325:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x80c723bf;
		    uVar4 = *(undefined4 *)(*(int *)(iVar8 + 0xc) + 0xc);
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_iiiiifi
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21b,param1,
		               *(undefined4 *)(iVar8 + 0x10),uVar4,*(undefined4 *)(*(int *)(iVar8 + 0xc) + 0x10),
		               param3,uVar4);
		    iVar8 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		  } while (iVar8 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c723db:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    puVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (puVar2 != (uint *)0x1) {
		code_r0x80c72424:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80c7249c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80c7249c:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar8 == 0) {
		        Gameplay_Combat_View_GameField_GameFieldMono__HandlePressDown(param1,puVar2);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21c,&local_c);
		  iVar8 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_EnableFollowFieldEffectFigureOnPointer ---
		void Gameplay_Combat_View_GameField_GameFieldMono__get_EnableFollowFieldEffectFigureOnPointer
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0xb0) = 0;
		  *(undefined1 *)(param1 + 0xb5) = (undefined1)param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_EnableFollowFieldEffectFigureOnPointer ---
		void Gameplay_Combat_View_GameField_GameFieldMono__set_EnableFollowFieldEffectFigureOnPointer
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_Animations_LoseFieldAnimation__LoseEffect(*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Combat_View_GameField_StoneMono_StoneAppearanceRecord___ctor
		            (*(undefined4 *)(param1 + 0xb8),param1);
		  func_ii_8007(*(undefined4 *)(param1 + 0x68),0,0);
		  Gameplay_Combat_View_GameField_BaseGameFieldMono__set_IsPressed(param1,param1);
		  return;
		}
		*/

}
