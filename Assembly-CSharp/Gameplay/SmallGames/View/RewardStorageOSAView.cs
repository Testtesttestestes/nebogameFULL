using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Core.Data;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	public class RewardStorageOSAView : GridAdapter<GridParams, RewardsStorageCellViewHolder>
	{
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		public SimpleDataHelper<ArtifactData> Data
		{
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0x7061", Offset = "0x7061", VA = "0x7061")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFB")]
			[Address(RVA = "0x7062", Offset = "0x7062", VA = "0x7062")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x7063", Offset = "0x7063", VA = "0x7063", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__Start(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58659 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_RewardStorageOSAView_NotifyStencilDelayed__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a58659 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xb4);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__get_Item__
		                    );
		  iVar2 = *(int *)param2[6];
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		            ((int *)param2[6],uVar1,*(undefined4 *)(iVar2 + 0x13c));
		  if (*(int *)(param1 + 0xb8) == 0) {
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_View_RewardStorageOSAView_NotifyStencilDelayed__,0);
		    uVar1 = DG_Tweening_DOVirtual__EasedValue(0.1,uVar1,1,0);
		    *(undefined4 *)(param1 + 0xb8) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x7064", Offset = "0x7064", VA = "0x7064", Slot = "128")]
		protected override void UpdateCellViewsHolder(RewardsStorageCellViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__UpdateCellViewsHolder
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5865a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5865a = '\x01';
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

		// Token: 0x06001EFE RID: 7934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x7065", Offset = "0x7065", VA = "0x7065")]
		private void NotifyStencilDelayed()
		{
		/* --- GHIDRA: NotifyStencilDelayed ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__NotifyStencilDelayed
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5865b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__RewardsStorageCellViewHolder__OnBeforeRecycleOrDisableCellViewsHolder__
		              );
		    DAT_ram_00a5865b = '\x01';
		  }
		  iVar1 = **(int **)(param2 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param2 + 0x18),0,*(undefined4 *)(iVar1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x7066", Offset = "0x7066", VA = "0x7066", Slot = "129")]
		protected override void OnBeforeRecycleOrDisableCellViewsHolder(RewardsStorageCellViewHolder inRecycleBinOrVisible, int newItemIndex)
		{
		/* --- GHIDRA: OnBeforeRecycleOrDisableCellViewsHolder ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__OnBeforeRecycleOrDisableCellViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5865c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactData__InsertRange__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__NotifyListChangedExternally__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__get_List__)
		    ;
		    DAT_ram_00a5865c = '\x01';
		  }
		  System_Collections_Generic_List_object___GetRange
		            (*(undefined4 *)(*(int *)(param1 + 0xb4) + 0xc),param2,param3,
		             Method_System_Collections_Generic_List_ArtifactData__InsertRange__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(param1 + 0xb4),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x7067", Offset = "0x7067", VA = "0x7067")]
		public void AddItemsAt(int index, IList<ArtifactData> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5865d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactData__RemoveRange__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__NotifyListChangedExternally__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__get_List__)
		    ;
		    DAT_ram_00a5865d = '\x01';
		  }
		  System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___RemoveAt
		            (*(undefined4 *)(*(int *)(param1 + 0xb4) + 0xc),param2,param3,
		             Method_System_Collections_Generic_List_ArtifactData__RemoveRange__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(param1 + 0xb4),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x7068", Offset = "0x7068", VA = "0x7068")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__RemoveItemsFrom
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5865e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__ResetItems__
		              );
		    DAT_ram_00a5865e = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (param1[0x2d],param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__ResetItems__);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ArtifactData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f199d0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_ArtifactData__TypeInfo
		                                ,0);
		code_r0x80f199d0:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (0 < iVar3) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x390) * 4))
		              (param1,0,0,0,*(undefined4 *)(*param1 + 0x394));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x7069", Offset = "0x7069", VA = "0x7069")]
		public void SetItems(IList<ArtifactData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5865f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__RewardsStorageCellViewHolder___ctor__
		              );
		    DAT_ram_00a5865f = '\x01';
		  }
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__RewardsStorageCellViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x706A", Offset = "0x706A", VA = "0x706A")]
		public RewardStorageOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_View_RewardStorageOSAView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58660 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_ArtifactView___);
		    DAT_ram_00a58660 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellViewsHolder__InitWithExistingRootPrefab
		            (param1,0);
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_ArtifactView___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0xB0")]
		public Component MaskOnTop;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0xB8")]
		private Tween _delayedCall;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_SmallGames_View_RewardStorageOSAView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58658 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_RewardsStorageCellViewHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_RewardsStorageCellViewHolder___get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__TypeInfo);
		    DAT_ram_00a58658 = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417
		                          (
		                          Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData__TypeInfo
		                          );
		    System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		              (param1_00,param1,1,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ArtifactData___ctor__);
		    *(undefined4 *)(param1 + 0xb4) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_RewardsStorageCellViewHolder___Start__
		              );
		  }
		  return;
		}
		*/

}
