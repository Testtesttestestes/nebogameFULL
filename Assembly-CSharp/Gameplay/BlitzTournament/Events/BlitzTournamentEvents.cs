using System;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;

namespace Gameplay.BlitzTournament.Events
{
	// Token: 0x02000BD6 RID: 3030
	[Token(Token = "0x2000BD6")]
	public class BlitzTournamentEvents : AbstractMVCEvents
	{
		// Token: 0x06004A3F RID: 19007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x98A1", Offset = "0x98A1", VA = "0x98A1")]
		public BlitzTournamentEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_Events_BlitzTournamentEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a608b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents___ctor__
		              );
		    DAT_ram_00a608b5 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param3,param4,param5,
		             Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		[FieldOffset(Offset = "0x14")]
		public Action TournamentInfoReceived;

		// Token: 0x04002877 RID: 10359
		[Token(Token = "0x4002877")]
		[FieldOffset(Offset = "0x18")]
		public Action TournamentListReceived;

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x1C")]
		public Action JoinedQueueEvent;

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x20")]
		public Action LeftQueueEvent;

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x24")]
		public Action<ProtoStateChangedEvt> StateChangedEvent;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x28")]
		public Action<uint> FightersCountChangedEvent;

		// Token: 0x0400287C RID: 10364
		[Token(Token = "0x400287C")]
		[FieldOffset(Offset = "0x2C")]
		public Action<bool> BlockUIEvent;

		// Token: 0x0400287D RID: 10365
		[Token(Token = "0x400287D")]
		[FieldOffset(Offset = "0x30")]
		public Action<ProtoHealthChangedEvt> HealthChangedEvent;
	}
}
