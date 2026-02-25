using System;
using System.Collections.Generic;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Events
{
	// Token: 0x02000B9F RID: 2975
	[Token(Token = "0x2000B9F")]
	public class BossEvents : AbstractMVCEvents
	{
		// Token: 0x060048BF RID: 18623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x9738", Offset = "0x9738", VA = "0x9738")]
		public BossEvents()
		{
		}

		// Token: 0x040027D0 RID: 10192
		[Token(Token = "0x40027D0")]
		[FieldOffset(Offset = "0x14")]
		public Action<IList<BossInstance>> InstanceListChangedEvent;

		// Token: 0x040027D1 RID: 10193
		[Token(Token = "0x40027D1")]
		[FieldOffset(Offset = "0x18")]
		public Action<long> CurrentBossInstanceChangedEvent;

		// Token: 0x040027D2 RID: 10194
		[Token(Token = "0x40027D2")]
		[FieldOffset(Offset = "0x1C")]
		public Action CurrentCreateRequestChangedEvent;

		// Token: 0x040027D3 RID: 10195
		[Token(Token = "0x40027D3")]
		[FieldOffset(Offset = "0x20")]
		public Action TotalNotificationNumChangedEvent;

		// Token: 0x040027D4 RID: 10196
		[Token(Token = "0x40027D4")]
		[FieldOffset(Offset = "0x24")]
		public Action MinionSuccessPayoffEvent;

		// Token: 0x040027D5 RID: 10197
		[Token(Token = "0x40027D5")]
		[FieldOffset(Offset = "0x28")]
		public Action MinionSuccessAttackEvent;

		// Token: 0x040027D6 RID: 10198
		[Token(Token = "0x40027D6")]
		[FieldOffset(Offset = "0x2C")]
		public Action MinionCanceledEvent;
	}
}
