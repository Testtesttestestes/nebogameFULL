using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.TutorialCombatV2.Model
{
	// Token: 0x02000451 RID: 1105
	[Token(Token = "0x2000451")]
	public class TutorialCombatModel : CombatModel
	{
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00005A30 File Offset: 0x00003C30
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000497")]
		public bool CombatOnPause
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x6BC7", Offset = "0x6BC7", VA = "0x6BC7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x6BC8", Offset = "0x6BC8", VA = "0x6BC8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x6BC9", Offset = "0x6BC9", VA = "0x6BC9")]
		public TutorialCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialCombatV2_Model_TutorialCombatModel___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58426 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents__Dispose__
		              );
		    DAT_ram_00a58426 = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x20),0);
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  Gameplay_Combat_Control_CombatController_object__object___CompleteQueueCallback
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_TutorialCombatModel__TutorialCombatEvents__Dispose__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CombatOnPause ---
		void Gameplay_TutorialCombatV2_Model_TutorialCombatModel__set_CombatOnPause
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined1 *)(param1 + 0x5c) = 1;
		  Gameplay_Combat_Model_CombatModel__Dispose(param1,param2,param3,param4,param5,0);
		  return;
		}
		*/

}
