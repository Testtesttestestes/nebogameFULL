using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.InvitesTab
{
	// Token: 0x02000B6E RID: 2926
	[Token(Token = "0x2000B6E")]
	public class BossInvitesListAdapter : OSA<BaseParamsWithPrefab, BossInviteItemViewHolder>
	{
		// Token: 0x140001BF RID: 447
		// (add) Token: 0x06004710 RID: 18192 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004711 RID: 18193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BF")]
		public event Action<BossInviteData> SelectedEvent
		{
			[Token(Token = "0x6004710")]
			[Address(RVA = "0x95A6", Offset = "0x95A6", VA = "0x95A6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004711")]
			[Address(RVA = "0x95A7", Offset = "0x95A7", VA = "0x95A7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004713 RID: 18195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E25")]
		public SimpleDataHelper<BossInviteData> Data
		{
			[Token(Token = "0x6004712")]
			[Address(RVA = "0x95A8", Offset = "0x95A8", VA = "0x95A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004713")]
			[Address(RVA = "0x95A9", Offset = "0x95A9", VA = "0x95A9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06004714 RID: 18196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E26")]
		public BossInviteData SelectedItem
		{
			[Token(Token = "0x6004714")]
			[Address(RVA = "0x95AA", Offset = "0x95AA", VA = "0x95AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004715")]
		[Address(RVA = "0x95AB", Offset = "0x95AB", VA = "0x95AB", Slot = "67")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__Awake
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
		  
		  if (DAT_ram_00a57a1a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_InvitesTab_BossInviteItemViewHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter_BossInviteItemViewOnClickEvent__
		              );
		    DAT_ram_00a57a1a = '\x01';
		  }
		  param1_01 = unnamed_function_1417(Gameplay_Boss_View_InvitesTab_BossInviteItemViewHolder_TypeInfo)
		  ;
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_01,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar3 = *(int *)(param1_01 + 0x14);
		  param1_02 = unnamed_function_1417(System_Action_BossInviteData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_02,param1,
		             Method_Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter_BossInviteItemViewOnClickEvent__
		             ,0);
		  if (DAT_ram_00a57a12 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    DAT_ram_00a57a12 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_03 = UnityEngine_UI_Image__set_sprite(param1_00,param1_02,0);
		    param2_00 = System_Action_BossInviteData__TypeInfo;
		    if ((param1_03 != 0) &&
		       (iVar2 = func_ii_1082(param1_03,System_Action_BossInviteData__TypeInfo), iVar2 == 0)) break;
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

		// Token: 0x06004716 RID: 18198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004716")]
		[Address(RVA = "0x95AC", Offset = "0x95AC", VA = "0x95AC", Slot = "99")]
		protected override BossInviteItemViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__CreateViewsHolder
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__BossInviteItemViewOnClickEvent
		            (param1,param2,param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004717")]
		[Address(RVA = "0x95AD", Offset = "0x95AD", VA = "0x95AD")]
		private void BossInviteItemViewOnClickEvent(BossInviteData data)
		{
		/* --- GHIDRA: BossInviteItemViewOnClickEvent ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__BossInviteItemViewOnClickEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57a1b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInviteData__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder__GetItemViewsHolderIfVisible__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__get_List__
		              );
		    DAT_ram_00a57a1b = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0xa8);
		  *(int *)(param1 + 0xa8) = param2;
		  if (iVar2 != 0) {
		    uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (*(undefined4 *)(*(int *)(param1 + 0xa4) + 0xc),iVar2,
		                       Method_System_Collections_Generic_List_BossInviteData__IndexOf__);
		    iVar2 = Com_TheFallenGames_OSA_Core_OSA_object__object___GetItemViewsHolder
		                      (param1,uVar1,
		                       Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder__GetItemViewsHolderIfVisible__
		                      );
		    if (iVar2 != 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		    }
		    param2 = *(int *)(param1 + 0xa8);
		  }
		  if (param2 != 0) {
		    uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (*(undefined4 *)(*(int *)(param1 + 0xa4) + 0xc),param2,
		                       Method_System_Collections_Generic_List_BossInviteData__IndexOf__);
		    iVar2 = Com_TheFallenGames_OSA_Core_OSA_object__object___GetItemViewsHolder
		                      (param1,uVar1,
		                       Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder__GetItemViewsHolderIfVisible__
		                      );
		    if (iVar2 != 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,1,0);
		    }
		  }
		  iVar2 = *(int *)(param1 + 0xa0);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param1 + 0xa8),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x95AE", Offset = "0x95AE", VA = "0x95AE")]
		public void Select(BossInviteData instanceInfo)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__Select
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57a1c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter_BossInviteItemViewOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a57a1c = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_BossInviteData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter_BossInviteItemViewOnClickEvent__
		             ,0);
		  if (DAT_ram_00a57a13 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    DAT_ram_00a57a13 = '\x01';
		  }
		  iVar5 = *(int *)(iVar4 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_00 = func_ii_7048(iVar5,uVar3,0);
		    param2_00 = System_Action_BossInviteData__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar2 = func_ii_1082(param1_00,System_Action_BossInviteData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x20,iVar2,iVar5);
		    bVar1 = iVar2 == iVar5;
		    iVar5 = iVar2;
		    if (bVar1) {
		      iVar4 = *(int *)(param2 + 0x14);
		      if (DAT_ram_00a57a14 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_DataOnCaptainUserDataChangedEvent__
		                  );
		        DAT_ram_00a57a14 = '\x01';
		      }
		      iVar5 = *(int *)(iVar4 + 0x24);
		      if (iVar5 != 0) {
		        uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		        UnityEngine_Events_UnityEvent__AddListener
		                  (uVar3,iVar4,
		                   Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_DataOnCaptainUserDataChangedEvent__
		                   ,0);
		        Gameplay_Boss_Model_BossInviteData__add_CaptainUserDataChangedEvent(iVar5,uVar3,0);
		      }
		      *(undefined4 *)(iVar4 + 0x24) = 0;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x95AF", Offset = "0x95AF", VA = "0x95AF", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossInviteItemViewHolder vh, bool isActive)
		{
		/* --- GHIDRA: OnBeforeDestroyViewsHolder ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__OnBeforeDestroyViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57a1d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__get_Item__
		              );
		    DAT_ram_00a57a1d = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa4);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  param2_00 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                        (param1_00,uVar1,
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__get_Item__
		                        );
		  Gameplay_Boss_View_InvitesTab_BossInviteItemView__get_Data(param2[5],param2_00,param2);
		  iVar2 = *(int *)(param1 + 0xa8);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param2[5] + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(iVar2 == param2_00),0);
		  return;
		}
		*/

		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471A")]
		[Address(RVA = "0x95B0", Offset = "0x95B0", VA = "0x95B0", Slot = "100")]
		protected override void UpdateViewsHolder(BossInviteItemViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__UpdateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57a1e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__ResetItems__
		              );
		    DAT_ram_00a57a1e = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa4),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471B")]
		[Address(RVA = "0x95B1", Offset = "0x95B1", VA = "0x95B1")]
		public void SetItems(List<BossInviteData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__SetItems
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a1f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder___ctor__
		              );
		    DAT_ram_00a57a1f = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600471C RID: 18204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471C")]
		[Address(RVA = "0x95B2", Offset = "0x95B2", VA = "0x95B2")]
		public BossInvitesListAdapter()
		{
		}

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[FieldOffset(Offset = "0xA8")]
		private BossInviteData _selectedItem;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a18 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    DAT_ram_00a57a18 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInviteData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInviteData__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: get_SelectedItem ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__get_SelectedItem
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__TypeInfo);
		    DAT_ram_00a57a19 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData___ctor__);
		  *(undefined4 *)(param1 + 0xa4) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossInviteItemViewHolder__Start__
		            );
		  return;
		}
		*/

}
