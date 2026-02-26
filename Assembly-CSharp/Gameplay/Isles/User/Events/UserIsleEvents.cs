using System;
using Gameplay.Isles.Base.Events;
using Gameplay.World.Events;
using Il2CppDummyDll;

namespace Gameplay.Isles.User.Events
{
	// Token: 0x02000D2D RID: 3373
	[Token(Token = "0x2000D2D")]
	public class UserIsleEvents : BaseIsleEvents
	{
		// Token: 0x06005286 RID: 21126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005286")]
		[Address(RVA = "0xA05C", Offset = "0xA05C", VA = "0xA05C")]
		public UserIsleEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Events_UserIsleEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58d87 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView___ctor__
		              );
		    DAT_ram_00a58d87 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x24")]
		public Action<WorldControllerEvents.MonsterChangeReason> MonsterChangedEvent;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		[FieldOffset(Offset = "0x28")]
		public Action MonsterFlewAwayEvent;

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		[FieldOffset(Offset = "0x2C")]
		public Action<uint> DecorationAddedEvent;

		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		[FieldOffset(Offset = "0x30")]
		public Action<uint> DecorationRemovedEvent;

		// Token: 0x04002CEE RID: 11502
		[Token(Token = "0x4002CEE")]
		[FieldOffset(Offset = "0x34")]
		public Action<uint> AnimationStartedEvent;

		// Token: 0x04002CEF RID: 11503
		[Token(Token = "0x4002CEF")]
		[FieldOffset(Offset = "0x38")]
		public Action AccountMarkersChangedEvent;

		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		[FieldOffset(Offset = "0x3C")]
		public Action<uint> IsleViewChangedEvent;

		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		[FieldOffset(Offset = "0x40")]
		public Action<uint> IsleBonusCollectedEvent;

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x44")]
		public Action DiamondIsleFoundEvent;
	}
}
