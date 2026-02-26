using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Portals.View.TotalizatorTab
{
	// Token: 0x020005BA RID: 1466
	[Token(Token = "0x20005BA")]
	public class UserInPortalsTotalizatorViewsHolder : ItemViewsHolder<UserInPortalTotalizatorListElement>
	{
		// Token: 0x0600232A RID: 9002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x747E", Offset = "0x747E", VA = "0x747E", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Portals_View_TotalizatorTab_UserInPortalsTotalizatorViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ItemViewsHolder_UserInPortalTotalizatorListElement___ctor__);
		    DAT_ram_00a580f5 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232B")]
		[Address(RVA = "0x747F", Offset = "0x747F", VA = "0x747F")]
		public UserInPortalsTotalizatorViewsHolder()
		{
		}
	}
}
