using System;
using System.Runtime.CompilerServices;
using Gameplay.ThemeDuelCombat;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D45 RID: 3397
	[Token(Token = "0x2000D45")]
	public sealed class ThemeDuelCombatEventStatisticsObserver : CombatEventStatisticsObserver<ThemeDuelCombatEvents>
	{
		// Token: 0x140001FB RID: 507
		// (add) Token: 0x0600533A RID: 21306 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600533B RID: 21307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FB")]
		public event Action<long> OnScoreChanged
		{
			[Token(Token = "0x600533A")]
			[Address(RVA = "0xA0F9", Offset = "0xA0F9", VA = "0xA0F9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600533B")]
			[Address(RVA = "0xA0FA", Offset = "0xA0FA", VA = "0xA0FA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533C")]
		[Address(RVA = "0xA0FB", Offset = "0xA0FB", VA = "0xA0FB")]
		public ThemeDuelCombatEventStatisticsObserver(ThemeDuelCombatEvents events)
		{
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533D")]
		[Address(RVA = "0xA0FC", Offset = "0xA0FC", VA = "0xA0FC", Slot = "5")]
		protected override void ListenEvents(ThemeDuelCombatEvents events)
		{
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533E")]
		[Address(RVA = "0xA0FD", Offset = "0xA0FD", VA = "0xA0FD", Slot = "6")]
		protected override void UnlistenEvents(ThemeDuelCombatEvents events)
		{
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533F")]
		[Address(RVA = "0xA0FE", Offset = "0xA0FE", VA = "0xA0FE")]
		private void HandleThemeScoreChangedEvent(ProtoThemeScoreChangedEvt msg)
		{
		}

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x28")]
		private long _score;
	}
}
