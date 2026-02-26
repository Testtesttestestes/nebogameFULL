using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AE9 RID: 2793
	[Token(Token = "0x2000AE9")]
	public class ChatRoomVisitorsListAdapter : OSA<BaseParamsWithPrefab, ChatVisitorViewsHolder>
	{
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600434F RID: 17231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D44")]
		public SimpleDataHelper<ChatVisitorData> Data
		{
			[Token(Token = "0x600434E")]
			[Address(RVA = "0x9202", Offset = "0x9202", VA = "0x9202")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600434F")]
			[Address(RVA = "0x9203", Offset = "0x9203", VA = "0x9203")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001A3 RID: 419
		// (add) Token: 0x06004350 RID: 17232 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004351 RID: 17233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A3")]
		public event EventHandler<ChatVisitorData> ItemClickedEvent
		{
			[Token(Token = "0x6004350")]
			[Address(RVA = "0x9204", Offset = "0x9204", VA = "0x9204")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004351")]
			[Address(RVA = "0x9205", Offset = "0x9205", VA = "0x9205")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004352")]
		[Address(RVA = "0x9206", Offset = "0x9206", VA = "0x9206", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Chat_View_ChatRoomVisitorsListAdapter__Start
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
		  
		  if (DAT_ram_00a57ad4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatRoomVisitorsListAdapter_HandleItemRendererClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatVisitorViewsHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57ad4 = '\x01';
		  }
		  param1_01 = unnamed_function_1417(Gameplay_Chat_View_ChatVisitorViewsHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_01,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar3 = *(int *)(param1_01 + 0x14);
		  param1_02 = unnamed_function_1417(System_EventHandler_ChatVisitorData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (param1_02,param1,
		             Method_Gameplay_Chat_View_ChatRoomVisitorsListAdapter_HandleItemRendererClickEvent__,0)
		  ;
		  if (DAT_ram_00a57aee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57aee = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_03 = UnityEngine_UI_Image__set_sprite(param1_00,param1_02,0);
		    param2_00 = System_EventHandler_ChatVisitorData__TypeInfo;
		    if ((param1_03 != 0) &&
		       (iVar2 = func_ii_1082(param1_03,System_EventHandler_ChatVisitorData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x3c,iVar2,param1_00);
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

		// Token: 0x06004353 RID: 17235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004353")]
		[Address(RVA = "0x9207", Offset = "0x9207", VA = "0x9207", Slot = "99")]
		protected override ChatVisitorViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57ad5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__get_Item__
		              );
		    DAT_ram_00a57ad5 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  iVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,param2_00,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__get_Item__
		                    );
		  iVar3 = param2[5];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  if (uVar2 != *(uint *)(iVar3 + 0x38)) {
		    *(uint *)(iVar3 + 0x38) = uVar2;
		    iVar4 = 0x24;
		    if ((uVar2 & 1) == 0) {
		      iVar4 = 0x28;
		    }
		    func_ii_7050(*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + iVar4),0);
		  }
		  iVar3 = param2[5];
		  if (iVar1 != *(int *)(iVar3 + 0x40)) {
		    *(int *)(iVar3 + 0x40) = iVar1;
		    Gameplay_Chat_View_VisitorItemRenderer__set_Title(iVar3,iVar3);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004354")]
		[Address(RVA = "0x9208", Offset = "0x9208", VA = "0x9208", Slot = "100")]
		protected override void UpdateViewsHolder(ChatVisitorViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__UpdateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57ad6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatRoomVisitorsListAdapter_HandleItemRendererClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a57ad6 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x14);
		  param1_01 = unnamed_function_1417(System_EventHandler_ChatVisitorData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (param1_01,param1,
		             Method_Gameplay_Chat_View_ChatRoomVisitorsListAdapter_HandleItemRendererClickEvent__,0)
		  ;
		  if (DAT_ram_00a57aef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57aef = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_EventHandler_ChatVisitorData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_EventHandler_ChatVisitorData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x3c,iVar2,param1_00);
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

		// Token: 0x06004355 RID: 17237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004355")]
		[Address(RVA = "0x9209", Offset = "0x9209", VA = "0x9209", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(ChatVisitorViewsHolder vh, bool isActive)
		{
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004356")]
		[Address(RVA = "0x920A", Offset = "0x920A", VA = "0x920A")]
		private void HandleItemRendererClickEvent(object sender, ChatVisitorData visitor)
		{
		/* --- GHIDRA: HandleItemRendererClickEvent ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__HandleItemRendererClickEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57ad7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__InsertItems__
		              );
		    DAT_ram_00a57ad7 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__InsertItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004357")]
		[Address(RVA = "0x920B", Offset = "0x920B", VA = "0x920B")]
		public void AddItemsAt(int index, IList<ChatVisitorData> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57ad8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__RemoveItems__
		              );
		    DAT_ram_00a57ad8 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004358")]
		[Address(RVA = "0x920C", Offset = "0x920C", VA = "0x920C")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__RemoveItemsFrom
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57ad9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		              );
		    DAT_ram_00a57ad9 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (param1[0x28],param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004359")]
		[Address(RVA = "0x920D", Offset = "0x920D", VA = "0x920D")]
		public void SetItems(IList<ChatVisitorData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ada == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder___ctor__
		              );
		    DAT_ram_00a57ada = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435A")]
		[Address(RVA = "0x920E", Offset = "0x920E", VA = "0x920E")]
		public ChatRoomVisitorsListAdapter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57ad1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57ad1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_EventHandler_ChatVisitorData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatVisitorData__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_ItemClickedEvent ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__add_ItemClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57ad2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57ad2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_ChatVisitorData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatVisitorData__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_ItemClickedEvent ---
		void Gameplay_Chat_View_ChatRoomVisitorsListAdapter__remove_ItemClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ad3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57ad3 = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417
		                          (
		                          Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__TypeInfo
		                          );
		    System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		              (param1_00,param1,1,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData___ctor__);
		    *(undefined4 *)(param1 + 0xa0) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder__Start__
		              );
		  }
		  return;
		}
		*/

}
