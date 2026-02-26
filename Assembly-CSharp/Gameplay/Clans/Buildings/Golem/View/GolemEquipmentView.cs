using System;
using Gameplay.UserInfo.View.Equipment;
using Il2CppDummyDll;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC2 RID: 2754
	[Token(Token = "0x2000AC2")]
	public class GolemEquipmentView : BaseEquipmentView<GolemEquipmentSlotConfig>
	{
		// Token: 0x0600426B RID: 17003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426B")]
		[Address(RVA = "0x911F", Offset = "0x911F", VA = "0x911F")]
		public GolemEquipmentView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Buildings_Golem_View_GolemEquipmentView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57836 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12591);
		    DAT_ram_00a57836 = '\x01';
		  }
		  return StringLiteral_12591;
		}
		*/

		}
	}
}
