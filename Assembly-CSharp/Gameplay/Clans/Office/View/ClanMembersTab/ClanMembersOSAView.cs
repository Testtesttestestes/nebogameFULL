using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A3B RID: 2619
	[Token(Token = "0x2000A3B")]
	public class ClanMembersOSAView : OSA<BaseParamsWithPrefab, ClanMembersViewsHolder>
	{
		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5F")]
		public SimpleDataHelper<ClanMemberListElement.ClanMemberListElementArgs> Data
		{
			[Token(Token = "0x6003DF6")]
			[Address(RVA = "0x8CB5", Offset = "0x8CB5", VA = "0x8CB5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DF7")]
			[Address(RVA = "0x8CB6", Offset = "0x8CB6", VA = "0x8CB6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x8CB7", Offset = "0x8CB7", VA = "0x8CB7", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersOSAView__Start
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f7d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersViewsHolder_TypeInfo);
		    DAT_ram_00a57f7d = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersViewsHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x8CB8", Offset = "0x8CB8", VA = "0x8CB8", Slot = "99")]
		protected override ClanMembersViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersOSAView__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f7e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__get_Item__
		              );
		    DAT_ram_00a57f7e = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__get_Item__
		                    );
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__get_Data(param2[5],uVar1,param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x8CB9", Offset = "0x8CB9", VA = "0x8CB9", Slot = "100")]
		protected override void UpdateViewsHolder(ClanMembersViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersOSAView__UpdateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57f7f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__InsertItems__
		              );
		    DAT_ram_00a57f7f = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__InsertItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x8CBA", Offset = "0x8CBA", VA = "0x8CBA")]
		public void AddItemsAt(int index, IList<ClanMemberListElement.ClanMemberListElementArgs> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersOSAView__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 local_1;
		  
		  if (DAT_ram_00a57f80 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder__SetVirtualAbstractNormalizedScrollPosition__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__ResetItems__
		              );
		    DAT_ram_00a57f80 = '\x01';
		  }
		  local_1 = 0;
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__ResetItems__
		            );
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetViewsHolderEnabled
		            (param1,1.0,1,&local_1,0,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder__SetVirtualAbstractNormalizedScrollPosition__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0x8CBB", Offset = "0x8CBB", VA = "0x8CBB")]
		public void SetItems(IList<ClanMemberListElement.ClanMemberListElementArgs> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersOSAView__SetItems
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f81 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder___ctor__
		              );
		    DAT_ram_00a57f81 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x8CBC", Offset = "0x8CBC", VA = "0x8CBC")]
		public ClanMembersOSAView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersOSAView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a57f71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__get_args__
		              );
		    DAT_ram_00a57f71 = '\x01';
		  }
		  return *(undefined4 *)(iVar1 + 0x18);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMembersOSAView__set_Data
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		              );
		    DAT_ram_00a57f7c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ClanMemberListElement_ClanMemberListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMembersViewsHolder__Start__
		            );
		  return;
		}
		*/

}
