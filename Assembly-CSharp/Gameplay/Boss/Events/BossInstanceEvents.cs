using System;
using System.Collections.Generic;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Events
{
	// Token: 0x02000BA0 RID: 2976
	[Token(Token = "0x2000BA0")]
	public class BossInstanceEvents : AbstractMVCEvents
	{
		// Token: 0x060048C0 RID: 18624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C0")]
		[Address(RVA = "0x9739", Offset = "0x9739", VA = "0x9739")]
		public BossInstanceEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Events_BossInstanceEvents___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5789f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossCaptainView__Dispose__
		              );
		    DAT_ram_00a5789f = '\x01';
		  }
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 0x18),0);
		  System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x18),0);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossCaptainView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040027D7 RID: 10199
		[Token(Token = "0x40027D7")]
		[FieldOffset(Offset = "0x14")]
		public Action InstanceStateChangedEvent;

		// Token: 0x040027D8 RID: 10200
		[Token(Token = "0x40027D8")]
		[FieldOffset(Offset = "0x18")]
		public Action HealthChangedEvent;

		// Token: 0x040027D9 RID: 10201
		[Token(Token = "0x40027D9")]
		[FieldOffset(Offset = "0x1C")]
		public Action TeamInfoChangedEvent;

		// Token: 0x040027DA RID: 10202
		[Token(Token = "0x40027DA")]
		[FieldOffset(Offset = "0x20")]
		public Action<IList<ulong>> PossibleAssistantsReceivedEvent;

		// Token: 0x040027DB RID: 10203
		[Token(Token = "0x40027DB")]
		[FieldOffset(Offset = "0x24")]
		public Action<ulong> AssistantInvitedEvent;

		// Token: 0x040027DC RID: 10204
		[Token(Token = "0x40027DC")]
		[FieldOffset(Offset = "0x28")]
		public Action<ulong> AssistantKickedEvent;

		// Token: 0x040027DD RID: 10205
		[Token(Token = "0x40027DD")]
		[FieldOffset(Offset = "0x2C")]
		public Action<ulong> AssistantInviteOrKickErrorEvent;

		// Token: 0x040027DE RID: 10206
		[Token(Token = "0x40027DE")]
		[FieldOffset(Offset = "0x30")]
		public Action CaptainInvitesChangedEvent;

		// Token: 0x040027DF RID: 10207
		[Token(Token = "0x40027DF")]
		[FieldOffset(Offset = "0x34")]
		public Action MyTeamsInfoChangedEvent;

		// Token: 0x040027E0 RID: 10208
		[Token(Token = "0x40027E0")]
		[FieldOffset(Offset = "0x38")]
		public Action LicenceCountChangedEvent;

		// Token: 0x040027E1 RID: 10209
		[Token(Token = "0x40027E1")]
		[FieldOffset(Offset = "0x3C")]
		public Action<TeamData> TeamInfoReceivedEvent;

		// Token: 0x040027E2 RID: 10210
		[Token(Token = "0x40027E2")]
		[FieldOffset(Offset = "0x40")]
		public Action<ulong, List<TeamRewardData>> CaptainTeamsReceivedEvent;

		// Token: 0x040027E3 RID: 10211
		[Token(Token = "0x40027E3")]
		[FieldOffset(Offset = "0x44")]
		public Action<List<BossCaptainRatingData>> RatingReceivedEvent;

		// Token: 0x040027E4 RID: 10212
		[Token(Token = "0x40027E4")]
		[FieldOffset(Offset = "0x48")]
		public Action<TeamAndRewardsData> TeamAndRewardsDataReceivedEvent;
	}
}
