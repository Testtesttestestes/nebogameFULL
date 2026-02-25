using System;
using System.Collections.Generic;
using Core.Data.User;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000961 RID: 2401
	[Token(Token = "0x2000961")]
	[Serializable]
	public class CombatAnimationsMode
	{
		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B37")]
		public Transform Parent
		{
			[Token(Token = "0x60038FB")]
			[Address(RVA = "0x8898", Offset = "0x8898", VA = "0x8898")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x8899", Offset = "0x8899", VA = "0x8899")]
		public void Init(UserSettings settings)
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x889A", Offset = "0x889A", VA = "0x889A")]
		public IPool<IStoneParticles> CreateParticlesPool(Transform parent)
		{
			return null;
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x889B", Offset = "0x889B", VA = "0x889B")]
		public GameFieldMono.ImpactDelegate GetImpactFunction()
		{
			return null;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x889C", Offset = "0x889C", VA = "0x889C")]
		private void HandleImpact(IEnumerable<StoneMono> stones, StoneMono[,] allStones)
		{
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003900")]
		[Address(RVA = "0x889D", Offset = "0x889D", VA = "0x889D")]
		private void HandleImpactEmpty(IEnumerable<StoneMono> stones, StoneMono[,] allStones)
		{
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003901")]
		[Address(RVA = "0x889E", Offset = "0x889E", VA = "0x889E")]
		private void ReleaseCallback(Component component)
		{
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003902")]
		[Address(RVA = "0x889F", Offset = "0x889F", VA = "0x889F")]
		public CombatAnimationsMode()
		{
		}

		// Token: 0x04001F7E RID: 8062
		[Token(Token = "0x4001F7E")]
		[FieldOffset(Offset = "0x8")]
		private UserSettings _settings;

		// Token: 0x04001F7F RID: 8063
		[Token(Token = "0x4001F7F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private StoneParticles _animatedParticles;

		// Token: 0x04001F80 RID: 8064
		[Token(Token = "0x4001F80")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StoneParticlesOld _oldParticles;

		// Token: 0x04001F81 RID: 8065
		[Token(Token = "0x4001F81")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _parent;
	}
}
