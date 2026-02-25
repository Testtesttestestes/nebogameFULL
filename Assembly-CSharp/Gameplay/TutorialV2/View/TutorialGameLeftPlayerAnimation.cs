using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public class TutorialGameLeftPlayerAnimation : MonoBehaviour
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x6AE0", Offset = "0x6AE0", VA = "0x6AE0")]
		private void BattleToIdleAnimationCompleteEvent(GameAnimationView animComponent)
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x6AE1", Offset = "0x6AE1", VA = "0x6AE1")]
		private void IdleToBattleAnimationCompleteEvent(GameAnimationView animComponent)
		{
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x6AE2", Offset = "0x6AE2", VA = "0x6AE2")]
		public void ToBattle()
		{
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x6AE3", Offset = "0x6AE3", VA = "0x6AE3")]
		public void ToIdle()
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001945")]
		[Address(RVA = "0x6AE4", Offset = "0x6AE4", VA = "0x6AE4")]
		public TutorialGameLeftPlayerAnimation()
		{
		}

		// Token: 0x04000D5A RID: 3418
		[Token(Token = "0x4000D5A")]
		public const string IDLE_TO_BATTLE = "idle_to_battle";

		// Token: 0x04000D5B RID: 3419
		[Token(Token = "0x4000D5B")]
		public const string BATTLE_TO_IDLE = "battle_to_idle";

		// Token: 0x04000D5C RID: 3420
		[Token(Token = "0x4000D5C")]
		public const string IDLE = "1idle";

		// Token: 0x04000D5D RID: 3421
		[Token(Token = "0x4000D5D")]
		public const string BATTLE = "battle";
	}
}
