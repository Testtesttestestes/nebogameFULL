using System;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Control;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D43 RID: 3395
	[Token(Token = "0x2000D43")]
	public abstract class CombatEventStatisticsObserver<T> : IDisposable where T : Gameplay.Combat.Events.CombatEvents
	{
		// Token: 0x140001F7 RID: 503
		// (add) Token: 0x06005324 RID: 21284 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005325 RID: 21285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F7")]
		public event Action<uint> OnUseSpell
		{
			[Token(Token = "0x6005324")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005325")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001F8 RID: 504
		// (add) Token: 0x06005326 RID: 21286 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005327 RID: 21287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F8")]
		public event Action<uint> OnUseElixir
		{
			[Token(Token = "0x6005326")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005327")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001F9 RID: 505
		// (add) Token: 0x06005328 RID: 21288 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005329 RID: 21289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F9")]
		public event Action<int, StonesTypes, bool> OnMatchStones
		{
			[Token(Token = "0x6005328")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005329")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001FA RID: 506
		// (add) Token: 0x0600532A RID: 21290 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600532B RID: 21291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FA")]
		public event Action<bool> OnTurn
		{
			[Token(Token = "0x600532A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600532B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600532C")]
		public CombatEventStatisticsObserver(T events)
		{
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600532D")]
		protected virtual void ListenEvents(T events)
		{
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600532E")]
		protected virtual void UnlistenEvents(T events)
		{
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600532F RID: 21295 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		// (set) Token: 0x06005330 RID: 21296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E9")]
		public bool LogCorrupted
		{
			[Token(Token = "0x600532F")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005330")]
			private set
			{
			}
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005331")]
		private void ClearField()
		{
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005332")]
		private void OnSpellUsed(CombatSpellData spellData)
		{
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005333")]
		private void OnSwitchTurn(TurnStates state)
		{
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005334")]
		private void OnSwapStones(int toX, int toY, int fromX, int fromY)
		{
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005335")]
		private void OnCombatGameEvents(CombatFieldChangesConvItem e)
		{
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005336")]
		public virtual void Dispose()
		{
		}

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		private const int DimX = 6;

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		private const int DimY = 6;

		// Token: 0x04002D13 RID: 11539
		[Token(Token = "0x4002D13")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _events;

		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		[FieldOffset(Offset = "0x0")]
		private readonly StonesTypes[,] _field;

		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		[FieldOffset(Offset = "0x0")]
		private TurnStates _currentState;

		// Token: 0x04002D16 RID: 11542
		[Token(Token = "0x4002D16")]
		[FieldOffset(Offset = "0x0")]
		private bool _logCorrupted;
	}
}
