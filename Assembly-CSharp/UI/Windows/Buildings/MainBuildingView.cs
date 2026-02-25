using System;
using AssetContent;
using AssetContent.Loaders;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	public abstract class MainBuildingView<TIsle> : MonoBehaviour
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700025D")]
		public GameAssetViewRawImage TreeBg
		{
			[Token(Token = "0x600104A")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700025E")]
		public GameRawImageLoader IsleBg
		{
			[Token(Token = "0x600104B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600104C RID: 4172
		[Token(Token = "0x600104C")]
		public abstract void Init(TIsle isle);

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700025F")]
		public BaseBuildingItemView[] BuildingItems
		{
			[Token(Token = "0x600104D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600104E")]
		public BaseBuildingItemView GetBuildingView(uint typeId)
		{
			return null;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104F")]
		protected MainBuildingView()
		{
		}

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected BaseBuildingItemView[] _buildingItems;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameRawImageLoader _isleBg;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameAssetViewRawImage _treeBg;
	}
}
