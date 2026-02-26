using System;
using System.Collections.Generic;
using Core.Sorting;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Sorting;

namespace Gameplay.Boss.View.InvitesTab
{
	// Token: 0x02000B70 RID: 2928
	[Token(Token = "0x2000B70")]
	public class BossInvitesSortControlView : AbstractSortControlView<BossInviteData>
	{
		// Token: 0x06004721 RID: 18209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004721")]
		[Address(RVA = "0x95B7", Offset = "0x95B7", VA = "0x95B7", Slot = "4")]
		protected override List<IGameDataComparer<BossInviteData>> GetComparers()
		{
		/* --- GHIDRA: GetComparers ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesSortControlView__GetComparers
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a22 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Sorting_AbstractSortControlView_BossInviteData___ctor__)
		    ;
		    DAT_ram_00a57a22 = '\x01';
		  }
		  UI_SkinsV2_AbstractSkinResolver___Il2CppFullySharedGenericType__object___StartRollback
		            (param1,Method_UI_Sorting_AbstractSortControlView_BossInviteData___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004722")]
		[Address(RVA = "0x95B8", Offset = "0x95B8", VA = "0x95B8")]
		public BossInvitesSortControlView()
		{
		}
	}
}
