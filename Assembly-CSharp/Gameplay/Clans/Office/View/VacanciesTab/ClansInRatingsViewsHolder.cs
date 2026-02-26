using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Clans.Office.View.VacanciesTab
{
	// Token: 0x02000A07 RID: 2567
	[Token(Token = "0x2000A07")]
	public class ClansInRatingsViewsHolder : ItemViewsHolder<ClanInRatingListElement>
	{
		// Token: 0x06003CFD RID: 15613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0x8BBD", Offset = "0x8BBD", VA = "0x8BBD", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Clans_Office_View_VacanciesTab_ClansInRatingsViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f14 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_ClanInRatingListElement___ctor__);
		    DAT_ram_00a57f14 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x8BBE", Offset = "0x8BBE", VA = "0x8BBE")]
		public ClansInRatingsViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_VacanciesTab_ClansInRatingsViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  if (DAT_ram_00a57f15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanInRatingListElement_ClanInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1509);
		    DAT_ram_00a57f15 = '\x01';
		  }
		  local_4 = 0;
		  Gameplay_Clans_Office_View_UserRatingsRender___ctor(param1,auStack_10);
		  iVar1 = *(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x24) + 0x1c);
		  param2_00 = StringLiteral_1509;
		  if (iVar1 != 0) {
		    local_4 = iVar1;
		    param2_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  }
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x28),param2_00,0);
		  return;
		}
		*/

		}
	}
}
