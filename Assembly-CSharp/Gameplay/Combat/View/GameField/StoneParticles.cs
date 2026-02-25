using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200096E RID: 2414
	[Token(Token = "0x200096E")]
	public class StoneParticles : MonoBehaviour, IPoolElement<StoneParticles>, IStoneParticles
	{
		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003971 RID: 14705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B49")]
		public ObjectPool<StoneParticles> Pool
		{
			[Token(Token = "0x6003970")]
			[Address(RVA = "0x8901", Offset = "0x8901", VA = "0x8901", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003971")]
			[Address(RVA = "0x8902", Offset = "0x8902", VA = "0x8902", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x8903", Offset = "0x8903", VA = "0x8903")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x8904", Offset = "0x8904", VA = "0x8904", Slot = "7")]
		public void SpawnParticles(StonesTypes stonesType, StoneMono.StoneSkinProvider provider)
		{
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x8905", Offset = "0x8905", VA = "0x8905", Slot = "6")]
		public void Release()
		{
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x8906", Offset = "0x8906", VA = "0x8906")]
		public StoneParticles()
		{
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x8907", Offset = "0x8907", VA = "0x8907", Slot = "8")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x8908", Offset = "0x8908", VA = "0x8908", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ParticleSystem _shards;

		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _particles;

		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _particles2;

		// Token: 0x04001FCC RID: 8140
		[Token(Token = "0x4001FCC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ParticleSystem _whiteSmoke;

		// Token: 0x04001FCD RID: 8141
		[Token(Token = "0x4001FCD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _waves;

		// Token: 0x04001FCE RID: 8142
		[Token(Token = "0x4001FCE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ParticleSystem _outline;

		// Token: 0x04001FCF RID: 8143
		[Token(Token = "0x4001FCF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _duration;

		// Token: 0x04001FD1 RID: 8145
		[Token(Token = "0x4001FD1")]
		[FieldOffset(Offset = "0x30")]
		private bool _isDestroyed;
	}
}
