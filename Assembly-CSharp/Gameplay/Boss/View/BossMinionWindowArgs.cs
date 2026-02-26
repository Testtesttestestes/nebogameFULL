using System;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.Combat;
using Il2CppDummyDll;
using UI.Windows;
using Utils;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B48 RID: 2888
	[Token(Token = "0x2000B48")]
	public class BossMinionWindowArgs : BaseWindowArgs
	{
		// Token: 0x060045FC RID: 17916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x9496", Offset = "0x9496", VA = "0x9496")]
		public BossMinionWindowArgs()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_BossMinionWindowArgs___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates___ctor__
		              );
		    DAT_ram_00a579a0 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002631 RID: 9777
		[Token(Token = "0x4002631")]
		[FieldOffset(Offset = "0x18")]
		public ICombat Combat;

		// Token: 0x04002632 RID: 9778
		[Token(Token = "0x4002632")]
		[FieldOffset(Offset = "0x1C")]
		public BossManager BossManager;

		// Token: 0x04002633 RID: 9779
		[Token(Token = "0x4002633")]
		[FieldOffset(Offset = "0x20")]
		public MonsterData MonsterData;

		// Token: 0x04002634 RID: 9780
		[Token(Token = "0x4002634")]
		[FieldOffset(Offset = "0x24")]
		public BackTime BackTime;
	}
}
