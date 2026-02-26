using System;
using Gameplay.GdEvents.Control;
using Gameplay.GdEvents.Model;
using Il2CppDummyDll;
using UI;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	public class ContentContainerView : MonoBehaviourWithStates<EventViewState>
	{
		// Token: 0x06002C4C RID: 11340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4C")]
		[Address(RVA = "0x7CDB", Offset = "0x7CDB", VA = "0x7CDB")]
		public void Init(GdEventsController controller)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_GdEvents_View_EventView_ContentContainerView__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a2b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_EventViewState___ctor__);
		    DAT_ram_00a5a2b8 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_EventViewState___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C4D")]
		[Address(RVA = "0x7CDC", Offset = "0x7CDC", VA = "0x7CDC")]
		public ContentContainerView()
		{
		}

		// Token: 0x04001849 RID: 6217
		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x19")]
		private bool _isInit;
	}
}
