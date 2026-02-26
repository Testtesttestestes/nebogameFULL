using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B81 RID: 2945
	[Token(Token = "0x2000B81")]
	public class BossTeamEditListAdapter : OSA<BaseParamsWithPrefab, BossPossibleAssistantViewHolder>
	{
		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4D")]
		public SimpleDataHelper<UserData> Data
		{
			[Token(Token = "0x6004784")]
			[Address(RVA = "0x9614", Offset = "0x9614", VA = "0x9614")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004785")]
			[Address(RVA = "0x9615", Offset = "0x9615", VA = "0x9615")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001C4 RID: 452
		// (add) Token: 0x06004786 RID: 18310 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004787 RID: 18311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C4")]
		public event Action<UserData> ClickedEvent
		{
			[Token(Token = "0x6004786")]
			[Address(RVA = "0x9616", Offset = "0x9616", VA = "0x9616")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004787")]
			[Address(RVA = "0x9617", Offset = "0x9617", VA = "0x9617")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004788")]
		[Address(RVA = "0x9618", Offset = "0x9618", VA = "0x9618", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__Start
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
		  
		  if (DAT_ram_00a57a57 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_View_CaptainTab_BossPossibleAssistantViewHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter_AssistantViewOnClickedEvent__
		              );
		    DAT_ram_00a57a57 = '\x01';
		  }
		  param1_01 = unnamed_function_1417
		                        (Gameplay_Boss_View_CaptainTab_BossPossibleAssistantViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_01,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar3 = *(int *)(param1_01 + 0x14);
		  param1_02 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_02,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter_AssistantViewOnClickedEvent__
		             ,0);
		  if (DAT_ram_00a57a6b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a57a6b = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_03 = UnityEngine_UI_Image__set_sprite(param1_00,param1_02,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_03 != 0) &&
		       (iVar2 = func_ii_1082(param1_03,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x24,iVar2,param1_00);
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

		// Token: 0x06004789 RID: 18313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004789")]
		[Address(RVA = "0x9619", Offset = "0x9619", VA = "0x9619", Slot = "99")]
		protected override BossPossibleAssistantViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__CreateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xa4);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478A")]
		[Address(RVA = "0x961A", Offset = "0x961A", VA = "0x961A")]
		private void AssistantViewOnClickedEvent(UserData data)
		{
		/* --- GHIDRA: AssistantViewOnClickedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__AssistantViewOnClickedEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a58 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__get_Item__);
		    DAT_ram_00a57a58 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__get_Item__
		                    );
		  Gameplay_Boss_View_CaptainTab_BossUserListItemView__get_UserData(param2[5],uVar1,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478B")]
		[Address(RVA = "0x961B", Offset = "0x961B", VA = "0x961B", Slot = "100")]
		protected override void UpdateViewsHolder(BossPossibleAssistantViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__UpdateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57a59 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter_AssistantViewOnClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossPossibleAssistantViewHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a57a59 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x14);
		  param1_01 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter_AssistantViewOnClickedEvent__
		             ,0);
		  if (DAT_ram_00a57a6c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a57a6c = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x24,iVar2,param1_00);
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

		// Token: 0x0600478C RID: 18316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478C")]
		[Address(RVA = "0x961C", Offset = "0x961C", VA = "0x961C", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossPossibleAssistantViewHolder vh, bool isActive)
		{
		/* --- GHIDRA: OnBeforeDestroyViewsHolder ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__OnBeforeDestroyViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57a5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__InsertItems__);
		    DAT_ram_00a57a5a = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__InsertItems__);
		  return;
		}
		*/

		}

		// Token: 0x0600478D RID: 18317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478D")]
		[Address(RVA = "0x961D", Offset = "0x961D", VA = "0x961D")]
		public void AddItemsAt(int index, IList<UserData> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57a5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__RemoveItems__);
		    DAT_ram_00a57a5b = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__RemoveItems__);
		  return;
		}
		*/

		}

		// Token: 0x0600478E RID: 18318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478E")]
		[Address(RVA = "0x961E", Offset = "0x961E", VA = "0x961E")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__RemoveItemsFrom
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57a5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__ResetItems__);
		    DAT_ram_00a57a5c = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__ResetItems__);
		  return;
		}
		*/

		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478F")]
		[Address(RVA = "0x961F", Offset = "0x961F", VA = "0x961F")]
		public void SetItems(IList<UserData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__SetItems(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57a5d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__ResetItems__);
		    DAT_ram_00a57a5d = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0xa0);
		  if (param1_01 != 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_UserData__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_UserData___ctor__);
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		              (param1_01,param1_00,0,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__ResetItems__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004790 RID: 18320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004790")]
		[Address(RVA = "0x9620", Offset = "0x9620", VA = "0x9620")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__Clear
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a5e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossPossibleAssistantViewHolder___ctor__
		              );
		    DAT_ram_00a57a5e = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossPossibleAssistantViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004791")]
		[Address(RVA = "0x9621", Offset = "0x9621", VA = "0x9621")]
		public BossTeamEditListAdapter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a54 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a57a54 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_ClickedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a55 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a57a55 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ClickedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__remove_ClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossPossibleAssistantViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__TypeInfo);
		    DAT_ram_00a57a56 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData__TypeInfo);
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_UserData___ctor__);
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossPossibleAssistantViewHolder__Start__
		            );
		  return;
		}
		*/

}
