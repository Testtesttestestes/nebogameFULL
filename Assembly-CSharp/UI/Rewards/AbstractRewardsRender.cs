using System;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	public abstract class AbstractRewardsRender : MonoBehaviour, IDisposable
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x5E54", Offset = "0x5E54", VA = "0x5E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x5E55", Offset = "0x5E55", VA = "0x5E55")]
			set
			{
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x5E56", Offset = "0x5E56", VA = "0x5E56", Slot = "5")]
		public virtual void RemoveAll()
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x1C8C", Offset = "0x1C8C", VA = "0x1C8C")]
		public AbstractRewardsRender SetRewards(params RewardData[] rewards)
		{
			return null;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x5E57", Offset = "0x5E57", VA = "0x5E57")]
		private void HandleRewardChanged()
		{
		}

		// Token: 0x06000B37 RID: 2871
		[Token(Token = "0x6000B37")]
		public abstract void Render();

		// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x5E58", Offset = "0x5E58", VA = "0x5E58", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x5E59", Offset = "0x5E59", VA = "0x5E59")]
		protected AbstractRewardsRender()
		{
		}

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Transform _content;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Color32 _labelColor;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Color32 _valueColor;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x1C")]
		protected RewardData[] _rewards;
	}
}
