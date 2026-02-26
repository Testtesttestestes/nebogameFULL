using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using DG.Tweening;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D54 RID: 3412
	[Token(Token = "0x2000D54")]
	public class AprsOsaGridView : GridAdapter<GridParams, AprCellViewHolder>
	{
		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FF")]
		public SimpleDataHelper<AprData> Data
		{
			[Token(Token = "0x60053A8")]
			[Address(RVA = "0xA167", Offset = "0xA167", VA = "0xA167")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053A9")]
			[Address(RVA = "0xA168", Offset = "0xA168", VA = "0xA168")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AA")]
		[Address(RVA = "0xA169", Offset = "0xA169", VA = "0xA169", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Aprs_View_AprsOsaGridView__Start(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5940f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprsOsaGridView_NotifyStencilDelayed__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__get_Item__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a5940f = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xb4);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__get_Item__)
		  ;
		  iVar2 = *(int *)param2[6];
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            ((int *)param2[6],uVar1,*(undefined4 *)(iVar2 + 0x13c));
		  if (*(int *)(param1 + 0xb8) == 0) {
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,Method_Gameplay_Aprs_View_AprsOsaGridView_NotifyStencilDelayed__,0);
		    uVar1 = DG_Tweening_DOVirtual__EasedValue(0.1,uVar1,1,0);
		    *(undefined4 *)(param1 + 0xb8) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AB")]
		[Address(RVA = "0xA16A", Offset = "0xA16A", VA = "0xA16A", Slot = "128")]
		protected override void UpdateCellViewsHolder(AprCellViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Gameplay_Aprs_View_AprsOsaGridView__UpdateCellViewsHolder(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59410 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59410 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xb8) = 0;
		  param1_00 = *(undefined4 *)(param1 + 0xb0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    UnityEngine_UI_MaskUtilities__Notify2DMaskStateChanged(*(undefined4 *)(param1 + 0xb0),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053AC RID: 21420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AC")]
		[Address(RVA = "0xA16B", Offset = "0xA16B", VA = "0xA16B")]
		private void NotifyStencilDelayed()
		{
		/* --- GHIDRA: NotifyStencilDelayed ---
		void Gameplay_Aprs_View_AprsOsaGridView__NotifyStencilDelayed
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59411 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__AprCellViewHolder__OnBeforeRecycleOrDisableCellViewsHolder__
		              );
		    DAT_ram_00a59411 = '\x01';
		  }
		  iVar1 = **(int **)(param2 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param2 + 0x18),0,*(undefined4 *)(iVar1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x060053AD RID: 21421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AD")]
		[Address(RVA = "0xA16C", Offset = "0xA16C", VA = "0xA16C", Slot = "129")]
		protected override void OnBeforeRecycleOrDisableCellViewsHolder(AprCellViewHolder inRecycleBinOrVisible, int newItemIndex)
		{
		/* --- GHIDRA: OnBeforeRecycleOrDisableCellViewsHolder ---
		void Gameplay_Aprs_View_AprsOsaGridView__OnBeforeRecycleOrDisableCellViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a59412 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__InsertRange__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__get_List__);
		    DAT_ram_00a59412 = '\x01';
		  }
		  System_Collections_Generic_List_object___GetRange
		            (*(undefined4 *)(*(int *)(param1 + 0xb4) + 0xc),param2,param3,
		             Method_System_Collections_Generic_List_AprData__InsertRange__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(param1 + 0xb4),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060053AE RID: 21422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AE")]
		[Address(RVA = "0xA16D", Offset = "0xA16D", VA = "0xA16D")]
		public void AddItemsAt(int index, IList<AprData> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Aprs_View_AprsOsaGridView__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a59413 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__RemoveRange__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__get_List__);
		    DAT_ram_00a59413 = '\x01';
		  }
		  System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___RemoveAt
		            (*(undefined4 *)(*(int *)(param1 + 0xb4) + 0xc),param2,param3,
		             Method_System_Collections_Generic_List_AprData__RemoveRange__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(param1 + 0xb4),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AF")]
		[Address(RVA = "0xA16E", Offset = "0xA16E", VA = "0xA16E")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Aprs_View_AprsOsaGridView__RemoveItemsFrom(int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59414 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__ResetItems__);
		    DAT_ram_00a59414 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (param1[0x2d],param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__ResetItems__);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_AprData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80fff294;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_AprData__TypeInfo,0);
		code_r0x80fff294:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (0 < iVar3) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x390) * 4))
		              (param1,0,0,0,*(undefined4 *)(*param1 + 0x394));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B0")]
		[Address(RVA = "0xA16F", Offset = "0xA16F", VA = "0xA16F")]
		public void SetItems(IList<AprData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Aprs_View_AprsOsaGridView__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a59415 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprsOsaGridView_NotifyStencilDelayed__);
		    DAT_ram_00a59415 = '\x01';
		  }
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,Method_Gameplay_Aprs_View_AprsOsaGridView_NotifyStencilDelayed__,0);
		  if (DAT_ram_00a593f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprView_TypeInfo);
		    DAT_ram_00a593f8 = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c);
		  while ((param1_02 = (int *)func_ii_7048(param1_00,param1_01,0), param1_02 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_02))) {
		    iVar2 = func_ii_4329(*(undefined4 *)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c),param1_02,
		                         param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B1")]
		[Address(RVA = "0xA170", Offset = "0xA170", VA = "0xA170", Slot = "73")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Aprs_View_AprsOsaGridView__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59416 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__AprCellViewHolder___ctor__
		              );
		    DAT_ram_00a59416 = '\x01';
		  }
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__AprCellViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B2")]
		[Address(RVA = "0xA171", Offset = "0xA171", VA = "0xA171")]
		public AprsOsaGridView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Aprs_View_AprsOsaGridView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59417 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12562);
		    DAT_ram_00a59417 = '\x01';
		  }
		  return StringLiteral_12562;
		}
		*/

		}

		// Token: 0x04002D56 RID: 11606
		[Token(Token = "0x4002D56")]
		[FieldOffset(Offset = "0xB0")]
		public Component MaskOnTop;

		// Token: 0x04002D58 RID: 11608
		[Token(Token = "0x4002D58")]
		[FieldOffset(Offset = "0xB8")]
		private Tween _delayedCall;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Aprs_View_AprsOsaGridView__set_Data(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5940e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprsOsaGridView_NotifyStencilDelayed__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_AprCellViewHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_AprCellViewHolder___get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__TypeInfo);
		    DAT_ram_00a5940e = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    uVar2 = unnamed_function_1417
		                      (Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__TypeInfo);
		    System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		              (uVar2,param1,1,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData___ctor__);
		    *(undefined4 *)(param1 + 0xb4) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Gameplay_Aprs_View_AprsOsaGridView_NotifyStencilDelayed__,0);
		    if (DAT_ram_00a593f7 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprView_TypeInfo);
		      DAT_ram_00a593f7 = '\x01';
		    }
		    param1_00 = **(int **)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c);
		    do {
		      param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		      if ((param1_01 != (int *)0x0) && (System_Action_TypeInfo != *param1_01)) {
		        System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(*(undefined4 *)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c),param1_01,
		                           param1_00);
		      bVar1 = iVar3 != param1_00;
		      param1_00 = iVar3;
		    } while (bVar1);
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_AprCellViewHolder___Start__
		              );
		  }
		  return;
		}
		*/

}
