using System;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;

namespace Gameplay.Rating.View
{
	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	public class MyClanInRatingListElement : ClanInRatingListElement
	{
		// Token: 0x060021A0 RID: 8608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x72FF", Offset = "0x72FF", VA = "0x72FF", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Rating_View_MyClanInRatingListElement__ApplyArgs(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_View_VacanciesTab_RequestedClanListElement__Select(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x7300", Offset = "0x7300", VA = "0x7300")]
		public MyClanInRatingListElement()
		{
		}
	}
}
