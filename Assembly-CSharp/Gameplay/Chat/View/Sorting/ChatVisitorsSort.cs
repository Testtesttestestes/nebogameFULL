using System;
using System.Collections.Generic;
using Core.Sorting;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using UI.Sorting;

namespace Gameplay.Chat.View.Sorting
{
	// Token: 0x02000AF6 RID: 2806
	[Token(Token = "0x2000AF6")]
	public class ChatVisitorsSort : AbstractSortControlView<ChatVisitorData>
	{
		// Token: 0x060043AC RID: 17324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x9260", Offset = "0x9260", VA = "0x9260", Slot = "4")]
		protected override List<IGameDataComparer<ChatVisitorData>> GetComparers()
		{
		/* --- GHIDRA: GetComparers ---
		void Gameplay_Chat_View_Sorting_ChatVisitorsSort__GetComparers(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57afc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_ChatVisitorData___ctor__);
		    DAT_ram_00a57afc = '\x01';
		  }
		  UI_SkinsV2_AbstractSkinResolver___Il2CppFullySharedGenericType__object___StartRollback
		            (param1,Method_UI_Sorting_AbstractSortControlView_ChatVisitorData___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AD")]
		[Address(RVA = "0x9261", Offset = "0x9261", VA = "0x9261")]
		public ChatVisitorsSort()
		{
		}
	}
}
