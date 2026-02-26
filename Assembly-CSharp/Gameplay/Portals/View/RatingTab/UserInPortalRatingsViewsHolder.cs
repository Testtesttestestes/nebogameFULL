using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Portals.View.RatingTab
{
	// Token: 0x020005C3 RID: 1475
	[Token(Token = "0x20005C3")]
	public class UserInPortalRatingsViewsHolder : ItemViewsHolder<UserInPortalRatingListElement>
	{
		// Token: 0x06002368 RID: 9064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002368")]
		[Address(RVA = "0x74BC", Offset = "0x74BC", VA = "0x74BC", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Portals_View_RatingTab_UserInPortalRatingsViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58109 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_UserInPortalRatingListElement___ctor__);
		    DAT_ram_00a58109 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x74BD", Offset = "0x74BD", VA = "0x74BD")]
		public UserInPortalRatingsViewsHolder()
		{
		}
	}
}
