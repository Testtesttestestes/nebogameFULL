using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Gameplay.GdEvents.View.Milestone
{
	// Token: 0x02000721 RID: 1825
	[Token(Token = "0x2000721")]
	public class MilestonesListOsaView : OSA<BaseParamsWithPrefab, MyItemViewsHolder>
	{
		// Token: 0x1400015F RID: 351
		// (add) Token: 0x06002BAA RID: 11178 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002BAB RID: 11179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015F")]
		public event Action<MilestoneData> ClickEvent
		{
			[Token(Token = "0x6002BAA")]
			[Address(RVA = "0x7C41", Offset = "0x7C41", VA = "0x7C41")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002BAB")]
			[Address(RVA = "0x7C42", Offset = "0x7C42", VA = "0x7C42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000852")]
		public SimpleDataHelper<MilestoneData> Data
		{
			[Token(Token = "0x6002BAC")]
			[Address(RVA = "0x7C43", Offset = "0x7C43", VA = "0x7C43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BAD")]
			[Address(RVA = "0x7C44", Offset = "0x7C44", VA = "0x7C44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x7C45", Offset = "0x7C45", VA = "0x7C45", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__Start
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a26a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_View_Milestone_MyItemViewsHolder_TypeInfo);
		    DAT_ram_00a5a26a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_GdEvents_View_Milestone_MyItemViewsHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x7C46", Offset = "0x7C46", VA = "0x7C46", Slot = "99")]
		protected override MyItemViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int local_4;
		  
		  if (DAT_ram_00a5a26b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MilestoneData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_View_Milestone_MilestonesListOsaView_DispatchClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__get_Item__
		              );
		    DAT_ram_00a5a26b = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0xa8);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (uVar2,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__get_Item__
		                    );
		  iVar3 = param2[5];
		  uVar2 = unnamed_function_1417(System_Action_MilestoneData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_View_Milestone_MilestonesListOsaView_DispatchClickEvent__,0);
		  *(undefined4 *)(iVar3 + 0x2c) = uVar2;
		  iVar3 = param2[5];
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xe4));
		  if (DAT_ram_00a5a266 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a266 = '\x01';
		  }
		  piVar4 = *(int **)(iVar3 + 0x10);
		  local_4 = local_4 + 1;
		  iVar3 = func_ii_4443(&local_4,0);
		  if (iVar3 == 0) {
		    iVar3 = StringLiteral_5;
		  }
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,iVar3,*(undefined4 *)(iVar5 + 0x2d4));
		  iVar3 = param2[5];
		  *(undefined4 *)(iVar3 + 0x30) = uVar1;
		  Gameplay_GdEvents_View_Milestone_MilestoneItemView__set_Data(iVar3,iVar3);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB0")]
		[Address(RVA = "0x7C47", Offset = "0x7C47", VA = "0x7C47", Slot = "100")]
		protected override void UpdateViewsHolder(MyItemViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__UpdateViewsHolder
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a5a26c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder__OnItemIndexChangedDueInsertOrRemove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__get_Item__
		              );
		    DAT_ram_00a5a26c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa8);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		            (param1_00,param2_00,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__get_Item__);
		  iVar1 = param2[5];
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xe4));
		  if (DAT_ram_00a5a266 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a266 = '\x01';
		  }
		  piVar2 = *(int **)(iVar1 + 0x10);
		  local_4 = local_4 + 1;
		  iVar1 = func_ii_4443(&local_4,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB1")]
		[Address(RVA = "0x7C48", Offset = "0x7C48", VA = "0x7C48", Slot = "101")]
		protected override void OnItemIndexChangedDueInsertOrRemove(MyItemViewsHolder shiftedViewsHolder, int oldIndex, bool wasInsert, int removeOrInsertIndex)
		{
		/* --- GHIDRA: OnItemIndexChangedDueInsertOrRemove ---
		void Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__OnItemIndexChangedDueInsertOrRemove
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a5a26d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder__ChangeItemsCount__
		              );
		    DAT_ram_00a5a26d = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___ChangeItemSizeAndUpdateContentSizeAccordingly
		            (param1,param2,param3,param4,param5,param6,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder__ChangeItemsCount__
		            );
		  if (*(int *)(param1 + 0xa4) != 0) {
		    UnityEngine_Events_UnityEvent__GetDelegate(*(int *)(param1 + 0xa4),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB2")]
		[Address(RVA = "0x7C49", Offset = "0x7C49", VA = "0x7C49", Slot = "83")]
		public override void ChangeItemsCount(ItemCountChangeMode changeMode, int itemsCount, int indexIfInsertingOrRemoving = -1, bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0x7C4A", Offset = "0x7C4A", VA = "0x7C4A")]
		private void DispatchClickEvent(MilestoneData data)
		{
		/* --- GHIDRA: DispatchClickEvent ---
		void Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__DispatchClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a26e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder___ctor__
		              );
		    DAT_ram_00a5a26e = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0x7C4B", Offset = "0x7C4B", VA = "0x7C4B")]
		public MilestonesListOsaView()
		{
		}

		// Token: 0x040017EC RID: 6124
		[Token(Token = "0x40017EC")]
		[FieldOffset(Offset = "0xA4")]
		public UnityEvent OnItemsUpdated;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a268 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MilestoneData__TypeInfo);
		    DAT_ram_00a5a268 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MilestoneData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MilestoneData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa0,iVar2,param1_00);
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


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a269 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__TypeInfo);
		    DAT_ram_00a5a269 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData___ctor__);
		  *(undefined4 *)(param1 + 0xa8) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder__Start__
		            );
		  return;
		}
		*/

}
