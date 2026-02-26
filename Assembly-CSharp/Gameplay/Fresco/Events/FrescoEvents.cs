using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Fresco;

namespace Gameplay.Fresco.Events
{
	// Token: 0x0200080A RID: 2058
	[Token(Token = "0x200080A")]
	public class FrescoEvents : AbstractMVCEvents
	{
		// Token: 0x0600305E RID: 12382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600305E")]
		[Address(RVA = "0x80C3", Offset = "0x80C3", VA = "0x80C3")]
		public FrescoEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_Events_FrescoEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a575a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_FrescoModel__FrescoEvents___ctor__);
		    DAT_ram_00a575a2 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_FrescoModel__FrescoEvents___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  return;
		}
		*/

		}

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x14")]
		public Action<Fresco> FrescoUpdated;

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x18")]
		public Action BalanceChanged;

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x1C")]
		public Action FrescoesUpdated;

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x20")]
		public Action OtherFrescoesUpdated;

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x24")]
		public Action<uint> UniversalFragmentsCountChanged;
	}
}
