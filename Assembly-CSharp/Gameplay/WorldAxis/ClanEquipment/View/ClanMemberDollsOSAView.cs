using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.ClanEquipment.View
{
	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public class ClanMemberDollsOSAView : OSAGenericBase<ClanMemberDollsOSAView.ClansMembersViewsHolder, ClanMemberDollsListElement.ClanMemberDollsListElementArgs>
	{
		// Token: 0x06001345 RID: 4933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x6536", Offset = "0x6536", VA = "0x6536", Slot = "119")]
		protected override ClanMemberDollsOSAView.ClansMembersViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58c35 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_ClanMemberDollsOSAView_ClansMembersViewsHolder__ClanMemberDollsListElement_ClanMemberDollsListElementArgs___ctor__
		              );
		    DAT_ram_00a58c35 = '\x01';
		  }
		  UI_OSADynamicBase_object__object___get_MinElementsToUpdate
		            (param1,
		             Method_UI_OSAGenericBase_ClanMemberDollsOSAView_ClansMembersViewsHolder__ClanMemberDollsListElement_ClanMemberDollsListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x6537", Offset = "0x6537", VA = "0x6537")]
		public ClanMemberDollsOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58c36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsListElement_ClanMemberDollsListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanMemberDollsListElement_ClanMemberDollsListElementArgs__set_Data__
		              );
		    DAT_ram_00a58c36 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsListElement_ClanMemberDollsListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsListElement_ClanMemberDollsListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsListElement_ClanMemberDollsListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_WorldAxis_ClanEquipment_View_ClanMemberDollsListElement_ClanMemberDollsListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_ClanMemberDollsListElement_ClanMemberDollsListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}

		// Token: 0x02000348 RID: 840
		[Token(Token = "0x2000348")]
		public class ClansMembersViewsHolder : ItemViewsHolder<ClanMemberDollsListElement>
		{
			// Token: 0x06001347 RID: 4935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001347")]
			[Address(RVA = "0x6538", Offset = "0x6538", VA = "0x6538", Slot = "13")]
			public override void SetData(GenericListElementArgs args)
			{
			}

			// Token: 0x06001348 RID: 4936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001348")]
			[Address(RVA = "0x6539", Offset = "0x6539", VA = "0x6539")]
			public ClansMembersViewsHolder()
			{
			}
		}
	}
}
