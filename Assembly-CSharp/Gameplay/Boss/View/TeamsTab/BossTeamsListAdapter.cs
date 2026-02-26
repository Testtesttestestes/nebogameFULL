using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B55 RID: 2901
	[Token(Token = "0x2000B55")]
	public class BossTeamsListAdapter : OSA<BaseParamsWithPrefab, BossTeamsListItemViewHolder>
	{
		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004633 RID: 17971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD6")]
		public SimpleDataHelper<TeamRewardData> Data
		{
			[Token(Token = "0x6004632")]
			[Address(RVA = "0x94CB", Offset = "0x94CB", VA = "0x94CB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004633")]
			[Address(RVA = "0x94CC", Offset = "0x94CC", VA = "0x94CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001B1 RID: 433
		// (add) Token: 0x06004634 RID: 17972 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004635 RID: 17973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B1")]
		public event Action<TeamRewardData> ClickEvent
		{
			[Token(Token = "0x6004634")]
			[Address(RVA = "0x94CD", Offset = "0x94CD", VA = "0x94CD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004635")]
			[Address(RVA = "0x94CE", Offset = "0x94CE", VA = "0x94CE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004636")]
		[Address(RVA = "0x94CF", Offset = "0x94CF", VA = "0x94CF", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__Start
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  undefined4 param1_02;
		  int param1_03;
		  int iVar3;
		  
		  if (DAT_ram_00a579b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter_RendererOnButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_TeamsTab_BossTeamsListItemViewHolder_TypeInfo);
		    DAT_ram_00a579b9 = '\x01';
		  }
		  param1_01 = unnamed_function_1417
		                        (Gameplay_Boss_View_TeamsTab_BossTeamsListItemViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_01,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar3 = *(int *)(param1_01 + 0x14);
		  param1_02 = unnamed_function_1417(System_Action_TeamRewardData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_02,param1,
		             Method_Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter_RendererOnButtonClickedEvent__,
		             0);
		  if (DAT_ram_00a579bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    DAT_ram_00a579bf = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_03 = UnityEngine_UI_Image__set_sprite(param1_00,param1_02,0);
		    param2_00 = System_Action_TeamRewardData__TypeInfo;
		    if ((param1_03 != 0) &&
		       (iVar2 = func_ii_1082(param1_03,System_Action_TeamRewardData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return param1_01;
		    }
		  }
		  System_Activator__CreateInstance(param1_03,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004637")]
		[Address(RVA = "0x94D0", Offset = "0x94D0", VA = "0x94D0", Slot = "99")]
		protected override BossTeamsListItemViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004638")]
		[Address(RVA = "0x94D1", Offset = "0x94D1", VA = "0x94D1")]
		private void RendererOnButtonClickedEvent(TeamRewardData obj)
		{
		/* --- GHIDRA: RendererOnButtonClickedEvent ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__RendererOnButtonClickedEvent
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a579ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter_RendererOnButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossTeamsListItemViewHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a579ba = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x14);
		  param1_01 = unnamed_function_1417(System_Action_TeamRewardData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter_RendererOnButtonClickedEvent__,
		             0);
		  if (DAT_ram_00a579c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    DAT_ram_00a579c0 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_TeamRewardData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_TeamRewardData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004639")]
		[Address(RVA = "0x94D2", Offset = "0x94D2", VA = "0x94D2", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossTeamsListItemViewHolder vh, bool isActive)
		{
		/* --- GHIDRA: OnBeforeDestroyViewsHolder ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__OnBeforeDestroyViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData__get_Item__
		              );
		    DAT_ram_00a579bb = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData__get_Item__
		                    );
		  Gameplay_Boss_View_TeamsTab_BossTeamsListItemView__get_Data(param2[5],uVar1,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463A")]
		[Address(RVA = "0x94D3", Offset = "0x94D3", VA = "0x94D3", Slot = "100")]
		protected override void UpdateViewsHolder(BossTeamsListItemViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__UpdateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a579bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData__ResetItems__
		              );
		    DAT_ram_00a579bc = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463B")]
		[Address(RVA = "0x94D4", Offset = "0x94D4", VA = "0x94D4")]
		public void SetItems(List<TeamRewardData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossTeamsListItemViewHolder___ctor__
		              );
		    DAT_ram_00a579bd = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossTeamsListItemViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463C")]
		[Address(RVA = "0x94D5", Offset = "0x94D5", VA = "0x94D5")]
		public BossTeamsListAdapter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    DAT_ram_00a579b6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TeamRewardData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamRewardData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    DAT_ram_00a579b7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TeamRewardData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamRewardData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__remove_ClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossTeamsListItemViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData__TypeInfo);
		    DAT_ram_00a579b8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_TeamRewardData___ctor__);
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossTeamsListItemViewHolder__Start__
		            );
		  return;
		}
		*/

}
