using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Clans.Office.View.ClanResumesTab
{
	// Token: 0x02000A2B RID: 2603
	[Token(Token = "0x2000A2B")]
	public class UserInRatingsViewsHolder : ItemViewsHolder<UserInRatingListElement>
	{
		// Token: 0x06003DB7 RID: 15799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB7")]
		[Address(RVA = "0x8C76", Offset = "0x8C76", VA = "0x8C76", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingsViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f66 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_UserInRatingListElement___ctor__);
		    DAT_ram_00a57f66 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB8")]
		[Address(RVA = "0x8C77", Offset = "0x8C77", VA = "0x8C77")]
		public UserInRatingsViewsHolder()
		{
		}
	}
}
