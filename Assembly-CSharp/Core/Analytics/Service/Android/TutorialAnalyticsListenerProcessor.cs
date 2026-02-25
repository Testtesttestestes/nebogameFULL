using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Analytics.Service.Android
{
	// Token: 0x0200129C RID: 4764
	[Token(Token = "0x200129C")]
	public class TutorialAnalyticsListenerProcessor
	{
		// Token: 0x06007133 RID: 28979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007133")]
		[Address(RVA = "0xBB56", Offset = "0xBB56", VA = "0xBB56")]
		public void Process(Dictionary<string, Dictionary<string, object>> aggregator, string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007134")]
		[Address(RVA = "0xBB57", Offset = "0xBB57", VA = "0xBB57")]
		private static void BeginStep(string eventTheme, string stage, int step)
		{
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007135")]
		[Address(RVA = "0xBB58", Offset = "0xBB58", VA = "0xBB58")]
		private static void FinishStep(string eventTheme, string stage, int step, IReadOnlyDictionary<string, object> aggregated)
		{
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007136")]
		[Address(RVA = "0xBB59", Offset = "0xBB59", VA = "0xBB59")]
		private static IEnumerator UserInputRoutine(TouchCollector touchCollector)
		{
			return null;
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x6007137")]
		[Address(RVA = "0xBB5A", Offset = "0xBB5A", VA = "0xBB5A")]
		private bool TryGetCombatCollector(Dictionary<string, Dictionary<string, object>> aggregator, out CombatCollector combatCollector)
		{
			return default(bool);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007138")]
		[Address(RVA = "0xBB5B", Offset = "0xBB5B", VA = "0xBB5B")]
		public TutorialAnalyticsListenerProcessor()
		{
		}

		// Token: 0x04003B14 RID: 15124
		[Token(Token = "0x4003B14")]
		[FieldOffset(Offset = "0x8")]
		private Coroutine _currentTapRoutine;
	}
}
