using System;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.View.VacanciesTab
{
	// Token: 0x02000A08 RID: 2568
	[Token(Token = "0x2000A08")]
	public class RequestedClanListElement : ClanInRatingListElement
	{
		// Token: 0x06003CFF RID: 15615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x8BBF", Offset = "0x8BBF", VA = "0x8BBF", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x8BC0", Offset = "0x8BC0", VA = "0x8BC0", Slot = "9")]
		protected override void Select(bool isSelected)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_Clans_Office_View_VacanciesTab_RequestedClanListElement__Select
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f0d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElement_ClanInRatingListElement_ClanInRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a57f0d = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_Gameplay_Clans_Office_View_ClanListElement_ClanInRatingListElement_ClanInRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x8BC1", Offset = "0x8BC1", VA = "0x8BC1")]
		public RequestedClanListElement()
		{
		}
	}
}
