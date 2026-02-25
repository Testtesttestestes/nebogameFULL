using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200096F RID: 2415
	[Token(Token = "0x200096F")]
	public class StoneParticlesGray : MonoBehaviour, IPoolElement<StoneParticlesGray>, IStoneParticles
	{
		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4A")]
		public ObjectPool<StoneParticlesGray> Pool
		{
			[Token(Token = "0x6003978")]
			[Address(RVA = "0x8909", Offset = "0x8909", VA = "0x8909", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003979")]
			[Address(RVA = "0x890A", Offset = "0x890A", VA = "0x890A", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x890B", Offset = "0x890B", VA = "0x890B")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x890C", Offset = "0x890C", VA = "0x890C", Slot = "7")]
		public void SpawnParticles(StonesTypes stonesType, StoneMono.StoneSkinProvider provider)
		{
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x890D", Offset = "0x890D", VA = "0x890D", Slot = "6")]
		public void Release()
		{
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x890E", Offset = "0x890E", VA = "0x890E")]
		public StoneParticlesGray()
		{
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x890F", Offset = "0x890F", VA = "0x890F", Slot = "8")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x8910", Offset = "0x8910", VA = "0x8910", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001FD2 RID: 8146
		[Token(Token = "0x4001FD2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04001FD3 RID: 8147
		[Token(Token = "0x4001FD3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _lifeDuration;
	}
}
