using System;
using System.Collections.Generic;
using Gameplay.GameEvents.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.GameEvents
{
	// Token: 0x02000774 RID: 1908
	[Token(Token = "0x2000774")]
	public class GameEventsEvents : AbstractMVCEvents
	{
		// Token: 0x06002D7E RID: 11646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7E")]
		[Address(RVA = "0x7DFC", Offset = "0x7DFC", VA = "0x7DFC")]
		public GameEventsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_GameEventsEvents___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57482 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_AbstractActionOnEvent__TypeInfo);
		    DAT_ram_00a57482 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_EventHandler_AbstractActionOnEvent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_AbstractActionOnEvent__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040018D8 RID: 6360
		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x14")]
		public Action WarmSourcesCompleteEvent;

		// Token: 0x040018D9 RID: 6361
		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x18")]
		public Action<int> NotViewedEventCountChangedEvent;

		// Token: 0x040018DA RID: 6362
		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x1C")]
		public Action<EventCategoriesDic.Types.Category, int> NotViewedEventInCategoryCountChangedEvent;

		// Token: 0x040018DB RID: 6363
		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x20")]
		public Action<GameEventData> CurrentReadEventChangedEvent;

		// Token: 0x040018DC RID: 6364
		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x24")]
		public Action<GameEventData> GetRewardCompleteEvent;

		// Token: 0x040018DD RID: 6365
		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x28")]
		public Action<GameEventData> EventProcessCompleteEvent;

		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0x2C")]
		public Action CloseRequestEvent;

		// Token: 0x040018DF RID: 6367
		[Token(Token = "0x40018DF")]
		[FieldOffset(Offset = "0x30")]
		public Action<EventCategoriesDic> OpenRequestEvent;

		// Token: 0x040018E0 RID: 6368
		[Token(Token = "0x40018E0")]
		[FieldOffset(Offset = "0x34")]
		public Action<IList<GameEventData>> EventsHasBeenDeletedEvent;
	}
}
