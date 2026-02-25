using System;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	public abstract class AbstractRewardRender : MonoBehaviour, IDisposable
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000177")]
		public AbstractRewardRender RewardRender
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x5E47", Offset = "0x5E47", VA = "0x5E47")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x5E48", Offset = "0x5E48", VA = "0x5E48", Slot = "5")]
		public virtual AbstractRewardRender Render(RewardsContainer container, RewardData reward)
		{
			return null;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		public Color32 LabelColor
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x5E49", Offset = "0x5E49", VA = "0x5E49")]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x5E4A", Offset = "0x5E4A", VA = "0x5E4A")]
			set
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00003B40 File Offset: 0x00001D40
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		public Color32 ValueColor
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x5E4B", Offset = "0x5E4B", VA = "0x5E4B")]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x5E4C", Offset = "0x5E4C", VA = "0x5E4C")]
			set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		public virtual RewardData Reward
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x5E4D", Offset = "0x5E4D", VA = "0x5E4D", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x5E4E", Offset = "0x5E4E", VA = "0x5E4E", Slot = "7")]
			protected set
			{
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x5E4F", Offset = "0x5E4F", VA = "0x5E4F", Slot = "8")]
		protected virtual void HandleRewardChanged()
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x5E50", Offset = "0x5E50", VA = "0x5E50", Slot = "9")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x5E51", Offset = "0x5E51", VA = "0x5E51")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x5E52", Offset = "0x5E52", VA = "0x5E52")]
		protected void Start()
		{
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x5E53", Offset = "0x5E53", VA = "0x5E53")]
		protected AbstractRewardRender()
		{
		}

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		protected RewardsContainer _container;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public AbstractRewardRender _rewardRender;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public RewardsRender RootRewardsRender;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x1C")]
		protected RewardData _reward;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x20")]
		private Color32 _labelColor;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x24")]
		private Color32 _valueColor;
	}
}
