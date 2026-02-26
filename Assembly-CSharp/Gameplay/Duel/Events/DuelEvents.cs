using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Duel.Events
{
	// Token: 0x02000863 RID: 2147
	[Token(Token = "0x2000863")]
	public class DuelEvents : AbstractMVCEvents
	{
		// Token: 0x06003267 RID: 12903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x82BC", Offset = "0x82BC", VA = "0x82BC")]
		public DuelEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_Events_DuelEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a57bd9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents___ctor__);
		    DAT_ram_00a57bd9 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param3,param4,param5,
		             Method_Gameplay_Combat_Control_CombatController_CombatModel__CombatEvents___ctor__);
		  *(undefined4 *)(param1 + 0x24) = param2;
		  *(undefined1 *)(param1 + 0x20) = (undefined1)param6;
		  return;
		}
		*/

		}

		// Token: 0x04001BA5 RID: 7077
		[Token(Token = "0x4001BA5")]
		[FieldOffset(Offset = "0x14")]
		public Action SkillsRequestedEvent;

		// Token: 0x04001BA6 RID: 7078
		[Token(Token = "0x4001BA6")]
		[FieldOffset(Offset = "0x18")]
		public Action DuelInfoRequestedEvent;

		// Token: 0x04001BA7 RID: 7079
		[Token(Token = "0x4001BA7")]
		[FieldOffset(Offset = "0x1C")]
		public Action UpdateDataEvent;

		// Token: 0x04001BA8 RID: 7080
		[Token(Token = "0x4001BA8")]
		[FieldOffset(Offset = "0x20")]
		public Action CloseViewEvent;
	}
}
