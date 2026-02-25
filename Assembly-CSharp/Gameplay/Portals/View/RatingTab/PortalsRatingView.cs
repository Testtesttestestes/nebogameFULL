using System;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Portals.View.RatingTab
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	public class PortalsRatingView : MonoBehaviour
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000697")]
		public PortalRatingOSAView UsersOSAView
		{
			[Token(Token = "0x600236A")]
			[Address(RVA = "0x74BE", Offset = "0x74BE", VA = "0x74BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000698")]
		public MyPortalRatingView MyRatingView
		{
			[Token(Token = "0x600236B")]
			[Address(RVA = "0x74BF", Offset = "0x74BF", VA = "0x74BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x74C0", Offset = "0x74C0", VA = "0x74C0")]
		public void Init()
		{
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x1BD9", Offset = "0x1BD9", VA = "0x1BD9")]
		public void SetVisibleReceivingData(bool value)
		{
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x74C1", Offset = "0x74C1", VA = "0x74C1")]
		public PortalsRatingView()
		{
		}

		// Token: 0x04001378 RID: 4984
		[Token(Token = "0x4001378")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PortalRatingOSAView _usersOSAView;

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MyPortalRatingView _myRatingView;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _receivingDataView;
	}
}
