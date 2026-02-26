using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Rating.View
{
	// Token: 0x02000579 RID: 1401
	[Token(Token = "0x2000579")]
	public class CultInRatingsViewsHolder : ItemViewsHolder<CultInRatingListElement>
	{
		// Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219E")]
		[Address(RVA = "0x72FD", Offset = "0x72FD", VA = "0x72FD", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Rating_View_CultInRatingsViewsHolder__SetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5802c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_CultInRatingListElement___ctor__);
		    DAT_ram_00a5802c = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219F")]
		[Address(RVA = "0x72FE", Offset = "0x72FE", VA = "0x72FE")]
		public CultInRatingsViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_CultInRatingsViewsHolder___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5802d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanInRatingListElement_ClanInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1902);
		    DAT_ram_00a5802d = '\x01';
		  }
		  Gameplay_Clans_Office_View_UserRatingsRender___ctor(param1,0);
		  if (*(int *)(*(int *)(param1 + 0x18) + 0x20) == 0) {
		    UnityEngine_Component__GetComponentInChildren_object_
		              (*(undefined4 *)(param1 + 0x28),StringLiteral_1902,0);
		  }
		  return;
		}
		*/

		}
	}
}
