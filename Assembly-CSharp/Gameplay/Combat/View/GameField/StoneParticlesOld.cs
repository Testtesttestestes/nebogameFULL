using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000970 RID: 2416
	[Token(Token = "0x2000970")]
	public class StoneParticlesOld : MonoBehaviour, IPoolElement<StoneParticlesOld>, IStoneParticles
	{
		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003981 RID: 14721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4B")]
		public ObjectPool<StoneParticlesOld> Pool
		{
			[Token(Token = "0x6003980")]
			[Address(RVA = "0x8911", Offset = "0x8911", VA = "0x8911", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003981")]
			[Address(RVA = "0x8912", Offset = "0x8912", VA = "0x8912", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x8913", Offset = "0x8913", VA = "0x8913")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x8914", Offset = "0x8914", VA = "0x8914", Slot = "7")]
		public void SpawnParticles(StonesTypes stonesType, StoneMono.StoneSkinProvider provider)
		{
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x8915", Offset = "0x8915", VA = "0x8915", Slot = "6")]
		public void Release()
		{
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x8916", Offset = "0x8916", VA = "0x8916")]
		public StoneParticlesOld()
		{
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x8917", Offset = "0x8917", VA = "0x8917", Slot = "8")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x8918", Offset = "0x8918", VA = "0x8918", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001FD5 RID: 8149
		[Token(Token = "0x4001FD5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04001FD6 RID: 8150
		[Token(Token = "0x4001FD6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _lifeDuration;

		// Token: 0x04001FD8 RID: 8152
		[Token(Token = "0x4001FD8")]
		[FieldOffset(Offset = "0x1C")]
		private bool _isDestroyed;
	}
}
