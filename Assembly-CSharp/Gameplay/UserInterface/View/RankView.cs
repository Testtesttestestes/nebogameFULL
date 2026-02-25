using System;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	public class RankView : MonoBehaviour
	{
		// Token: 0x0600167D RID: 5757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x683E", Offset = "0x683E", VA = "0x683E")]
		public void SetRank(RankTypes value)
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x683F", Offset = "0x683F", VA = "0x683F")]
		public RankView()
		{
		}

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RankView.RankImages[] _rankImages;

		// Token: 0x020003C0 RID: 960
		[Token(Token = "0x20003C0")]
		[Serializable]
		public class RankImages
		{
			// Token: 0x0600167F RID: 5759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600167F")]
			[Address(RVA = "0x6840", Offset = "0x6840", VA = "0x6840")]
			public RankImages()
			{
			}

			// Token: 0x04000BD4 RID: 3028
			[Token(Token = "0x4000BD4")]
			[FieldOffset(Offset = "0x8")]
			public RankTypes Rank;

			// Token: 0x04000BD5 RID: 3029
			[Token(Token = "0x4000BD5")]
			[FieldOffset(Offset = "0xC")]
			public Image Image;
		}
	}
}
