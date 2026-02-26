using System;
using Core.Data.Tournaments;
using Il2CppDummyDll;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC6 RID: 3014
	[Token(Token = "0x2000BC6")]
	public class BlitzTournamentListElement : TournamentListElementBase<BlitzTournamentData>
	{
		// Token: 0x060049E1 RID: 18913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x984B", Offset = "0x984B", VA = "0x984B", Slot = "9")]
		public override void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_BlitzTournament_View_BlitzTournamentListElement__UpdateView
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6089b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData___ctor__
		              );
		    DAT_ram_00a6089b = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x984C", Offset = "0x984C", VA = "0x984C")]
		public BlitzTournamentListElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_BlitzTournament_View_BlitzTournamentListElement___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6089c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12575);
		    DAT_ram_00a6089c = '\x01';
		  }
		  return StringLiteral_12575;
		}
		*/

		}
	}
}
