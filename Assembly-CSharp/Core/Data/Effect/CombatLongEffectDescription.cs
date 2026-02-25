using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Effect
{
	// Token: 0x020010EA RID: 4330
	[Token(Token = "0x20010EA")]
	public class CombatLongEffectDescription : CombatEffectDescription
	{
		// Token: 0x06006539 RID: 25913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006539")]
		[Address(RVA = "0xB105", Offset = "0xB105", VA = "0xB105")]
		public CombatLongEffectDescription(string sourceText, EffectData[] effects, Skills userSkills)
		{
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653A")]
		[Address(RVA = "0xB106", Offset = "0xB106", VA = "0xB106", Slot = "6")]
		protected override void WriteValue(Dictionary<string, string> source, uint effectId, string textVarName, string value)
		{
		}
	}
}
