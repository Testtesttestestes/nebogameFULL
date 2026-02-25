using System;
using DG.Tweening;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Helpers
{
	// Token: 0x0200048A RID: 1162
	[Token(Token = "0x200048A")]
	public class ArenaCombatGuideHelper : MonoBehaviour
	{
		// Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7A")]
		[Address(RVA = "0x6CF9", Offset = "0x6CF9", VA = "0x6CF9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x6CFA", Offset = "0x6CFA", VA = "0x6CFA")]
		private void Start()
		{
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x6CFB", Offset = "0x6CFB", VA = "0x6CFB")]
		private void Callback()
		{
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x6CFC", Offset = "0x6CFC", VA = "0x6CFC")]
		private void HandleTurnStateChangedEvent()
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x6CFD", Offset = "0x6CFD", VA = "0x6CFD")]
		public ArenaCombatGuideHelper()
		{
		}

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private OneOnOneCombatView _combatMono;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x14")]
		private Tween _delayCall;
	}
}
