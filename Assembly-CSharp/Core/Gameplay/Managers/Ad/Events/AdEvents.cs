using System;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Providers;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Ad.Events
{
	// Token: 0x02001226 RID: 4646
	[Token(Token = "0x2001226")]
	public class AdEvents : AbstractMVCEvents
	{
		// Token: 0x06006DFF RID: 28159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0xB8B5", Offset = "0xB8B5", VA = "0xB8B5")]
		public AdEvents()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_Ad_Events_AdEvents___ctor(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a5a7bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__);
		    DAT_ram_00a5a7bf = '\x01';
		  }
		  param1_00 = param1[7];
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    DAT_ram_00a5a7b4 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  uVar2 = System_Linq_Enumerable__FirstOrDefault_int_
		                    (uVar2,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		  uVar2 = System_Collections_Generic_List_object___get_Item
		                    (param1_00,uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__);
		  return uVar2;
		}
		*/

		}

		// Token: 0x04003988 RID: 14728
		[Token(Token = "0x4003988")]
		[FieldOffset(Offset = "0x14")]
		public Action<AdTransaction> AdRewardedEvent;

		// Token: 0x04003989 RID: 14729
		[Token(Token = "0x4003989")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> AdPlacementDataChangedEvent;

		// Token: 0x0400398A RID: 14730
		[Token(Token = "0x400398A")]
		[FieldOffset(Offset = "0x1C")]
		public Action<AdTransaction> TransactionCreatedEvent;

		// Token: 0x0400398B RID: 14731
		[Token(Token = "0x400398B")]
		[FieldOffset(Offset = "0x20")]
		public Action<string> TransactionClosedEvent;

		// Token: 0x0400398C RID: 14732
		[Token(Token = "0x400398C")]
		[FieldOffset(Offset = "0x24")]
		public Action<IAdProvider.AdAvailabilityEventData> AdAvailabilityChangedEvent;
	}
}
