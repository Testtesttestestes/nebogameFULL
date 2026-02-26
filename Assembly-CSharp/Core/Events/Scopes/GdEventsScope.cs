using System;
using System.Collections.Generic;
using Core.Application;
using Core.Gameplay;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;

namespace Core.Events.Scopes
{
	// Token: 0x02001001 RID: 4097
	[Token(Token = "0x2001001")]
	public class GdEventsScope : AbstractEventBusScope
	{
		// Token: 0x06006136 RID: 24886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006136")]
		[Address(RVA = "0xAD62", Offset = "0xAD62", VA = "0xAD62", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006137")]
		[Address(RVA = "0xAD63", Offset = "0xAD63", VA = "0xAD63")]
		public GdEventsScope()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Events_Scopes_GdEventsScope___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a351 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27866);
		    DAT_ram_00a5a351 = '\x01';
		  }
		  if (DAT_ram_00a5a349 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a5a349 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  func_ii_2946(param1_00,StringLiteral_27866,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x14),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  return param1_00;
		}
		*/

		}

		// Token: 0x04003414 RID: 13332
		[Token(Token = "0x4003414")]
		[FieldOffset(Offset = "0x8")]
		public Action<GdEventsScope.Args> MilestoneSelectedEvent;

		// Token: 0x04003415 RID: 13333
		[Token(Token = "0x4003415")]
		[FieldOffset(Offset = "0xC")]
		public Action<GdEventsScope.Args> GameActivityNavigationEvent;

		// Token: 0x04003416 RID: 13334
		[Token(Token = "0x4003416")]
		[FieldOffset(Offset = "0x10")]
		public Action<GdEventsScope.CompletionsArgs> MilestoneCompleteEvent;

		// Token: 0x04003417 RID: 13335
		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x14")]
		public Action<GdEventsScope.CompletionsArgs> CompleteEvent;

		// Token: 0x02001002 RID: 4098
		[Token(Token = "0x2001002")]
		public class CompletionsArgs : BaseEventBusEventArgs
		{
			// Token: 0x06006138 RID: 24888 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006138")]
			[Address(RVA = "0x2194", Offset = "0x2194", VA = "0x2194")]
			public CompletionsArgs(TriggerDic trigger, IApp app, IGame game)
			{
			}

			// Token: 0x06006139 RID: 24889 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6006139")]
			[Address(RVA = "0xAD64", Offset = "0xAD64", VA = "0xAD64", Slot = "4")]
			public override Dictionary<string, object> GetEventProperties()
			{
				return null;
			}

			// Token: 0x04003418 RID: 13336
			[Token(Token = "0x4003418")]
			private const string TRIGGER_NAME = "trigger_name";

			// Token: 0x04003419 RID: 13337
			[Token(Token = "0x4003419")]
			[FieldOffset(Offset = "0x10")]
			public readonly TriggerDic Trigger;
		}

		// Token: 0x02001003 RID: 4099
		[Token(Token = "0x2001003")]
		public class Args : BaseEventBusEventArgs
		{
			// Token: 0x0600613A RID: 24890 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600613A")]
			[Address(RVA = "0xAD65", Offset = "0xAD65", VA = "0xAD65")]
			public Args([NotNull] GdEventData evt, MilestoneData milestone, IApp app, IGame game)
			{
			}

			// Token: 0x0600613B RID: 24891 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600613B")]
			[Address(RVA = "0xAD66", Offset = "0xAD66", VA = "0xAD66")]
			public Args([NotNull] GdEventData evt, [CanBeNull] MilestoneData milestone, [CanBeNull] GameActivityData gameActivity, IApp app, IGame game)
			{
			}

			// Token: 0x0600613C RID: 24892 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600613C")]
			[Address(RVA = "0xAD67", Offset = "0xAD67", VA = "0xAD67", Slot = "4")]
			public override Dictionary<string, object> GetEventProperties()
			{
				return null;
			}

			// Token: 0x0400341A RID: 13338
			[Token(Token = "0x400341A")]
			private const string EVENT_NAME = "event_name";

			// Token: 0x0400341B RID: 13339
			[Token(Token = "0x400341B")]
			private const string EVENT_ID = "event_id";

			// Token: 0x0400341C RID: 13340
			[Token(Token = "0x400341C")]
			private const string MILESTONE_NAME = "milestone_name";

			// Token: 0x0400341D RID: 13341
			[Token(Token = "0x400341D")]
			private const string ACTIVITY_NAME = "activity_name";

			// Token: 0x0400341E RID: 13342
			[Token(Token = "0x400341E")]
			private const string URI = "uri";

			// Token: 0x0400341F RID: 13343
			[Token(Token = "0x400341F")]
			[FieldOffset(Offset = "0x10")]
			[NotNull]
			public readonly GdEventData Evt;

			// Token: 0x04003420 RID: 13344
			[Token(Token = "0x4003420")]
			[FieldOffset(Offset = "0x14")]
			[CanBeNull]
			public readonly MilestoneData Milestone;

			// Token: 0x04003421 RID: 13345
			[Token(Token = "0x4003421")]
			[FieldOffset(Offset = "0x18")]
			[CanBeNull]
			public readonly GameActivityData GameActivity;
		}
	}
}
