using System;
using AssetContent;
using AssetContent.Loaders;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	public abstract class MainBuildingView2<TIsle> : MonoBehaviour
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000260")]
		public GameAssetViewRawImage TreeBg
		{
			[Token(Token = "0x6001050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000261")]
		public GameRawImageLoader IsleBg
		{
			[Token(Token = "0x6001051")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001052 RID: 4178
		[Token(Token = "0x6001052")]
		public abstract void Init(TIsle isle);

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000262")]
		public BaseBuildingItemView2[] BuildingItems
		{
			[Token(Token = "0x6001053")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001054")]
		public BaseBuildingItemView2 GetBuildingView(uint typeId)
		{
			return null;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001055")]
		protected MainBuildingView2()
		{
		}

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected BaseBuildingItemView2[] _buildingItems;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameRawImageLoader _isleBg;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameAssetViewRawImage _treeBg;
	}
}
