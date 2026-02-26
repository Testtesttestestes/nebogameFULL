using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Windows;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1C RID: 3356
	[Token(Token = "0x2000D1C")]
	public class AttackMonsterWindowArgs : BaseWindowArgs
	{
		// Token: 0x060051F8 RID: 20984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051F8")]
		[Address(RVA = "0x9FCF", Offset = "0x9FCF", VA = "0x9FCF")]
		public AttackMonsterWindowArgs([NotNull] UserIsle isle)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Isles_User_View_AttackMonsterWindowArgs___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58d60 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12646);
		    DAT_ram_00a58d60 = '\x01';
		  }
		  return StringLiteral_12646;
		}
		*/

		}

		// Token: 0x04002C90 RID: 11408
		[Token(Token = "0x4002C90")]
		[FieldOffset(Offset = "0x18")]
		[NotNull]
		public readonly UserIsle Isle;
	}
}
